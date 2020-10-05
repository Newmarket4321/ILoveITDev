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
    public partial class SearchRoll : Form
    {
        static string tpin ="";
        DateTime DateFrom ;
        DateTime DateTo ;
        string sDateFrom, sDateTo;
        decimal nAmount;
        //Testing search
        public SearchRoll()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "")
            {
                DataTable table = new DataTable();
                tpin = textBox1.Text;

                tpin = tpin.ToUpper();
                table = TXM.Run(@"select c.roll_no, b.name1, b.name2, c.str_no, c.str_name, c.unit_no, a.bill_payer_flg, a.expiry_date
                    from client_acct a
left
join client b on b.id = a.cli_id_fk
left
join acct c on c.id = a.acct_id_fk
where a.pin = @tpin", tpin);

                Text = "Search";
                Report r = new Report(Text, table);
                r.Show();

                Close();
            }
            else
            {
                DataTable table = new DataTable();
                sDateFrom = dtpFrom.Value.Date.ToString();
                sDateTo = dtpTo.Value.Date.ToString();
                DateFrom = DateTime.Parse(sDateFrom).Date;
                DateTo = DateTime.Parse(sDateTo).Date;
                nAmount = Convert.ToDecimal(txtAmount.Text) ;
                txtAmount.Text = (Convert.ToDecimal(txtAmount.Text) ).ToString();
                
                if (nAmount > 0)
                {
                    table = TXM.Run(@"select b.roll_no, a.amt , a.tran_date ,a.create_date
from txmadm.pymt a 
left join acct b on b.id = a.acct_id_fk where a.tran_date >= @DateFrom and a.tran_date <= @DateTo and a.amt =@nAmount ", DateFrom, DateTo, nAmount);
                }
                else
                {
                    table = TXM.Run(@"select b.roll_no, a.amt , a.tran_date ,a.create_date
from txmadm.pymt a 
left join acct b on b.id = a.acct_id_fk where a.tran_date >= @DateFrom and a.tran_date <= @DateTo ", DateFrom, DateTo);
                }
                Text = "Search";
                Report r = new Report(Text, table);
                r.Show();

                Close();
            }
        }
    }
}
