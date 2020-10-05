using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class BuildingPermitDelete : Form
    {
        public BuildingPermitDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CityView cv = new CityView("select * from sysadmin.building_permits where application_number = @PERMIT");
                cv.AddParameter("@PERMIT", textBox1.Text);
                DataTable dt = cv.Run();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Permit not found.");
                    return;
                }

                string param = "";

                for (int i = 0; i < dt.Columns.Count; i++)
                    param += (i != 0 ? ", " : "") + "@VAR" + i;

                cv = new CityView("insert into sysadmin.building_permits_hist values (" + param + ", @DTIME, @DNAME, @DCOMP, @DDATE)");
                for (int i = 0; i < dt.Columns.Count; i++)
                    cv.AddParameter("@VAR" + i, dt.Rows[0][i].ToString());
                cv.AddParameter("@DTIME", DateTime.Now.ToString());
                cv.AddParameter("@DNAME", Environment.UserName);
                cv.AddParameter("@DCOMP", Environment.MachineName);
                cv.AddParameter("@DDATE", DateTime.Now.ToString());
                cv.Run();

                cv = new CityView("delete from sysadmin.building_permits where application_number = @PERMIT");
                cv.AddParameter("@PERMIT", textBox1.Text);
                cv.Run();

                MessageBox.Show("Permit deleted.");
            }
            catch(Exception e2)
            {
                MessageBox.Show("Error:" + e2.Message);
            }
        }
    }
}
