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
    public partial class ROAReport : Form
    {
        public ROAReport()
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

select
a.ID,
ApplicantName as Applicant,
OwnerName as Owner,
StreetNoFrom as 'Street Number From',
StreetNoTo as 'Street Number To',
s1.Description as 'Street Name',
StartDate as 'Start Date',
CompletionDate as 'Completion Date'

from Applications a
left join Streets s1 on a.StreetSiteID = s1.Code
order by ID");
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
