using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace I_IT
{
    class EquipmentTimeEntryExport
    {
        //con connects to SQL2008, acon connects to MSAccess on the T:\ Drive
        static SqlConnection con;
        static bool TESTSYSTEM = true;

        public EquipmentTimeEntryExport()
        {
            if (TESTSYSTEM)
                //con = new SqlConnection("Server=172.16.0.34; Database=DATSTest; User Id=DATS; password=SQL2008@r2");
                con = new SqlConnection("Server=172.16.0.46; Database=DATS; User Id=DATS; password=SQL2008@r2");
            else
                con = new SqlConnection("Server=172.16.0.34; Database=DATS; User Id=DATS; password=SQL2008@r2");

            Console.WriteLine("Beginning export and update");



            EquipmentTimeEntry();

            Console.WriteLine("Export and update complete!");
        }

        //Takes the input string, and spits out the same string with quotes handled appropriately
        static string antiQuote(string input)
        {
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                output += ((input.ToCharArray())[i] == '\'' ? "''" : (input.ToCharArray())[i].ToString());
            }

            return output;
        }
        
        //Exports Equipment Time Entry records
        static void EquipmentTimeEntry()
        {
            int sleep = 0;

            Boolean bgood = true;
            string errormessage = "";

            Console.WriteLine("Grabbing EquipmentTimeEntry for export");

            string sql = @"
SELECT e.EquipID, t.workorder, t.Hours, t.Period, t.DateWorked, t.DateEntered, u.USERNAME, d.Department, e.timesheetid
FROM EquipmentTimeEntry AS e INNER JOIN
                        Timesheets AS t ON e.TIMESHEETID = t.TimeCardDetailID INNER JOIN
                        Users AS u ON t.EmployeeID = u.EMPLOYEEID INNER JOIN
                        DepartmentAssociations AS da ON u.USERID = da.UserID INNER JOIN
                        Department AS d ON da.DepartmentID = d.DepartmentID

WHERE        (e.SENT = 'False') AND (t.RecordLocked = 'True') and t.workorder is not null and t.workorder <> ''";
            SqlCommand com2 = new SqlCommand(sql, con);
            SqlDataAdapter sda2 = new SqlDataAdapter(com2);
            DataTable dt = new DataTable();
            sda2.Fill(dt);
            Thread.Sleep(sleep);

            string[] equipID, WOID, hours, period, dateWorked, dateEntered, DATUSER, DATDEP, timesheetID;

            int numRecords = dt.Rows.Count;

            if (numRecords > 0)
            {
                equipID = new string[numRecords];
                WOID = new string[numRecords];
                hours = new string[numRecords];
                period = new string[numRecords];
                dateWorked = new string[numRecords];
                dateEntered = new string[numRecords];
                DATUSER = new string[numRecords];
                DATDEP = new string[numRecords];
                timesheetID = new string[numRecords];
                string VNEDLN = "";
                string VNEDBT = "";
                string VNDGJ = "";
                string VNJELN = "";
                string positiveVNANI = "";
                string negativeVNANI = "";
                string positiveVNMCU = "";
                string positiveVNOBJ = "";
                string negativeVNMCU = "";
                string negativeVNOBJ = "";
                string positiveVNSUB = "";
                string negativeVNSUB = "";
                string VNSBL = "";
                string VNPN = "";
                string VNFY = "";
                int positiveVNAA = 0;
                int negativeVNAA = 0;
                string VNEXA = "";
                string VNEXR = "";
                string VNR1 = "";
                int positiveVNAG = 0;
                int negativeVNAG = 0;
                string VNDSVJ = "";
                int FAAAID = 0;
                int nCounter = 0;

                for (int i = 0; i < numRecords; i++)
                {
                    equipID[i] = dt.Rows[i][0].ToString();
                    WOID[i] = dt.Rows[i][1].ToString();
                    hours[i] = dt.Rows[i][2].ToString();
                    period[i] = dt.Rows[i][3].ToString();
                    dateWorked[i] = dt.Rows[i][4].ToString();
                    dateEntered[i] = dt.Rows[i][5].ToString();
                    DATUSER[i] = dt.Rows[i][6].ToString();
                    DATDEP[i] = dt.Rows[i][7].ToString();
                    timesheetID[i] = dt.Rows[i][8].ToString();
                }

                
                int lineNumber = 0;

                Console.WriteLine("Grabbing Batch Number");

                string strSql = "";

                Oracle ora = new Oracle("SELECT NNN006 from CRPCTL.F0002 where NNSY='00'");

                //Validates data first before sending it to JDE
                for (int i = 0; i < numRecords; i++)
                {
                    errormessage = "Not Found on table F4801 ->";
                    ora = new Oracle("SELECT WAMCU from CRPDTA.F4801 WHERE WADOCO=@WorkOrder");
                    ora.AddParameter("@WorkOrder", WOID[i]);
                    dt = ora.Run();
                    if (dt.Rows.Count == 0)
                    {
                        Console.WriteLine(WOID[i] + ' ' + i.ToString());
                        errormessage = errormessage + WOID[i] + ' ' + i.ToString();
                        bgood = false;

                    }


                    errormessage = "Not Found on table F1201 ";
                    ora = new Oracle("SELECT FARMCU, FAROBJ, FARSUB, FAAAID from CRPDTA.F1201 WHERE trim(FAAPID)=trim(@EquipmentNumber)");
                    ora.AddParameter("@EquipmentNumber", equipID[i]);
                    dt = ora.Run();

                    if (dt.Rows.Count == 0)
                    {
                        Console.WriteLine(equipID[i] + ' ' + i.ToString());
                        errormessage = errormessage + equipID[i] + ' ' + i.ToString();
                        bgood = false;

                    }
                 


                }

                if (!bgood)
                {
                    Core.sendMail("ealarcon@newmarket.ca", "ExportTimeEntry", errormessage);

                }
                else
             
                {
                    ora = new Oracle("SELECT NNN006 from CRPCTL.F0002 where NNSY='00'");
                    //if(TESTSYSTEM)
                    //    ora = new Oracle("SELECT NNN006 from CRPCTL.F0002 where NNSY='00'");
                    dt = ora.Run();
                    Thread.Sleep(sleep);

                    VNEDBT = dt.Rows[0][0].ToString();

                    Console.WriteLine("Incrementing Batch Table");

                    ora = new Oracle("UPDATE CRPCTL.F0002 SET NNN006=NNN006+1");

                    //if (TESTSYSTEM)
                    //    ora = new Oracle("UPDATE CRPCTL.F0002 SET NNN006=NNN006+1");
                    dt = ora.Run();
                    Thread.Sleep(sleep);
            
                    for (int i = 0; i < numRecords; i++)
                    {
                        Console.WriteLine("Inserting into EquipmentTimeEntry record " + (i + 1) + " of " + numRecords);

                        VNDGJ = Core.dateToJDE(DateTime.Now.ToString("G"));
                        VNDSVJ = Core.dateToJDE(dateWorked[i]);
                        Thread.Sleep(sleep);

                        Console.WriteLine("- - - 1/6 Grabbing Business Unit");

                        ora = new Oracle("SELECT WAMCU from CRPDTA.F4801 WHERE WADOCO=@WorkOrder");
                        ora.AddParameter("@WorkOrder", WOID[i]);
                        dt = ora.Run();
                        Thread.Sleep(sleep);

                        positiveVNMCU = dt.Rows[0][0].ToString();

                        ora = new Oracle("SELECT FARMCU, FAROBJ, FARSUB, FAAAID from CRPDTA.F1201 WHERE trim(FAAPID)=trim(@EquipmentNumber)");
                        ora.AddParameter("@EquipmentNumber", equipID[i]);
                        dt = ora.Run();
                        Thread.Sleep(sleep);

                        //throw new Exception(equipID[i]);

                        negativeVNMCU = dt.Rows[0][0].ToString();
                        negativeVNOBJ = dt.Rows[0][1].ToString();
                        negativeVNSUB = dt.Rows[0][2].ToString();
                        FAAAID = int.Parse(dt.Rows[0][3].ToString());

                        int length = FAAAID.ToString().Length;
                        string FAAAIDstring = "/";

                        for (int x = 0; x < 8 - length; x++)
                            FAAAIDstring += "0";

                        FAAAIDstring += FAAAID.ToString();

                        Console.WriteLine("- - - 2/6 Grabbing Object");

                        ora = new Oracle("SELECT KGOBJ, KGSUB from CRPDTA.F0012 WHERE KGITEM=@KGITEM AND KGCO=@KGCO");
                        ora.AddParameter("@KGITEM", "FTD");
                        ora.AddParameter("@KGCO", "01000");
                        dt = ora.Run();
                        Thread.Sleep(sleep);

                        if (dt.Rows.Count > 0)
                        {
                            positiveVNOBJ = dt.Rows[0][0].ToString();
                            positiveVNSUB = dt.Rows[0][1].ToString();
                        }
                        else
                        {
                            Console.WriteLine("- - - 2/6 Grabbing Object (Backup)");

                            ora = new Oracle("SELECT KGOBJ, KGSUB from CRPDTA.F0012 WHERE KGITEM='FTD' AND KGCO='00000'");
                            //ora.AddParameter("@KGITEM", "FTD");
                            //ora.AddParameter("@KGCO", "00000");
                            dt = ora.Run();
                            Thread.Sleep(sleep);

                            positiveVNOBJ = dt.Rows[0][0].ToString();
                            positiveVNSUB = dt.Rows[0][1].ToString();
                        }

                      
                        positiveVNANI = positiveVNMCU + "." + positiveVNOBJ + (positiveVNSUB != "" && positiveVNSUB != null && positiveVNSUB != "        " ? "." + positiveVNSUB : "");
                        negativeVNANI = negativeVNMCU + "." + negativeVNOBJ + (negativeVNSUB != "" && negativeVNSUB != null && negativeVNSUB != "        " ? "." + negativeVNSUB : "");

                        VNPN = DateTime.Parse(dateWorked[i]).Month.ToString();
                        VNFY = (DateTime.Parse(dateWorked[i]).Year.ToString()).Substring(2, 2);
                        VNEXA = "Equipment Time Entry";

                        Console.WriteLine("- - - 3/6 Grabbing Equipment Description and Rate Type");

                      
                        ora = new Oracle("SELECT FADL01, FAACL0 from CRPDTA.F1201 WHERE trim(FAAPID)=trim(@EquipmentNumber)");
                        ora.AddParameter("@EquipmentNumber", equipID[i]);
                        dt = ora.Run();
                        Thread.Sleep(sleep);

                        VNEXR = dt.Rows[0][0].ToString();
                        string rateType = dt.Rows[0][1].ToString();


                        //Pads the work order number with 0s -EAC
                        nCounter = WOID[i].Length;
                        for (int x = 0; x < 8 - nCounter; x++)
                        {
                            WOID[i] = "0" + WOID[i];
                        }

                        VNSBL = WOID[i];

                        Console.WriteLine("- - - 4/6 Grabbing Billing Rate");

                        

                        ora = new Oracle("SELECT FGEBRT, FGERC from CRPDTA.F1301 WHERE FGRTGR=@RateType");
                        ora.AddParameter("@RateType", rateType);
                        dt = ora.Run();
                        Thread.Sleep(sleep);

                        string billingRate = dt.Rows[0][0].ToString();
                        string VNALTY = dt.Rows[0][1].ToString();

                        positiveVNAA = (int)(double.Parse(billingRate) * double.Parse(hours[i]));
                        negativeVNAA = -positiveVNAA;

                        double VNU = 100 * double.Parse(hours[i]);

                        VNR1 = equipID[i];

                        positiveVNAG = positiveVNAA;
                        negativeVNAG = negativeVNAA;

                        Console.WriteLine("- - - 5/6 Inserting Entry");

                        lineNumber++;
                        VNJELN = lineNumber.ToString();
                        VNEDLN = (lineNumber * 1000).ToString();

                        //Inserts the positive entry
                        if (TESTSYSTEM)
                            ora = new Oracle("INSERT into CRPDTA.F0911Z1 VALUES (@VNEDUS, @VNEDTY, @VNEDSQ, @VNEDTN, @VNEDCT, @VNEDLN, @VNEDTS, @VNEDFT, @VNEDDT, @VNEDER, @VNEDDL, @VNEDSP, @VNEDTC, @VNEDTR, @VNEDBT, @VNEDGL, @VNEDAN, @VNKCO, @VNDCT, @VNDOC, @VNDGJ, @VNJELN, @VNEXTL, @VNPOST, @VNICU, @VNICUT, @VNDICJ, @VNDSYJ, @VNTICU, @VNCO, @VNANI, @VNAM, @VNAID, @VNMCU, @VNOBJ, @VNSUB, @VNSBL, @VNSBLT, @VNLT, @VNPN, @VNCTRY, @VNFY, @VNFQ, @VNCRCD, @VNCRR, @VNHCRR, @VNHDGJ, @VNAA, @VNU, @VNUM, @VNGLC, @VNRE, @VNEXA, @VNEXR, @VNR1, @VNR2, @VNR3, @VNSFX, @VNODOC, @VNODCT, @VNOSFX, @VNPKCO, @VNOKCO, @VNPDCT, @VNAN8, @VNCN, @VNDKJ, @VNDKC, @VNASID, @VNBRE, @VNRCND, @VNSUMM, @VNPRGE, @VNTNN, @VNALT1, @VNALT2, @VNALT3, @VNALT4, @VNALT5, @VNALT6, @VNALT7, @VNALT8, @VNALT9, @VNALT0, @VNALTT, @VNALTU, @VNALTV, @VNALTW, @VNALTX, @VNALTZ, @VNDLNA, @VNCFF1, @VNCFF2, @VNASM, @VNBC, @VNVINV, @VNIVD, @VNWR01, @VNPO, @VNPSFX, @VNDCTO, @VNLNID, @VNWY, @VNWN, @VNFNLP, @VNOPSQ, @VNJBCD, @VNJBST, @VNHMCU, @VNDOI, @VNALID, @VNALTY, @VNDSVJ, @VNTORG, @VNREGPOUND, @VNPYID, @VNUSER, @VNPID, @VNJOBN, @VNUPMJ, @VNUPMT, @VNCRRM, @VNACR, @VNDGM, @VNDGD, @VNDGY, @VNGDGPOUND, @VNDICM, @VNDICD, @VNDICY, @VNDICPOUND, @VNDSYM, @VNDSYS, @VNDSYY, @VNDSYPOUND, @VNDKM, @VNDKD, @VNDKY, @VNDKPOUND, @VNDSVM, @VNDSVD, @VNDSVY, @VNDSVPOUND, @VNHDGM, @VNHDGD, @VNHDGY, @VNHDGPOUND, @VNDKCM, @VNDKCD, @VNDKCY, @VNDKCPOUND, @VNIVDM, @VNIVDD, @VNIVDY, @VNIVDPOUND, @VNABR1, @VNABR2, @VNABR3, @VNABR4, @VNABT1, @VNABT2, @VNABT3, @VNABT4, @VNITM, @VNPM01, @VNPM02, @VNPM03, @VNPM04, @VNPM05, @VNPM06, @VNPM07, @VNPM08, @VNPM09, @VNPM10, @VNBCRC, @VNEXR1, @VNTXA1, @VNTXITM, @VNACTB, @VNSTAM, @VNCTAM, @VNAG, @VNAGF, @VNTKTX, @VNDLNID, @VNCKNU, @VNBUPC, @VNAHBU, @VNEPGC, @VNJPGC, @VNRC5, @VNSFXE, @VNOFM)");
                        else
                            ora = new Oracle("INSERT into PRODDTA.F0911Z1 VALUES (@VNEDUS, @VNEDTY, @VNEDSQ, @VNEDTN, @VNEDCT, @VNEDLN, @VNEDTS, @VNEDFT, @VNEDDT, @VNEDER, @VNEDDL, @VNEDSP, @VNEDTC, @VNEDTR, @VNEDBT, @VNEDGL, @VNEDAN, @VNKCO, @VNDCT, @VNDOC, @VNDGJ, @VNJELN, @VNEXTL, @VNPOST, @VNICU, @VNICUT, @VNDICJ, @VNDSYJ, @VNTICU, @VNCO, @VNANI, @VNAM, @VNAID, @VNMCU, @VNOBJ, @VNSUB, @VNSBL, @VNSBLT, @VNLT, @VNPN, @VNCTRY, @VNFY, @VNFQ, @VNCRCD, @VNCRR, @VNHCRR, @VNHDGJ, @VNAA, @VNU, @VNUM, @VNGLC, @VNRE, @VNEXA, @VNEXR, @VNR1, @VNR2, @VNR3, @VNSFX, @VNODOC, @VNODCT, @VNOSFX, @VNPKCO, @VNOKCO, @VNPDCT, @VNAN8, @VNCN, @VNDKJ, @VNDKC, @VNASID, @VNBRE, @VNRCND, @VNSUMM, @VNPRGE, @VNTNN, @VNALT1, @VNALT2, @VNALT3, @VNALT4, @VNALT5, @VNALT6, @VNALT7, @VNALT8, @VNALT9, @VNALT0, @VNALTT, @VNALTU, @VNALTV, @VNALTW, @VNALTX, @VNALTZ, @VNDLNA, @VNCFF1, @VNCFF2, @VNASM, @VNBC, @VNVINV, @VNIVD, @VNWR01, @VNPO, @VNPSFX, @VNDCTO, @VNLNID, @VNWY, @VNWN, @VNFNLP, @VNOPSQ, @VNJBCD, @VNJBST, @VNHMCU, @VNDOI, @VNALID, @VNALTY, @VNDSVJ, @VNTORG, @VNREGPOUND, @VNPYID, @VNUSER, @VNPID, @VNJOBN, @VNUPMJ, @VNUPMT, @VNCRRM, @VNACR, @VNDGM, @VNDGD, @VNDGY, @VNGDGPOUND, @VNDICM, @VNDICD, @VNDICY, @VNDICPOUND, @VNDSYM, @VNDSYS, @VNDSYY, @VNDSYPOUND, @VNDKM, @VNDKD, @VNDKY, @VNDKPOUND, @VNDSVM, @VNDSVD, @VNDSVY, @VNDSVPOUND, @VNHDGM, @VNHDGD, @VNHDGY, @VNHDGPOUND, @VNDKCM, @VNDKCD, @VNDKCY, @VNDKCPOUND, @VNIVDM, @VNIVDD, @VNIVDY, @VNIVDPOUND, @VNABR1, @VNABR2, @VNABR3, @VNABR4, @VNABT1, @VNABT2, @VNABT3, @VNABT4, @VNITM, @VNPM01, @VNPM02, @VNPM03, @VNPM04, @VNPM05, @VNPM06, @VNPM07, @VNPM08, @VNPM09, @VNPM10, @VNBCRC, @VNEXR1, @VNTXA1, @VNTXITM, @VNACTB, @VNSTAM, @VNCTAM, @VNAG, @VNAGF, @VNTKTX, @VNDLNID, @VNCKNU, @VNBUPC, @VNAHBU, @VNEPGC, @VNJPGC, @VNRC5, @VNSFXE, @VNOFM)");

                        ora.AddParameter("@VNEDUS", "JDE");
                        ora.AddParameter("@VNEDTY", "T");
                        ora.AddParameter("@VNEDSQ", 0);
                        ora.AddParameter("@VNEDTN", "1");
                        ora.AddParameter("@VNEDCT", " ");
                        ora.AddParameter("@VNEDLN", VNEDLN);
                        ora.AddParameter("@VNEDTS", " ");
                        ora.AddParameter("@VNEDFT", " ");
                        ora.AddParameter("@VNEDDT", 0);
                        ora.AddParameter("@VNEDER", "B");
                        ora.AddParameter("@VNEDDL", 0);
                        ora.AddParameter("@VNEDSP", "0");
                        ora.AddParameter("@VNEDTC", "A");
                        ora.AddParameter("@VNEDTR", "J");
                        ora.AddParameter("@VNEDBT", VNEDBT);
                        ora.AddParameter("@VNEDGL", " ");
                        ora.AddParameter("@VNEDAN", 0);
                        ora.AddParameter("@VNKCO", "01000");
                        ora.AddParameter("@VNDCT", "TE");
                        ora.AddParameter("@VNDOC", 0);
                        ora.AddParameter("@VNDGJ", VNDGJ);
                        ora.AddParameter("@VNJELN", VNJELN);
                        ora.AddParameter("@VNEXTL", " ");
                        ora.AddParameter("@VNPOST", " ");
                        ora.AddParameter("@VNICU", 0);
                        ora.AddParameter("@VNICUT", "T");
                        ora.AddParameter("@VNDICJ", 0);
                        ora.AddParameter("@VNDSYJ", 0);
                        ora.AddParameter("@VNTICU", 0);
                        ora.AddParameter("@VNCO", "01000");
                        ora.AddParameter("@VNANI", positiveVNANI);
                        ora.AddParameter("@VNAM", "2");
                        ora.AddParameter("@VNAID", " ");
                        ora.AddParameter("@VNMCU", positiveVNMCU);
                        ora.AddParameter("@VNOBJ", positiveVNOBJ);
                        ora.AddParameter("@VNSUB", positiveVNSUB);
                        ora.AddParameter("@VNSBL", VNSBL);
                        ora.AddParameter("@VNSBLT", "W");
                        ora.AddParameter("@VNLT", "AA");
                        ora.AddParameter("@VNPN", VNPN);
                        ora.AddParameter("@VNCTRY", 20);
                        ora.AddParameter("@VNFY", VNFY);
                        ora.AddParameter("@VNFQ", " ");
                        ora.AddParameter("@VNCRCD", " ");
                        ora.AddParameter("@VNCRR", 0);
                        ora.AddParameter("@VNHCRR", 0);
                        ora.AddParameter("@VNHDGJ", 0);
                        ora.AddParameter("@VNAA", positiveVNAA);
                        ora.AddParameter("@VNU", VNU.ToString());
                        ora.AddParameter("@VNUM", " ");
                        ora.AddParameter("@VNGLC", " ");
                        ora.AddParameter("@VNRE", " ");
                        ora.AddParameter("@VNEXA", VNEXA);
                        ora.AddParameter("@VNEXR", VNEXR);
                        ora.AddParameter("@VNR1", VNR1.Substring(0, Math.Min(8, VNR1.Length)));
                        ora.AddParameter("@VNR2", " ");
                        ora.AddParameter("@VNR3", " ");
                        ora.AddParameter("@VNSFX", " ");
                        ora.AddParameter("@VNODOC", 0);
                        ora.AddParameter("@VNODCT", " ");
                        ora.AddParameter("@VNOSFX", " ");
                        ora.AddParameter("@VNPKCO", " ");
                        ora.AddParameter("@VNOKCO", " ");
                        ora.AddParameter("@VNPDCT", " ");
                        ora.AddParameter("@VNAN8", 0);
                        ora.AddParameter("@VNCN", " ");
                        ora.AddParameter("@VNDKJ", 0);
                        ora.AddParameter("@VNDKC", 0);
                        ora.AddParameter("@VNASID", FAAAIDstring); //Asset ID?
                        ora.AddParameter("@VNBRE", " ");
                        ora.AddParameter("@VNRCND", " ");
                        ora.AddParameter("@VNSUMM", " ");
                        ora.AddParameter("@VNPRGE", " ");
                        ora.AddParameter("@VNTNN", " ");
                        ora.AddParameter("@VNALT1", " ");
                        ora.AddParameter("@VNALT2", " ");
                        ora.AddParameter("@VNALT3", " ");
                        ora.AddParameter("@VNALT4", " ");
                        ora.AddParameter("@VNALT5", " ");
                        ora.AddParameter("@VNALT6", " ");
                        ora.AddParameter("@VNALT7", " ");
                        ora.AddParameter("@VNALT8", " ");
                        ora.AddParameter("@VNALT9", " ");
                        ora.AddParameter("@VNALT0", " ");
                        ora.AddParameter("@VNALTT", " ");
                        ora.AddParameter("@VNALTU", " ");
                        ora.AddParameter("@VNALTV", " ");
                        ora.AddParameter("@VNALTW", " ");
                        ora.AddParameter("@VNALTX", " ");
                        ora.AddParameter("@VNALTZ", " ");
                        ora.AddParameter("@VNDLNA", " ");
                        ora.AddParameter("@VNCFF1", " ");
                        ora.AddParameter("@VNCFF2", " ");
                        ora.AddParameter("@VNASM", " ");
                        ora.AddParameter("@VNBC", " ");
                        ora.AddParameter("@VNVINV", " ");
                        ora.AddParameter("@VNIVD", 0);
                        ora.AddParameter("@VNWR01", " ");
                        ora.AddParameter("@VNPO", " ");
                        ora.AddParameter("@VNPSFX", " ");
                        ora.AddParameter("@VNDCTO", " ");
                        ora.AddParameter("@VNLNID", 0);
                        ora.AddParameter("@VNWY", 0);
                        ora.AddParameter("@VNWN", 0);
                        ora.AddParameter("@VNFNLP", " ");
                        ora.AddParameter("@VNOPSQ", 0);
                        ora.AddParameter("@VNJBCD", " ");
                        ora.AddParameter("@VNJBST", " ");
                        ora.AddParameter("@VNHMCU", " ");
                        ora.AddParameter("@VNDOI", 0);
                        ora.AddParameter("@VNALID", " ");
                        ora.AddParameter("@VNALTY", VNALTY);
                        ora.AddParameter("@VNDSVJ", VNDSVJ);
                        ora.AddParameter("@VNTORG", " ");
                        ora.AddParameter("@VNREGPOUND", 0);
                        ora.AddParameter("@VNPYID", 0);
                        ora.AddParameter("@VNUSER", "JDE");
                        ora.AddParameter("@VNPID", " ");
                        ora.AddParameter("@VNJOBN", " ");
                        ora.AddParameter("@VNUPMJ", 0);
                        ora.AddParameter("@VNUPMT", 0);
                        ora.AddParameter("@VNCRRM", " ");
                        ora.AddParameter("@VNACR", 0);
                        ora.AddParameter("@VNDGM", 0);
                        ora.AddParameter("@VNDGD", 0);
                        ora.AddParameter("@VNDGY", 0);
                        ora.AddParameter("@VNGDGPOUND", 0);
                        ora.AddParameter("@VNDICM", 0);
                        ora.AddParameter("@VNDICD", 0);
                        ora.AddParameter("@VNDICY", 0);
                        ora.AddParameter("@VNDICPOUND", 0);
                        ora.AddParameter("@VNDSYM", 0);
                        ora.AddParameter("@VNDSYS", 0);
                        ora.AddParameter("@VNDSYY", 0);
                        ora.AddParameter("@VNDSYPOUND", 0);
                        ora.AddParameter("@VNDKM", 0);
                        ora.AddParameter("@VNDKD", 0);
                        ora.AddParameter("@VNDKY", 0);
                        ora.AddParameter("@VNDKPOUND", 0);
                        ora.AddParameter("@VNDSVM", 0);
                        ora.AddParameter("@VNDSVD", 0);
                        ora.AddParameter("@VNDSVY", 0);
                        ora.AddParameter("@VNDSVPOUND", 0);
                        ora.AddParameter("@VNHDGM", 0);
                        ora.AddParameter("@VNHDGD", 0);
                        ora.AddParameter("@VNHDGY", 0);
                        ora.AddParameter("@VNHDGPOUND", 0);
                        ora.AddParameter("@VNDKCM", 0);
                        ora.AddParameter("@VNDKCD", 0);
                        ora.AddParameter("@VNDKCY", 0);
                        ora.AddParameter("@VNDKCPOUND", 0);
                        ora.AddParameter("@VNIVDM", 0);
                        ora.AddParameter("@VNIVDD", 0);
                        ora.AddParameter("@VNIVDY", 0);
                        ora.AddParameter("@VNIVDPOUND", 0);
                        ora.AddParameter("@VNABR1", " ");
                        ora.AddParameter("@VNABR2", " ");
                        ora.AddParameter("@VNABR3", " ");
                        ora.AddParameter("@VNABR4", " ");
                        ora.AddParameter("@VNABT1", " ");
                        ora.AddParameter("@VNABT2", " ");
                        ora.AddParameter("@VNABT3", " ");
                        ora.AddParameter("@VNABT4", " ");
                        ora.AddParameter("@VNITM", 0);
                        ora.AddParameter("@VNPM01", " ");
                        ora.AddParameter("@VNPM02", " ");
                        ora.AddParameter("@VNPM03", " ");
                        ora.AddParameter("@VNPM04", " ");
                        ora.AddParameter("@VNPM05", " ");
                        ora.AddParameter("@VNPM06", " ");
                        ora.AddParameter("@VNPM07", " ");
                        ora.AddParameter("@VNPM08", " ");
                        ora.AddParameter("@VNPM09", " ");
                        ora.AddParameter("@VNPM10", " ");
                        ora.AddParameter("@VNBCRC", " ");
                        ora.AddParameter("@VNEXR1", " ");
                        ora.AddParameter("@VNTXA1", " ");
                        ora.AddParameter("@VNTXITM", 0);
                        ora.AddParameter("@VNACTB", " ");
                        ora.AddParameter("@VNSTAM", 0);
                        ora.AddParameter("@VNCTAM", 0);
                        ora.AddParameter("@VNAG", positiveVNAG);
                        ora.AddParameter("@VNAGF", 0);
                        ora.AddParameter("@VNTKTX", " ");
                        ora.AddParameter("@VNDLNID", 0);
                        ora.AddParameter("@VNCKNU", " ");
                        ora.AddParameter("@VNBUPC", " ");
                        ora.AddParameter("@VNAHBU", " ");
                        ora.AddParameter("@VNEPGC", " ");
                        ora.AddParameter("@VNJPGC", " ");
                        ora.AddParameter("@VNRC5", 0);
                        ora.AddParameter("@VNSFXE", 0);
                        ora.AddParameter("@VNOFM", " ");

                        //string text = "";

                        //for (int blah = 0; blah < acom.Parameters.Count; blah++)
                        //    text += acom.Parameters[blah].Value + Environment.NewLine;

                        // System.IO.File.WriteAllText(@"C:\WriteText.txt", text);

                        dt = ora.Run();

                        lineNumber++;
                        VNJELN = lineNumber.ToString();
                        VNEDLN = (lineNumber * 1000).ToString();

                        //Inserts the negative entry, so numbers balance
                        //strSql = "INSERT into CRPDTA_F0911Z1 VALUES (@VNEDUS, @VNEDTY, @VNEDSQ, @VNEDTN, @VNEDCT, @VNEDLN, @VNEDTS, @VNEDFT, @VNEDDT, @VNEDER, @VNEDDL, @VNEDSP, @VNEDTC, @VNEDTR, @VNEDBT, @VNEDGL, @VNEDAN, @VNKCO, @VNDCT, @VNDOC, @VNDGJ, @VNJELN, @VNEXTL, @VNPOST, @VNICU, @VNICUT, @VNDICJ, @VNDSYJ, @VNTICU, @VNCO, @VNANI, @VNAM, @VNAID, @VNMCU, @VNOBJ, @VNSUB, @VNSBL, @VNSBLT, @VNLT, @VNPN, @VNCTRY, @VNFY, @VNFQ, @VNCRCD, @VNCRR, @VNHCRR, @VNHDGJ, @VNAA, @VNU, @VNUM, @VNGLC, @VNRE, @VNEXA, @VNEXR, @VNR1, @VNR2, @VNR3, @VNSFX, @VNODOC, @VNODCT, @VNOSFX, @VNPKCO, @VNOKCO, @VNPDCT, @VNAN8, @VNCN, @VNDKJ, @VNDKC, @VNASID, @VNBRE, @VNRCND, @VNSUMM, @VNPRGE, @VNTNN, @VNALT1, @VNALT2, @VNALT3, @VNALT4, @VNALT5, @VNALT6, @VNALT7, @VNALT8, @VNALT9, @VNALT0, @VNALTT, @VNALTU, @VNALTV, @VNALTW, @VNALTX, @VNALTZ, @VNDLNA, @VNCFF1, @VNCFF2, @VNASM, @VNBC, @VNVINV, @VNIVD, @VNWR01, @VNPO, @VNPSFX, @VNDCTO, @VNLNID, @VNWY, @VNWN, @VNFNLP, @VNOPSQ, @VNJBCD, @VNJBST, @VNHMCU, @VNDOI, @VNALID, @VNALTY, @VNDSVJ, @VNTORG, @VNREGPOUND, @VNPYID, @VNUSER, @VNPID, @VNJOBN, @VNUPMJ, @VNUPMT, @VNCRRM, @VNACR, @VNDGM, @VNDGD, @VNDGY, @VNGDGPOUND, @VNDICM, @VNDICD, @VNDICY, @VNDICPOUND, @VNDSYM, @VNDSYS, @VNDSYY, @VNDSYPOUND, @VNDKM, @VNDKD, @VNDKY, @VNDKPOUND, @VNDSVM, @VNDSVD, @VNDSVY, @VNDSVPOUND, @VNHDGM, @VNHDGD, @VNHDGY, @VNHDGPOUND, @VNDKCM, @VNDKCD, @VNDKCY, @VNDKCPOUND, @VNIVDM, @VNIVDD, @VNIVDY, @VNIVDPOUND, @VNABR1, @VNABR2, @VNABR3, @VNABR4, @VNABT1, @VNABT2, @VNABT3, @VNABT4, @VNITM, @VNPM01, @VNPM02, @VNPM03, @VNPM04, @VNPM05, @VNPM06, @VNPM07, @VNPM08, @VNPM09, @VNPM10, @VNBCRC, @VNEXR1, @VNTXA1, @VNTXITM, @VNACTB, @VNSTAM, @VNCTAM, @VNAG, @VNAGF, @VNTKTX, @VNDLNID, @VNCKNU, @VNBUPC, @VNAHBU, @VNEPGC, @VNJPGC, @VNRC5, @VNSFXE, @VNOFM)";
                        if (TESTSYSTEM)
                            ora = new Oracle("INSERT into CRPDTA.F0911Z1 VALUES (@VNEDUS, @VNEDTY, @VNEDSQ, @VNEDTN, @VNEDCT, @VNEDLN, @VNEDTS, @VNEDFT, @VNEDDT, @VNEDER, @VNEDDL, @VNEDSP, @VNEDTC, @VNEDTR, @VNEDBT, @VNEDGL, @VNEDAN, @VNKCO, @VNDCT, @VNDOC, @VNDGJ, @VNJELN, @VNEXTL, @VNPOST, @VNICU, @VNICUT, @VNDICJ, @VNDSYJ, @VNTICU, @VNCO, @VNANI, @VNAM, @VNAID, @VNMCU, @VNOBJ, @VNSUB, @VNSBL, @VNSBLT, @VNLT, @VNPN, @VNCTRY, @VNFY, @VNFQ, @VNCRCD, @VNCRR, @VNHCRR, @VNHDGJ, @VNAA, @VNU, @VNUM, @VNGLC, @VNRE, @VNEXA, @VNEXR, @VNR1, @VNR2, @VNR3, @VNSFX, @VNODOC, @VNODCT, @VNOSFX, @VNPKCO, @VNOKCO, @VNPDCT, @VNAN8, @VNCN, @VNDKJ, @VNDKC, @VNASID, @VNBRE, @VNRCND, @VNSUMM, @VNPRGE, @VNTNN, @VNALT1, @VNALT2, @VNALT3, @VNALT4, @VNALT5, @VNALT6, @VNALT7, @VNALT8, @VNALT9, @VNALT0, @VNALTT, @VNALTU, @VNALTV, @VNALTW, @VNALTX, @VNALTZ, @VNDLNA, @VNCFF1, @VNCFF2, @VNASM, @VNBC, @VNVINV, @VNIVD, @VNWR01, @VNPO, @VNPSFX, @VNDCTO, @VNLNID, @VNWY, @VNWN, @VNFNLP, @VNOPSQ, @VNJBCD, @VNJBST, @VNHMCU, @VNDOI, @VNALID, @VNALTY, @VNDSVJ, @VNTORG, @VNREGPOUND, @VNPYID, @VNUSER, @VNPID, @VNJOBN, @VNUPMJ, @VNUPMT, @VNCRRM, @VNACR, @VNDGM, @VNDGD, @VNDGY, @VNGDGPOUND, @VNDICM, @VNDICD, @VNDICY, @VNDICPOUND, @VNDSYM, @VNDSYS, @VNDSYY, @VNDSYPOUND, @VNDKM, @VNDKD, @VNDKY, @VNDKPOUND, @VNDSVM, @VNDSVD, @VNDSVY, @VNDSVPOUND, @VNHDGM, @VNHDGD, @VNHDGY, @VNHDGPOUND, @VNDKCM, @VNDKCD, @VNDKCY, @VNDKCPOUND, @VNIVDM, @VNIVDD, @VNIVDY, @VNIVDPOUND, @VNABR1, @VNABR2, @VNABR3, @VNABR4, @VNABT1, @VNABT2, @VNABT3, @VNABT4, @VNITM, @VNPM01, @VNPM02, @VNPM03, @VNPM04, @VNPM05, @VNPM06, @VNPM07, @VNPM08, @VNPM09, @VNPM10, @VNBCRC, @VNEXR1, @VNTXA1, @VNTXITM, @VNACTB, @VNSTAM, @VNCTAM, @VNAG, @VNAGF, @VNTKTX, @VNDLNID, @VNCKNU, @VNBUPC, @VNAHBU, @VNEPGC, @VNJPGC, @VNRC5, @VNSFXE, @VNOFM)");
                        else
                            ora = new Oracle("INSERT into PRODDTA.F0911Z1 VALUES (@VNEDUS, @VNEDTY, @VNEDSQ, @VNEDTN, @VNEDCT, @VNEDLN, @VNEDTS, @VNEDFT, @VNEDDT, @VNEDER, @VNEDDL, @VNEDSP, @VNEDTC, @VNEDTR, @VNEDBT, @VNEDGL, @VNEDAN, @VNKCO, @VNDCT, @VNDOC, @VNDGJ, @VNJELN, @VNEXTL, @VNPOST, @VNICU, @VNICUT, @VNDICJ, @VNDSYJ, @VNTICU, @VNCO, @VNANI, @VNAM, @VNAID, @VNMCU, @VNOBJ, @VNSUB, @VNSBL, @VNSBLT, @VNLT, @VNPN, @VNCTRY, @VNFY, @VNFQ, @VNCRCD, @VNCRR, @VNHCRR, @VNHDGJ, @VNAA, @VNU, @VNUM, @VNGLC, @VNRE, @VNEXA, @VNEXR, @VNR1, @VNR2, @VNR3, @VNSFX, @VNODOC, @VNODCT, @VNOSFX, @VNPKCO, @VNOKCO, @VNPDCT, @VNAN8, @VNCN, @VNDKJ, @VNDKC, @VNASID, @VNBRE, @VNRCND, @VNSUMM, @VNPRGE, @VNTNN, @VNALT1, @VNALT2, @VNALT3, @VNALT4, @VNALT5, @VNALT6, @VNALT7, @VNALT8, @VNALT9, @VNALT0, @VNALTT, @VNALTU, @VNALTV, @VNALTW, @VNALTX, @VNALTZ, @VNDLNA, @VNCFF1, @VNCFF2, @VNASM, @VNBC, @VNVINV, @VNIVD, @VNWR01, @VNPO, @VNPSFX, @VNDCTO, @VNLNID, @VNWY, @VNWN, @VNFNLP, @VNOPSQ, @VNJBCD, @VNJBST, @VNHMCU, @VNDOI, @VNALID, @VNALTY, @VNDSVJ, @VNTORG, @VNREGPOUND, @VNPYID, @VNUSER, @VNPID, @VNJOBN, @VNUPMJ, @VNUPMT, @VNCRRM, @VNACR, @VNDGM, @VNDGD, @VNDGY, @VNGDGPOUND, @VNDICM, @VNDICD, @VNDICY, @VNDICPOUND, @VNDSYM, @VNDSYS, @VNDSYY, @VNDSYPOUND, @VNDKM, @VNDKD, @VNDKY, @VNDKPOUND, @VNDSVM, @VNDSVD, @VNDSVY, @VNDSVPOUND, @VNHDGM, @VNHDGD, @VNHDGY, @VNHDGPOUND, @VNDKCM, @VNDKCD, @VNDKCY, @VNDKCPOUND, @VNIVDM, @VNIVDD, @VNIVDY, @VNIVDPOUND, @VNABR1, @VNABR2, @VNABR3, @VNABR4, @VNABT1, @VNABT2, @VNABT3, @VNABT4, @VNITM, @VNPM01, @VNPM02, @VNPM03, @VNPM04, @VNPM05, @VNPM06, @VNPM07, @VNPM08, @VNPM09, @VNPM10, @VNBCRC, @VNEXR1, @VNTXA1, @VNTXITM, @VNACTB, @VNSTAM, @VNCTAM, @VNAG, @VNAGF, @VNTKTX, @VNDLNID, @VNCKNU, @VNBUPC, @VNAHBU, @VNEPGC, @VNJPGC, @VNRC5, @VNSFXE, @VNOFM)");

                        ora.AddParameter("@VNEDUS", "JDE");
                        ora.AddParameter("@VNEDTY", "T");
                        ora.AddParameter("@VNEDSQ", 0);
                        ora.AddParameter("@VNEDTN", "1");
                        ora.AddParameter("@VNEDCT", " ");
                        ora.AddParameter("@VNEDLN", VNEDLN);
                        ora.AddParameter("@VNEDTS", " ");
                        ora.AddParameter("@VNEDFT", " ");
                        ora.AddParameter("@VNEDDT", 0);
                        ora.AddParameter("@VNEDER", "B");
                        ora.AddParameter("@VNEDDL", 0);
                        ora.AddParameter("@VNEDSP", "0");
                        ora.AddParameter("@VNEDTC", "A");
                        ora.AddParameter("@VNEDTR", "J");
                        ora.AddParameter("@VNEDBT", VNEDBT);
                        ora.AddParameter("@VNEDGL", " ");
                        ora.AddParameter("@VNEDAN", 0);
                        ora.AddParameter("@VNKCO", "01000");
                        ora.AddParameter("@VNDCT", "TE");
                        ora.AddParameter("@VNDOC", 0);
                        ora.AddParameter("@VNDGJ", VNDGJ);
                        ora.AddParameter("@VNJELN", VNJELN);
                        ora.AddParameter("@VNEXTL", " ");
                        ora.AddParameter("@VNPOST", " ");
                        ora.AddParameter("@VNICU", 0);
                        ora.AddParameter("@VNICUT", "T");
                        ora.AddParameter("@VNDICJ", 0);
                        ora.AddParameter("@VNDSYJ", 0);
                        ora.AddParameter("@VNTICU", 0);
                        ora.AddParameter("@VNCO", "01000");
                        ora.AddParameter("@VNANI", negativeVNANI);
                        ora.AddParameter("@VNAM", "2");
                        ora.AddParameter("@VNAID", " ");
                        ora.AddParameter("@VNMCU", negativeVNMCU);
                        ora.AddParameter("@VNOBJ", negativeVNOBJ);
                        ora.AddParameter("@VNSUB", negativeVNSUB);
                        ora.AddParameter("@VNSBL", "        ");
                        ora.AddParameter("@VNSBLT", " ");
                        ora.AddParameter("@VNLT", "AA");
                        ora.AddParameter("@VNPN", VNPN);
                        ora.AddParameter("@VNCTRY", 20);
                        ora.AddParameter("@VNFY", VNFY);
                        ora.AddParameter("@VNFQ", " ");
                        ora.AddParameter("@VNCRCD", " ");
                        ora.AddParameter("@VNCRR", 0);
                        ora.AddParameter("@VNHCRR", 0);
                        ora.AddParameter("@VNHDGJ", 0);
                        ora.AddParameter("@VNAA", negativeVNAA);
                        ora.AddParameter("@VNU", VNU.ToString());
                        ora.AddParameter("@VNUM", " ");
                        ora.AddParameter("@VNGLC", " ");
                        ora.AddParameter("@VNRE", " ");
                        ora.AddParameter("@VNEXA", VNEXA);
                        ora.AddParameter("@VNEXR", VNEXR);
                        ora.AddParameter("@VNR1", VNR1.Substring(0, Math.Min(8, VNR1.Length)));
                        ora.AddParameter("@VNR2", " ");
                        ora.AddParameter("@VNR3", " ");
                        ora.AddParameter("@VNSFX", " ");
                        ora.AddParameter("@VNODOC", 0);
                        ora.AddParameter("@VNODCT", " ");
                        ora.AddParameter("@VNOSFX", " ");
                        ora.AddParameter("@VNPKCO", " ");
                        ora.AddParameter("@VNOKCO", " ");
                        ora.AddParameter("@VNPDCT", " ");
                        ora.AddParameter("@VNAN8", 0);
                        ora.AddParameter("@VNCN", " ");
                        ora.AddParameter("@VNDKJ", 0);
                        ora.AddParameter("@VNDKC", 0);
                        ora.AddParameter("@VNASID", FAAAIDstring); //Asset ID
                        ora.AddParameter("@VNBRE", " ");
                        ora.AddParameter("@VNRCND", " ");
                        ora.AddParameter("@VNSUMM", " ");
                        ora.AddParameter("@VNPRGE", " ");
                        ora.AddParameter("@VNTNN", " ");
                        ora.AddParameter("@VNALT1", " ");
                        ora.AddParameter("@VNALT2", " ");
                        ora.AddParameter("@VNALT3", " ");
                        ora.AddParameter("@VNALT4", " ");
                        ora.AddParameter("@VNALT5", " ");
                        ora.AddParameter("@VNALT6", " ");
                        ora.AddParameter("@VNALT7", " ");
                        ora.AddParameter("@VNALT8", " ");
                        ora.AddParameter("@VNALT9", " ");
                        ora.AddParameter("@VNALT0", " ");
                        ora.AddParameter("@VNALTT", " ");
                        ora.AddParameter("@VNALTU", " ");
                        ora.AddParameter("@VNALTV", " ");
                        ora.AddParameter("@VNALTW", " ");
                        ora.AddParameter("@VNALTX", " ");
                        ora.AddParameter("@VNALTZ", " ");
                        ora.AddParameter("@VNDLNA", " ");
                        ora.AddParameter("@VNCFF1", " ");
                        ora.AddParameter("@VNCFF2", " ");
                        ora.AddParameter("@VNASM", " ");
                        ora.AddParameter("@VNBC", " ");
                        ora.AddParameter("@VNVINV", " ");
                        ora.AddParameter("@VNIVD", 0);
                        ora.AddParameter("@VNWR01", " ");
                        ora.AddParameter("@VNPO", " ");
                        ora.AddParameter("@VNPSFX", " ");
                        ora.AddParameter("@VNDCTO", " ");
                        ora.AddParameter("@VNLNID", 0);
                        ora.AddParameter("@VNWY", 0);
                        ora.AddParameter("@VNWN", 0);
                        ora.AddParameter("@VNFNLP", " ");
                        ora.AddParameter("@VNOPSQ", 0);
                        ora.AddParameter("@VNJBCD", " ");
                        ora.AddParameter("@VNJBST", " ");
                        ora.AddParameter("@VNHMCU", " ");
                        ora.AddParameter("@VNDOI", 0);
                        ora.AddParameter("@VNALID", " ");
                        ora.AddParameter("@VNALTY", VNALTY);
                        ora.AddParameter("@VNDSVJ", VNDSVJ);
                        ora.AddParameter("@VNTORG", " ");
                        ora.AddParameter("@VNREGPOUND", 0);
                        ora.AddParameter("@VNPYID", 0);
                        ora.AddParameter("@VNUSER", "JDE");
                        ora.AddParameter("@VNPID", " ");
                        ora.AddParameter("@VNJOBN", " ");
                        ora.AddParameter("@VNUPMJ", 0);
                        ora.AddParameter("@VNUPMT", 0);
                        ora.AddParameter("@VNCRRM", " ");
                        ora.AddParameter("@VNACR", 0);
                        ora.AddParameter("@VNDGM", 0);
                        ora.AddParameter("@VNDGD", 0);
                        ora.AddParameter("@VNDGY", 0);
                        ora.AddParameter("@VNGDGPOUND", 0);
                        ora.AddParameter("@VNDICM", 0);
                        ora.AddParameter("@VNDICD", 0);
                        ora.AddParameter("@VNDICY", 0);
                        ora.AddParameter("@VNDICPOUND", 0);
                        ora.AddParameter("@VNDSYM", 0);
                        ora.AddParameter("@VNDSYS", 0);
                        ora.AddParameter("@VNDSYY", 0);
                        ora.AddParameter("@VNDSYPOUND", 0);
                        ora.AddParameter("@VNDKM", 0);
                        ora.AddParameter("@VNDKD", 0);
                        ora.AddParameter("@VNDKY", 0);
                        ora.AddParameter("@VNDKPOUND", 0);
                        ora.AddParameter("@VNDSVM", 0);
                        ora.AddParameter("@VNDSVD", 0);
                        ora.AddParameter("@VNDSVY", 0);
                        ora.AddParameter("@VNDSVPOUND", 0);
                        ora.AddParameter("@VNHDGM", 0);
                        ora.AddParameter("@VNHDGD", 0);
                        ora.AddParameter("@VNHDGY", 0);
                        ora.AddParameter("@VNHDGPOUND", 0);
                        ora.AddParameter("@VNDKCM", 0);
                        ora.AddParameter("@VNDKCD", 0);
                        ora.AddParameter("@VNDKCY", 0);
                        ora.AddParameter("@VNDKCPOUND", 0);
                        ora.AddParameter("@VNIVDM", 0);
                        ora.AddParameter("@VNIVDD", 0);
                        ora.AddParameter("@VNIVDY", 0);
                        ora.AddParameter("@VNIVDPOUND", 0);
                        ora.AddParameter("@VNABR1", " ");
                        ora.AddParameter("@VNABR2", " ");
                        ora.AddParameter("@VNABR3", " ");
                        ora.AddParameter("@VNABR4", " ");
                        ora.AddParameter("@VNABT1", " ");
                        ora.AddParameter("@VNABT2", " ");
                        ora.AddParameter("@VNABT3", " ");
                        ora.AddParameter("@VNABT4", " ");
                        ora.AddParameter("@VNITM", 0);
                        ora.AddParameter("@VNPM01", " ");
                        ora.AddParameter("@VNPM02", " ");
                        ora.AddParameter("@VNPM03", " ");
                        ora.AddParameter("@VNPM04", " ");
                        ora.AddParameter("@VNPM05", " ");
                        ora.AddParameter("@VNPM06", " ");
                        ora.AddParameter("@VNPM07", " ");
                        ora.AddParameter("@VNPM08", " ");
                        ora.AddParameter("@VNPM09", " ");
                        ora.AddParameter("@VNPM10", " ");
                        ora.AddParameter("@VNBCRC", " ");
                        ora.AddParameter("@VNEXR1", " ");
                        ora.AddParameter("@VNTXA1", " ");
                        ora.AddParameter("@VNTXITM", 0);
                        ora.AddParameter("@VNACTB", " ");
                        ora.AddParameter("@VNSTAM", 0);
                        ora.AddParameter("@VNCTAM", 0);
                        ora.AddParameter("@VNAG", negativeVNAG);
                        ora.AddParameter("@VNAGF", 0);
                        ora.AddParameter("@VNTKTX", " ");
                        ora.AddParameter("@VNDLNID", 0);
                        ora.AddParameter("@VNCKNU", " ");
                        ora.AddParameter("@VNBUPC", " ");
                        ora.AddParameter("@VNAHBU", " ");
                        ora.AddParameter("@VNEPGC", " ");
                        ora.AddParameter("@VNJPGC", " ");
                        ora.AddParameter("@VNRC5", 0);
                        ora.AddParameter("@VNSFXE", 0);
                        ora.AddParameter("@VNOFM", " ");

                        dt = ora.Run();

                        Thread.Sleep(sleep);

                        Console.WriteLine("- - - 6/6 Updating Local Table");

                        strSql = "UPDATE EquipmentTimeEntry SET SENT='True' WHERE EquipID=@EquipID AND TimesheetID=@TimesheetID";
                        SqlCommand scom = new SqlCommand(strSql, con);
                        scom.Parameters.Add("@EquipID", SqlDbType.VarChar, 50).Value = equipID[i];
                        scom.Parameters.Add("@TimesheetID", SqlDbType.VarChar, 50).Value = timesheetID[i];
                        SqlDataAdapter ssda = new SqlDataAdapter(scom);
                        DataTable dt3 = new DataTable();
                        ssda.Fill(dt3);
                    }
                }
            }
        }
    }
}
