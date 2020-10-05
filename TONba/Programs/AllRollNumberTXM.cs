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
    public partial class AllRollNumberTXM : Form
    {
        public AllRollNumberTXM()
        {
            InitializeComponent();
            getRollNumbers();
        }

        public void getRollNumbers()
        {
            DataTable table = new DataTable();
            table = TXM.Run(@"select * from ACCT");
            Report r = new Report(Text, table);
            r.Show();

            Close();
        }
    }
}
