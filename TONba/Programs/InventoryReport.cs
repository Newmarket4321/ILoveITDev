using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class InventoryReport : Form
    {
        //  static string environment = "PD";
        static string environment = "PY";
        static string schema = Core.getSchema(environment);
        string localTable = (environment == "PD" ? "log" : "logtest");

        public InventoryReport()
        {
            InitializeComponent();

            try
            {
                Text = SQL.RunString("select description from programs where code=@CODE", Name);
            }
            catch
            {

            }
        }

        private void Visa_Load(object sender, EventArgs e)
        {
            DataTable dt = SQL.Run(@"
use inventorymanagement;

select
ltrim(empno) as 'Employee',
'' as 'Division',
ltrim(woid) as 'Work Order',
ltrim(itemno) as 'Item',
qty as 'Quantity',
cost as 'Cost',
date as 'DateTemp',
'' as Date,
jde_user,
jde_batch,
jde_trans,
jde_line,
'' as Status

from " + localTable + @"
order by id desc");



            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["Division"] = Oracle.RunString("select MCDL01 from " + schema + ".F0006 join " + schema + ".F060116 on MCMCU = YAMCU where YAAN8 = @EMPNO", dt.Rows[i]["Employee"].ToString()).Trim();
                dt.Rows[i]["Employee"] = dt.Rows[i]["Employee"].ToString() + " - " + Oracle.RunString("select YAALPH from CRPDTA.F060116 where YAAN8 = @EMPNO", dt.Rows[i]["Employee"].ToString()).Trim();
                dt.Rows[i]["Work Order"] = dt.Rows[i]["Work Order"].ToString() + " - " + Oracle.RunString("select WADL01 from CRPDTA.F4801 where WADOCO = @WOID", dt.Rows[i]["Work Order"].ToString()).Trim();
                dt.Rows[i]["Item"] = dt.Rows[i]["Item"].ToString() + " - " + Oracle.RunString("select IMDSC1 from CRPDTA.F4101 where IMITM = @ITEMNO", dt.Rows[i]["Item"].ToString()).Trim();
                dt.Rows[i]["Date"] = DateTime.Parse(dt.Rows[i]["DateTemp"].ToString()).ToString("F");

                string status = "";

                try
                {
                    string user = dt.Rows[i]["jde_user"].ToString();
                    int batch = int.Parse(dt.Rows[i]["jde_batch"].ToString());
                    int trans = int.Parse(dt.Rows[i]["jde_trans"].ToString());
                    int line = int.Parse(dt.Rows[i]["jde_line"].ToString());

                    status = Oracle.RunString("select SZEDSP from " + schema + ".F3111Z1 where trim(SZEDBT)=@BAT and trim(SZEDTN)=@TRANS and SZEDLN=@LINE and trim(SZEDUS)=@USR", batch, trans, line, user);

                    if (status.Trim() == "Y")
                        status = "Processed";
                    else if (status.Trim() == "N")
                        status = "Error";
                    else
                        status = "Awaiting processing";
                }
                catch(Exception)
                {
                    status = "Cleared";
                }

                dt.Rows[i]["Status"] = status;
            }

            dt.Columns.Remove("DateTemp");
            dt.Columns.Remove("jde_user");
            dt.Columns.Remove("jde_batch");
            dt.Columns.Remove("jde_trans");
            dt.Columns.Remove("jde_line");

            Report r = new Report("Inventory Report", dt);
            r.Show();

            Close();
        }
    }
}
