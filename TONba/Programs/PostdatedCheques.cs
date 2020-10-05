using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class PostdatedCheques : Form
    {
        public int entryNumber = 0;
        public List<string> rowNumber = new List<string>();
        private DataTable table;
        private DataRow row;
        private DataTable itemsTable;
        private Boolean manual = false;
       

        public PostdatedCheques()
        {
            
            table = new DataTable();
            itemsTable = new DataTable();
            DataColumn myDataColumn;

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Double");
            myDataColumn.ColumnName = "AMT";
            itemsTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.DateTime");
            myDataColumn.ColumnName = "CREATE_DATE";
            itemsTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.DateTime");
            myDataColumn.ColumnName = "TRAN_DATE";
            itemsTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "Roll_Number";
            itemsTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Int32");
            myDataColumn.ColumnName = "ACCT_ID_FK";
            itemsTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = " PYMTM_CD_FK";
            itemsTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "CREATE_USERID";
            itemsTable.Columns.Add(myDataColumn);



            InitializeComponent();
            itemsPanel.VerticalScroll.Visible = false;

            newLine();
            getLabels();

           // OracleConnection con;
            Connect();
            

            //void Close()
            //{
            //    con.Close();
            //    con.Dispose();
            //}   
        }

        public void getLabels()
        {
            Label lblEntry = new Label();
            Label lblRoll = new Label();
            Label lblActivity = new Label();
            Label lblOwner = new Label();
            Label lblDate = new Label();
            Label lblAmount = new Label();

            lblEntry.Text = "Entry #";
            lblEntry.Width = 40;
            lblEntry.Location = new Point(0, 0);
            itemsPanel.Controls.Add(lblEntry);

            lblAmount.Text = "Amount";
            lblAmount.Location = new Point(45, 0);
            lblAmount.Width = 100;
            itemsPanel.Controls.Add(lblAmount);

            lblRoll.Text = "Roll Number";
            lblRoll.Width = 120;
            lblRoll.Location = new Point(150, 0);
            itemsPanel.Controls.Add(lblRoll);

            lblActivity.Text = "Suffix";
            lblActivity.Location = new Point(275, 0);
            lblActivity.Width = 30;
            itemsPanel.Controls.Add(lblActivity);

            lblOwner.Text = "Owner";
            lblOwner.Location = new Point(310, 0);
            lblOwner.Width = 150;
            itemsPanel.Controls.Add(lblOwner);

            lblDate.Text = "Date";
            lblDate.Location = new Point(465, 0);
            lblDate.Width = 100;
            itemsPanel.Controls.Add(lblDate);
        }
        public void Connect()
        {
            table = TXM.Run(@"select * from ACCT INNER JOIN client_acct ON ACCT.ID = client_acct.ACCT_ID_FK INNER JOIN client on client_acct.CLI_ID_FK = client.id");
            //client acct
        }

        public string getPYMTID()
        {
            DataTable rowID = new DataTable();
 //         rowID = TXM.Run("Select pymt_id_seq.nextval from dual");
            rowID = TXM.Run("Select max(id)+1 from txmadm.temppymt");
            return rowID.Rows[0][0].ToString();

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

        public void UpdatePYMTTemp()
        {

            var sequenceNo = 0;
            var batchNo = getBatchNO();
            var row_ID = getPYMTID();
            foreach (DataRow dtRow in itemsTable.Rows)
            {
                sequenceNo++;
                var temp = getAcctID(dtRow["Roll_Number"].ToString());
                TXM ora = new TXM("BEGIN Insert Into txmadm.temppymt (ID, ACCT_ID_FK, AMT, PYMTS_CD_FK, SUSPENSE_FLG, BATCH_NO, SEQ_NO, TRAN_NO, CREATE_DATE, TRAN_DATE, PULL_FLG, OVERPAY_FLG, TX_SALE_FLG, PYMTM_CD_FK, CREATE_USERID) Values (@ID, @ACCT_ID_FK, @AMT, 'OTH', 'N', @BATCH_NO, @SEQ_NO, 1, @CREATE_DATE, @TRAN_DATE, 'N', 'N', 'N', 'CHQ', @CREATE_USERID); COMMIT; END;");
                // ora.AddParameter("@ID", getPYMTID());
                ora.AddParameter("@ID", row_ID);
                ora.AddParameter("@ACCT_ID_FK", temp);
                ora.AddParameter("@AMT", dtRow["AMT"]);
                ora.AddParameter("@BATCH_NO", batchNo);
                ora.AddParameter("@SEQ_NO", sequenceNo);
                ora.AddParameter("@CREATE_DATE", dtRow["CREATE_DATE"]);
                ora.AddParameter("@TRAN_DATE", dtRow["TRAN_DATE"]);
                ora.AddParameter("@CREATE_USERID", dtRow["CREATE_USERID"]);
                row_ID = row_ID + 1;
                ora.Run();
            }
        }

        

        private void rollNumber_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            TextBox txtRoll = (TextBox)sender;
            row["Roll_Number"] = "19" + txtRoll.Text;
            if (e.KeyData == Keys.Tab)
                {
                DataRow[] foundRollNumber = table.Select("ROLL_NO = 19" + txtRoll.Text + "");
                if (foundRollNumber.Length != 0)
                {
                    txtRoll.BackColor = Color.White;
                    string expression = "ROLL_NO = 19" + txtRoll.Text + "";
                    DataRow[] foundRow = table.Select(expression);
                    Control txtSuffix = itemsPanel.GetNextControl(txtRoll, true);
                    Control txtOwner = itemsPanel.GetNextControl(txtSuffix, true);
                    txtOwner.Text = foundRow[0]["NAME1"].ToString();
                    Control txtDate = itemsPanel.GetNextControl(txtOwner, true);
                    txtDate.Text = dtpDate.Value.Date.ToString();
                    row["ACCT_ID_FK"] = foundRow[0]["ID"];
                    row["CREATE_DATE"] = DateTime.Today;
                    row["TRAN_DATE"] = DateTime.Parse(txtDate.Text).Date;
                    row["CREATE_USERID"] = tbBatchNo.Text;
                }
                else
                {
                    txtRoll.BackColor = Color.Red;
                }
            }

        }

        private void amount_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            TextBox txtAmount = (TextBox)sender;
            if (e.KeyData == Keys.Tab)
            {
                if (txtAmount.Text != "")
                {                  
                    row["AMT"] = Convert.ToDecimal(txtAmount.Text) / 100;
                    txtAmount.Text = (Convert.ToDecimal(txtAmount.Text) / 100).ToString();                  
                }
            }
           
        }
        private void suffix_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            TextBox txtSuffix = (TextBox)sender;
           
            if (e.KeyData == Keys.Tab)
            {
                if (txtSuffix.Text == "")
                {
                    txtSuffix.Text = "0";
                }
                if(!manual)
                {
                    itemsTable.Rows.Add(row);

                    newLine();
                }
               
            }
        }

        private void date_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            TextBox txtDate = (TextBox)sender;
            
            if (e.KeyData == Keys.Tab)
            {
                if (manual)
                {
                    row["TRAN_DATE"] = DateTime.Parse(txtDate.Text).Date;
                    itemsTable.Rows.Add(row);
                }
                newLine();
            }
        }

        public void newLine()
            {
            row = itemsTable.NewRow();
            entryNumber++;
            int point = (entryNumber * 22) + itemsPanel.AutoScrollPosition.Y;
            

            TextBox entry = new TextBox();
            TextBox roll = new TextBox();
            TextBox activity = new TextBox();
            TextBox owner = new TextBox();
            TextBox date = new TextBox();
            TextBox amount = new TextBox();

            var temp = itemsPanel.AutoScrollMargin;


            entry.Name = "tbentry" + entryNumber;
            entry.Text = entryNumber.ToString();
            entry.Width = 40;
            entry.TabStop = false;
            entry.Location = new Point(0, point);
            itemsPanel.Controls.Add(entry);

            amount.Name = "tbAmountNumber" + entryNumber;
            amount.Location = new Point(45, point);
            amount.Width = 100;
            amount.PreviewKeyDown += new PreviewKeyDownEventHandler(amount_KeyDown);
            itemsPanel.Controls.Add(amount);

            roll.Name = "tbRollNumber" + entryNumber;
            roll.Width = 120;
            roll.Location = new Point(150, point);
            roll.PreviewKeyDown += new PreviewKeyDownEventHandler(rollNumber_KeyDown);
            
            itemsPanel.Controls.Add(roll);

            activity.Name = "tbActivityNumber" + entryNumber;
            activity.Location = new Point(275, point);       
            activity.Width = 30;
            activity.PreviewKeyDown += new PreviewKeyDownEventHandler(suffix_KeyDown);
            itemsPanel.Controls.Add(activity);

            owner.Name = "tbOwnerName" + entryNumber;
            owner.Location = new Point(310, point);
            owner.Width = 150;
            itemsPanel.Controls.Add(owner);

           
            date.Name = "tbDate" + entryNumber;
            date.Location = new Point(465, point);           
            date.Width = 100;
            date.PreviewKeyDown += new PreviewKeyDownEventHandler(date_PreviewKeyDown);
            itemsPanel.Controls.Add(date);
            if(entryNumber == 1)
            {
                amount.Focus();
            }
            else
            {
                entry.Focus();
            }           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Console.Write(itemsTable.Rows);
            UpdatePYMTTemp();
            MessageBox.Show("Successfully Updated " + itemsTable.Rows.Count + " Rows");
            itemsPanel.Controls.Clear();

            row.Delete();
            itemsTable.Clear();
            entryNumber = 0;
            newLine();
            getLabels();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            manual = !manual;
        }
    }
}
