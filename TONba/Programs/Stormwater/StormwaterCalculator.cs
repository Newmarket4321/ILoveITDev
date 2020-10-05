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
    public partial class Stormwater : Form
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
        Database vtx;

        public Stormwater()
        {
            InitializeComponent();

            label6.Text = "";
            textBox1.Text = SQL.Run("use stormwater; select * from systemvariables where variable='FundingReq'").Rows[0]["Setting"].ToString();
            textBox5.Text = SQL.Run("use stormwater; select * from systemvariables where variable='CalcYear'").Rows[0]["Setting"].ToString();
            textBox2.Text = SQL.Run("use stormwater; select * from systemvariables where variable='ImpLow'").Rows[0]["Setting"].ToString();
            textBox3.Text = SQL.Run("use stormwater; select * from systemvariables where variable='ImpMed'").Rows[0]["Setting"].ToString();
            textBox4.Text = SQL.Run("use stormwater; select * from systemvariables where variable='ImpHigh'").Rows[0]["Setting"].ToString();
            label15.Text = "Last calculated on " + SQL.Run("use stormwater; select * from systemvariables where variable='CalcLast'").Rows[0]["Setting"].ToString();
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
                year = int.Parse(textBox5.Text);

                DataTable assess = vtx.Run("select roll_no, class, sum(ASSESSMENT) as ASSESSMENT from TX_ROLL_ASSESS where ASS_YEAR = " + year + " group by roll_no, class");
                townOwned = vtx.Run("select * from TX_ROLL where trim(OWNER_1) = 'NEWMARKET TOWN'");
                schoolboardOwned = vtx.Run("select * from TX_ROLL where (trim(OWNER_1) not like '%COLLEGE%' and trim(UNIT_CLASS) = 'EDN') or (trim(owner_2) in ('SCHOOL BOARD', 'OF EDUCATION'))");
                totalAssessment = vtx.Run("select roll_no, sum(assessment) from TX_ROLL_ASSESS where ass_year = " + year + " group by roll_no");
                area = vtx.Run("select site_area, uom, roll_no from TX_PROP_DATA");
                greenspace = GISPub.Run("select globalid, sde.st_minx(shape) as left, sde.st_maxx(shape) as right, sde.st_miny(shape) as bottom, sde.st_maxy(shape) as top from sde_plan.zoning where (sde_plan.zoning.ZONE_CODE = 'OS-1' OR sde_plan.zoning.ZONE_CODE = 'OS-2' OR sde_plan.zoning.ZONE_CODE = 'OS-EP' OR sde_plan.zoning.ZONE_CODE = 'RU1-ORM' OR sde_plan.zoning.ZONE_CODE = 'RU2-ORM' OR sde_plan.zoning.ZONE_CODE = 'EP-ORM' OR sde_plan.zoning.ZONE_CODE = 'NC-ORM' OR sde_plan.zoning.ZONE_CODE = 'I-C')");
                riverlands = GISPub.Run("select globalid, sde.st_minx(shape) as left, sde.st_maxx(shape) as right, sde.st_miny(shape) as bottom, sde.st_maxy(shape) as top from tongis.ton_watercourse where tongis.ton_watercourse.class = 'River - Single Line'");
                gisParcels = GISPub.Run("select roll_no,  sde.st_minx(shape) as left, sde.st_maxx(shape) as right, sde.st_miny(shape) as bottom, sde.st_maxy(shape) as top from TONGIS.VIEW_ASMNT_PARCEL");

                DataTable dt = vtx.Run(@"
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

                string[] rollNo = { "040150745310000" };

                for (int i = 0; i < rollNo.Length; i++)
                {
                    //string className = "";
                    //int code = getRunoffCode(rollNo[i], assess.Select(), out className);
                    double area = getArea(rollNo[i]);
                    MessageBox.Show(rollNo[i] + " is area " + area);


                    //MessageBox.Show(rollNo[i] + " is code " + code + " (" + className + ")");
                }
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
            else if (sum(" N", assess) > sum("CHN,CTN,DTN,STN,XTN,YTN,ZTN", assess))
            {
                className = "Exempt";
                ecb = exempt;
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

        public bool isParkingLotOverride(string rollNo)
        {
            DataTable dt = vtx.Run("select * from stormwatervacant where roll_no=@rollno and parking_lot='Y'", rollNo);

            return dt.Rows.Count > 0;
        }

        public void calculateAreas(DataTable dt)
        {
            DataTable assess = vtx.Run(vtx.Query = "select roll_no, class, sum(ASSESSMENT) as ASSESSMENT from TX_ROLL_ASSESS where ASS_YEAR = " + year + " group by roll_no, class");
            startTime = DateTime.Now;

            SQL.Run("use stormwater; delete from RunoffMap where class_name <> 'Parking lot (Override)'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string rollNo = dt.Rows[i][0].ToString();
                string streetNo = "";
                string streetName = "";

                try
                {
                    streetNo = vtx.Run("select street_no from tx_roll where roll_no = '" + rollNo + "'").Rows[0][0].ToString();
                    streetName = vtx.Run("select street_name from tx_roll where roll_no = '" + rollNo + "'").Rows[0][0].ToString();
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
        

        public double getRunoffRateCalc(string level) //Step 10
        {
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

            DataTable dt = vtx.Run(@"
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

            DataTable dt = vtx.Run(@"
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
            DataTable dt = vtx.Run("select LEGAL1 from TX_ROLL where ROLL_NO=@ROLLNO and (LEGAL1 like '%CONDO%' or LEGAL1 like '%YRSCP%' or LEGAL1 like '%YRCP%')", rollNo);
            
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

            return vtx.Run(@"
select LEGAL1
from TX_ROLL r
join TX_PROP_DATA p on r.roll_no = p.roll_no
where property_code not in (376, 377)
and (LEGAL1 like '%CONDO%' or LEGAL1 like '%YRSCP%' or LEGAL1 like '%YRCP%')
and LEGAL1 like '%" + id + "%'").Rows.Count;
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
                for(int i = 0; i < greenspace.Rows.Count; i++)
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

            DataTable temp = vtx.Run("select * from tx_prop_data where roll_no=@ROLL and property_code in (702, 703)", rollNo);

            if (temp.Rows.Count > 0)
                r = true;

            return r;
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
                    catch(FormatException) //Some shape columns have null X/Y values
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
            textBox1.Enabled = set;
            textBox2.Enabled = set;
            textBox3.Enabled = set;
            textBox4.Enabled = set;
            textBox5.Enabled = set;
            button3.Enabled = set;
            button4.Enabled = set;
            linkLabel1.Enabled = set;
            testMode.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VacancyView vv = new VacancyView();
            vv.ShowDialog();
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

                year = int.Parse(textBox5.Text);

                DataTable assess = vtx.Run("select roll_no, class, sum(ASSESSMENT) as ASSESSMENT from TX_ROLL_ASSESS where ASS_YEAR = " + year + " group by roll_no, class");
                townOwned = vtx.Run("select * from TX_ROLL where trim(OWNER_1) = 'NEWMARKET TOWN'");
                schoolboardOwned = vtx.Run("select * from TX_ROLL where (trim(OWNER_1) not like '%COLLEGE%' and trim(UNIT_CLASS) = 'EDN') or (trim(owner_2) in ('SCHOOL BOARD', 'OF EDUCATION'))");
                totalAssessment = vtx.Run("select roll_no, sum(assessment) from TX_ROLL_ASSESS where ass_year = " + year + " group by roll_no");
                area = vtx.Run("select site_area, uom, roll_no from TX_PROP_DATA");
                greenspace = GISPub.Run("select globalid, sde.st_minx(shape) as left, sde.st_maxx(shape) as right, sde.st_miny(shape) as bottom, sde.st_maxy(shape) as top from sde_plan.zoning where (sde_plan.zoning.ZONE_CODE = 'OS-1' OR sde_plan.zoning.ZONE_CODE = 'OS-2' OR sde_plan.zoning.ZONE_CODE = 'OS-EP' OR sde_plan.zoning.ZONE_CODE = 'RU1-ORM' OR sde_plan.zoning.ZONE_CODE = 'RU2-ORM' OR sde_plan.zoning.ZONE_CODE = 'EP-ORM' OR sde_plan.zoning.ZONE_CODE = 'NC-ORM' OR sde_plan.zoning.ZONE_CODE = 'I-C')");
                riverlands = GISPub.Run("select globalid, sde.st_minx(shape) as left, sde.st_maxx(shape) as right, sde.st_miny(shape) as bottom, sde.st_maxy(shape) as top from tongis.ton_watercourse where tongis.ton_watercourse.class = 'River - Single Line'");
                gisParcels = GISPub.Run("select roll_no,  sde.st_minx(shape) as left, sde.st_maxx(shape) as right, sde.st_miny(shape) as bottom, sde.st_maxy(shape) as top from TONGIS.VIEW_ASMNT_PARCEL");

                DataTable dt = vtx.Run(@"
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
                    string low = getRunoffRateCalc("LOW").ToString("F6");
                    string medium = getRunoffRateCalc("MEDIUM").ToString("F6");
                    string high = getRunoffRateCalc("HIGH").ToString("F6");

                    label15.Text = "Last calculated on " + DateTime.Now.ToString("MMMM dd yyyy, hh:mm tt");

                    SQL.Run("use stormwater; update systemvariables set setting = '" + low + "' where variable = 'CalcRateLow'");
                    SQL.Run("use stormwater; update systemvariables set setting = '" + medium + "' where variable = 'CalcRateMed'");
                    SQL.Run("use stormwater; update systemvariables set setting = '" + high + "' where variable = 'CalcRateHigh'");
                    SQL.Run("use stormwater; update systemvariables set setting = '" + DateTime.Now.ToString("MMMM dd yyyy, hh:mm tt") + "' where variable = 'CalcLast'");

                    MessageBox.Show("The runoff rate for LOW was calculated to be " + low + ".");
                    MessageBox.Show("The runoff rate for MEDIUM was calculated to be " + medium + ".");
                    MessageBox.Show("The runoff rate for HIGH was calculated to be " + high + ".");

                    if (MessageBox.Show("Would you like to receive an e-mail receipt?", "E-mail?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            string body = "";

                            body += "Funding Requirement - " + textBox1.Text + Environment.NewLine;
                            body += "Assessment Year - " + textBox5.Text + Environment.NewLine;
                            body += "Low Imperviousness % - " + textBox2.Text + Environment.NewLine;
                            body += "Medium Imperviousness % - " + textBox3.Text + Environment.NewLine;
                            body += "High Imperviousness % - " + textBox4.Text + Environment.NewLine;
                            body += Environment.NewLine;
                            body += "LOW RUNOFF RATE - " + low + Environment.NewLine;
                            body += "MEDIUM RUNOFF RATE - " + medium + Environment.NewLine;
                            body += "HIGH RUNOFF RATE - " + high + Environment.NewLine;

                            bool success;
                            string email = Core.getString("Enter e-mail address", out success);

                            if (success)
                                Core.sendMail(email, "Stormwater Calculation Results", body);
                            else
                                MessageBox.Show("E-mail not sent");
                        }
                        catch
                        {

                        }
                    }

                    setEnabled(true);
                });
            }
            catch (Exception e2)
            {
                Core.error(e2);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Core.export("Stormwater Calculations", SQL.Run("use stormwater; select * from systemvariables where variable in ('CalcRateLow', 'CalcRateMed', 'CalcRateHigh')"));
            Core.export("Stormwater Calculations", SQL.Run("use stormwater; select * from runoffmap"));
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
                vtx = new Vailtest("");
            else
                vtx = new Vailtech("");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            SQL.Run("use stormwater; update systemvariables set setting = '" + textBox5.Text + "' where variable = 'CalcYear'");
        }
    }
}
