using System;

//Download from https://winscp.net/download/WinSCP-5.13.1-Automation.zip
using WinSCP;

namespace I_IT
{
    class JostleExport
    {
        public JostleExport()
        {
            try
            {
                // Set up session options
                SessionOptions sessionOptions = new SessionOptions
                {
                    Protocol = Protocol.Sftp,
                    HostName = "sftp.jostle.us",
                    UserName = "newmarket",
                    Password = "n3wm4rk3t", //For SFTP user account
                    PrivateKeyPassphrase = "n3wm4rk3t", //For private key file

                    //Open WinSCP, connect to SFTP site, then go Session --> Generate session URL/code
                    //Then, .NET assembly code tab... there you can find the fingerprint
                    //SshHostKeyFingerprint = "ssh-ed25519 256 BpSqTdt8cZ7V2oK9QoxopAnn8B0jk8BX2rKQN/kK7D8=",
                    SshHostKeyFingerprint = "ssh-ed25519 256 PtSEJ3EhEv7Msfj5uzM+r2ymzdbxUBDXo4hYL7oPrYk=",
                    SshPrivateKeyPath = @"\\data\files\Corp Services\IT\ADExport\privatekey-putty.ppk",
                };
                
                using (Session session = new Session())
                {
                    // Debug
                    //session.SessionLogPath = @"C:\Users\graeme smyth\Documents\Jostle.log";
                    //session.DebugLogLevel = 2;

                    // Connect
                    session.Open(sessionOptions);

                    // Upload files
                    TransferOptions transferOptions = new TransferOptions();
                    transferOptions.TransferMode = TransferMode.Binary;

                    TransferOperationResult transferResult;
                    transferResult = session.PutFiles(@"\\data\files\Corp Services\IT\ADExport\Output", "/jostle/input", false, transferOptions);

                    // Throw on any error
                    transferResult.Check();

                    // Print results
                    foreach (TransferEventArgs transfer in transferResult.Transfers)
                    {
                        Console.WriteLine("Upload of {0} succeeded", transfer.FileName);
                        Core.log("JostleExport", "Transfer result", "Upload of " + transfer.FileName + " succeeded");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
                Core.log("JostleExport", "Transfer result", "Error: " + e);
            }
        }
    }
}
