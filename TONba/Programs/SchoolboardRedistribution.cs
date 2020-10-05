using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class SchoolboardRedistribution : Form
    {
        public SchoolboardRedistribution()
        {
            InitializeComponent();

            DataTable dt = Vailtech.Run("select USER_ID, SRC_DOC from TX_BAL_ADJ_CNT");

            for (int i = 0; i < dt.Rows.Count; i++)
                batchBox.Items.Add(dt.Rows[i][0].ToString() + " - " + dt.Rows[i][1].ToString());

            if (batchBox.Items.Count > 0)
                batchBox.Text = batchBox.Items[0].ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string getBatch()
        {
            return batchBox.Text.Split('-')[1].Trim();
        }

        private string getUser()
        {
            return batchBox.Text.Split('-')[0].Trim();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (batchBox.Text == "")
                    throw new Exception("Please select user/batch");

                string[] headerRolls = getHeaderRolls();
                int[] headerEntryNo = getHeaderEntry();
                float[] headerValue = getHeaderAmounts();

                for (int i = 0; i < headerRolls.Length; i++)
                    process(headerRolls[i], headerEntryNo[i], headerValue[i]);

                label1.Text = "Done " + batchBox.Text + "!";
                label1.ForeColor = Color.Green;
            }
                catch (Exception e2)
                {
                    label1.Text = e2.Message;
                    label1.ForeColor = Color.Red;
                }
        }
        
        //Process one header record
        private void process(string rollNo, int entryNo, float value)
        {
            performValueCheck(rollNo, entryNo, value);

            processDetails(rollNo, entryNo, value);
        }

        //Process all details for the given header record
        private void processDetails(string rollNo, int entryNo, float value)
        {
            //Get 9s records
            Vailtech ora = new Vailtech("select YEAR_NO, TAX_AMT, ACTIVITY_NO, PEN_AMT, PEN_GL, OTHER_AMT, OTHER_GL from TX_BAL_ADJ_DET where ROLL_NO = @ROLL_NO and TAX_GL='9999.9999'");
            ora.AddParameter("@ROLL_NO", rollNo);
            DataTable dtx = ora.Run();

            float totalSum = 0;

            ora = new Vailtech("select YEAR_NO, TAX_AMT, ACTIVITY_NO, PEN_AMT, PEN_GL, OTHER_AMT, OTHER_GL from TX_BAL_ADJ_DET where ROLL_NO = @ROLL_NO and TAX_GL != '9999.9999'");
            ora.AddParameter("@ROLL_NO", rollNo);
            DataTable dt2 = ora.Run();

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                totalSum += float.Parse(dt2.Rows[i]["TAX_AMT"].ToString());
            }

            int numDetailRecords = dtx.Rows.Count;

            //For each 9s record
            for (int dr = 0; dr < numDetailRecords; dr++)
            {
                int year = int.Parse(dtx.Rows[dr][0].ToString());
                float amount = float.Parse(dtx.Rows[dr][1].ToString());
                string ACTIVITY_NO = dtx.Rows[dr][2].ToString();
                string PEN_AMT = dtx.Rows[dr][3].ToString();
                string PEN_GL = dtx.Rows[dr][4].ToString();
                string OTHER_AMT = dtx.Rows[dr][5].ToString();
                string OTHER_GL = dtx.Rows[dr][6].ToString();

                string batch = getBatch();

                //Get batch class
                ora = new Vailtech("select Clas from View_Vac_Trans where ORIGIN=:BATCH and ROLL_NO=:ROLLNO");
                ora.AddParameter("@BATCH", batch);
                ora.AddParameter("@ROLLNO", rollNo);
                DataTable dt = ora.Run();

                string batchClass = dt.Rows[0][0].ToString();

                //Get percentages using batch class
                dt = Vailtech.Run(@"
select *

from TX_ADJ_PERCENT_PER_YEAR

where ADJ_TYPE = @TYPE
and ADJ_YEAR = @ADJYEAR
and CLASS = @PARCLASS
and GL_NO in ('1000.1241', '1000.1242', '1000.1243', '1000.1244')", "ADJ", year, batchClass);

                //Prepare split records
                string[] GL_NO = new string[dt.Rows.Count];
                string[] description = new string[dt.Rows.Count];
                string[] percentage = new string[dt.Rows.Count];
                float[] adjAmount = new float[dt.Rows.Count];
                int numberOfRecords = dt.Rows.Count;

                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    GL_NO[j] = dt.Rows[j]["GL_NO"].ToString();
                    description[j] = dt.Rows[j]["DESCRIPTION"].ToString();
                    percentage[j] = dt.Rows[j]["PERCENTAGE_PER_YEAR"].ToString();
                    adjAmount[j] = (float)((int)(amount * float.Parse(percentage[j]))) / 100;
                    totalSum += adjAmount[j];
                }

                ////Insert split records
                for (int j = 0; j < numberOfRecords; j++)
                {
                    ora = new Vailtech("insert into TX_BAL_ADJ_DET values (@USER_ID, @ENTRY_NO, @YEAR_NO, @ROLL_NO, @ACTIVITY_NO, @TAX_AMT, @TAX_GL, @PEN_AMT, @PEN_GL, @OTHER_AMT, @OTHER_GL)");
                    ora.AddParameter("@USER_ID", getUser());
                    ora.AddParameter("@ENTRY_NO", entryNo);
                    ora.AddParameter("@YEAR_NO", year);
                    ora.AddParameter("@ROLL_NO", rollNo);
                    ora.AddParameter("@ACTIVITY_NO", ACTIVITY_NO);
                    ora.AddParameter("@TAX_AMT", adjAmount[j]);
                    ora.AddParameter("@TAX_GL", GL_NO[j]);
                    ora.AddParameter("@PEN_AMT", PEN_AMT);
                    ora.AddParameter("@PEN_GL", PEN_GL);
                    ora.AddParameter("@OTHER_AMT", OTHER_AMT);
                    ora.AddParameter("@OTHER_GL", OTHER_GL);
                    ora.Run();
                }

                ////Remove 999s
                ora = new Vailtech(@"delete
from TX_BAL_ADJ_DET

where
YEAR_NO = @YEAR and
USER_ID = @USERALIAS and
ENTRY_NO = @ENTRY_NO and
ROLL_NO = @ROLL_NO and
TAX_GL = '9999.9999'

");
                ora.AddParameter("@YEAR_NO", year);
                ora.AddParameter("@USERALIAS", getUser());
                ora.AddParameter("@ENTRY_NO", entryNo);
                ora.AddParameter("@ROLL_NO", rollNo);
                ora.Run();
            }

            ////Update header
            ora = new Vailtech("update TX_BAL_ADJ set TOTAL_AMOUNT=@TOTAL_AMOUNT where USER_ID=@USER_ID and ENTRY_NO=@ENTRY_NO");
            ora.AddParameter("@TOTAL_AMOUNT", totalSum);
            ora.AddParameter("@USER_ID", getUser());
            ora.AddParameter("@ENTRY_NO", entryNo);
            ora.Run();
        }

        private void performValueCheck(string rollNo, int entryNo, float value)
        {
            const float tolerance = 0.04f;

            float detailValue = getPredictedDetailValue(entryNo, rollNo);
            int numYearsInvolved = Vailtech.Run("select YEAR_NO from TX_BAL_ADJ_DET where USER_ID=@USER_ID and ENTRY_NO=@ENTRY_NO and ROLL_NO=@ROLL_NO group by YEAR_NO", getUser(), entryNo, rollNo).Rows.Count;

            float difference = value - detailValue;

            if (Math.Abs(difference) > numYearsInvolved * tolerance)
                throw new Exception("Numbers are off by " + difference);
        }

        private float[] getHeaderAmounts()
        {
            Vailtech ora = new Vailtech("select TOTAL_AMOUNT from TX_BAL_ADJ where USER_ID = :USER_ID order by ROLL_NO");
            ora.AddParameter("@USER_ID", getUser());
            DataTable dt = ora.Run();

            float[] x = new float[dt.Rows.Count];

            for (int i = 0; i < x.Length; i++)
                x[i] = float.Parse(dt.Rows[i][0].ToString());

            return x;
        }

        private string[] getHeaderRolls()
        {
            Vailtech ora = new Vailtech("select ROLL_NO from TX_BAL_ADJ where USER_ID = :USER_ID order by ROLL_NO");
            ora.AddParameter("@USER_ID", getUser());
            DataTable dt = ora.Run();

            string[] x = new string[dt.Rows.Count];

            for (int i = 0; i < x.Length; i++)
                x[i] = dt.Rows[i][0].ToString();

            return x;
        }

        private int[] getHeaderEntry()
        {
            Vailtech ora = new Vailtech("select ENTRY_NO from TX_BAL_ADJ where USER_ID = :USER_ID order by ROLL_NO");
            ora.AddParameter("@USER_ID", getUser());
            DataTable dt = ora.Run();

            int[] x = new int[dt.Rows.Count];

            for (int i = 0; i < x.Length; i++)
                x[i] = int.Parse(dt.Rows[i][0].ToString());

            return x;
        }

        private float getPredictedDetailValue(int entryNo, string rollNo)
        {
            //Get 9s records
            Vailtech ora = new Vailtech("select YEAR_NO, TAX_AMT, ACTIVITY_NO, PEN_AMT, PEN_GL, OTHER_AMT, OTHER_GL from TX_BAL_ADJ_DET where ROLL_NO = @ROLL_NO and TAX_GL='9999.9999'");
            ora.AddParameter("@ROLL_NO", rollNo);
            DataTable dtx = ora.Run();

            float totalSum = 0;
            int numDetailRecords = dtx.Rows.Count;

            for (int dr = 0; dr < numDetailRecords; dr++)
            {
                int year = int.Parse(dtx.Rows[dr][0].ToString());
                float amount = float.Parse(dtx.Rows[dr][1].ToString());
                string ACTIVITY_NO = dtx.Rows[dr][2].ToString();
                string PEN_AMT = dtx.Rows[dr][3].ToString();
                string PEN_GL = dtx.Rows[dr][4].ToString();
                string OTHER_AMT = dtx.Rows[dr][5].ToString();
                string OTHER_GL = dtx.Rows[dr][6].ToString();

                string batch = getBatch();

                //Get batch class
                ora = new Vailtech("select Clas from View_Vac_Trans where ORIGIN=:BATCH and ROLL_NO=:ROLLNO");
                ora.AddParameter("@BATCH", batch);
                ora.AddParameter("@ROLLNO", rollNo);
                DataTable dt = ora.Run();

                string batchClass = dt.Rows[0][0].ToString();

                //Get percentages using batch class
                dt = Vailtech.Run(@"
select *

from TX_ADJ_PERCENT_PER_YEAR

where ADJ_TYPE = @TYPE
and ADJ_YEAR = @ADJYEAR
and CLASS = @PARCLASS
and GL_NO in ('1000.1241', '1000.1242', '1000.1243', '1000.1244')", "ADJ", year, batchClass);

                string[] GL_NO = new string[dt.Rows.Count];
                string[] description = new string[dt.Rows.Count];
                string[] percentage = new string[dt.Rows.Count];
                float[] adjAmount = new float[dt.Rows.Count];
                int numberOfRecords = dt.Rows.Count;

                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    GL_NO[j] = dt.Rows[j]["GL_NO"].ToString();
                    description[j] = dt.Rows[j]["DESCRIPTION"].ToString();
                    percentage[j] = dt.Rows[j]["PERCENTAGE_PER_YEAR"].ToString();
                    adjAmount[j] = (float)((int)(amount * float.Parse(percentage[j]))) / 100;
                    totalSum += adjAmount[j];
                    //Console.WriteLine("Adding " + amount + " * " + float.Parse(percentage[j])/100 + " = " + adjAmount[j]);
                }
            }

            ora = new Vailtech("select YEAR_NO, TAX_AMT, ACTIVITY_NO, PEN_AMT, PEN_GL, OTHER_AMT, OTHER_GL from TX_BAL_ADJ_DET where ROLL_NO = @ROLL_NO and TAX_GL != '9999.9999'");
            ora.AddParameter("@ROLL_NO", rollNo);
            DataTable dt2 = ora.Run();

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                totalSum += float.Parse(dt2.Rows[i]["TAX_AMT"].ToString());
                //Console.WriteLine("Adding " + float.Parse(dt2.Rows[i]["TAX_AMT"].ToString()));
            }

            return totalSum;
        }
    }
}
