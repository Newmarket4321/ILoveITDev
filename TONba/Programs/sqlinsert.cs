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
    public partial class sqlinsert : Form
    {
        public sqlinsert()
        {
            InitializeComponent();
            getData();
        }


        public string getAcctID(string rollNumber)
        {
            DataTable rowID = new DataTable();
            rowID = TXM.Run("SELECT ID from ACCT where ROLL_NO = @rollNumber", rollNumber);
            return rowID.Rows[0][0].ToString();
        }

        public string getBatchNO()
        {
            DataTable batch = new DataTable();
            batch = TXM.Run("select pymt_batch_no_seq.nextval from dual");
            return batch.Rows[0][0].ToString();
        }
        public void getData()
        {
            DataTable table = new DataTable();
            table = TXM.Run(@"SELECT * FROM temppymt where create_date = TO_DATE('20-01-08')");
            foreach (DataRow dtRow in table.Rows)
            {
                TXM ora = new TXM("Insert Into pymt (ID, ACCT_ID_FK, AMT, PYMTS_CD_FK, SUSPENSE_FLG, BATCH_NO, SEQ_NO, TRAN_NO, CREATE_DATE, TRAN_DATE, PULL_FLG, OVERPAY_FLG, TX_SALE_FLG, PYMTM_CD_FK) Values (@ID, @ACCT_ID_FK, @AMT, 'CSH', 'N', @BATCH_NO, @SEQ_NO, 1, @CREATE_DATE, @TRAN_DATE, 'N', 'N', 'N', 'CHQ')");
                ora.AddParameter("@ID", getAcctID("1948" + dtRow["ROLL_NO"].ToString()));
                //ora.AddParameter("@ACCT_ID_FK", dtRow["ACCT_ID_FK"]);
                //ora.AddParameter("@AMT", dtRow["AMT"]);
                ora.AddParameter("@BATCH_NO", getBatchNO());
                ora.AddParameter("@SEQ_NO", dtRow["SEQ_NO"]);
                //ora.AddParameter("@CREATE_DATE", dtRow["CREATE_DATE"]);
                ora.AddParameter("@TRAN_DATE", dtRow["TRAN_DATE"]);
               // ora.AddParameter("@PYMTS_CD_FK", dtRow["PYMTS_CD_FK"]);
                ora.Run();
            }
        }

        public void getCashData()
        {
            var sequenceNo = 0;
            var batchNo = getBatchNO();
            DataTable table = new DataTable();
            table = TXM.Run(@"SELECT * FROM TX_CASH_ENTRIES");
            foreach (DataRow dtRow in table.Rows)
            {
                sequenceNo++;
                TXM ora = new TXM("Insert Into pymt (ID, ACCT_ID_FK, AMT, PYMTS_CD_FK, SUSPENSE_FLG, BATCH_NO, SEQ_NO, TRAN_NO, CREATE_DATE, TRAN_DATE, PULL_FLG, OVERPAY_FLG, TX_SALE_FLG, PYMTM_CD_FK) Values (@ID, @ACCT_ID_FK, @AMT, 'CSH', 'N', @BATCH_NO, @SEQ_NO, 1, @CREATE_DATE, @TRAN_DATE, 'N', 'N', 'N', 'CHQ')");
                ora.AddParameter("@ID", getAcctID(dtRow["ROLL_NO"].ToString()));
                //ora.AddParameter("@ACCT_ID_FK", dtRow["ACCT_ID_FK"]);
                //ora.AddParameter("@AMT", dtRow["AMT"]);
                ora.AddParameter("@BATCH_NO", dtRow["BATCH_NO"]);
                ora.AddParameter("@SEQ_NO", dtRow["SEQ_NO"]);
                ora.AddParameter("@CREATE_DATE", dtRow["CREATE_DATE"]);
                ora.AddParameter("@TRAN_DATE", dtRow["PAYMENT_DATE"]);
                // ora.AddParameter("@PYMTS_CD_FK", dtRow["PYMTS_CD_FK"]);
                ora.Run();
            }
        }

        private void btnCashEntries_Click(object sender, EventArgs e)
        {

        }

        private void btnPostDated_Click(object sender, EventArgs e)
        {
            getData();
        }
    }
}
