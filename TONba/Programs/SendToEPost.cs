using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace I_IT
{
    class SendToEPost
    {
        static string ftpServerIP = "198.33.200.17";
        static string ftpUserID = "newmarket";
        static string ftpPassword = "BCbtw*HU";
        static string ftpURI = "ftp://" + ftpServerIP + "/incoming/";

        static int retryMAX = 20;

        public SendToEPost()
        {
            //Zip everything, individually wrapped
            string[] files = Directory.GetFiles(@"V:\epost\receiver\");

            for (int i = 0; i < files.Length; i++)
                if (files[i].Contains(".zip"))
                    File.Delete(files[i]);

            Directory.CreateDirectory(@"V:\epost\receiver\temp");
            files = Directory.GetFiles(@"V:\epost\receiver\");

            for (int i = 0; i < files.Length; i++)
            {
                File.Copy(files[i], files[i].Replace(@"receiver\", @"receiver\temp\"));
                ZipFile.CreateFromDirectory(@"V:\epost\receiver\temp", files[i].Replace(files[i].Substring(files[i].IndexOf('.')), ".zip")); //Replace extension with .zip
                File.Delete(files[i]);
                File.Delete(files[i].Replace(@"receiver\", @"receiver\temp\"));
            }

            Directory.Delete(@"V:\epost\receiver\temp", true);

            //Send files
            files = Directory.GetFiles(@"V:\epost\outgoing\");

            for (int i = 0; i < files.Length; i++)
            {
                export(files[i], 1);
                File.Move(files[i], files[i].Replace(@"V:\epost\outgoing\", @"V:\epost\archive\outgoing\"));
            }

            files = Directory.GetFiles(@"V:\epost\receiver\");

            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Contains(".zip"))
                    export(files[i], 1);

                File.Move(files[i], files[i].Replace(@"V:\epost\receiver\", @"V:\epost\archive\receiver\"));
            }
        }
        
        static private void export(string file, int attemptNo)
        {
            if (attemptNo > 1)
                Console.WriteLine("Retrying (" + attemptNo + "/" + retryMAX + ")");

            try
            {
                // Get the object used to communicate with the server.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + ftpServerIP + "/ftp/import/digipen" + DateTime.Now.ToString("yyyyMMddHHmm") + ".csv");
                request.Method = WebRequestMethods.Ftp.UploadFile;

                // This example assumes the FTP site uses anonymous logon.
                request.Credentials = new NetworkCredential(ftpUserID, ftpPassword);

                // Copy the contents of the file to the request stream.
                StreamReader sourceStream = new StreamReader(file);
                byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                sourceStream.Close();
                request.ContentLength = fileContents.Length;

                Stream requestStream = request.GetRequestStream();
                requestStream.Write(fileContents, 0, fileContents.Length);
                requestStream.Close();

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                Console.WriteLine("File upload complete, status:" + Environment.NewLine + " {0}", response.StatusDescription);

                response.Close();
            }
            catch (WebException wEx)
            {
                Console.Write(wEx.Message);

                if (attemptNo < retryMAX)
                {
                    export(file, attemptNo + 1);
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);

                if (attemptNo < retryMAX)
                {
                    export(file, attemptNo + 1);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
