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
    public partial class InventoryManagement : Form
    {
        //       static string env = "PD";
        static string env = "PY";
        static string schema = Core.getSchema(env);
        static string controlSchema = Core.getControlSchema(env);

        static string batchDescription = "Inventory Issuance";

        public InventoryManagement()
        {
            InitializeComponent();
        }

        private void InventoryManagement_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int empNo = int.Parse(textBox1.Text);
            int woID = int.Parse(textBox2.Text);
            string positiveBranchPlant = Core.getEmployeeBusinessUnit(env, empNo);
            string positiveObjectNumber = Core.getVariable("InventoryChargeGLObjectNo");
            string creditAccount = positiveBranchPlant + "." + Core.getVariable("InventoryRecoveryGLObjectNo");
            string woBranchPlant = Oracle.RunString("select WAMCU from " + schema + ".F4801 where WADOCO = @WO", woID);

            //Error checking
            int numRows = Oracle.Run("select * from " + schema + ".F4801 where trim(wammcu) = '1001' and wadoco = @WO", textBox2.Text.Trim()).Rows.Count;

            if (numRows == 0)
            {
                MessageBox.Show("Error: The work order " + textBox2.Text.Trim() + " does not have a manufacturing branch plant of 1001. Please correct the branch plant before using this work order.");
                return;
            }

            if (textBox1.Text.Trim() == "" || textBox1.Text.Trim() == "0")
            {
                MessageBox.Show("Error: Employee number is blank.");
                return;
            }

            if (textBox2.Text.Trim() == "" || textBox2.Text.Trim() == "0")
            {
                MessageBox.Show("Error: Work order is blank.");
                return;
            }

            if(dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Error: Please scan item.");
                return;
            }

            if(Oracle.Run("select * from " + schema + ".F0901 where trim(gmmcu) = @MCU and trim(gmobj) = @OBJ", positiveBranchPlant.Trim(), positiveObjectNumber.Trim()).Rows.Count == 0)
            {
                MessageBox.Show("Error: The employee's home business unit is " + positiveBranchPlant.Trim() + ". The account " + positiveBranchPlant.Trim() + "." + positiveObjectNumber.Trim() + " does not exist, and must be created to process this transaction.");
                return;
            }

            if (Oracle.Run("select * from " + schema + ".F0901 where trim(gmmcu) = @MCU and trim(gmobj) = @OBJ", positiveBranchPlant.Trim(), Core.getVariable("InventoryRecoveryGLObjectNo").Trim()).Rows.Count == 0)
            {
                MessageBox.Show("Error: The employee's home business unit is " + positiveBranchPlant.Trim() + ". The account " + positiveBranchPlant.Trim() + "." + Core.getVariable("InventoryRecoveryGLObjectNo").Trim() + " does not exist, and must be created to process this transaction.");
                return;
            }

            //if(woBranchPlant.Trim().Length >= 7)
            //{
            //    MessageBox.Show("Error: The work order's home business unit is " + woBranchPlant.Trim() + ". This is a capital account, and cannot be used for inventory. Please use another work order.");
            //    return;
            //}

            if (Oracle.Run("select * from " + schema + ".F0901 where trim(gmmcu) = @MCU and trim(gmobj) = @OBJ", woBranchPlant.Trim(), "5107").Rows.Count == 0)
            {
                MessageBox.Show("Error: The work order's home business unit is " + woBranchPlant.Trim() + ". The account " + woBranchPlant.Trim() + ".5107 does not exist, and must be created to process this transaction.");
                return;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["ItemNumber"].Value != null && dataGridView1.Rows[i].Cells["ItemNumber"].Value.ToString() != "")
                {
                    if(!Core.isNumeric(dataGridView1.Rows[i].Cells["ItemNumber"].Value.ToString()))
                    {
                        MessageBox.Show("Error: Item # \"" + dataGridView1.Rows[i].Cells["ItemNumber"].Value + "\" contains letters. This should be a number.");
                        dataGridView1.Rows[i].Selected = true;
                        return;
                    }

                    int itemNo = int.Parse(dataGridView1.Rows[i].Cells["ItemNumber"].Value.ToString());

                    //Ensure item exists
                    int count = int.Parse(Oracle.RunString("select count(*) from " + schema + ".F4101 where IMITM = @ITEMNO", itemNo));
                    if(count == 0)
                    {
                        MessageBox.Show("Error: Item #" + dataGridView1.Rows[i].Cells["ItemNumber"].Value + ") doesn't exist.");
                        dataGridView1.Rows[i].Selected = true;
                        return;
                    }

                    //Ensure everything is a stock item, and kick out otherwise.
                    string lineType = Oracle.RunString("select IMLNTY from " + schema + ".F4101 where IMITM = @ITEMNO", itemNo).Trim();
                    if(lineType != "S")
                    {
                        MessageBox.Show("Error: " + dataGridView1.Rows[i].Cells["ItemDescription"].Value + " (#" + dataGridView1.Rows[i].Cells["ItemNumber"].Value + ") is not considered a stock item within JDE.");
                        dataGridView1.Rows[i].Selected = true;
                        return;
                    }

                    //Ensure we have some in stock
                    int inStock = 0;

                    try
                    {
                        inStock = int.Parse(Oracle.RunString("select sum(LIPQOH) from " + schema + ".F41021 where LIITM = @ITEMNO", itemNo)) / 100;
                    }
                    catch
                    {
                        MessageBox.Show("Error: " + dataGridView1.Rows[i].Cells["ItemDescription"].Value + " (#" + dataGridView1.Rows[i].Cells["ItemNumber"].Value + ") has missing quantities within JDE.");
                        dataGridView1.Rows[i].Selected = true;
                        return;
                    }

                    int recentTransactions = 0;
                    try
                    {
                        recentTransactions = int.Parse(Oracle.RunString("select SZTRQT from " + schema + ".F3111Z1 where SZCPIT = @ITEMNO and SZEDSP <> 'Y'", itemNo)) / 100;
                    }
                    catch
                    {
                        //Normal
                    }

                    int tryingToBuy = int.Parse(dataGridView1.Rows[i].Cells["Quantity"].Value.ToString());
                    if (tryingToBuy > inStock - recentTransactions)
                    {
                        //Re-enabled July 24th

                        MessageBox.Show("Error: " + dataGridView1.Rows[i].Cells["ItemDescription"].Value.ToString().Trim() + " (#" + dataGridView1.Rows[i].Cells["ItemNumber"].Value + ")" + Environment.NewLine
                            + "In stock (JDE): " + inStock + Environment.NewLine
                            + "Unprocessed transactions (JDE): " + recentTransactions + Environment.NewLine
                            + "Total in stock = " + inStock + " - " + recentTransactions + " = " + (inStock - recentTransactions) + Environment.NewLine
                            + "Trying to dispense: " + tryingToBuy);
                        dataGridView1.Rows[i].Selected = true;
                        return;
                    }

                    DataTable pr = Oracle.Run("select COUNCS from " + schema + ".F4105 where COITM = @ITEMNO", itemNo);
                    if (pr.Rows.Count == 0)
                    {
                        MessageBox.Show("Error: Unit cost is missing in JDE for " + dataGridView1.Rows[i].Cells["ItemDescription"].Value.ToString().Trim() + " (#" + dataGridView1.Rows[i].Cells["ItemNumber"].Value + ")" + Environment.NewLine
                            + "Ask IT to check table F4105.COUNCS for item " + dataGridView1.Rows[i].Cells["ItemNumber"].Value + ".");
                        dataGridView1.Rows[i].Selected = true;
                        return;
                    }

                    DataTable uom = Oracle.Run("select IMUOM1 from " + schema + ".F4101 where IMITM = @ITEMNO", itemNo);
                    if (pr.Rows.Count == 0)
                    {
                        MessageBox.Show("Error: Unit of measurement (UOM) is missing in JDE for " + dataGridView1.Rows[i].Cells["ItemDescription"].Value.ToString().Trim() + " (#" + dataGridView1.Rows[i].Cells["ItemNumber"].Value + ")" + Environment.NewLine
                            + "Ask IT to check table F4101.IMUOM1 for item " + dataGridView1.Rows[i].Cells["ItemNumber"].Value + ".");
                        dataGridView1.Rows[i].Selected = true;
                        return;
                    }
                }
            }

            int batchID;
            int lineNumber;
            int transactionNumber;

            //Check that batch exists
            bool batchExisting = Oracle.Run("select * from " + schema + ".F3111Z1 where SZEDUS = 'JDE' and SZEDSP <> 'Y'").Rows.Count > 0;
            string user = "JDE";

            if (batchExisting)
            {
                batchID = int.Parse(Oracle.RunString("select max(SZEDBT) from " + schema + ".F3111Z1 where SZEDUS = 'JDE' and SZEDSP <> 'Y'"));
                transactionNumber = int.Parse(Oracle.RunString("select max(SZEDTN) from " + schema + ".F3111Z1 where SZEDBT = @BATCH", batchID));
                lineNumber = 1000 + int.Parse(Oracle.RunString("select max(SZEDLN) from " + schema + ".F3111Z1 where SZEDBT = @BATCH", batchID));
            }
            else
            {
                batchID = int.Parse(Oracle.RunString("select NNN002 from " + controlSchema + ".F0002 where NNSY = @VAR", "47  "));
                Oracle.Run("update " + controlSchema + ".F0002 set NNN002 = NNN002 + 1 where NNSY = @VAR", "47  ");

                transactionNumber = int.Parse(Oracle.RunString("select NNN001 from " + controlSchema + ".F0002 where NNSY = @VAR", "47  "));
                Oracle.Run("update " + controlSchema + ".F0002 set NNN001 = NNN001 + 1 where NNSY = @VAR", "47  ");

                lineNumber = 1000;
            }

            //Insert inventory records
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["ItemNumber"].Value != null && dataGridView1.Rows[i].Cells["ItemNumber"].Value.ToString() != "")
                {
                    int qty = int.Parse(dataGridView1.Rows[i].Cells["Quantity"].Value.ToString());
                    int itemNo = int.Parse(dataGridView1.Rows[i].Cells["ItemNumber"].Value.ToString());
                    string logTable = "Log";

                    double price = double.Parse(Oracle.RunString("select COUNCS from " + schema + ".F4105 where trim(COLEDG) = '07' and COITM = @ITEMNO", itemNo)) / 10000;
                    double cost = qty * price;

                    if (env == "PY")
                        logTable = "LogTest";

                    SQL.Run(@"use inventorymanagement; insert into " + logTable + @" values (@EMPNO, @WOID, @ITEMNO, @QTY, @DATE, @COST, @USR, @BAT, @TRANS, @LINENO)",
                        empNo,
                        woID,
                        itemNo,
                        qty,
                        DateTime.Now,
                        cost,
                        user,
                        batchID,
                        transactionNumber,
                        lineNumber);

                    string variables = "@SZEDUS, @SZEDBT, @SZEDTN, @SZEDLN, @SZTYTN, @SZTNAC, @SZEDSP, @SZDRIN, @SZDOCO, @SZTRQT, @SZCPIT, @SZUM, @SZCMCU, @SZMTST, @SZLOCN, @SZUKID, @SZEDCT, @SZDCTO, @SZEDDT";
                    string columns = variables.Replace("@", "");

                    Oracle.Run(@"insert into " + schema + ".F3111Z1 (" + columns + ") values (" + variables + ")",
                        user,
                        batchID,
                        transactionNumber,
                        lineNumber,
                        "JDEII",
                        "A",
                        " ",
                        "1",
                        woID,
                        qty * 100,
                        itemNo,
                        Oracle.RunString("select IMUOM1 from " + schema + ".F4101 where IMITM = @ITEMNO", itemNo),
                        "        1001", //Oracle.RunString("select WAMMCU from " + schema + ".F4801 where WADOCO = @WO", woID),
                        "20",
                        Oracle.RunString("select LILOCN from " + schema + ".F41021 where LIITM = @ITEMNO", itemNo),
                        0,
                        Oracle.RunString("select WADCTO from " + schema + ".F4801 where WADOCO = @WO", woID),
                        Oracle.RunString("select WADCTO from " + schema + ".F4801 where WADOCO = @WO", woID),
                        Core.dateToJDE(DateTime.Now));

                    lineNumber += 1000;
                }
            }

            //Check that batch exists
            batchID = Core.getOrFindGLBatchNumber(env, batchDescription, out lineNumber);
            lineNumber /= 1000;

            //Insert financial records
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["ItemNumber"].Value != null && dataGridView1.Rows[i].Cells["ItemNumber"].Value.ToString() != "")
                {
                    DateTime date = DateTime.Now;

                    int itemNo = int.Parse(dataGridView1.Rows[i].Cells["ItemNumber"].Value.ToString());
                    string itemDesc = itemNo + " - " + dataGridView1.Rows[i].Cells["ItemDescription"].Value.ToString();

                    if (itemDesc.Length > 30)
                        itemDesc = itemDesc.Substring(0, 30);

                    int qty = int.Parse(dataGridView1.Rows[i].Cells["Quantity"].Value.ToString());
                    decimal price = decimal.Parse(Oracle.RunString("select COUNCS from " + schema + ".F4105 where trim(COLEDG) = '07' and COITM = @ITEMNO", itemNo)) / 10000;

                    decimal amount = qty * price;

                    //13% * (1 - 0.8464)
                    decimal HST = decimal.Parse(Oracle.RunString("select TATXR1 from " + schema + ".F4008 where trim(TATXA1) = 'HST'")) / 100000;
                    string taxTreatment = Oracle.RunString("select trim(MCRP07) from " + schema + ".F0006 b join " + schema + ".F4102 i on b.MCMCU = i.IBMCU where IBITM = @ITEMNO", itemNo);
                    decimal taxPerc = 0;

                    if (taxTreatment == "ITC")
                        taxPerc = HST * (1 - 1); //0%
                    else if (taxTreatment == "RBA")
                        taxPerc = HST * (1 - (decimal)0.8646);
                    else if (taxTreatment == "PLS")
                        taxPerc = HST * (1 - (decimal)0.9323);
                    else if (taxTreatment == "LGL")
                        taxPerc = HST * (1 - (decimal)0.9053);
                    else if (taxTreatment == "MUL")
                        taxPerc = HST * (1 - (decimal)0.9084);
                    else
                        taxPerc = 0;

                    decimal taxAmount = taxPerc * amount;

                    string unitType = Oracle.RunString("select IMUOM1 from " + schema + ".F4101 where IMITM = @ITEMNO", itemNo);

                    lineNumber = Core.submitGL(env, batchID, batchDescription, lineNumber, date, itemDesc, "", amount, positiveBranchPlant, positiveObjectNumber, "", creditAccount, qty, unitType, woID, Core.GLType.Inventory, Core.GLSides.Both);
                    //lineNumber = 1000 * Core.submitGL(env, batchID, batchDescription, lineNumber / 1000, date, itemDesc + " HST", taxAmount, positiveBranchPlant, positiveObjectNumber, "", creditAccount, 0, "");
                }
            }

            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "Employee Number";
            label2.Text = "Work Order";
            label2.Left = textBox2.Right - label2.Width;
            
            dataGridView1.Rows.Clear();

            textBox1.Focus();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //Default quantity 1
            dataGridView1.Rows[Math.Max(e.RowIndex - 1, 0)].Cells["Quantity"].Value = 1;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //if(e.Button == MouseButtons.Right)
                
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            LookupWorkOrder lwo = new LookupWorkOrder();
            lwo.ShowDialog();

            if (lwo.quit)
            {
                dataGridView1.Focus();
                //Close();
            }
            else
            {
                WorkOrder wo = lwo.r;

                textBox2.Text = wo.woID.ToString();
                label2.Text = wo.woDesc == null ? "Work Order" : wo.woDesc;
                label2.Left = textBox2.Right - label2.Width;

                dataGridView1.Focus();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool isItemNumber = e.ColumnIndex == dataGridView1.Columns["ItemNumber"].Index;
            bool isQuantity = e.ColumnIndex == dataGridView1.Columns["Quantity"].Index;

            try
            {
                string no = dataGridView1.Rows[e.RowIndex].Cells["ItemNumber"].Value.ToString();

                //Must be numeric
                if (isItemNumber && !Core.isNumeric(no))
                {
                    MessageBox.Show("Error: " + no + " is not a number.");
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    
                    return;
                }

                //Must exist in JDE
                Oracle ora = new Oracle("select imdsc1, imuom1 from " + schema + ".f4101 where imitm=@NO");
                ora.AddParameter("@NO", no);
                DataTable dt = ora.Run();

                if (isItemNumber && dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Error: " + no + " doesn't exist within JDE.");
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                    return;
                }
                else if (isItemNumber)
                {
                    dataGridView1.Rows[e.RowIndex].Cells["ItemDescription"].Value = dt.Rows[0][0].ToString();
                    dataGridView1.Rows[e.RowIndex].Cells["IssueUOM"].Value = dt.Rows[0][1].ToString();
                }

                //Must be stock type
                string lineType = Oracle.RunString("select IMLNTY from " + schema + ".F4101 where IMITM = @ITEMNO", no).Trim();

                if (isItemNumber && lineType != "S") //Not stock
                {
                    MessageBox.Show("Error: " + no + " is not considered a stock item within JDE.");
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                    return;
                }

                //Must have quantities in JDE
                int inStock = 0;

                try
                {
                    inStock = int.Parse(Oracle.RunString("select sum(LIPQOH) from " + schema + ".F41021 where LIITM = @ITEMNO", no)) / 100;
                }
                catch
                {
                    MessageBox.Show("Error: " + dataGridView1.Rows[e.RowIndex].Cells["ItemDescription"].Value + " (#" + dataGridView1.Rows[e.RowIndex].Cells["ItemNumber"].Value + ") has missing quantities within JDE.");
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                    return;
                }

                //Must have enough stock in JDE
                int recentTransactions = 0;

                try
                {
                    recentTransactions = int.Parse(Oracle.RunString("select SZTRQT from " + schema + ".F3111Z1 where SZCPIT = @ITEMNO and SZEDSP <> 'Y'", no)) / 100;
                }
                catch
                {
                    //Normal
                }

                int tryingToBuy = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString());
                if (tryingToBuy > inStock - recentTransactions)
                {
                    MessageBox.Show("Error: " + dataGridView1.Rows[e.RowIndex].Cells["ItemDescription"].Value.ToString().Trim() + " (#" + dataGridView1.Rows[e.RowIndex].Cells["ItemNumber"].Value + ")" + Environment.NewLine
                        + "In stock (JDE): " + inStock + Environment.NewLine
                        + "Unprocessed transactions (JDE): " + recentTransactions + Environment.NewLine
                        + "Total in stock = " + inStock + " - " + recentTransactions + " = " + (inStock - recentTransactions) + Environment.NewLine
                        + "Trying to dispense: " + tryingToBuy);
                    dataGridView1.Rows[e.RowIndex].Selected = true;
                    return;
                }
            }
            catch
            {

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            LookupEmployee lemp = new LookupEmployee();
            lemp.ShowDialog();

            if (lemp.quit)
            {
                dataGridView1.Focus();
                //Close();
            }
            else
            {
                textBox1.Text = lemp.empNo;
                label1.Text = lemp.empDesc == null ? "Employee Number" : lemp.empDesc;

                textBox2.Focus();
            }
        }
    }
}
