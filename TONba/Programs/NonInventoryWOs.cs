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
    public partial class NonInventoryWOs : Form
    {
        public NonInventoryWOs()
        {
            InitializeComponent();
            
            SQL sql = new SQL("select * from programs where code=@CODE");
            sql.AddParameter("@CODE", Name);
            DataTable dt = sql.Run();

            Text = dt.Rows[0]["Description"].ToString();
        }

        private void Visa_Load(object sender, EventArgs e)
        {
            Oracle ora = new Oracle(@"
select wadoco, watyps, wadl01, wamcu, wammcu, wasrst
from CRPDTA.F4801 where WASRST between '50' and '85'
and trim(WAMMCU) <> '1001'
order by wadoco desc
");
            Report r = new Report(Text, ora.Run());
            r.Show();

            Close();
        }
    }
}
