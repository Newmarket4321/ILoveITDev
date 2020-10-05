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
    public partial class AllRollNumbers : Form
    {
        public AllRollNumbers()
        {
            InitializeComponent();
            
            SQL sql = new SQL("select * from programs where code=@CODE");
            sql.AddParameter("@CODE", Name);
            DataTable dt = sql.Run();

            Text = dt.Rows[0]["Description"].ToString();
        }

        private void Visa_Load(object sender, EventArgs e)
        {
            DataTable dt = Vailtech.Run(@"
select * from vailtech.tx_roll order by roll_no
");

            Report r = new Report(Text, dt);
            r.Show();

            Close();
        }
    }
}
