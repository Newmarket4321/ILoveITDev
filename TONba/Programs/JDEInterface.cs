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
    public partial class JDEInterface : Form
    {
        private enum Environment
        {
            Live,
            Test
        };

        //       string environmentJDE = "PD";
        //       EAC
        string environmentJDE = "PY";

        Environment environmentAIMS = Environment.Live;
        Environment environmentClass = Environment.Live;

        string schema;
        string controlSchema;

        public JDEInterface()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;

            environmentJDE = comboBox1.Text;
            environmentAIMS = comboBox3.Text == "Live" ? Environment.Live : Environment.Test;
            environmentClass = comboBox2.Text == "Live" ? Environment.Live : Environment.Test;

            schema = Core.getSchema(environmentJDE);
            controlSchema = Core.getControlSchema(environmentJDE);
        }

        private void classButton_Click(object sender, EventArgs e)
        {
            environmentJDE = comboBox1.Text;
            controlSchema = Core.getControlSchema(environmentJDE);
            environmentClass = comboBox2.Text == "Live" ? Environment.Live : Environment.Test;

            bool success;
            DateTime date = Core.getDate((checkBox1.Checked ? "Please select the start of your import date range." : "What date would you like to import?"), DateTime.Parse(Core.getVariable("InterfaceLastDateClass")).AddDays(1), out success);

            if (!success)
                return;

            DateTime dateTo = date;

            if (checkBox1.Checked)
                dateTo = Core.getDate("Please select the end of your import date range.", date, out success);

            if (!success)
                return;

            int period = date.Month;

        //    Class.Run((environmentClass == Environment.Live ? "use class;" : "use trainer;") + @"
//UPDATE ACCOUNTING_ALLOCATION

//SET ACCOUNTING_ALLOCATION.function_gl_extension_id = NULL

//WHERE ACCOUNTING_ALLOCATION.function_gl_extension_id IS NOT NULL
//AND ACCOUNTING_ALLOCATION.gl_account_id = 250
//");

            DataTable classGL = Class.Run((environmentClass == Environment.Live ? "use class;" : "use trainer;") + @"
SELECT
at.effective_date,
CASE WHEN pt.title = 'Cash' or pt.title = 'Cheque' THEN
	CASE WHEN at.post_user IS NULL
        THEN c1.user_code
    ELSE
        c2.user_code
	END
ELSE
	wl.title
END AS 'Detail',
CASE
    WHEN aa.FUNCTION_GL_EXTENSION_ID IS NULL OR ltrim(rtrim(gl.GL_ACCOUNT_NUMBER)) = '2-565'
        THEN ltrim(rtrim(gl.GL_ACCOUNT_NUMBER))
    ELSE
        ltrim(rtrim(gl.GL_ACCOUNT_NUMBER)) + ltrim(rtrim(gle.EXTENSION))
END AS GL,
Sum(DEBIT-CREDIT) AS Amt,
case when pt.title is null then 'Other' else pt.title end as 'TransactionType'

FROM ACCOUNTING_ALLOCATION aa
INNER JOIN GL_ACCOUNT gl ON aa.gl_account_id = gl.gl_account_id
INNER JOIN ACCOUNTING_TRANSACTION at ON aa.transaction_id = at.transaction_id
INNER JOIN CLASS_USER c1 ON at.userstamp = c1.person_id
INNER JOIN CLASS_USER c2 ON at.post_user = c2.person_id
LEFT JOIN PAYMENT_TYPE pt ON aa.REFERENCE=pt.PAYMENT_TYPE_ID
LEFT JOIN WORKSTATION_LOCATION wl ON at.POST_LOCATION = wl.WORKSTATION_LOCATION_ID
LEFT JOIN FUNCTION_GL_EXTENSION gle ON aa.function_gl_extension_id = gle.function_gl_extension_id

WHERE at.effective_date >= @DATEFROM
AND at.effective_date < @DATETO

GROUP BY
at.effective_date,
CASE WHEN pt.title = 'Cash' or pt.title = 'Cheque' THEN
	CASE WHEN at.post_user IS NULL
        THEN c1.user_code
    ELSE
        c2.user_code
	END
ELSE
	wl.title
END,
CASE
    WHEN aa.FUNCTION_GL_EXTENSION_ID IS NULL OR ltrim(rtrim(gl.GL_ACCOUNT_NUMBER)) = '2-565'
        THEN ltrim(rtrim(gl.GL_ACCOUNT_NUMBER))
    ELSE
        ltrim(rtrim(gl.GL_ACCOUNT_NUMBER)) + ltrim(rtrim(gle.EXTENSION))
END,
pt.title", date, dateTo.AddDays(1));

            int batchNumber = int.Parse(Oracle.RunString("select NNN006 from " + controlSchema + ".F0002 where NNSY='00'"));

            int numberInserts = 0;

            if (classGL.Rows.Count > 0)
            {
                Oracle.Run("UPDATE " + controlSchema + ".F0002 Set NNN006 = NNN006 + 1 where NNSY='00'");

                int lineNumber = 1;
                string batchDescription = "";
                string remark = "";
                decimal amount = 0;
                string positiveBranchPlant = "";
                string positiveObjectNumber = "";
                string positiveSub = "";
                string creditAccount = "";
                string reference = "";

                //Put it all in
                for (int i = 0; i < classGL.Rows.Count; i++)
                {
                    DateTime glDate = DateTime.Parse(classGL.Rows[i]["EFFECTIVE_DATE"].ToString());
                    batchDescription = "Class " + glDate.ToString("MM\\/dd\\/yy");
                    remark = classGL.Rows[i]["Detail"].ToString();
                    amount = decimal.Parse(classGL.Rows[i]["AMT"].ToString());
                    positiveBranchPlant = classGL.Rows[i]["GL"].ToString().Split('.')[0];
                    positiveObjectNumber = classGL.Rows[i]["GL"].ToString().Split('.')[1];
                    positiveSub = classGL.Rows[i]["GL"].ToString().Split('.').Length >= 3 ? classGL.Rows[i]["GL"].ToString().Split('.')[2] : "";
                    creditAccount = classGL.Rows[i]["GL"].ToString();
                    reference = classGL.Rows[i]["TransactionType"].ToString();
                    
                    lineNumber = Core.submitGL(environmentJDE, batchNumber, batchDescription, lineNumber, date, remark, reference, amount, positiveBranchPlant, positiveObjectNumber, positiveSub, creditAccount, null, null, null, Core.GLType.General, Core.GLSides.PositiveOnly);
                    
                    numberInserts++;
                }
                
                //Transfer tax payments to correct account
                string accountNumber = Core.getVariable("TaxDummyAccountNo");
                int transferNumRecords = Oracle.Run("SELECT * FROM " + schema + ".F0911Z1 WHERE trim(VNANI) = @ACCOUNTNO AND VNEDBT = @BATCHNO", accountNumber, batchNumber).Rows.Count;

                if (transferNumRecords > 0)
                {
                    batchDescription = "Tax Transfer " + date.ToString("MM\\/dd\\/yy");
                    remark = "POS Payment " + batchNumber;
                    amount = decimal.Parse(Oracle.RunString("SELECT -sum(VNAA)/100 FROM " + schema + ".F0911Z1 WHERE trim(VNANI) = @ACCOUNTNO AND VNEDBT = @BATCHNO", accountNumber, batchNumber));
                    positiveBranchPlant = accountNumber.Split('.')[0];
                    positiveObjectNumber = accountNumber.Split('.')[1];
                    positiveSub = accountNumber.Split('.').Length > 2 ? accountNumber.Split('.')[2] : "";
                    creditAccount = "1000.1111";

                    lineNumber = Core.submitGL(environmentJDE, batchNumber, batchDescription, lineNumber, date, remark, "", amount, positiveBranchPlant, positiveObjectNumber, positiveSub, creditAccount, null, null, null, Core.GLType.General, Core.GLSides.Both);
                    numberInserts += 2;
                }

                //Transfer parking ticket payments to correct account
                accountNumber = Core.getVariable("ParkingDummyAccountNo");
                transferNumRecords = Oracle.Run("SELECT * FROM " + schema + ".F0911Z1 WHERE trim(VNANI) = @ACCOUNTNO AND VNEDBT = @BATCHNO", accountNumber, batchNumber).Rows.Count;

                if (transferNumRecords > 0)
                {
                    batchDescription = "Parking Transfer " + date.ToString("MM\\/dd\\/yy");
                    remark = "Parking payment " + batchNumber;
                    amount = decimal.Parse(Oracle.RunString("SELECT -sum(VNAA)/100 FROM " + schema + ".F0911Z1 WHERE trim(VNANI) = @ACCOUNTNO AND VNEDBT = @BATCHNO", accountNumber, batchNumber));
                    positiveBranchPlant = accountNumber.Split('.')[0];
                    positiveObjectNumber = accountNumber.Split('.')[1];
                    positiveSub = accountNumber.Split('.').Length > 2 ? accountNumber.Split('.')[2] : "";
                    creditAccount = "1000.1111";

                    lineNumber = Core.submitGL(environmentJDE, batchNumber, batchDescription, lineNumber, date, remark, "", amount, positiveBranchPlant, positiveObjectNumber, positiveSub, creditAccount, null, null, null, Core.GLType.General, Core.GLSides.Both);
                    numberInserts += 2;
                }

                Core.setVariable("InterfaceLastDateClass", date.ToString("MMMM dd, yyyy"));
                MessageBox.Show("Done! " + numberInserts + " records entered into batch " + batchNumber + ".");
                Core.log(Text, "Class import", numberInserts + " records entered into batch " + batchNumber + " for date " + date.ToString("MMMM dd, yyyy") + ". (Environment " + environmentJDE + ")");
            }
            else
            {
                MessageBox.Show("No records found in Class for this date.");
                Core.log(Text, "Class import", "No records found in Class for date " + date.ToString("MMMM dd, yyyy") + ". (Environment " + environmentJDE + ")");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            environmentJDE = comboBox1.Text;
            controlSchema = Core.getControlSchema(environmentJDE);

            bool success;
            DateTime date = Core.getDate((checkBox1.Checked ? "Please select the start of your import date range." : "What date would you like to import?"), DateTime.Parse(Core.getVariable("InterfaceLastDateVailtech")).AddDays(1), out success);

            if (!success)
                return;

            DateTime dateTo = date;

            if (checkBox1.Checked)
                dateTo = Core.getDate("Please select the end of your import date range.", date, out success);

            if (!success)
                return;

            int period = date.Month;

            int batchNumber = int.Parse(Oracle.RunString("select NNN006 from " + controlSchema + ".F0002 where NNSY='00'"));
            Oracle.Run("UPDATE " + controlSchema + ".F0002 Set NNN006 = NNN006 + 1 where NNSY='00'");

            int lineNumber = 1;
            int numberInserts = 0;


            for (DateTime d = date; d <= dateTo; d = d.AddDays(1))
            {
                //int exclusionBatch = int.Parse(Vailtech.RunString("select ORIGIN from VAILTECH.TX_HISTORY where post_date = @POSTD and origin like 'PAY%' and trim(reference) in ('1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12', '13', '14', '15', '16', '17', '18', '19', '20', '21', '22', '23', '24', '25', '26', '27', '28', '29', '30', '31')", d).Replace("PAY", ""));

                DataTable vtaxGL = Vailtech.Run(@"
SELECT
C_ACCOUNT as GL,
RUN_DATE,
REFERENCE,
AMOUNT AS AMT,
JOURNALCODE,
JOURNALNO

FROM VAILTECH.GLTRANS
WHERE RUN_DATE >= @DATEFROM
AND RUN_DATE < @DATETO

ORDER BY JOURNALCODE, JOURNALNO

", d, d.AddDays(1));

                if (vtaxGL.Rows.Count > 0)
                {
                    for (int i = 0; i < vtaxGL.Rows.Count; i++)
                    {
                        string variables = "@VNEDUS, @VNEDTN, @VNEDLN, @VNEDER, @VNEDSP, @VNEDTC, @VNEDTR, @VNEDBT, @VNKCO, @VNDCT, @VNDGJ, @VNPOST, @VNCO, @VNANI, @VNAM, @VNLT, @VNPN, @VNCTRY, @VNFY, @VNAA, @VNEXA, @VNEXR, @VNR1, @VNUSER";
                        string columns = variables.Replace("@", "");
                        DateTime glDate = DateTime.Parse(vtaxGL.Rows[i]["RUN_DATE"].ToString());

                        string batch = vtaxGL.Rows[i]["JOURNALNO"].ToString();

                        while (batch.Length < 4)
                            batch = "0" + batch;

                        batch = vtaxGL.Rows[i]["JOURNALCODE"].ToString() + batch;

                        string batchDescription = "Vailtech " + glDate.ToString("MM\\/dd\\/yy");
                        string remark = batch;
                        decimal amount = decimal.Parse(vtaxGL.Rows[i]["AMT"].ToString());
                        string positiveBranchPlant = vtaxGL.Rows[i]["GL"].ToString().Split('.')[0];
                        string positiveObjectNumber = vtaxGL.Rows[i]["GL"].ToString().Split('.')[1];
                        string positiveSub = vtaxGL.Rows[i]["GL"].ToString().Split('.').Length >= 3 ? vtaxGL.Rows[i]["GL"].ToString().Split('.')[2] : "";
                        string creditAccount = "";

                        lineNumber = Core.submitGL(environmentJDE, batchNumber, batchDescription, lineNumber, glDate, remark, "", amount, positiveBranchPlant, positiveObjectNumber, positiveSub, creditAccount, null, null, null, Core.GLType.General, Core.GLSides.PositiveOnly);
                        
                        numberInserts++;
                    }
                }
                else
                {
                    MessageBox.Show("No records found in Vailtech for date " + d.ToString("MMMM dd, yyyy") + ".");
                    Core.log(Text, "Vailtech import", "No records found in Vailtech for date " + d.ToString("MMMM dd, yyyy") + ". (Environment " + environmentJDE + ")");
                }
            }

            if (numberInserts > 0)
            {
                Core.setVariable("InterfaceLastDateVailtech", date.ToString("MMMM dd, yyyy"));
                MessageBox.Show("Done! " + numberInserts + " records entered into batch " + batchNumber + ".");
                Core.log(Text, "Vailtech import", numberInserts + " records entered into batch " + batchNumber + " for date " + date.ToString("D") + ". (Environment " + environmentJDE + ")");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            environmentJDE = comboBox1.Text;
            controlSchema = Core.getControlSchema(environmentJDE);

            bool success;
            DateTime date = Core.getDate("What date would you like to import?", DateTime.Parse(Core.getVariable("InterfaceLastDateTixHub")).AddDays(1), out success);

            if (!success)
                return;

            int period = date.Month;

            int numberInserts = 0;
            int batchNumber = -1;

            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();

            if (file.FileName != "")
            {
                string[] lines = File.ReadAllLines(file.FileName);

                if (lines.Length > 0)
                {
                    batchNumber = int.Parse(Oracle.RunString("select NNN006 from " + controlSchema + ".F0002 where NNSY='00'"));
                    Oracle.Run("UPDATE " + controlSchema + ".F0002 Set NNN006 = NNN006 + 1 where NNSY='00'");

                    decimal totalHST = 0;

                    int lineNumber = 1;
                    string batchDescription = "";

                    for (int i = 0; i < lines.Length; i++)
                    {
                        string rec_type = lines[i].Substring(0, 1);
                        string trans_number = lines[i].Substring(1, 8);
                        DateTime trans_date = date; //new DateTime(int.Parse(lines[i].Substring(13, 4)), int.Parse(lines[i].Substring(11, 2)), int.Parse(lines[i].Substring(9, 2)));
                        string trans_amount = lines[i].Substring(17, 15);
                        string desc_1 = lines[i].Substring(32, 30);
                        string desc_2 = lines[i].Substring(62, 30);
                        string gl_number = lines[i].Substring(92, 29);
                        string filler_1 = lines[i].Substring(121, 9);
                        decimal gst_amt = 0;

                        try
                        {
                            gst_amt = decimal.Parse(lines[i].Substring(130, 15)) / 100;
                        }
                        catch
                        {

                        }

                        decimal hst_amt = 0;

                        try
                        {
                            hst_amt = decimal.Parse(lines[i].Substring(145, 15)) / 100;
                        }
                        catch
                        {

                        }

                        string operator_name = lines[i].Substring(160, 8);
                        string customer_name = lines[i].Substring(168, 27);
                        decimal amount = decimal.Parse(lines[i].Substring(17, 15).Trim()) / 100;
                        batchDescription = "TixHub " + trans_date.ToString("MM\\/dd\\/yy");
                        string remark = desc_2;

                        totalHST += gst_amt + hst_amt; 

                        //if (desc_2 != "Ticket Service Charges")
                        //    if (rec_type == "D")
                        //        amount = SumOfTrans_Amount + gst_amt;
                        //    else
                        //        amount = SumOfTrans_Amount;

                        if(rec_type == "D") //Negative
                        {
                            string positiveBranchPlant = "";
                            string positiveObjectNumber = "";
                            string positiveSub = "";
                            string creditAccount = gl_number;

                            lineNumber = Core.submitGL(environmentJDE, batchNumber, batchDescription, lineNumber, trans_date, remark, "", amount, positiveBranchPlant, positiveObjectNumber, positiveSub, creditAccount, null, null, null, Core.GLType.General, Core.GLSides.NegativeOnly);
                            numberInserts++;
                        }
                        else if(rec_type == "O") //Positive
                        {
                            string positiveBranchPlant = "1000";
                            string positiveObjectNumber = "1111";
                            string positiveSub = "";
                            string creditAccount = "";

                            lineNumber = Core.submitGL(environmentJDE, batchNumber, batchDescription, lineNumber, trans_date, remark, "", amount, positiveBranchPlant, positiveObjectNumber, positiveSub, creditAccount, null, null, null, Core.GLType.General, Core.GLSides.PositiveOnly);
                            numberInserts++;
                        }
                    }
                    
                    if (totalHST > 0) //If there is a HST amount, enter into the GL a HST record
                    {
                        string remark = "HST";
                        decimal amount = totalHST;
                        DateTime trans_date = date;
                        string positiveBranchPlant = "";
                        string positiveObjectNumber = "";
                        string positiveSub = "";
                        string creditAccount = "1000.1212";

                        //"1000.1212"
                        lineNumber = Core.submitGL(environmentJDE, batchNumber, batchDescription, lineNumber, trans_date, remark, "", amount, positiveBranchPlant, positiveObjectNumber, positiveSub, creditAccount, null, null, null, Core.GLType.General, Core.GLSides.NegativeOnly);
                        numberInserts++;
                    }

                    Core.setVariable("InterfaceLastDateTixHub", date.ToString("MMMM dd, yyyy"));
                    MessageBox.Show("Done! " + numberInserts + " records entered into batch " + batchNumber + ".");
                    Core.log(Text, "TixHub import", numberInserts + " records entered into batch " + batchNumber + " for date " + date.ToString("D") + ". (Environment " + environmentJDE + ")");
                }
                else
                {
                    MessageBox.Show("No records found in file.");
                    Core.log(Text, "TixHub import", "No records found in file. (Environment " + environmentJDE + ")");
                }
            }
        }

        private void AIMSButton_Click(object sender, EventArgs e)
        {
            environmentJDE = comboBox1.Text;
            controlSchema = Core.getControlSchema(environmentJDE);
            environmentAIMS = comboBox3.Text == "Live" ? Environment.Live : Environment.Test;

            bool success;
            DateTime date = Core.getDate((checkBox1.Checked ? "Please select the start of your import date range." : "What date would you like to import?"), DateTime.Parse(Core.getVariable("InterfaceLastDateAIMS")).AddDays(1), out success);

            if (!success)
                return;

            DateTime dateTo = date;

            if (checkBox1.Checked)
                dateTo = Core.getDate("Please select the end of your import date range.", date, out success);

            if (!success)
                return;

            int period = date.Month;

            string query = @"
use AIMS;
select
convert(date, PostingDate) as PostingDay,
sum(Credit) as Credit,
PayTypeDesc,
case when itemcode not in ('CON_MTO', 'CON_MUN', 'CON_MAG', 'NSF', 'MUN ADMIN', 'MTO ADMIN', 'CON_MUN_TRIAL', 'RSOC_MAG', 'RSOC_MTO', 'RSOC_MUN') then PaidViaDesc else itemcode end as 'PaidViaDesc',
case when paytypecode = 'NCCR' then '1000.1289' else '1000.1111' end as 'PositiveAccount',
case when itemcode = 'CON_MAG' then '1000.2222'
	  when itemcode = 'CON_MTO' then '1000.2223'
	  when itemcode = 'CON_MUN' then '26112.7521'
	  when itemcode = 'NSF' then '14312.7598'
	  when itemcode = 'MUN ADMIN' then '14312.7598'
      when itemcode = 'MTO ADMIN' then '26112.7521'
      when itemcode = 'CON_MUN_TRIAL' then '26112.7521'
      when itemcode = 'RSOC_MAG' then '1000.2222'
	  when itemcode = 'RSOC_MTO' then '1000.2223'
	  when itemcode = 'RSOC_MUN' then '26112.7521'
	  else '26112.7521' end as 'CreditAccount'
from VTX_ItemGLCredits
where credit <> 0
and PostingDate >= @STARTDATE
and PostingDate < @ENDDATE
group by convert(date, PostingDate)
      ,paytypedesc
      ,paytypecode
      ,case when itemcode not in ('CON_MTO', 'CON_MUN', 'CON_MAG', 'NSF', 'MUN ADMIN', 'MTO ADMIN', 'CON_MUN_TRIAL', 'RSOC_MAG', 'RSOC_MTO', 'RSOC_MUN') then PaidViaDesc else itemcode end
	  ,case when itemcode = 'CON_MAG' then '1000.2222'
	  when itemcode = 'CON_MTO' then '1000.2223'
	  when itemcode = 'CON_MUN' then '26112.7521'
	  when itemcode = 'NSF' then '14312.7598'
	  when itemcode = 'MUN ADMIN' then '14312.7598'
      when itemcode = 'MTO ADMIN' then '26112.7521'
      when itemcode = 'CON_MUN_TRIAL' then '26112.7521'
      when itemcode = 'RSOC_MAG' then '1000.2222'
	  when itemcode = 'RSOC_MTO' then '1000.2223'
	  when itemcode = 'RSOC_MUN' then '26112.7521'
	  else '26112.7521' end
having sum(credit) <> 0
order by convert(date, PostingDate), PayTypeDesc, case when itemcode not in ('CON_MTO', 'CON_MUN', 'CON_MAG', 'NSF', 'MUN ADMIN', 'MTO ADMIN', 'CON_MUN_TRIAL', 'RSOC_MAG', 'RSOC_MTO', 'RSOC_MUN') then PaidViaDesc else itemcode end
";

            DataTable dt = null;

            if(environmentAIMS == Environment.Live)
                dt = SQL.Run(query, date, dateTo.AddDays(1));
            else
                dt = SQLDev.Run(query, date, dateTo.AddDays(1));

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No records found in AIMS for this date.");
                Core.log(Text, "AIMS import", "No records found in AIMS for date " + date.ToString("D") + ". (Environment " + environmentJDE + ")");

                return;
            }

            int batchNumber = int.Parse(Oracle.RunString("select NNN006 from " + controlSchema + ".F0002 where NNSY='00'"));
            string batchDescription = "AIMS " + date.ToString("MM\\/dd\\/yy");
            int numberInserts = 0;
                
            Oracle.Run("UPDATE " + controlSchema + ".F0002 Set NNN006 = NNN006 + 1 where NNSY='00'");

            for (int i = 0, lineNumber = 1; i < dt.Rows.Count; i++)
            {
                string payTypeDesc = dt.Rows[i]["PayTypeDesc"].ToString();
                string paidViaDesc = dt.Rows[i]["PaidViaDesc"].ToString();
                string remark = payTypeDesc + " - " + paidViaDesc;
                DateTime glDate = DateTime.Parse(dt.Rows[i]["PostingDay"].ToString());
                decimal amount = decimal.Parse(dt.Rows[i]["Credit"].ToString());
                string positiveAccount = dt.Rows[i]["PositiveAccount"].ToString();
                string positiveBranchPlant = positiveAccount.Split('.')[0];
                string positiveObjectNumber = positiveAccount.Split('.')[1];
                string positiveSub = "";
                string creditAccount = dt.Rows[i]["CreditAccount"].ToString();
                
                lineNumber = Core.submitGL(environmentJDE, batchNumber, batchDescription, lineNumber, glDate, remark, "", amount, positiveBranchPlant, positiveObjectNumber, positiveSub, creditAccount, null, null, null, Core.GLType.General, Core.GLSides.Both);
                numberInserts += 2;
            }

            Core.setVariable("InterfaceLastDateAIMS", date.ToString("MMMM dd, yyyy"));
            MessageBox.Show("Done! " + numberInserts + " records entered into batch " + batchNumber + ".");
            Core.log(Text, "AIMS import", numberInserts + " records entered into batch " + batchNumber + " for date " + date.ToString("D") + ". (Environment " + environmentJDE + ")");
        }

        private void btnAccela_Click(object sender, EventArgs e)
        {
            environmentJDE = comboBox1.Text;
            controlSchema = Core.getControlSchema(environmentJDE);

            bool success;
            DateTime date = Core.getDate("What date would you like to import?", DateTime.Parse(Core.getVariable("InterfaceLastDateAccela")).AddDays(1), out success);

            if (!success)
                return;

            int period = date.Month;

            int numberInserts = 0;
            int batchNumber = -1;

            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();

            if (file.FileName != "")
            {
                string[] lines = File.ReadAllLines(file.FileName);

                if (lines.Length > 0)
                {
                    batchNumber = int.Parse(Oracle.RunString("select NNN006 from " + controlSchema + ".F0002 where NNSY='00'"));
                    Oracle.Run("UPDATE " + controlSchema + ".F0002 Set NNN006 = NNN006 + 1 where NNSY='00'");

                    decimal totalHST = 0;

                    int lineNumber = 1;
                    string batchDescription = "";

                    for (int i = 0; i < lines.Length; i++)
                    {
                        string rec_type = lines[i].Substring(0, 1);
                        string trans_number = lines[i].Substring(1, 8);
                        DateTime trans_date = date; //new DateTime(int.Parse(lines[i].Substring(13, 4)), int.Parse(lines[i].Substring(11, 2)), int.Parse(lines[i].Substring(9, 2)));
                        string trans_amount = lines[i].Substring(17, 15);
                        string desc_1 = lines[i].Substring(32, 30);
                        string desc_2 = lines[i].Substring(62, 30);
                        string gl_number = lines[i].Substring(92, 29);
                        string filler_1 = lines[i].Substring(121, 9);
                        decimal gst_amt = 0;

                        try
                        {
                            gst_amt = decimal.Parse(lines[i].Substring(130, 15)) / 100;
                        }
                        catch
                        {

                        }

                        decimal hst_amt = 0;

                        try
                        {
                            hst_amt = decimal.Parse(lines[i].Substring(145, 15)) / 100;
                        }
                        catch
                        {

                        }

                        string operator_name = lines[i].Substring(160, 8);
                        string customer_name = lines[i].Substring(168, 27);
                        decimal amount = decimal.Parse(lines[i].Substring(17, 15).Trim()) / 100;
                        batchDescription = "Accela " + trans_date.ToString("MM\\/dd\\/yy");
                        string remark = desc_2;

                        totalHST += gst_amt + hst_amt;

                        if (rec_type == "D") //Negative
                        {
                            string positiveBranchPlant = "";
                            string positiveObjectNumber = "";
                            string positiveSub = "";
                            string creditAccount = gl_number;

                            lineNumber = Core.submitGL(environmentJDE, batchNumber, batchDescription, lineNumber, trans_date, remark, "", amount, positiveBranchPlant, positiveObjectNumber, positiveSub, creditAccount, null, null, null, Core.GLType.General, Core.GLSides.NegativeOnly);
                            numberInserts++;
                        }
                        else if (rec_type == "O") //Positive
                        {
                            string positiveBranchPlant = "1000";
                            string positiveObjectNumber = "1111";
                            string positiveSub = "";
                            string creditAccount = "";

                            lineNumber = Core.submitGL(environmentJDE, batchNumber, batchDescription, lineNumber, trans_date, remark, "", amount, positiveBranchPlant, positiveObjectNumber, positiveSub, creditAccount, null, null, null, Core.GLType.General, Core.GLSides.PositiveOnly);
                            numberInserts++;
                        }
                    }

                    if (totalHST > 0) //If there is a HST amount, enter into the GL a HST record
                    {
                        string remark = "HST";
                        decimal amount = totalHST;
                        DateTime trans_date = date;
                        string positiveBranchPlant = "";
                        string positiveObjectNumber = "";
                        string positiveSub = "";
                        string creditAccount = "1000.1212";

                        //"1000.1212"
                        lineNumber = Core.submitGL(environmentJDE, batchNumber, batchDescription, lineNumber, trans_date, remark, "", amount, positiveBranchPlant, positiveObjectNumber, positiveSub, creditAccount, null, null, null, Core.GLType.General, Core.GLSides.NegativeOnly);
                        numberInserts++;
                    }

                    Core.setVariable("InterfaceLastDateAccela", date.ToString("MMMM dd, yyyy"));
                    MessageBox.Show("Done! " + numberInserts + " records entered into batch " + batchNumber + ".");
                    Core.log(Text, "Accela import", numberInserts + " records entered into batch " + batchNumber + " for date " + date.ToString("D") + ". (Environment " + environmentJDE + ")");
                }
                else
                {
                    MessageBox.Show("No records found in file.");
                    Core.log(Text, "Accela import", "No records found in file. (Environment " + environmentJDE + ")");
                }
            }
        }

        private void btnTXM_Click(object sender, EventArgs e)
        {
            environmentJDE = comboBox1.Text;
            controlSchema = Core.getControlSchema(environmentJDE);

            bool success;
            DateTime date = Core.getDate((checkBox1.Checked ? "Please select the start of your import date range." : "What date would you like to import?"), DateTime.Parse(Core.getVariable("InterfaceLastDateVailtech")).AddDays(1), out success);

            if (!success)
                return;

            DateTime dateTo = date;

            if (checkBox1.Checked)
                dateTo = Core.getDate("Please select the end of your import date range.", date, out success);

            if (!success)
                return;

            int period = date.Month;

            int batchNumber = int.Parse(Oracle.RunString("select NNN006 from " + controlSchema + ".F0002 where NNSY='00'"));
            Oracle.Run("UPDATE " + controlSchema + ".F0002 Set NNN006 = NNN006 + 1 where NNSY='00'");

            int lineNumber = 1;
            int numberInserts = 0;


            for (DateTime d = date; d <= dateTo; d = d.AddDays(1))
            {
                //int exclusionBatch = int.Parse(Vailtech.RunString("select ORIGIN from VAILTECH.TX_HISTORY where post_date = @POSTD and origin like 'PAY%' and trim(reference) in ('1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12', '13', '14', '15', '16', '17', '18', '19', '20', '21', '22', '23', '24', '25', '26', '27', '28', '29', '30', '31')", d).Replace("PAY", ""));

                DataTable vtaxGL = TXM.Run(@"
SELECT
GL_ACCT as GL,
POST_DATE,
MODULE,
AMT,
DSCR

FROM GL_TRAN_EXP
WHERE POST_DATE >= @DATEFROM
AND POST_DATE < @DATETO

ORDER BY MODULE

", d, d.AddDays(1));

                if (vtaxGL.Rows.Count > 0)
                {
                    for (int i = 0; i < vtaxGL.Rows.Count; i++)
                    {
                        string variables = "@VNEDUS, @VNEDTN, @VNEDLN, @VNEDER, @VNEDSP, @VNEDTC, @VNEDTR, @VNEDBT, @VNKCO, @VNDCT, @VNDGJ, @VNPOST, @VNCO, @VNANI, @VNAM, @VNLT, @VNPN, @VNCTRY, @VNFY, @VNAA, @VNEXA, @VNEXR, @VNR1, @VNUSER";
                        string columns = variables.Replace("@", "");
                        DateTime glDate = DateTime.Parse(vtaxGL.Rows[i]["POST_DATE"].ToString());

                        //string batch = vtaxGL.Rows[i]["JOURNALNO"].ToString();

                        //while (batch.Length < 4)
                        //    batch = "0" + batch;

                        string batch = vtaxGL.Rows[i]["DSCR"].ToString();

                        string batchDescription = "TXM " + glDate.ToString("MM\\/dd\\/yy");
                        string remark = batch;
                        decimal amount = decimal.Parse(vtaxGL.Rows[i]["AMT"].ToString());
                        string positiveBranchPlant = vtaxGL.Rows[i]["GL"].ToString().Split('.')[0];
                        string positiveObjectNumber = vtaxGL.Rows[i]["GL"].ToString().Split('.')[1];
                        string positiveSub = vtaxGL.Rows[i]["GL"].ToString().Split('.').Length >= 3 ? vtaxGL.Rows[i]["GL"].ToString().Split('.')[2] : "";
                        string creditAccount = "";

                        lineNumber = Core.submitGL(environmentJDE, batchNumber, batchDescription, lineNumber, glDate, remark, "", amount, positiveBranchPlant, positiveObjectNumber, positiveSub, creditAccount, null, null, null, Core.GLType.General, Core.GLSides.PositiveOnly);

                        numberInserts++;
                    }
                }
                else
                {
                    MessageBox.Show("No records found in Vailtech for date " + d.ToString("MMMM dd, yyyy") + ".");
                    Core.log(Text, "TXM import", "No records found in Vailtech for date " + d.ToString("MMMM dd, yyyy") + ". (Environment " + environmentJDE + ")");
                }
            }

            if (numberInserts > 0)
            {
                Core.setVariable("InterfaceLastDateVailtech", date.ToString("MMMM dd, yyyy"));
                MessageBox.Show("Done! " + numberInserts + " records entered into batch " + batchNumber + ".");
                Core.log(Text, "TXM import", numberInserts + " records entered into batch " + batchNumber + " for date " + date.ToString("D") + ". (Environment " + environmentJDE + ")");
            }
        }
    }
}
