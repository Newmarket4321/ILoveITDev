using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace I_IT
{
    public partial class Form1 : Form
    {
        string search = "";
        List<ScreenItem> itemBackup = new List<ScreenItem>();

        public Form1()
        {
            InitializeComponent();

//            Report r = new Report("PAP B Report", Vailtech.Run(@"
//select * from ('010030227000000', '040185690150000', '020111930000000', '040196346350000', '010020059160000', '040161181290000', '040196640070000', '040172362740000', '040172370860000', '040155272000000', '040185690250000', '040196355180000', '040161359090000', '040161180720000', '040172360200000', '040187508520000', '040185450230000', '010050407140000', '030120208000000', '040186152160000', '040186222540000', '040186559080000', '040186562760000', '030130773000000', '040187625940000', '040204363060000', '040187509840000', '040205390130000', '040186475600000', '040204394680000', '040185286140000', '040198630020000', '040187007880000', '040186858080000', '040161402200000', '040185457740000', '040171344000000', '020070678000000', '040185285840000', '040187005640000', '040187015430000', '040187623470000', '040187625500000', '040196346100000', '040196346660000', '040186475170000', '010050274360000', '040205385340000', '020111767000000', '040205390470000', '040205380160000', '040185701260000', '040204357880000', '040198551570000', '040202672380000', '040204153050000', '040166057020000', '040170550000000', '040204399160000', '040186562900000', '020061119000000', '020061577500000', '020112264000000', '030140636000000', '030141158000000', '040156804140000', '040158910000000', '040159388000000', '040160825070000', '040160827510000', '040205991150000', '010020063000000', '010020082000000', '010050275080000', '040154069680000', '040154071220000', '040158808000000', '040161181750000', '010040120320000', '020100564000000', '010050403920000', '030140052000000', '010043162000000', '040161170370000', '040162600840000', '040161353770000', '010040540110000', '040161173190000', '040205991430000', '010040465000000', '010050246470000', '010050264000000', '010050276360000', '040161178750000', '040161360370000', '040161355840000', '040154074700000', '030130315090000', '040205367880000', '040197643120000', '040171178000000', '030141065000000', '040197800320000', '040160957260000', '040196332550000', '040156795400000', '040204352180000', '040187940230000', '040196311240000', '020112154000000', '040196629090000', '040159384000000', '040163712000000', '040197800050000', '040198012180000', '040160954040000', '040204320760000', '040161348520000', '040161362360000', '040165571000000', '040205902640000', '040196361240000', '040202901540000', '040207201410000', '040207200270000', '040196346080000', '040204152350000', '040204372280000', '040185463520000', '040202862980000', '040204185110000', '040202830060000', '040187625140000', '040204187550000', '040198551480000', '040161360460000', '040185690440000', '040202862460000', '040202898300000', '040204185060000', '040204310500000', '040196315560000', '040204318400000', '040204319850000', '040204399740000', '040198543130000', '040187507240000', '040196634100000', '010040046000000', '030130343110000', '010040124660000', '040160600470000', '040161167960000', '040162753360000', '040186861260000', '040196317980000', '040196629820000', '040198551430000', '040205384840000', '040205362220000', '040198025770000', '040204183600000', '040196321500000', '040204315380000', '040162744420000', '040198010100000', '010050415480000', '040187509500000', '040185464280000', '040205278060000', '040196347090000', '010050276250000', '040196334010000', '040196346900000', '040196355300000', '040196635650000', '040198025180000', '040186860620000', '040154070460000', '040202890110000', '040202891710000', '040204153530000', '040204187570000', '040204319580000', '040204321760000', '040204361300000', '040196630010000', '040205277280000', '040198010340000', '040205362280000', '040207200930000', '040159240000000', '040166056460000', '040204316300000', '040198025520000', '040198543430000', '040198551060000', '040202673080000', '040202900130000', '040160827070000', '040204311920000', '040152410040000', '040204366320000', '040160827980000', '040162748540000', '040165548200000', '040162604180000', '040205275180000', '040205990460000', '040186859800000', '040187015020000', '040166055350000', '040159044000000', '040187507780000', '040172360620000', '040204316420000', '040204181720000', '040162747020000', '030130317010000', '040187624360000', '040202671800000', '040198551160000', '010040124120000', '010040124600000', '020080590000000', '040196332610000', '020111078000000', '040161172580000', '040196551720000', '040160827580000', '040187507740000', '040205387000000', '040205906060000', '040187004940000', '040170734000000', '040159576000000', '040196635000000', '040196347170000', '040162603640000', '020111103070000', '040161352690000', '040161360400000', '030140407000000', '040205995070000', '010050246380000', '010050274210000', '010050409820000', '010050416540000', '020090635000000', '020100021000000', '010030130300000', '020110755060000', '010040072000000', '010041512000000', '020100855000000', '030130305080000', '030130953000000', '040161306840000', '020110851000000', '020111039000000', '040161359330000', '020111400860000', '020111765400000', '030130311060000', '040161181400000', '040161181610000', '040161168230000', '040161181760000', '040162604880000', '040159528000000', '040161350960000', '040161351100000', '040161356640000', '040161403860000', '040160955580000', '040161352910000', '040162600900000', '040198551840000', '040204357020000', '040161307120000', '040162602000000', '040161180280000', '040163661000000', '040166056200000', '040161172300000', '040161353580000', '040198551010000', '010020391000000', '040160600610000', '040203079220000', '040172362900000', '040185450650000', '020111948000000', '010050114000000', '040187005420000', '040205367900000', '040161400700000', '030130315120000', '040162754120000', '040166048380000', '040205276560000', '040160600130000', '040198551500000', '040150467030000', '040160825310000', '040158935000000', '040160826710000', '040161168070000', '040161353660000', '040161358080000', '040161358340000', '040161359790000', '040161360060000', '040162745240000', '040164074000000', '040165050000000', '040166056320000', '040171918000000', '020100471000000', '040196322760000', '020110212000000', '040150103000000', '040160826300000', '040161348100000', '040162757220000', '040205895310000', '040198383260000', '040198383050000', '040187503380000', '020061299000000', '020111919000000', '030130313060000', '040154053020000', '040159336000000', '040160826450000', '040161181100000', '040171778000000', '040185454160000', '040186475690000', '040186475850000', '040186557520000', '040198010070000', '040204367500000', '040205167450000', '040205906640000', '040172356180000', '040185450160000', '040185451960000', '040185690020000', '040186561460000', '040187508200000', '040187622760000', '040187623740000', '040187930720000', '040196317720000', '040196319800000', '040196322060000', '040196326100000', '040197736000000', '040198026240000', '040202899180000', '040204367580000', '040202913120000', '040205991140000', '040204180760000', '010050275010000', '040187005960000', '040205895040000', '040204187520000', '040204359940000', '040204382220000', '040205380960000', '040205383940000', '040185701170000', '020110742380000', '040161350800000', '040205895090000', '040160828050000', '040166046060000', '010020119250000', '030130999000000', '030141001130000', '030141002100000', '040150114600000', '040150467160000', '040154061200000', '040156805500000', '040160825010000', '040205366120000', '010040385290000', '010020059200000', '010020076000000', '040150467080000', '040162601840000', '040207201650000', '020111120440000', '020061481000000', '040161351340000', '040186559830000', '040198668000000', '040160959660000', '030130657000000', '040204372300000', '040205364300000', '030130342110000', '040204315460000', '040171008000000', '040162600140000', '040197800130000', '040205387360000', '040161357490000', '040205991180000', '020111104060000', '040197641980000', '020110996000000', '020110735620000', '020111766920000', '020111768160000', '020112104000000', '030130333050000', '040150109300000', '040154070960000', '040154074520000', '040154517000000', '040154982000000', '040205901540000', '010050403080000', '040156805880000', '040170594000000', '040196629490000', '040187005540000', '040202863190000', '020110821000000', '040185450040000', '040198646010000', '040159265000000', '040161353740000', '040161176330000', '040204185190000', '040171054000000', '040205382740000', '040187510240000', '040162744940000', '020110733080000', '040185459200000', '040204187190000', '040161402800000', '040172372160000', '040196323180000', '040196636910000', '040196637490000', '010010333000000', '010030130320000', '010050026000000', '010050246020000', '010050275320000', '010050407660000', '010050417170000', '020110794000000', '020111007000000', '030130336010000', '030130338120000', '030130343020000', '030140806000000', '040152409400000', '040154073840000', '040154075100000', '040156803940000', '040158792000000', '040159067000000', '040160953740000', '040160956040000', '040160958860000', '040161171880000', '040161173490000', '040196551310000', '040161355360000', '020110116060000', '040160828020000', '040202674620000', '040173006000000', '010050417120000', '020110735680000', '030130321040000', '030130340030000', '040205390120000', '040156802680000', '040159626000000', '040160600960000', '040161403300000', '040162567340000', '040162755940000', '040162756060000', '040166056820000', '040205990060000', '040186556380000', '040186563240000', '040196311180000', '040196324460000', '040196331680000', '040196332220000', '040196353560000', '040187015030000', '040196629710000', '040196639980000', '040198551210000', '040204152960000', '040204318600000', '040204318660000', '040204320460000', '040205275300000', '040205385600000', '040205904400000', '040205991450000', '040185454100000', '040196641660000', '040161354970000', '010030080000000', '040156795920000', '040207201260000', '040202672770000', '040198551760000', '040171688000000', '040158990000000', '040196630920000', '040158882000000', '040171798000000', '040154074300000', '040202830440000', '040186556060000', '040158772000000', '040204314220000', '040204360280000', '040161180480000', '040161182150000', '040162603000000', '040166046700000', '040172370520000', '040185458340000', '040187015170000', '040196325260000', '040203074840000', '040204185280000', '040204320620000', '040205166220000', '040205908600000', '040196321840000', '040196334130000', '040196346680000', '040202891440000', '020070194000000', '020080649000000', '040156792000000', '040160825990000', '010050403100000', '040186856840000', '010050275210000', '040161181410000', '040161349010000', '040205390560000', '040161352930000', '040161355440000', '020080763000000', '040196641990000', '040162566980000', '020101162000000', '040165122000000', '040172356500000', '040171198000000', '040186475290000', '010040407000000', '040202671690000', '040196630560000', '040205895430000', '010040120400000', '040186221400000', '030120307000000', '010050403320000', '020070029000000', '040161357530000', '040155995000000', '040160956000000', '040186560400000', '040205380100000', '010050273640000', '020091012000000', '040152876000000', '040173880000000', '040204151850000', '040204356420000', '040205361840000', '040154071200000', '010030072000000', '040186562280000', '010020024000000', '040160827120000', '040161354360000', '040156425000000', '030120241000000', '010020079000000', '020110728300000', '020110899000000', '030130306080000', '030141001240000', '040150113900000', '040153608000000', '040161180750000', '040161181560000', '040161181740000', '040166055440000', '040171948000000', '040161355080000', '030140542000000', '040204319060000', '020111101100000', '010050408920000', '010040463000000', '040207200460000', '010020177000000', '010030130230000', '040187930120000', '040154607100000', '020112073000000', '020112116000000', '040150113600000', '040161178330000', '040162755260000', '040160826840000', '030130318110000', '040165116000000', '040166048200000', '040156805760000', '040171185000000', '040186564880000', '040187623100000', '040187006000000', '040202890560000', '040186858740000', '040207200110000', '040172360680000', '040186152900000', '040160600330000', '040186223480000', '040196357970000', '010040540220000', '040172356080000', '040205907280000', '040186564580000', '030130319120000', '040162754820000', '040160850040000', '040198541500000', '040204358640000', '040160825180000', '040161360550000', '010050417340000', '040161167950000', '040186560360000', '020090340000000', '040171028000000', '020061239000000', '040196329620000', '040154034000000', '040150114700000', '040156455000000', '040205361160000', '040171096000000', '040202891600000', '040204181440000', '040165549130000', '020060831000000', '020111051200000', '040155065000000', '040204321020000', '040161175100000', '040198543600000', '040196320760000', '040173664000000', '040196636840000', '040198551140000', '040161178930000', '040197714000000', '010020059130000', '040197738610000', '040185462940000', '040160825520000', '040172354360000', '040186565120000', '040198010030000', '040187625960000', '040173198000000', '040202862970000', '010050403600000', '040186859220000', '040150124500000', '040159228000000', '040186563060000', '040205381860000', '040196358000000', '040196359620000', '040196361720000', '040196362020000', '030140414000000', '040198025790000', '040204187220000', '040204365560000', '040204368960000', '040205909220000', '040205995500000', '040207201930000', '020101117000000', '020111400560000', '040160957180000', '040162744060000', '010050015000000', '030141001170000', '040161350300000', '010040481000000', '010050407120000', '040205991250000', '040202672930000', '010040104040000', '040185707610000', '040202901310000', '040204317660000', '040205390350000', '040161176630000', '040187623960000', '040187940250000', '040196324900000', '040197642060000', '040204187080000', '040204314420000')
//"));
//            r.ShowDialog();

//            DataTable dt = CityView.Run(@"
//select bp.recordid, APPLICATION_NUMBER, las.DESCRIPTION,

            //(select sum(fee_amount) from sysadmin.bi_fees f where f.bi_app_id = bp.recordid) as SumOfFees,
            //(select sum(pymnt_amount) from sysadmin.bi_payments p where p.bi_app_id = bp.recordid) as SumOfPayments,
            //'' as HasFinalInspection,
            //'' as FinalInspectionBy

            //from sysadmin.building_permits bp
            //left join sysadmin.lookupappstatus las on bp.application_status = las.code
            //where las.description <> 'ISSUED'

            //");

            //            for (int i = 0; i < dt.Rows.Count; i++)
            //            {
            //                DataTable temp = CityView.Run(@"
            //select * from sysadmin.inspections where bi_app_id = @ID and final in (1, -1)
            //", dt.Rows[i]["RECORDID"].ToString());

            //                dt.Rows[i]["HasFinalInspection"] = "No";

            //                if (temp.Rows.Count > 0)
            //                {
            //                    string inspector = "Code \"" + temp.Rows[0]["inspector"].ToString() + "\"";

            //                    DataTable temp2 = CityView.Run("select description from sysadmin.lookupbiinspector where code = @CODE", temp.Rows[0]["inspector"].ToString());

            //                    if (temp2.Rows.Count > 0)
            //                        inspector = temp2.Rows[0]["description"].ToString();

            //                    dt.Rows[i]["HasFinalInspection"] = "Yes";
            //                    dt.Rows[i]["FinalInspectionBy"] = inspector;
            //                }
            //            }

            //            Report r = new Report("CityView", dt);
            //            r.ShowDialog();

            //            Close();

            //Core.export("Test", SQL.Run("select * from systemvariables"));

            //SQL.Run("delete from LegalFileList");

            //DataTable dt = CityView.Run("select * from sysadmin.leg_file_list");

            //int ID = -1;
            //string FILE_NAME = "NULL";
            //string LOCATION = "NULL";
            //string COMMENTS = "NULL";
            //string BOX_FILE = "NULL";
            //string CORPORATE_FILE_NO = "NULL";
            //string CREATED_BY = "NULL";
            //string ASSIGNED_LAWYER = "NULL";
            //DateTime DATE_OPENED = new DateTime(1900, 1, 1);
            //DateTime DATE_BRING_FORWARD = new DateTime(1900, 1, 1);
            //DateTime DATE_IN = new DateTime(1900, 1, 1);
            //DateTime DATE_OUT = new DateTime(1900, 1, 1);
            //DateTime DATE_MOVED = new DateTime(1900, 1, 1);
            //DateTime DATE_CLOSED = new DateTime(1900, 1, 1);
            //DateTime DATE_TOBE_DESTRYD = new DateTime(1900, 1, 1);
            //DateTime DATE_DESTROYED = new DateTime(1900, 1, 1);
            //string FILE_STATUS = "NULL";
            //int FILE_NUMBER = -1;
            //int RSN = -1;
            //string OLD_LOCATION = "NULL";

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    ID = int.Parse(dt.Rows[i]["RECORDID"].ToString());
            //    FILE_NAME = dt.Rows[i]["FILE_NAME"].ToString();
            //    LOCATION = dt.Rows[i]["LOCATION"].ToString();
            //    COMMENTS = dt.Rows[i]["COMMENTS"].ToString();
            //    BOX_FILE = dt.Rows[i]["BOX_FILE"].ToString();
            //    CORPORATE_FILE_NO = dt.Rows[i]["CORPORATE_FILE_NO"].ToString();
            //    CREATED_BY = dt.Rows[i]["CREATED_BY"].ToString();
            //    ASSIGNED_LAWYER = dt.Rows[i]["ASSIGNED_LAWYER"].ToString();
            //    try
            //    {
            //        DATE_OPENED = DateTime.Parse(dt.Rows[i]["DATE_OPENED"].ToString());
            //    }
            //    catch
            //    {

            //    }
            //    try
            //    {
            //        DATE_BRING_FORWARD = DateTime.Parse(dt.Rows[i]["DATE_BRING_FORWARD"].ToString());
            //    }
            //    catch
            //    {

            //    }
            //    try
            //    {
            //        DATE_IN = DateTime.Parse(dt.Rows[i]["DATE_IN"].ToString());
            //    }
            //    catch
            //    {

            //    }
            //    try
            //    {
            //        DATE_OUT = DateTime.Parse(dt.Rows[i]["DATE_OUT"].ToString());
            //    }
            //    catch
            //    {

            //    }
            //    try
            //    {
            //        DATE_MOVED = DateTime.Parse(dt.Rows[i]["DATE_MOVED"].ToString());
            //    }
            //    catch
            //    {

            //    }
            //    try
            //    {
            //        DATE_CLOSED = DateTime.Parse(dt.Rows[i]["DATE_CLOSED"].ToString());
            //    }
            //    catch
            //    {

            //    }
            //    try
            //    {
            //        DATE_TOBE_DESTRYD = DateTime.Parse(dt.Rows[i]["DATE_TOBE_DESTRYD"].ToString());
            //    }
            //    catch
            //    {

            //    }
            //    try
            //    {
            //        DATE_DESTROYED = DateTime.Parse(dt.Rows[i]["DATE_DESTROYED"].ToString());
            //    }
            //    catch
            //    {

            //    }
            //    FILE_STATUS = dt.Rows[i]["FILE_STATUS"].ToString();
            //    try
            //    {
            //        FILE_NUMBER = int.Parse(dt.Rows[i]["FILE_NUMBER"].ToString());
            //    }
            //    catch
            //    {

            //    }
            //    try
            //    {
            //        RSN = int.Parse(dt.Rows[i]["RSN"].ToString());
            //    }
            //    catch
            //    {

            //    }
            //    OLD_LOCATION = dt.Rows[i]["OLD_LOCATION"].ToString();

            //    SQL.Run("insert into LegalFileList values (@ID, @FILENAME, @LOCATION, @COMMENTS, @BOXFILE, @CORPORATEFILENO, @CREATEDBY, @ASSIGNEDLAWYER, @DATEOPENED, @DATEBRINGFORWARD, @DATEIN, @DATEOUT, @DATEMOVED, @DATECLOSED, @DATETOBEDESTRYD, @DATEDESTROYED, @FILESTATUS, @FILENUMBER, @RSN, @OLDLOCATION)", ID, FILE_NAME, LOCATION, COMMENTS, BOX_FILE, CORPORATE_FILE_NO, CREATED_BY, ASSIGNED_LAWYER, DATE_OPENED, DATE_BRING_FORWARD, DATE_IN, DATE_OUT, DATE_MOVED, DATE_CLOSED, DATE_TOBE_DESTRYD, DATE_DESTROYED, FILE_STATUS, FILE_NUMBER, RSN, OLD_LOCATION);
            //}

            Console.SetOut(new TextBoxConsole(console));
            homeScreen1.list = imageList;
            homeScreen1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            console.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;

//            DataTable dt = SQL.Run(@"
//use dats;
//SELECT u.EMPLOYEEID as 'Employee Number'
//	  ,u.DISPLAYNAME as 'Employee Name'
//	  ,case when (select count(*) from DepartmentAssociations da where da.UserID = u.USERID) > 1 then 'Multi' else (select d.Department from Department d join DepartmentAssociations da on d.DepartmentID = da.DepartmentID join users u2 on da.UserID = u2.USERID and u2.USERID = u.USERID) end as 'Department'
//	  ,case when u.EMPTYPE = 'H' then 'Hourly' else case when u.emptype = 'S' then 'Salary' else u.emptype end end as 'Employee Type'
//	  ,'' as 'PT/FT'
//      ,convert(date, [DateWorked]) as 'Date Worked'
//	  ,[Period] as 'Pay Period'
//      ,p.Description as 'Pay Type'
//      ,[Hours]
//      ,[StartTime] as 'Start Time'
//      ,[FinishTime] as 'Finish Time'
//      ,[WorkOrder] as 'Work Order'
//      ,[LumpSum] as 'Lump Sum'
//      ,case when [Reviewed] <> 0 then 'Yes' else 'No' end as 'Reviewed'
//      ,case when [RecordLocked] <> 0 then 'Yes' else 'No' end as 'Approved'
//      ,case when [Exported] <> 0 then 'Yes' else 'No' end as 'Processed'
//      ,t.[Description]
//	  ,(select rtrim(e.EQUIPID) + ', ' as 'data()' from EquipmentTimeEntry e where t.TimeCardDetailID = e.TIMESHEETID FOR XML PATH('')) as 'Equipment'
//  FROM [DATS].[dbo].[Timesheets] t
//  join users u on t.employeeid = u.EMPLOYEEID
//  join PayCodes p on t.PayType = p.PayType

//  where
//  case when (select count(*) from DepartmentAssociations da where da.UserID = u.USERID) > 1 then 'Multi' else (select d.Department from Department d join DepartmentAssociations da on d.DepartmentID = da.DepartmentID join users u2 on da.UserID = u2.USERID and u2.USERID = u.USERID) end in ((select department from Department))

//  order by dateentered

//");

//            for (int i = 0; i < dt.Rows.Count; i++)
//            {
//                Oracle ora = new Oracle(@"
//select YAEST from CRPDTA.F060116 where YAAN8 = @EMPNO");
//                ora.AddParameter("@EMPNO", dt.Rows[i]["Employee Number"].ToString());
//                string code = ora.Run().Rows[0]["YAEST"].ToString().Trim();

//                string answer = "";

//                if (code == "")
//                    answer = "Full-time Regular";
//                else if (code == "1")
//                    answer = "Part-time Casual";
//                else if (code == "2")
//                    answer = "Part-time Hourly";
//                else if (code == "3")
//                    answer = "Contract";
//                else if (code == "4")
//                    answer = "Elected Officials";
//                else if (code == "5")
//                    answer = "Full-time Hourly";
//                else if (code == "6")
//                    answer = "Contract Salary";
//                else if (code == "7")
//                    answer = "LTD";

//                dt.Rows[i]["PT/FT"] = answer;
//            }

//            Report r = new Report("DATS Report", dt);
//            r.ShowDialog();

            //   Full - time Regular
            //1  Part - Time Casual
            //2  Part - Time Hourly
            //3  Contract
            //4  Elected Officials
            //5  Full Time Hourly
            //6  Contract Salary
            //7  LTD

            refreshList();
        }

        private void refreshList()
        {
            itemBackup.Clear();
            homeScreen1.programs.Clear();
            homeScreen1.scrollPos = 0;

            SQL sql = new SQL("select category from programs where hidden = 'False' group by category order by category");
            DataTable dt = sql.Run();

            //for (int i = 0; i < dt.Rows.Count; i++)
            //    homeScreen1.AddGroup(dt.Rows[i]["Category"].ToString(), "Services.png");

            //Programs
            Type[] programList = Core.GetTypesInNamespace(Assembly.GetExecutingAssembly(), "I_IT");

            for (int i = 0; i < programList.Length; i++)
            {
                if(hasPermission(programList[i].Name))
                {
                    DataTable details = SQL.Run("select * from programs where code = '" + programList[i].Name + "' order by category, description");

                    ScreenItem item = new ScreenItem();
                    item.title = details.Rows.Count > 0 ? details.Rows[0]["description"].ToString() : programList[i].Name;
                    item.tag = programList[i].Name;
                    item.group = details.Rows.Count > 0 ? details.Rows[0]["category"].ToString() : "";

                    if (details.Rows.Count > 0)
                    {
                        item.icon = imageList.Images[details.Rows[0]["icon"].ToString()];
                        item.hover = details.Rows[0]["tooltip"].ToString();
                    }
                    else
                        item.icon = imageList.Images["Services.png"];

                    if (search == "" || item.title.ToLower().Contains(search.ToLower()))
                    {
                        item.Left = homeScreen1.margin;
                        item.Right = item.Left + homeScreen1.itemHeight;

                        homeScreen1.AddItem(item);
                        itemBackup.Add(item);
                    }
                }
            }

            selectFirstItem();
        }

        private bool hasPermission(string program)
        {
            SQL sql = new SQL(@"
select *
from permissions
where (username=@USERNAME or username = 'Everyone')
and (program=@PROGRAM or program = 'Admin')
");
            sql.AddParameter("@USERNAME", Core.getUsername());
            sql.AddParameter("@PROGRAM", program);
            DataTable dt = sql.Run();

            return dt.Rows.Count > 0 && !Core.isProgramHidden(program); //True if query returned something, and the program is not hidden
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //Automatic cases
            if (homeScreen1.programs.Count == 0)
            {
                MessageBox.Show("You don't have permission to use this program.");
                Close();
            }
            //else if (homeScreen1.items.Count == 1)
            //{
            //    homeScreen1.Select();
            //    //programs.Items[0].Selected = true;
            //    listView1_DoubleClick(null, null);
            //}
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back)
            {
                search = search.Substring(0, Math.Max(search.Length - 1, 0));
                refreshList();
            }
            else if (Core.isIn(e.KeyCode.ToString(), "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Space", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D0"))
            {
                search += (char)e.KeyValue;
                
                for (int i = homeScreen1.programs.Count - 1; i >= 0; i--)
                    if (!homeScreen1.programs[i].title.ToUpper().Contains(search))
                        homeScreen1.programs.Remove(homeScreen1.programs[i]);

                homeScreen1.groups.Clear();
                homeScreen1.createViewList();

                homeScreen1.scrollPos = 0;
                selectFirstItem();
            }
            else if (e.KeyCode == Keys.Escape && search != "")
            {
                search = "";

                homeScreen1.programs.Clear();

                for (int i = 0; i < itemBackup.Count; i++)
                    homeScreen1.AddItem(itemBackup[i]);
            }
            else if(e.KeyCode == Keys.Enter)
            {
                if (homeScreen1.viewList.Count == 1 && homeScreen1.viewList[0].type == ScreenItemType.Program)
                    homeScreen1.openProgram(homeScreen1.viewList[0]);
            }
        }

        private void selectFirstItem()
        {
            //int index = -1;

            //for (int g = 0; g < programs.Groups.Count && index == -1; g++)
            //    if (programs.Groups[g].Items.Count > 0)
            //        index = g;

            //if (index != -1)
            //    programs.Groups[index].Items[0].Selected = true;
        }
        
        private void console_TextChanged(object sender, EventArgs e)
        {
            if(!console.Visible)
            {
                console.Visible = true;
                Width = console.Right + 16;
            }
        }
    }
}
