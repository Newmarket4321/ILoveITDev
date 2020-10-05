using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace I_IT
{
    public class ISIDownload
    {
        static string ftpServerIP = "ftp.isilive.ca";
        static string ftpUserID = "newmarket";
        static string ftpPassword = "37ve9mq";
        static string ftpURI = "ftp://" + ftpServerIP + "/";

        static string localPath = @"\\172.16.0.12\VideoStorage\Council\";
        static int retryMAX = 20;

        public ISIDownload()
        {
            string[] files = GetFileList();

            if(files == null || files.Length == 0)
            {
                Console.WriteLine("File list is null or empty");
                return;
            }

            Console.WriteLine("Downloading files");

            for (int i = 0; i < files.Length; i++)
                //if (!File.Exists(localPath + files[i]))
                    Download(files[i]);
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

            //for (int retryNo = 1; retryNo <= retryMAX && !success; retryNo++)
            //{
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

                string categoryFolder;

                if (file.Contains("CM"))
                    categoryFolder = "Council";
                else if (file.Contains("SPC"))
                    categoryFolder = "Special Council";
                else if (file.Contains("SCOW"))
                    categoryFolder = "Special Committee of the Whole";
                else if (file.Contains("COW"))
                    categoryFolder = "Committee of the Whole";
                else if (file.Contains("CW"))
                    categoryFolder = "Council Workshop";
                else
                    categoryFolder = "Other";

                DateTime date = getDate(file);
                string extension = getExtension(file);

                string dateFolder = date.ToString("MMMM dd yyyy");

                string newFilename = categoryFolder == "Other" || date.Year == 1900 ? file : categoryFolder + " " + date.ToString("MMMM dd yyyy, hh-mm") + extension;

                if (!Directory.Exists(localPath + categoryFolder))
                    Directory.CreateDirectory(localPath + categoryFolder);

                if(categoryFolder != "Other")
                    if (!Directory.Exists(localPath + categoryFolder + @"\" + dateFolder))
                        Directory.CreateDirectory(localPath + categoryFolder + @"\" + dateFolder);

                string writePath = categoryFolder == "Other" || date.Year == 1900 ? localPath + categoryFolder + @"\" + newFilename : localPath + categoryFolder + @"\" + dateFolder + @"\" + newFilename;

                Console.WriteLine(writePath);

                if (!File.Exists(writePath) && extension != ".html")
                {
                    FileStream writeStream = new FileStream(writePath, FileMode.Create);
                    int Length = 2048;
                    Byte[] buffer = new Byte[Length];
                    int bytesRead = responseStream.Read(buffer, 0, Length);
                    while (bytesRead > 0)
                    {
                        writeStream.Write(buffer, 0, bytesRead);
                        bytesRead = responseStream.Read(buffer, 0, Length);
                    }
                    writeStream.Close();
                }
                
                response.Close();

                success = true;
            }
            catch (Exception e)
            {
                //Console.Write("Attempt " + 0 + " of " + retryMAX + ": " + e.Message);
            }
            //}
        }

        static private DateTime getDate(string file)
        {
            try
            {
                //New Encoder_COW_2018-06-08-11-05.mp4
                int year = int.Parse(file.Split('_')[2].Split('.')[0].Substring(0, 4));
                int month = int.Parse(file.Split('_')[2].Split('.')[0].Substring(5, 2));
                int day = int.Parse(file.Split('_')[2].Split('.')[0].Substring(8, 2));
                int hour = int.Parse(file.Split('_')[2].Split('.')[0].Substring(11, 2));
                int minute = int.Parse(file.Split('_')[2].Split('.')[0].Substring(14, 2));

                return new DateTime(year, month, day, hour, minute, 0);
            }
            catch
            {
                return new DateTime(1900, 1, 1);
            }
        }

        static private string getExtension(string file)
        {
            return file.Substring(file.LastIndexOf('.'), file.Length - file.LastIndexOf('.'));
        }
    }
}