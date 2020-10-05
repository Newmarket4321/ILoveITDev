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
    public partial class StormwaterTest : Form
    {
        double lowArea = 0;
        double mediumArea = 0;
        double highArea = 0;
        double exemptArea = 0;
        DateTime startTime;
        int year = -1;
        DataTable townOwned;
        DataTable schoolboardOwned;
        DataTable totalAssessment;
        DataTable area;
        //DataTable runoffMap;
        DataTable greenspace;
        DataTable riverlands;
        DataTable gisParcels;

        public StormwaterTest()
        {
            InitializeComponent();

            label6.Text = "";
            label8.Text = "";
            textBox1.Text = SQL.Run("use stormwater; select * from systemvariables where variable='FundingReq'").Rows[0]["Setting"].ToString();
            textBox6.Text = SQL.Run("use stormwater; select * from systemvariables where variable='CalcYear'").Rows[0]["Setting"].ToString();
            textBox2.Text = SQL.Run("use stormwater; select * from systemvariables where variable='ImpLow'").Rows[0]["Setting"].ToString();
            textBox3.Text = SQL.Run("use stormwater; select * from systemvariables where variable='ImpMed'").Rows[0]["Setting"].ToString();
            textBox4.Text = SQL.Run("use stormwater; select * from systemvariables where variable='ImpHigh'").Rows[0]["Setting"].ToString();
            label15.Text = SQL.Run("use stormwater; select * from systemvariables where variable='CalcLast'").Rows[0]["Setting"].ToString();
            label23.Text = SQL.Run("use stormwater; select * from systemvariables where variable='AppLast'").Rows[0]["Setting"].ToString();
            textBox5.Text = SQL.Run("use stormwater; select * from systemvariables where variable='AppRateLow'").Rows[0]["Setting"].ToString();
            textBox7.Text = SQL.Run("use stormwater; select * from systemvariables where variable='AppRateMed'").Rows[0]["Setting"].ToString();
            textBox8.Text = SQL.Run("use stormwater; select * from systemvariables where variable='AppRateHigh'").Rows[0]["Setting"].ToString();
            putOnBills.Checked = SQL.Run("use stormwater; select * from systemvariables where variable='PutOnBills'").Rows[0]["Setting"].ToString() == "True";
            putOnline.Checked = SQL.Run("use stormwater; select * from systemvariables where variable='PutOnline'").Rows[0]["Setting"].ToString() == "True";

            checkBox2.Checked = SQL.Run("use stormwater; select * from systemvariables where variable='CalcLock'").Rows[0]["Setting"].ToString() == "True";
            checkBox3.Checked = SQL.Run("use stormwater; select * from systemvariables where variable='AppLock'").Rows[0]["Setting"].ToString() == "True";


            //runoffMap = new DataTable();
            //runoffMap.Columns.Add("RollNo");
            //runoffMap.Columns.Add("RunoffCode");
            //runoffMap.Columns.Add("ClassName");

            //string rollNo = "010010028500000";
            //townOwned = Vailtest.Run("select * from TX_ROLL where OWNER_1 = 'NEWMARKET TOWN'");
            //MessageBox.Show(isTownOwned(rollNo).ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setEnabled(false);
            Core.invoke(start);
            //start();
        }

        private void start()
        {
            try
            {
                Invoke((MethodInvoker)delegate {
                    label6.Text = "Calculating overhead...";
                    label6.Update();
                });

                year = int.Parse(textBox6.Text);

                DataTable assess = Vailtest.Run("select roll_no, class, sum(ASSESSMENT) as ASSESSMENT from TX_ROLL_ASSESS where ASS_YEAR = " + year + " group by roll_no, class");
                townOwned = Vailtest.Run("select * from TX_ROLL where OWNER_1 = 'NEWMARKET TOWN'");
                schoolboardOwned = Vailtest.Run("select * from TX_ROLL where OWNER_1 not like '%COLLEGE%' and UNIT_CLASS = 'EDN'");
                totalAssessment = Vailtest.Run("select roll_no, sum(assessment) from TX_ROLL_ASSESS where ass_year = " + year + " group by roll_no");
                area = Vailtest.Run("select site_area, uom, roll_no from TX_PROP_DATA");
                greenspace = GISPub.Run("select globalid, sde.st_minx(shape) as left, sde.st_maxx(shape) as right, sde.st_miny(shape) as bottom, sde.st_maxy(shape) as top from sde_plan.zoning where (sde_plan.zoning.ZONE_CODE = 'OS-1' OR sde_plan.zoning.ZONE_CODE = 'OS-2' OR sde_plan.zoning.ZONE_CODE = 'OS-EP' OR sde_plan.zoning.ZONE_CODE = 'RU1-ORM' OR sde_plan.zoning.ZONE_CODE = 'RU2-ORM' OR sde_plan.zoning.ZONE_CODE = 'EP-ORM' OR sde_plan.zoning.ZONE_CODE = 'NC-ORM' OR sde_plan.zoning.ZONE_CODE = 'I-C')");
                riverlands = GISPub.Run("select globalid, sde.st_minx(shape) as left, sde.st_maxx(shape) as right, sde.st_miny(shape) as bottom, sde.st_maxy(shape) as top from tongis.ton_watercourse where tongis.ton_watercourse.class = 'River - Single Line'");
                gisParcels = GISPub.Run("select roll_no,  sde.st_minx(shape) as left, sde.st_maxx(shape) as right, sde.st_miny(shape) as bottom, sde.st_maxy(shape) as top from TONGIS.VIEW_ASMNT_PARCEL");

                DataTable dt = SQL.Run("use stormwater; select * from runoffmap");

                Vailtest.Run("delete from stormwater where year = " + year);

                if (putOnline.Checked)
                    SQL.Run("use stormwater; delete from results");

                Vailtest.Run("delete from tx_roll_locals where LOCAL_ID = 'SWCHARGE' or LOCAL_ID = 'SWCREDIT'");

                Invoke((MethodInvoker)delegate
                {
                    progressBar2.Maximum = dt.Rows.Count;
                });

                startTime = DateTime.Now;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string rollNo = dt.Rows[i][0].ToString();
                    DataTable info = SQL.Run("use stormwater; select * from runoffmap where roll_no = '" + rollNo + "'");

                    if (info.Rows.Count > 0)
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
                        SQL.Run("use stormwater; update systemvariables set setting = '" + label23.Text + "' where variable = 'AppLast'");
                    }
                    catch
                    {

                    }

                    setEnabled(true);
                    Core.export("Stormwater", Vailtest.Run("select * from stormwater where year = " + year));
                });
            }
            catch (Exception e2)
            {
                Core.error(e2);
            }
        }

        int getRunoffCode(string rollNo, DataRow[] assess, out string className) //Step 6
        {
            const int exempt = 4;
            const int greenspace = 1;
            const int riverland = 1;
            const int utilityAndRailROW = 1;
            const int excessAndVacantLand = 1;
            const int parkingLot = 3;
            const int industrial = 3;
            const int commercial = 3;
            //const int vacant = 3;
            const int singleResidential = 2;
            const int multiResidential = 2;
            const int institutional = 2;
            const int multiResAndInstRevisited = 2;
            const int estate = 1;

            int ecb = 0;
            className = "Unknown";

            double total = getTotalAssessment(rollNo);

            if (isCondo(rollNo))
            {
                assess = getCondoAssessment(getCondoID(rollNo));
                total = getTotalCondoAssessment(getCondoID(rollNo));
            }

            //Classify
            if (isParkingLotOverride(rollNo))
            {
                className = "Parking lot override";
                ecb = parkingLot;
            }
            //else if (isVacant(rollNo))
            //{
            //    className = "Vacant";
            //    ecb = vacant;
            //}
            else if (isTownOwned(rollNo) || isSchoolboardOwned(rollNo))
            {
                className = isTownOwned(rollNo) ? "Town owned" : "Schoolboard owned";
                ecb = exempt;
            }
            else if (isRiverland(rollNo) && sum("RHEP,RTEP,RTES,RTFP,RTFS,RTN,MTEP,MTES,MTFP,MTFS", assess) > 0.8 * total)
            {
                className = "Riverland";
                ecb = riverland;
            }
            else if (isGreenspace(rollNo))
            {
                className = "Greenspace";
                ecb = greenspace;
            }
            else if (sum("PTN,UHN,WGN", assess) > 0) //Rail
            {
                className = "Utility and rail";
                ecb = utilityAndRailROW;
            }
            else if (sum("CKN,CUN,CWN,CXN,FTN,IKN,IUN,IXN,LUN,SUN,XUN,YUN,FTEP", assess) > 0.5 * total)
            {
                className = "Excess and vacant";
                ecb = excessAndVacantLand;
            }
            else if (sum("GTN", assess) > 0.5 * total)
            {
                className = "Parking lot (GTN)";
                ecb = parkingLot;
            }
            else if (sum("RHEP,RTEP,RTES,RTFP,RTFS,RTN", assess) > 0.8 * total && getArea(rollNo) > 4000)
            {
                className = "Estate";
                ecb = estate;
            }
            else if (sum("RHEP,RTEP,RTES,RTFP,RTFS,RTN", assess) > 0.8 * total)
            {
                className = "Single res";
                ecb = singleResidential;
            }
            else if (sum("MTEP,MTES,MTFP,MTFS", assess) > 0.8 * total)
            {
                className = "Multi res";
                ecb = multiResidential;
            }
            else if (sum("CFN,CGN,CPN,DFN,E N", assess) > 0.8 * total)
            {
                className = "Institutional";
                ecb = institutional;
            }
            else if (sum("IHN,ITN,JTN,LTN", assess) > sum("CHN,CTN,DTN,STN,XTN,YTN,ZTN", assess))
            {
                className = "Industrial";
                ecb = industrial;
            }
            else if (sum("CHN,CTN,DTN,STN,XTN,YTN,ZTN", assess) > sum("IHN,ITN,JTN,LTN", assess))
            {
                className = "Commercial";
                ecb = commercial;
            }
            else if (sum("MTEP,MTES,MTFP,MTFS", assess) > 1 && sum("CFN,CGN,CPN,DFN,E N", assess) > 1)
            {
                className = "Multi res and institutional revisited";
                ecb = multiResAndInstRevisited;
            }

            return ecb;
        }

        public bool isVacant(string rollNo)
        {
            Vailtest ora = new Vailtest("select * from stormwatervacant where roll_no=@rollno");
            ora.AddParameter("@rollno", rollNo);
            DataTable dt = ora.Run();

            return dt.Rows.Count > 0;
        }

        public bool isParkingLotOverride(string rollNo)
        {
            Vailtest ora = new Vailtest("select * from stormwatervacant where roll_no=@rollno and parking_lot='Y'");
            ora.AddParameter("@rollno", rollNo);
            DataTable dt = ora.Run();

            return dt.Rows.Count > 0;
        }

        public void calculateAreas(DataTable dt)
        {
            DataTable assess = Vailtest.Run("select roll_no, class, sum(ASSESSMENT) as ASSESSMENT from TX_ROLL_ASSESS where ASS_YEAR = " + year + " group by roll_no, class");
            startTime = DateTime.Now;

            //DataTable dt = Vailtest.Run("select roll_no from TX_ROLL where roll_no like '%0000' and BILLABLE='Y'");
            SQL.Run("use stormwater; delete from RunoffMap where class_name <> 'Parking lot (Override)'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string rollNo = dt.Rows[i][0].ToString();
                string streetNo = "";
                string streetName = "";

                try
                {
                    streetNo = Vailtest.Run("select street_no from tx_roll where roll_no = '" + rollNo + "'").Rows[0][0].ToString();
                    streetName = Vailtest.Run("select street_name from tx_roll where roll_no = '" + rollNo + "'").Rows[0][0].ToString();
                }
                catch
                {

                }
                //string rollNo = "040207201600000";

                //Runoff code (integer, 1-4)
                DataRow[] result = assess.Select("roll_no = " + rollNo);

                string className = "";
                int runoffCode = getRunoffCode(rollNo, result, out className);

                SQL sql = new SQL("use stormwater; select * from runoffmap where roll_no = @ROLLNO"); //Does it already exist?
                sql.AddParameter("@ROLLNO", rollNo);

                if (sql.Run().Rows.Count == 0) //If not, make it
                {
                    sql = new SQL("use stormwater; insert into runoffmap values (@ROLLNO, @RUNOFFCODE, @CLASSNAME, @STREETNO, @STREETNAME)");
                    sql.AddParameter("@ROLLNO", rollNo);
                    sql.AddParameter("@RUNOFFCODE", runoffCode);
                    sql.AddParameter("@CLASSNAME", className);
                    sql.AddParameter("@STREETNO", streetNo);
                    sql.AddParameter("@STREETNAME", streetName);
                    sql.Run();
                }

                //runoffMap.Rows.Add(new object[] { rollNo, runoffCode, className });

                double area = getArea(rollNo);

                if (runoffCode == 1)
                    lowArea += area;
                else if (runoffCode == 2)
                    mediumArea += area;
                else if (runoffCode == 3)
                    highArea += area;
                else if (runoffCode == 4)
                    exemptArea += area;

                Invoke((MethodInvoker)delegate {
                    try
                    {
                        TimeSpan timeSpent = DateTime.Now - startTime;
                        double secondsRemaining = timeSpent.TotalSeconds * (dt.Rows.Count - i) / i;
                        DateTime finish = DateTime.Now.AddSeconds(secondsRemaining);

                        progressBar1.Value++;
                        progressBar1.Update();
                        label6.Text = finish.ToString("T") + " (" + progressBar1.Value.ToString() + " / " + progressBar1.Maximum.ToString() + ")";
                        label6.Update();
                    }
                    catch
                    {

                    }
                });
            }

            Invoke((MethodInvoker)delegate {
                try
                {
                    progressBar1.Value = progressBar1.Maximum;
                    progressBar1.Update();
                    label6.Text = DateTime.Now.ToString("T") + " (" + progressBar1.Value.ToString() + " / " + progressBar1.Maximum.ToString() + ")";
                    label6.Update();
                }
                catch
                {

                }
            });
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

            Vailtest ora = new Vailtest("insert into stormwater values (@ROLLNO, @YEAR, @AREA, @CLASS, @RUNOFF, @RUNOFFRATE, @CHARGE, @REBATE)");
            ora.AddParameter("@ROLLNO", rollNo);
            ora.AddParameter("@YEAR", year);
            ora.AddParameter("@AREA", area);
            ora.AddParameter("@CLASS", className);
            ora.AddParameter("@RUNOFF", runoffCode == 1 ? "LOW" : runoffCode == 2 ? "MEDIUM" : runoffCode == 3 ? "HIGH" : runoffCode == 4 ? "EXEMPT" : "UNKNOWN");
            ora.AddParameter("@RUNOFFRATE", runoffRate);
            ora.AddParameter("@CHARGE", (double)((int)(stormwaterCharge * 100)) / 100);
            ora.AddParameter("@REBATE", credit);
            ora.Run();

            if (putOnBills.Checked)
            {
                if (stormwaterCharge != 0)
                {
                    ora = new Vailtest("insert into tx_roll_locals values (@ROLLNO, @ACTIVITYNO, @LOCALID, @YEARLYCHARGE, @UNITS)");
                    ora.AddParameter("@ROLLNO", rollNo);
                    ora.AddParameter("@ACTIVITYNO", 0);
                    ora.AddParameter("@LOCALID", "SWCHARGE");
                    ora.AddParameter("@YEARLYCHARGE", (double)((int)(stormwaterCharge * 100)) / 100);
                    ora.AddParameter("@UNITS", 0);
                    ora.Run();
                }

                if (credit != 0)
                {
                    ora = new Vailtest("insert into tx_roll_locals values (@ROLLNO, @ACTIVITYNO, @LOCALID, @YEARLYCHARGE, @UNITS)");
                    ora.AddParameter("@ROLLNO", rollNo);
                    ora.AddParameter("@ACTIVITYNO", 0);
                    ora.AddParameter("@LOCALID", "SWCREDIT");
                    ora.AddParameter("@YEARLYCHARGE", credit);
                    ora.AddParameter("@UNITS", 0);
                    ora.Run();
                }
            }

            if (putOnline.Checked && runoffCode != 4 && runoffCode != 0) //If we're putting things online and this one is not exempt
            {
                Vailtest temp = new Vailtest("select block_1_total from tx_billprint where roll_no = @ROLLNO and tax_year = @YEAR and interim_fin_sup = @CODE");
                temp.AddParameter("@ROLLNO", rollNo);
                temp.AddParameter("@HISYEAR", 2016);
                temp.AddParameter("@CODE", "F");
                DataTable tempdt = temp.Run();

                double taxBill = 0;

                if (tempdt.Rows.Count > 0)
                    taxBill = double.Parse(tempdt.Rows[0][0].ToString());

                SQL sql = new SQL("use stormwater; insert into results values (@ROLLNO, @STREETNO, @STREETNAME, @AREA, @RUNOFFLEVEL, @RATE, @CHARGE, @TAXBILL)");
                sql.AddParameter("@ROLLNO", rollNo);
                sql.AddParameter("@STREETNO", Vailtest.Run("select street_no from tx_roll where roll_no = " + rollNo).Rows[0][0].ToString());
                sql.AddParameter("@STREETNAME", Vailtest.Run("select street_name from tx_roll where roll_no = " + rollNo).Rows[0][0].ToString());
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
            Vailtest ora = new Vailtest("select * from stormwatercredits where roll_no = @rollno and expiry >= @TODAY");
            ora.AddParameter("@rollno", rollNo);
            ora.AddParameter("@TODAY", DateTime.Today);
            DataTable dt = ora.Run();

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
            Vailtest ora = new Vailtest("select * from stormwatercredits where roll_no = @rollno and expiry >= @TODAY");
            ora.AddParameter("@rollno", rollNo);
            ora.AddParameter("@TODAY", DateTime.Today);
            DataTable dt = ora.Run();

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

        public double getRunoffRateCalc(string level) //Step 10
        {
            double totalAssessment = getTotalAssessment();
            double fundingRequirement = getFundingRequirement();
            double swmRate = fundingRequirement / totalAssessment;

            return swmRate * getRunoffImperviousness(level);
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

        public DataRow[] getCondoAssessment(string condoID)
        {
            int id = int.Parse(Regex.Match(condoID, @"\d+").Value);

            Vailtest ora = new Vailtest(@"
select
class,
sum(assessment) as ASSESSMENT

from TX_ROLL r
join TX_ROLL_ASSESS a
    on r.ROLL_NO = a.ROLL_NO
    and r.ACTIVITY_NO = a.ACTIVITY_NO

where
    (LEGAL1 like '%CONDO%'
    or LEGAL1 like '%YRSCP%'
    or LEGAL1 like '%YRCP%')
and LEGAL1 like '%" + id + @"%'
and ASS_YEAR = " + year + @"

group by class");
            DataTable dt = ora.Run();

            return dt.Select();
        }

        public double getTotalAssessment(string rollNo)
        {
            DataRow[] rows = totalAssessment.Select("roll_no = " + rollNo);

            if (rows.Length > 0)
                return double.Parse(rows[0][1].ToString());

            return 0;
        }

        public double getTotalCondoAssessment(string condoID)
        {
            int id = int.Parse(Regex.Match(condoID, @"\d+").Value);

            Vailtest ora = new Vailtest(@"
select sum(assessment)
from TX_ROLL r
join TX_ROLL_ASSESS a
    on r.ROLL_NO = a.ROLL_NO
    and r.ACTIVITY_NO = a.ACTIVITY_NO
where
    (LEGAL1 like '%CONDO%'
    or LEGAL1 like '%YRSCP%'
    or LEGAL1 like '%YRCP%')
and LEGAL1 like '%" + id + @"%'
and ASS_YEAR = " + year + @"");
            DataTable dt = ora.Run();

            try
            {
                if (dt.Rows.Count > 0)
                    return double.Parse(dt.Rows[0][0].ToString());
            }
            catch
            {

            }

            return 0;
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
            return double.Parse(textBox1.Text.Replace("$", "").Replace(",", "").Trim());
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
            Vailtest ora = new Vailtest("select LEGAL1 from TX_ROLL where ROLL_NO=@ROLLNO and (LEGAL1 like '%CONDO%' or LEGAL1 like '%YRSCP%' or LEGAL1 like '%YRCP%')");
            ora.AddParameter("@ROLLNO", rollNo);
            DataTable dt = ora.Run();

            if (dt.Rows.Count > 0)
                return dt.Rows[0][0].ToString();

            return "";
        }

        bool isCondo(string rollNo)
        {
            return getCondoID(rollNo) != "";
        }

        int getNumCondoUnits(string condoID)
        {
            int id = int.Parse(Regex.Match(condoID, @"\d+").Value);

            Vailtest ora = new Vailtest(@"
select LEGAL1
from TX_ROLL r
join TX_PROPERTY_DATA p on r.roll_no = p.roll_no
where property_code not in (376, 377)
and (LEGAL1 like '%CONDO%' or LEGAL1 like '%YRSCP%' or LEGAL1 like '%YRCP%')
and LEGAL1 like '%" + id + "%'");
            DataTable dt = ora.Run();

            return dt.Rows.Count;
        }

        double sum(string pre, DataRow[] assess)
        {
            string[] classes = pre.Split(',');
            double r = 0;

            foreach (DataRow row in assess)
            {
                foreach (string cl in classes)
                    if (row["CLASS"].ToString() == cl)
                        r += double.Parse(row["ASSESSMENT"].ToString());
            }

            return r;
        }

        public bool isGreenspace(string rollNo) //Step 1
        {
            bool r = false;
            DataRow[] parcel = gisParcels.Select("roll_no = " + rollNo);

            if (parcel.Length != 0)
            {
                for (int i = 0; i < greenspace.Rows.Count; i++)
                {
                    try
                    {
                        if (double.Parse(parcel[0]["left"].ToString()) <= double.Parse(greenspace.Rows[i]["right"].ToString()) &&
       double.Parse(parcel[0]["right"].ToString()) >= double.Parse(greenspace.Rows[i]["left"].ToString()) &&
       double.Parse(parcel[0]["bottom"].ToString()) <= double.Parse(greenspace.Rows[i]["top"].ToString()) &&
       double.Parse(parcel[0]["top"].ToString()) >= double.Parse(greenspace.Rows[i]["bottom"].ToString()))
                        {
                            DataTable dt = GISPub.Run(@"
select TONGIS.VIEW_ASMNT_PARCEL.roll_no

from sde_plan.zoning, TONGIS.VIEW_ASMNT_PARCEL
                            
where sde_plan.zoning.ZONE_CODE in ('OS-1', 'OS-2', 'OS-EP', 'RU1-ORM', 'RU2-ORM', 'EP-ORM', 'NC-ORM', 'I-C')
and sde.st_within(sde.st_centroid(TONGIS.VIEW_ASMNT_PARCEL.shape), sde_plan.zoning.shape) = 1
and sde_plan.zoning.globalid = '" + greenspace.Rows[i]["globalid"].ToString() + @"'
and TONGIS.VIEW_ASMNT_PARCEL.roll_no = '" + rollNo + "'");

                            if (dt.Rows.Count > 0)
                                r = true;
                        }
                    }
                    catch (FormatException) //Some shape columns have null X/Y values
                    {

                    }
                }
            }

            DataTable temp = Vailtest.Run("select * from Vailtest.tx_prop_data where roll_no=@ROLL and property_code in (702, 703)", rollNo);

            if (temp.Rows.Count > 0)
                r = true;

            return r;
        }

        public bool isCemetary(string rollNo) //Step 1
        {
            DataRow[] parcel = gisParcels.Select("roll_no = " + rollNo);

            if (parcel.Length == 0)
                return false;
            else
            {
                for (int i = 0; i < greenspace.Rows.Count; i++)
                {
                    try
                    {
                        if (double.Parse(parcel[0]["left"].ToString()) <= double.Parse(greenspace.Rows[i]["right"].ToString()) &&
       double.Parse(parcel[0]["right"].ToString()) >= double.Parse(greenspace.Rows[i]["left"].ToString()) &&
       double.Parse(parcel[0]["bottom"].ToString()) <= double.Parse(greenspace.Rows[i]["top"].ToString()) &&
       double.Parse(parcel[0]["top"].ToString()) >= double.Parse(greenspace.Rows[i]["bottom"].ToString()))
                        {
                            DataTable dt = GISPub.Run(@"
                            select TONGIS.VIEW_ASMNT_PARCEL.roll_no
                            from sde_plan.zoning, TONGIS.VIEW_ASMNT_PARCEL
                            where sde_plan.zoning.ZONE_CODE = 'I-C'
                            and sde.st_within(sde.st_centroid(TONGIS.VIEW_ASMNT_PARCEL.shape), sde_plan.zoning.shape) = 1
                            and sde_plan.zoning.globalid = '" + greenspace.Rows[i]["globalid"].ToString() + @"'
                            and TONGIS.VIEW_ASMNT_PARCEL.roll_no = '" + rollNo + "'");

                            if (dt.Rows.Count > 0)
                                return true;
                        }
                    }
                    catch (FormatException) //Some shape columns have null X/Y values
                    {

                    }
                }

                return false;
            }
        }

        public bool isRiverland(string rollNo) //Step 1
        {
            DataRow[] parcel = gisParcels.Select("roll_no = " + rollNo);

            if (parcel.Length == 0)
                return false;
            else
            {
                for (int i = 0; i < riverlands.Rows.Count; i++)
                {
                    try
                    {
                        if (double.Parse(parcel[0]["left"].ToString()) <= double.Parse(riverlands.Rows[i]["right"].ToString()) &&
       double.Parse(parcel[0]["right"].ToString()) >= double.Parse(riverlands.Rows[i]["left"].ToString()) &&
       double.Parse(parcel[0]["bottom"].ToString()) <= double.Parse(riverlands.Rows[i]["top"].ToString()) &&
       double.Parse(parcel[0]["top"].ToString()) >= double.Parse(riverlands.Rows[i]["bottom"].ToString()))
                        {
                            DataTable dt = GISPub.Run(@"
            select TONGIS.VIEW_ASMNT_PARCEL.roll_no
            from tongis.ton_watercourse, TONGIS.VIEW_ASMNT_PARCEL
            where
            tongis.ton_watercourse.class = 'River - Single Line'
            and sde.st_intersects(TONGIS.VIEW_ASMNT_PARCEL.shape, tongis.ton_watercourse.shape) = 1
            and tongis.ton_watercourse.globalid = '" + riverlands.Rows[i]["globalid"].ToString() + @"'
            and TONGIS.VIEW_ASMNT_PARCEL.roll_no = '" + rollNo + "'");

                            if (dt.Rows.Count > 0)
                                return true;
                        }
                    }
                    catch (FormatException) //Some shape columns have null X/Y values
                    {

                    }
                }

                return false;
            }
        }

        public bool isTownOwned(string rollNo) //Step 1
        {
            DataRow[] rows = townOwned.Select("roll_no = " + rollNo);

            foreach (DataRow row in rows)
                return true;

            return false;
        }

        public bool isSchoolboardOwned(string rollNo) //Step 1
        {
            DataRow[] rows = schoolboardOwned.Select("roll_no = " + rollNo);

            foreach (DataRow row in rows)
                return true;

            return false;
        }

        private void setEnabled(bool set)
        {
            textBox1.Enabled = set && !checkBox2.Checked;
            textBox2.Enabled = set && !checkBox2.Checked;
            textBox3.Enabled = set && !checkBox2.Checked;
            textBox4.Enabled = set && !checkBox2.Checked;
            textBox5.Enabled = set && !checkBox3.Checked;
            textBox6.Enabled = set && !checkBox2.Checked;
            textBox7.Enabled = set && !checkBox3.Checked;
            textBox8.Enabled = set && !checkBox3.Checked;
            button1.Enabled = set;
            button2.Enabled = set;
            button3.Enabled = set;
            button4.Enabled = set;
            putOnBills.Enabled = set && !checkBox3.Checked;
            putOnline.Enabled = set && !checkBox3.Checked;
            checkBox2.Enabled = set;
            checkBox3.Enabled = set;
            linkLabel1.Enabled = set;
            linkLabel2.Enabled = set;
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

        private void button3_Click(object sender, EventArgs e)
        {
            VacancyView vv = new VacancyView();
            vv.ShowDialog();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = !checkBox2.Checked;
            textBox6.Enabled = !checkBox2.Checked;
            textBox2.Enabled = !checkBox2.Checked;
            textBox3.Enabled = !checkBox2.Checked;
            textBox4.Enabled = !checkBox2.Checked;
            button3.Enabled = !checkBox2.Checked;

            if (checkBox2.Checked)
            {
                SQL.Run("use stormwater; update systemvariables set setting = '" + textBox1.Text + "' where variable = 'FundingReq'");
                SQL.Run("use stormwater; update systemvariables set setting = '" + textBox6.Text + "' where variable = 'CalcYear'");
                SQL.Run("use stormwater; update systemvariables set setting = '" + textBox2.Text + "' where variable = 'ImpLow'");
                SQL.Run("use stormwater; update systemvariables set setting = '" + textBox3.Text + "' where variable = 'ImpMed'");
                SQL.Run("use stormwater; update systemvariables set setting = '" + textBox4.Text + "' where variable = 'ImpHigh'");
            }

            SQL.Run("use stormwater; update systemvariables set setting = '" + (checkBox2.Checked ? "True" : "False") + "' where variable = 'CalcLock'");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setEnabled(false);
            Core.invoke(calculate);
            //start();
        }

        private void calculate()
        {
            try
            {
                Invoke((MethodInvoker)delegate {
                    label6.Text = "Calculating overhead...";
                    label6.Update();
                });

                year = int.Parse(textBox6.Text);

                DataTable assess = Vailtest.Run("select roll_no, class, sum(ASSESSMENT) as ASSESSMENT from TX_ROLL_ASSESS where ASS_YEAR = " + year + " group by roll_no, class");
                townOwned = Vailtest.Run("select * from TX_ROLL where OWNER_1 = 'NEWMARKET TOWN'");
                schoolboardOwned = Vailtest.Run("select * from TX_ROLL where OWNER_1 not like '%COLLEGE%' and UNIT_CLASS = 'EDN'");
                totalAssessment = Vailtest.Run("select roll_no, sum(assessment) from TX_ROLL_ASSESS where ass_year = " + year + " group by roll_no");
                area = Vailtest.Run("select site_area, uom, roll_no from TX_PROP_DATA");
                greenspace = GISPub.Run("select globalid, sde.st_minx(shape) as left, sde.st_maxx(shape) as right, sde.st_miny(shape) as bottom, sde.st_maxy(shape) as top from sde_plan.zoning where (sde_plan.zoning.ZONE_CODE = 'OS-1' OR sde_plan.zoning.ZONE_CODE = 'OS-2' OR sde_plan.zoning.ZONE_CODE = 'OS-EP' OR sde_plan.zoning.ZONE_CODE = 'RU1-ORM' OR sde_plan.zoning.ZONE_CODE = 'RU2-ORM' OR sde_plan.zoning.ZONE_CODE = 'EP-ORM' OR sde_plan.zoning.ZONE_CODE = 'NC-ORM' OR sde_plan.zoning.ZONE_CODE = 'I-C')");
                riverlands = GISPub.Run("select globalid, sde.st_minx(shape) as left, sde.st_maxx(shape) as right, sde.st_miny(shape) as bottom, sde.st_maxy(shape) as top from tongis.ton_watercourse where tongis.ton_watercourse.class = 'River - Single Line'");
                gisParcels = GISPub.Run("select roll_no,  sde.st_minx(shape) as left, sde.st_maxx(shape) as right, sde.st_miny(shape) as bottom, sde.st_maxy(shape) as top from TONGIS.VIEW_ASMNT_PARCEL");

                DataTable dt = Vailtest.Run(@"
select roll_no

from TX_ROLL

where roll_no like '%0000'
and BILLABLE='Y'
and roll_no not in ('010010014000000',
                    '020110034000000',
                    '020111669000000',
                    '040160100000000',
                    '040161346010000')

and ' ' || LEGAL1 not like '%PKG%'
and ' ' || LEGAL2 not like '%PKG%'
and ' ' || LEGAL3 not like '%PKG%'
and ' ' || LEGAL4 not like '%PKG%'
and ' ' || LEGAL5 not like '%PKG%'");

                Invoke((MethodInvoker)delegate
                {
                    progressBar1.Maximum = dt.Rows.Count;
                });

                calculateAreas(dt);

                Invoke((MethodInvoker)delegate
                {
                    textBox9.Text = getRunoffRateCalc("LOW").ToString("F6");
                    textBox10.Text = getRunoffRateCalc("MEDIUM").ToString("F6");
                    textBox11.Text = getRunoffRateCalc("HIGH").ToString("F6");
                    label15.Text = "Last calculated on " + DateTime.Now.ToString("MMMM dd yyyy, hh:mm tt");
                    SQL.Run("use stormwater; update systemvariables set setting = '" + textBox9.Text + "' where variable = 'CalcRateLow'");
                    SQL.Run("use stormwater; update systemvariables set setting = '" + textBox10.Text + "' where variable = 'CalcRateMed'");
                    SQL.Run("use stormwater; update systemvariables set setting = '" + textBox11.Text + "' where variable = 'CalcRateHigh'");
                    SQL.Run("use stormwater; update systemvariables set setting = '" + label15.Text + "' where variable = 'CalcLast'");

                    setEnabled(true);
                });
            }
            catch (Exception e2)
            {
                Core.error(e2);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = !checkBox3.Checked;
            textBox7.Enabled = !checkBox3.Checked;
            textBox8.Enabled = !checkBox3.Checked;
            putOnBills.Enabled = !checkBox3.Checked;
            putOnline.Enabled = !checkBox3.Checked;
            button2.Enabled = !checkBox3.Checked;

            if (checkBox3.Checked)
            {
                SQL.Run("use stormwater; update systemvariables set setting = '" + textBox5.Text + "' where variable = 'AppRateLow'");
                SQL.Run("use stormwater; update systemvariables set setting = '" + textBox7.Text + "' where variable = 'AppRateMed'");
                SQL.Run("use stormwater; update systemvariables set setting = '" + textBox8.Text + "' where variable = 'AppRateHigh'");
                SQL.Run("use stormwater; update systemvariables set setting = '" + (putOnBills.Checked ? "True" : "False") + "' where variable = 'PutOnBills'");
                SQL.Run("use stormwater; update systemvariables set setting = '" + (putOnline.Checked ? "True" : "False") + "' where variable = 'PutOnline'");
            }

            SQL.Run("use stormwater; update systemvariables set setting = '" + (checkBox3.Checked ? "True" : "False") + "' where variable = 'AppLock'");
        }

        private void Stormwater_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Core.export("Stormwater Calculations", SQL.Run("use stormwater; select * from systemvariables where variable in ('CalcRateLow', 'CalcRateMed', 'CalcRateHigh')"));
            Core.export("Stormwater Calculations", SQL.Run("use stormwater; select * from runoffmap"));
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Core.export("Stormwater Credits", Vailtest.Run("select * from stormwatercredits"));
            Core.export("Stormwater Calculations", SQL.Run("use stormwater; select * from results"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setEnabled(false);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            setEnabled(true);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string output = "";

            DataTable assess = Vailtest.Run("select roll_no, class, sum(ASSESSMENT) as ASSESSMENT from TX_ROLL_ASSESS where ASS_YEAR = " + year + " group by roll_no, class");
            townOwned = Vailtest.Run("select * from TX_ROLL where OWNER_1 = 'NEWMARKET TOWN'");
            schoolboardOwned = Vailtest.Run("select * from TX_ROLL where OWNER_1 not like '%COLLEGE%' and UNIT_CLASS = 'EDN'");
            totalAssessment = Vailtest.Run("select roll_no, sum(assessment) from TX_ROLL_ASSESS where ass_year = " + year + " group by roll_no");
            area = Vailtest.Run("select site_area, uom, roll_no from TX_PROP_DATA");
            greenspace = GISPub.Run("select globalid, sde.st_minx(shape) as left, sde.st_maxx(shape) as right, sde.st_miny(shape) as bottom, sde.st_maxy(shape) as top from sde_plan.zoning where (sde_plan.zoning.ZONE_CODE = 'OS-1' OR sde_plan.zoning.ZONE_CODE = 'OS-2' OR sde_plan.zoning.ZONE_CODE = 'OS-EP' OR sde_plan.zoning.ZONE_CODE = 'RU1-ORM' OR sde_plan.zoning.ZONE_CODE = 'RU2-ORM' OR sde_plan.zoning.ZONE_CODE = 'EP-ORM' OR sde_plan.zoning.ZONE_CODE = 'NC-ORM' OR sde_plan.zoning.ZONE_CODE = 'I-C')");
            riverlands = GISPub.Run("select globalid, sde.st_minx(shape) as left, sde.st_maxx(shape) as right, sde.st_miny(shape) as bottom, sde.st_maxy(shape) as top from tongis.ton_watercourse where tongis.ton_watercourse.class = 'River - Single Line'");
            gisParcels = GISPub.Run("select roll_no,  sde.st_minx(shape) as left, sde.st_maxx(shape) as right, sde.st_miny(shape) as bottom, sde.st_maxy(shape) as top from TONGIS.VIEW_ASMNT_PARCEL");

            DataTable dt = Vailtest.Run(@"
select roll_no, STREET_NO, STREET_NAME, OWNER_1, OWNER_2, OWNER_3

from TX_ROLL

where roll_no like '%0000'
and BILLABLE='Y'
and roll_no not in ('010010014000000',
                    '020110034000000',
                    '020111669000000',
                    '040160100000000')

and ' ' || LEGAL1 not like '%PKG%'
and ' ' || LEGAL2 not like '%PKG%'
and ' ' || LEGAL3 not like '%PKG%'
and ' ' || LEGAL4 not like '%PKG%'
and ' ' || LEGAL5 not like '%PKG%'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (isGreenspace(dt.Rows[i][0].ToString()))
                    output += dt.Rows[i][0].ToString() + " " + dt.Rows[i]["STREET_NO"].ToString() + " " + dt.Rows[i]["STREET_NAME"].ToString() + " " + dt.Rows[i]["OWNER_1"].ToString() + " " + dt.Rows[i]["OWNER_2"].ToString() + " " + dt.Rows[i]["OWNER_3"].ToString() + Environment.NewLine;
            }

            Core.sendMail("gsmyth@newmarket.ca", "I-C", output);
        }
    }
}
