using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_IT
{
    class CityViewToAccelaDataPort
    {
        int nextRefer = 1;

        string g(DataTable dt, int i, string s)
        {
            return dt.Rows[i][s].ToString();
        }

        string g(DataTable dt, int i, string s, int length)
        {
            string x = g(dt, i, s);

            if (x.Length < length)
                return x;
            else
                return x.Substring(0, length);
        }

       

        public CityViewToAccelaDataPort()
        {
            
            //bool PermitHistory = true;
            //bool PermitStatus = true;
            //bool PermitAddress = true;
            //bool PermitComment = false; //Keep off for now; not needed
            //bool PermitFee = true; //Keep off for now; use when CityView data is cleaned up
            //bool PermitFeeAllocation = true; //Keep off for now; use when CityView data is cleaned up
            //bool PermitInsp = true;
            //bool PermitCustomFixtures = true; //Turned it On;  CityView
            //bool PermitCustomEngineering = true; //Turned it On;  CityView
            //bool PermitParcel = true;
            //bool PermitPeople = true;
            //bool ReferPeople = false;
            //bool ReferActivity = false;
            //bool PermitReferral = true;
            //bool PermitOntarioNewHome = true;
            //bool PermitApplicationInformation = true;
            //bool PermitPurposeofApplication = true;


            //testing
            bool PermitHistory = false; 
            bool PermitStatus = false; 
            bool PermitAddress = false; 
            bool PermitComment = false; //Keep off for now; not needed
            bool PermitFee = false; //Keep off for now; use when CityView data is cleaned up
            bool PermitFeeAllocation = false; //Keep off for now; use when CityView data is cleaned up
            bool PermitInsp = false;
            bool PermitCustomFixtures = false; //Turned it On;  CityView 
            bool PermitCustomEngineering = false; //Turned it On;  CityView
            bool PermitParcel = false; 
            bool PermitPeople = false; 
            bool ReferPeople = false;
            bool ReferActivity = false;
            bool PermitReferral = false; 
            bool PermitOntarioNewHome = false; 
            bool PermitApplicationInformation = false; 
            bool PermitPurposeofApplication = false; 


            //   bool PermitHistory = true; // RW off for testing 
            //   bool PermitStatus = true;
            //   bool PermitAddress = true;
            //   bool PermitComment = false; //Keep off for now; not needed
            //   bool PermitFee = true; //Keep off for now; use when CityView data is cleaned up
            //   bool PermitFeeAllocation = true; //Keep off for now; use when CityView data is cleaned up
            //   bool PermitInsp = true;
            //   bool PermitCustomFixtures = true;
            //   bool PermitCustomEngineering = true;
            //   bool PermitParcel = true;
            //   bool PermitPeople = true;
            //   bool ReferPeople = true;
            //   bool ReferActivity = true;

            DataTable temp;
            //DataTable bp = CityView.Run(@"
            //select *
            //from sysadmin.building_permits p
            //where trim(APPLICATION_NUMBER) is not null
            //and APPLICATION_NUMBER <> '+'
            //and APPLICATION_NUMBER not like 'prw%'
            //and assess_ID is not null
            //and application_status in ('ISS', 'C')

            //");
            //DataTable bp = CityView.Run(@"
            //    select * from sysadmin.building_permits 
            //    LEFT JOIN sysadmin.bp_additional 
            //    on sysadmin.bp_additional.bi_app_id = sysadmin.building_permits.RECORDID
            //");
            DataTable bp = CityView.Run("select * from sysadmin.building_permits");


            DataTable bv = CityView.Run("select * from sysadmin.building_violations Left JOIN sysadmin.assess on sysadmin.building_violations.assess_id = sysadmin.assess.recordid");

            /*
and exists (select 1 from sysadmin.inspections where bi_app_id=p.RecordID and Inspectiontype='FINAL' and FINAL=1 and inspectioncomplete=1)
and exists (select 1 from sysadmin.bi_fees where bi_app_id=p.recordID)
and exists (select 1 from sysadmin.bi_payments where bi_app_id=p.recordid)
and exists (select 1 from sysadmin.chequereqtable where bi_app_id=p.recordid)             
             */

            //comment out the vi  DataTable vi = CityView.Run("select * from sysadmin.violations where violation_id is not null and rownum=1");

            Console.WriteLine("Starting. The time is currently " + DateTime.Now.ToString() + ".");

            Core.sendMail("ealarcon@newmarket.ca", "CityViewtoAccelaDataPort", "Starting now:"+ DateTime.Now.ToString());
            /*
            if (PermitHistory)
                SQL.Run("use accelastage; delete from AATable_Permit_History");

            if (PermitStatus)
                SQL.Run("use accelastage; delete from AATable_Permit_Status");

            if (PermitAddress)
                SQL.Run("use accelastage; delete from AATable_Permit_Address");

            if (PermitComment)
                SQL.Run("use accelastage; delete from AATable_Permit_Comment");

            if (PermitFee)
                SQL.Run("use accelastage; delete from AATable_Permit_Fee");

            if (PermitFeeAllocation)
                SQL.Run("use accelastage; delete from AATable_Permit_FeeAllocation");

            if (PermitInsp)
                // Console.WriteLine("deleting record insp");
                SQL.Run("use accelastage; delete from AATable_Permit_Insp");

            if (PermitCustomFixtures)
                SQL.Run("use accelastage; delete from AATable_Permit_ASI_Fixtures");

            if (PermitCustomEngineering)
                SQL.Run("use accelastage; delete from AATable_Permit_ASI_Engineering");

            if (PermitParcel)
                SQL.Run("use accelastage; delete from AATable_Permit_Parcel");

            if (PermitPeople)
                SQL.Run("use accelastage; delete from AATable_Permit_People");

            if (ReferPeople)
                SQL.Run("use accelastage; delete from AATABLE_REFER_PEOPLE");

            if (ReferActivity)
                SQL.Run("use accelastage; delete from AATABLE_PERMIT_ACTIVITY");

            SQL.Run("use accelastage; delete from AATable_Permit_Comment");
            */

            //Enter building permits into AATable_Permit_History
           
            if (PermitHistory)
            {
                var count = 0;
                //Console.WriteLine("adding record to permit history");
                for (int i = 0; i < bp.Rows.Count; i++)
                {
                    SQL sql = new SQL(@"
            use accelastage;
            insert into aatable_permit_history
            (
            PERMITNUM,
            TT_RECORD,
            PROJECTVALUATION,
            DATEOPENED,
            LIC_EXPR_DATE,
            TT_RECORD_STATUS,
            WORK_DESC,
            APP_NAME,
            HOUSE_COUNT,
            BUILDING_COUNT,
            PUBLIC_OWNED,
            CONST_TYPE_CODE,
            LIC_STATUS,
            SHORT_NOTES,
            ASGN_DEPT,
            ASGN_STAFF,
            ASGN_DATE,
            COMPLETED_DEPT,
            COMPLETED_BY,
            COMPLETED_DATE,
            SCHEDULED_DATE,
            PRIORITY,
            TOTAL_JOB_COST,
            CLOSED_DATE,
            CLOSED_BY,
            IVR_TRACKING_NUM,
            CREATED_BY,
            REPORTED_CHANNEL,
            CREATED_BY_DEPT,
            FIRST_ISSUED_DATE,
            ANONYMOUS_FLAG,
            REFERENCE_TYPE,
            APPEARANCE_DAYOFWEEK,
            APPEARANCE_DATE,
            BOOKING_FLAG,
            DEFENDANT_SIGNATURE_FLAG,
            ENFORCE_OFFICER_ID,
            ENFORCE_OFFICER_NAME,
            INFRACTION_FLAG,
            INSPECTOR_ID,
            MISDEMEANOR_FLAG,
            OFFENCE_WITNESSED_FLAG,
            INSPECTOR_NAME,
            ENFORCE_DEPT,
            INSPECTOR_DEPT,
            VALUATION_MULTIPLIER,
            VALUATION_EXTRA_AMT,
            LAST_AUDIT_DATE,
            APP_STATUS_DATE,
            DELEGATE_USER_ID
            )
            values (
            @PERMITNUM,
            @TT_RECORD,
            @PROJECTVALUATION,
            @DATEOPENED,
            @LIC_EXPR_DATE,
            @TT_RECORD_STATUS,
            @WORK_DESC,
            @APP_NAME,
            @HOUSE_COUNT,
            @BUILDING_COUNT,
            @PUBLIC_OWNED,
            @CONST_TYPE_CODE,
            @LIC_STATUS,
            @SHORT_NOTES,
            @ASGN_DEPT,
            @ASGN_STAFF,
            @ASGN_DATE,
            @COMPLETED_DEPT,
            @COMPLETED_BY,
            @COMPLETED_DATE,
            @SCHEDULED_DATE,
            @PRIORITY,
            @TOTAL_JOB_COST,
            @CLOSED_DATE,
            @CLOSED_BY,
            @IVR_TRACKING_NUM,
            @CREATED_BY,
            @REPORTED_CHANNEL,
            @CREATED_BY_DEPT,
            @FIRST_ISSUED_DATE,
            @ANONYMOUS_FLAG,
            @REFERENCE_TYPE,
            @APPEARANCE_DAYOFWEEK,
            @APPEARANCE_DATE,
            @BOOKING_FLAG,
            @DEFENDANT_SIGNATURE_FLAG,
            @ENFORCE_OFFICER_ID,
            @ENFORCE_OFFICER_NAME,
            @INFRACTION_FLAG,
            @INSPECTOR_ID,
            @MISDEMEANOR_FLAG,
            @OFFENCE_WITNESSED_FLAG,
            @INSPECTOR_NAME,
            @ENFORCE_DEPT,
            @INSPECTOR_DEPT,
            @VALUATION_MULTIPLIER,
            @VALUATION_EXTRA_AMT,
            @LAST_AUDIT_DATE,
            @APP_STATUS_DATE,
            @DELEGATE_USER_ID
            )");

                    string[] ADU = new string[] {
                        "A2019-00318",
                        "P2010-00020",
                        "A2010-00851",
                        "P2010-00722",
                        "P2010-00961",
                        "P2010-00547",
                        "P2010-00548",
                        "A2010-00813",
                        "P2010-00831",
                        "P2010-00934",
                        "P2010-00534",
                        "P2010-00282",
                        "P2010-00261",
                        "P2010-00944",
                        "P2010-00723",
                        "P2011-00478",
                        "P2011-00479",
                        "P2011-00561",
                        "P2019-00036",
                        "P2018-00040",
                        "P2018-00224",
                        "P2019-00493",
                        "P2017-00517",
                        "P2017-00561",
                        "P2018-00037",
                        "P2019-00396",
                        "P2019-00121",
                        "P2016-00292",
                        "P2016-00133",
                        "A2016-00118",
                        "P2016-00173",
                        "P2016-00069",
                        "P2015-00763",
                        "P2016-00068",
                        "P2015-00959",
                        "A2020-00005",
                        "P2018-00235",
                        "P2016-00335",
                        "P2016-00353",
                        "P2019-00035",
                        "P2019-00420",
                        "P2013-00308",
                        "P2013-00213",
                        "P2013-00300",
                        "P2013-00893",
                        "A2013-00900",
                        "P2014-00302",
                        "P2017-00615",
                        "P2012-00055",
                        "P2015-00961",
                        "P2011-00672",
                        "P2011-00497",
                        "P2012-00392",
                        "P2012-00579",
                        "P2012-00381",
                        "P2012-00738",
                        "P2012-00576",
                        "P2013-00765",
                        "P2013-00762",
                        "P2013-00767",
                        "P2013-00048",
                        "P2013-00860",
                        "P2014-00136",
                        "P2014-00361",
                        "P2014-00583",
                        "A2014-00674",
                        "P2015-00422",
                        "P2015-00790",
                        "P2015-00479",
                        "P2015-00792",
                        "P2015-00685",
                        "P2015-00672",
                        "P2015-00347",
                        "P2015-00601",
                        "P2015-00736",
                        "P2015-00644",
                        "P2015-00610",
                        "P2016-00222",
                        "P2016-00247",
                        "P2017-00264",
                        "P2017-00076",
                        "P2014-00359",
                        "P2017-00826",
                        "P2019-00267",
                        "P2019-00527",
                        "P2019-00328",
                        "P2013-00798",
                        "P2013-00662",
                        "P2013-00314",
                        "P2014-00584",
                        "P2014-00363",
                        "P2018-00301",
                        "P2018-00002",
                        "P2018-00661",
                        "P2019-00324",
                        "P2018-00699",
                        "P2018-00688",
                        "P2018-00284",
                        "P2019-00426",
                        "P2019-00293",
                        "P2018-00373",
                        "P2019-00321",
                        "P2019-00064",
                        "A2019-00501",
                        "P2019-00246",
                        "P2019-00483",
                        "P2015-00830",
                        "P2015-00461",
                        "P2015-00842",
                        "P2013-00872",
                        "P2015-00891",
                        "P2018-00271",
                        "P2019-00270",
                        "P2019-00232",
                        "P2011-00507",
                        "P2011-00584",
                        "P2017-00673",
                        "P2011-00416",
                        "P2013-00117",
                        "P2015-00512",
                        "P2013-00663",
                        "A2018-00712",
                        "P2014-00069",
                        "P2014-00362",
                        "P2014-00026",
                        "P2013-00626",
                        "P2013-00620",
                        "P2013-00610",
                        "P2014-00030",
                        "P2012-00325",
                        "P2018-00601",
                        "P2014-00077",
                        "P2015-00511",
                        "P2017-00874",
                        "A2019-00535",
                        "A2017-00672",
                        "P2016-00228",
                        "P2016-00063",
                        "P2013-00745",
                        "P2015-00421",
                        "P2019-00424",
                        "P2011-00603",
                        "P2011-00095",
                        "P2011-00834",
                        "P2011-01102",
                        "P2011-00081",
                        "A2011-00193",
                        "P2011-00299",
                        "P2011-00715",
                        "P2011-00836",
                        "A2011-00744",
                        "P2012-00170",
                        "P2012-00042",
                        "P2012-00087",
                        "P2012-00109",
                        "P2014-00354",
                        "P2014-00337",
                        "P2014-00143",
                        "P2019-00212",
                        "P2011-00004",
                        "P2011-01173",
                        "P2019-00325",
                        "P2013-00147",
                        "P2012-00313",
                        "P2019-00194",
                        "P2014-00179",
                        "P2014-00243",
                        "P2016-00240",
                        "A2019-00333",
                        "P2016-00003",
                        "P2012-00316",
                        "P2016-00057",
                        "P2019-00488",
                        "P2015-00710",
                        "P2014-00241",
                        "P2015-00709",
                        "P2017-00675",
                        "P2017-00816",
                        "P2018-00551",
                        "P2015-00907",
                        "P2013-00028",
                        "P2015-00864",
                        "P2016-00242",
                        "P2016-00006",
                        "P2019-00011",
                        "P2016-00105",
                        "P2019-00144",
                        "P2016-00215",
                        "P2014-00194",
                        "P2014-00635",
                        "P2018-00292",
                        "P2014-00608",
                        "P2011-00691",
                        "A2016-00339",
                        "P2013-00141",
                        "P2015-00888",
                        "P2016-00546",
                        "P2016-00551",
                        "P2016-00114",
                        "P2016-00115",
                        "P2016-00360",
                        "P2013-00134",
                        "P2014-00540",
                        "P2012-00631",
                        "P2012-00079",
                        "P2012-00186",
                        "P2017-00597",
                        "P2013-00575",
                        "P2012-00289",
                        "A2013-00562",
                        "P2012-00253",
                        "A2017-00752",
                        "P2015-00537",
                        "P2016-00107",
                        "P2018-00584",
                        "P2016-00220",
                        "P2016-00163",
                        "A2020-00003",
                        "P2016-00517",
                        "P2016-00552",
                        "P2015-00455",
                        "P2018-00003",
                        "P2016-00564",
                        "P2015-00714",
                        "A2014-00257",
                        "P2018-00028",
                        "P2016-00446",
                        "P2018-00055",
                        "P2019-00012",
                        "P2014-00607",
                        "P2016-00537",
                        "P2018-00245",
                        "P2016-00570",
                        "P2018-00560",
                        "P2019-00540",
                        "P2017-00098",
                        "A2017-00841",
                        "P2019-00120",
                        "A2017-00084",
                        "P2015-00924",
                        "P2016-00392",
                        "P2018-00729",
                        "P2018-00007",
                        "P2019-00541",
                        "A2019-00394",
                        "A2018-00730",
                        "A2018-00202",
                        "P2016-00036",
                        "P2016-00058",
                        "P2014-00203",
                        "P2016-00438",
                        "P2014-00617",
                        "P2015-00952",
                        "P2014-00631",
                        "A2017-00589",
                        "P2014-00614",
                        "P2016-00338",
                        "P2014-00622",
                        "P2016-00545",
                        "P2018-00383",
                        "P2014-00250",
                        "P2015-00879",
                        "P2019-00506",
                        "P2019-00380",
                        "P2019-00066",
                        "A2019-00059",
                        "P2019-00114",
                        "P2019-00391",
                        "P2016-00064",
                        "A2019-00086",
                        "P2019-00448",
                        "P2019-00235",
                        "P2018-00690",
                        "P2011-00399",
                        "P2016-00044",
                        "P2013-00869",
                        "P2015-00973",
                        "P2014-00364",
                        "P2014-00118",
                        "P2012-00301",
                        "P2014-00594",
                        "P2015-00897",
                        "P2015-00110",
                        "P2014-00391",
                        "P2014-00120",
                        "P2012-00278",
                        "P2011-01058",
                        "P2012-00177",
                        "P2015-00847",
                        "A2019-00178",
                        "A2014-00170",
                        "P2013-00148",
                        "P2015-00102",
                        "P2019-00333"
                    };

                    sql.AddParameter("@PERMITNUM", g(bp, i, "APPLICATION_NUMBER"));
                    //sql.AddParameter("@TT_RECORD", "");
                    var converttoint = false;
                    if (g(bp, i, "APPLICATION_NUMBER") == "A2020-00059")
                    {

                    }
                    if (g(bp, i, "APPLICATION_NUMBER") == "560" || g(bp, i, "APPLICATION_NUMBER") == "A0-26627" || g(bp, i, "APPLICATION_NUMBER") == "A0-26628" || g(bp, i, "APPLICATION_NUMBER") == "P012-10114")
                    {
                        //Console.WriteLine("line 544 permit number is " + bp);
                        sql.AddParameter("@TT_RECORD", "Historic");
                    }
                    else if (g(bp, i, "APPLICATION_NUMBER") == "S0-0" || g(bp, i, "APPLICATION_NUMBER") == "B10-0")
                    {
                        sql.AddParameter("@TT_RECORD", "Historic");
                    }

                    else
                    {
                        var temp3 = g(bp, i, "APPLICATION_NUMBER").ToString();
                        //var temp2 = g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1);
                        if (i == 33716)
                        {
                            if(g(bp, i, "APPLICATION_NUMBER").Length > 0)
                                Console.WriteLine(g(bp, i, "APPLICATION_NUMBER") + " Test " + temp3);
                            else
                                Console.WriteLine("Is Empty");
                        }
                        if (g(bp, i, "APPLICATION_NUMBER").Length > 0)
                            converttoint = Int32.TryParse(g(bp, i, "APPLICATION_NUMBER").Substring(1, 4), out int result);


                        if (converttoint)
                        {
                            if (Int32.Parse(g(bp, i, "APPLICATION_NUMBER").Substring(1, 4)) <= 2009)
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else
                            {
                                if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2199")
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2200")
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3199")
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3200")
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1) == "A")
                                {
                                    sql.AddParameter("@TT_RECORD", "Alternative Solution");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1) == "P")
                                {
                                    sql.AddParameter("@TT_RECORD", "Partial Permit");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1) == "C")
                                {
                                    sql.AddParameter("@TT_RECORD", "Conditional Permit");
                                }
                                else if (ADU.Contains(g(bp, i, "APPLICATION_NUMBER").ToString()))
                                {
                                    sql.AddParameter("@TT_RECORD", "Accessory Dwelling Unit");
                                }
                                else if (g(bp, i, "APPLICATION_Type") == "01")
                                {
                                    sql.AddParameter("@TT_RECORD", "Building Permit - New");
                                }
                                else if (g(bp, i, "FLAG_ALTREP") == "1")
                                {
                                    sql.AddParameter("@TT_RECORD", "Altration");
                                }
                                else if (g(bp, i, "FLAG_DEMO") == "1")
                                {
                                    sql.AddParameter("@TT_RECORD", "Demolision");
                                }
                                else if (g(bp, i, "BUILDINGCLASSFICATION") == "0014")
                                {
                                    sql.AddParameter("@TT_RECORD", "Deck");
                                }
                                else if (g(bp, i, "FLAG_ADDITIONAL") == "1")
                                {
                                    sql.AddParameter("@TT_RECORD", "Addition");
                                }
                                else if (g(bp, i, "APPLICATION_Type") == "06")
                                {
                                    sql.AddParameter("@TT_RECORD", "Mechanical");
                                }
                                else if (g(bp, i, "BUILDINGCLASSFICATION") == "0012")
                                {
                                    sql.AddParameter("@TT_RECORD", "Solar Panel");
                                }
                                else if (g(bp, i, "BUILDINGCLASSFICATION") == "0016")
                                {
                                    sql.AddParameter("@TT_RECORD", "Temporary");
                                }
                                else if (g(bp, i, "BUILDINGCLASSFICATION") == "0017")
                                {
                                    sql.AddParameter("@TT_RECORD", "Change Of Use");
                                }
                                else if (g(bp, i, "PERMIT_TYPE") == "S" || g(bp, i, "PERMIT_TYPE") == "s")
                                {
                                    sql.AddParameter("@TT_RECORD", "Signs");
                                }
                                else if (g(bp, i, "PERMIT_TYPE") == "P" || g(bp, i, "PERMIT_TYPE") == "p")
                                {
                                    sql.AddParameter("@TT_RECORD", "Pool");
                                }
                                else if(g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "PP2020-10200")
                                {
                                    sql.AddParameter("@TT_RECORD", "Pool");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "SP2020-10198")
                                {
                                    sql.AddParameter("@TT_RECORD", "Pool");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "1997-11352")
                                {
                                    sql.AddParameter("@TT_RECORD", "Pool");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "15")
                                {
                                    if (g(bp, i, "CONSTRUCTION_TYPE") == "101")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Building Permit - New");
                                    }
                                    else if (g(bp, i, "CONSTRUCTION_TYPE") == "116")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Addition");
                                    }
                                    else if (g(bp, i, "CONSTRUCTION_TYPE") == "117")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Addition");
                                    }
                                    else
                                    {
                                        sql.AddParameter("@TT_RECORD", "");
                                    }

                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "02")
                                {
                                    sql.AddParameter("@TT_RECORD", "Addition");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "02")
                                {
                                    sql.AddParameter("@TT_RECORD", "Altration");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "11")
                                {
                                    sql.AddParameter("@TT_RECORD", "Change Of Use");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "111")
                                {
                                    sql.AddParameter("@TT_RECORD", "Signs");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "12")
                                {
                                    sql.AddParameter("@TT_RECORD", "Building Permit - New");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "999")
                                {
                                    sql.AddParameter("@TT_RECORD", "Demolision");
                                }
                                else
                                {
                                    sql.AddParameter("@TT_RECORD", "");
                                }
                            }
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2199")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3199")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "60")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "990-")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "A200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "D200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "G199")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "P200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "PP2020-10200")
                        {
                            sql.AddParameter("@TT_RECORD", "Pool");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "SP2020-10198")
                        {
                            sql.AddParameter("@TT_RECORD", "Pool");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "1997-11352")
                        {
                            sql.AddParameter("@TT_RECORD", "Pool");
                        }
                        else
                        {
                            sql.AddParameter("@TT_RECORD", "");
                        }

                    }


                    //else if (g(bp, i, "APPLICATION_TYPE") == "01")
                    //{
                    //    sql.AddParameter("@TT_RECORD", "Building Permit - New");
                    //}
                    //else if (g(bp, i, "FLAG_ALTREP") == "1")
                    //{
                    //    sql.AddParameter("@TT_RECORD", "");
                    //}
                    //else if (g(bp, i, "PERMIT_TYPE") == "A")
                    //{
                    //    sql.AddParameter("@TT_RECORD", "");
                    //}



                    if (g(bp, i, "ESTIMATED_COST") != "")
                        sql.AddParameter("@PROJECTVALUATION", g(bp, i, "ESTIMATED_COST"));
                    else
                        sql.AddParameter("@PROJECTVALUATION", DBNull.Value);

                    sql.AddParameter("@DATEOPENED", g(bp, i, "APPLICATION_DATE"));
                    sql.AddParameter("@LIC_EXPR_DATE", DBNull.Value);

                    string status = g(bp, i, "APPLICATION_STATUS");



                    sql.AddParameter("@TT_RECORD_STATUS", status);
                    sql.AddParameter("@WORK_DESC", g(bp, i, "DESCRIPTION", 4000));
                    sql.AddParameter("@APP_NAME", DBNull.Value);
                    sql.AddParameter("@HOUSE_COUNT", DBNull.Value);
                    sql.AddParameter("@BUILDING_COUNT", DBNull.Value);
                    sql.AddParameter("@PUBLIC_OWNED", DBNull.Value);
                    sql.AddParameter("@CONST_TYPE_CODE", g(bp, i, "TONCONTYPE", 4));
                    sql.AddParameter("@LIC_STATUS", DBNull.Value);

                    temp = CityView.Run("select addition_info from sysadmin.bp_additional where bi_app_id = @ID", g(bp, i, "recordid"));

                    if (temp.Rows.Count > 0)
                        sql.AddParameter("@SHORT_NOTES", g(temp, 0, "addition_info", 255));
                    else
                        sql.AddParameter("@SHORT_NOTES", DBNull.Value);

                    sql.AddParameter("@ASGN_DEPT", DBNull.Value);
                    sql.AddParameter("@ASGN_STAFF", DBNull.Value);
                    sql.AddParameter("@ASGN_DATE", DBNull.Value);
                    sql.AddParameter("@COMPLETED_DEPT", DBNull.Value);
                    sql.AddParameter("@COMPLETED_BY", DBNull.Value);
                    sql.AddParameter("@COMPLETED_DATE", DBNull.Value);
                    sql.AddParameter("@SCHEDULED_DATE", DBNull.Value);
                    sql.AddParameter("@PRIORITY", DBNull.Value);

                    if (g(bp, i, "ESTIMATED_COST") != "")
                        sql.AddParameter("@TOTAL_JOB_COST", g(bp, i, "ESTIMATED_COST"));
                    else
                        sql.AddParameter("@TOTAL_JOB_COST", DBNull.Value);

                    sql.AddParameter("@CLOSED_DATE", DBNull.Value);
                    sql.AddParameter("@CLOSED_BY", DBNull.Value);
                    sql.AddParameter("@IVR_TRACKING_NUM", DBNull.Value);
                    sql.AddParameter("@CREATED_BY", DBNull.Value);
                    sql.AddParameter("@REPORTED_CHANNEL", DBNull.Value);
                    sql.AddParameter("@CREATED_BY_DEPT", DBNull.Value);
                    sql.AddParameter("@FIRST_ISSUED_DATE", g(bp, i, "BUILDINGPERMIT_ISSUEDATE"));
                    sql.AddParameter("@ANONYMOUS_FLAG", DBNull.Value);
                    sql.AddParameter("@REFERENCE_TYPE", DBNull.Value);
                    sql.AddParameter("@APPEARANCE_DAYOFWEEK", DBNull.Value);
                    sql.AddParameter("@APPEARANCE_DATE", DBNull.Value);
                    sql.AddParameter("@BOOKING_FLAG", DBNull.Value);
                    sql.AddParameter("@DEFENDANT_SIGNATURE_FLAG", DBNull.Value);
                    sql.AddParameter("@ENFORCE_OFFICER_ID", DBNull.Value);
                    sql.AddParameter("@ENFORCE_OFFICER_NAME", DBNull.Value);
                    sql.AddParameter("@INFRACTION_FLAG", DBNull.Value);
                    sql.AddParameter("@INSPECTOR_ID", g(bp, i, "INSPECTOR", 12));
                    sql.AddParameter("@MISDEMEANOR_FLAG", DBNull.Value);
                    sql.AddParameter("@OFFENCE_WITNESSED_FLAG", DBNull.Value);

                    temp = CityView.Run("select description from sysadmin.LookupBIInspector where code = @ID", g(bp, i, "INSPECTOR"));

                    if (temp.Rows.Count > 0)
                        sql.AddParameter("@INSPECTOR_NAME", g(temp, 0, "description", 70));
                    else
                        sql.AddParameter("@INSPECTOR_NAME", DBNull.Value);

                    sql.AddParameter("@ENFORCE_DEPT", DBNull.Value);
                    sql.AddParameter("@INSPECTOR_DEPT", g(bp, i, "INSPECTOR", 100) != "" ? "Building" : "");
                    sql.AddParameter("@VALUATION_MULTIPLIER", DBNull.Value);
                    sql.AddParameter("@VALUATION_EXTRA_AMT", DBNull.Value);
                    sql.AddParameter("@LAST_AUDIT_DATE", DBNull.Value);
                    sql.AddParameter("@APP_STATUS_DATE", DBNull.Value);
                    sql.AddParameter("@DELEGATE_USER_ID", DBNull.Value);
                    sql.Run();
                }
                count = 0;
                for (int i = 0; i < bv.Rows.Count; i++)
                {


                    SQL sql = new SQL(@"
            use accelastage;
            insert into aatable_permit_history
            (
            PERMITNUM,
            TT_RECORD,
            PROJECTVALUATION,
            DATEOPENED,
            LIC_EXPR_DATE,
            TT_RECORD_STATUS,
            WORK_DESC,
            APP_NAME,
            HOUSE_COUNT,
            BUILDING_COUNT,
            PUBLIC_OWNED,
            CONST_TYPE_CODE,
            LIC_STATUS,
            SHORT_NOTES,
            ASGN_DEPT,
            ASGN_STAFF,
            ASGN_DATE,
            COMPLETED_DEPT,
            COMPLETED_BY,
            COMPLETED_DATE,
            SCHEDULED_DATE,
            PRIORITY,
            TOTAL_JOB_COST,
            CLOSED_DATE,
            CLOSED_BY,
            IVR_TRACKING_NUM,
            CREATED_BY,
            REPORTED_CHANNEL,
            CREATED_BY_DEPT,
            FIRST_ISSUED_DATE,
            ANONYMOUS_FLAG,
            REFERENCE_TYPE,
            APPEARANCE_DAYOFWEEK,
            APPEARANCE_DATE,
            BOOKING_FLAG,
            DEFENDANT_SIGNATURE_FLAG,
            ENFORCE_OFFICER_ID,
            ENFORCE_OFFICER_NAME,
            INFRACTION_FLAG,
            INSPECTOR_ID,
            MISDEMEANOR_FLAG,
            OFFENCE_WITNESSED_FLAG,
            INSPECTOR_NAME,
            ENFORCE_DEPT,
            INSPECTOR_DEPT,
            VALUATION_MULTIPLIER,
            VALUATION_EXTRA_AMT,
            LAST_AUDIT_DATE,
            APP_STATUS_DATE,
            DELEGATE_USER_ID
            )
            values (
            @PERMITNUM,
            @TT_RECORD,
            @PROJECTVALUATION,
            @DATEOPENED,
            @LIC_EXPR_DATE,
            @TT_RECORD_STATUS,
            @WORK_DESC,
            @APP_NAME,
            @HOUSE_COUNT,
            @BUILDING_COUNT,
            @PUBLIC_OWNED,
            @CONST_TYPE_CODE,
            @LIC_STATUS,
            @SHORT_NOTES,
            @ASGN_DEPT,
            @ASGN_STAFF,
            @ASGN_DATE,
            @COMPLETED_DEPT,
            @COMPLETED_BY,
            @COMPLETED_DATE,
            @SCHEDULED_DATE,
            @PRIORITY,
            @TOTAL_JOB_COST,
            @CLOSED_DATE,
            @CLOSED_BY,
            @IVR_TRACKING_NUM,
            @CREATED_BY,
            @REPORTED_CHANNEL,
            @CREATED_BY_DEPT,
            @FIRST_ISSUED_DATE,
            @ANONYMOUS_FLAG,
            @REFERENCE_TYPE,
            @APPEARANCE_DAYOFWEEK,
            @APPEARANCE_DATE,
            @BOOKING_FLAG,
            @DEFENDANT_SIGNATURE_FLAG,
            @ENFORCE_OFFICER_ID,
            @ENFORCE_OFFICER_NAME,
            @INFRACTION_FLAG,
            @INSPECTOR_ID,
            @MISDEMEANOR_FLAG,
            @OFFENCE_WITNESSED_FLAG,
            @INSPECTOR_NAME,
            @ENFORCE_DEPT,
            @INSPECTOR_DEPT,
            @VALUATION_MULTIPLIER,
            @VALUATION_EXTRA_AMT,
            @LAST_AUDIT_DATE,
            @APP_STATUS_DATE,
            @DELEGATE_USER_ID
            )");


                    sql.AddParameter("@PERMITNUM", g(bv, i, "RECORDID"));
                    sql.AddParameter("@TT_RECORD", "Construction Without Permit");


                    sql.AddParameter("@PROJECTVALUATION", DBNull.Value);

                    sql.AddParameter("@DATEOPENED", g(bv, i, "DATEOFCOMPLAINT"));
                    sql.AddParameter("@LIC_EXPR_DATE", DBNull.Value);



                    sql.AddParameter("@TT_RECORD_STATUS", "C");
                    sql.AddParameter("@WORK_DESC", g(bv, i, "DESCRIPTIONOFVIOLATION", 4000));
                    sql.AddParameter("@APP_NAME", DBNull.Value);
                    sql.AddParameter("@HOUSE_COUNT", DBNull.Value);
                    sql.AddParameter("@BUILDING_COUNT", DBNull.Value);
                    sql.AddParameter("@PUBLIC_OWNED", DBNull.Value);
                    sql.AddParameter("@CONST_TYPE_CODE", DBNull.Value);
                    sql.AddParameter("@LIC_STATUS", DBNull.Value);


                    sql.AddParameter("@SHORT_NOTES", DBNull.Value);

                    sql.AddParameter("@ASGN_DEPT", DBNull.Value);
                    sql.AddParameter("@ASGN_STAFF", DBNull.Value);
                    sql.AddParameter("@ASGN_DATE", DBNull.Value);
                    sql.AddParameter("@COMPLETED_DEPT", DBNull.Value);
                    sql.AddParameter("@COMPLETED_BY", DBNull.Value);
                    sql.AddParameter("@COMPLETED_DATE", DBNull.Value);
                    sql.AddParameter("@SCHEDULED_DATE", DBNull.Value);
                    sql.AddParameter("@PRIORITY", DBNull.Value);


                    sql.AddParameter("@TOTAL_JOB_COST", DBNull.Value);

                    sql.AddParameter("@CLOSED_DATE", DBNull.Value);
                    sql.AddParameter("@CLOSED_BY", DBNull.Value);
                    sql.AddParameter("@IVR_TRACKING_NUM", DBNull.Value);
                    sql.AddParameter("@CREATED_BY", DBNull.Value);
                    sql.AddParameter("@REPORTED_CHANNEL", DBNull.Value);
                    sql.AddParameter("@CREATED_BY_DEPT", DBNull.Value);
                    sql.AddParameter("@FIRST_ISSUED_DATE", DBNull.Value);
                    sql.AddParameter("@ANONYMOUS_FLAG", DBNull.Value);
                    sql.AddParameter("@REFERENCE_TYPE", DBNull.Value);
                    sql.AddParameter("@APPEARANCE_DAYOFWEEK", DBNull.Value);
                    sql.AddParameter("@APPEARANCE_DATE", DBNull.Value);
                    sql.AddParameter("@BOOKING_FLAG", DBNull.Value);
                    sql.AddParameter("@DEFENDANT_SIGNATURE_FLAG", DBNull.Value);
                    sql.AddParameter("@ENFORCE_OFFICER_ID", DBNull.Value);
                    sql.AddParameter("@ENFORCE_OFFICER_NAME", DBNull.Value);
                    sql.AddParameter("@INFRACTION_FLAG", DBNull.Value);
                    sql.AddParameter("@INSPECTOR_ID", g(bv, i, "ASSIGNEDTO", 12));
                    sql.AddParameter("@MISDEMEANOR_FLAG", DBNull.Value);
                    sql.AddParameter("@OFFENCE_WITNESSED_FLAG", DBNull.Value);

                    temp = CityView.Run("select description from sysadmin.LookupBIInspector where code = @ID", g(bv, i, "ASSIGNEDTO"));

                    if (temp.Rows.Count > 0)
                        sql.AddParameter("@INSPECTOR_NAME", g(temp, 0, "description", 70));
                    else
                        sql.AddParameter("@INSPECTOR_NAME", DBNull.Value);

                    sql.AddParameter("@ENFORCE_DEPT", DBNull.Value);
                    sql.AddParameter("@INSPECTOR_DEPT", g(bv, i, "ASSIGNEDTO", 100) != "" ? "Building" : "");
                    sql.AddParameter("@VALUATION_MULTIPLIER", DBNull.Value);
                    sql.AddParameter("@VALUATION_EXTRA_AMT", DBNull.Value);
                    sql.AddParameter("@LAST_AUDIT_DATE", DBNull.Value);
                    sql.AddParameter("@APP_STATUS_DATE", DBNull.Value);
                    sql.AddParameter("@DELEGATE_USER_ID", DBNull.Value);
                    sql.Run();

                    SQL sqladdress = new SQL(@"
            use accelastage;
            insert into AATABLE_PERMIT_ADDRESS
            (
           PERMITNUM
      ,ISPRIMARY
      ,STR_NUM_START
      ,STR_NUM_END
      ,STR_FRAC_START
      ,STR_FRAC_END
      ,STR_DIR
      ,STR_NAME
      ,STR_SUFFIX
      ,STR_UNIT_START
      ,STR_UNIT_END
      ,STR_UNIT_TYPE
      ,SITUS_CITY
      ,SITUS_STATE
      ,SITUS_ZIP
      ,SITUS_COUNTY
      ,SITUS_COUNTRY
      ,SITUS_COUNTRY_CODE
      ,X_COORD
      ,Y_COORD
      ,ADDR_DESC
      ,FULL_ADDRESS
      ,ADDRESS1
      ,ADDRESS2
      ,SITUS_NBRHD
      ,EXT_ADDRESS_UID
            )
            values (
            @PERMITNUM
      ,@ISPRIMARY
      ,@STR_NUM_START
      ,@STR_NUM_END
      ,@STR_FRAC_START
      ,@STR_FRAC_END
      ,@STR_DIR
      ,@STR_NAME
      ,@STR_SUFFIX
      ,@STR_UNIT_START
      ,@STR_UNIT_END
      ,@STR_UNIT_TYPE
      ,@SITUS_CITY
      ,@SITUS_STATE
      ,@SITUS_ZIP
      ,@SITUS_COUNTY
      ,@SITUS_COUNTRY
      ,@SITUS_COUNTRY_CODE
      ,@X_COORD
      ,@Y_COORD
      ,@ADDR_DESC
      ,@FULL_ADDRESS
      ,@ADDRESS1
      ,@ADDRESS2
      ,@SITUS_NBRHD
      ,@EXT_ADDRESS_UID
            )");

                    sqladdress.AddParameter("@PERMITNUM", g(bv, i, "RECORDID"));
                    sqladdress.AddParameter("@ISPRIMARY", "Y");
                    sqladdress.AddParameter("@STR_NUM_START", g(bv, i, "STREET_NUMBER"));
                    sqladdress.AddParameter("@STR_NUM_END", DBNull.Value);
                    sqladdress.AddParameter("@STR_FRAC_START", DBNull.Value);
                    sqladdress.AddParameter("@STR_FRAC_END", DBNull.Value);
                    sqladdress.AddParameter("@STR_DIR", DBNull.Value);
                    sqladdress.AddParameter("@STR_NAME", g(bv, i, "STREET_NAME"));
                    sqladdress.AddParameter("@STR_SUFFIX", DBNull.Value);
                    sqladdress.AddParameter("@STR_UNIT_START", DBNull.Value);
                    sqladdress.AddParameter("@STR_UNIT_END", DBNull.Value);
                    sqladdress.AddParameter("@STR_UNIT_TYPE", DBNull.Value);
                    if (g(bv, i, "CITY_PROV_COUNTRY") != "")
                    {
                        var city = g(bv, i, "CITY_PROV_COUNTRY").Substring(0, g(bv, i, "CITY_PROV_COUNTRY").Length - 3);
                        sqladdress.AddParameter("@SITUS_CITY", city);
                        var province = g(bv, i, "CITY_PROV_COUNTRY").Substring(g(bv, i, "CITY_PROV_COUNTRY").Length - 2);
                        sqladdress.AddParameter("@SITUS_STATE", province);
                    }
                    else
                    {
                        sqladdress.AddParameter("@SITUS_CITY", DBNull.Value);
                        sqladdress.AddParameter("@SITUS_STATE", DBNull.Value);
                    }

                    sqladdress.AddParameter("@SITUS_ZIP", g(bv, i, "POSTAL_CODE"));
                    sqladdress.AddParameter("@SITUS_COUNTY", DBNull.Value);
                    sqladdress.AddParameter("@SITUS_COUNTRY", "Canada");
                    sqladdress.AddParameter("@SITUS_COUNTRY_CODE", DBNull.Value);
                    sqladdress.AddParameter("@X_COORD", DBNull.Value);
                    sqladdress.AddParameter("@Y_COORD", DBNull.Value);
                    sqladdress.AddParameter("@ADDR_DESC", DBNull.Value);
                    sqladdress.AddParameter("@FULL_ADDRESS", g(bv, i, "STREET_NUMBER") + g(bv, i, "STREET_NAME") + g(bv, i, "CITY_PROV_COUNTRY"));
                    sqladdress.AddParameter("@ADDRESS1", g(bv, i, "STREET_NUMBER") + g(bv, i, "STREET_NAME"));
                    sqladdress.AddParameter("@ADDRESS2", DBNull.Value);
                    sqladdress.AddParameter("@SITUS_NBRHD", DBNull.Value);
                    sqladdress.AddParameter("@EXT_ADDRESS_UID", DBNull.Value);


                }

                //Enter violations into AATable_Permit_History
                /* 20190613
                for (int i = 0; i < vi.Rows.Count; i++)
                {
                    SQL sql = new SQL(@"
            use accelastage;
            insert into aatable_permit_history
            (
            PERMITNUM,
            TT_RECORD,
            PROJECTVALUATION,
            DATEOPENED,
            LIC_EXPR_DATE,
            TT_RECORD_STATUS,
            WORK_DESC,
            APP_NAME,
            HOUSE_COUNT,
            BUILDING_COUNT,
            PUBLIC_OWNED,
            CONST_TYPE_CODE,
            LIC_STATUS,
            SHORT_NOTES,
            ASGN_DEPT,
            ASGN_STAFF,
            ASGN_DATE,
            COMPLETED_DEPT,
            COMPLETED_BY,
            COMPLETED_DATE,
            SCHEDULED_DATE,
            PRIORITY,
            TOTAL_JOB_COST,
            CLOSED_DATE,
            CLOSED_BY,
            IVR_TRACKING_NUM,
            CREATED_BY,
            REPORTED_CHANNEL,
            CREATED_BY_DEPT,
            FIRST_ISSUED_DATE,
            ANONYMOUS_FLAG,
            REFERENCE_TYPE,
            APPEARANCE_DAYOFWEEK,
            APPEARANCE_DATE,
            BOOKING_FLAG,
            DEFENDANT_SIGNATURE_FLAG,
            ENFORCE_OFFICER_ID,
            ENFORCE_OFFICER_NAME,
            INFRACTION_FLAG,
            INSPECTOR_ID,
            MISDEMEANOR_FLAG,
            OFFENCE_WITNESSED_FLAG,
            INSPECTOR_NAME,
            ENFORCE_DEPT,
            INSPECTOR_DEPT,
            VALUATION_MULTIPLIER,
            VALUATION_EXTRA_AMT,
            LAST_AUDIT_DATE,
            APP_STATUS_DATE,
            DELEGATE_USER_ID
            )
            values (
            @PERMITNUM,
            @TT_RECORD,
            @PROJECTVALUATION,
            @DATEOPENED,
            @LIC_EXPR_DATE,
            @TT_RECORD_STATUS,
            @WORK_DESC,
            @APP_NAME,
            @HOUSE_COUNT,
            @BUILDING_COUNT,
            @PUBLIC_OWNED,
            @CONST_TYPE_CODE,
            @LIC_STATUS,
            @SHORT_NOTES,
            @ASGN_DEPT,
            @ASGN_STAFF,
            @ASGN_DATE,
            @COMPLETED_DEPT,
            @COMPLETED_BY,
            @COMPLETED_DATE,
            @SCHEDULED_DATE,
            @PRIORITY,
            @TOTAL_JOB_COST,
            @CLOSED_DATE,
            @CLOSED_BY,
            @IVR_TRACKING_NUM,
            @CREATED_BY,
            @REPORTED_CHANNEL,
            @CREATED_BY_DEPT,
            @FIRST_ISSUED_DATE,
            @ANONYMOUS_FLAG,
            @REFERENCE_TYPE,
            @APPEARANCE_DAYOFWEEK,
            @APPEARANCE_DATE,
            @BOOKING_FLAG,
            @DEFENDANT_SIGNATURE_FLAG,
            @ENFORCE_OFFICER_ID,
            @ENFORCE_OFFICER_NAME,
            @INFRACTION_FLAG,
            @INSPECTOR_ID,
            @MISDEMEANOR_FLAG,
            @OFFENCE_WITNESSED_FLAG,
            @INSPECTOR_NAME,
            @ENFORCE_DEPT,
            @INSPECTOR_DEPT,
            @VALUATION_MULTIPLIER,
            @VALUATION_EXTRA_AMT,
            @LAST_AUDIT_DATE,
            @APP_STATUS_DATE,
            @DELEGATE_USER_ID
            )");
                    sql.AddParameter("@PERMITNUM", g(vi, i, "VIOLATION_ID"));
                    sql.AddParameter("@TT_RECORD", "Violation");
                    sql.AddParameter("@PROJECTVALUATION", DBNull.Value);
                    sql.AddParameter("@DATEOPENED", g(vi, i, "VIOLATION_DATE"));
                    sql.AddParameter("@LIC_EXPR_DATE", DBNull.Value);
                    sql.AddParameter("@TT_RECORD_STATUS", "ViolationEntered");

                    temp = CityView.Run("select partcomment from sysadmin.Violation_Particulars where parentid = @ID", g(vi, i, "RecordID"));

                    if (temp.Rows.Count > 0)
                        sql.AddParameter("@WORK_DESC", g(temp, 0, "PartComment", 4000));
                    else
                        sql.AddParameter("@WORK_DESC", DBNull.Value);

                    sql.AddParameter("@APP_NAME", DBNull.Value);
                    sql.AddParameter("@HOUSE_COUNT", DBNull.Value);
                    sql.AddParameter("@BUILDING_COUNT", DBNull.Value);
                    sql.AddParameter("@PUBLIC_OWNED", DBNull.Value);
                    sql.AddParameter("@CONST_TYPE_CODE", DBNull.Value);
                    sql.AddParameter("@LIC_STATUS", DBNull.Value);
                    sql.AddParameter("@SHORT_NOTES", g(vi, i, "REGARDING", 4000));
                    sql.AddParameter("@ASGN_DEPT", DBNull.Value);
                    sql.AddParameter("@ASGN_STAFF", DBNull.Value);
                    sql.AddParameter("@ASGN_DATE", DBNull.Value);
                    sql.AddParameter("@COMPLETED_DEPT", DBNull.Value);
                    sql.AddParameter("@COMPLETED_BY", DBNull.Value);
                    sql.AddParameter("@COMPLETED_DATE", DBNull.Value);
                    sql.AddParameter("@SCHEDULED_DATE", DBNull.Value);
                    sql.AddParameter("@PRIORITY", DBNull.Value);
                    sql.AddParameter("@TOTAL_JOB_COST", DBNull.Value);
                    sql.AddParameter("@CLOSED_DATE", g(vi, i, "DateClosed"));
                    sql.AddParameter("@CLOSED_BY", DBNull.Value);
                    sql.AddParameter("@IVR_TRACKING_NUM", DBNull.Value);
                    sql.AddParameter("@CREATED_BY", DBNull.Value);
                    sql.AddParameter("@REPORTED_CHANNEL", DBNull.Value);
                    sql.AddParameter("@CREATED_BY_DEPT", DBNull.Value);
                    sql.AddParameter("@FIRST_ISSUED_DATE", g(vi, i, "VIOLATION_DATE"));
                    sql.AddParameter("@ANONYMOUS_FLAG", DBNull.Value);
                    sql.AddParameter("@REFERENCE_TYPE", DBNull.Value);
                    sql.AddParameter("@APPEARANCE_DAYOFWEEK", DBNull.Value);
                    sql.AddParameter("@APPEARANCE_DATE", DBNull.Value);
                    sql.AddParameter("@BOOKING_FLAG", DBNull.Value);
                    sql.AddParameter("@DEFENDANT_SIGNATURE_FLAG", DBNull.Value);
                    sql.AddParameter("@ENFORCE_OFFICER_ID", g(vi, i, "Inspect_Inspect", 12));

                    temp = CityView.Run("select description from sysadmin.LookupBIInspector where code = @ID", g(vi, i, "Inspect_Inspect"));

                    if (temp.Rows.Count > 0)
                        sql.AddParameter("@ENFORCE_OFFICER_NAME", g(temp, 0, "description", 70));
                    else
                        sql.AddParameter("@ENFORCE_OFFICER_NAME", DBNull.Value);

                    sql.AddParameter("@INFRACTION_FLAG", DBNull.Value);
                    sql.AddParameter("@INSPECTOR_ID", DBNull.Value);
                    sql.AddParameter("@MISDEMEANOR_FLAG", DBNull.Value);
                    sql.AddParameter("@OFFENCE_WITNESSED_FLAG", DBNull.Value);
                    sql.AddParameter("@INSPECTOR_NAME", DBNull.Value);
                    sql.AddParameter("@ENFORCE_DEPT", g(vi, i, "Inspect_Inspect", 12) != "" ? "Bylaws" : "");
                    sql.AddParameter("@INSPECTOR_DEPT", DBNull.Value);
                    sql.AddParameter("@VALUATION_MULTIPLIER", DBNull.Value);
                    sql.AddParameter("@VALUATION_EXTRA_AMT", DBNull.Value);
                    sql.AddParameter("@LAST_AUDIT_DATE", DBNull.Value);
                    sql.AddParameter("@APP_STATUS_DATE", DBNull.Value);
                    sql.AddParameter("@DELEGATE_USER_ID", DBNull.Value);
                    sql.Run();
                }
                20190613 comment out vi*/
            }

            //Enter building permits into AATable_Permit_Status

            if (PermitStatus)
            {
                for (int i = 0; i < bp.Rows.Count; i++)
                {
                    SQL sql = new SQL(@"
            use accelastage;
            insert into aatable_permit_status
            (
            PERMITNUM,
            STATUS,
            STATUS_DATE,
            STATUS_COMMENT,
            FNAME,
            MNAME,
            LNAME
            )
            values (
            @PERMITNUM,
            @STATUS,
            @STATUS_DATE,
            @STATUS_COMMENT,
            @FNAME,
            @MNAME,
            @LNAME
            )");
                    sql.AddParameter("@PERMITNUM", g(bp, i, "APPLICATION_NUMBER"));
                    sql.AddParameter("@STATUS", g(bp, i, "APPLICATION_STATUS"));

                    if (g(bp, i, "BUILDINGPERMIT_ISSUEDATE") == "")
                        sql.AddParameter("@STATUS_DATE", g(bp, i, "APPLICATION_DATE"));
                    else
                        sql.AddParameter("@STATUS_DATE", g(bp, i, "BUILDINGPERMIT_ISSUEDATE"));

                    sql.AddParameter("@STATUS_COMMENT", DBNull.Value);
                    sql.AddParameter("@FNAME", DBNull.Value);
                    sql.AddParameter("@MNAME", DBNull.Value);
                    sql.AddParameter("@LNAME", DBNull.Value);
                    if (g(bp, i, "APPLICATION_NUMBER") != "")
                    {
                        sql.Run();

                    }
                    
                }

                //Enter violations into AATable_Permit_Status
                /* 20190613 vi
                for (int i = 0; i < vi.Rows.Count; i++)
                {
                    SQL sql = new SQL(@"
            use accelastage;
            insert into aatable_permit_status
            (
            PERMITNUM,
            STATUS,
            STATUS_DATE,
            STATUS_COMMENT,
            FNAME,
            MNAME,
            LNAME
            )
            values (
            @PERMITNUM,
            @STATUS,
            @STATUS_DATE,
            @STATUS_COMMENT,
            @FNAME,
            @MNAME,
            @LNAME
            )");
                    sql.AddParameter("@PERMITNUM", g(vi, i, "VIOLATION_ID"));
                    sql.AddParameter("@STATUS", g(vi, i, "STATUS"));

                    if (g(vi, i, "DateClosed") == "")
                        sql.AddParameter("@STATUS_DATE", g(vi, i, "VIOLATION_DATE"));
                    else
                        sql.AddParameter("@STATUS_DATE", g(vi, i, "DateClosed"));

                    sql.AddParameter("@STATUS_COMMENT", DBNull.Value);
                    sql.AddParameter("@FNAME", DBNull.Value);
                    sql.AddParameter("@MNAME", DBNull.Value);
                    sql.AddParameter("@LNAME", DBNull.Value);
                    sql.Run();
                }
               20190613 vi  */
            }

            //Enter building permits into AATable_Permit_Address
            if (PermitAddress)
            {
                for (int i = 0; i < bp.Rows.Count; i++)
                {
                    DataTable assess = CityView.Run("select * from sysadmin.assess where recordid=@ID and STREET_NAME IS NOT NULL", g(bp, i, "ASSESS_ID"));

            //        if (assess.Rows.Count == 0)
            //        {
            //            SQL temp2 = new SQL(@"
            //use accelastage;
            //insert into AATable_Permit_Address
            //(
            //PERMITNUM
            //)
            //values (
            //@PERMITNUM
            //)");
            //            temp2.AddParameter("@PERMITNUM", g(bp, i, "APPLICATION_NUMBER"));
            //            //temp2.Run();
            //        }
            //        else
            //        {
                        SQL sql = new SQL(@"
            use accelastage;
            insert into AATable_Permit_Address
            (
            PERMITNUM,
            ISPRIMARY,
            STR_NUM_START,
            STR_NUM_END,
            STR_FRAC_START,
            STR_FRAC_END,
            STR_DIR,
            STR_NAME,
            STR_SUFFIX,
            STR_UNIT_START,
            STR_UNIT_END,
            STR_UNIT_TYPE,
            SITUS_CITY,
            SITUS_STATE,
            SITUS_ZIP,
            SITUS_COUNTY,
            SITUS_COUNTRY,
            SITUS_COUNTRY_CODE,
            X_COORD,
            Y_COORD,
            ADDR_DESC,
            FULL_ADDRESS,
            ADDRESS1,
            ADDRESS2,
            SITUS_NBRHD,
            EXT_ADDRESS_UID
            )
            values (
            @PERMITNUM,
            @ISPRIMARY,
            @STR_NUM_START,
            @STR_NUM_END,
            @STR_FRAC_START,
            @STR_FRAC_END,
            @STR_DIR,
            @STR_NAME,
            @STR_SUFFIX,
            @STR_UNIT_START,
            @STR_UNIT_END,
            @STR_UNIT_TYPE,
            @SITUS_CITY,
            @SITUS_STATE,
            @SITUS_ZIP,
            @SITUS_COUNTY,
            @SITUS_COUNTRY,
            @SITUS_COUNTRY_CODE,
            @X_COORD,
            @Y_COORD,
            @ADDR_DESC,
            @FULL_ADDRESS,
            @ADDRESS1,
            @ADDRESS2,
            @SITUS_NBRHD,
            @EXT_ADDRESS_UID
            )");
                        sql.AddParameter("@PERMITNUM", g(bp, i, "APPLICATION_NUMBER"));
                        sql.AddParameter("@ISPRIMARY", "Y");

                        string numstart = g(assess, 0, "STREET_NUMBER");
                        string numend = g(assess, 0, "UPPER_STREET_NUMBER");

                        if (numstart == "")
                            sql.AddParameter("@STR_NUM_START", DBNull.Value);
                        else
                            sql.AddParameter("@STR_NUM_START", numstart);

                        if (numend == "" || numend == "00000")
                            sql.AddParameter("@STR_NUM_END", DBNull.Value);
                        else
                            sql.AddParameter("@STR_NUM_END", numend);

                        sql.AddParameter("@STR_FRAC_START", DBNull.Value);
                        sql.AddParameter("@STR_FRAC_END", DBNull.Value);
                        sql.AddParameter("@STR_DIR", DBNull.Value);
                        sql.AddParameter("@STR_NAME", g(assess, 0, "STREET_NAME"));
                        sql.AddParameter("@STR_SUFFIX", DBNull.Value);
                        sql.AddParameter("@STR_UNIT_START", g(assess, 0, "UNIT_NUMBER"));
                        sql.AddParameter("@STR_UNIT_END", DBNull.Value);
                        sql.AddParameter("@STR_UNIT_TYPE", DBNull.Value);

                        //20190613 string s = g(assess, 0, "CITY_PROV_COUNTRY").Trim();

                        /* 20190613
                        if (s == "SEE OWNER")
                        {
                            sql.AddParameter("@SITUS_CITY", DBNull.Value);
                            sql.AddParameter("@SITUS_STATE", DBNull.Value);
                        }
                        else if (s.Contains(" ON"))
                        {
                            city = s.Replace(" ON", "").Trim();
                            state = "ON";

                            sql.AddParameter("@SITUS_CITY", city);
                            sql.AddParameter("@SITUS_STATE", state);
                        }
                        else if (s.Contains(' '))
                        {
                            string[] x = s.Split(' ');

                            city = s.Replace(x[x.Length - 1], "").Trim();
                            state = x[x.Length - 1];

                            sql.AddParameter("@SITUS_CITY", city);
                            sql.AddParameter("@SITUS_STATE", state);
                        }
                        else
                        {
                            sql.AddParameter("@SITUS_CITY", DBNull.Value);
                            sql.AddParameter("@SITUS_STATE", DBNull.Value);
                        }
                        */
                        string city = "NEWMARKET";
                        string state = "ON";
                        sql.AddParameter("@SITUS_CITY", city);
                        sql.AddParameter("@SITUS_STATE", state);
                        sql.AddParameter("@SITUS_ZIP", DBNull.Value);
                        //20190613 sql.AddParameter("@SITUS_ZIP", g(assess, 0, "POSTAL_CODE", 10));
                        sql.AddParameter("@SITUS_COUNTY", DBNull.Value);
                        sql.AddParameter("@SITUS_COUNTRY", DBNull.Value);
                        sql.AddParameter("@SITUS_COUNTRY_CODE", DBNull.Value);
                        sql.AddParameter("@X_COORD", DBNull.Value);
                        sql.AddParameter("@Y_COORD", DBNull.Value);
                        sql.AddParameter("@ADDR_DESC", DBNull.Value);

                        string full = "";
                        string a1 = "";
                        string a2 = "";

                        if (g(assess, 0, "STREET_NUMBER") != "")
                        {
                            full += g(assess, 0, "STREET_NUMBER") + " ";
                            a1 += g(assess, 0, "STREET_NUMBER") + " ";
                        }

                        if (g(assess, 0, "STREET_NAME") != "")
                        {
                            full += g(assess, 0, "STREET_NAME") + " ";
                            a1 += g(assess, 0, "STREET_NAME") + " ";
                        }

                        if (g(assess, 0, "UNIT_NUMBER") != "")
                        {
                            full += "Unit " + g(assess, 0, "UNIT_NUMBER") + " ";
                            a1 += "Unit " + g(assess, 0, "UNIT_NUMBER") + " ";
                        }

                        if (city != "")
                        {
                            full += city;
                            a2 += city;  //20190613 change a1 to a2
                        }

                        /* 20190613
                        if (g(assess, 0, "POSTAL_CODE") != "")
                            a2 += g(assess, 0, "POSTAL_CODE") + " ";
                            */

                        if (state != "")
                        {
                            full += state;
                            a2 += state;
                        }


                        full = full.Trim();
                        a1 = a1.Trim();
                        a2 = a2.Trim();

                        sql.AddParameter("@FULL_ADDRESS", full);
                        sql.AddParameter("@ADDRESS1", a1);
                        sql.AddParameter("@ADDRESS2", a2);
                        sql.AddParameter("@SITUS_NBRHD", DBNull.Value);
                        sql.AddParameter("@EXT_ADDRESS_UID ", DBNull.Value);
                        if (g(bp, i, "APPLICATION_NUMBER") != "" )
                        {
                                sql.Run();
                            
                        }
                    }
                //}

                //Enter violations into AATable_Permit_Address
                /* comment out the violation permit address
                for (int i = 0; i < vi.Rows.Count; i++)
                {
                    DataTable vt = Vailtech.Run("select * from vailtech.cv_tx_roll where roll_no=@ID", g(vi, i, "roll_num"));

                    if (vt.Rows.Count == 0)
                    {
                        SQL temp2 = new SQL(@"
            use accelastage;
            insert into AATable_Permit_Address
            (
            PERMITNUM,
            STR_NAME,
            FULL_ADDRESS
            )
            values (
            @PERMITNUM,
            @STR_NAME,
            @FULL_ADDRESS
            )");
                        temp2.AddParameter("@PERMITNUM", g(vi, i, "VIOLATION_ID"));
                        temp2.AddParameter("@STR_NAME", "N/A");
                        temp2.AddParameter("@FULL_ADDRESS", "N/A");
                        temp2.Run();
                    }
                    else
                    {
                        SQL sql = new SQL(@"
            use accelastage;
            insert into AATable_Permit_Address
            (
            PERMITNUM,
            ISPRIMARY,
            STR_NUM_START,
            STR_NUM_END,
            STR_FRAC_START,
            STR_FRAC_END,
            STR_DIR,
            STR_NAME,
            STR_SUFFIX,
            STR_UNIT_START,
            STR_UNIT_END,
            STR_UNIT_TYPE,
            SITUS_CITY,
            SITUS_STATE,
            SITUS_ZIP,
            SITUS_COUNTY,
            SITUS_COUNTRY,
            SITUS_COUNTRY_CODE,
            X_COORD,
            Y_COORD,
            ADDR_DESC,
            FULL_ADDRESS,
            ADDRESS1,
            ADDRESS2,
            SITUS_NBRHD,
            EXT_ADDRESS_UID
            )
            values (
            @PERMITNUM,
            @ISPRIMARY,
            @STR_NUM_START,
            @STR_NUM_END,
            @STR_FRAC_START,
            @STR_FRAC_END,
            @STR_DIR,
            @STR_NAME,
            @STR_SUFFIX,
            @STR_UNIT_START,
            @STR_UNIT_END,
            @STR_UNIT_TYPE,
            @SITUS_CITY,
            @SITUS_STATE,
            @SITUS_ZIP,
            @SITUS_COUNTY,
            @SITUS_COUNTRY,
            @SITUS_COUNTRY_CODE,
            @X_COORD,
            @Y_COORD,
            @ADDR_DESC,
            @FULL_ADDRESS,
            @ADDRESS1,
            @ADDRESS2,
            @SITUS_NBRHD,
            @EXT_ADDRESS_UID
            )");
                        sql.AddParameter("@PERMITNUM", g(vi, i, "VIOLATION_ID"));
                        sql.AddParameter("@ISPRIMARY", "Y");

                        if (g(vt, 0, "STREET_NO") == "")
                            sql.AddParameter("@STR_NUM_START", DBNull.Value);
                        else
                            sql.AddParameter("@STR_NUM_START", g(vt, 0, "STREET_NO"));

                        if (g(vt, 0, "STREET_QUAL").Trim() != "-")
                            sql.AddParameter("@STR_NUM_END", DBNull.Value);
                        else
                            sql.AddParameter("@STR_NUM_END", g(vt, 0, "STREET_UNIT"));

                        sql.AddParameter("@STR_FRAC_START", DBNull.Value);
                        sql.AddParameter("@STR_FRAC_END", DBNull.Value);
                        sql.AddParameter("@STR_DIR", DBNull.Value);
                        sql.AddParameter("@STR_NAME", g(vt, 0, "STREET_NAME")==""?"N/A": g(vt, 0, "STREET_NAME"));
                        sql.AddParameter("@STR_SUFFIX", DBNull.Value);

                        if (g(vt, 0, "STREET_QUAL").Trim() == "-")
                            sql.AddParameter("@STR_UNIT_START", DBNull.Value);
                        else
                            sql.AddParameter("@STR_UNIT_START", g(vt, 0, "STREET_UNIT"));

                        sql.AddParameter("@STR_UNIT_END", DBNull.Value);
                        sql.AddParameter("@STR_UNIT_TYPE", DBNull.Value);

                        string s = g(vt, 0, "MAILING4").Trim();
                        string city = "";
                        string state = "";

                        if (s == "SEE OWNER")
                        {
                            sql.AddParameter("@SITUS_CITY", DBNull.Value);
                            sql.AddParameter("@SITUS_STATE", DBNull.Value);
                        }
                        else if (s.Contains(" ON"))
                        {
                            city = s.Replace(" ON", "").Trim();
                            state = "ON";

                            sql.AddParameter("@SITUS_CITY", city);
                            sql.AddParameter("@SITUS_STATE", state);
                        }
                        else if (s.Contains(' '))
                        {
                            string[] x = s.Split(' ');

                            city = s.Replace(x[x.Length - 1], "").Trim();
                            state = x[x.Length - 1];

                            sql.AddParameter("@SITUS_CITY", city);
                            sql.AddParameter("@SITUS_STATE", state);
                        }
                        else
                        {
                            sql.AddParameter("@SITUS_CITY", DBNull.Value);
                            sql.AddParameter("@SITUS_STATE", DBNull.Value);
                        }

                        sql.AddParameter("@SITUS_ZIP", g(vt, 0, "MAILING5", 10));
                        sql.AddParameter("@SITUS_COUNTY", DBNull.Value);
                        sql.AddParameter("@SITUS_COUNTRY", DBNull.Value);
                        sql.AddParameter("@SITUS_COUNTRY_CODE", DBNull.Value);
                        sql.AddParameter("@X_COORD", DBNull.Value);
                        sql.AddParameter("@Y_COORD", DBNull.Value);
                        sql.AddParameter("@ADDR_DESC", DBNull.Value);

                        string full = "";
                        string a1 = "";
                        string a2 = "";

                        if (g(vt, 0, "STREET_NO") != "")
                        {
                            full += g(vt, 0, "STREET_NO") + " ";
                            a1 += g(vt, 0, "STREET_NO") + " ";
                        }

                        if (g(vt, 0, "STREET_NAME") != "")
                        {
                            full += g(vt, 0, "STREET_NAME") + " ";
                            a1 += g(vt, 0, "STREET_NAME") + " ";
                        }

                        if (g(vt, 0, "STREET_UNIT") != "")
                        {
                            full += "Unit " + g(vt, 0, "STREET_UNIT") + " ";
                            a1 += "Unit " + g(vt, 0, "STREET_UNIT") + " ";
                        }

                        if (city != "")
                        {
                            full += city;
                            a1 += city;
                        }

                        if (g(vt, 0, "MAILING5") != "")
                            a2 += g(vt, 0, "MAILING5") + " ";

                        if (state != "")
                            a2 += state;

                        full = full.Trim();
                        a1 = a1.Trim();
                        a2 = a2.Trim();

                        sql.AddParameter("@FULL_ADDRESS", full);
                        sql.AddParameter("@ADDRESS1", a1);
                        sql.AddParameter("@ADDRESS2", a2);
                        sql.AddParameter("@SITUS_NBRHD", DBNull.Value);
                        sql.AddParameter("@EXT_ADDRESS_UID ", DBNull.Value);
                        sql.Run();
                    }
                }
               End of Violation Permit Address */
            }

            //Enter building permits into AATable_Permit_Comment
            if (PermitComment)
            {
                for (int i = 0; i < bp.Rows.Count; i++)
                {
                    SQL sql = new SQL(@"
            use accelastage;
            insert into AATable_Permit_Comment
            (
            PERMITNUM,
            COMMENTS,
            ADDEDBY,
            ADDEDDATE
            )
            values (
            @PERMITNUM,
            @COMMENTS,
            @ADDEDBY,
            @ADDEDDATE
            )");
                    sql.AddParameter("@PERMITNUM", DBNull.Value);
                    sql.AddParameter("@COMMENTS", DBNull.Value);
                    sql.AddParameter("@ADDEDBY", DBNull.Value);
                    sql.AddParameter("@ADDEDDATE", DBNull.Value);
                    sql.Run();
                }

                //Enter violations into AATable_Permit_Comment
                /* 20190613 vi
                for (int i = 0; i < vi.Rows.Count; i++)
                {
                    SQL sql = new SQL(@"
            use accelastage;
            insert into AATable_Permit_Comment
            (
            PERMITNUM,
            COMMENTS,
            ADDEDBY,
            ADDEDDATE
            )
            values (
            @PERMITNUM,
            @COMMENTS,
            @ADDEDBY,
            @ADDEDDATE
            )");
                    sql.AddParameter("@PERMITNUM", DBNull.Value);
                    sql.AddParameter("@COMMENTS", DBNull.Value);
                    sql.AddParameter("@ADDEDBY", DBNull.Value);
                    sql.AddParameter("@ADDEDDATE", DBNull.Value);
                    sql.Run();
                } */
            }

            //AATable_Permit_Fee
            if (PermitFee)
            {
                System.Diagnostics.Debug.WriteLine("Total permit count = {0}", bp.Rows.Count);
                int totalFee = 0;
                for (int i = 0; i < bp.Rows.Count; i++)
                {
                    var permit_type = g(bp, i, "permit_type");
                    //Keep S 
                    //if (permit_type == "S")
                    //{
                    //    continue;
                    //}

                    DataTable fees = CityView.Run("select * from sysadmin.bi_fees f join sysadmin.building_permits a on f.bi_app_id=a.recordId where a.application_date>='2018-11-01' and f.bi_app_id = @ID and not exists  (select 1 from sysadmin.inspections i where i.inspectioncomplete=1 and i.inspectiontype in ('FINAL','FININSP','OCCUP','OCCUPANCY','final','fininsp','occup') and i.bi_app_id=f.bi_app_id )", g(bp, i, "RECORDID"));
                    totalFee += fees.Rows.Count;

                    for (int f = 0; f < fees.Rows.Count; f++)
                    {
                        if (g(fees, f, "FEE_AMOUNT") != "")
                        {
                            /* FeeType is just PYMNET_TYPE  HOW TO MAPPING TO TT_FEE_CODE ??*/
                            string feeType = "";
                            temp = CityView.Run("select description from sysadmin.lookupbi_fee_type where code = @ID", g(fees, f, "FEE_TYPE").ToUpper());

                            if (temp.Rows.Count > 0)
                                feeType = g(temp, 0, "description");
                            else
                                feeType = "N/A";

                            string feeCode = g(fees, f, "FEE_TYPE");
                            if (string.IsNullOrEmpty(feeCode))
                            {
                                feeCode = "NA";
                            }

                            SQL sql = new SQL(@"
            use accelastage;
            insert into AATable_Permit_Fee
            (
            PERMITNUM,
            FEE_KEY,
            TT_FEE_CODE,
            GF_FEE_PERIOD,
            FEE_ITEM_AMOUNT,
            GF_DISPLAY,
            ACCOUNT_CODE1,
            ACCOUNT_CODE2,
            ACCOUNT_CODE3,
            GF_FEE_SCHEDULE,
            REC_DATE,
            REC_FUL_NAM,
            TT_FEE_DESC,
            GF_UNIT,
            INVOICE,
            FEE_NOTES,
            FEE_SCHEDULE_VERSION,
            INVOICE_CUSTOMIZED_NBR,
            GF_FEE_TYPE_ALLOCATION,
            GF_L1_ALLOCATION,
            GF_L2_ALLOCATION,
            GF_L3_ALLOCATION
            )
            values (
            @PERMITNUM,
            @FEE_KEY,
            @TT_FEE_CODE,
            @GF_FEE_PERIOD,
            @FEE_ITEM_AMOUNT,
            @GF_DISPLAY,
            @ACCOUNT_CODE1,
            @ACCOUNT_CODE2,
            @ACCOUNT_CODE3,
            @GF_FEE_SCHEDULE,
            @REC_DATE,
            @REC_FUL_NAM,
            @TT_FEE_DESC,
            @GF_UNIT,
            @INVOICE,
            @FEE_NOTES,
            @FEE_SCHEDULE_VERSION,
            @INVOICE_CUSTOMIZED_NBR,
            @GF_FEE_TYPE_ALLOCATION,
            @GF_L1_ALLOCATION,
            @GF_L2_ALLOCATION,
            @GF_L3_ALLOCATION
            )");
                            sql.AddParameter("@PERMITNUM", g(bp, i, "APPLICATION_NUMBER"));
                            //sql.AddParameter("@FEE_KEY", g(fees, f, "BI_APP_ID"));
                            sql.AddParameter("@FEE_KEY", g(fees, f, "RECORDID"));
                            sql.AddParameter("@TT_FEE_CODE", feeCode);
                            sql.AddParameter("@GF_FEE_PERIOD", "FINAL");
                            sql.AddParameter("@FEE_ITEM_AMOUNT", g(fees, f, "FEE_AMOUNT"));
                            sql.AddParameter("@GF_DISPLAY", f + 1);
                            sql.AddParameter("@ACCOUNT_CODE1", DBNull.Value);
                            sql.AddParameter("@ACCOUNT_CODE2", DBNull.Value);
                            sql.AddParameter("@ACCOUNT_CODE3", DBNull.Value);
                            sql.AddParameter("@GF_FEE_SCHEDULE", DBNull.Value);
                            sql.AddParameter("@REC_DATE", g(fees, f, "FEE_DATE"));
                            sql.AddParameter("@REC_FUL_NAM", "Legacy");
                            sql.AddParameter("@TT_FEE_DESC", feeType);
                            sql.AddParameter("@GF_UNIT", DBNull.Value);
                            sql.AddParameter("@INVOICE", DBNull.Value);
                            sql.AddParameter("@FEE_NOTES", DBNull.Value);
                            sql.AddParameter("@FEE_SCHEDULE_VERSION", DBNull.Value);
                            sql.AddParameter("@INVOICE_CUSTOMIZED_NBR", g(bp, i, "APPLICATION_NUMBER") + "-" + g(fees, f, "RECORDID"));
                            sql.AddParameter("@GF_FEE_TYPE_ALLOCATION", DBNull.Value);
                            sql.AddParameter("@GF_L1_ALLOCATION", DBNull.Value);
                            sql.AddParameter("@GF_L2_ALLOCATION", DBNull.Value);
                            sql.AddParameter("@GF_L3_ALLOCATION", DBNull.Value);
                            sql.Run();
                        }
                    }
                }
                System.Diagnostics.Debug.WriteLine("Total Fee count = {0}", totalFee);
            }

            //AATable_Permit_FeeAllocation

            if (PermitFeeAllocation)
            {
                int totalPayment = 0;
                for (int i = 0; i < bp.Rows.Count; i++)
                {
                    //DataTable payments = CityView.Run("select * from sysadmin.bi_payments f where f.bi_app_id = @ID  and exists (select 1 from sysadmin.inspections i where i.Final!=1 and i.bi_app_id =f.bi_app_id)", g(bp, i, "RECORDID"));
                    var permit_type = g(bp, i, "permit_type");
                    //if (permit_type == "S")
                    //{
                    //    continue;
                    //}

                    DataTable payments = CityView.Run("select * from sysadmin.bi_payments p join sysadmin.building_permits a on p.bi_app_id=a.recordId where a.application_date>='2018-11-01' and p.bi_app_id = @ID and  not exists  (select 1 from sysadmin.inspections i where i.inspectioncomplete=1 and i.inspectiontype in ('FINAL','FININSP','OCCUP','OCCUPANCY','final','fininsp','occup') and i.bi_app_id=p.bi_app_id )", g(bp, i, "RECORDID"));
                    string paymentStatus = "PAYMENT";
                    string paymentMethod = "Cash";
                    totalPayment += payments.Rows.Count;

                    for (int p = 0; p < payments.Rows.Count; p++)
                    {
                        if (g(payments, p, "PYMNT_AMOUNT") != "")
                        {
                            paymentStatus = g(payments, p, "PYMNT_TYPE");

                            if (paymentStatus == "REF")
                            {
                                paymentStatus = "REFUND";
                            }
                            else
                            {
                                paymentStatus = "PAYMENT";
                            }

                            var paymentMethod1 = g(payments, p, "CHEQUE_NO");
                            paymentMethod = g(payments, p, "CHEQUE_NO");

                            if (string.IsNullOrEmpty(paymentMethod))
                            {
                                paymentMethod = "Cash";
                            }
                            else if (paymentMethod.ToUpper().IndexOf("VISA") >= 0 || paymentMethod.ToUpper().IndexOf("MASTER") >= 0 || paymentMethod.ToUpper().IndexOf("MC") >= 0 || paymentMethod.ToUpper().IndexOf("AMEX") >= 0)
                            {
                                paymentMethod = "Credit Card";
                            }
                            else if (paymentMethod.ToUpper().IndexOf("DEBIT") >= 0 || paymentMethod.ToUpper().IndexOf("INTER") >= 0)
                            {
                                paymentMethod = "Trust Account";
                            }
                            else if (paymentMethod.ToUpper().IndexOf("CHEQUE") >= 0)
                            {
                                paymentMethod = "Check";
                            }
                            else if (paymentMethod.IndexOf(".") >= 0)
                            {
                                paymentMethod = "Cash";
                            }
                            else if (paymentMethod == "0")
                            {

                            }
                            else if (System.Text.RegularExpressions.Regex.IsMatch(paymentMethod, "^[0-9]+$"))
                            {
                                paymentMethod = "Check";
                            }
                            else
                            {
                                paymentMethod = "Cash";
                            }


                            var tempfees = CityView.Run("select * from sysadmin.bi_fees f where f.bi_app_id = @ID ", g(bp, i, "RECORDID"));
                            if (tempfees.Rows.Count == 0)
                                paymentMethod = "PAYMENT ONLY";


                            // System.Diagnostics.Debug.WriteLine("** {0} - {1} - {2}", g(payments, p, "RECORDID"), paymentMethod, paymentMethod1);

                            SQL sql = new SQL(@"
            use accelastage;
            insert into AATable_Permit_FeeAllocation
            (
            PERMITNUM,
            FEE_KEY,
            HIST_RECEIPT_NBR,
            PAYMENT_STATUS,
            GF_FEE_PERIOD,
            CC_TYPE,
            CC_EXP_DATE,
            PAYEE,
            PAYMENT_DATE,
            PAYMENT_AMOUNT,
            PAYMENT_METHOD,
            PAYMENT_COMMENT,
            CASHIER_ID,
            REGISTER_NBR,
            PAYMENT_REF_NBR,
            VOID_DATE,
            VOID_BY
            )
            values (
            @PERMITNUM,
            @FEE_KEY,
            @HIST_RECEIPT_NBR,
            @PAYMENT_STATUS,
            @GF_FEE_PERIOD,
            @CC_TYPE,
            @CC_EXP_DATE,
            @PAYEE,
            @PAYMENT_DATE,
            @PAYMENT_AMOUNT,
            @PAYMENT_METHOD,
            @PAYMENT_COMMENT,
            @CASHIER_ID,
            @REGISTER_NBR,
            @PAYMENT_REF_NBR,
            @VOID_DATE,
            @VOID_BY
            )");
                            sql.AddParameter("@PERMITNUM", g(bp, i, "APPLICATION_NUMBER"));
                            //sql.AddParameter("@FEE_KEY", g(payments, p, "BI_APP_ID"));
                            sql.AddParameter("@FEE_KEY", g(payments, p, "RECORDID"));
                            sql.AddParameter("@HIST_RECEIPT_NBR", g(bp, i, "APPLICATION_NUMBER") + "-" + g(payments, p, "RECORDID"));
                            sql.AddParameter("@PAYMENT_STATUS", paymentStatus);
                            sql.AddParameter("@GF_FEE_PERIOD", DBNull.Value);
                            sql.AddParameter("@CC_TYPE", DBNull.Value);
                            sql.AddParameter("@CC_EXP_DATE", DBNull.Value);
                            sql.AddParameter("@PAYEE", "Legacy");
                            sql.AddParameter("@PAYMENT_DATE", g(payments, p, "PYMNT_DATE"));
                            sql.AddParameter("@PAYMENT_AMOUNT", g(payments, p, "PYMNT_AMOUNT"));
                            sql.AddParameter("@PAYMENT_METHOD", paymentMethod);
                            sql.AddParameter("@PAYMENT_COMMENT", DBNull.Value);
                            sql.AddParameter("@CASHIER_ID", "CityView");
                            sql.AddParameter("@REGISTER_NBR", DBNull.Value);
                            sql.AddParameter("@PAYMENT_REF_NBR", DBNull.Value);
                            sql.AddParameter("@VOID_DATE", DBNull.Value);
                            sql.AddParameter("@VOID_BY", DBNull.Value);

                            //Only submit the payment if the fee exists
                            //if (CityView.Run("select * from sysadmin.bi_fees where bi_app_id = @ID", g(fees, p, "BI_APP_ID")).Rows.Count > 0)
                            sql.Run();
                        }
                    }
                }
                System.Diagnostics.Debug.WriteLine("Total payment count = {0}", totalPayment);
            }


            //AATable_Permit_Insp
            if (PermitInsp)
            {
                for (int i = 0; i < bp.Rows.Count; i++)
                {
                    // Console.WriteLine("adding record line 2116 inside permitinsp");
                    DataTable insp = CityView.Run("select * from sysadmin.inspections where BI_APP_ID = @ID", g(bp, i, "RECORDID"));
                    //Console.WriteLine("adding record line 2119 inside permitinsp " + bp);

                    for (int j = 0; j < insp.Rows.Count; j++)
                    {
                        SQL sql = new SQL(@"
            use accelastage;
            insert into AATable_Permit_Insp
            (
            PERMITNUM,
            TT_INSPECTION,
            INSPDATE,
            TT_INSPECTION_STATUS,
            INSPSCHEDDATE,
            INSPREQDATE,
            INSP_FNAME,
            INSP_MNAME,
            INSP_LNAME,
            USER_ID ,
            INSP_NUMBER,
            INSP_REQUIRED,
            PHONE_NUM,
            LATITUDE,
            LONGITUDE,
            AGENCY_CODE,
            BUREAU_CODE,
            DIVISION_CODE,
            OFFICE_CODE,
            SECTION_CODE,
            GROUP_CODE,
            INSP_RESULT_COMM,
            INSP_SCHED_COMM,
            SD_OVERTIME,
            DISPLAY_IN_ACA,
            CONTACT_NBR,
            INSP_SEQ_NBR
            )
            values (
            @PERMITNUM,
            @TT_INSPECTION,
            @INSPDATE,
            @TT_INSPECTION_STATUS,
            @INSPSCHEDDATE,
            @INSPREQDATE,
            @INSP_FNAME,
            @INSP_MNAME,
            @INSP_LNAME,
            @USER_ID ,
            @INSP_NUMBER,
            @INSP_REQUIRED,
            @PHONE_NUM,
            @LATITUDE,
            @LONGITUDE,
            @AGENCY_CODE,
            @BUREAU_CODE,
            @DIVISION_CODE,
            @OFFICE_CODE,
            @SECTION_CODE,
            @GROUP_CODE,
            @INSP_RESULT_COMM,
            @INSP_SCHED_COMM,
            @SD_OVERTIME,
            @DISPLAY_IN_ACA,
            @CONTACT_NBR,
            @INSP_SEQ_NBR
            )");
                        sql.AddParameter("@PERMITNUM", g(bp, i, "APPLICATION_NUMBER"));
                        //sql.AddParameter("@PERMITNUM", g(insp, j, "RECORDID")); //changed RW April 30 2020 to display application number 
                        // Console.WriteLine("adding record line 2185 this is insp " + insp);

                        if (g(insp, j, "INSPECTIONTYPE").ToString() != "")
                        {
                            if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "AIRBAR")
                            {
                                sql.AddParameter("@TT_INSPECTION", "AIR BARRIER");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "CONSUL")
                            {
                                sql.AddParameter("@TT_INSPECTION", "CONSULTANT");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "DRAIN")
                            {
                                sql.AddParameter("@TT_INSPECTION", "INSIDE DRAINS");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "FINAL")
                            {
                                sql.AddParameter("@TT_INSPECTION", "FINAL COMPLETION");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "FININSP")
                            {
                                sql.AddParameter("@TT_INSPECTION", "FINAL INSPECTION");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "FIRE")
                            {
                                sql.AddParameter("@TT_INSPECTION", "FIRE PROTECTION - CYFS");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "FOOT")
                            {
                                sql.AddParameter("@TT_INSPECTION", "EXCAVATION");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "FOUND")
                            {
                                sql.AddParameter("@TT_INSPECTION", "FOUNDATION WALLS - BACKFILL");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "FRAME")
                            {
                                sql.AddParameter("@TT_INSPECTION", "FRAMING COMPLETED");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "GARA")
                            {
                                sql.AddParameter("@TT_INSPECTION", "GARAGE INSULATION");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "GEO")
                            {
                                sql.AddParameter("@TT_INSPECTION", "GEOTECHNICAL");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "HVAC")
                            {
                                sql.AddParameter("@TT_INSPECTION", "FIRE SEPARATIONS");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "HVAC2")
                            {
                                sql.AddParameter("@TT_INSPECTION", "HVAC");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "INSUL")
                            {
                                sql.AddParameter("@TT_INSPECTION", "INSULATION");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "INSIDE DRAINS")
                            {
                                sql.AddParameter("@TT_INSPECTION", "INSIDE DRAINS");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "OCCUP")
                            {
                                sql.AddParameter("@TT_INSPECTION", "OCCUPANCY");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "OTHER")
                            {
                                sql.AddParameter("@TT_INSPECTION", "OTHER");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "PLUMB")
                            {
                                sql.AddParameter("@TT_INSPECTION", "PLUMBING");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "PREINSP")
                            {
                                sql.AddParameter("@TT_INSPECTION", "PRE-INSPECTION");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "REINSP")
                            {
                                sql.AddParameter("@TT_INSPECTION", "MISCELLANEOUS");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "SEWER")
                            {
                                sql.AddParameter("@TT_INSPECTION", "EXTERIOR SEWER");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "SRHCP")
                            {
                                sql.AddParameter("@TT_INSPECTION", "SRHC - PRE-OCCUPANCY");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "SRHCW")
                            {
                                sql.AddParameter("@TT_INSPECTION", "SRHC-WALK-THROUGH / MEETING");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "VENT")
                            {
                                sql.AddParameter("@TT_INSPECTION", "DRAINAGE & VENTING SYSTEMS");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "WATER")
                            {
                                sql.AddParameter("@TT_INSPECTION", "WATER DISTRIBUTION SYSTEMS");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "WATER1")
                            {
                                sql.AddParameter("@TT_INSPECTION", "WATER SERVICE PIPES");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "PLUMBINGI")
                            {
                                sql.AddParameter("@TT_INSPECTION", "PLUMBING");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "OCCUPANCY")
                            {
                                sql.AddParameter("@TT_INSPECTION", "OCCUPANCY");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "-BACKFIL")
                            {
                                sql.AddParameter("@TT_INSPECTION", "FOUNDATION WALL-BACKFIL");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "IN")
                            {
                                sql.AddParameter("@TT_INSPECTION", "INSULATION");
                            }
                            else if (g(insp, j, "INSPECTIONTYPE").ToString().ToUpper() == "SRHCW")
                            {
                                sql.AddParameter("@TT_INSPECTION", "SRHC - WALKTHROUGH/ MEETING");
                            }
                            else
                            {
                                sql.AddParameter("@TT_INSPECTION", g(insp, j, "INSPECTIONTYPE").ToString().ToLower());
                            }

                        }
                        else
                        {
                            sql.AddParameter("@TT_INSPECTION", g(insp, j, "INSPECTIONTYPE").ToString().ToLower());
                        }

                        sql.AddParameter("@INSPDATE", g(insp, j, "INSPECTIONDATE"));
                        sql.AddParameter("@TT_INSPECTION_STATUS", g(insp, j, "INSPECTIONCOMPLETE") == "0" ? "Failed" : "Passed");
                        sql.AddParameter("@INSPSCHEDDATE", g(insp, j, "INSPECTIONDATE"));
                        sql.AddParameter("@INSPREQDATE", DBNull.Value);

                        temp = CityView.Run("select * from sysadmin.lookupbiinspector where code = @ID", g(insp, j, "INSPECTOR"));

                        if (temp.Rows.Count > 0)
                        {
                            string s = g(temp, 0, "description");

                            if (s.Contains(' '))
                            {
                                int x = s.IndexOf(' ');

                                sql.AddParameter("@INSP_FNAME", s.Substring(0, x));
                                sql.AddParameter("@INSP_MNAME", DBNull.Value);
                                sql.AddParameter("@INSP_LNAME", s.Substring(x));
                            }
                            else
                            {
                                sql.AddParameter("@INSP_FNAME", g(temp, 0, "description"));
                                sql.AddParameter("@INSP_MNAME", DBNull.Value);
                                sql.AddParameter("@INSP_LNAME", DBNull.Value);
                            }
                        }
                        else
                        {
                            sql.AddParameter("@INSP_FNAME", DBNull.Value);
                            sql.AddParameter("@INSP_MNAME", DBNull.Value);
                            sql.AddParameter("@INSP_LNAME", DBNull.Value);
                        }

                        sql.AddParameter("@USER_ID ", g(insp, j, "INSPECTOR"));
                        sql.AddParameter("@INSP_NUMBER", g(insp, j, "RECORDID"));
                        sql.AddParameter("@INSP_REQUIRED", DBNull.Value);
                        sql.AddParameter("@PHONE_NUM", DBNull.Value);
                        sql.AddParameter("@LATITUDE", DBNull.Value);
                        sql.AddParameter("@LONGITUDE", DBNull.Value);
                        sql.AddParameter("@AGENCY_CODE", DBNull.Value);
                        sql.AddParameter("@BUREAU_CODE", DBNull.Value);
                        sql.AddParameter("@DIVISION_CODE", DBNull.Value);
                        sql.AddParameter("@OFFICE_CODE", DBNull.Value);
                        sql.AddParameter("@SECTION_CODE", DBNull.Value);
                        sql.AddParameter("@GROUP_CODE", DBNull.Value);
                        sql.AddParameter("@INSP_RESULT_COMM", g(insp, j, "COMMENT_"));
                        sql.AddParameter("@INSP_SCHED_COMM", DBNull.Value);
                        sql.AddParameter("@SD_OVERTIME", DBNull.Value);
                        sql.AddParameter("@DISPLAY_IN_ACA", DBNull.Value);
                        sql.AddParameter("@CONTACT_NBR", DBNull.Value);
                        sql.AddParameter("@INSP_SEQ_NBR", DBNull.Value);
                        sql.Run();
                    }
                }
            }

            //ASI_ApplicationInformation
            if (PermitApplicationInformation)
            {
                string[] App_Info = { "PERMIT_TYPE", "Applicant_name","Corp_part","Application_Date","Buildingpermit_issuedate","Applicant_Address","Applicant_unit",
                                        "Applicant_prov","Applicant_postalcde","Applicant_phone","Applicant_email","Application_status","FAX_NUMBER","CELL_NUMBER","NO_Dwelling_units",
                                        "estimated_cost","square_footage","square_meters","completed"};
                for (int i = 0; i < bp.Rows.Count; i++)
                {
                    SQL sql = new SQL(@"
                        use accelastage;
                        insert into ASI_ApplicationInformation
                        (
                            PERMITNUM,
                            Permit_Type,
                            Applicant_name,
                            Corp_part,
                            Application_Date,
                            Buildingpermit_issuedate,
                            Applicant_Address,
                            Applicant_unit,
                            Applicant_prov,
                            Applicant_postalcde,
                            Applicant_phone,
                            Applicant_email,
                            Application_status,
                            FAX_NUMBER,
                            CELL_NUMBER,
                            NO_Dwelling_units,
                            estimated_cost,
                            square_footage,
                            square_meters,
                            completed,
                            TT_RECORD
                        )
                        values 
                       (
                            @PERMITNUM,
                            @Permit_Type,
                            @Applicant_name,
                            @Corp_part,
                            @Application_Date,
                            @Buildingpermit_issuedate,
                            @Applicant_Address,
                            @Applicant_unit,
                            @Applicant_prov,
                            @Applicant_postalcde,
                            @Applicant_phone,
                            @Applicant_email,
                            @Application_status,
                            @FAX_NUMBER,
                            @CELL_NUMBER,
                            @NO_Dwelling_units,
                            @estimated_cost,
                            @square_footage,
                            @square_meters,
                            @completed,
                            @TT_RECORD
                       )");

                        sql.AddParameter("@PERMITNUM", g(bp, i, "APPLICATION_NUMBER"));
                        for (int AP = 0; AP < App_Info.Length; AP++)
                        {
                            sql.AddParameter("@" + App_Info[AP], g(bp, i, App_Info[AP]));
                        }   


                    string[] ADU = new string[] {
                        "A2019-00318",
                        "P2010-00020",
                        "A2010-00851",
                        "P2010-00722",
                        "P2010-00961",
                        "P2010-00547",
                        "P2010-00548",
                        "A2010-00813",
                        "P2010-00831",
                        "P2010-00934",
                        "P2010-00534",
                        "P2010-00282",
                        "P2010-00261",
                        "P2010-00944",
                        "P2010-00723",
                        "P2011-00478",
                        "P2011-00479",
                        "P2011-00561",
                        "P2019-00036",
                        "P2018-00040",
                        "P2018-00224",
                        "P2019-00493",
                        "P2017-00517",
                        "P2017-00561",
                        "P2018-00037",
                        "P2019-00396",
                        "P2019-00121",
                        "P2016-00292",
                        "P2016-00133",
                        "A2016-00118",
                        "P2016-00173",
                        "P2016-00069",
                        "P2015-00763",
                        "P2016-00068",
                        "P2015-00959",
                        "A2020-00005",
                        "P2018-00235",
                        "P2016-00335",
                        "P2016-00353",
                        "P2019-00035",
                        "P2019-00420",
                        "P2013-00308",
                        "P2013-00213",
                        "P2013-00300",
                        "P2013-00893",
                        "A2013-00900",
                        "P2014-00302",
                        "P2017-00615",
                        "P2012-00055",
                        "P2015-00961",
                        "P2011-00672",
                        "P2011-00497",
                        "P2012-00392",
                        "P2012-00579",
                        "P2012-00381",
                        "P2012-00738",
                        "P2012-00576",
                        "P2013-00765",
                        "P2013-00762",
                        "P2013-00767",
                        "P2013-00048",
                        "P2013-00860",
                        "P2014-00136",
                        "P2014-00361",
                        "P2014-00583",
                        "A2014-00674",
                        "P2015-00422",
                        "P2015-00790",
                        "P2015-00479",
                        "P2015-00792",
                        "P2015-00685",
                        "P2015-00672",
                        "P2015-00347",
                        "P2015-00601",
                        "P2015-00736",
                        "P2015-00644",
                        "P2015-00610",
                        "P2016-00222",
                        "P2016-00247",
                        "P2017-00264",
                        "P2017-00076",
                        "P2014-00359",
                        "P2017-00826",
                        "P2019-00267",
                        "P2019-00527",
                        "P2019-00328",
                        "P2013-00798",
                        "P2013-00662",
                        "P2013-00314",
                        "P2014-00584",
                        "P2014-00363",
                        "P2018-00301",
                        "P2018-00002",
                        "P2018-00661",
                        "P2019-00324",
                        "P2018-00699",
                        "P2018-00688",
                        "P2018-00284",
                        "P2019-00426",
                        "P2019-00293",
                        "P2018-00373",
                        "P2019-00321",
                        "P2019-00064",
                        "A2019-00501",
                        "P2019-00246",
                        "P2019-00483",
                        "P2015-00830",
                        "P2015-00461",
                        "P2015-00842",
                        "P2013-00872",
                        "P2015-00891",
                        "P2018-00271",
                        "P2019-00270",
                        "P2019-00232",
                        "P2011-00507",
                        "P2011-00584",
                        "P2017-00673",
                        "P2011-00416",
                        "P2013-00117",
                        "P2015-00512",
                        "P2013-00663",
                        "A2018-00712",
                        "P2014-00069",
                        "P2014-00362",
                        "P2014-00026",
                        "P2013-00626",
                        "P2013-00620",
                        "P2013-00610",
                        "P2014-00030",
                        "P2012-00325",
                        "P2018-00601",
                        "P2014-00077",
                        "P2015-00511",
                        "P2017-00874",
                        "A2019-00535",
                        "A2017-00672",
                        "P2016-00228",
                        "P2016-00063",
                        "P2013-00745",
                        "P2015-00421",
                        "P2019-00424",
                        "P2011-00603",
                        "P2011-00095",
                        "P2011-00834",
                        "P2011-01102",
                        "P2011-00081",
                        "A2011-00193",
                        "P2011-00299",
                        "P2011-00715",
                        "P2011-00836",
                        "A2011-00744",
                        "P2012-00170",
                        "P2012-00042",
                        "P2012-00087",
                        "P2012-00109",
                        "P2014-00354",
                        "P2014-00337",
                        "P2014-00143",
                        "P2019-00212",
                        "P2011-00004",
                        "P2011-01173",
                        "P2019-00325",
                        "P2013-00147",
                        "P2012-00313",
                        "P2019-00194",
                        "P2014-00179",
                        "P2014-00243",
                        "P2016-00240",
                        "A2019-00333",
                        "P2016-00003",
                        "P2012-00316",
                        "P2016-00057",
                        "P2019-00488",
                        "P2015-00710",
                        "P2014-00241",
                        "P2015-00709",
                        "P2017-00675",
                        "P2017-00816",
                        "P2018-00551",
                        "P2015-00907",
                        "P2013-00028",
                        "P2015-00864",
                        "P2016-00242",
                        "P2016-00006",
                        "P2019-00011",
                        "P2016-00105",
                        "P2019-00144",
                        "P2016-00215",
                        "P2014-00194",
                        "P2014-00635",
                        "P2018-00292",
                        "P2014-00608",
                        "P2011-00691",
                        "A2016-00339",
                        "P2013-00141",
                        "P2015-00888",
                        "P2016-00546",
                        "P2016-00551",
                        "P2016-00114",
                        "P2016-00115",
                        "P2016-00360",
                        "P2013-00134",
                        "P2014-00540",
                        "P2012-00631",
                        "P2012-00079",
                        "P2012-00186",
                        "P2017-00597",
                        "P2013-00575",
                        "P2012-00289",
                        "A2013-00562",
                        "P2012-00253",
                        "A2017-00752",
                        "P2015-00537",
                        "P2016-00107",
                        "P2018-00584",
                        "P2016-00220",
                        "P2016-00163",
                        "A2020-00003",
                        "P2016-00517",
                        "P2016-00552",
                        "P2015-00455",
                        "P2018-00003",
                        "P2016-00564",
                        "P2015-00714",
                        "A2014-00257",
                        "P2018-00028",
                        "P2016-00446",
                        "P2018-00055",
                        "P2019-00012",
                        "P2014-00607",
                        "P2016-00537",
                        "P2018-00245",
                        "P2016-00570",
                        "P2018-00560",
                        "P2019-00540",
                        "P2017-00098",
                        "A2017-00841",
                        "P2019-00120",
                        "A2017-00084",
                        "P2015-00924",
                        "P2016-00392",
                        "P2018-00729",
                        "P2018-00007",
                        "P2019-00541",
                        "A2019-00394",
                        "A2018-00730",
                        "A2018-00202",
                        "P2016-00036",
                        "P2016-00058",
                        "P2014-00203",
                        "P2016-00438",
                        "P2014-00617",
                        "P2015-00952",
                        "P2014-00631",
                        "A2017-00589",
                        "P2014-00614",
                        "P2016-00338",
                        "P2014-00622",
                        "P2016-00545",
                        "P2018-00383",
                        "P2014-00250",
                        "P2015-00879",
                        "P2019-00506",
                        "P2019-00380",
                        "P2019-00066",
                        "A2019-00059",
                        "P2019-00114",
                        "P2019-00391",
                        "P2016-00064",
                        "A2019-00086",
                        "P2019-00448",
                        "P2019-00235",
                        "P2018-00690",
                        "P2011-00399",
                        "P2016-00044",
                        "P2013-00869",
                        "P2015-00973",
                        "P2014-00364",
                        "P2014-00118",
                        "P2012-00301",
                        "P2014-00594",
                        "P2015-00897",
                        "P2015-00110",
                        "P2014-00391",
                        "P2014-00120",
                        "P2012-00278",
                        "P2011-01058",
                        "P2012-00177",
                        "P2015-00847",
                        "A2019-00178",
                        "A2014-00170",
                        "P2013-00148",
                        "P2015-00102",
                        "P2019-00333"
                    };

                    //sql.AddParameter("@TT_RECORD", "");
                    var converttoint = false;
                    if (g(bp, i, "APPLICATION_NUMBER") == "A2020-00059")
                    {

                    }
                    if (g(bp, i, "APPLICATION_NUMBER") == "560" || g(bp, i, "APPLICATION_NUMBER") == "A0-26627" || g(bp, i, "APPLICATION_NUMBER") == "A0-26628" || g(bp, i, "APPLICATION_NUMBER") == "P012-10114")
                    {
                        //Console.WriteLine("line 544 permit number is " + bp);
                        sql.AddParameter("@TT_RECORD", "Historic");
                    }
                    else if (g(bp, i, "APPLICATION_NUMBER") == "S0-0" || g(bp, i, "APPLICATION_NUMBER") == "B10-0")
                    {
                        sql.AddParameter("@TT_RECORD", "Historic");
                    }

                    else
                    {
                        var temp3 = g(bp, i, "APPLICATION_NUMBER").ToString();
                        //var temp2 = g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1);

                        if (g(bp, i, "APPLICATION_NUMBER").Length > 0)
                            converttoint = Int32.TryParse(g(bp, i, "APPLICATION_NUMBER").Substring(1, 4), out int result);


                        if (converttoint)
                        {
                            if (Int32.Parse(g(bp, i, "APPLICATION_NUMBER").Substring(1, 4)) <= 2009)
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else
                            {
                                if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2199")
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2200")
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3199")
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3200")
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1) == "A")
                                {
                                    sql.AddParameter("@TT_RECORD", "Alternative Solution");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1) == "P")
                                {
                                    sql.AddParameter("@TT_RECORD", "Partial Permit");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1) == "C")
                                {
                                    sql.AddParameter("@TT_RECORD", "Conditional Permit");
                                }
                                else if (ADU.Contains(g(bp, i, "APPLICATION_NUMBER").ToString()))
                                {
                                    sql.AddParameter("@TT_RECORD", "Accessory Dwelling Unit");
                                }
                                else if (g(bp, i, "APPLICATION_Type") == "01")
                                {
                                    sql.AddParameter("@TT_RECORD", "Building Permit - New");
                                }
                                else if (g(bp, i, "FLAG_ALTREP") == "1")
                                {
                                    sql.AddParameter("@TT_RECORD", "Altration");
                                }
                                else if (g(bp, i, "FLAG_DEMO") == "1")
                                {
                                    sql.AddParameter("@TT_RECORD", "Demolision");
                                }
                                else if (g(bp, i, "BUILDINGCLASSFICATION") == "0014")
                                {
                                    sql.AddParameter("@TT_RECORD", "Deck");
                                }
                                else if (g(bp, i, "FLAG_ADDITIONAL") == "1")
                                {
                                    sql.AddParameter("@TT_RECORD", "Addition");
                                }
                                else if (g(bp, i, "APPLICATION_Type") == "06")
                                {
                                    sql.AddParameter("@TT_RECORD", "Mechanical");
                                }
                                else if (g(bp, i, "BUILDINGCLASSFICATION") == "0012")
                                {
                                    sql.AddParameter("@TT_RECORD", "Solar Panel");
                                }
                                else if (g(bp, i, "BUILDINGCLASSFICATION") == "0016")
                                {
                                    sql.AddParameter("@TT_RECORD", "Temporary");
                                }
                                else if (g(bp, i, "BUILDINGCLASSFICATION") == "0017")
                                {
                                    sql.AddParameter("@TT_RECORD", "Change Of Use");
                                }
                                else if (g(bp, i, "PERMIT_TYPE") == "S" || g(bp, i, "PERMIT_TYPE") == "s")
                                {
                                    sql.AddParameter("@TT_RECORD", "Signs");
                                }
                                else if (g(bp, i, "PERMIT_TYPE") == "P" || g(bp, i, "PERMIT_TYPE") == "p")
                                {
                                    sql.AddParameter("@TT_RECORD", "Pool");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "PP2020-10200")
                                {
                                    sql.AddParameter("@TT_RECORD", "Pool");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "SP2020-10198")
                                {
                                    sql.AddParameter("@TT_RECORD", "Pool");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "1997-11352")
                                {
                                    sql.AddParameter("@TT_RECORD", "Pool");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "15")
                                {
                                    if (g(bp, i, "CONSTRUCTION_TYPE") == "101")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Building Permit - New");
                                    }
                                    else if (g(bp, i, "CONSTRUCTION_TYPE") == "116")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Addition");
                                    }
                                    else if (g(bp, i, "CONSTRUCTION_TYPE") == "117")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Addition");
                                    }
                                    else
                                    {
                                        sql.AddParameter("@TT_RECORD", "");
                                    }

                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "02")
                                {
                                    sql.AddParameter("@TT_RECORD", "Addition");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "02")
                                {
                                    sql.AddParameter("@TT_RECORD", "Altration");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "11")
                                {
                                    sql.AddParameter("@TT_RECORD", "Change Of Use");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "111")
                                {
                                    sql.AddParameter("@TT_RECORD", "Signs");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "12")
                                {
                                    sql.AddParameter("@TT_RECORD", "Building Permit - New");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "999")
                                {
                                    sql.AddParameter("@TT_RECORD", "Demolision");
                                }
                                else
                                {
                                    sql.AddParameter("@TT_RECORD", "");
                                }
                            }
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2199")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3199")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "60")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "990-")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "A200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "D200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "G199")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "P200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "PP2020-10200")
                        {
                            sql.AddParameter("@TT_RECORD", "Pool");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "SP2020-10198")
                        {
                            sql.AddParameter("@TT_RECORD", "Pool");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "1997-11352")
                        {
                            sql.AddParameter("@TT_RECORD", "Pool");
                        }
                        else
                        {
                            sql.AddParameter("@TT_RECORD", "");
                        }

                    }
                    if (g(bp, i, "APPLICATION_NUMBER") != "" && g(bp, i, "APPLICATION_NUMBER") != "A2020-11354" && g(bp, i, "APPLICATION_NUMBER") != "A2020-20394"
                        && g(bp, i, "APPLICATION_NUMBER") != "A2020-11479" && g(bp, i, "APPLICATION_NUMBER") != "A2020-11493" && g(bp, i, "APPLICATION_NUMBER") != "P2019-99999"
                        && g(bp, i, "APPLICATION_NUMBER") != "A2020-11484" && g(bp, i, "APPLICATION_NUMBER") != "A2020-00775" && g(bp, i, "APPLICATION_NUMBER") != "A2020-11111"
                        && g(bp, i, "APPLICATION_NUMBER") != "A2021-11016" && g(bp, i, "APPLICATION_NUMBER") != "A2020-00350")
                    {
                        sql.Run();

                    }
                }

            }
            //ASI_REFERRALS
            if (PermitReferral)
            {
                string[] Referral = {"REFERRAL_AGENCY", "APPROVED", "COMMENT_", "WORKFLOW_DATE" };
                for (int i = 0; i < bp.Rows.Count; i++)
                {
                    
                    DataTable ReferralTable = CityView.Run("select * from sysadmin.referrals where  bi_app_id = @ID ", g(bp, i, "recordid"));

                   for(var rf=0; rf < ReferralTable.Rows.Count; rf++)
                    {
                        SQL sql = new SQL(@"
                            use accelastage;
                            insert into ASI_REFERRALS
                            (
                                PERMITNUM,
                                PERMIT_TYPE,
                                REFERRAL_AGENCY,
                                APPROVED,
                                COMMENT_,
                                WORKFLOW_DATE,
                                TT_RECORD
                            )
                            values 
                           (
                                @PERMITNUM,
                                @PERMIT_TYPE,
                                @REFERRAL_AGENCY,
                                @APPROVED,
                                @COMMENT_,
                                @WORKFLOW_DATE,
                                @TT_RECORD
                           )");

                        sql.AddParameter("@PERMITNUM", g(bp, i, "APPLICATION_NUMBER"));
                        sql.AddParameter("@PERMIT_TYPE", g(bp, i, "PERMIT_TYPE"));
                       
                        for (int R = 0; R < Referral.Length; R++)
                        {
                            var approve = "";
                            var workflowdate = "";

                            if (Referral[R] == "APPROVED" && g(ReferralTable, rf, "APPROVED") == "-1")
                            {
                                approve = "Yes";
                            }
                            else if (Referral[R] == "APPROVED" && g(ReferralTable, rf, "APPROVED") == "0")
                            {
                                approve = "No";
                            }
                            if (Referral[R] == "WORKFLOW_DATE" && g(ReferralTable, rf, "DATE_APPROVED") == null || g(ReferralTable, rf, "DATE_APPROVED") == "")
                            {
                                workflowdate = g(ReferralTable, rf, "DATE_SENT");
                            }
                            else if (Referral[R] == "WORKFLOW_DATE" && g(ReferralTable, rf, "DATE_APPROVED") != null || g(ReferralTable, rf, "DATE_APPROVED") != "")
                            {
                                workflowdate = g(ReferralTable, rf, "DATE_APPROVED");
                            }

                          
                            if (Referral[R] == "APPROVED")
                            {
                                sql.AddParameter("@" + Referral[R], approve);
                            }
                            else if (Referral[R] == "WORKFLOW_DATE")
                            {
                                sql.AddParameter("@" + Referral[R], workflowdate);
                            }
                            else
                            {
                                sql.AddParameter("@" + Referral[R], g(ReferralTable, rf, Referral[R]));
                            }
                        //C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\Backup\TON20210112.bak
                        }

                        string[] ADU = new string[] {
                        "A2019-00318",
                        "P2010-00020",
                        "A2010-00851",
                        "P2010-00722",
                        "P2010-00961",
                        "P2010-00547",
                        "P2010-00548",
                        "A2010-00813",
                        "P2010-00831",
                        "P2010-00934",
                        "P2010-00534",
                        "P2010-00282",
                        "P2010-00261",
                        "P2010-00944",
                        "P2010-00723",
                        "P2011-00478",
                        "P2011-00479",
                        "P2011-00561",
                        "P2019-00036",
                        "P2018-00040",
                        "P2018-00224",
                        "P2019-00493",
                        "P2017-00517",
                        "P2017-00561",
                        "P2018-00037",
                        "P2019-00396",
                        "P2019-00121",
                        "P2016-00292",
                        "P2016-00133",
                        "A2016-00118",
                        "P2016-00173",
                        "P2016-00069",
                        "P2015-00763",
                        "P2016-00068",
                        "P2015-00959",
                        "A2020-00005",
                        "P2018-00235",
                        "P2016-00335",
                        "P2016-00353",
                        "P2019-00035",
                        "P2019-00420",
                        "P2013-00308",
                        "P2013-00213",
                        "P2013-00300",
                        "P2013-00893",
                        "A2013-00900",
                        "P2014-00302",
                        "P2017-00615",
                        "P2012-00055",
                        "P2015-00961",
                        "P2011-00672",
                        "P2011-00497",
                        "P2012-00392",
                        "P2012-00579",
                        "P2012-00381",
                        "P2012-00738",
                        "P2012-00576",
                        "P2013-00765",
                        "P2013-00762",
                        "P2013-00767",
                        "P2013-00048",
                        "P2013-00860",
                        "P2014-00136",
                        "P2014-00361",
                        "P2014-00583",
                        "A2014-00674",
                        "P2015-00422",
                        "P2015-00790",
                        "P2015-00479",
                        "P2015-00792",
                        "P2015-00685",
                        "P2015-00672",
                        "P2015-00347",
                        "P2015-00601",
                        "P2015-00736",
                        "P2015-00644",
                        "P2015-00610",
                        "P2016-00222",
                        "P2016-00247",
                        "P2017-00264",
                        "P2017-00076",
                        "P2014-00359",
                        "P2017-00826",
                        "P2019-00267",
                        "P2019-00527",
                        "P2019-00328",
                        "P2013-00798",
                        "P2013-00662",
                        "P2013-00314",
                        "P2014-00584",
                        "P2014-00363",
                        "P2018-00301",
                        "P2018-00002",
                        "P2018-00661",
                        "P2019-00324",
                        "P2018-00699",
                        "P2018-00688",
                        "P2018-00284",
                        "P2019-00426",
                        "P2019-00293",
                        "P2018-00373",
                        "P2019-00321",
                        "P2019-00064",
                        "A2019-00501",
                        "P2019-00246",
                        "P2019-00483",
                        "P2015-00830",
                        "P2015-00461",
                        "P2015-00842",
                        "P2013-00872",
                        "P2015-00891",
                        "P2018-00271",
                        "P2019-00270",
                        "P2019-00232",
                        "P2011-00507",
                        "P2011-00584",
                        "P2017-00673",
                        "P2011-00416",
                        "P2013-00117",
                        "P2015-00512",
                        "P2013-00663",
                        "A2018-00712",
                        "P2014-00069",
                        "P2014-00362",
                        "P2014-00026",
                        "P2013-00626",
                        "P2013-00620",
                        "P2013-00610",
                        "P2014-00030",
                        "P2012-00325",
                        "P2018-00601",
                        "P2014-00077",
                        "P2015-00511",
                        "P2017-00874",
                        "A2019-00535",
                        "A2017-00672",
                        "P2016-00228",
                        "P2016-00063",
                        "P2013-00745",
                        "P2015-00421",
                        "P2019-00424",
                        "P2011-00603",
                        "P2011-00095",
                        "P2011-00834",
                        "P2011-01102",
                        "P2011-00081",
                        "A2011-00193",
                        "P2011-00299",
                        "P2011-00715",
                        "P2011-00836",
                        "A2011-00744",
                        "P2012-00170",
                        "P2012-00042",
                        "P2012-00087",
                        "P2012-00109",
                        "P2014-00354",
                        "P2014-00337",
                        "P2014-00143",
                        "P2019-00212",
                        "P2011-00004",
                        "P2011-01173",
                        "P2019-00325",
                        "P2013-00147",
                        "P2012-00313",
                        "P2019-00194",
                        "P2014-00179",
                        "P2014-00243",
                        "P2016-00240",
                        "A2019-00333",
                        "P2016-00003",
                        "P2012-00316",
                        "P2016-00057",
                        "P2019-00488",
                        "P2015-00710",
                        "P2014-00241",
                        "P2015-00709",
                        "P2017-00675",
                        "P2017-00816",
                        "P2018-00551",
                        "P2015-00907",
                        "P2013-00028",
                        "P2015-00864",
                        "P2016-00242",
                        "P2016-00006",
                        "P2019-00011",
                        "P2016-00105",
                        "P2019-00144",
                        "P2016-00215",
                        "P2014-00194",
                        "P2014-00635",
                        "P2018-00292",
                        "P2014-00608",
                        "P2011-00691",
                        "A2016-00339",
                        "P2013-00141",
                        "P2015-00888",
                        "P2016-00546",
                        "P2016-00551",
                        "P2016-00114",
                        "P2016-00115",
                        "P2016-00360",
                        "P2013-00134",
                        "P2014-00540",
                        "P2012-00631",
                        "P2012-00079",
                        "P2012-00186",
                        "P2017-00597",
                        "P2013-00575",
                        "P2012-00289",
                        "A2013-00562",
                        "P2012-00253",
                        "A2017-00752",
                        "P2015-00537",
                        "P2016-00107",
                        "P2018-00584",
                        "P2016-00220",
                        "P2016-00163",
                        "A2020-00003",
                        "P2016-00517",
                        "P2016-00552",
                        "P2015-00455",
                        "P2018-00003",
                        "P2016-00564",
                        "P2015-00714",
                        "A2014-00257",
                        "P2018-00028",
                        "P2016-00446",
                        "P2018-00055",
                        "P2019-00012",
                        "P2014-00607",
                        "P2016-00537",
                        "P2018-00245",
                        "P2016-00570",
                        "P2018-00560",
                        "P2019-00540",
                        "P2017-00098",
                        "A2017-00841",
                        "P2019-00120",
                        "A2017-00084",
                        "P2015-00924",
                        "P2016-00392",
                        "P2018-00729",
                        "P2018-00007",
                        "P2019-00541",
                        "A2019-00394",
                        "A2018-00730",
                        "A2018-00202",
                        "P2016-00036",
                        "P2016-00058",
                        "P2014-00203",
                        "P2016-00438",
                        "P2014-00617",
                        "P2015-00952",
                        "P2014-00631",
                        "A2017-00589",
                        "P2014-00614",
                        "P2016-00338",
                        "P2014-00622",
                        "P2016-00545",
                        "P2018-00383",
                        "P2014-00250",
                        "P2015-00879",
                        "P2019-00506",
                        "P2019-00380",
                        "P2019-00066",
                        "A2019-00059",
                        "P2019-00114",
                        "P2019-00391",
                        "P2016-00064",
                        "A2019-00086",
                        "P2019-00448",
                        "P2019-00235",
                        "P2018-00690",
                        "P2011-00399",
                        "P2016-00044",
                        "P2013-00869",
                        "P2015-00973",
                        "P2014-00364",
                        "P2014-00118",
                        "P2012-00301",
                        "P2014-00594",
                        "P2015-00897",
                        "P2015-00110",
                        "P2014-00391",
                        "P2014-00120",
                        "P2012-00278",
                        "P2011-01058",
                        "P2012-00177",
                        "P2015-00847",
                        "A2019-00178",
                        "A2014-00170",
                        "P2013-00148",
                        "P2015-00102",
                        "P2019-00333"
                    };

                        //sql.AddParameter("@TT_RECORD", "");
                        var converttoint = false;
                        if (g(bp, i, "APPLICATION_NUMBER") == "A2020-00059")
                        {

                        }
                        if (g(bp, i, "APPLICATION_NUMBER") == "560" || g(bp, i, "APPLICATION_NUMBER") == "A0-26627" || g(bp, i, "APPLICATION_NUMBER") == "A0-26628" || g(bp, i, "APPLICATION_NUMBER") == "P012-10114")
                        {
                            //Console.WriteLine("line 544 permit number is " + bp);
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER") == "S0-0" || g(bp, i, "APPLICATION_NUMBER") == "B10-0")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }

                        else
                        {
                            var temp3 = g(bp, i, "APPLICATION_NUMBER").ToString();
                            //var temp2 = g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1);

                            if (g(bp, i, "APPLICATION_NUMBER").Length > 0)
                                converttoint = Int32.TryParse(g(bp, i, "APPLICATION_NUMBER").Substring(1, 4), out int result);


                            if (converttoint)
                            {
                                if (Int32.Parse(g(bp, i, "APPLICATION_NUMBER").Substring(1, 4)) <= 2009)
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else
                                {
                                    if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2199")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Historic");
                                    }
                                    else if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2200")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Historic");
                                    }
                                    else if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3199")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Historic");
                                    }
                                    else if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3200")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Historic");
                                    }
                                    else if (g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1) == "A")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Alternative Solution");
                                    }
                                    else if (g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1) == "P")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Partial Permit");
                                    }
                                    else if (g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1) == "C")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Conditional Permit");
                                    }
                                    else if (ADU.Contains(g(bp, i, "APPLICATION_NUMBER").ToString()))
                                    {
                                        sql.AddParameter("@TT_RECORD", "Accessory Dwelling Unit");
                                    }
                                    else if (g(bp, i, "APPLICATION_Type") == "01")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Building Permit - New");
                                    }
                                    else if (g(bp, i, "FLAG_ALTREP") == "1")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Altration");
                                    }
                                    else if (g(bp, i, "FLAG_DEMO") == "1")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Demolision");
                                    }
                                    else if (g(bp, i, "BUILDINGCLASSFICATION") == "0014")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Deck");
                                    }
                                    else if (g(bp, i, "FLAG_ADDITIONAL") == "1")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Addition");
                                    }
                                    else if (g(bp, i, "APPLICATION_Type") == "06")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Mechanical");
                                    }
                                    else if (g(bp, i, "BUILDINGCLASSFICATION") == "0012")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Solar Panel");
                                    }
                                    else if (g(bp, i, "BUILDINGCLASSFICATION") == "0016")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Temporary");
                                    }
                                    else if (g(bp, i, "BUILDINGCLASSFICATION") == "0017")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Change Of Use");
                                    }
                                    else if (g(bp, i, "PERMIT_TYPE") == "S" || g(bp, i, "PERMIT_TYPE") == "s")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Signs");
                                    }
                                    else if (g(bp, i, "PERMIT_TYPE") == "P" || g(bp, i, "PERMIT_TYPE") == "p")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Pool");
                                    }
                                    else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "PP2020-10200")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Pool");
                                    }
                                    else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "SP2020-10198")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Pool");
                                    }
                                    else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "1997-11352")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Pool");
                                    }
                                    else if (g(bp, i, "APPLICATION_TYPE") == "15")
                                    {
                                        if (g(bp, i, "CONSTRUCTION_TYPE") == "101")
                                        {
                                            sql.AddParameter("@TT_RECORD", "Building Permit - New");
                                        }
                                        else if (g(bp, i, "CONSTRUCTION_TYPE") == "116")
                                        {
                                            sql.AddParameter("@TT_RECORD", "Addition");
                                        }
                                        else if (g(bp, i, "CONSTRUCTION_TYPE") == "117")
                                        {
                                            sql.AddParameter("@TT_RECORD", "Addition");
                                        }
                                        else
                                        {
                                            sql.AddParameter("@TT_RECORD", "");
                                        }

                                    }
                                    else if (g(bp, i, "APPLICATION_TYPE") == "02")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Addition");
                                    }
                                    else if (g(bp, i, "APPLICATION_TYPE") == "02")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Altration");
                                    }
                                    else if (g(bp, i, "APPLICATION_TYPE") == "11")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Change Of Use");
                                    }
                                    else if (g(bp, i, "APPLICATION_TYPE") == "111")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Signs");
                                    }
                                    else if (g(bp, i, "APPLICATION_TYPE") == "12")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Building Permit - New");
                                    }
                                    else if (g(bp, i, "APPLICATION_TYPE") == "999")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Demolision");
                                    }
                                    else
                                    {
                                        sql.AddParameter("@TT_RECORD", "");
                                    }
                                }
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2199")
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2200")
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3199")
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3200")
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "60")
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "990-")
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "A200")
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "D200")
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "G199")
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "P200")
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "PP2020-10200")
                            {
                                sql.AddParameter("@TT_RECORD", "Pool");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "SP2020-10198")
                            {
                                sql.AddParameter("@TT_RECORD", "Pool");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "1997-11352")
                            {
                                sql.AddParameter("@TT_RECORD", "Pool");
                            }
                            else
                            {
                                sql.AddParameter("@TT_RECORD", "");
                            }

                        }
                        if (g(bp, i, "APPLICATION_NUMBER") != "" && g(bp, i, "APPLICATION_NUMBER") != "A2020-11354" && g(bp, i, "APPLICATION_NUMBER") != "A2020-20394"
                        && g(bp, i, "APPLICATION_NUMBER") != "A2020-11479" && g(bp, i, "APPLICATION_NUMBER") != "A2020-11493" && g(bp, i, "APPLICATION_NUMBER") != "P2019-99999"
                        && g(bp, i, "APPLICATION_NUMBER") != "A2020-11484" && g(bp, i, "APPLICATION_NUMBER") != "A2020-00775" && g(bp, i, "APPLICATION_NUMBER") != "A2020-11111"
                        && g(bp, i, "APPLICATION_NUMBER") != "A2021-11016" && g(bp, i, "APPLICATION_NUMBER") != "A2020-00350")
                        {
                            sql.Run();

                        }
                    }
                   
                }

            }
            //ASI_ON_NEWHOME
            if (PermitOntarioNewHome)
            {
                string[] ON_NewHome = { "PERMIT_TYPE", "ONWPACT_PERMIT", "ONHWPACT_REGNUM", "ONHWPACT_CONSt" };

                for(int i = 0; i < bp.Rows.Count; i++)
                {
                    SQL sql = new SQL(@"
                        use accelastage;
                        insert into ASI_ON_NEWHOME
                        (
                            PERMITNUM,
                            PERMIT_TYPE,
                            ONWPACT_PERMIT,
                            ONHWPACT_REGNUM,
                            ONHWPACT_CONSt,
                            TT_RECORD
                        )
                        values 
                       (
                            @PERMITNUM,
                            @PERMIT_TYPE,
                            @ONWPACT_PERMIT,
                            @ONHWPACT_REGNUM,
                            @ONHWPACT_CONSt,
                            @TT_RECORD
                       )");

                    sql.AddParameter("@PERMITNUM", g(bp, i, "APPLICATION_NUMBER"));
                  
                    for (int H = 0; H < ON_NewHome.Length; H++)
                    {
                        sql.AddParameter("@" + ON_NewHome[H], g(bp, i, ON_NewHome[H]));
                    }


                    string[] ADU = new string[] {
                        "A2019-00318",
                        "P2010-00020",
                        "A2010-00851",
                        "P2010-00722",
                        "P2010-00961",
                        "P2010-00547",
                        "P2010-00548",
                        "A2010-00813",
                        "P2010-00831",
                        "P2010-00934",
                        "P2010-00534",
                        "P2010-00282",
                        "P2010-00261",
                        "P2010-00944",
                        "P2010-00723",
                        "P2011-00478",
                        "P2011-00479",
                        "P2011-00561",
                        "P2019-00036",
                        "P2018-00040",
                        "P2018-00224",
                        "P2019-00493",
                        "P2017-00517",
                        "P2017-00561",
                        "P2018-00037",
                        "P2019-00396",
                        "P2019-00121",
                        "P2016-00292",
                        "P2016-00133",
                        "A2016-00118",
                        "P2016-00173",
                        "P2016-00069",
                        "P2015-00763",
                        "P2016-00068",
                        "P2015-00959",
                        "A2020-00005",
                        "P2018-00235",
                        "P2016-00335",
                        "P2016-00353",
                        "P2019-00035",
                        "P2019-00420",
                        "P2013-00308",
                        "P2013-00213",
                        "P2013-00300",
                        "P2013-00893",
                        "A2013-00900",
                        "P2014-00302",
                        "P2017-00615",
                        "P2012-00055",
                        "P2015-00961",
                        "P2011-00672",
                        "P2011-00497",
                        "P2012-00392",
                        "P2012-00579",
                        "P2012-00381",
                        "P2012-00738",
                        "P2012-00576",
                        "P2013-00765",
                        "P2013-00762",
                        "P2013-00767",
                        "P2013-00048",
                        "P2013-00860",
                        "P2014-00136",
                        "P2014-00361",
                        "P2014-00583",
                        "A2014-00674",
                        "P2015-00422",
                        "P2015-00790",
                        "P2015-00479",
                        "P2015-00792",
                        "P2015-00685",
                        "P2015-00672",
                        "P2015-00347",
                        "P2015-00601",
                        "P2015-00736",
                        "P2015-00644",
                        "P2015-00610",
                        "P2016-00222",
                        "P2016-00247",
                        "P2017-00264",
                        "P2017-00076",
                        "P2014-00359",
                        "P2017-00826",
                        "P2019-00267",
                        "P2019-00527",
                        "P2019-00328",
                        "P2013-00798",
                        "P2013-00662",
                        "P2013-00314",
                        "P2014-00584",
                        "P2014-00363",
                        "P2018-00301",
                        "P2018-00002",
                        "P2018-00661",
                        "P2019-00324",
                        "P2018-00699",
                        "P2018-00688",
                        "P2018-00284",
                        "P2019-00426",
                        "P2019-00293",
                        "P2018-00373",
                        "P2019-00321",
                        "P2019-00064",
                        "A2019-00501",
                        "P2019-00246",
                        "P2019-00483",
                        "P2015-00830",
                        "P2015-00461",
                        "P2015-00842",
                        "P2013-00872",
                        "P2015-00891",
                        "P2018-00271",
                        "P2019-00270",
                        "P2019-00232",
                        "P2011-00507",
                        "P2011-00584",
                        "P2017-00673",
                        "P2011-00416",
                        "P2013-00117",
                        "P2015-00512",
                        "P2013-00663",
                        "A2018-00712",
                        "P2014-00069",
                        "P2014-00362",
                        "P2014-00026",
                        "P2013-00626",
                        "P2013-00620",
                        "P2013-00610",
                        "P2014-00030",
                        "P2012-00325",
                        "P2018-00601",
                        "P2014-00077",
                        "P2015-00511",
                        "P2017-00874",
                        "A2019-00535",
                        "A2017-00672",
                        "P2016-00228",
                        "P2016-00063",
                        "P2013-00745",
                        "P2015-00421",
                        "P2019-00424",
                        "P2011-00603",
                        "P2011-00095",
                        "P2011-00834",
                        "P2011-01102",
                        "P2011-00081",
                        "A2011-00193",
                        "P2011-00299",
                        "P2011-00715",
                        "P2011-00836",
                        "A2011-00744",
                        "P2012-00170",
                        "P2012-00042",
                        "P2012-00087",
                        "P2012-00109",
                        "P2014-00354",
                        "P2014-00337",
                        "P2014-00143",
                        "P2019-00212",
                        "P2011-00004",
                        "P2011-01173",
                        "P2019-00325",
                        "P2013-00147",
                        "P2012-00313",
                        "P2019-00194",
                        "P2014-00179",
                        "P2014-00243",
                        "P2016-00240",
                        "A2019-00333",
                        "P2016-00003",
                        "P2012-00316",
                        "P2016-00057",
                        "P2019-00488",
                        "P2015-00710",
                        "P2014-00241",
                        "P2015-00709",
                        "P2017-00675",
                        "P2017-00816",
                        "P2018-00551",
                        "P2015-00907",
                        "P2013-00028",
                        "P2015-00864",
                        "P2016-00242",
                        "P2016-00006",
                        "P2019-00011",
                        "P2016-00105",
                        "P2019-00144",
                        "P2016-00215",
                        "P2014-00194",
                        "P2014-00635",
                        "P2018-00292",
                        "P2014-00608",
                        "P2011-00691",
                        "A2016-00339",
                        "P2013-00141",
                        "P2015-00888",
                        "P2016-00546",
                        "P2016-00551",
                        "P2016-00114",
                        "P2016-00115",
                        "P2016-00360",
                        "P2013-00134",
                        "P2014-00540",
                        "P2012-00631",
                        "P2012-00079",
                        "P2012-00186",
                        "P2017-00597",
                        "P2013-00575",
                        "P2012-00289",
                        "A2013-00562",
                        "P2012-00253",
                        "A2017-00752",
                        "P2015-00537",
                        "P2016-00107",
                        "P2018-00584",
                        "P2016-00220",
                        "P2016-00163",
                        "A2020-00003",
                        "P2016-00517",
                        "P2016-00552",
                        "P2015-00455",
                        "P2018-00003",
                        "P2016-00564",
                        "P2015-00714",
                        "A2014-00257",
                        "P2018-00028",
                        "P2016-00446",
                        "P2018-00055",
                        "P2019-00012",
                        "P2014-00607",
                        "P2016-00537",
                        "P2018-00245",
                        "P2016-00570",
                        "P2018-00560",
                        "P2019-00540",
                        "P2017-00098",
                        "A2017-00841",
                        "P2019-00120",
                        "A2017-00084",
                        "P2015-00924",
                        "P2016-00392",
                        "P2018-00729",
                        "P2018-00007",
                        "P2019-00541",
                        "A2019-00394",
                        "A2018-00730",
                        "A2018-00202",
                        "P2016-00036",
                        "P2016-00058",
                        "P2014-00203",
                        "P2016-00438",
                        "P2014-00617",
                        "P2015-00952",
                        "P2014-00631",
                        "A2017-00589",
                        "P2014-00614",
                        "P2016-00338",
                        "P2014-00622",
                        "P2016-00545",
                        "P2018-00383",
                        "P2014-00250",
                        "P2015-00879",
                        "P2019-00506",
                        "P2019-00380",
                        "P2019-00066",
                        "A2019-00059",
                        "P2019-00114",
                        "P2019-00391",
                        "P2016-00064",
                        "A2019-00086",
                        "P2019-00448",
                        "P2019-00235",
                        "P2018-00690",
                        "P2011-00399",
                        "P2016-00044",
                        "P2013-00869",
                        "P2015-00973",
                        "P2014-00364",
                        "P2014-00118",
                        "P2012-00301",
                        "P2014-00594",
                        "P2015-00897",
                        "P2015-00110",
                        "P2014-00391",
                        "P2014-00120",
                        "P2012-00278",
                        "P2011-01058",
                        "P2012-00177",
                        "P2015-00847",
                        "A2019-00178",
                        "A2014-00170",
                        "P2013-00148",
                        "P2015-00102",
                        "P2019-00333"
                    };

                    //sql.AddParameter("@TT_RECORD", "");
                    var converttoint = false;
                    if (g(bp, i, "APPLICATION_NUMBER") == "A2020-00059")
                    {

                    }
                    if (g(bp, i, "APPLICATION_NUMBER") == "560" || g(bp, i, "APPLICATION_NUMBER") == "A0-26627" || g(bp, i, "APPLICATION_NUMBER") == "A0-26628" || g(bp, i, "APPLICATION_NUMBER") == "P012-10114")
                    {
                        //Console.WriteLine("line 544 permit number is " + bp);
                        sql.AddParameter("@TT_RECORD", "Historic");
                    }
                    else if (g(bp, i, "APPLICATION_NUMBER") == "S0-0" || g(bp, i, "APPLICATION_NUMBER") == "B10-0")
                    {
                        sql.AddParameter("@TT_RECORD", "Historic");
                    }

                    else
                    {
                        var temp3 = g(bp, i, "APPLICATION_NUMBER").ToString();
                        //var temp2 = g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1);
                       
                        if (g(bp, i, "APPLICATION_NUMBER").Length > 0)
                            converttoint = Int32.TryParse(g(bp, i, "APPLICATION_NUMBER").Substring(1, 4), out int result);


                        if (converttoint)
                        {
                            if (Int32.Parse(g(bp, i, "APPLICATION_NUMBER").Substring(1, 4)) <= 2009)
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else
                            {
                                if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2199")
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2200")
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3199")
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3200")
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1) == "A")
                                {
                                    sql.AddParameter("@TT_RECORD", "Alternative Solution");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1) == "P")
                                {
                                    sql.AddParameter("@TT_RECORD", "Partial Permit");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1) == "C")
                                {
                                    sql.AddParameter("@TT_RECORD", "Conditional Permit");
                                }
                                else if (ADU.Contains(g(bp, i, "APPLICATION_NUMBER").ToString()))
                                {
                                    sql.AddParameter("@TT_RECORD", "Accessory Dwelling Unit");
                                }
                                else if (g(bp, i, "APPLICATION_Type") == "01")
                                {
                                    sql.AddParameter("@TT_RECORD", "Building Permit - New");
                                }
                                else if (g(bp, i, "FLAG_ALTREP") == "1")
                                {
                                    sql.AddParameter("@TT_RECORD", "Altration");
                                }
                                else if (g(bp, i, "FLAG_DEMO") == "1")
                                {
                                    sql.AddParameter("@TT_RECORD", "Demolision");
                                }
                                else if (g(bp, i, "BUILDINGCLASSFICATION") == "0014")
                                {
                                    sql.AddParameter("@TT_RECORD", "Deck");
                                }
                                else if (g(bp, i, "FLAG_ADDITIONAL") == "1")
                                {
                                    sql.AddParameter("@TT_RECORD", "Addition");
                                }
                                else if (g(bp, i, "APPLICATION_Type") == "06")
                                {
                                    sql.AddParameter("@TT_RECORD", "Mechanical");
                                }
                                else if (g(bp, i, "BUILDINGCLASSFICATION") == "0012")
                                {
                                    sql.AddParameter("@TT_RECORD", "Solar Panel");
                                }
                                else if (g(bp, i, "BUILDINGCLASSFICATION") == "0016")
                                {
                                    sql.AddParameter("@TT_RECORD", "Temporary");
                                }
                                else if (g(bp, i, "BUILDINGCLASSFICATION") == "0017")
                                {
                                    sql.AddParameter("@TT_RECORD", "Change Of Use");
                                }
                                else if (g(bp, i, "PERMIT_TYPE") == "S" || g(bp, i, "PERMIT_TYPE") == "s")
                                {
                                    sql.AddParameter("@TT_RECORD", "Signs");
                                }
                                else if (g(bp, i, "PERMIT_TYPE") == "P" || g(bp, i, "PERMIT_TYPE") == "p")
                                {
                                    sql.AddParameter("@TT_RECORD", "Pool");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "PP2020-10200")
                                {
                                    sql.AddParameter("@TT_RECORD", "Pool");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "SP2020-10198")
                                {
                                    sql.AddParameter("@TT_RECORD", "Pool");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "1997-11352")
                                {
                                    sql.AddParameter("@TT_RECORD", "Pool");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "15")
                                {
                                    if (g(bp, i, "CONSTRUCTION_TYPE") == "101")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Building Permit - New");
                                    }
                                    else if (g(bp, i, "CONSTRUCTION_TYPE") == "116")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Addition");
                                    }
                                    else if (g(bp, i, "CONSTRUCTION_TYPE") == "117")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Addition");
                                    }
                                    else
                                    {
                                        sql.AddParameter("@TT_RECORD", "");
                                    }

                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "02")
                                {
                                    sql.AddParameter("@TT_RECORD", "Addition");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "02")
                                {
                                    sql.AddParameter("@TT_RECORD", "Altration");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "11")
                                {
                                    sql.AddParameter("@TT_RECORD", "Change Of Use");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "111")
                                {
                                    sql.AddParameter("@TT_RECORD", "Signs");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "12")
                                {
                                    sql.AddParameter("@TT_RECORD", "Building Permit - New");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "999")
                                {
                                    sql.AddParameter("@TT_RECORD", "Demolision");
                                }
                                else
                                {
                                    sql.AddParameter("@TT_RECORD", "");
                                }
                            }
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2199")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3199")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "60")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "990-")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "A200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "D200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "G199")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "P200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "PP2020-10200")
                        {
                            sql.AddParameter("@TT_RECORD", "Pool");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "SP2020-10198")
                        {
                            sql.AddParameter("@TT_RECORD", "Pool");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "1997-11352")
                        {
                            sql.AddParameter("@TT_RECORD", "Pool");
                        }
                        else
                        {
                            sql.AddParameter("@TT_RECORD", "");
                        }

                    }

                    if (g(bp, i, "APPLICATION_NUMBER") != "" && g(bp, i, "APPLICATION_NUMBER") != "A2020-11354" && g(bp, i, "APPLICATION_NUMBER") != "A2020-20394"
                        && g(bp, i, "APPLICATION_NUMBER") != "A2020-11479" && g(bp, i, "APPLICATION_NUMBER") != "A2020-11493" && g(bp, i, "APPLICATION_NUMBER") != "P2019-99999"
                        && g(bp, i, "APPLICATION_NUMBER") != "A2020-11484" && g(bp, i, "APPLICATION_NUMBER") != "A2020-00775" && g(bp, i, "APPLICATION_NUMBER") != "A2020-11111"
                        && g(bp, i, "APPLICATION_NUMBER") != "A2021-11016" && g(bp, i, "APPLICATION_NUMBER") != "A2020-00350")
                    {
                        sql.Run();

                    } 
                }
            }


            //ASI_PurposeofApplication
            if (PermitPurposeofApplication)
            {
                string[] Purpose_of_Application = { "PERMIT_TYPE", "DESCRIPTION", "PARTIAL", "FLAG_CONDPER","FLAG_DEMO","FLAG_ALTREP",
                    "FLAG_CONST", "FLAG_ADDITIONAL", "APPLICATION_TYPE", "CONSTRUCTION_TYPE", "INSPECTOR", "Examiner", "MODEL",
                     "OTHER_LOC_INFO", "BuildingClassfication", "TonConType", "STATSCANCODE", "CurrentUse" };
                for (int i = 0; i < bp.Rows.Count; i++)
                {

                    SQL sql = new SQL(@"
                        use accelastage;
                        insert into ASI_PurposeofApplication
                        (
                            PERMITNUM,
                            PERMIT_TYPE, 
                            DESCRIPTION, 
                            PARTIAL, 
                            FLAG_CONDPER,
                            FLAG_DEMO,
                            FLAG_ALTREP,
                            FLAG_CONST, 
                            FLAG_ADDITIONAL, 
                            APPLICATION_TYPE, 
                            CONSTRUCTION_TYPE, 
                            INSPECTOR, 
                            Examiner, 
                            MODEL,
                            ADDITION_INFO, 
                            OTHER_LOC_INFO, 
                            BuildingClassfication, 
                            TonConType, 
                            STATSCANCODE, 
                            CurrentUse,
                            TT_RECORD
                        )
                        values 
                       (
                            @PERMITNUM,
                            @PERMIT_TYPE, 
                            @DESCRIPTION, 
                            @PARTIAL, 
                            @FLAG_CONDPER,
                            @FLAG_DEMO,
                            @FLAG_ALTREP,
                            @FLAG_CONST, 
                            @FLAG_ADDITIONAL, 
                            @APPLICATION_TYPE, 
                            @CONSTRUCTION_TYPE, 
                            @INSPECTOR, 
                            @Examiner, 
                            @MODEL,
                            @ADDITION_INFO, 
                            @OTHER_LOC_INFO, 
                            @BuildingClassfication, 
                            @TonConType, 
                            @STATSCANCODE, 
                            @CurrentUse,
                            @TT_RECORD
                       )");

                    sql.AddParameter("@PERMITNUM", g(bp, i, "APPLICATION_NUMBER"));
                    //Console.WriteLine("@PERMITNUM = " + i.ToString().Length + "= Length =" + g(bp, i, "APPLICATION_NUMBER"));
                    for (int PA = 0; PA < Purpose_of_Application.Length; PA++)
                    {
                        
                            sql.AddParameter("@" + Purpose_of_Application[PA], g(bp, i, Purpose_of_Application[PA]));
                        ////Purpose_of_Application[PA] != "@DESCRIPTION" && Purpose_of_Application[PA] != "@ADDITION_INFO" &&Purpose_of_Application[PA] != "@OTHER_LOC_INFO" &&
                        //if (g(bp, i, Purpose_of_Application[PA]).Length > 255)
                        //    Console.WriteLine("@" + Purpose_of_Application[PA] + " = Length =" + g(bp, i, Purpose_of_Application[PA]).Length + " =" + g(bp, i, Purpose_of_Application[PA]) + " = RECORNUM =" + i + "</br>");



                    }
                    temp = CityView.Run("select addition_info from sysadmin.bp_additional where bi_app_id = @ID", g(bp, i, "recordid"));

                    if (temp.Rows.Count > 0)
                        sql.AddParameter("@ADDITION_INFO", g(temp, 0, "addition_info", 255));
                    else
                        sql.AddParameter("@ADDITION_INFO", DBNull.Value);

                    string[] ADU = new string[] {
                        "A2019-00318",
                        "P2010-00020",
                        "A2010-00851",
                        "P2010-00722",
                        "P2010-00961",
                        "P2010-00547",
                        "P2010-00548",
                        "A2010-00813",
                        "P2010-00831",
                        "P2010-00934",
                        "P2010-00534",
                        "P2010-00282",
                        "P2010-00261",
                        "P2010-00944",
                        "P2010-00723",
                        "P2011-00478",
                        "P2011-00479",
                        "P2011-00561",
                        "P2019-00036",
                        "P2018-00040",
                        "P2018-00224",
                        "P2019-00493",
                        "P2017-00517",
                        "P2017-00561",
                        "P2018-00037",
                        "P2019-00396",
                        "P2019-00121",
                        "P2016-00292",
                        "P2016-00133",
                        "A2016-00118",
                        "P2016-00173",
                        "P2016-00069",
                        "P2015-00763",
                        "P2016-00068",
                        "P2015-00959",
                        "A2020-00005",
                        "P2018-00235",
                        "P2016-00335",
                        "P2016-00353",
                        "P2019-00035",
                        "P2019-00420",
                        "P2013-00308",
                        "P2013-00213",
                        "P2013-00300",
                        "P2013-00893",
                        "A2013-00900",
                        "P2014-00302",
                        "P2017-00615",
                        "P2012-00055",
                        "P2015-00961",
                        "P2011-00672",
                        "P2011-00497",
                        "P2012-00392",
                        "P2012-00579",
                        "P2012-00381",
                        "P2012-00738",
                        "P2012-00576",
                        "P2013-00765",
                        "P2013-00762",
                        "P2013-00767",
                        "P2013-00048",
                        "P2013-00860",
                        "P2014-00136",
                        "P2014-00361",
                        "P2014-00583",
                        "A2014-00674",
                        "P2015-00422",
                        "P2015-00790",
                        "P2015-00479",
                        "P2015-00792",
                        "P2015-00685",
                        "P2015-00672",
                        "P2015-00347",
                        "P2015-00601",
                        "P2015-00736",
                        "P2015-00644",
                        "P2015-00610",
                        "P2016-00222",
                        "P2016-00247",
                        "P2017-00264",
                        "P2017-00076",
                        "P2014-00359",
                        "P2017-00826",
                        "P2019-00267",
                        "P2019-00527",
                        "P2019-00328",
                        "P2013-00798",
                        "P2013-00662",
                        "P2013-00314",
                        "P2014-00584",
                        "P2014-00363",
                        "P2018-00301",
                        "P2018-00002",
                        "P2018-00661",
                        "P2019-00324",
                        "P2018-00699",
                        "P2018-00688",
                        "P2018-00284",
                        "P2019-00426",
                        "P2019-00293",
                        "P2018-00373",
                        "P2019-00321",
                        "P2019-00064",
                        "A2019-00501",
                        "P2019-00246",
                        "P2019-00483",
                        "P2015-00830",
                        "P2015-00461",
                        "P2015-00842",
                        "P2013-00872",
                        "P2015-00891",
                        "P2018-00271",
                        "P2019-00270",
                        "P2019-00232",
                        "P2011-00507",
                        "P2011-00584",
                        "P2017-00673",
                        "P2011-00416",
                        "P2013-00117",
                        "P2015-00512",
                        "P2013-00663",
                        "A2018-00712",
                        "P2014-00069",
                        "P2014-00362",
                        "P2014-00026",
                        "P2013-00626",
                        "P2013-00620",
                        "P2013-00610",
                        "P2014-00030",
                        "P2012-00325",
                        "P2018-00601",
                        "P2014-00077",
                        "P2015-00511",
                        "P2017-00874",
                        "A2019-00535",
                        "A2017-00672",
                        "P2016-00228",
                        "P2016-00063",
                        "P2013-00745",
                        "P2015-00421",
                        "P2019-00424",
                        "P2011-00603",
                        "P2011-00095",
                        "P2011-00834",
                        "P2011-01102",
                        "P2011-00081",
                        "A2011-00193",
                        "P2011-00299",
                        "P2011-00715",
                        "P2011-00836",
                        "A2011-00744",
                        "P2012-00170",
                        "P2012-00042",
                        "P2012-00087",
                        "P2012-00109",
                        "P2014-00354",
                        "P2014-00337",
                        "P2014-00143",
                        "P2019-00212",
                        "P2011-00004",
                        "P2011-01173",
                        "P2019-00325",
                        "P2013-00147",
                        "P2012-00313",
                        "P2019-00194",
                        "P2014-00179",
                        "P2014-00243",
                        "P2016-00240",
                        "A2019-00333",
                        "P2016-00003",
                        "P2012-00316",
                        "P2016-00057",
                        "P2019-00488",
                        "P2015-00710",
                        "P2014-00241",
                        "P2015-00709",
                        "P2017-00675",
                        "P2017-00816",
                        "P2018-00551",
                        "P2015-00907",
                        "P2013-00028",
                        "P2015-00864",
                        "P2016-00242",
                        "P2016-00006",
                        "P2019-00011",
                        "P2016-00105",
                        "P2019-00144",
                        "P2016-00215",
                        "P2014-00194",
                        "P2014-00635",
                        "P2018-00292",
                        "P2014-00608",
                        "P2011-00691",
                        "A2016-00339",
                        "P2013-00141",
                        "P2015-00888",
                        "P2016-00546",
                        "P2016-00551",
                        "P2016-00114",
                        "P2016-00115",
                        "P2016-00360",
                        "P2013-00134",
                        "P2014-00540",
                        "P2012-00631",
                        "P2012-00079",
                        "P2012-00186",
                        "P2017-00597",
                        "P2013-00575",
                        "P2012-00289",
                        "A2013-00562",
                        "P2012-00253",
                        "A2017-00752",
                        "P2015-00537",
                        "P2016-00107",
                        "P2018-00584",
                        "P2016-00220",
                        "P2016-00163",
                        "A2020-00003",
                        "P2016-00517",
                        "P2016-00552",
                        "P2015-00455",
                        "P2018-00003",
                        "P2016-00564",
                        "P2015-00714",
                        "A2014-00257",
                        "P2018-00028",
                        "P2016-00446",
                        "P2018-00055",
                        "P2019-00012",
                        "P2014-00607",
                        "P2016-00537",
                        "P2018-00245",
                        "P2016-00570",
                        "P2018-00560",
                        "P2019-00540",
                        "P2017-00098",
                        "A2017-00841",
                        "P2019-00120",
                        "A2017-00084",
                        "P2015-00924",
                        "P2016-00392",
                        "P2018-00729",
                        "P2018-00007",
                        "P2019-00541",
                        "A2019-00394",
                        "A2018-00730",
                        "A2018-00202",
                        "P2016-00036",
                        "P2016-00058",
                        "P2014-00203",
                        "P2016-00438",
                        "P2014-00617",
                        "P2015-00952",
                        "P2014-00631",
                        "A2017-00589",
                        "P2014-00614",
                        "P2016-00338",
                        "P2014-00622",
                        "P2016-00545",
                        "P2018-00383",
                        "P2014-00250",
                        "P2015-00879",
                        "P2019-00506",
                        "P2019-00380",
                        "P2019-00066",
                        "A2019-00059",
                        "P2019-00114",
                        "P2019-00391",
                        "P2016-00064",
                        "A2019-00086",
                        "P2019-00448",
                        "P2019-00235",
                        "P2018-00690",
                        "P2011-00399",
                        "P2016-00044",
                        "P2013-00869",
                        "P2015-00973",
                        "P2014-00364",
                        "P2014-00118",
                        "P2012-00301",
                        "P2014-00594",
                        "P2015-00897",
                        "P2015-00110",
                        "P2014-00391",
                        "P2014-00120",
                        "P2012-00278",
                        "P2011-01058",
                        "P2012-00177",
                        "P2015-00847",
                        "A2019-00178",
                        "A2014-00170",
                        "P2013-00148",
                        "P2015-00102",
                        "P2019-00333"
                    };

                    //sql.AddParameter("@TT_RECORD", "");
                    var converttoint = false;
                    if (g(bp, i, "APPLICATION_NUMBER") == "A2020-00059")
                    {

                    }
                    if (g(bp, i, "APPLICATION_NUMBER") == "560" || g(bp, i, "APPLICATION_NUMBER") == "A0-26627" || g(bp, i, "APPLICATION_NUMBER") == "A0-26628" || g(bp, i, "APPLICATION_NUMBER") == "P012-10114")
                    {
                        //Console.WriteLine("line 544 permit number is " + bp);
                        sql.AddParameter("@TT_RECORD", "Historic");
                    }
                    else if (g(bp, i, "APPLICATION_NUMBER") == "S0-0" || g(bp, i, "APPLICATION_NUMBER") == "B10-0")
                    {
                        sql.AddParameter("@TT_RECORD", "Historic");
                    }

                    else
                    {
                        var temp3 = g(bp, i, "APPLICATION_NUMBER").ToString();
                        //var temp2 = g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1);

                        if (g(bp, i, "APPLICATION_NUMBER").Length > 0)
                            converttoint = Int32.TryParse(g(bp, i, "APPLICATION_NUMBER").Substring(1, 4), out int result);


                        if (converttoint)
                        {
                            if (Int32.Parse(g(bp, i, "APPLICATION_NUMBER").Substring(1, 4)) <= 2009)
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else
                            {
                                if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2199")
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2200")
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3199")
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3200")
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1) == "A")
                                {
                                    sql.AddParameter("@TT_RECORD", "Alternative Solution");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1) == "P")
                                {
                                    sql.AddParameter("@TT_RECORD", "Partial Permit");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1) == "C")
                                {
                                    sql.AddParameter("@TT_RECORD", "Conditional Permit");
                                }
                                else if (ADU.Contains(g(bp, i, "APPLICATION_NUMBER").ToString()))
                                {
                                    sql.AddParameter("@TT_RECORD", "Accessory Dwelling Unit");
                                }
                                else if (g(bp, i, "APPLICATION_Type") == "01")
                                {
                                    sql.AddParameter("@TT_RECORD", "Building Permit - New");
                                }
                                else if (g(bp, i, "FLAG_ALTREP") == "1")
                                {
                                    sql.AddParameter("@TT_RECORD", "Altration");
                                }
                                else if (g(bp, i, "FLAG_DEMO") == "1")
                                {
                                    sql.AddParameter("@TT_RECORD", "Demolision");
                                }
                                else if (g(bp, i, "BUILDINGCLASSFICATION") == "0014")
                                {
                                    sql.AddParameter("@TT_RECORD", "Deck");
                                }
                                else if (g(bp, i, "FLAG_ADDITIONAL") == "1")
                                {
                                    sql.AddParameter("@TT_RECORD", "Addition");
                                }
                                else if (g(bp, i, "APPLICATION_Type") == "06")
                                {
                                    sql.AddParameter("@TT_RECORD", "Mechanical");
                                }
                                else if (g(bp, i, "BUILDINGCLASSFICATION") == "0012")
                                {
                                    sql.AddParameter("@TT_RECORD", "Solar Panel");
                                }
                                else if (g(bp, i, "BUILDINGCLASSFICATION") == "0016")
                                {
                                    sql.AddParameter("@TT_RECORD", "Temporary");
                                }
                                else if (g(bp, i, "BUILDINGCLASSFICATION") == "0017")
                                {
                                    sql.AddParameter("@TT_RECORD", "Change Of Use");
                                }
                                else if (g(bp, i, "PERMIT_TYPE") == "S" || g(bp, i, "PERMIT_TYPE") == "s")
                                {
                                    sql.AddParameter("@TT_RECORD", "Signs");
                                }
                                else if (g(bp, i, "PERMIT_TYPE") == "P" || g(bp, i, "PERMIT_TYPE") == "p")
                                {
                                    sql.AddParameter("@TT_RECORD", "Pool");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "PP2020-10200")
                                {
                                    sql.AddParameter("@TT_RECORD", "Pool");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "SP2020-10198")
                                {
                                    sql.AddParameter("@TT_RECORD", "Pool");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "1997-11352")
                                {
                                    sql.AddParameter("@TT_RECORD", "Pool");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "15")
                                {
                                    if (g(bp, i, "CONSTRUCTION_TYPE") == "101")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Building Permit - New");
                                    }
                                    else if (g(bp, i, "CONSTRUCTION_TYPE") == "116")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Addition");
                                    }
                                    else if (g(bp, i, "CONSTRUCTION_TYPE") == "117")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Addition");
                                    }
                                    else
                                    {
                                        sql.AddParameter("@TT_RECORD", "");
                                    }

                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "02")
                                {
                                    sql.AddParameter("@TT_RECORD", "Addition");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "02")
                                {
                                    sql.AddParameter("@TT_RECORD", "Altration");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "11")
                                {
                                    sql.AddParameter("@TT_RECORD", "Change Of Use");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "111")
                                {
                                    sql.AddParameter("@TT_RECORD", "Signs");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "12")
                                {
                                    sql.AddParameter("@TT_RECORD", "Building Permit - New");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "999")
                                {
                                    sql.AddParameter("@TT_RECORD", "Demolision");
                                }
                                else
                                {
                                    sql.AddParameter("@TT_RECORD", "");
                                }
                            }
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2199")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3199")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "60")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "990-")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "A200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "D200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "G199")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "P200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "PP2020-10200")
                        {
                            sql.AddParameter("@TT_RECORD", "Pool");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "SP2020-10198")
                        {
                            sql.AddParameter("@TT_RECORD", "Pool");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "1997-11352")
                        {
                            sql.AddParameter("@TT_RECORD", "Pool");
                        }
                        else
                        {
                            sql.AddParameter("@TT_RECORD", "");
                        }

                    }
                    if (g(bp, i, "APPLICATION_NUMBER") != "" && g(bp, i, "APPLICATION_NUMBER") != "A2020-11354" && g(bp, i, "APPLICATION_NUMBER") != "A2020-20394"
                       && g(bp, i, "APPLICATION_NUMBER") != "A2020-11479" && g(bp, i, "APPLICATION_NUMBER") != "A2020-11493" && g(bp, i, "APPLICATION_NUMBER") != "P2019-99999"
                       && g(bp, i, "APPLICATION_NUMBER") != "A2020-11484" && g(bp, i, "APPLICATION_NUMBER") != "A2020-00775" && g(bp, i, "APPLICATION_NUMBER") != "A2020-11111"
                       && g(bp, i, "APPLICATION_NUMBER") != "A2021-11016" && g(bp, i, "APPLICATION_NUMBER") != "A2020-00350")
                    {
                        sql.Run();

                    }
                }


            }

            //ASI_Fixtures
            if (PermitCustomFixtures)
            {
                string[] fixtures = { "FIXTURES_NOWC", "FIXTURES_NOKITCHENSINKS", "FIXTURES_NOHOSEBIBS", "FIXTURES_NOWASHBASINS", "FIXTURES_NOLAUNDRYTUBS", "FIXTURES_NOJANITORSSINK", "FIXTURES_NOURINALS", "FIXTURES_NOBARSINKS", "FIXTURES_NOBIDETS", "FIXTURES_NOINTERCEPTORS", "FIXTURES_WATERTANKS", "FIXTURES_NOBATHTUBS", "FIXTURES_NOFLOORDRAINS", "FIXTURES_NOBSMTROUGHTIN", "FIXTURES_NOSHOWERSTALLS", "FIXTURES_NOBACKFLOW", "FIXTURES_NOOTHER" };
                //string[] fixtureLabels = { "W.C. (Toilets)", "Kitchen Sinks", "Hose Bibs", "Wash Basins", "Laundry Tubs", "Janitor/Slop Sinks", "Urinals", "Bar Sinks", "Bidets", "Interceptors", "Water Tanks/Heaters", "Bath Tubs", "Floor Drains", "Bsmt. Rough-In", "Shower Stalls", "Back Flow Prev.", "Other" };

                for (int i = 0; i < bp.Rows.Count; i++)
                {
                    SQL sql = new SQL(@"
            use accelastage;
            insert into ASI_Fixtures
            (
            PERMITNUM,
            TT_RECORD,
            FIXTURES_NOWC,
            FIXTURES_NOKITCHENSINKS,
            FIXTURES_NOHOSEBIBS,
            FIXTURES_NOWASHBASINS,
            FIXTURES_NOLAUNDRYTUBS,
            FIXTURES_NOJANITORSSINK,
            FIXTURES_NOURINALS,
            FIXTURES_NOBARSINKS,
            FIXTURES_NOBIDETS,
            FIXTURES_NOINTERCEPTORS,
            FIXTURES_WATERTANKS,
            FIXTURES_NOBATHTUBS,
            FIXTURES_NOFLOORDRAINS,
            FIXTURES_NOBSMTROUGHTIN,
            FIXTURES_NOSHOWERSTALLS,
            FIXTURES_NOBACKFLOW,
            FIXTURES_NOOTHER
            )
            values (
            @PERMITNUM,
            @TT_RECORD,
            @FIXTURES_NOWC,
            @FIXTURES_NOKITCHENSINKS,
            @FIXTURES_NOHOSEBIBS,
            @FIXTURES_NOWASHBASINS,
            @FIXTURES_NOLAUNDRYTUBS,
            @FIXTURES_NOJANITORSSINK,
            @FIXTURES_NOURINALS,
            @FIXTURES_NOBARSINKS,
            @FIXTURES_NOBIDETS,
            @FIXTURES_NOINTERCEPTORS,
            @FIXTURES_WATERTANKS,
            @FIXTURES_NOBATHTUBS,
            @FIXTURES_NOFLOORDRAINS,
            @FIXTURES_NOBSMTROUGHTIN,
            @FIXTURES_NOSHOWERSTALLS,
            @FIXTURES_NOBACKFLOW,
            @FIXTURES_NOOTHER
            )");

                    sql.AddParameter("@PERMITNUM", g(bp, i, "APPLICATION_NUMBER"));
                   
                    // Console.WriteLine("adding record line 2433");

                    for (int f = 0; f < fixtures.Length; f++)
                    {
                        sql.AddParameter("@" + fixtures[f], g(bp, i, fixtures[f]));
                    }
                    string[] ADU = new string[] {
                        "A2019-00318",
                        "P2010-00020",
                        "A2010-00851",
                        "P2010-00722",
                        "P2010-00961",
                        "P2010-00547",
                        "P2010-00548",
                        "A2010-00813",
                        "P2010-00831",
                        "P2010-00934",
                        "P2010-00534",
                        "P2010-00282",
                        "P2010-00261",
                        "P2010-00944",
                        "P2010-00723",
                        "P2011-00478",
                        "P2011-00479",
                        "P2011-00561",
                        "P2019-00036",
                        "P2018-00040",
                        "P2018-00224",
                        "P2019-00493",
                        "P2017-00517",
                        "P2017-00561",
                        "P2018-00037",
                        "P2019-00396",
                        "P2019-00121",
                        "P2016-00292",
                        "P2016-00133",
                        "A2016-00118",
                        "P2016-00173",
                        "P2016-00069",
                        "P2015-00763",
                        "P2016-00068",
                        "P2015-00959",
                        "A2020-00005",
                        "P2018-00235",
                        "P2016-00335",
                        "P2016-00353",
                        "P2019-00035",
                        "P2019-00420",
                        "P2013-00308",
                        "P2013-00213",
                        "P2013-00300",
                        "P2013-00893",
                        "A2013-00900",
                        "P2014-00302",
                        "P2017-00615",
                        "P2012-00055",
                        "P2015-00961",
                        "P2011-00672",
                        "P2011-00497",
                        "P2012-00392",
                        "P2012-00579",
                        "P2012-00381",
                        "P2012-00738",
                        "P2012-00576",
                        "P2013-00765",
                        "P2013-00762",
                        "P2013-00767",
                        "P2013-00048",
                        "P2013-00860",
                        "P2014-00136",
                        "P2014-00361",
                        "P2014-00583",
                        "A2014-00674",
                        "P2015-00422",
                        "P2015-00790",
                        "P2015-00479",
                        "P2015-00792",
                        "P2015-00685",
                        "P2015-00672",
                        "P2015-00347",
                        "P2015-00601",
                        "P2015-00736",
                        "P2015-00644",
                        "P2015-00610",
                        "P2016-00222",
                        "P2016-00247",
                        "P2017-00264",
                        "P2017-00076",
                        "P2014-00359",
                        "P2017-00826",
                        "P2019-00267",
                        "P2019-00527",
                        "P2019-00328",
                        "P2013-00798",
                        "P2013-00662",
                        "P2013-00314",
                        "P2014-00584",
                        "P2014-00363",
                        "P2018-00301",
                        "P2018-00002",
                        "P2018-00661",
                        "P2019-00324",
                        "P2018-00699",
                        "P2018-00688",
                        "P2018-00284",
                        "P2019-00426",
                        "P2019-00293",
                        "P2018-00373",
                        "P2019-00321",
                        "P2019-00064",
                        "A2019-00501",
                        "P2019-00246",
                        "P2019-00483",
                        "P2015-00830",
                        "P2015-00461",
                        "P2015-00842",
                        "P2013-00872",
                        "P2015-00891",
                        "P2018-00271",
                        "P2019-00270",
                        "P2019-00232",
                        "P2011-00507",
                        "P2011-00584",
                        "P2017-00673",
                        "P2011-00416",
                        "P2013-00117",
                        "P2015-00512",
                        "P2013-00663",
                        "A2018-00712",
                        "P2014-00069",
                        "P2014-00362",
                        "P2014-00026",
                        "P2013-00626",
                        "P2013-00620",
                        "P2013-00610",
                        "P2014-00030",
                        "P2012-00325",
                        "P2018-00601",
                        "P2014-00077",
                        "P2015-00511",
                        "P2017-00874",
                        "A2019-00535",
                        "A2017-00672",
                        "P2016-00228",
                        "P2016-00063",
                        "P2013-00745",
                        "P2015-00421",
                        "P2019-00424",
                        "P2011-00603",
                        "P2011-00095",
                        "P2011-00834",
                        "P2011-01102",
                        "P2011-00081",
                        "A2011-00193",
                        "P2011-00299",
                        "P2011-00715",
                        "P2011-00836",
                        "A2011-00744",
                        "P2012-00170",
                        "P2012-00042",
                        "P2012-00087",
                        "P2012-00109",
                        "P2014-00354",
                        "P2014-00337",
                        "P2014-00143",
                        "P2019-00212",
                        "P2011-00004",
                        "P2011-01173",
                        "P2019-00325",
                        "P2013-00147",
                        "P2012-00313",
                        "P2019-00194",
                        "P2014-00179",
                        "P2014-00243",
                        "P2016-00240",
                        "A2019-00333",
                        "P2016-00003",
                        "P2012-00316",
                        "P2016-00057",
                        "P2019-00488",
                        "P2015-00710",
                        "P2014-00241",
                        "P2015-00709",
                        "P2017-00675",
                        "P2017-00816",
                        "P2018-00551",
                        "P2015-00907",
                        "P2013-00028",
                        "P2015-00864",
                        "P2016-00242",
                        "P2016-00006",
                        "P2019-00011",
                        "P2016-00105",
                        "P2019-00144",
                        "P2016-00215",
                        "P2014-00194",
                        "P2014-00635",
                        "P2018-00292",
                        "P2014-00608",
                        "P2011-00691",
                        "A2016-00339",
                        "P2013-00141",
                        "P2015-00888",
                        "P2016-00546",
                        "P2016-00551",
                        "P2016-00114",
                        "P2016-00115",
                        "P2016-00360",
                        "P2013-00134",
                        "P2014-00540",
                        "P2012-00631",
                        "P2012-00079",
                        "P2012-00186",
                        "P2017-00597",
                        "P2013-00575",
                        "P2012-00289",
                        "A2013-00562",
                        "P2012-00253",
                        "A2017-00752",
                        "P2015-00537",
                        "P2016-00107",
                        "P2018-00584",
                        "P2016-00220",
                        "P2016-00163",
                        "A2020-00003",
                        "P2016-00517",
                        "P2016-00552",
                        "P2015-00455",
                        "P2018-00003",
                        "P2016-00564",
                        "P2015-00714",
                        "A2014-00257",
                        "P2018-00028",
                        "P2016-00446",
                        "P2018-00055",
                        "P2019-00012",
                        "P2014-00607",
                        "P2016-00537",
                        "P2018-00245",
                        "P2016-00570",
                        "P2018-00560",
                        "P2019-00540",
                        "P2017-00098",
                        "A2017-00841",
                        "P2019-00120",
                        "A2017-00084",
                        "P2015-00924",
                        "P2016-00392",
                        "P2018-00729",
                        "P2018-00007",
                        "P2019-00541",
                        "A2019-00394",
                        "A2018-00730",
                        "A2018-00202",
                        "P2016-00036",
                        "P2016-00058",
                        "P2014-00203",
                        "P2016-00438",
                        "P2014-00617",
                        "P2015-00952",
                        "P2014-00631",
                        "A2017-00589",
                        "P2014-00614",
                        "P2016-00338",
                        "P2014-00622",
                        "P2016-00545",
                        "P2018-00383",
                        "P2014-00250",
                        "P2015-00879",
                        "P2019-00506",
                        "P2019-00380",
                        "P2019-00066",
                        "A2019-00059",
                        "P2019-00114",
                        "P2019-00391",
                        "P2016-00064",
                        "A2019-00086",
                        "P2019-00448",
                        "P2019-00235",
                        "P2018-00690",
                        "P2011-00399",
                        "P2016-00044",
                        "P2013-00869",
                        "P2015-00973",
                        "P2014-00364",
                        "P2014-00118",
                        "P2012-00301",
                        "P2014-00594",
                        "P2015-00897",
                        "P2015-00110",
                        "P2014-00391",
                        "P2014-00120",
                        "P2012-00278",
                        "P2011-01058",
                        "P2012-00177",
                        "P2015-00847",
                        "A2019-00178",
                        "A2014-00170",
                        "P2013-00148",
                        "P2015-00102",
                        "P2019-00333"
                    };

                    //sql.AddParameter("@TT_RECORD", "");
                    var converttoint = false;
                    if (g(bp, i, "APPLICATION_NUMBER") == "A2020-00059")
                    {

                    }
                    if (g(bp, i, "APPLICATION_NUMBER") == "560" || g(bp, i, "APPLICATION_NUMBER") == "A0-26627" || g(bp, i, "APPLICATION_NUMBER") == "A0-26628" || g(bp, i, "APPLICATION_NUMBER") == "P012-10114")
                    {
                        //Console.WriteLine("line 544 permit number is " + bp);
                        sql.AddParameter("@TT_RECORD", "Historic");
                    }
                    else if (g(bp, i, "APPLICATION_NUMBER") == "S0-0" || g(bp, i, "APPLICATION_NUMBER") == "B10-0")
                    {
                        sql.AddParameter("@TT_RECORD", "Historic");
                    }

                    else
                    {
                        var temp3 = g(bp, i, "APPLICATION_NUMBER").ToString();
                        //var temp2 = g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1);

                        if (g(bp, i, "APPLICATION_NUMBER").Length > 0)
                            converttoint = Int32.TryParse(g(bp, i, "APPLICATION_NUMBER").Substring(1, 4), out int result);


                        if (converttoint)
                        {
                            if (Int32.Parse(g(bp, i, "APPLICATION_NUMBER").Substring(1, 4)) <= 2009)
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else
                            {
                                if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2199")
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2200")
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3199")
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3200")
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1) == "A")
                                {
                                    sql.AddParameter("@TT_RECORD", "Alternative Solution");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1) == "P")
                                {
                                    sql.AddParameter("@TT_RECORD", "Partial Permit");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1) == "C")
                                {
                                    sql.AddParameter("@TT_RECORD", "Conditional Permit");
                                }
                                else if (ADU.Contains(g(bp, i, "APPLICATION_NUMBER").ToString()))
                                {
                                    sql.AddParameter("@TT_RECORD", "Accessory Dwelling Unit");
                                }
                                else if (g(bp, i, "APPLICATION_Type") == "01")
                                {
                                    sql.AddParameter("@TT_RECORD", "Building Permit - New");
                                }
                                else if (g(bp, i, "FLAG_ALTREP") == "1")
                                {
                                    sql.AddParameter("@TT_RECORD", "Altration");
                                }
                                else if (g(bp, i, "FLAG_DEMO") == "1")
                                {
                                    sql.AddParameter("@TT_RECORD", "Demolision");
                                }
                                else if (g(bp, i, "BUILDINGCLASSFICATION") == "0014")
                                {
                                    sql.AddParameter("@TT_RECORD", "Deck");
                                }
                                else if (g(bp, i, "FLAG_ADDITIONAL") == "1")
                                {
                                    sql.AddParameter("@TT_RECORD", "Addition");
                                }
                                else if (g(bp, i, "APPLICATION_Type") == "06")
                                {
                                    sql.AddParameter("@TT_RECORD", "Mechanical");
                                }
                                else if (g(bp, i, "BUILDINGCLASSFICATION") == "0012")
                                {
                                    sql.AddParameter("@TT_RECORD", "Solar Panel");
                                }
                                else if (g(bp, i, "BUILDINGCLASSFICATION") == "0016")
                                {
                                    sql.AddParameter("@TT_RECORD", "Temporary");
                                }
                                else if (g(bp, i, "BUILDINGCLASSFICATION") == "0017")
                                {
                                    sql.AddParameter("@TT_RECORD", "Change Of Use");
                                }
                                else if (g(bp, i, "PERMIT_TYPE") == "S" || g(bp, i, "PERMIT_TYPE") == "s")
                                {
                                    sql.AddParameter("@TT_RECORD", "Signs");
                                }
                                else if (g(bp, i, "PERMIT_TYPE") == "P" || g(bp, i, "PERMIT_TYPE") == "p")
                                {
                                    sql.AddParameter("@TT_RECORD", "Pool");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "PP2020-10200")
                                {
                                    sql.AddParameter("@TT_RECORD", "Pool");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "SP2020-10198")
                                {
                                    sql.AddParameter("@TT_RECORD", "Pool");
                                }
                                else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "1997-11352")
                                {
                                    sql.AddParameter("@TT_RECORD", "Pool");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "15")
                                {
                                    if (g(bp, i, "CONSTRUCTION_TYPE") == "101")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Building Permit - New");
                                    }
                                    else if (g(bp, i, "CONSTRUCTION_TYPE") == "116")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Addition");
                                    }
                                    else if (g(bp, i, "CONSTRUCTION_TYPE") == "117")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Addition");
                                    }
                                    else
                                    {
                                        sql.AddParameter("@TT_RECORD", "");
                                    }

                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "02")
                                {
                                    sql.AddParameter("@TT_RECORD", "Addition");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "02")
                                {
                                    sql.AddParameter("@TT_RECORD", "Altration");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "11")
                                {
                                    sql.AddParameter("@TT_RECORD", "Change Of Use");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "111")
                                {
                                    sql.AddParameter("@TT_RECORD", "Signs");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "12")
                                {
                                    sql.AddParameter("@TT_RECORD", "Building Permit - New");
                                }
                                else if (g(bp, i, "APPLICATION_TYPE") == "999")
                                {
                                    sql.AddParameter("@TT_RECORD", "Demolision");
                                }
                                else
                                {
                                    sql.AddParameter("@TT_RECORD", "");
                                }
                            }
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2199")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3199")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "60")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "990-")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "A200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "D200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "G199")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "P200")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "PP2020-10200")
                        {
                            sql.AddParameter("@TT_RECORD", "Pool");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "SP2020-10198")
                        {
                            sql.AddParameter("@TT_RECORD", "Pool");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "1997-11352")
                        {
                            sql.AddParameter("@TT_RECORD", "Pool");
                        }
                        else
                        {
                            sql.AddParameter("@TT_RECORD", "");
                        }

                    }
                    if (g(bp, i, "APPLICATION_NUMBER") != "" && g(bp, i, "APPLICATION_NUMBER") != "A2020-11354" && g(bp, i, "APPLICATION_NUMBER") != "A2020-20394"
                    && g(bp, i, "APPLICATION_NUMBER") != "A2020-11479" && g(bp, i, "APPLICATION_NUMBER") != "A2020-11493" && g(bp, i, "APPLICATION_NUMBER") != "P2019-99999"
                    && g(bp, i, "APPLICATION_NUMBER") != "A2020-11484" && g(bp, i, "APPLICATION_NUMBER") != "A2020-00775" && g(bp, i, "APPLICATION_NUMBER") != "A2020-11111"
                    && g(bp, i, "APPLICATION_NUMBER") != "A2021-11016" && g(bp, i, "APPLICATION_NUMBER") != "A2020-00350")
                    {
                        sql.Run();

                    }
                }
            }

            //ASI_Engineering
            if (PermitCustomEngineering)
            {
                string[] engineering = { "NO_MANHOLES", "NO_CATCHBASINS", "NO_RAINWATERHOPPERS", "NO_AREADRAINS", "RES_WATERSERVICE", "RES_SANITARYDRAIN", "RES_STORMDRAIN", "RES_CONVERSIONTOSEWER", "RES_CONVERSIONINCLUDING", "NO_MANHOLES_VALUE", "NO_CATCHBASINS_VALUE", "NO_RAINWTRHPPERS_VALUE", "NO_AREADRAINS_VALUE", "RES_WATER_VALUE", "RES_SANITARY_VALUE", "RES_STORM_VALUE", "RES_CONVERSION_TO_VALUE", "RES_CONVERSION_INCL_VALUE", "COMM_50MMWATER", "COMM_100MMWATER", "COMM_150MMWATER", "COMM_200MMWATER", "COMM_250MMWATER", "COMM_300MMWATER", "COMM_GT300MMWATER", "COMM_50MMSANITARY", "COMM_100MMSANITARY", "COMM_150MMSANITARY", "COMM_200MMSANITARY", "COMM_250MMSANITARY", "COMM_300MMSANITARY", "COMM_GT300MMSANITARY", "COMM_50MMSTORM", "COMM_100MMSTORM", "COMM_150MMSTORM", "COMM_200MMSTORM", "COMM_250MMSTORM", "COMM_300MMSTORM", "COMM_GT300MMSTORM", "COMM50mm_VALUE", "COMM100mm_VALUE", "COMM150mm_VALUE", "COMM200mm_VALUE", "COMM250mm_VALUE", "COMM300mm_VALUE", "COMMGT300mm_VALUE", "COMM_OTHER", "COMMOTHER_VALUE" };
                //string[] engineeringLabels = { "Manholes Number", "Catch Basins Number", "Rain Water Hoppers Number", "Area Drains Number", "Water Service Number", "Sanitary Service Number", "Storm Drain Number", "Conversion to sewer", "Number", "Conversion Including Number", "Manholes Value", "Catch Basins Value", "Rain Water Hoppers Value", "Area Drains Value", "Water Service Value", "Sanitary Service Value", "Storm Drain Value", "Conversion to sewer Value", "Conversion Including Value", "50mm", "Water Number", "100mm Water Number", "150mm Water Number", "200mm Water Number", "250mm Water Number", "300mm Water Number", ">300mm Water Number", "50mm Sanitary Number", "100mm Sanitary Number", "150mm Sanitary Number", "200mm Sanitary Number", "250mm Sanitary", "Number", "300mm Sanitary Number", ">300mm Sanitary Number", "50mm Storm Number", "100mm", "Storm Number", "150mm Storm Number", "200mm Storm Number", "250mm Storm Number", "300mm", "Storm Number", ">300mm Storm Number", "50mm Value", "100mm Value", "150mm Value", "200mm Value", "250mm Value", "300mm Value", ">300mm Value", "Other Number", "Other Value" };

                for (int i = 0; i < bp.Rows.Count; i++)
                {
                    DataTable engineeringTable = CityView.Run("select * from sysadmin.engineering where bi_app_id = @ID", g(bp, i, "RECORDID"));

                    if (engineeringTable.Rows.Count > 0)
                    {
                        SQL sql = new SQL(@"
                    use accelastage;
                    insert into ASI_Engineering
                    (
                    PERMITNUM,
                    TT_RECORD,
                    NO_MANHOLES,
                    NO_CATCHBASINS,
                    NO_RAINWATERHOPPERS,
                    NO_AREADRAINS,
                    RES_WATERSERVICE,
                    RES_SANITARYDRAIN,
                    RES_STORMDRAIN,
                    RES_CONVERSIONTOSEWER,
                    RES_CONVERSIONINCLUDING,
                    NO_MANHOLES_VALUE,
                    NO_CATCHBASINS_VALUE,
                    NO_RAINWTRHPPERS_VALUE,
                    NO_AREADRAINS_VALUE,
                    RES_WATER_VALUE,
                    RES_SANITARY_VALUE,
                    RES_STORM_VALUE,
                    RES_CONVERSION_TO_VALUE,
                    RES_CONVERSION_INCL_VALUE,
                    COMM_50MMWATER,
                    COMM_100MMWATER,
                    COMM_150MMWATER,
                    COMM_200MMWATER,
                    COMM_250MMWATER,
                    COMM_300MMWATER,
                    COMM_GT300MMWATER,
                    COMM_50MMSANITARY,
                    COMM_100MMSANITARY,
                    COMM_150MMSANITARY,
                    COMM_200MMSANITARY,
                    COMM_250MMSANITARY,
                    COMM_300MMSANITARY,
                    COMM_GT300MMSANITARY,
                    COMM_50MMSTORM,
                    COMM_100MMSTORM,
                    COMM_150MMSTORM,
                    COMM_200MMSTORM,
                    COMM_250MMSTORM,
                    COMM_300MMSTORM,
                    COMM_GT300MMSTORM,
                    COMM50mm_VALUE,
                    COMM100mm_VALUE,
                    COMM150mm_VALUE,
                    COMM200mm_VALUE,
                    COMM250mm_VALUE,
                    COMM300mm_VALUE,
                    COMMGT300mm_VALUE,
                    COMM_OTHER,
                    COMMOTHER_VALUE
                    )
                    values (
                    @PERMITNUM,
                    @TT_RECORD,
                    @NO_MANHOLES,
                    @NO_CATCHBASINS,
                    @NO_RAINWATERHOPPERS,
                    @NO_AREADRAINS,
                    @RES_WATERSERVICE,
                    @RES_SANITARYDRAIN,
                    @RES_STORMDRAIN,
                    @RES_CONVERSIONTOSEWER,
                    @RES_CONVERSIONINCLUDING,
                    @NO_MANHOLES_VALUE,
                    @NO_CATCHBASINS_VALUE,
                    @NO_RAINWTRHPPERS_VALUE,
                    @NO_AREADRAINS_VALUE,
                    @RES_WATER_VALUE,
                    @RES_SANITARY_VALUE,
                    @RES_STORM_VALUE,
                    @RES_CONVERSION_TO_VALUE,
                    @RES_CONVERSION_INCL_VALUE,
                    @COMM_50MMWATER,
                    @COMM_100MMWATER,
                    @COMM_150MMWATER,
                    @COMM_200MMWATER,
                    @COMM_250MMWATER,
                    @COMM_300MMWATER,
                    @COMM_GT300MMWATER,
                    @COMM_50MMSANITARY,
                    @COMM_100MMSANITARY,
                    @COMM_150MMSANITARY,
                    @COMM_200MMSANITARY,
                    @COMM_250MMSANITARY,
                    @COMM_300MMSANITARY,
                    @COMM_GT300MMSANITARY,
                    @COMM_50MMSTORM,
                    @COMM_100MMSTORM,
                    @COMM_150MMSTORM,
                    @COMM_200MMSTORM,
                    @COMM_250MMSTORM,
                    @COMM_300MMSTORM,
                    @COMM_GT300MMSTORM,
                    @COMM50mm_VALUE,
                    @COMM100mm_VALUE,
                    @COMM150mm_VALUE,
                    @COMM200mm_VALUE,
                    @COMM250mm_VALUE,
                    @COMM300mm_VALUE,
                    @COMMGT300mm_VALUE,
                    @COMM_OTHER,
                    @COMMOTHER_VALUE
                    )");

                        sql.AddParameter("@PERMITNUM", g(bp, i, "APPLICATION_NUMBER"));

                        for (int f = 0; f < engineering.Length; f++)
                        {
                            decimal d;
                            bool success;
                            string s = g(engineeringTable, 0, engineering[f]);

                            success = decimal.TryParse(s, out d);

                            if (success)
                                sql.AddParameter("@" + engineering[f], d);
                            else if (s == "")
                                sql.AddParameter("@" + engineering[f], DBNull.Value);
                            else
                                sql.AddParameter("@" + engineering[f], g(engineeringTable, 0, engineering[f]));
                        }

                        string[] ADU = new string[] {
                        "A2019-00318",
                        "P2010-00020",
                        "A2010-00851",
                        "P2010-00722",
                        "P2010-00961",
                        "P2010-00547",
                        "P2010-00548",
                        "A2010-00813",
                        "P2010-00831",
                        "P2010-00934",
                        "P2010-00534",
                        "P2010-00282",
                        "P2010-00261",
                        "P2010-00944",
                        "P2010-00723",
                        "P2011-00478",
                        "P2011-00479",
                        "P2011-00561",
                        "P2019-00036",
                        "P2018-00040",
                        "P2018-00224",
                        "P2019-00493",
                        "P2017-00517",
                        "P2017-00561",
                        "P2018-00037",
                        "P2019-00396",
                        "P2019-00121",
                        "P2016-00292",
                        "P2016-00133",
                        "A2016-00118",
                        "P2016-00173",
                        "P2016-00069",
                        "P2015-00763",
                        "P2016-00068",
                        "P2015-00959",
                        "A2020-00005",
                        "P2018-00235",
                        "P2016-00335",
                        "P2016-00353",
                        "P2019-00035",
                        "P2019-00420",
                        "P2013-00308",
                        "P2013-00213",
                        "P2013-00300",
                        "P2013-00893",
                        "A2013-00900",
                        "P2014-00302",
                        "P2017-00615",
                        "P2012-00055",
                        "P2015-00961",
                        "P2011-00672",
                        "P2011-00497",
                        "P2012-00392",
                        "P2012-00579",
                        "P2012-00381",
                        "P2012-00738",
                        "P2012-00576",
                        "P2013-00765",
                        "P2013-00762",
                        "P2013-00767",
                        "P2013-00048",
                        "P2013-00860",
                        "P2014-00136",
                        "P2014-00361",
                        "P2014-00583",
                        "A2014-00674",
                        "P2015-00422",
                        "P2015-00790",
                        "P2015-00479",
                        "P2015-00792",
                        "P2015-00685",
                        "P2015-00672",
                        "P2015-00347",
                        "P2015-00601",
                        "P2015-00736",
                        "P2015-00644",
                        "P2015-00610",
                        "P2016-00222",
                        "P2016-00247",
                        "P2017-00264",
                        "P2017-00076",
                        "P2014-00359",
                        "P2017-00826",
                        "P2019-00267",
                        "P2019-00527",
                        "P2019-00328",
                        "P2013-00798",
                        "P2013-00662",
                        "P2013-00314",
                        "P2014-00584",
                        "P2014-00363",
                        "P2018-00301",
                        "P2018-00002",
                        "P2018-00661",
                        "P2019-00324",
                        "P2018-00699",
                        "P2018-00688",
                        "P2018-00284",
                        "P2019-00426",
                        "P2019-00293",
                        "P2018-00373",
                        "P2019-00321",
                        "P2019-00064",
                        "A2019-00501",
                        "P2019-00246",
                        "P2019-00483",
                        "P2015-00830",
                        "P2015-00461",
                        "P2015-00842",
                        "P2013-00872",
                        "P2015-00891",
                        "P2018-00271",
                        "P2019-00270",
                        "P2019-00232",
                        "P2011-00507",
                        "P2011-00584",
                        "P2017-00673",
                        "P2011-00416",
                        "P2013-00117",
                        "P2015-00512",
                        "P2013-00663",
                        "A2018-00712",
                        "P2014-00069",
                        "P2014-00362",
                        "P2014-00026",
                        "P2013-00626",
                        "P2013-00620",
                        "P2013-00610",
                        "P2014-00030",
                        "P2012-00325",
                        "P2018-00601",
                        "P2014-00077",
                        "P2015-00511",
                        "P2017-00874",
                        "A2019-00535",
                        "A2017-00672",
                        "P2016-00228",
                        "P2016-00063",
                        "P2013-00745",
                        "P2015-00421",
                        "P2019-00424",
                        "P2011-00603",
                        "P2011-00095",
                        "P2011-00834",
                        "P2011-01102",
                        "P2011-00081",
                        "A2011-00193",
                        "P2011-00299",
                        "P2011-00715",
                        "P2011-00836",
                        "A2011-00744",
                        "P2012-00170",
                        "P2012-00042",
                        "P2012-00087",
                        "P2012-00109",
                        "P2014-00354",
                        "P2014-00337",
                        "P2014-00143",
                        "P2019-00212",
                        "P2011-00004",
                        "P2011-01173",
                        "P2019-00325",
                        "P2013-00147",
                        "P2012-00313",
                        "P2019-00194",
                        "P2014-00179",
                        "P2014-00243",
                        "P2016-00240",
                        "A2019-00333",
                        "P2016-00003",
                        "P2012-00316",
                        "P2016-00057",
                        "P2019-00488",
                        "P2015-00710",
                        "P2014-00241",
                        "P2015-00709",
                        "P2017-00675",
                        "P2017-00816",
                        "P2018-00551",
                        "P2015-00907",
                        "P2013-00028",
                        "P2015-00864",
                        "P2016-00242",
                        "P2016-00006",
                        "P2019-00011",
                        "P2016-00105",
                        "P2019-00144",
                        "P2016-00215",
                        "P2014-00194",
                        "P2014-00635",
                        "P2018-00292",
                        "P2014-00608",
                        "P2011-00691",
                        "A2016-00339",
                        "P2013-00141",
                        "P2015-00888",
                        "P2016-00546",
                        "P2016-00551",
                        "P2016-00114",
                        "P2016-00115",
                        "P2016-00360",
                        "P2013-00134",
                        "P2014-00540",
                        "P2012-00631",
                        "P2012-00079",
                        "P2012-00186",
                        "P2017-00597",
                        "P2013-00575",
                        "P2012-00289",
                        "A2013-00562",
                        "P2012-00253",
                        "A2017-00752",
                        "P2015-00537",
                        "P2016-00107",
                        "P2018-00584",
                        "P2016-00220",
                        "P2016-00163",
                        "A2020-00003",
                        "P2016-00517",
                        "P2016-00552",
                        "P2015-00455",
                        "P2018-00003",
                        "P2016-00564",
                        "P2015-00714",
                        "A2014-00257",
                        "P2018-00028",
                        "P2016-00446",
                        "P2018-00055",
                        "P2019-00012",
                        "P2014-00607",
                        "P2016-00537",
                        "P2018-00245",
                        "P2016-00570",
                        "P2018-00560",
                        "P2019-00540",
                        "P2017-00098",
                        "A2017-00841",
                        "P2019-00120",
                        "A2017-00084",
                        "P2015-00924",
                        "P2016-00392",
                        "P2018-00729",
                        "P2018-00007",
                        "P2019-00541",
                        "A2019-00394",
                        "A2018-00730",
                        "A2018-00202",
                        "P2016-00036",
                        "P2016-00058",
                        "P2014-00203",
                        "P2016-00438",
                        "P2014-00617",
                        "P2015-00952",
                        "P2014-00631",
                        "A2017-00589",
                        "P2014-00614",
                        "P2016-00338",
                        "P2014-00622",
                        "P2016-00545",
                        "P2018-00383",
                        "P2014-00250",
                        "P2015-00879",
                        "P2019-00506",
                        "P2019-00380",
                        "P2019-00066",
                        "A2019-00059",
                        "P2019-00114",
                        "P2019-00391",
                        "P2016-00064",
                        "A2019-00086",
                        "P2019-00448",
                        "P2019-00235",
                        "P2018-00690",
                        "P2011-00399",
                        "P2016-00044",
                        "P2013-00869",
                        "P2015-00973",
                        "P2014-00364",
                        "P2014-00118",
                        "P2012-00301",
                        "P2014-00594",
                        "P2015-00897",
                        "P2015-00110",
                        "P2014-00391",
                        "P2014-00120",
                        "P2012-00278",
                        "P2011-01058",
                        "P2012-00177",
                        "P2015-00847",
                        "A2019-00178",
                        "A2014-00170",
                        "P2013-00148",
                        "P2015-00102",
                        "P2019-00333"
                    };

                        //sql.AddParameter("@TT_RECORD", "");
                        var converttoint = false;
                        if (g(bp, i, "APPLICATION_NUMBER") == "A2020-00059")
                        {

                        }
                        if (g(bp, i, "APPLICATION_NUMBER") == "560" || g(bp, i, "APPLICATION_NUMBER") == "A0-26627" || g(bp, i, "APPLICATION_NUMBER") == "A0-26628" || g(bp, i, "APPLICATION_NUMBER") == "P012-10114")
                        {
                            //Console.WriteLine("line 544 permit number is " + bp);
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }
                        else if (g(bp, i, "APPLICATION_NUMBER") == "S0-0" || g(bp, i, "APPLICATION_NUMBER") == "B10-0")
                        {
                            sql.AddParameter("@TT_RECORD", "Historic");
                        }

                        else
                        {
                            var temp3 = g(bp, i, "APPLICATION_NUMBER").ToString();
                            //var temp2 = g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1);

                            if (g(bp, i, "APPLICATION_NUMBER").Length > 0)
                                converttoint = Int32.TryParse(g(bp, i, "APPLICATION_NUMBER").Substring(1, 4), out int result);


                            if (converttoint)
                            {
                                if (Int32.Parse(g(bp, i, "APPLICATION_NUMBER").Substring(1, 4)) <= 2009)
                                {
                                    sql.AddParameter("@TT_RECORD", "Historic");
                                }
                                else
                                {
                                    if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2199")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Historic");
                                    }
                                    else if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2200")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Historic");
                                    }
                                    else if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3199")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Historic");
                                    }
                                    else if (g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3200")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Historic");
                                    }
                                    else if (g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1) == "A")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Alternative Solution");
                                    }
                                    else if (g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1) == "P")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Partial Permit");
                                    }
                                    else if (g(bp, i, "APPLICATION_NUMBER").Substring(g(bp, i, "APPLICATION_NUMBER").Length - 1) == "C")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Conditional Permit");
                                    }
                                    else if (ADU.Contains(g(bp, i, "APPLICATION_NUMBER").ToString()))
                                    {
                                        sql.AddParameter("@TT_RECORD", "Accessory Dwelling Unit");
                                    }
                                    else if (g(bp, i, "APPLICATION_Type") == "01")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Building Permit - New");
                                    }
                                    else if (g(bp, i, "FLAG_ALTREP") == "1")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Altration");
                                    }
                                    else if (g(bp, i, "FLAG_DEMO") == "1")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Demolision");
                                    }
                                    else if (g(bp, i, "BUILDINGCLASSFICATION") == "0014")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Deck");
                                    }
                                    else if (g(bp, i, "FLAG_ADDITIONAL") == "1")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Addition");
                                    }
                                    else if (g(bp, i, "APPLICATION_Type") == "06")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Mechanical");
                                    }
                                    else if (g(bp, i, "BUILDINGCLASSFICATION") == "0012")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Solar Panel");
                                    }
                                    else if (g(bp, i, "BUILDINGCLASSFICATION") == "0016")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Temporary");
                                    }
                                    else if (g(bp, i, "BUILDINGCLASSFICATION") == "0017")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Change Of Use");
                                    }
                                    else if (g(bp, i, "PERMIT_TYPE") == "S" || g(bp, i, "PERMIT_TYPE") == "s")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Signs");
                                    }
                                    else if (g(bp, i, "PERMIT_TYPE") == "P" || g(bp, i, "PERMIT_TYPE") == "p")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Pool");
                                    }
                                    else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "PP2020-10200")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Pool");
                                    }
                                    else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "SP2020-10198")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Pool");
                                    }
                                    else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "1997-11352")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Pool");
                                    }
                                    else if (g(bp, i, "APPLICATION_TYPE") == "15")
                                    {
                                        if (g(bp, i, "CONSTRUCTION_TYPE") == "101")
                                        {
                                            sql.AddParameter("@TT_RECORD", "Building Permit - New");
                                        }
                                        else if (g(bp, i, "CONSTRUCTION_TYPE") == "116")
                                        {
                                            sql.AddParameter("@TT_RECORD", "Addition");
                                        }
                                        else if (g(bp, i, "CONSTRUCTION_TYPE") == "117")
                                        {
                                            sql.AddParameter("@TT_RECORD", "Addition");
                                        }
                                        else
                                        {
                                            sql.AddParameter("@TT_RECORD", "");
                                        }

                                    }
                                    else if (g(bp, i, "APPLICATION_TYPE") == "02")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Addition");
                                    }
                                    else if (g(bp, i, "APPLICATION_TYPE") == "02")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Altration");
                                    }
                                    else if (g(bp, i, "APPLICATION_TYPE") == "11")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Change Of Use");
                                    }
                                    else if (g(bp, i, "APPLICATION_TYPE") == "111")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Signs");
                                    }
                                    else if (g(bp, i, "APPLICATION_TYPE") == "12")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Building Permit - New");
                                    }
                                    else if (g(bp, i, "APPLICATION_TYPE") == "999")
                                    {
                                        sql.AddParameter("@TT_RECORD", "Demolision");
                                    }
                                    else
                                    {
                                        sql.AddParameter("@TT_RECORD", "");
                                    }
                                }
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2199")
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "2200")
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3199")
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "3200")
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "60")
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "990-")
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "A200")
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "D200")
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "G199")
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER").Substring(1, 4) == "P200")
                            {
                                sql.AddParameter("@TT_RECORD", "Historic");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "PP2020-10200")
                            {
                                sql.AddParameter("@TT_RECORD", "Pool");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "SP2020-10198")
                            {
                                sql.AddParameter("@TT_RECORD", "Pool");
                            }
                            else if (g(bp, i, "APPLICATION_NUMBER").Length > 0 && g(bp, i, "APPLICATION_NUMBER") == "1997-11352")
                            {
                                sql.AddParameter("@TT_RECORD", "Pool");
                            }
                            else
                            {
                                sql.AddParameter("@TT_RECORD", "");
                            }

                        }
                        if (g(bp, i, "APPLICATION_NUMBER") != "" && g(bp, i, "APPLICATION_NUMBER") != "A2020-11354" && g(bp, i, "APPLICATION_NUMBER") != "A2020-20394"
                        && g(bp, i, "APPLICATION_NUMBER") != "A2020-11479" && g(bp, i, "APPLICATION_NUMBER") != "A2020-11493" && g(bp, i, "APPLICATION_NUMBER") != "P2019-99999"
                        && g(bp, i, "APPLICATION_NUMBER") != "A2020-11484" && g(bp, i, "APPLICATION_NUMBER") != "A2020-00775" && g(bp, i, "APPLICATION_NUMBER") != "A2020-11111"
                        && g(bp, i, "APPLICATION_NUMBER") != "A2021-11016" && g(bp, i, "APPLICATION_NUMBER") != "A2020-00350")
                        {
                            sql.Run();

                        }
                    }
                }
            }

            //AATable_Permit_Parcel
            if (PermitParcel)
            {
                for (int i = 0; i < bp.Rows.Count; i++)
                {
                    DataTable assess = CityView.Run("select roll_num from sysadmin.assess where recordid = @ID", g(bp, i, "ASSESS_ID"));

                    if (assess.Rows.Count > 0)
                    {
                        DataTable parcels = SQL.Run("select * from ASSESS_MAPPED where roll_num = @ID", g(assess, 0, "ROLL_NUM"));

                        if (parcels.Rows.Count > 0)
                        {
                            SQL sql = new SQL(@"
            use accelastage;
            insert into AATable_Permit_Parcel
            values (
            @PERMITNUM,
            @PARCELNUM,
            @BOOK,
            @PAGE,
            @PARCEL,
            @LOT,
            @BLOCK,
            @TRACT,
            @LEGAL_DESC,
            @PARCEL_AREA,
            @PLAN_AREA,
            @CENSUS_TRACT,
            @COUNCIL_DISTRICT,
            @SUPERVISOR_DISTRICT,
            @INSPECTION_DISTRICT,
            @LAND_VALUE,
            @IMPROVED_VALUE,
            @EXEMPT_VALUE,
            @MAP_REFERENCE,
            @MAP_NUMBER,
            @SUBDIVISION,
            @PRIMARY_FLAG,
            @TOWNSHIP,
            @RANGE,
            @SECTION,
            @EXT_PARCEL_UID
            )");

                            string rollNo = g(parcels, 0, "ROLL_NUM");
                            string PIN = g(parcels, 0, "PIN");
                            string legalDesc = "";

                            sql.AddParameter("@PERMITNUM", g(bp, i, "APPLICATION_NUMBER"));
                            sql.AddParameter("@PARCELNUM", rollNo);
                            sql.AddParameter("@BOOK", DBNull.Value);
                            sql.AddParameter("@PAGE", DBNull.Value);
                            sql.AddParameter("@PARCEL", PIN);
                            sql.AddParameter("@LOT", DBNull.Value);
                            sql.AddParameter("@BLOCK", DBNull.Value);
                            sql.AddParameter("@TRACT", DBNull.Value);

                            if (rollNo.Length == 19)
                                rollNo = rollNo.Substring(4);

                            // temp = Vailtech.Run("select * from Vailtech.TX_ROLL where roll_no = @ID", rollNo); // Vailtech server is no longer in use now so we cahnge it to SQL
                             temp = SQL.Run("select * from VTX.Vailtech.TX_ROLL where roll_no = @ID", rollNo);

                            if (temp.Rows.Count > 0)
                                legalDesc = g(temp, 0, "LEGAL1") + " " + g(temp, 0, "LEGAL2") + " " + g(temp, 0, "LEGAL3") + " " + g(temp, 0, "LEGAL4") + " " + g(temp, 0, "LEGAL5");

                            legalDesc = legalDesc.Trim();

                            sql.AddParameter("@LEGAL_DESC", legalDesc);
                            sql.AddParameter("@PARCEL_AREA", DBNull.Value);
                            sql.AddParameter("@PLAN_AREA", DBNull.Value);
                            sql.AddParameter("@CENSUS_TRACT", DBNull.Value);
                            sql.AddParameter("@COUNCIL_DISTRICT", DBNull.Value);
                            sql.AddParameter("@SUPERVISOR_DISTRICT", DBNull.Value);
                            sql.AddParameter("@INSPECTION_DISTRICT", DBNull.Value);
                            sql.AddParameter("@LAND_VALUE", DBNull.Value);
                            sql.AddParameter("@IMPROVED_VALUE", DBNull.Value);
                            sql.AddParameter("@EXEMPT_VALUE", DBNull.Value);
                            sql.AddParameter("@MAP_REFERENCE", DBNull.Value);
                            sql.AddParameter("@MAP_NUMBER", DBNull.Value);
                            sql.AddParameter("@SUBDIVISION", DBNull.Value);
                            sql.AddParameter("@PRIMARY_FLAG", DBNull.Value);
                            sql.AddParameter("@TOWNSHIP", DBNull.Value);
                            sql.AddParameter("@RANGE", DBNull.Value);
                            sql.AddParameter("@SECTION", DBNull.Value);
                            sql.AddParameter("@EXT_PARCEL_UID", DBNull.Value);

                            if (g(bp, i, "APPLICATION_NUMBER") != "")
                                sql.Run();
                        }
                    }
                }
            }

            //Enter applicant into AATable_Permit_People
            if (PermitPeople)
            {
                for (int i = 0; i < bp.Rows.Count; i++)
                {
                    SQL sql = new SQL(@"
            use accelastage;
            insert into AATable_Permit_People
            (
            PERMITNUM,
            TT_CONTACT_TYPE,
            ISPRIMARY,
            LIC_NUM,
            LIC_TYPE,
            NAME,
            FNAME,
            MNAME,
            LNAME,
            BUS_NAME,
            ADDR1,
            ADDR2,
            ADDR3,
            CITY,
            STATE,
            ZIP,
            PH1,
            PH2,
            FAX,
            EMAIL,
            COMMENTS,
            TITLE,
            PH3,
            COUNTRY_CODE,
            NOTIFY,
            NAME_SUFFIX,
            BUS_LIC,
            LIC_ORIGINAL_ISSUE_DATE,
            EXPIRATION_DATE,
            RENEWAL_DATE,
            MAIL_ADDR1,
            MAIL_ADDR2,
            MAIL_ADDR3,
            MAIL_CITY,
            MAIL_STATE,
            MAIL_ZIP,
            MAIL_COUNTRY,
            OWNER_TYPE,
            GENDER,
            SALUTATION,
            PO_BOX,
            BUS_NAME2,
            BIRTH_DATE,
            PH1_COUNTRY_CODE,
            PH2_COUNTRY_CODE,
            PH3_COUNTRY_CODE,
            FAX_COUNTRY_CODE,
            TRADE_NAME,
            CONTACT_TYPE_FLAG,
            SOCIAL_SECURITY_NUMBER,
            FEDERAL_EMPLOYER_ID_NUM,
            CONTRA_TYPE_FLAG,
            LIC_BOARD,
            B1_ID,
            CONT_LIC_BUS_NAME,
            B1_ACCESS_LEVEL,
            BIRTH_CITY,
            BIRTH_STATE,
            BIRTH_REGION,
            RACE,
            DECEASED_DATE,
            PASSPORT_NBR,
            DRIVER_LIC_NBR,
            DRIVER_LIC_STATE,
            STATE_ID_NBR,
            B1_CONTACT_NBR,
            G1_CONTACT_NBR
            )
            values (
            @PERMITNUM,
            @TT_CONTACT_TYPE,
            @ISPRIMARY,
            @LIC_NUM,
            @LIC_TYPE,
            @NAME,
            @FNAME,
            @MNAME,
            @LNAME,
            @BUS_NAME,
            @ADDR1,
            @ADDR2,
            @ADDR3,
            @CITY,
            @STATE,
            @ZIP,
            @PH1,
            @PH2,
            @FAX,
            @EMAIL,
            @COMMENTS,
            @TITLE,
            @PH3,
            @COUNTRY_CODE,
            @NOTIFY,
            @NAME_SUFFIX,
            @BUS_LIC,
            @LIC_ORIGINAL_ISSUE_DATE,
            @EXPIRATION_DATE,
            @RENEWAL_DATE,
            @MAIL_ADDR1,
            @MAIL_ADDR2,
            @MAIL_ADDR3,
            @MAIL_CITY,
            @MAIL_STATE,
            @MAIL_ZIP,
            @MAIL_COUNTRY,
            @OWNER_TYPE,
            @GENDER,
            @SALUTATION,
            @PO_BOX,
            @BUS_NAME2,
            @BIRTH_DATE,
            @PH1_COUNTRY_CODE,
            @PH2_COUNTRY_CODE,
            @PH3_COUNTRY_CODE,
            @FAX_COUNTRY_CODE,
            @TRADE_NAME,
            @CONTACT_TYPE_FLAG,
            @SOCIAL_SECURITY_NUMBER,
            @FEDERAL_EMPLOYER_ID_NUM,
            @CONTRA_TYPE_FLAG,
            @LIC_BOARD,
            @B1_ID,
            @CONT_LIC_BUS_NAME,
            @B1_ACCESS_LEVEL,
            @BIRTH_CITY,
            @BIRTH_STATE,
            @BIRTH_REGION,
            @RACE,
            @DECEASED_DATE,
            @PASSPORT_NBR,
            @DRIVER_LIC_NBR,
            @DRIVER_LIC_STATE,
            @STATE_ID_NBR,
            @B1_CONTACT_NBR,
            @G1_CONTACT_NBR
            )");
                    sql.AddParameter("@PERMITNUM", g(bp, i, "APPLICATION_NUMBER"));
                    sql.AddParameter("@TT_CONTACT_TYPE", "Applicant");
                    sql.AddParameter("@ISPRIMARY", "Y");
                    sql.AddParameter("@LIC_NUM", DBNull.Value);
                    sql.AddParameter("@LIC_TYPE", DBNull.Value);

                    string first = "N/A";
                    string last = "N/A";
                    string full = g(bp, i, "APPLICANT_NAME").Trim();

                    if (full == "")
                        full = "N/A";

                    if (full.Contains(' '))
                    {
                        int space = full.IndexOf(' ');
                        last = full.Substring(0, space);
                        first = full.Substring(space);
                    }

                    sql.AddParameter("@NAME", full);
                    sql.AddParameter("@FNAME", first);
                    sql.AddParameter("@MNAME", DBNull.Value);
                    sql.AddParameter("@LNAME", last);
                    sql.AddParameter("@BUS_NAME", DBNull.Value);
                    sql.AddParameter("@ADDR1", g(bp, i, "APPLICANT_ADDRESS"));
                    sql.AddParameter("@ADDR2", DBNull.Value);
                    sql.AddParameter("@ADDR3", DBNull.Value);
                    sql.AddParameter("@CITY", g(bp, i, "APPLICANT_CITY"));
                    sql.AddParameter("@STATE", g(bp, i, "APPLICANT_PROV"));
                    sql.AddParameter("@ZIP", g(bp, i, "APPLICANT_POSTALCDE"));
                    sql.AddParameter("@PH1", g(bp, i, "APPLICANT_PHONE") + (g(bp, i, "Extension") != "" ? "ext. " + g(bp, i, "Extension") : ""));
                    sql.AddParameter("@PH2", g(bp, i, "CELL_NUMBER"));
                    sql.AddParameter("@FAX", g(bp, i, "FAX_NUMBER"));
                    sql.AddParameter("@EMAIL", g(bp, i, "APPLICANT_EMAIL"));
                    sql.AddParameter("@COMMENTS", DBNull.Value);
                    sql.AddParameter("@TITLE", DBNull.Value);
                    sql.AddParameter("@PH3", DBNull.Value);
                    sql.AddParameter("@COUNTRY_CODE", DBNull.Value);
                    sql.AddParameter("@NOTIFY", DBNull.Value);
                    sql.AddParameter("@NAME_SUFFIX", DBNull.Value);
                    sql.AddParameter("@BUS_LIC", DBNull.Value);
                    sql.AddParameter("@LIC_ORIGINAL_ISSUE_DATE", DBNull.Value);
                    sql.AddParameter("@EXPIRATION_DATE", DBNull.Value);
                    sql.AddParameter("@RENEWAL_DATE", DBNull.Value);
                    sql.AddParameter("@MAIL_ADDR1", DBNull.Value);
                    sql.AddParameter("@MAIL_ADDR2", DBNull.Value);
                    sql.AddParameter("@MAIL_ADDR3", DBNull.Value);
                    sql.AddParameter("@MAIL_CITY", DBNull.Value);
                    sql.AddParameter("@MAIL_STATE", DBNull.Value);
                    sql.AddParameter("@MAIL_ZIP", DBNull.Value);
                    sql.AddParameter("@MAIL_COUNTRY", DBNull.Value);
                    sql.AddParameter("@OWNER_TYPE", DBNull.Value);
                    sql.AddParameter("@GENDER", DBNull.Value);
                    sql.AddParameter("@SALUTATION", DBNull.Value);
                    sql.AddParameter("@PO_BOX", DBNull.Value);
                    sql.AddParameter("@BUS_NAME2", DBNull.Value);
                    sql.AddParameter("@BIRTH_DATE", DBNull.Value);
                    sql.AddParameter("@PH1_COUNTRY_CODE", DBNull.Value);
                    sql.AddParameter("@PH2_COUNTRY_CODE", DBNull.Value);
                    sql.AddParameter("@PH3_COUNTRY_CODE", DBNull.Value);
                    sql.AddParameter("@FAX_COUNTRY_CODE", DBNull.Value);
                    sql.AddParameter("@TRADE_NAME", DBNull.Value);
                    sql.AddParameter("@CONTACT_TYPE_FLAG", "Individual");
                    sql.AddParameter("@SOCIAL_SECURITY_NUMBER", DBNull.Value);
                    sql.AddParameter("@FEDERAL_EMPLOYER_ID_NUM", DBNull.Value);
                    sql.AddParameter("@CONTRA_TYPE_FLAG", DBNull.Value);
                    sql.AddParameter("@LIC_BOARD", DBNull.Value);
                    sql.AddParameter("@B1_ID", DBNull.Value);
                    sql.AddParameter("@CONT_LIC_BUS_NAME", DBNull.Value);
                    sql.AddParameter("@B1_ACCESS_LEVEL", DBNull.Value);
                    sql.AddParameter("@BIRTH_CITY", DBNull.Value);
                    sql.AddParameter("@BIRTH_STATE", DBNull.Value);
                    sql.AddParameter("@BIRTH_REGION", DBNull.Value);
                    sql.AddParameter("@RACE", DBNull.Value);
                    sql.AddParameter("@DECEASED_DATE", DBNull.Value);
                    sql.AddParameter("@PASSPORT_NBR", DBNull.Value);
                    sql.AddParameter("@DRIVER_LIC_NBR", DBNull.Value);
                    sql.AddParameter("@DRIVER_LIC_STATE", DBNull.Value);
                    sql.AddParameter("@STATE_ID_NBR", DBNull.Value);
                    sql.AddParameter("@B1_CONTACT_NBR", DBNull.Value);
                    sql.AddParameter("@G1_CONTACT_NBR", DBNull.Value);

                    if (g(bp, i, "APPLICATION_NUMBER") != "")
                        sql.Run();

                    addNumber("Applicant", first, last, full, g(bp, i, "APPLICANT_ADDRESS"), g(bp, i, "APPLICANT_CITY"), g(bp, i, "APPLICANT_PROV"), g(bp, i, "APPLICANT_POSTALCDE"), g(bp, i, "APPLICANT_PHONE") + (g(bp, i, "Extension") != "" ? "ext. " + g(bp, i, "Extension") : ""), g(bp, i, "CELL_NUMBER"), g(bp, i, "FAX_NUMBER"), g(bp, i, "APPLICANT_EMAIL"));
                }

                //Enter owner into AATable_Permit_People from building permits
                for (int i = 0; i < bp.Rows.Count; i++)
                {
                    DataTable assess = CityView.Run("select * from sysadmin.assess where recordid = @ID", g(bp, i, "ASSESS_ID"));
                    DataTable owner = CityView.Run("select * from sysadmin.owner where parentid = @ID", g(bp, i, "ASSESS_ID"));

                    if (owner.Rows.Count == 0 || assess.Rows.Count == 0)
                    {
                        //SQL sql = new SQL(@"
                        //    use accelastage;
                        //    insert into AATable_Permit_People
                        //    (
                        //    PERMITNUM
                        //    )
                        //    values (
                        //    @PERMITNUM
                        //    )");
                        //sql.AddParameter("@PERMITNUM", g(bp, i, "APPLICATION_NUMBER"));
                        //sql.Run();
                    }
                    else
                    {
                        SQL sql = new SQL(@"
                        use accelastage;
                        insert into AATable_Permit_People
                        (
                        PERMITNUM,
                        TT_CONTACT_TYPE,
                        ISPRIMARY,
                        LIC_NUM,
                        LIC_TYPE,
                        NAME,
                        FNAME,
                        MNAME,
                        LNAME,
                        BUS_NAME,
                        ADDR1,
                        ADDR2,
                        ADDR3,
                        CITY,
                        STATE,
                        ZIP,
                        PH1,
                        PH2,
                        FAX,
                        EMAIL,
                        COMMENTS,
                        TITLE,
                        PH3,
                        COUNTRY_CODE,
                        NOTIFY,
                        NAME_SUFFIX,
                        BUS_LIC,
                        LIC_ORIGINAL_ISSUE_DATE,
                        EXPIRATION_DATE,
                        RENEWAL_DATE,
                        MAIL_ADDR1,
                        MAIL_ADDR2,
                        MAIL_ADDR3,
                        MAIL_CITY,
                        MAIL_STATE,
                        MAIL_ZIP,
                        MAIL_COUNTRY,
                        OWNER_TYPE,
                        GENDER,
                        SALUTATION,
                        PO_BOX,
                        BUS_NAME2,
                        BIRTH_DATE,
                        PH1_COUNTRY_CODE,
                        PH2_COUNTRY_CODE,
                        PH3_COUNTRY_CODE,
                        FAX_COUNTRY_CODE,
                        TRADE_NAME,
                        CONTACT_TYPE_FLAG,
                        SOCIAL_SECURITY_NUMBER,
                        FEDERAL_EMPLOYER_ID_NUM,
                        CONTRA_TYPE_FLAG,
                        LIC_BOARD,
                        B1_ID,
                        CONT_LIC_BUS_NAME,
                        B1_ACCESS_LEVEL,
                        BIRTH_CITY,
                        BIRTH_STATE,
                        BIRTH_REGION,
                        RACE,
                        DECEASED_DATE,
                        PASSPORT_NBR,
                        DRIVER_LIC_NBR,
                        DRIVER_LIC_STATE,
                        STATE_ID_NBR,
                        B1_CONTACT_NBR,
                        G1_CONTACT_NBR
                        )
                        values (
                        @PERMITNUM,
                        @TT_CONTACT_TYPE,
                        @ISPRIMARY,
                        @LIC_NUM,
                        @LIC_TYPE,
                        @NAME,
                        @FNAME,
                        @MNAME,
                        @LNAME,
                        @BUS_NAME,
                        @ADDR1,
                        @ADDR2,
                        @ADDR3,
                        @CITY,
                        @STATE,
                        @ZIP,
                        @PH1,
                        @PH2,
                        @FAX,
                        @EMAIL,
                        @COMMENTS,
                        @TITLE,
                        @PH3,
                        @COUNTRY_CODE,
                        @NOTIFY,
                        @NAME_SUFFIX,
                        @BUS_LIC,
                        @LIC_ORIGINAL_ISSUE_DATE,
                        @EXPIRATION_DATE,
                        @RENEWAL_DATE,
                        @MAIL_ADDR1,
                        @MAIL_ADDR2,
                        @MAIL_ADDR3,
                        @MAIL_CITY,
                        @MAIL_STATE,
                        @MAIL_ZIP,
                        @MAIL_COUNTRY,
                        @OWNER_TYPE,
                        @GENDER,
                        @SALUTATION,
                        @PO_BOX,
                        @BUS_NAME2,
                        @BIRTH_DATE,
                        @PH1_COUNTRY_CODE,
                        @PH2_COUNTRY_CODE,
                        @PH3_COUNTRY_CODE,
                        @FAX_COUNTRY_CODE,
                        @TRADE_NAME,
                        @CONTACT_TYPE_FLAG,
                        @SOCIAL_SECURITY_NUMBER,
                        @FEDERAL_EMPLOYER_ID_NUM,
                        @CONTRA_TYPE_FLAG,
                        @LIC_BOARD,
                        @B1_ID,
                        @CONT_LIC_BUS_NAME,
                        @B1_ACCESS_LEVEL,
                        @BIRTH_CITY,
                        @BIRTH_STATE,
                        @BIRTH_REGION,
                        @RACE,
                        @DECEASED_DATE,
                        @PASSPORT_NBR,
                        @DRIVER_LIC_NBR,
                        @DRIVER_LIC_STATE,
                        @STATE_ID_NBR,
                        @B1_CONTACT_NBR,
                        @G1_CONTACT_NBR
                        )");
                        sql.AddParameter("@PERMITNUM", g(bp, i, "APPLICATION_NUMBER"));
                        sql.AddParameter("@TT_CONTACT_TYPE", "Owner");
                        sql.AddParameter("@ISPRIMARY", "Y");
                        sql.AddParameter("@LIC_NUM", DBNull.Value);
                        sql.AddParameter("@LIC_TYPE", DBNull.Value);

                        string first = "N/A";
                        string last = "N/A";
                        string full = g(owner, 0, "NAME").Trim();

                        if (full == "")
                            full = "N/A";

                        if (full.Contains(' '))
                        {
                            int space = full.IndexOf(' ');
                            last = full.Substring(0, space);
                            first = full.Substring(space);
                        }

                        sql.AddParameter("@NAME", full);
                        sql.AddParameter("@FNAME", first);
                        sql.AddParameter("@MNAME", DBNull.Value);
                        sql.AddParameter("@LNAME", last);
                        sql.AddParameter("@BUS_NAME", DBNull.Value);

                        string a1 = "";
                        string a2 = "";

                        if (g(assess, 0, "STREET_NUMBER") != "")
                            a1 += g(assess, 0, "STREET_NUMBER") + " ";

                        if (g(assess, 0, "STREET_NAME") != "")
                            a1 += g(assess, 0, "STREET_NAME") + " ";

                        if (g(assess, 0, "UNIT_NUMBER") != "")
                            a1 += "Unit " + g(assess, 0, "UNIT_NUMBER") + " ";

                        string s = g(assess, 0, "CITY_PROV_COUNTRY").Trim();
                        string city = "";
                        string state = "";

                        if (s.Contains(" ON"))
                        {
                            city = s.Replace(" ON", "").Trim();
                            state = "ON";
                        }
                        else if (s.Contains(' '))
                        {
                            string[] x = s.Split(' ');

                            city = s.Replace(x[x.Length - 1], "").Trim();
                            state = x[x.Length - 1];
                        }

                        if (city != "")
                            a1 += city;

                        if (g(assess, 0, "POSTAL_CODE") != "")
                            a2 += g(assess, 0, "POSTAL_CODE") + " ";

                        if (state != "")
                            a2 += state;

                        full = full.Trim();
                        a1 = a1.Trim();
                        a2 = a2.Trim();

                        sql.AddParameter("@ADDR1", a1);
                        sql.AddParameter("@ADDR2", a2);
                        sql.AddParameter("@ADDR3", DBNull.Value);

                        /////////////////

                        if (s == "SEE OWNER")
                        {
                            sql.AddParameter("@CITY", DBNull.Value);
                            sql.AddParameter("@STATE", DBNull.Value);
                        }
                        else if (s.Contains(" ON"))
                        {
                            sql.AddParameter("@CITY", city);
                            sql.AddParameter("@STATE", state);
                        }
                        else if (s.Contains(' '))
                        {
                            sql.AddParameter("@CITY", city);
                            sql.AddParameter("@STATE", state);
                        }
                        else
                        {
                            sql.AddParameter("@CITY", DBNull.Value);
                            sql.AddParameter("@STATE", DBNull.Value);
                        }

                        sql.AddParameter("@ZIP", g(assess, 0, "POSTAL_CODE"));
                        sql.AddParameter("@PH1", g(owner, 0, "PHONENUMBER"));
                        sql.AddParameter("@PH2", DBNull.Value);
                        sql.AddParameter("@FAX", DBNull.Value);
                        sql.AddParameter("@EMAIL", DBNull.Value);
                        sql.AddParameter("@COMMENTS", DBNull.Value);
                        sql.AddParameter("@TITLE", DBNull.Value);
                        sql.AddParameter("@PH3", DBNull.Value);
                        sql.AddParameter("@COUNTRY_CODE", DBNull.Value);
                        sql.AddParameter("@NOTIFY", DBNull.Value);
                        sql.AddParameter("@NAME_SUFFIX", DBNull.Value);
                        sql.AddParameter("@BUS_LIC", DBNull.Value);
                        sql.AddParameter("@LIC_ORIGINAL_ISSUE_DATE", DBNull.Value);
                        sql.AddParameter("@EXPIRATION_DATE", DBNull.Value);
                        sql.AddParameter("@RENEWAL_DATE", DBNull.Value);
                        sql.AddParameter("@MAIL_ADDR1", DBNull.Value);
                        sql.AddParameter("@MAIL_ADDR2", DBNull.Value);
                        sql.AddParameter("@MAIL_ADDR3", DBNull.Value);
                        sql.AddParameter("@MAIL_CITY", DBNull.Value);
                        sql.AddParameter("@MAIL_STATE", DBNull.Value);
                        sql.AddParameter("@MAIL_ZIP", DBNull.Value);
                        sql.AddParameter("@MAIL_COUNTRY", DBNull.Value);
                        sql.AddParameter("@OWNER_TYPE", DBNull.Value);
                        sql.AddParameter("@GENDER", DBNull.Value);
                        sql.AddParameter("@SALUTATION", DBNull.Value);
                        sql.AddParameter("@PO_BOX", DBNull.Value);
                        sql.AddParameter("@BUS_NAME2", DBNull.Value);
                        sql.AddParameter("@BIRTH_DATE", DBNull.Value);
                        sql.AddParameter("@PH1_COUNTRY_CODE", DBNull.Value);
                        sql.AddParameter("@PH2_COUNTRY_CODE", DBNull.Value);
                        sql.AddParameter("@PH3_COUNTRY_CODE", DBNull.Value);
                        sql.AddParameter("@FAX_COUNTRY_CODE", DBNull.Value);
                        sql.AddParameter("@TRADE_NAME", DBNull.Value);
                        sql.AddParameter("@CONTACT_TYPE_FLAG", "Individual");
                        sql.AddParameter("@SOCIAL_SECURITY_NUMBER", DBNull.Value);
                        sql.AddParameter("@FEDERAL_EMPLOYER_ID_NUM", DBNull.Value);
                        sql.AddParameter("@CONTRA_TYPE_FLAG", DBNull.Value);
                        sql.AddParameter("@LIC_BOARD", DBNull.Value);
                        sql.AddParameter("@B1_ID", DBNull.Value);
                        sql.AddParameter("@CONT_LIC_BUS_NAME", DBNull.Value);
                        sql.AddParameter("@B1_ACCESS_LEVEL", DBNull.Value);
                        sql.AddParameter("@BIRTH_CITY", DBNull.Value);
                        sql.AddParameter("@BIRTH_STATE", DBNull.Value);
                        sql.AddParameter("@BIRTH_REGION", DBNull.Value);
                        sql.AddParameter("@RACE", DBNull.Value);
                        sql.AddParameter("@DECEASED_DATE", DBNull.Value);
                        sql.AddParameter("@PASSPORT_NBR", DBNull.Value);
                        sql.AddParameter("@DRIVER_LIC_NBR", DBNull.Value);
                        sql.AddParameter("@DRIVER_LIC_STATE", DBNull.Value);
                        sql.AddParameter("@STATE_ID_NBR", DBNull.Value);
                        sql.AddParameter("@B1_CONTACT_NBR", DBNull.Value);
                        sql.AddParameter("@G1_CONTACT_NBR", DBNull.Value);

                        if (g(bp, i, "APPLICATION_NUMBER") != "")
                            sql.Run();

                        addNumber("Owner", first, last, full, a1, city, state, g(assess, 0, "POSTAL_CODE"), g(owner, 0, "PHONENUMBER"), "", "", "");
                    }
                }

                //Enter owner into AATable_Permit_People from violations
                /* 20190613 vi
                for (int i = 0; i < vi.Rows.Count; i++)
                {
                    DataTable vt = Vailtech.Run("select * from vailtech.cv_tx_roll where roll_no = @ID", g(vi, i, "ROLL_NUM"));

                    if (vt.Rows.Count == 0)
                    {
                        //SQL sql = new SQL(@"
                        //    use accelastage;
                        //    insert into AATable_Permit_People
                        //    (
                        //    PERMITNUM
                        //    )
                        //    values (
                        //    @PERMITNUM
                        //    )");
                        //sql.AddParameter("@PERMITNUM", g(vi, i, "VIOLATION_ID"));
                        //sql.Run();
                    }
                    else
                    {
                        SQL sql = new SQL(@"
                        use accelastage;
                        insert into AATable_Permit_People
                        (
                        PERMITNUM,
                        TT_CONTACT_TYPE,
                        ISPRIMARY,
                        LIC_NUM,
                        LIC_TYPE,
                        NAME,
                        FNAME,
                        MNAME,
                        LNAME,
                        BUS_NAME,
                        ADDR1,
                        ADDR2,
                        ADDR3,
                        CITY,
                        STATE,
                        ZIP,
                        PH1,
                        PH2,
                        FAX,
                        EMAIL,
                        COMMENTS,
                        TITLE,
                        PH3,
                        COUNTRY_CODE,
                        NOTIFY,
                        NAME_SUFFIX,
                        BUS_LIC,
                        LIC_ORIGINAL_ISSUE_DATE,
                        EXPIRATION_DATE,
                        RENEWAL_DATE,
                        MAIL_ADDR1,
                        MAIL_ADDR2,
                        MAIL_ADDR3,
                        MAIL_CITY,
                        MAIL_STATE,
                        MAIL_ZIP,
                        MAIL_COUNTRY,
                        OWNER_TYPE,
                        GENDER,
                        SALUTATION,
                        PO_BOX,
                        BUS_NAME2,
                        BIRTH_DATE,
                        PH1_COUNTRY_CODE,
                        PH2_COUNTRY_CODE,
                        PH3_COUNTRY_CODE,
                        FAX_COUNTRY_CODE,
                        TRADE_NAME,
                        CONTACT_TYPE_FLAG,
                        SOCIAL_SECURITY_NUMBER,
                        FEDERAL_EMPLOYER_ID_NUM,
                        CONTRA_TYPE_FLAG,
                        LIC_BOARD,
                        B1_ID,
                        CONT_LIC_BUS_NAME,
                        B1_ACCESS_LEVEL,
                        BIRTH_CITY,
                        BIRTH_STATE,
                        BIRTH_REGION,
                        RACE,
                        DECEASED_DATE,
                        PASSPORT_NBR,
                        DRIVER_LIC_NBR,
                        DRIVER_LIC_STATE,
                        STATE_ID_NBR,
                        B1_CONTACT_NBR,
                        G1_CONTACT_NBR
                        )
                        values (
                        @PERMITNUM,
                        @TT_CONTACT_TYPE,
                        @ISPRIMARY,
                        @LIC_NUM,
                        @LIC_TYPE,
                        @NAME,
                        @FNAME,
                        @MNAME,
                        @LNAME,
                        @BUS_NAME,
                        @ADDR1,
                        @ADDR2,
                        @ADDR3,
                        @CITY,
                        @STATE,
                        @ZIP,
                        @PH1,
                        @PH2,
                        @FAX,
                        @EMAIL,
                        @COMMENTS,
                        @TITLE,
                        @PH3,
                        @COUNTRY_CODE,
                        @NOTIFY,
                        @NAME_SUFFIX,
                        @BUS_LIC,
                        @LIC_ORIGINAL_ISSUE_DATE,
                        @EXPIRATION_DATE,
                        @RENEWAL_DATE,
                        @MAIL_ADDR1,
                        @MAIL_ADDR2,
                        @MAIL_ADDR3,
                        @MAIL_CITY,
                        @MAIL_STATE,
                        @MAIL_ZIP,
                        @MAIL_COUNTRY,
                        @OWNER_TYPE,
                        @GENDER,
                        @SALUTATION,
                        @PO_BOX,
                        @BUS_NAME2,
                        @BIRTH_DATE,
                        @PH1_COUNTRY_CODE,
                        @PH2_COUNTRY_CODE,
                        @PH3_COUNTRY_CODE,
                        @FAX_COUNTRY_CODE,
                        @TRADE_NAME,
                        @CONTACT_TYPE_FLAG,
                        @SOCIAL_SECURITY_NUMBER,
                        @FEDERAL_EMPLOYER_ID_NUM,
                        @CONTRA_TYPE_FLAG,
                        @LIC_BOARD,
                        @B1_ID,
                        @CONT_LIC_BUS_NAME,
                        @B1_ACCESS_LEVEL,
                        @BIRTH_CITY,
                        @BIRTH_STATE,
                        @BIRTH_REGION,
                        @RACE,
                        @DECEASED_DATE,
                        @PASSPORT_NBR,
                        @DRIVER_LIC_NBR,
                        @DRIVER_LIC_STATE,
                        @STATE_ID_NBR,
                        @B1_CONTACT_NBR,
                        @G1_CONTACT_NBR
                        )");
                        sql.AddParameter("@PERMITNUM", g(vi, i, "VIOLATION_ID"));
                        sql.AddParameter("@TT_CONTACT_TYPE", "Owner");
                        sql.AddParameter("@ISPRIMARY", "Y");
                        sql.AddParameter("@LIC_NUM", DBNull.Value);
                        sql.AddParameter("@LIC_TYPE", DBNull.Value);

                        string first = "N/A";
                        string last = "N/A";
                        string full = g(vt, 0, "OWNER_1").Trim();

                        if (full == "")
                            full = "N/A";

                        if (full.Contains(' '))
                        {
                            int space = full.IndexOf(' ');
                            last = full.Substring(0, space);
                            first = full.Substring(space);
                        }

                        sql.AddParameter("@NAME", full);
                        sql.AddParameter("@FNAME", first);
                        sql.AddParameter("@MNAME", DBNull.Value);
                        sql.AddParameter("@LNAME", last);
                        sql.AddParameter("@BUS_NAME", DBNull.Value);

                        string a1 = "";
                        string a2 = "";

                        if (g(vt, 0, "STREET_NO") != "")
                            a1 += g(vt, 0, "STREET_NO") + " ";

                        if (g(vt, 0, "STREET_NAME") != "")
                            a1 += g(vt, 0, "STREET_NAME") + " ";

                        if (g(vt, 0, "STREET_UNIT") != "")
                            a1 += "Unit " + g(vt, 0, "STREET_UNIT") + " ";

                        string s = g(vt, 0, "MAILING4").Trim();
                        string city = "";
                        string state = "";

                        if (s.Contains(" ON"))
                        {
                            city = s.Replace(" ON", "").Trim();
                            state = "ON";
                        }
                        else if (s.Contains(' '))
                        {
                            string[] x = s.Split(' ');

                            city = s.Replace(x[x.Length - 1], "").Trim();
                            state = x[x.Length - 1];
                        }

                        if (city != "")
                            a1 += city;

                        if (g(vt, 0, "MAILING5") != "")
                            a2 += g(vt, 0, "MAILING5") + " ";

                        if (state != "")
                            a2 += state;

                        full = full.Trim();
                        a1 = a1.Trim();
                        a2 = a2.Trim();

                        sql.AddParameter("@ADDR1", a1);
                        sql.AddParameter("@ADDR2", a2);
                        sql.AddParameter("@ADDR3", DBNull.Value);

                        /////////////////

                        if (s == "SEE OWNER")
                        {
                            sql.AddParameter("@CITY", DBNull.Value);
                            sql.AddParameter("@STATE", DBNull.Value);
                        }
                        else if (s.Contains(" ON"))
                        {
                            sql.AddParameter("@CITY", city);
                            sql.AddParameter("@STATE", state);
                        }
                        else if (s.Contains(' '))
                        {
                            sql.AddParameter("@CITY", city);
                            sql.AddParameter("@STATE", state);
                        }
                        else
                        {
                            sql.AddParameter("@CITY", DBNull.Value);
                            sql.AddParameter("@STATE", DBNull.Value);
                        }

                        sql.AddParameter("@ZIP", g(vt, 0, "MAILING5"));
                        sql.AddParameter("@PH1", DBNull.Value);
                        sql.AddParameter("@PH2", DBNull.Value);
                        sql.AddParameter("@FAX", DBNull.Value);
                        sql.AddParameter("@EMAIL", DBNull.Value);
                        sql.AddParameter("@COMMENTS", DBNull.Value);
                        sql.AddParameter("@TITLE", DBNull.Value);
                        sql.AddParameter("@PH3", DBNull.Value);
                        sql.AddParameter("@COUNTRY_CODE", DBNull.Value);
                        sql.AddParameter("@NOTIFY", DBNull.Value);
                        sql.AddParameter("@NAME_SUFFIX", DBNull.Value);
                        sql.AddParameter("@BUS_LIC", DBNull.Value);
                        sql.AddParameter("@LIC_ORIGINAL_ISSUE_DATE", DBNull.Value);
                        sql.AddParameter("@EXPIRATION_DATE", DBNull.Value);
                        sql.AddParameter("@RENEWAL_DATE", DBNull.Value);
                        sql.AddParameter("@MAIL_ADDR1", g(vt, 0, "MAILING1"));
                        sql.AddParameter("@MAIL_ADDR2", g(vt, 0, "MAILING2"));
                        sql.AddParameter("@MAIL_ADDR3", g(vt, 0, "MAILING3"));
                        sql.AddParameter("@MAIL_CITY", city);
                        sql.AddParameter("@MAIL_STATE", state);
                        sql.AddParameter("@MAIL_ZIP", g(vt, 0, "MAILING5"));
                        sql.AddParameter("@MAIL_COUNTRY", DBNull.Value);
                        sql.AddParameter("@OWNER_TYPE", DBNull.Value);
                        sql.AddParameter("@GENDER", DBNull.Value);
                        sql.AddParameter("@SALUTATION", DBNull.Value);
                        sql.AddParameter("@PO_BOX", DBNull.Value);
                        sql.AddParameter("@BUS_NAME2", DBNull.Value);
                        sql.AddParameter("@BIRTH_DATE", DBNull.Value);
                        sql.AddParameter("@PH1_COUNTRY_CODE", DBNull.Value);
                        sql.AddParameter("@PH2_COUNTRY_CODE", DBNull.Value);
                        sql.AddParameter("@PH3_COUNTRY_CODE", DBNull.Value);
                        sql.AddParameter("@FAX_COUNTRY_CODE", DBNull.Value);
                        sql.AddParameter("@TRADE_NAME", DBNull.Value);
                        sql.AddParameter("@CONTACT_TYPE_FLAG", "Individual");
                        sql.AddParameter("@SOCIAL_SECURITY_NUMBER", DBNull.Value);
                        sql.AddParameter("@FEDERAL_EMPLOYER_ID_NUM", DBNull.Value);
                        sql.AddParameter("@CONTRA_TYPE_FLAG", DBNull.Value);
                        sql.AddParameter("@LIC_BOARD", DBNull.Value);
                        sql.AddParameter("@B1_ID", DBNull.Value);
                        sql.AddParameter("@CONT_LIC_BUS_NAME", DBNull.Value);
                        sql.AddParameter("@B1_ACCESS_LEVEL", DBNull.Value);
                        sql.AddParameter("@BIRTH_CITY", DBNull.Value);
                        sql.AddParameter("@BIRTH_STATE", DBNull.Value);
                        sql.AddParameter("@BIRTH_REGION", DBNull.Value);
                        sql.AddParameter("@RACE", DBNull.Value);
                        sql.AddParameter("@DECEASED_DATE", DBNull.Value);
                        sql.AddParameter("@PASSPORT_NBR", DBNull.Value);
                        sql.AddParameter("@DRIVER_LIC_NBR", DBNull.Value);
                        sql.AddParameter("@DRIVER_LIC_STATE", DBNull.Value);
                        sql.AddParameter("@STATE_ID_NBR", DBNull.Value);
                        sql.AddParameter("@B1_CONTACT_NBR", DBNull.Value);
                        sql.AddParameter("@G1_CONTACT_NBR", nextRefer);
                        sql.Run();

                        addNumber("Owner", first, last, full, a1, city, state, g(vt, 0, "MAILING5"), "", "", "", "");
                    }
                } vi */

                //Enter contractor into AATable_Permit_People
                for (int i = 0; i < bp.Rows.Count; i++)
                {
                    DataTable con = CityView.Run("select * from sysadmin.lookupcontractors where code = @ID", g(bp, i, "CLIENT_BUILDER"));

                    if (con.Rows.Count > 0)
                    {
                        SQL sql = new SQL(@"
            use accelastage;
            insert into AATable_Permit_People
            (
            PERMITNUM,
            TT_CONTACT_TYPE,
            ISPRIMARY,
            LIC_NUM,
            LIC_TYPE,
            NAME,
            FNAME,
            LNAME,
            BUS_NAME,
            ADDR1,
            ADDR2,
            ADDR3,
            CITY,
            STATE,
            ZIP,
            PH1,
            COMMENTS,
            TITLE,
            BUS_LIC,
            CONTACT_TYPE_FLAG,
            G1_CONTACT_NBR
            )
            values (
            @PERMITNUM,
            @TT_CONTACT_TYPE,
            @ISPRIMARY,
            @LIC_NUM,
            @LIC_TYPE,
            @NAME,
            @FNAME,
            @LNAME,
            @BUS_NAME,
            @ADDR1,
            @ADDR2,
            @ADDR3,
            @CITY,
            @STATE,
            @ZIP,
            @PH1,
            @COMMENTS,
            @TITLE,
            @BUS_LIC,
            @CONTACT_TYPE_FLAG,
            @G1_CONTACT_NBR
            )");
                        sql.AddParameter("@PERMITNUM", g(bp, i, "APPLICATION_NUMBER"));
                        sql.AddParameter("@TT_CONTACT_TYPE", "Contractor (Builder)");
                        sql.AddParameter("@ISPRIMARY", "Y");
                        sql.AddParameter("@LIC_NUM", DBNull.Value);
                        sql.AddParameter("@LIC_TYPE", DBNull.Value);

                        string first = "N/A";
                        string last = "N/A";
                        string full = g(con, 0, "CONTACT_NAME").Trim();

                        if (full == "")
                            full = "N/A";

                        if (full.Contains(' '))
                        {
                            int space = full.IndexOf(' ');
                            last = full.Substring(0, space);
                            first = full.Substring(space);
                        }

                        sql.AddParameter("@NAME", full);
                        sql.AddParameter("@FNAME", first);
                        sql.AddParameter("@LNAME", last);
                        sql.AddParameter("@BUS_NAME", DBNull.Value);
                        sql.AddParameter("@ADDR1", g(con, 0, "ADDRESS"));
                        sql.AddParameter("@ADDR2", DBNull.Value);
                        sql.AddParameter("@ADDR3", DBNull.Value);
                        sql.AddParameter("@CITY", g(con, 0, "CITY"));
                        sql.AddParameter("@STATE", g(con, 0, "PROVINCE"));
                        sql.AddParameter("@ZIP", g(con, 0, "POSTAL"));
                        sql.AddParameter("@PH1", g(con, 0, "PHONE"));
                        sql.AddParameter("@COMMENTS", g(con, 0, "DESCRIPTION"));
                        sql.AddParameter("@TITLE", "Builder");
                        sql.AddParameter("@BUS_LIC", g(con, 0, "LICENSENUMBER"));
                        sql.AddParameter("@CONTACT_TYPE_FLAG", "Individual");
                        sql.AddParameter("@G1_CONTACT_NBR", DBNull.Value);

                        if (g(bp, i, "APPLICATION_NUMBER") != "")
                            sql.Run();

                        addNumber("Contractor (Builder)", first, last, full, g(con, 0, "ADDRESS"), g(con, 0, "CITY"), g(con, 0, "PROVINCE"), g(con, 0, "POSTAL"), g(con, 0, "PHONE"), "", "", "");
                    }

                    con = CityView.Run("select * from sysadmin.lookupcontractors where code = @ID", g(bp, i, "CLIENT_PLUMBER"));

                    if (con.Rows.Count > 0)
                    {
                        SQL sql = new SQL(@"
            use accelastage;
            insert into AATable_Permit_People
            (
            PERMITNUM,
            TT_CONTACT_TYPE,
            ISPRIMARY,
            LIC_NUM,
            LIC_TYPE,
            NAME,
            FNAME,
            LNAME,
            BUS_NAME,
            ADDR1,
            ADDR2,
            ADDR3,
            CITY,
            STATE,
            ZIP,
            PH1,
            COMMENTS,
            TITLE,
            BUS_LIC,
            CONTACT_TYPE_FLAG,
            G1_CONTACT_NBR
            )
            values (
            @PERMITNUM,
            @TT_CONTACT_TYPE,
            @ISPRIMARY,
            @LIC_NUM,
            @LIC_TYPE,
            @NAME,
            @FNAME,
            @LNAME,
            @BUS_NAME,
            @ADDR1,
            @ADDR2,
            @ADDR3,
            @CITY,
            @STATE,
            @ZIP,
            @PH1,
            @COMMENTS,
            @TITLE,
            @BUS_LIC,
            @CONTACT_TYPE_FLAG,
            @G1_CONTACT_NBR
            )");
                        sql.AddParameter("@PERMITNUM", g(bp, i, "APPLICATION_NUMBER"));
                        sql.AddParameter("@TT_CONTACT_TYPE", "Contractor (Plumber)");
                        sql.AddParameter("@ISPRIMARY", "Y");
                        sql.AddParameter("@LIC_NUM", DBNull.Value);
                        sql.AddParameter("@LIC_TYPE", DBNull.Value);

                        string first = "N/A";
                        string last = "N/A";
                        string full = g(con, 0, "CONTACT_NAME").Trim();

                        if (full == "")
                            full = "N/A";

                        if (full.Contains(' '))
                        {
                            int space = full.IndexOf(' ');
                            last = full.Substring(0, space);
                            first = full.Substring(space);
                        }

                        sql.AddParameter("@NAME", full);
                        sql.AddParameter("@FNAME", first);
                        sql.AddParameter("@LNAME", last);
                        sql.AddParameter("@BUS_NAME", DBNull.Value);
                        sql.AddParameter("@ADDR1", g(con, 0, "ADDRESS"));
                        sql.AddParameter("@ADDR2", DBNull.Value);
                        sql.AddParameter("@ADDR3", DBNull.Value);
                        sql.AddParameter("@CITY", g(con, 0, "CITY"));
                        sql.AddParameter("@STATE", g(con, 0, "PROVINCE"));
                        sql.AddParameter("@ZIP", g(con, 0, "POSTAL"));
                        sql.AddParameter("@PH1", g(con, 0, "PHONE"));
                        sql.AddParameter("@COMMENTS", g(con, 0, "DESCRIPTION"));
                        sql.AddParameter("@TITLE", "Plumber");
                        sql.AddParameter("@BUS_LIC", g(con, 0, "LICENSENUMBER"));
                        sql.AddParameter("@CONTACT_TYPE_FLAG", "Individual");
                        sql.AddParameter("@G1_CONTACT_NBR", DBNull.Value);

                        if (g(bp, i, "APPLICATION_NUMBER") != "")
                            sql.Run();

                        addNumber("Contractor (Plumber)", first, last, full, g(con, 0, "ADDRESS"), g(con, 0, "CITY"), g(con, 0, "PROVINCE"), g(con, 0, "POSTAL"), g(con, 0, "PHONE"), "", "", "");
                    }

                    con = CityView.Run("select * from sysadmin.lookupcontractors where code = @ID", g(bp, i, "CLIENT_DRAIN"));

                    if (con.Rows.Count > 0)
                    {
                        SQL sql = new SQL(@"
            use accelastage;
            insert into AATable_Permit_People
            (
            PERMITNUM,
            TT_CONTACT_TYPE,
            ISPRIMARY,
            LIC_NUM,
            LIC_TYPE,
            NAME,
            FNAME,
            LNAME,
            BUS_NAME,
            ADDR1,
            ADDR2,
            ADDR3,
            CITY,
            STATE,
            ZIP,
            PH1,
            COMMENTS,
            TITLE,
            BUS_LIC,
            CONTACT_TYPE_FLAG,
            G1_CONTACT_NBR
            )
            values (
            @PERMITNUM,
            @TT_CONTACT_TYPE,
            @ISPRIMARY,
            @LIC_NUM,
            @LIC_TYPE,
            @NAME,
            @FNAME,
            @LNAME,
            @BUS_NAME,
            @ADDR1,
            @ADDR2,
            @ADDR3,
            @CITY,
            @STATE,
            @ZIP,
            @PH1,
            @COMMENTS,
            @TITLE,
            @BUS_LIC,
            @CONTACT_TYPE_FLAG,
            @G1_CONTACT_NBR
            )");
                        sql.AddParameter("@PERMITNUM", g(bp, i, "APPLICATION_NUMBER"));
                        sql.AddParameter("@TT_CONTACT_TYPE", "Contractor (Drain)");
                        sql.AddParameter("@ISPRIMARY", "Y");
                        sql.AddParameter("@LIC_NUM", DBNull.Value);
                        sql.AddParameter("@LIC_TYPE", DBNull.Value);

                        string first = "N/A";
                        string last = "N/A";
                        string full = g(con, 0, "CONTACT_NAME").Trim();

                        if (full == "")
                            full = "N/A";

                        if (full.Contains(' '))
                        {
                            int space = full.IndexOf(' ');
                            last = full.Substring(0, space);
                            first = full.Substring(space);
                        }

                        sql.AddParameter("@NAME", full);
                        sql.AddParameter("@FNAME", first);
                        sql.AddParameter("@LNAME", last);
                        sql.AddParameter("@BUS_NAME", DBNull.Value);
                        sql.AddParameter("@ADDR1", g(con, 0, "ADDRESS"));
                        sql.AddParameter("@ADDR2", DBNull.Value);
                        sql.AddParameter("@ADDR3", DBNull.Value);
                        sql.AddParameter("@CITY", g(con, 0, "CITY"));
                        sql.AddParameter("@STATE", g(con, 0, "PROVINCE"));
                        sql.AddParameter("@ZIP", g(con, 0, "POSTAL"));
                        sql.AddParameter("@PH1", g(con, 0, "PHONE"));
                        sql.AddParameter("@COMMENTS", g(con, 0, "DESCRIPTION"));
                        sql.AddParameter("@TITLE", "Drain");
                        sql.AddParameter("@BUS_LIC", g(con, 0, "LICENSENUMBER"));
                        sql.AddParameter("@CONTACT_TYPE_FLAG", "Individual");
                        sql.AddParameter("@G1_CONTACT_NBR", DBNull.Value);

                        if (g(bp, i, "APPLICATION_NUMBER") != "")
                            sql.Run();

                        addNumber("Contractor (Drain)", first, last, full, g(con, 0, "ADDRESS"), g(con, 0, "CITY"), g(con, 0, "PROVINCE"), g(con, 0, "POSTAL"), g(con, 0, "PHONE"), "", "", "");
                    }
                }
            }

            Console.WriteLine("Finished. The time is currently " + DateTime.Now.ToString() + ".");

            Core.sendMail("ealarcon@newmarket.ca", "CityViewtoAccelaDataPort", "Transfer completed at:" + DateTime.Now.ToString());
        } //End constructor

        void addNumber(string contactType, string firstName, string lastName, string fullName, string address, string city, string state, string zip, string ph1, string ph2, string fax, string email)
        {
            //            SQL sql = new SQL(@"
            //use accelastage;
            //insert into AATABLE_REFER_PEOPLE
            //(
            //CONTACT_NBR
            //,CONTACT_TYPE
            //,FNAME
            //,LNAME
            //,FULL_NAME
            //,ADDR1
            //,CITY
            //,STATE
            //,ZIP
            //,PH1
            //,PH2
            //,FAX
            //,EMAIL
            //,G1_ID
            //,CONTACT_TYPE_FLAG
            //)
            //values
            //(
            //@CONTACT_NBR
            //,@CONTACT_TYPE
            //,@FNAME
            //,@LNAME
            //,@FULL_NAME
            //,@ADDR1
            //,@CITY
            //,@STATE
            //,@ZIP
            //,@PH1
            //,@PH2
            //,@FAX
            //,@EMAIL
            //,@G1_ID
            //,@CONTACT_TYPE_FLAG
            //)
            //");
            //            sql.AddParameter("@CONTACT_NBR", nextRefer);
            //            sql.AddParameter("@CONTACT_TYPE", contactType);
            //            sql.AddParameter("@FNAME", firstName);
            //            sql.AddParameter("@LNAME", lastName);
            //            sql.AddParameter("@FULL_NAME", fullName);
            //            sql.AddParameter("@ADDR1", address);
            //            sql.AddParameter("@CITY", city);
            //            sql.AddParameter("@STATE", state);
            //            sql.AddParameter("@ZIP", zip);
            //            sql.AddParameter("@PH1", ph1);
            //            sql.AddParameter("@PH2", ph2);
            //            sql.AddParameter("@FAX", fax);
            //            sql.AddParameter("@EMAIL", email);
            //            sql.AddParameter("@G1_ID", nextRefer);
            //            sql.AddParameter("@CONTACT_TYPE_FLAG", "Individual");
            //            sql.Run();

            //            nextRefer++;
        }
    } //End class
} //End namespace
