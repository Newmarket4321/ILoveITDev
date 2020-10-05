using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace I_IT
{
    public partial class CashReceipts : Form
    {
        public CashReceipts()
        {
            InitializeComponent();
            getCashRecipts();
        }

        public void getCashRecipts()
        {

            DataTable table = new DataTable();
            table = TXM.Run(@"select txmadm.TX_CASH_ENTRIES_ARCHIVE.Receipt_NO, txmadm.TX_CASH_ENTRIES_ARCHIVE.Roll_NO, txmadm.TX_CASH_ENTRIES_ARCHIVE.ACTIVITY_NO, client.name1, txmadm.TX_CASH_ENTRIES_ARCHIVE.PAYMENT_AMT, txmadm.TX_CASH_ENTRIES_ARCHIVE.PAYMENT_DATE from txmadm.TX_CASH_ENTRIES_ARCHIVE
       LEFT JOIN acct on ACCT.ROLL_NO =  CONCAT('1948', txmadm.TX_CASH_ENTRIES_ARCHIVE.ROLL_NO)
                                LEFT JOIN client_acct ON ACCT.ID = client_acct.ACCT_ID_FK  AND client_acct.ACS_CD_FK ='OWNER'
                                LEFT JOIN client on client_acct.CLI_ID_FK = client.id where client_type = 'O'");
          
            Text = "POS Summary";
            Report r = new Report(Text, table);
            r.Show();
            
            Close();
        }

    }
}
