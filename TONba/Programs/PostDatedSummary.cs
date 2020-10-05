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
    public partial class PostDatedSummary : Form
    {
        public PostDatedSummary()
        {
            InitializeComponent();
            getPostDatedCheques();
        }

        public void getPostDatedCheques()
        {

            DataTable table = new DataTable();
            
            table = TXM.Run(@"select txmadm.temppymt.ID, txmadm.ACCT.roll_no, txmadm.client.Name1, txmadm.temppymt.amt, txmadm.temppymt.suspense_flg, txmadm.temppymt.batch_no,
                                txmadm.temppymt.seq_no, txmadm.temppymt.tran_no, txmadm.temppymt.create_date, txmadm.temppymt.tran_date, create_userid AS Newmarket_Batch
                                from txmadm.temppymt 
                                LEFT JOIN acct on ACCT.ID =  txmadm.temppymt.ACCT_ID_FK
                                LEFT JOIN client_acct ON ACCT.ID = client_acct.ACCT_ID_FK  AND client_acct.ACS_CD_FK ='OWNER'
                                LEFT JOIN client on client_acct.CLI_ID_FK = client.id where client_type = 'O'");

            Text = "Post Dated Cheque Summary";
 

            Report r = new Report(Text, table);
            r.Show();

            Close();
        }
    }
}
