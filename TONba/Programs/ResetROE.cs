using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class ResetROE : Form
    {
        public ResetROE()
        {
            InitializeComponent();

            GetString box = new GetString("Employee ID");
            box.ShowDialog();

            if (box.r != "")
            {
                int empID = -1;

                int.TryParse(box.r, out empID);

                if (empID <= 0)
                {
                    MessageBox.Show("Employee ID not understood. Unable to parse.");
                    return;
                }

                Oracle ora = new Oracle("select JFPCT# from CRPDTA.F0717 where JFAN8=@EMPID order by JFPPED desc");
                ora.AddParameter("@EMPID", empID);
                DataTable dt = ora.Run();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No ROE records found for " + empID + ".");
                    return;
                }

                string PCT = dt.Rows[0]["JFPCT#"].ToString();

                string name = Oracle.Run("select YAALPH from CRPDTA.F060116 where YAAN8=" + empID).Rows[0]["YAALPH"].ToString().Trim();

                if (Core.lookupMessageBox("Are you sure?", empID + " is " + name + ". Is this correct?", "Yes", "No") == "No")
                {
                    return;
                }

                //if(dt.Rows[0]["JFPCT#"].ToString().Trim() == "0")
                //{
                //    MessageBox.Show("ROE record found, however not needing reset.");
                //    return;
                //}

                try
                {
                    ora = new Oracle("update CRPDTA.F0717 set JFROEN=@ROEN, JFPCT#=0 where JFPCT#=@PCT");
                    ora.AddParameter("@ROEN", "           ");
                    ora.AddParameter("@PCT", PCT);
                    ora.Run();

                    ora = new Oracle("update CRPDTA.F06176 set YSDTM=0, YSPCT#=0, YSROEN=@ROEN where YSPCT#=@PCT");
                    ora.AddParameter("@ROEN", "           ");
                    ora.AddParameter("@PCT", PCT);
                    ora.Run();
                }
                catch(Exception e)
                {
                    if (e.Message.Contains("unique constraint"))
                    {
                        MessageBox.Show("A blank ROE for this employee already exists." + Environment.NewLine
                            + Environment.NewLine
                            + "Within JDE, please delete the existing blank ROE for this employee." + Environment.NewLine
                            + "Then, come back and try to reset this ROE again.");

                        Close();
                        return;
                    }
                    else
                        throw e;
                }

                MessageBox.Show("ROE has been reset!");
            }

            Close();
        }
    }
}
