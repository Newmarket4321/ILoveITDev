using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Net;
using System.Threading;

namespace I_IT
{
    class DigiPenImport
    {
        //EAC
        static string environment = "PY";
        static string schema = Core.getSchema(environment);
        static string controlSchema = Core.getControlSchema(environment);

        //static string ftpServerIP = "cloud06.iformation.ca";
        static string ftpServerIP = "ftp.iformation.ca";
        static string ftpUserID = "ftp_nwmkt";
        static string ftpPassword = "gH2ih(*G&234";
        static string ftpURI = "ftp://" + ftpServerIP + "/ftp/export/";

        static string localDestnDir = "C:\\DigitalPen\\";
        static string serverPath = "\\\\JDEDEPLOY\\E920\\mediaobj\\htmlupload\\";
        //EAC
        //static string serverPath = "\\\\Deployment1\\e910\\mediaobj\\htmlupload\\";
        static int retryMAX = 20;

        public DigiPenImport()
        {
            if(!Directory.Exists(localDestnDir))
                Directory.CreateDirectory(localDestnDir);

            handleTxt();
            handlePdf();
        }

        static DateTime getDate(string temp)
        {
            int year = int.Parse(temp.Substring(0, 4));
            int month = int.Parse(temp.Substring(4, 2));
            int day = int.Parse(temp.Substring(6, 2));
            int hour = int.Parse(temp.Substring(8, 2));
            int minute = int.Parse(temp.Substring(10, 2));
            int second = int.Parse(temp.Substring(12, 2));
            DateTime date = new DateTime(year, month, day, hour, minute, second);

            return date;
        }

        static void handlePdf()
        {
            string[] files = GetFileList();

            if(files != null && files.Length > 0)
            {
                int[] wo = new int[files.Length];
                DateTime[] date = new DateTime[files.Length];
                int numItems = 0;
                int[] woStatus = new int[files.Length];

                Console.WriteLine("Downloading PDF files");

                for (int i = 0; i < files.Length; i++)
                {
                    string file = files[i];

                    if (file.ToLower().Contains(".pdf"))
                    {
                        DateTime fileDate = getDate(file.Split('_')[1]);

                        if (fileDate.AddDays(7) > DateTime.Today)
                        {
                            int index = Array.FindIndex(wo, item => item == int.Parse(file.Split('_')[0]));

                            if (index != -1)
                            {
                                if (getDate(file.Split('_')[1]) > date[index])
                                {
                                    date[index] = fileDate;
                                }
                            }
                            else
                            {
                                wo[numItems] = int.Parse(file.Split('_')[0]);
                                date[numItems] = fileDate;

                                Oracle ora = new Oracle("select WASRST from " + schema + ".F4801 where WADOCO=@ID");
                                ora.AddParameter("@ID", wo[numItems]);
                                int.TryParse(ora.Run().Rows[0][0].ToString(), out woStatus[numItems]);
                                numItems++;
                            }

                            Console.WriteLine("File " + (i + 1) + " of " + files.Length + " - " + file.Split('_')[0]);

                            Download(file);
                        }
                    }
                }

                files = new string[numItems];
                int sequenceNumber = 1;

                for (int i = 0; i < numItems; i++)
                {
                    string dateString = date[i].Year.ToString() + z(date[i].Month.ToString()) + z(date[i].Day.ToString()) + z(date[i].Hour.ToString()) + z(date[i].Minute.ToString()) + z(date[i].Second.ToString());
                    files[i] = wo[i].ToString() + "_" + dateString + ".pdf";

                    Oracle ora = new Oracle("select * from " + schema + ".F00165 where trim(GDGTITNM)=@FILENAME");
                    ora.AddParameter("@FILENAME", files[i]);
                    bool alreadyExists = ora.Run().Rows.Count >= 1;

                    if (wo[i] != 32344 && wo[i] != 32332 && wo[i] != 32571)
                    {
                        if (woStatus[i] == 80 && !alreadyExists)
                        {
                            try
                            {
                                Console.WriteLine("Processing " + files[i]);
                                processPDF(files[i], sequenceNumber++);

                                Core.log("DigiPenImport", "File processed", files[i]);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error with PDF of work order #" + wo[i]);
                            }
                        }
                    }
                }
            }
        }

