using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class ProgramUsage : Form
    {
        public ProgramUsage()
        {
            InitializeComponent();

            SQL sql = new SQL(@"
SELECT Description as 'Program', count(description) as 'Uses in last 30 days'
  FROM Log
  where event = 'Open program'
  and timestamp > @DATE
  and username <> 'Graeme Smyth'
  group by Description
  order by count(description) desc
");
            sql.AddParameter("@DATE", DateTime.Now.AddMonths(-1));
            DataTable dt = sql.Run();

            Report r = new Report(Text, dt);
            r.Show();

            Close();
        }
    }
}
