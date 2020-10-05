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
    public partial class TrainingReport : Form
    {
        public TrainingReport()
        {
            InitializeComponent();
            
            SQL sql = new SQL("select * from programs where code=@CODE");
            sql.AddParameter("@CODE", Name);
            DataTable dt = sql.Run();

            Text = dt.Rows[0]["Description"].ToString();
        }

        private void Visa_Load(object sender, EventArgs e)
        {
            DataTable dt = Oracle.Run(@"
select
YAAN8 as ""Employee Number"",
YAALPH as ""Employee Name"",
u.DRDL01 as ""Employee Status"",
u3.DRDL01 as ""Job Type"",
trim(e.YAMCU) as ""Business Unit"",
MCDL01 as ""Department"",
u4.DRDL01 as ""Commission"",
T2DL01 as ""Type"",
case when T3EFT is null then '0' else trim(T3EFT) end as ""Training Date"",
u2.DRDL01 as ""Training"",
T3RMK as ""Remark"",
T3RMK2 as ""Remark 2""

from CRPDTA.F060116 e
join CRPDTA.F00092 t on t.T3SBN1 = e.YAAN8
join CRPDTA.F00091 x on x.T2SDB = t.T3SDB and x.T2TYDT = t.T3TYDT
join CRPDTA.F0006 b on trim(e.YAMCU) = trim(b.MCMCU)
left join CRPCTL.F0005 u on trim(u.DRKY) = trim(e.YAPAST)
left join CRPCTL.F0005 u2 on trim(u2.DRKY) = trim(t.T3KY)
left join CRPCTL.F0005 u3 on trim(u3.DRKY) = trim(e.YAJBCD)
left join CRPCTL.F0005 u4 on trim(u4.DRKY) = trim(b.MCRP04)

where (trim(u.DRSY) = '06' or u.DRSY is null)
and (trim(u.DRRT) = 'PS' or u.DRSY is null)
and (trim(u2.DRSY) = '55' or u2.DRSY is null)
and (trim(u2.DRRT) = 'TR' or u2.DRSY is null)
and (trim(u3.DRSY) = '06' or u3.DRSY is null)
and (trim(u3.DRRT) = 'G' or u3.DRSY is null)
and (trim(u4.DRSY) = '00' or u4.DRSY is null)
and (trim(u4.DRRT) = '04' or u4.DRSY is null)
and trim(T3SDB) = 'E'
and trim(T3TYDT) in ('C', 'E', 'L', 'T', 'TS')

order by T3EFT desc
");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    dt.Rows[i]["Training Date"] = Core.JDEToDate(dt.Rows[i]["Training Date"].ToString());
                }
                catch
                {
                    dt.Rows[i]["Training Date"] = new DateTime(1900, 1, 1);
                }
            }

            Report r = new Report(Text, dt);
            r.Show();

            Close();
        }
    }
}