        static void handleTxt()
        {
            string[] files = GetFileList();

            if (files != null && files.Length > 0)
            {
                int[] wo = new int[files.Length];
                DateTime[] date = new DateTime[files.Length];
                int numItems = 0;

                Console.WriteLine("Downloading text files");

                for (int i = 0; i < files.Length; i++)
                {
                    string file = files[i];

                    if (file.ToLower().Contains(".txt"))
                    {
                        DateTime fileDate = getDate(file.Split('_')[1]);

                        if (fileDate.AddDays(7) > DateTime.Today)
                        {

                            int index = Array.FindIndex(wo, item => item == int.Parse(file.Split('_')[0]));

                            if (index != -1)
                            {
                                if (getDate(file.Split('_')[1]) > date[index])
                                {
                                    date[index] = fileDate;
                                }
                            }
                            else
                            {
                                wo[numItems] = int.Parse(file.Split('_')[0]);
                                date[numItems] = getDate(file.Split('_')[1]);
                                numItems++;
                            }

                            Console.WriteLine("File " + (i + 1) + " of " + files.Length + " - " + file.Split('_')[0]);
                            Download(file);
                        }
                    }
                }

                files = new string[numItems];

                for (int i = 0; i < numItems; i++)
                {
                    string dateString = date[i].Year.ToString() + z(date[i].Month.ToString()) + z(date[i].Day.ToString()) + z(date[i].Hour.ToString()) + z(date[i].Minute.ToString()) + z(date[i].Second.ToString());
                    files[i] = wo[i].ToString() + "_" + dateString + ".txt";

                    if (wo[i] != 32344 && wo[i] != 32332 && wo[i] != 32571)
                    {
                        try
                        {
                            Console.WriteLine("Processing " + files[i]);
                            process(files[i]);

                            Core.log("DigiPenImport", "File processed", files[i]);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.GetType().Name + Environment.NewLine
                            + e.Message + Environment.NewLine
                            + Environment.NewLine
                            + (e.InnerException != null ? e.InnerException + Environment.NewLine : "")
                            + e.StackTrace + Environment.NewLine);
                        }
                    }
                }
            }
        }

        static void processPDF(string file, int sequenceNumber)
        {
            try
            {
                File.Move(localDestnDir + file, serverPath + file);
            }
            catch (IOException)
            {

            }

            //Oracle ora = new Oracle("insert into " + schema + ".F00165 (GDOBNM, GDTXKY, GDMOSEQN, GDGTMOTYPE, GDLNGP, GDUSER, GDUPMJ, GDTDAY, GDGTITNM, GDQUNAM, GDGTFILENM, GDGTFUTS1, GDGTFUTS2, GDGTFUTS3, GDGTFUTS4, GDGTFUTM1, GDGTFUTM2) values @GDOBNM, @GDTXKY, @GDMOSEQN, @GDGTMOTYPE, @GDLNGP, @GDUSER, @GDUPMJ, @GDTDAY, @GDGTITNM, @GDQUNAM, @GDGTFILENM, @GDGTFUTS1, @GDGTFUTS2, @GDGTFUTS3, @GDGTFUTS4, @GDGTFUTM1, @GDGTFUTM2");
            Oracle ora = new Oracle("insert into " + schema + ".F00165 values (@GDOBNM, @GDTXKY, @GDMOSEQN, @GDGTMOTYPE, @GDLNGP, @GDUSER, @GDUPMJ, @GDTDAY, @GDGTITNM, @GDQUNAM, @GDGTFILENM, @GDGTFUTS1, @GDGTFUTS2, @GDGTFUTS3, @GDGTFUTS4, @GDGTFUTM1, @GDGTFUTM2, @GDTFXT)");

            ora.AddParameter("@GDOBNM", "GT4801A");
            ora.AddParameter("@GDTXKY", file.Split('_')[0]); //Work order
            ora.AddParameter("@GDMOSEQN", sequenceNumber);
            ora.AddParameter("@GDGTMOTYPE", 5);
            ora.AddParameter("@GDLNGP", "  ");
            ora.AddParameter("@GDUSER", "JDE");
            ora.AddParameter("@GDUPMJ", dateToJDE(DateTime.Today.ToString("MM/dd/yyyy"))); //Update date
            ora.AddParameter("@GDTDAY", z(DateTime.Now.Hour.ToString()) + z(DateTime.Now.Minute.ToString()) + z(DateTime.Now.Second.ToString())); //Update time
            ora.AddParameter("@GDGTITNM", file); //File name
            ora.AddParameter("@GDQUNAM", "                              ");
            ora.AddParameter("@GDGTFILENM", serverPath + file); //File name with path
            ora.AddParameter("@GDGTFUTS1", "          ");
            ora.AddParameter("@GDGTFUTS2", "          ");
            ora.AddParameter("@GDGTFUTS3", "                                                  ");
            ora.AddParameter("@GDGTFUTS4", "                                                  ");
            ora.AddParameter("@GDGTFUTM1", 0);
            ora.AddParameter("@GDGTFUTM2", 0);
            ora.AddParameter("@GDTFXT", "0");
            ora.Run();

            Console.WriteLine(file);
        }

