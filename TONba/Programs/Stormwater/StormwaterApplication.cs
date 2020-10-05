using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class StormwaterApplication : Form
    {
        double lowArea = 0;
        double mediumArea = 0;
        double highArea = 0;
        double exemptArea = 0;
        DateTime startTime;
        int year = DateTime.Today.Year;
        DataTable area;
        Database vtx;

        public StormwaterApplication()
        {
            InitializeComponent();

            label8.Text = "";
            comboBox1.SelectedIndex = 0;
            label23.Text = "Last applied on " + SQL.Run("use stormwater; select * from systemvariables where variable='AppLast'").Rows[0]["Setting"].ToString();
            textBox1.Text = SQL.Run("use stormwater; select * from systemvariables where variable='FundingReq'").Rows[0]["Setting"].ToString();
            textBox2.Text = SQL.Run("use stormwater; select * from systemvariables where variable='ImpLow'").Rows[0]["Setting"].ToString();
            textBox3.Text = SQL.Run("use stormwater; select * from systemvariables where variable='ImpMed'").Rows[0]["Setting"].ToString();
            textBox4.Text = SQL.Run("use stormwater; select * from systemvariables where variable='ImpHigh'").Rows[0]["Setting"].ToString();
            textBox5.Text= SQL.Run("use stormwater; select * from systemvariables where variable='AppRateLow'").Rows[0]["Setting"].ToString();
            textBox6.Text = SQL.Run("use stormwater; select * from systemvariables where variable='TaxYear'").Rows[0]["Setting"].ToString();
            textBox7.Text = SQL.Run("use stormwater; select * from systemvariables where variable='AppRateMed'").Rows[0]["Setting"].ToString();
            textBox8.Text = SQL.Run("use stormwater; select * from systemvariables where variable='AppRateHigh'").Rows[0]["Setting"].ToString();
            putOnBills.Checked = SQL.Run("use stormwater; select * from systemvariables where variable='PutOnBills'").Rows[0]["Setting"].ToString() == "True";
            putOnline.Checked = SQL.Run("use stormwater; select * from systemvariables where variable='PutOnline'").Rows[0]["Setting"].ToString() == "True";
            testMode.Checked = SQL.Run("use stormwater; select * from systemvariables where variable='TestMode'").Rows[0]["Setting"].ToString() == "True";

            if (testMode.Checked)
                vtx = new Vailtest("");
            else
                vtx = new Vailtech("");

            //test();
        }

        public void test()
        {
            try
            {
                area = vtx.Run("select site_area, uom, roll_no from TX_PROP_DATA");
                
                string[] rollNo = { "040150745310000" };

                for (int i = 0; i < rollNo.Length; i++)
                {
                    double area = getArea(rollNo[i]);
                    MessageBox.Show(rollNo[i] + " is area " + area);
                }
            }
            catch (Exception e2)
            {
                Core.error(e2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setEnabled(false);
            Core.invoke(start);
        }

        private void start()
        {
            try
            {
                DateTime lastRun = DateTime.Parse(SQL.Run("use stormwater; select * from systemvariables where variable='CalcLast'").Rows[0]["Setting"].ToString());

                if(lastRun.AddMonths(1) < DateTime.Today)
                {
                    MessageBox.Show("Stormwater Calculator hasn't been run in the last month." + Environment.NewLine
                        + "Please run the Stormwater Calculator first.");

                    setEnabled(true);

                    return;
                }

                DataTable dt = SQL.Run("use stormwater; select * from runoffmap");

                int threshhold = 5000;
                if(dt.Rows.Count < threshhold)
                {
                    MessageBox.Show("Fewer than " + threshhold + " records found in RunoffMap." + Environment.NewLine
                        + "Please run the Stormwater Calculator first.");

                    setEnabled(true);

                    return;
                }
                
                area = vtx.Run("select site_area, uom, roll_no from TX_PROP_DATA");
                vtx.Run("delete from stormwater where year = " + year);

                if(putOnline.Checked)
                    SQL.Run("use stormwater; delete from results");

                vtx.Run("delete from tx_roll_locals where LOCAL_ID = 'SWCHARGE' or LOCAL_ID = 'SWCREDIT'");

                Invoke((MethodInvoker)delegate
                {
                    progressBar2.Maximum = dt.Rows.Count;
                });
                
                startTime = DateTime.Now;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string rollNo = dt.Rows[i][0].ToString();
                    DataTable info = SQL.Run("use stormwater; select * from runoffmap where roll_no = '" + rollNo + "'");
                    
                    if(info.Rows.Count > 0)
                        process(rollNo, int.Parse(info.Rows[0]["RUNOFF_CODE"].ToString()), info.Rows[0]["CLASS_NAME"].ToString());

                    Invoke((MethodInvoker)delegate {
                        try
                        {
                            TimeSpan timeSpent = DateTime.Now - startTime;
                            double secondsRemaining = timeSpent.TotalSeconds * (dt.Rows.Count - i) / i;
                            DateTime finish = DateTime.Now.AddSeconds(secondsRemaining);

                            progressBar2.Value++;
                            progressBar2.Update();
                            label8.Text = finish.ToString("T") + " (" + progressBar2.Value.ToString() + " / " + progressBar2.Maximum.ToString() + ")";
                            label8.Update();
                        }
                        catch
                        {

                        }
                    });
                }

                Invoke((MethodInvoker)delegate {
                    try
                    {
                        progressBar2.Value = progressBar2.Maximum;
                        progressBar2.Update();
                        label8.Text = DateTime.Now.ToString("T") + " (" + progressBar2.Value.ToString() + " / " + progressBar2.Maximum.ToString() + ")";
                        label8.Update();

                        label23.Text = "Last applied on " + DateTime.Now.ToString("MMMM dd yyyy, hh:mm tt");
                        SQL.Run("use stormwater; update systemvariables set setting = '" + DateTime.Now.ToString("MMMM dd yyyy, hh:mm tt") + "' where variable = 'AppLast'");
                    }
                    catch
                    {

                    }

                    setEnabled(true);
                    Core.export("Stormwater", vtx.Run("select * from stormwater where year = " + year));
                });
            }
            catch(Exception e2)
            {
                Core.error(e2);
            }
        }
                
        public void process(string rollNo, int runoffCode, string className)
        {
            //SWM rate area2
            double area = getArea(rollNo);

            //Runoff code (integer, 1-4)
            //int runoffCode = int.Parse(data["RUNOFF_CODE"].ToString());
            //string className = data["CLASS_NAME"].ToString();

            //Runoff rate
            double runoffRate = getClassRate(runoffCode);

            //Credit
            double credit = getCredit(rollNo);

            //Stormwater charge (does not include rebate - that is factored in on the bill itself)
            double stormwaterCharge = runoffCode == 4 || runoffCode == 0 ? 0 : (runoffRate * area);

            vtx.Run("insert into stormwater values (@ROLLNO, @YEAR, @AREA, @CLASS, @RUNOFF, @RUNOFFRATE, @CHARGE, @REBATE)",
                rollNo,
                year,
                area,
                className,
                runoffCode == 1 ? "LOW" : runoffCode == 2 ? "MEDIUM" : runoffCode == 3 ? "HIGH" : runoffCode == 4 ? "EXEMPT" : "UNKNOWN",
                runoffRate,
                (double)((int)(stormwaterCharge * 100)) / 100,
                credit);

            if(putOnBills.Checked)
            {
                if (stormwaterCharge != 0)
                {
                    double amount = 0;

                    if (comboBox1.Text == "Interim")
                        amount = (double)((int)(stormwaterCharge * 100 / 2)) / 100;
                    else
                        amount = (double)((int)(stormwaterCharge * 100)) / 100;

                    vtx.Run("insert into tx_roll_locals values (@ROLLNO, @ACTIVITYNO, @LOCALID, @YEARLYCHARGE, @UNITS)",
                        rollNo,
                        0,
                        "SWCHARGE",
                        amount,
                        0);
                }

                if (credit != 0)
                {
                    vtx.Run("insert into tx_roll_locals values (@ROLLNO, @ACTIVITYNO, @LOCALID, @YEARLYCHARGE, @UNITS)",
                        rollNo,
                        0,
                        "SWCREDIT",
                        credit,
                        0);
                }
            }

            if (putOnline.Checked && runoffCode != 4 && runoffCode != 0) //If we're putting things online and this one is not exempt
            {
                DataTable tempdt = vtx.Run("select block_1_total from tx_billprint where roll_no = @ROLLNO and tax_year = @YEAR and interim_fin_sup = @CODE", rollNo, textBox6.Text, "F");
                
                double taxBill = 0;

                if (tempdt.Rows.Count > 0)
                    taxBill = double.Parse(tempdt.Rows[0][0].ToString());

                SQL sql = new SQL("use stormwater; insert into results values (@ROLLNO, @STREETNO, @STREETNAME, @AREA, @RUNOFFLEVEL, @RATE, @CHARGE, @TAXBILL)");
                sql.AddParameter("@ROLLNO", rollNo);
                sql.AddParameter("@STREETNO", vtx.RunString("select street_no from tx_roll where roll_no = " + rollNo));
                sql.AddParameter("@STREETNAME", vtx.RunString("select street_name from tx_roll where roll_no = " + rollNo));
                sql.AddParameter("@RUNOFFLEVEL", runoffCode == 1 ? "LOW" : runoffCode == 2 ? "MEDIUM" : runoffCode == 3 ? "HIGH" : "");
                sql.AddParameter("@AREA", area);
                sql.AddParameter("@RATE", runoffRate);
                sql.AddParameter("@CHARGE", (double)((int)(stormwaterCharge * 100)) / 100);
                sql.AddParameter("@TAXBILL", taxBill);
                sql.Run();
            }

            //Core.log(Name, "Charge calculated", "rollno=" + rollNo + ", charge=" + (double)((int)(stormwaterCharge * 100)) / 100);
        }

        public double getCredit(string rollNo)
        {
            DataTable dt = vtx.Run("select * from stormwatercredits where roll_no = @rollno and expiry >= @TODAY", rollNo, DateTime.Today);
            
            if (dt.Rows.Count > 0)
            {
                double lowRate = getRunoffRateApp("LOW");
                double mediumRate = getRunoffRateApp("MEDIUM");
                double highRate = getRunoffRateApp("HIGH");
                double lowRollArea = double.Parse(dt.Rows[0]["LOW_AREA"].ToString());
                double mediumRollArea = double.Parse(dt.Rows[0]["MED_AREA"].ToString());

                return Core.calculateStormwaterCredit(rollNo, lowRate, mediumRate, highRate, lowRollArea, mediumRollArea, getPollutionPrevention(rollNo));
            }

            return 0;
        }

        public bool getPollutionPrevention(string rollNo)
        {
            DataTable dt = vtx.Run("select * from stormwatercredits where roll_no = @rollno and expiry >= @TODAY", rollNo, DateTime.Today);

            if (dt.Rows.Count > 0)
                return dt.Rows[0]["POLLUTION_PREVENTION"].ToString() == "Y";

            return false;
        }

        public double getClassRate(int runoffCode)
        {
            if (runoffCode == 1)
                return getRunoffRateApp("LOW");
            else if (runoffCode == 2)
                return getRunoffRateApp("MEDIUM");
            else if (runoffCode == 3)
                return getRunoffRateApp("HIGH");
            
            return 0;
        }

        public double getRunoffRateApp(string level) //Step 10
        {
            if (level == "LOW" && textBox5.Text.Length != 0)
                return double.Parse(textBox5.Text);
            else if (level == "MEDIUM" && textBox7.Text.Length != 0)
                return double.Parse(textBox7.Text);
            else if (level == "HIGH" && textBox8.Text.Length != 0)
                return double.Parse(textBox8.Text);

            double totalAssessment = getTotalAssessment();
            double fundingRequirement = getFundingRequirement();
            double swmRate = fundingRequirement / totalAssessment;

            return swmRate * getRunoffImperviousness(level);
        }

        public double getTotalAssessment() //Step 9 (sum of property runoff assessment)
        {
            double low = getRunoffAssessment("LOW");
            double medium = getRunoffAssessment("MEDIUM");
            double high = getRunoffAssessment("HIGH");
            double exempt = getRunoffAssessment("EXEMPT");

            return low + medium + high;
        }

        public double getRunoffAssessment(string level)
        {
            double runoffArea = getRunoffArea(level);
            double runoffImperviousness = getRunoffImperviousness(level);

            return runoffArea * runoffImperviousness;
        }

        public double getRunoffArea(string level)
        {
            if (level == "LOW")
                return lowArea;
            else if (level == "MEDIUM")
                return mediumArea;
            else if (level == "HIGH")
                return highArea;
            else if (level == "EXEMPT")
                return exemptArea;

            return -1;
        }

        public double getFundingRequirement() //Step 8
        {
            double r = 0;

            Invoke((MethodInvoker)delegate
            {
                r = double.Parse(textBox1.Text.Replace("$", "").Replace(",", "").Trim());
            });

            return r;
        }

        public double getRunoffImperviousness(string level) //Step 8
        {
            if (level == "LOW")
                return double.Parse(textBox2.Text.Replace("%", "")) / 100;
            else if (level == "MEDIUM")
                return double.Parse(textBox3.Text.Replace("%", "")) / 100;
            else if (level == "HIGH")
                return double.Parse(textBox4.Text.Replace("%", "")) / 100;

            return -1;
        }

        public double getArea(string rollNo)
        {
            double areaM = 0;
            string condoID = getCondoID(rollNo);

            if (condoID != "") //Condo
            {
                DataTable gis = GISPub.Run("select sde.st_area(shape) from TONGIS.VIEW_ASMNT_PARCEL where roll_no = '" + rollNo + "'");

                if (gis.Rows.Count > 0)
                    areaM = double.Parse(gis.Rows[0][0].ToString()); //Area of whole condo

                areaM /= getNumCondoUnits(condoID); //Divide by number of units to get unit's share
            }
            else //Not condo
            {
                DataRow[] rows = area.Select("roll_no = " + rollNo);

                if (rows.Count() == 0)
                    return 0;

                areaM = double.Parse(rows[0][0].ToString());
                string unit = rows[0][1].ToString();

                //Convert to square meters
                if (unit == "F")
                    areaM *= 0.092903;
                else if (unit == "A")
                    areaM *= 4046.86;
                else if (areaM == 0 || unit == "N")
                {
                    DataTable gis = GISPub.Run("select sde.st_area(shape) from TONGIS.VIEW_ASMNT_PARCEL where roll_no = '" + rollNo + "'");

                    if (gis.Rows.Count > 0)
                        areaM = double.Parse(gis.Rows[0][0].ToString());
                }
            }

            return (double)((int)(areaM * 1000)) / 1000;
        }

        string getCondoID(string rollNo)
        {
            DataTable dt = vtx.Run("select LEGAL1 from TX_ROLL where ROLL_NO=@ROLLNO and (LEGAL1 like '%CONDO%' or LEGAL1 like '%YRSCP%' or LEGAL1 like '%YRCP%')", rollNo);
            
            if (dt.Rows.Count > 0)
                return dt.Rows[0][0].ToString();

            return "";
        }

        int getNumCondoUnits(string condoID)
        {
            int id = int.Parse(Regex.Match(condoID, @"\d+").Value);

            return vtx.Run(@"
select LEGAL1
from TX_ROLL r
join TX_PROP_DATA p on r.roll_no = p.roll_no
where property_code not in (376, 377)
and (LEGAL1 like '%CONDO%' or LEGAL1 like '%YRSCP%' or LEGAL1 like '%YRCP%')
and LEGAL1 like '%" + id + "%'").Rows.Count;
        }

        private void setEnabled(bool set)
        {
            textBox1.Enabled = set;
            textBox2.Enabled = set;
            textBox3.Enabled = set;
            textBox4.Enabled = set;
            textBox5.Enabled = set;
            textBox7.Enabled = set;
            textBox8.Enabled = set;
            button1.Enabled = set;
            button2.Enabled = set;
            putOnBills.Enabled = set;
            putOnline.Enabled = set;
            linkLabel1.Enabled = set;
            linkLabel2.Enabled = set;
            textBox6.Enabled = set;
            testMode.Enabled = set;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double lowRunoff = textBox5.Text == "" ? 0 : double.Parse(textBox5.Text);
            double mediumRunoff = textBox7.Text == "" ? 0 : double.Parse(textBox7.Text);
            double highRunoff = textBox8.Text == "" ? 0 : double.Parse(textBox8.Text);

            CreditView cv = new CreditView();
            cv.lowRunoff = lowRunoff;
            cv.mediumRunoff = mediumRunoff;
            cv.highRunoff = highRunoff;

            cv.ShowDialog();
        }
        
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Core.export("Stormwater Credits", vtx.Run("select * from stormwatercredits"));
            Core.export("Stormwater", vtx.Run("select * from stormwater where year = " + year));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://stormwater.newmarket.ca/");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            SQL.Run("use stormwater; update systemvariables set setting = '" + textBox5.Text + "' where variable = 'AppRateLow'");
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            SQL.Run("use stormwater; update systemvariables set setting = '" + textBox7.Text + "' where variable = 'AppRateMed'");
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            SQL.Run("use stormwater; update systemvariables set setting = '" + textBox8.Text + "' where variable = 'AppRateHigh'");
        }

        private void putOnline_CheckedChanged(object sender, EventArgs e)
        {
            SQL.Run("use stormwater; update systemvariables set setting = '" + (putOnline.Checked ? "True" : "False") + "' where variable = 'PutOnline'");

            if(putOnline.Checked)
                testMode.Checked = false;
        }

        private void putOnBills_CheckedChanged(object sender, EventArgs e)
        {
            SQL.Run("use stormwater; update systemvariables set setting = '" + (putOnBills.Checked ? "True" : "False") + "' where variable = 'PutOnBills'");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SQL.Run("use stormwater; update systemvariables set setting = '" + textBox1.Text + "' where variable = 'FundingReq'");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SQL.Run("use stormwater; update systemvariables set setting = '" + textBox2.Text + "' where variable = 'ImpLow'");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            SQL.Run("use stormwater; update systemvariables set setting = '" + textBox3.Text + "' where variable = 'ImpMed'");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            SQL.Run("use stormwater; update systemvariables set setting = '" + textBox4.Text + "' where variable = 'ImpHigh'");
        }

        private void testMode_CheckedChanged(object sender, EventArgs e)
        {
            SQL.Run("use stormwater; update systemvariables set setting = '" + (testMode.Checked ? "True" : "False") + "' where variable = 'TestMode'");

            if (testMode.Checked)
            {
                vtx = new Vailtest("");
                putOnline.Checked = false;
            }
            else
                vtx = new Vailtech("");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            SQL.Run("use stormwater; update systemvariables set setting = '" + textBox6.Text + "' where variable = 'TaxYear'");
        }
    }
}
