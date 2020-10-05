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
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();

            SQL sql = new SQL("select * from log where timestamp >= @DATE order by id desc");
            sql.AddParameter("@DATE", DateTime.Now.AddDays(-14));
            DataTable dt = sql.Run();

            Report r = new Report(Text, dt);
            r.Show();

            Close();
        }
    }
}