        static void process(string file)
        {

            string line = File.ReadAllText(localDestnDir + file);

            //       32415          97900               01/06/2016      280    NNNNNNNNYN
            int workOrder = -1;
            string unitNumber = "";
            int kmsReading = -1;
            int hrsReading = -1;
            DateTime dateCompleted = new DateTime(1, 1, 1);
            int woType;
            string woStatus;
            string pmType;
            char wr11;
            char wr12;
            char wr13;
            char wr14;
            char wr15;
            char wr16;
            char wr17;
            char wr18;
            char wr19;
            char wr20;

            int.TryParse(line.Substring(0, 12).Trim(), out workOrder);
            unitNumber = line.Substring(12, 12);
            int.TryParse(line.Substring(24, 15).Trim(), out kmsReading);
            int.TryParse(line.Substring(39, 15).Trim(), out hrsReading);

            try
            {
                int year = int.Parse(line.Substring(60, 4));
                int month = int.Parse(line.Substring(54, 2));
                int day = int.Parse(line.Substring(57, 2));
                dateCompleted = new DateTime(year, month, day);
            }
            catch
            {

            }

            int.TryParse(line.Substring(64, 7).Trim(), out woType);
            woStatus = line.Substring(71, 2).Trim();
            pmType = line.Substring(73, 4).Trim();
            char.TryParse(line.Substring(77, 1), out wr11);
            char.TryParse(line.Substring(78, 1), out wr12);
            char.TryParse(line.Substring(79, 1), out wr13);
            char.TryParse(line.Substring(80, 1), out wr14);
            char.TryParse(line.Substring(81, 1), out wr15);
            char.TryParse(line.Substring(82, 1), out wr16);
            char.TryParse(line.Substring(83, 1), out wr17);
            char.TryParse(line.Substring(84, 1), out wr18);
            char.TryParse(line.Substring(85, 1), out wr19);
            char.TryParse(line.Substring(86, 1), out wr20);

            Oracle ora = new Oracle("select F1EWST from " + schema + ".F1307 where F1DOCO=@WOID order by F1EFTB desc, F1BEGT desc");
            ora.AddParameter("@WOID", workOrder);
            int currentStatus = -1;
            DataTable check = ora.Run();

            if (check.Rows.Count > 0)
                int.TryParse(check.Rows[0]["F1EWST"].ToString(), out currentStatus);

            ora = new Oracle(@"
update " + schema + @".F4801
set
" + (dateCompleted.Year != 1 ? "WASTRX=@STRX," : "") + @"
WATYPS=@TYPS,
WASRST=@SRST,
WAWR01=@WR01,
WALOTN=@LOTN,
WAUPMJ=@UPMJ,
WAVR01=@VR01

where WADOCO=@WADOCO
");
            if (dateCompleted.Year != 1)
                ora.AddParameter("@STRX", dateToJDE(dateCompleted.ToString("MM/dd/yyyy")));
            ora.AddParameter("@TYPS", woType);
            ora.AddParameter("@SRST", woStatus);
            ora.AddParameter("@WR01", pmType);
            ora.AddParameter("@LOTN", (kmsReading < 1 ? "" : kmsReading + "KM") + (kmsReading >= 1 && hrsReading >= 1 ? " " : "") + (hrsReading < 1 ? "" : hrsReading + "HRS"));
            ora.AddParameter("@UPMJ", dateToJDE(DateTime.Today.ToString("MM/dd/yyyy")));
            ora.AddParameter("@VR01", unitNumber);
            ora.AddParameter("@WADOCO", workOrder);
            ora.Run();

            ora = new Oracle(@"
update " + schema + @".F4801T
set
WAWR11=@WR11,
WAWR12=@WR12,
WAWR13=@WR13,
WAWR14=@WR14,
WAWR15=@WR15,
WAWR16=@WR16,
WAWR17=@WR17,
WAWR18=@WR18,
WAWR19=@WR19,
WAWR20=@WR20

where WADOCO=@WADOCO

");
            ora.AddParameter("@WR11", wr11 == 'Y' ? "Y" : "   ");
            ora.AddParameter("@WR12", wr12 == 'Y' ? "Y" : "   ");
            ora.AddParameter("@WR13", wr13 == 'Y' ? "Y" : "   ");
            ora.AddParameter("@WR14", wr14 == 'Y' ? "Y" : "   ");
            ora.AddParameter("@WR15", wr15 == 'Y' ? "Y" : "   ");
            ora.AddParameter("@WR16", wr16 == 'Y' ? "Y" : "   ");
            ora.AddParameter("@WR17", wr17 == 'Y' ? "Y" : "   ");
            ora.AddParameter("@WR18", wr18 == 'Y' ? "Y" : "   ");
            ora.AddParameter("@WR19", wr19 == 'Y' ? "Y" : "   ");
            ora.AddParameter("@WR20", wr20 == 'Y' ? "Y" : "   ");
            ora.AddParameter("@WADOCO", workOrder);
            ora.Run();

            if (currentStatus.ToString().Trim() != woStatus && woStatus != "")
            {
                ora = new Oracle("update " + schema + ".F1307 set F1EFTE = @F1EFTE, F1ENDT=@F1ENDT where F1DOCO=@F1DOCO and F1EWST=50");
                ora.AddParameter("@F1DOCO", workOrder);
                ora.AddParameter("@F1EFTE", dateToJDE(DateTime.Today.ToString("MM/dd/yyyy")));
                ora.AddParameter("@F1ENDT", getTime());
                ora.Run();

                //Update max(status)'s end date

                ora = new Oracle("insert into " + schema + ".F1307 values (@F1NUMR, @F1TREC, @F1EFTB, @F1BEGT, @F1EWST, @F1DOCO, @F1EFTE, @F1ENDT, @F1STHR, @F1CUMH, @F1LFR, @F1LHR, @F1LMR, @F1RMK, @F1USER, @F1PID, @F1JOBN, @F1UPMJ, @F1UPMT, @F1LM4R, @F1LM5R, @F1LM6R)");
                ora.AddParameter("@F1NUMR", Oracle.Run("select WANUMB from " + schema + ".F4801 where WADOCO=" + workOrder).Rows[0]["WANUMB"].ToString());
                ora.AddParameter("@F1TREC", Oracle.Run("select max(F1TREC) from " + schema + ".F1307 where F1DOCO=" + workOrder).Rows[0][0].ToString());
                ora.AddParameter("@F1EFTB", dateToJDE(DateTime.Today.ToString("MM/dd/yyyy")));
                ora.AddParameter("@F1BEGT", getTime());
                ora.AddParameter("@F1EWST", woStatus);
                ora.AddParameter("@F1DOCO", workOrder);
                ora.AddParameter("@F1EFTE", woStatus == "80" ? "0" : dateToJDE(DateTime.Today.ToString("MM/dd/yyyy")));
                ora.AddParameter("@F1ENDT", woStatus == "80" ? "0" : z(DateTime.Now.Hour.ToString()) + z(DateTime.Now.Minute.ToString()) + z(DateTime.Now.Second.ToString()));
                ora.AddParameter("@F1STHR", "0");
                ora.AddParameter("@F1CUMH", "0");
                ora.AddParameter("@F1LFR", "0");
                ora.AddParameter("@F1LHR", "0");
                ora.AddParameter("@F1LMR", "0");
                ora.AddParameter("@F1RMK", "                              ");
                ora.AddParameter("@F1USER", "JDE");
                ora.AddParameter("@F1PID", "DigiPen");
                ora.AddParameter("@F1JOBN", "SQL2008R2");
                ora.AddParameter("@F1UPMJ", dateToJDE(DateTime.Today.ToString("MM/dd/yyyy")));
                ora.AddParameter("@F1UPMT", getTime());
                ora.AddParameter("@F1LM4R", "0");
                ora.AddParameter("@F1LM5R", "0");
                ora.AddParameter("@F1LM6R", "0");
                ora.Run();

                if (woStatus == "80")
                {
                    ora = new Oracle(@"select * from " + schema + ".F1207 where FWWONA = @WO and FWMSTS = '50'");
                    //ora.AddParameter("@CHECKSTATUS", "50");
                    ora.AddParameter("@WO", workOrder);
                    DataTable dt = ora.Run();

                    if (dt.Rows.Count > 0)
                    {
                        //Insert into 1207
                        ora = new Oracle(@"insert into " + schema + @".F1207
select
FWNUMB,
FWAPID,
FWASID,
FWSRVT,
'01',
' ',
'          ',
0,
'                              ',
0,
0,
0,
0,
0,
0,
0,
0,
0,
" + dateToJDE(DateTime.Today.ToString("MM/dd/yyyy")) + @",
'DIGIPEN',
'DPENFTP',
" + dateToJDE(DateTime.Today.ToString("MM/dd/yyyy")) + @",
'E1',
FWDOCO,
0,
0,
FWSRVF,
0,
0,
' ',
0,
0,
0,
0,
' ',
" + getTime() + @",
'            ',
FWAAID,
0,
0,
'   ',
'   ',
0,
' ',
" + getPK() + @",
0,
0,
0,
0,
0,
0,
0,
1,
' ',
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0

from " + schema + @".F1207
where FWWONA=@WO and FWMSTS='50'
");
                        ora.AddParameter("@WO", workOrder);
                        ora.Run();

                        int date = int.Parse(dateToJDE(DateTime.Today.ToString("MM/dd/yyyy")));
                        int time = int.Parse(getTime());

                        //Update 1207
                        Oracle.Run("update " + schema + ".F1207 set FWMSTS='98', FWCPLD=" + date + ", FWUSER='DIGIPEN', FWUPMJ=" + date + ", FWUPMT=" + time + ", FWMPC=100 where FWWONA=" + workOrder + " and FWMSTS='50'");
                    }

                    //If Fire, e-mail CYFS
                    if (Oracle.RunString("select trim(WAWR08) from " + schema + ".F4801 where WADOCO = @WO", workOrder) == "FIE")
                    {
                        string emailBody = "The below work order has been completed.<br/>";
                        emailBody += "<br/>";
                        emailBody += "<b>Unit #</b> = " + unitNumber + "<br/>";
                        emailBody += "<b>Work Order #</b> = " + workOrder + "<br/>";
                        emailBody += "<b>Work Order Description</b> = " + Oracle.RunString("select trim(WADL01) from " + schema + ".F4801 where WADOCO=@WO", workOrder);

                        Core.sendMail(Core.getVariable("DigiPenImportCYFSContactList"), "Work Order Completed", emailBody);
                        Core.log("DigiPenImport", "Fire E-mail sent", Core.getVariable("DigiPenImportCYFSContactList"));
                    }
                }

            }

            Console.WriteLine(line + " " + file);
        }

        public static int getPK()
        {
            Oracle ora = new Oracle("select UKUKID from " + schema + ".F00022 where UKOBNM='F1207'");
            int newKey = int.Parse(ora.Run().Rows[0][0].ToString());

            ora = new Oracle("update " + schema + ".F00022 set UKUKID=UKUKID+1 where UKOBNM='F1207'");
            ora.Run();

            return newKey;
        }

        public static string getTime()
        {
            return DateTime.Now.Hour.ToString() + z(DateTime.Now.Minute.ToString()) + z(DateTime.Now.Second.ToString());
        }


        static string z(string x)
        {
            if (x.Length >= 2)
                return x;
            else
                return "0" + x;
        }

        //Takes a date in string format, and returns that string in JDE-style date
        static string dateToJDE(string date)
        {
            string returnable = "1";

            //"MM/dd/yyyy"
            DateTime temp = new DateTime(int.Parse(date.Substring(6, 4)), int.Parse(date.Substring(0, 2)), int.Parse(date.Substring(3, 2)));

            int year = temp.Year;
            int day = temp.DayOfYear;

            returnable += (year.ToString()).Substring(2, 2);

            if (day < 10)
                returnable += "00";
            else if (day < 100)
                returnable += "0";

            returnable += day;

            return returnable;
        }

        static public string[] GetFileList()
        {
            string[] downloadFiles;
            StringBuilder result = new StringBuilder();
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                FtpWebRequest reqFTP;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpURI));
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectory;
                reqFTP.Proxy = null;
                reqFTP.KeepAlive = false;
                reqFTP.UsePassive = false;
                response = reqFTP.GetResponse();
                reader = new StreamReader(response.GetResponseStream());
                string line = reader.ReadLine();
                while (line != null)
                {
                    result.Append(line);
                    result.Append("\n");
                    line = reader.ReadLine();
                }
                // to remove the trailing '\n'
                result.Remove(result.ToString().LastIndexOf('\n'), 1);
                return result.ToString().Split('\n');
            }
            catch (Exception)
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (response != null)
                {
                    response.Close();
                }
                downloadFiles = null;
                return downloadFiles;
            }
        }

        static private void Download(string file)
        {
            bool success = false;

            for (int retryNo = 1; retryNo <= retryMAX && !success; retryNo++)
            {
                try
                {
                    Uri serverUri = new Uri(ftpURI + file);
                    if (serverUri.Scheme != Uri.UriSchemeFtp)
                    {
                        return;
                    }
                    FtpWebRequest reqFTP;
                    reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpURI + file));
                    reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                    reqFTP.KeepAlive = false;
                    reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                    reqFTP.UseBinary = true;
                    reqFTP.Proxy = null;
                    reqFTP.UsePassive = true;// false;
                    FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                    Stream responseStream = response.GetResponseStream();
                    FileStream writeStream = new FileStream(localDestnDir + "\\" + file, FileMode.Create);
                    int Length = 2048;
                    Byte[] buffer = new Byte[Length];
                    int bytesRead = responseStream.Read(buffer, 0, Length);
                    while (bytesRead > 0)
                    {
                        writeStream.Write(buffer, 0, bytesRead);
                        bytesRead = responseStream.Read(buffer, 0, Length);
                    }
                    writeStream.Close();
                    response.Close();

                    success = true;
                }
                catch (Exception e)
                {
                    Console.Write("Attempt " + retryNo + " of " + retryMAX + ": " + e.Message);
                }
            }
        }
    }
}
