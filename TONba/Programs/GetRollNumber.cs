using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT.Programs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = TXM.Run(@"select a.pin, a.bill_payer_flg, a.expiry_date, b.name1, b.name2, C.ROLL_NO, C.STR_NO, C.STR_NAME, C.uNIT_NO from client_acct a
                             LEFT JOIN client b on b.id = a.cli_id_fk LEFT JOIN ACCT C ON C.ID = A.ACCT_ID_FK where a.pin = 'VXCB5XN2'");
            Text = "Client Information";
            Report r = new Report(Text, table);
            r.Show();

            Close();
        }
    }
}
