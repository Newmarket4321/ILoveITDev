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
    public partial class ROACount : Form
    {
        public ROACount()
        {
            InitializeComponent();
            
            SQL sql = new SQL("select * from programs where code=@CODE");
            sql.AddParameter("@CODE", Name);
            DataTable dt = sql.Run();

            Text = dt.Rows[0]["Description"].ToString();
        }

        private void Visa_Load(object sender, EventArgs e)
        {
            SQL sql = new SQL(@"
use ROA;

select year(StartDate) as Year, OwnerName as Owner, count(*) as Count from ROA.dbo.Applications
group by YEAR(startdate), ownername
order by year(StartDate), OwnerName");
            //Core.export(Text, sql.Run());
            Report r = new Report(Text, sql.Run());
            r.Show();

            Close();
        }

        //private void z(Delegate method)
        //{
        //    MethodInvoker mi = new MethodInvoker(method);
        //    mi.BeginInvoke(null, null);
        //}
    }
}
