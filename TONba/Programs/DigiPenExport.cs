using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace I_IT
{
    class DigiPenExport
    {
        bool sendFiles = true;

        public DigiPenExport()
        {
            if (Core.getUsername() != "IHeartIT")
                Core.setVariable("DigiPenBreaker", "False");

            bool breaker = Core.getVariable("DigiPenBreaker") == "True";

            if (breaker)
                return;

            DataTable dt = null;

            try
            {
                dt = Oracle.Run(@"
SELECT
CRPDTA.F4801.WADOCO,
CRPDTA.F4801.WATYPS,
Trim(CRPDTA.F1201.FAAPID),
Trim(DRDL01),
Trim(FHLNUM),
Trim(Trim(FADL01) || ' ' || Trim(FADL02) || ' ' || Trim(FADL03)),
Trim(CRPDTA.F1201.FAASID),
Trim(WADL01),
CRPDTA.F4801.WATRDJ,
CRPDTA.F4801T.WAWR11

FROM CRPDTA.F4801

LEFT JOIN CRPDTA.F1201 ON CRPDTA.F4801.WANUMB = CRPDTA.F1201.FANUMB
LEFT JOIN CRPDTA.F1206 ON CRPDTA.F1201.FANUMB = CRPDTA.F1206.FHNUMB
LEFT JOIN CRPDTA.F4801T ON CRPDTA.F4801.WADOCO = CRPDTA.F4801T.WADOCO
LEFT JOIN CRPCTL.F0005 ON CRPDTA.F1201.FAACL3 = Trim(CRPCTL.F0005.DRKY)

WHERE (CRPCTL.F0005.DRSY='12' or CRPCTL.F0005.DRSY = null)
AND (CRPCTL.F0005.DRRT='C3' or CRPCTL.F0005.DRRT = null)
AND CRPDTA.F4801.WAWR06='20 '
AND CRPDTA.F4801.WADOCO > 35038
AND CRPDTA.F4801.WADOCO < 89000
AND CRPDTA.F4801.WADOCO not in (select WADOCO from CRPDTA.F554801)

ORDER BY CRPDTA.F4801.WADOCO");

                string output = "";

                for (int r = 0; r < dt.Rows.Count; r++)
                {
                    //lastUpdate = Math.Max(lastUpdate, int.Parse(dt.Rows[r]["WADOCO"].ToString()));

                    for (int c = 0; c < dt.Columns.Count; c++)
                    {
                        output += dt.Rows[r][c].ToString().Trim();

                        if (c + 1 < dt.Columns.Count) //If there will be another iteration
                            output += "\t";
                    }

                    if (r + 1 < dt.Rows.Count) //If there will be another row
                        output += Environment.NewLine;

                    Console.WriteLine("Exporting work order " + dt.Rows[r]["WADOCO"].ToString());
                }

                if (output != "")
                {
                    string outputPath = @"C:\digipen" + DateTime.Now.ToString("yyyyMMddHHmm") + ".csv";

                    try
                    {
                        File.WriteAllText(outputPath, output);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        //Most likely doesn't have access to C:\
                        outputPath = Core.getUserDesktopDirectory() + DateTime.Now.ToString("yyyyMMddHHmm") + ".csv";

                        File.WriteAllText(outputPath, output);
                    }

                    bool result = true;
                    
                    if (sendFiles)
                        result = export(outputPath, 1);

                    if (sendFiles && result)
                    {
                        string[] lines = File.ReadAllLines(outputPath);
                        for (int i = 0; i < lines.Length; i++)
                        {
                            Core.log("DigiPenExport", "Work order exported", lines[i].Split('\t')[0]);

                            string wo = lines[i].Split('\t')[0];
                            string wodate = Core.dateToJDE(DateTime.Today);
                            int wotime = Core.timeToJDE(DateTime.Now);
                            string wouser = "JDE";

                            if (sendFiles)
                                Oracle.Run("insert into CRPDTA.F554801 values (@WO, @WODATE, @WOTIME, @WOUSER)", wo, wodate, wotime, wouser);
                        }
                    }
                    else if (sendFiles && !result)
                        Core.error(new Exception("DigiPenExport didn't work. Check log for details."));

                    File.Delete(outputPath);
                }
                else
                    Console.WriteLine("No work orders to export");
            }
            catch (Exception e)
            {
                //Core.setVariable("DigiPenBreaker", "True");
                //Core.error(new Exception("DigiPenExport Error - " + Core.getErrorText(e)));
                Core.log("DigiPenExport", "Error", e.Message);
                return;
            }
        }

        static private bool export(string file, int attemptNo)
        {
            string ftpServerIP = "ftp.iformation.ca";
            string ftpUserID = "ftp_nwmkt";
            string ftpPassword = "gH2ih(*G&234";
            int maxAttempts = 10;
            byte[] fileContents = null;
            FtpWebRequest request = null;
            FtpWebResponse response = null;

            if (attemptNo > 1)
                Console.WriteLine("Retrying (" + attemptNo + "/" + maxAttempts + ")");

            // Get the object used to communicate with the server.
            request = (FtpWebRequest)WebRequest.Create("ftp://" + ftpServerIP + "/ftp/import/digipen" + DateTime.Now.ToString("yyyyMMddHHmm") + ".csv");
            request.Method = WebRequestMethods.Ftp.UploadFile;

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
            request.Timeout = 10000;

            // Copy the contents of the file to the request stream.
            StreamReader sourceStream = new StreamReader(file);
            fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            sourceStream.Close();
            request.ContentLength = fileContents.Length;
            
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);
            requestStream.Close();

            response = (FtpWebResponse)request.GetResponse();

            Console.WriteLine("File upload complete, status:" + Environment.NewLine + " {0}", response.StatusDescription);
            Core.log("DigiPenExport-Dev", "File upload complete", response.StatusDescription);

            response.Close();
            
            return true;
            
            //catch (WebException wEx)
            //{
            //    Console.Write(wEx.Message);

            //    if (attemptNo < maxAttempts)
            //    {
            //        Thread.Sleep(500);
            //        return export(file, attemptNo + 1);
            //    }
            //    else
            //    {
            //        Core.log("DigiPenExport", "Error", response == null ? "Null" : response.StatusDescription);
            //        return false;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.Write(ex.Message);

            //    if (attemptNo < maxAttempts)
            //    {
            //        Thread.Sleep(500);
            //        return export(file, attemptNo + 1);
            //    }
            //    else
            //    {
            //        Core.log("DigiPenExport", "Error", response == null ? "Null" : response.StatusDescription);
            //        return false;
            //    }
            //}
        }
    }
}
