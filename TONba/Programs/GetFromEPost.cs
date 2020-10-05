using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace I_IT
{
    class GetFromEPost
    {
        static string ftpServerIP = "198.33.200.17";
        static string ftpUserID = "newmarket";
        static string ftpPassword = "BCbtw*HU";
        static string ftpURI = "ftp://" + ftpServerIP + "/outgoing/";
        
        static int retryMAX = 20;

        public GetFromEPost()
        {
            string[] files = Directory.GetFiles(@"V:\epost\incoming\");

            for (int i = 0; i < files.Length; i++)
                if (files[i].Contains(".zip") || files[i].Contains(".csv") || files[i].Contains(".xml"))
                    File.Delete(files[i]);

            files = GetFileList();

            for(int i = 0; i < files.Length; i++)
            {
                if (files[i].Contains("SR_"))
                {
                    Download(files[i], @"V:\epost\incoming");
                    ZipFile.ExtractToDirectory(@"V:\epost\incoming\" + files[i], @"V:\epost\incoming\");

                    DeleteFile(files[i]);
                }

                if (files[i].Contains("RCVR"))
                {
                    Download(files[i], @"V:\epost\reports");
                    DeleteFile(files[i]);
                }

                if (files[i].Contains("ifile"))
                {
                    Download(files[i], @"V:\epost\reports");
                    DeleteFile(files[i]);
                }
            }

            files = Directory.GetFiles(@"V:\epost\incoming\");

            for (int i = 0; i < files.Length; i++)
                if (files[i].Contains(".zip"))
                    File.Move(@"V:\epost\incoming\" + files[i], @"V:\epost\archive\" + files[i]);
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
                reqFTP.EnableSsl = true;
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

        static public void DeleteFile(string file)
        {
            try
            {
                FtpWebRequest reqFTP;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpURI + file));
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                reqFTP.Method = WebRequestMethods.Ftp.DeleteFile;
                reqFTP.Proxy = null;
                reqFTP.KeepAlive = false;
                reqFTP.UsePassive = false;
                reqFTP.GetResponse();
            }
            catch
            {
                
            }
        }

        //static void test()
        //{
        //    // Setup Credentials and Server Information
        //    ConnectionInfo ConnNfo = new ConnectionInfo("hostOrIP", 22, "username",
        //        new AuthenticationMethod[]{

        //        // Pasword based Authentication
        //        new PasswordAuthenticationMethod("username","password"),

        //        // Key Based Authentication (using keys in OpenSSH Format)
        //        new PrivateKeyAuthenticationMethod("username",new PrivateKeyFile[]{
        //            new PrivateKeyFile(@"..\openssh.key","passphrase")
        //        }),
        //        }
        //    );

        //    // Execute a (SHELL) Command - prepare upload directory
        //    using (var sshclient = new SshClient(ConnNfo))
        //    {
        //        sshclient.Connect();
        //        using (var cmd = sshclient.CreateCommand("mkdir -p /tmp/uploadtest && chmod +rw /tmp/uploadtest"))
        //        {
        //            cmd.Execute();
        //            Console.WriteLine("Command>" + cmd.CommandText);
        //            Console.WriteLine("Return Value = {0}", cmd.ExitStatus);
        //        }
        //        sshclient.Disconnect();
        //    }

        //    // Upload A File
        //    using (var sftp = new SftpClient(ConnNfo))
        //    {
        //        string uploadfn = "Renci.SshNet.dll";

        //        sftp.Connect();
        //        sftp.ChangeDirectory("/tmp/uploadtest");
        //        using (var uplfileStream = System.IO.File.OpenRead(uploadfn))
        //        {
        //            sftp.UploadFile(uplfileStream, uploadfn, true);
        //        }
        //        sftp.Disconnect();
        //    }

        //    // Execute (SHELL) Commands
        //    using (var sshclient = new SshClient(ConnNfo))
        //    {
        //        sshclient.Connect();

        //        // quick way to use ist, but not best practice - SshCommand is not Disposed, ExitStatus not checked...
        //        Console.WriteLine(sshclient.CreateCommand("cd /tmp && ls -lah").Execute());
        //        Console.WriteLine(sshclient.CreateCommand("pwd").Execute());
        //        Console.WriteLine(sshclient.CreateCommand("cd /tmp/uploadtest && ls -lah").Execute());
        //        sshclient.Disconnect();
        //    }
        //    Console.ReadKey();
        //}

        static private void Download(string file, string outputDirectory)
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
                    FileStream writeStream = new FileStream(outputDirectory + "\\" + file, FileMode.Create);
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
