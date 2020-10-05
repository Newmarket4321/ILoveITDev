using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;
using WUApiLib;

namespace I_IT
{
    public partial class MasterInstaller : Form
    {
        int value = 0;
        int max = 0;

        public MasterInstaller()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox[] installChecks = new PictureBox[checkedListBox1.Items.Count];

            for (int i = 0; i < installChecks.Length; i++)
            {
                PictureBox box = installChecks[i];

                box = new PictureBox();
                //box.Image = Properties.Resources.False;
                box.Size = new Size(15, 15);
                box.SizeMode = PictureBoxSizeMode.StretchImage;
                box.Location = new Point(15, 30 + i * 19);
                box.Name = "box" + i;
                this.Controls.Add(box);
            }

            checkForAlreadyInstalled();
        }

        private void checkForAlreadyInstalled()
        {
            MethodInvoker myProcessStarter = new MethodInvoker(checkInstallations);

            myProcessStarter.BeginInvoke(null, null);
        }

        private void checkInstallations()
        {
            try
            {
                for (int i = 0; i < Controls.Count; i++)
                {
                    if (Controls[i].Name.Contains("box"))
                    {
                        PictureBox box = Controls[i] as PictureBox;
                        int row = int.Parse(box.Name.Replace("box", ""));

                        string check = checkedListBox1.Items[row].ToString().ToLower();

                        if (check.Contains("reader"))
                        {
                            box.Image = IsApplictionInstalled("Adobe Reader XI  MUI") ? (Bitmap)Properties.Resources.ResourceManager.GetObject("True") : Properties.Resources.False;
                        }
                        else if (check.Contains("chrome"))
                        {
                            box.Image = IsApplictionInstalled("Google Chrome") ? Properties.Resources.True : Properties.Resources.False;
                        }
                        else if (check.Contains("callpilot"))
                        {
                            box.Image = IsApplictionInstalled("Avaya CallPilot Desktop Messaging") ? Properties.Resources.True : Properties.Resources.False;
                        }
                        else if (check.Contains("cityview 8"))
                        {
                            box.Image = IsApplictionInstalled("CityView Application Client") ? Properties.Resources.True : Properties.Resources.False;
                        }
                        else if (check.Contains("class"))
                        {
                            box.Image = IsApplictionInstalled("Class for Windows 8.00") ? Properties.Resources.True : Properties.Resources.False;
                        }
                        else if (check.Contains("dats"))
                        {
                            box.Image = File.Exists("C:\\DATS\\DATS.exe") ? Properties.Resources.True : Properties.Resources.False;
                        }
                        else if (check.Contains("i❤it"))
                        {
                            box.Image = File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + "\\I❤IT.exe") ? Properties.Resources.True : Properties.Resources.False;
                        }
                        else if (check.Contains("microsoft office"))
                        {
                            box.Image = IsApplictionInstalled("Microsoft Office Standard 2010") ? Properties.Resources.True : Properties.Resources.False;
                        }
                        else if (check.Contains("microsoft access"))
                        {
                            box.Image = IsApplictionInstalled("Microsoft Access 2010") ? Properties.Resources.True : Properties.Resources.False;
                        }
                        else if (check.Contains("oracle"))
                        {
                            box.Image = Directory.Exists("C:\\oracle\\product") ? Properties.Resources.True : Properties.Resources.False;
                        }
                        else if (check.Contains("microsoft access"))
                        {
                            box.Image = IsApplictionInstalled("Microsoft Access 2010") ? Properties.Resources.True : Properties.Resources.False;
                        }
                        else if (check.Contains("vailtech"))
                        {
                            box.Image = Directory.Exists("C:\\oracle\\dev") ? Properties.Resources.True : Properties.Resources.False;
                        }
                        else if (check.Contains("flash"))
                        {
                            box.Image = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Macromedia\\FlashPlayer") != null &&
                            Registry.LocalMachine.OpenSubKey("SOFTWARE\\Macromedia\\FlashPlayer").GetValue("CurrentVersion").ToString().Substring(0, 2) == "18" ? Properties.Resources.True : Properties.Resources.False;
                        }
                        else if (check.Contains("java"))
                        {
                            box.Image = IsApplictionInstalled("Java 8 Update 91") ? Properties.Resources.True : Properties.Resources.False;
                        }
                        else if (check.Contains("ticket"))
                        {
                            box.Image = IsApplictionInstalled("Ticket Processor 7.0.7") ? Properties.Resources.True : Properties.Resources.False;
                        }
                        else if (check.Contains("windows updates"))
                        {
                            UpdateSession uSession = new UpdateSession();
                            IUpdateSearcher uSearcher = uSession.CreateUpdateSearcher();
                            uSearcher.Online = false;
                            ISearchResult sResult = uSearcher.Search("IsInstalled=0 And IsHidden=0");

                            for (int j = 0; j < checkedListBox1.Items.Count; j++)
                                if (checkedListBox1.Items[j].ToString().ToLower().Contains("windows updates"))
                                    this.Invoke((MethodInvoker)delegate
                                    {
                                        checkedListBox1.Items[j] = "Windows Updates (" + sResult.Updates.Count + " found)";
                                    });

                            box.Image = sResult.Updates.Count == 0 ? Properties.Resources.True : Properties.Resources.False;
                        }
                    }
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("3:" + e2.Message + e2.StackTrace);
            }
        }

        public int getBit()
        {
            if (IntPtr.Size == 8)
                return 64;

            return 32;
        }

        public static bool IsApplictionInstalled(string p_name)
        {

            string displayName;
            RegistryKey key;

            // search in: CurrentUser
            key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            if (key != null)
                foreach (String keyName in key.GetSubKeyNames())
                {
                    RegistryKey subkey = key.OpenSubKey(keyName);
                    displayName = subkey.GetValue("DisplayName") as string;
                    if (p_name.Equals(displayName, StringComparison.OrdinalIgnoreCase) == true)
                    {
                        return true;
                    }
                }

            // search in: LocalMachine_32
            key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            if (key != null)
                foreach (String keyName in key.GetSubKeyNames())
                {
                    RegistryKey subkey = key.OpenSubKey(keyName);
                    displayName = subkey.GetValue("DisplayName") as string;
                    if (p_name.Equals(displayName, StringComparison.OrdinalIgnoreCase) == true)
                    {
                        return true;
                    }
                }

            // search in: LocalMachine_64
            //key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall");
            //foreach (String keyName in key.GetSubKeyNames())
            //{
            //    RegistryKey subkey = key.OpenSubKey(keyName);
            //    displayName = subkey.GetValue("DisplayName") as string;
            //    if (p_name.Equals(displayName, StringComparison.OrdinalIgnoreCase) == true)
            //    {
            //        return true;
            //    }
            //}

            // NOT FOUND
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MethodInvoker myProcessStarter = new MethodInvoker(beginInstallations);

            myProcessStarter.BeginInvoke(null, null);
        }

        private void updateRegistryForNewProfiles()
        {
            File.Copy("\\\\vcd\\systems\\Master Installer\\NTUSER.DAT", "C:\\Users\\Default\\NTUSER.DAT", true);
        }

        private void beginInstallations()
        {
            max = 0;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                    max++;
            }

            value = 1;

            this.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = 0;
                progressBar1.Maximum = max;
            });

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    if (checkedListBox1.Items[i].ToString() == "Chrome")
                        installChrome();
                    if (checkedListBox1.Items[i].ToString() == "Class 8")
                        installClass();
                    if (checkedListBox1.Items[i].ToString() == "Oracle 11g")
                        installOracle();
                    if (checkedListBox1.Items[i].ToString() == "DATS")
                        installDATS();
                    if (checkedListBox1.Items[i].ToString() == "I❤IT")
                        installIHeartIT();
                    if (checkedListBox1.Items[i].ToString() == "Vailtech")
                        installVailtech();
                    if (checkedListBox1.Items[i].ToString() == "Microsoft Office 2010")
                        installOffice();
                    if (checkedListBox1.Items[i].ToString() == "Microsoft Access 2010")
                        installAccess();
                    if (checkedListBox1.Items[i].ToString() == "CallPilot")
                        installCallPilot();
                    if (checkedListBox1.Items[i].ToString() == "Java 8u91")
                        installJava();
                    if (checkedListBox1.Items[i].ToString() == "CityView 8")
                        installCityView8();
                    if (checkedListBox1.Items[i].ToString() == "Flash 22")
                        installFlash();
                    if (checkedListBox1.Items[i].ToString() == "Adobe Reader XI")
                        installAdobeReader();
                    if (checkedListBox1.Items[i].ToString().Contains("Windows Updates"))
                        installWindowsUpdates();
                    if (checkedListBox1.Items[i].ToString().Contains("Ticket Processor"))
                        installTicketProcessor();
                }
            }

            checkForAlreadyInstalled();

            this.Invoke((MethodInvoker)delegate
            {
                feedbackLabel.Text = "Done!";
                feedbackLabel.Update();

                progressBar1.Value = progressBar1.Maximum;
            });

            //MessageBox.Show("Done!");
        }

        private void run(string location)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";

            startInfo.Arguments = "/C \"" + location + "\"";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void installTicketProcessor()
        {
            //Install ticket processor
            run("\\\\vcd\\systems\\Applications\\Ticket_Processor\\S009-004-043-TicketProcessorFullInstall7_0_7\\TicketProcessor.exe");

            this.Invoke((MethodInvoker)delegate
            {
                feedbackLabel.Visible = true;
                feedbackLabel.Text = "Installing Ticket Processor";
                feedbackLabel.Update();
            });

            //Wait for it to start
            //Need extra code, as the process changes name
            bool keepGoing = true;
            while (keepGoing)
            {
                Process[] p = Process.GetProcesses();

                for (int i = 0; i < p.Length; i++)
                {
                    try
                    {
                        if (p[i].ProcessName.Substring(0, 3) == "INS" &&
                            p[i].ProcessName.Substring(p[i].ProcessName.Length - 4, 4) == ".tmp")
                            keepGoing = false;
                    }
                    catch
                    {

                    }
                }

                if (keepGoing)
                    System.Threading.Thread.Sleep(1000);
            }

            //Wait for it to finish
            keepGoing = true;
            while (keepGoing)
            {
                keepGoing = false;

                Process[] p = Process.GetProcesses();

                for (int i = 0; i < p.Length; i++)
                {
                    try
                    {
                        if (p[i].ProcessName.Substring(0, 3) == "INS" &&
                            p[i].ProcessName.Substring(p[i].ProcessName.Length - 4, 4) == ".tmp")
                            keepGoing = true;
                    }
                    catch
                    {

                    }
                }

                if (keepGoing)
                    System.Threading.Thread.Sleep(1000);
            }

            //Install enforcer
            run("\\\\vcd\\systems\\Applications\\Ticket_Processor\\S009-004-043-EnforcerComponents\\EnforcerComponents.exe");

            //Wait for it to start
            //Need extra code, as the process changes name
            keepGoing = true;
            while (keepGoing)
            {
                Process[] p = Process.GetProcesses();

                for (int i = 0; i < p.Length; i++)
                {
                    try
                    {
                        if (p[i].ProcessName.Substring(0, 3) == "INS" &&
                            p[i].ProcessName.Substring(p[i].ProcessName.Length - 4, 4) == ".tmp")
                            keepGoing = false;
                    }
                    catch
                    {

                    }
                }

                if (keepGoing)
                    System.Threading.Thread.Sleep(1000);
            }

            //Wait for it to finish
            keepGoing = true;
            while (keepGoing)
            {
                keepGoing = false;

                Process[] p = Process.GetProcesses();

                for (int i = 0; i < p.Length; i++)
                {
                    try
                    {
                        if (p[i].ProcessName.Substring(0, 3) == "INS" &&
                            p[i].ProcessName.Substring(p[i].ProcessName.Length - 4, 4) == ".tmp")
                            keepGoing = true;
                    }
                    catch
                    {

                    }
                }

                if (keepGoing)
                    System.Threading.Thread.Sleep(1000);
            }

            string location = "HKEY_LOCAL_MACHINE\\SOFTWARE\\JJMackay\\Enforcer\\";
            Registry.SetValue(location + "Database", "ADOString", "Provider=SQLOLEDB.1;Password=mastermac;Persist Security Info=True;User ID=admin;Initial Catalog=Newmarket;Data Source=DEPLOY3\\SQLEXPRESS", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location + "Permit", "Alias", "", Microsoft.Win32.RegistryValueKind.String);

            File.Copy("\\\\vcd\\systems\\Applications\\Ticket_Processor\\TicketProcessor.lic", "C:\\Program Files\\jjmackay\\Ticket Processor\\TicketProcessor.lic", true);

            location = "HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\citation";
            Registry.SetValue(location, "Database", "newmarket", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "Description", "citation", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "Driver", "C:\\WINDOWS\\system32\\SQLSRV32.dll", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "LastUser", "admin", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "Server", "DEPLOY3\\SQLEXPRESS", Microsoft.Win32.RegistryValueKind.String);

            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\ODBC Data Sources", "citation", "SQL Server", Microsoft.Win32.RegistryValueKind.String);

            string[] profiles = Registry.Users.GetSubKeyNames();

            for (int i = 0; i < profiles.Length; i++)
            {
                if (profiles[i].Length > 10)
                {
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Software\\VB and VBA Program Settings\\PTMS\\Startup\\Data", "Database", "newmarket", Microsoft.Win32.RegistryValueKind.String);
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Software\\VB and VBA Program Settings\\PTMS\\Startup\\Data", "DSN", "citation", Microsoft.Win32.RegistryValueKind.String);
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Software\\VB and VBA Program Settings\\PTMS\\Startup\\Data", "RunName", "Town of Newmarket", Microsoft.Win32.RegistryValueKind.String);
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Software\\VB and VBA Program Settings\\PTMS\\Startup\\Data", "RuntimeID", "newmarket", Microsoft.Win32.RegistryValueKind.String);

                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Software\\VB and VBA Program Settings\\Shared Tools\\MCREG32\\MCDID", "REGID", "1", Microsoft.Win32.RegistryValueKind.String);

                    //Map P:\ drive
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Network\\p", "RemotePath", "\\\\payproc\\Parking_Import_Files", Microsoft.Win32.RegistryValueKind.String);
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Network\\p", "UserName", 0, Microsoft.Win32.RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Network\\p", "ProviderName", "Microsoft Windows Network", Microsoft.Win32.RegistryValueKind.String);
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Network\\p", "ProviderType", 131072, Microsoft.Win32.RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Network\\p", "ConnectionType", 1, Microsoft.Win32.RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Network\\p", "DeferFlags", 4, Microsoft.Win32.RegistryValueKind.DWord);

                    //Make it work on all existing profiles
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Software\\Microsoft\\Windows NT\\CurrentVersion\\RunOnce", "regsvr32.bat", "\\\\vcd\\systems\\Master Installer\\regsvr32.bat", Microsoft.Win32.RegistryValueKind.String);
                }
            }

            //Update P:\ drive without need to reboot
            run("\\\\vcd\\systems\\Master Installer\\mapDriveP.bat");

            //Make it work on this profile
            run("\\\\vcd\\systems\\Master Installer\\regsvr32.bat");

            profiles = Directory.GetDirectories("C:\\users\\");

            for (int i = 0; i < profiles.Length; i++)
            {
                profiles[i] = profiles[i].Replace("C:\\users\\", "");

                if (profiles[i] != "All Users" && profiles[i] != "Default User" && profiles[i] != "Public")
                {
                    if (!Directory.Exists("C:\\Users\\" + profiles[i] + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup"))
                        Directory.CreateDirectory("C:\\Users\\" + profiles[i] + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup");

                    File.Copy("\\\\vcd\\systems\\Master Installer\\regsvr32.bat", "C:\\Users\\" + profiles[i] + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\regsvr32.bat", true);
                }

            }

            //Make it work on all new profiles
            updateRegistryForNewProfiles();

            this.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = value++;
            });
        }

        private void installWindowsUpdates()
        {
            run("\\\\vcd\\systems\\Master Installer\\wuaucpl.cpl");

            this.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = value++;
            });
        }

        private void installAdobeReader()
        {
            run("\\\\vcd\\systems\\Master Installer\\Adobe Reader\\Setup.exe");

            waitForProcess("Installing Adobe Reader", "setup");

            this.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = value++;
            });
        }

        private void installFlash()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";

            startInfo.Arguments = "/C \"\\\\vcd\\systems\\Master Installer\\install_flash_player_ax.exe\""; // -install
            process.StartInfo = startInfo;
            process.Start();

            this.Invoke((MethodInvoker)delegate
            {
                feedbackLabel.Visible = true;
                feedbackLabel.Text = "Installing Flash";
                feedbackLabel.Update();
            });

            System.Threading.Thread.Sleep(5000);

            this.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = value++;
            });
        }

        private void installCallPilot()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";

            startInfo.Arguments = "/C \"\\\\vcd\\Software\\Avaya CallPilot Desktop Messaging 05.01.02.06\\setup.exe\" /S /v/qn";
            process.StartInfo = startInfo;
            process.Start();

            this.Invoke((MethodInvoker)delegate
            {
                feedbackLabel.Visible = true;
                feedbackLabel.Text = "Installing CallPilot";
                feedbackLabel.Update();
            });

            //Wait for it to start
            //while (Process.GetProcessesByName("msiexec").Length == 0)
            //    System.Threading.Thread.Sleep(1000);

            //Wait for it to finish
            //while (Process.GetProcessesByName("msiexec").Length != 0)
            //    System.Threading.Thread.Sleep(1000);

            System.Threading.Thread.Sleep(5000);

            this.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = value++;
            });
        }

        private void installCityView8()
        {
            if (!Directory.Exists("C:\\oracle"))
                installOracle();

            this.Invoke((MethodInvoker)delegate
            {
                feedbackLabel.Visible = true;
                feedbackLabel.Text = "Installing CityView 8";
                feedbackLabel.Update();
            });

            //tnsnames
            File.Copy("\\\\vcd\\systems\\how to install\\tnsnames.ora", "C:\\oracle\\product\\11.2.0\\client_1\\network\\admin\\tnsnames.ora", true);

            if (Directory.Exists("C:\\oracle\\E1Local\\NETWORK\\ADMIN\\"))
                File.Copy("\\\\vcd\\systems\\how to install\\tnsnames.ora", "C:\\oracle\\E1Local\\NETWORK\\ADMIN\\tnsnames.ora", true);

            if (Directory.Exists("C:\\oracle\\product\\11.2.0\\client_2\\network\\admin"))
                File.Copy("\\\\vcd\\systems\\how to install\\tnsnames.ora", "C:\\oracle\\product\\11.2.0\\client_2\\network\\admin\\tnsnames.ora", true);

            if (Directory.Exists("C:\\oracle\\devNET80\\ADMIN\\"))
                File.Copy("\\\\vcd\\systems\\how to install\\tnsnames.ora", "C:\\oracle\\dev\\NET80\\ADMIN\\TNSNAMES.ORA", true);

            //welcome1.cvb
            File.Copy("\\\\vcd\\systems\\Master Installer\\CityView.lnk", System.Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + "\\CityView 8.lnk", true);

            //cty ODBC
            string location = "HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\cty";
            Registry.SetValue(location, "Driver", "C:\\oracle\\product\\11.2.0\\client_1\\BIN\\SQORA32.DLL", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "DisableRULEHint", "T", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "Attributes", "W", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "FetchBufferSize", "64000", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "NumericSetting", "NLS", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "ForceWCHAR", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "FailoverDelay", "10", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "FailoverRetryCount", "10", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "MetadataIdDefault", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "BindAsFLOAT", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "BindAsDATE", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "CloseCursor", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "EXECSchemaOpt", "", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "EXECSyntax", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "Application Attributes", "T", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "ResultSets", "T", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "QueryTimeout", "T", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "CacheBufferSize", "20", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "StatementCache", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "Failover", "T", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "Lobs", "T", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "DisableMTS", "T", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "DisableDPM", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "BatchAutocommitMode", "IfAllSuccessful", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "Description", "cty", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "ServerName", "cty.newmarket", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "Password", "", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "UserID", "", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "DSN", "cty", Microsoft.Win32.RegistryValueKind.String);

            //vtx ODBC
            location = "HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx";
            Registry.SetValue(location, "Driver", "C:\\oracle\\product\\11.2.0\\client_1\\BIN\\SQORA32.DLL", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "DisableRULEHint", "T", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "Attributes", "W", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "FetchBufferSize", "64000", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "NumericSetting", "NLS", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "ForceWCHAR", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "FailoverDelay", "10", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "FailoverRetryCount", "10", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "MetadataIdDefault", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "BindAsFLOAT", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "BindAsDATE", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "CloseCursor", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "EXECSchemaOpt", "", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "EXECSyntax", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "Application Attributes", "T", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "ResultSets", "T", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "QueryTimeout", "T", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "CacheBufferSize", "20", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "StatementCache", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "Failover", "T", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "Lobs", "T", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "DisableMTS", "T", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "DisableDPM", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "BatchAutocommitMode", "IfAllSuccessful", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "Description", "vtx", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "ServerName", "vtx.newmarket", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "Password", "", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "UserID", "", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue(location, "DSN", "vtx", Microsoft.Win32.RegistryValueKind.String);

            //Map N:\ drive
            string[] profiles = Registry.Users.GetSubKeyNames();

            for (int i = 0; i < profiles.Length; i++)
            {
                if (profiles[i].Length > 10)
                {
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Network\\n", "RemotePath", "\\\\oracle2003r2\\cityview", Microsoft.Win32.RegistryValueKind.String);
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Network\\n", "UserName", 0, Microsoft.Win32.RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Network\\n", "ProviderName", "Microsoft Windows Network", Microsoft.Win32.RegistryValueKind.String);
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Network\\n", "ProviderType", 131072, Microsoft.Win32.RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Network\\n", "ConnectionType", 1, Microsoft.Win32.RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Network\\n", "DeferFlags", 4, Microsoft.Win32.RegistryValueKind.DWord);
                }
            }

            updateRegistryForNewProfiles();

            //Update N:\ drive without need to reboot
            run("\\\\vcd\\systems\\Master Installer\\mapDriveN.bat");

            //Install CityView
            run("\\\\oracle2003r2\\cityview\\cityview\\setup\\setup.exe");

            waitForProcess("Installing CityView", "setup");

            File.Delete(System.Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + "\\CityView.lnk");

            this.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = value++;
            });
        }

        private void installJava()
        {
            run("\"\\\\vcd\\systems\\Master Installer\\jre-8u91-windows-i586 silent installer.exe\"");

            waitForProcess("Installing Java", "msiexec");

            this.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = value++;
            });
        }

        private void waitForProcess(string label, string process)
        {
            bool skip = false;
            int time = 0;

            this.Invoke((MethodInvoker)delegate
            {
                feedbackLabel.Visible = true;
                feedbackLabel.Text = label + " - Waiting for " + process + " to start";
                feedbackLabel.Update();
            });

            //Wait for it to start
            while (Process.GetProcessesByName(process).Length == 0 && !skip)
            {
                System.Threading.Thread.Sleep(1000);
                time++;

                //if(time > 20)
                //    skip = mess
            }

            this.Invoke((MethodInvoker)delegate
            {
                feedbackLabel.Visible = true;
                feedbackLabel.Text = label + " - Waiting for " + process + " to close";
                feedbackLabel.Update();
            });

            //Wait for it to finish
            while (Process.GetProcessesByName(process).Length != 0 && !skip)
                System.Threading.Thread.Sleep(1000);
        }

        private void installOffice()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";

            startInfo.Arguments = "/C \\\\vcd\\Software\\MicrosoftOffice2010StandardSilentInstall\\setup.exe /config \\\\vcd\\Software\\MicrosoftOffice2010StandardSilentInstall\\Standard.WW\\config.xml";
            process.StartInfo = startInfo;
            process.Start();

            waitForProcess("Installing Office 2010", "setup");

            this.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = value++;
            });
        }

        private void installAccess()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";

            startInfo.Arguments = "/C \\\\vcd\\Software\\MicrosoftAccess2010SilentInstall\\setup.exe /config \\\\vcd\\Software\\MicrosoftAccess2010SilentInstall\\Access.WW\\config.xml";
            process.StartInfo = startInfo;
            process.Start();

            waitForProcess("Installing Access 2010", "setup");

            this.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = value++;
            });
        }

        private void installVailtech()
        {
            if (!Directory.Exists("C:\\oracle\\product\\11.2.0\\client_1"))
                installOracle();

            this.Invoke((MethodInvoker)delegate
            {
                feedbackLabel.Visible = true;
                feedbackLabel.Text = "Installing Vailtech";
                feedbackLabel.Update();
            });

            //Install Oracle 6i Forms and Reports
            if (!Directory.Exists("C:\\oracle\\dev"))
            {
                DirectoryCopy("\\\\vcd\\systems\\Master Installer\\Oracle 6i Forms and Reports", "C:\\oracle", true);

                //tnsnames.ora
                if (!Directory.Exists("C:\\oracle\\dev\\NET80\\ADMIN"))
                    Directory.CreateDirectory("C:\\oracle\\dev\\NET80\\ADMIN");

                File.Copy("\\\\vcd\\systems\\how to install\\tnsnames.ora", "C:\\oracle\\dev\\NET80\\ADMIN\\TNSNAMES.ORA", true);

                string PATH = Registry.GetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Environment", "PATH", "").ToString();
                if (!PATH.Contains("C:\\oracle\\dev\\bin"))
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Environment", "PATH", "C:\\oracle\\dev\\bin;" + PATH, Microsoft.Win32.RegistryValueKind.ExpandString);
            }

            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\ALL_HOMES", "DEFAULT_HOME", "DEFAULT_HOME", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\ALL_HOMES", "HOME_COUNTER", "1", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\ALL_HOMES", "LAST_HOME", "0", Microsoft.Win32.RegistryValueKind.ExpandString);

            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\ALL_HOMES\\ID0", "NAME", "DEFAULT_HOME", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\ALL_HOMES\\ID0", "NLS_LANG", "AMERICAN_AMERICA.WE8ISO8859P1", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\ALL_HOMES\\ID0", "PATH", "C:\\oracle\\dev", Microsoft.Win32.RegistryValueKind.ExpandString);

            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\HOME0", "ID", "0", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\HOME0", "ORACLE_HOME", "C:\\oracle\\dev", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\HOME0", "ORACLE_HOME_NAME", "DEFAULT_HOME", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\HOME0", "SHARED_ORACLE_HOME", "C:\\oracle\\dev", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\HOME0", "API", "C:\\oracle\\dev\\DBS", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\HOME0", "NLS_LANG", "AMERICAN_AMERICA.WE8ISO8859P1", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\HOME0", "COMPANY_NAME", "Town of Newmarket", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\HOME0", "ORACLE_GROUP_NAME", "Oracle for Windows NT", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\HOME0", "D2K60_COMPONENTS", "Oracle Forms & Reports 6i Comps", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\HOME0", "D2K60_ADMINISTRATION", "Oracle Forms & Reports 6i Admin", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\HOME0", "D2KOR60_ADMINISTRATION", "Oracle Reports 6i Admin", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\HOME0", "D2KIF60_ADMINISTRATION", "Oracle Forms 6i Admin", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\HOME0", "D2K60_DEMOS", "Oracle Forms & Reports 6i Demos", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\HOME0", "D2K60_DOCS", "Oracle Forms & Reports 6i Doc", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\HOME0", "D2K60_GROUP", "Oracle Forms & Reports 6i", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\HOME0", "D2KOR60_GROUP", "Oracle Reports 6i", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\HOME0", "D2KIF60_GROUP", "Oracle Forms 6i", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\HOME0", "D2K60_DRIVERS", "Oracle Forms & Reports 6i Direct Drivers", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\HOME0", "OPEN2K60_DOCS", "Oracle Forms & Reports 6i Doc", Microsoft.Win32.RegistryValueKind.ExpandString);

            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\ORACLE_HOMES\\ORACLE0", "API", "C:\\oracle\\dev\\DBS", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\ORACLE_HOMES\\ORACLE0", "COMPANY_NAME", "Town of Newmarket", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\ORACLE_HOMES\\ORACLE0", "NLS_LANG", "AMERICAN_AMERICA.WE8ISO8859P1", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\ORACLE_HOMES\\ORACLE0", "ORACLE_GROUP_NAME", "Oracle for Windows NT", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\ORACLE_HOMES\\ORACLE0", "ORACLE_HOME", "C:\\oracle\\dev", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\ORACLE_HOMES\\ORACLE0", "ORACLE_HOME_NAME", "DEFAULT_HOME", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle\\ORACLE_HOMES\\ORACLE0", "SHARED_ORACLE_HOME", "C:\\oracle\\dev", Microsoft.Win32.RegistryValueKind.ExpandString);

            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "API", "C:\\oracle\\dev\\DBS", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "BROWSER60", "C:\\oracle\\dev\\BROWSE60", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "CA_GPREFS", "C:\\oracle\\dev", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "CA_UPREFS", "C:\\oracle\\dev", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "COMPANY_NAME", "Town of Newmarket", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "CORE40", "C:\\oracle\\dev\\CORE40", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "DE60", "C:\\oracle\\dev\\TOOLS\\COMMON60", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "DEV2000_PROJECT", "NONE", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "DEV2000_SCCONVERT", "FALSE", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "DEV2000_SCVIEWER", "NOTEPAD.EXE", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "DEV2000_SOURCECONTROL", "NONE", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "DOC60", "C:\\oracle\\dev\\TOOLS\\DOC60", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "FORMS60", "C:\\oracle\\dev\\FORMS60", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "FORMS60_PATH", "V:\\vtax8\\cicon;V:\\vtax8\\library", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "GRAPHBMP60", "C:\\oracle\\dev\\GRAPH60\\GWIZ_BMP", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "GRAPHICS60", "C:\\oracle\\dev\\GRAPH60", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "GRAPHOGD60", "C:\\oracle\\dev\\GRAPH60\\GWIZ_OGD", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "GSCONNECTDIR", "C:\\oracle\\dev\\olap\\ecf620", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "GSINSTALLDIR", "C:\\oracle\\dev\\olap\\ece620", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "GWIZARD60", "C:\\oracle\\dev\\GRAPH60", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "inst_loc", "C:\\Program Files\\Oracle\\Inventory", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "MM60", "C:\\oracle\\dev\\TOOLS\\COMMON60", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "NET80", "C:\\oracle\\dev\\NET80", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "NLS_LANG", "AMERICAN_AMERICA.WE8ISO8859P1", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "NLSRTL33", "C:\\oracle\\dev\\NLSRTL33", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "OCL60", "C:\\oracle\\dev\\GRAPH60", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "OIN60", "C:\\oracle\\dev\\OIN60", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "ORA_NLS33", "C:\\oracle\\dev\\NLSRTL33\\DATA", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "ORACLE_GROUP_NAME", "Oracle for Windows NT", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "ORACLE_HOME", "C:\\oracle\\dev", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "ORACLE_HOME_NAME", "DEFAULT_HOME", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "ORACLE_JDK", "C:\\oracle\\dev\\JDK\\", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "ORAINFONAV_CDPATH", "\\\\vcd\\systems\\Applications\\Oracle\\Oracle_Forms_Reports_6i\\INSTALL", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "ORAINFONAV_DOCPATH", "C:\\oracle\\dev\\OIN", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "OTRACE80", "C:\\oracle\\dev\\OTRACE80", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "PLSQL80", "C:\\oracle\\dev\\PLSQL80", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "PRO80", "C:\\oracle\\dev\\PRO80", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "QT_PLAYER", "OMO", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "RDBMS80", "C:\\oracle\\dev\\RDBMS80", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "REPORTS_BUILDER", "rwbld60.exe", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "REPORTS_RUNTIME", "rwrun60.exe", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "REPORTS60_CLASSPATH", "C:\\oracle\\dev\\jdk\\lib\\classes.zip;C:\\oracle\\dev\\REPORT60\\java\\jars\\myreports60.jar;C:\\oracle\\dev\\REPORT60\\java\\jars\\xmlparser.jar", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "REPORTS60_EXPRESS_UI", "C:\\oracle\\dev\\bin", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "REPORTS60_JNI_LIB", "C:\\oracle\\dev\\jdk\\bin\\javai.dll", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "REPORTS60_PATH", "V:\\vtax8\\library;V:\\vtax8\\library;C:\\oracle\\dev\\REPORT60\\ADMIN\\TEMPLATE\\US;C:\\oracle\\dev\\REPORT60;V:\\vtax8\\library", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "REPORTS60_SPLASH", "TRUE", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "REPORTS60_TMP", "C:\\oracle\\dev\\REPORT60\\TMP", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "RW60", "C:\\oracle\\dev\\REPORT60", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "SHARED_ORACLE_HOME", "C:\\oracle\\dev", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "TK60", "C:\\oracle\\dev\\TOOLS\\COMMON60", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "UI_60", "V:\\vtax8\\cicon", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "UI_ICON", "V:\\vtax8\\cicon", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "UI60", "C:\\oracle\\dev\\TOOLS\\COMMON60", Microsoft.Win32.RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\oracle", "VGS60", "C:\\oracle\\dev\\TOOLS\\COMMON60", Microsoft.Win32.RegistryValueKind.ExpandString);

            //vtx ODBC
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "Driver", "C:\\oracle\\product\\11.2.0\\client_1\\BIN\\SQORA32.DLL", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "DisableRULEHint", "T", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "Attributes", "W", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "FetchBufferSize", "64000", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "NumericSetting", "NLS", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "ForceWCHAR", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "FailoverDelay", "10", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "FailoverRetryCount", "10", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "MetadataIdDefault", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "BindAsFLOAT", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "BindAsDATE", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "CloseCursor", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "EXECSchemaOpt", "", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "EXECSyntax", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "Application Attributes", "T", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "ResultSets", "T", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "QueryTimeout", "T", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "CacheBufferSize", "20", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "StatementCache", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "Failover", "T", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "Lobs", "T", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "DisableMTS", "T", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "DisableDPM", "F", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "BatchAutocommitMode", "IfAllSuccessful", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "Description", "vtx", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "ServerName", "vtx.newmarket", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "Password", "", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "UserID", "", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\vtx", "DSN", "vtx", Microsoft.Win32.RegistryValueKind.String);

            //Map V:\ drive
            string[] profiles = Registry.Users.GetSubKeyNames();

            for (int i = 0; i < profiles.Length; i++)
            {
                if (profiles[i].Length > 10)
                {
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Network\\v", "RemotePath", "\\\\data\\Vtax", Microsoft.Win32.RegistryValueKind.String);
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Network\\v", "UserName", "", Microsoft.Win32.RegistryValueKind.String);
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Network\\v", "ProviderName", "Microsoft Windows Network", Microsoft.Win32.RegistryValueKind.String);
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Network\\v", "ProviderType", 131072, Microsoft.Win32.RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Network\\v", "ConnectionType", 1, Microsoft.Win32.RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_USERS\\" + profiles[i] + "\\Network\\v", "DeferFlags", 4, Microsoft.Win32.RegistryValueKind.DWord);
                }
            }

            updateRegistryForNewProfiles();

            //Update V:\ drive without need to reboot
            run("\\\\vcd\\systems\\Master Installer\\mapDriveV.bat");

            //Desktop shortcut
            File.Copy("\\\\data\\files\\PCapps\\Vtax\\VTAX.lnk", System.Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + "\\VTAX.lnk", true);

            this.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = value++;
            });
        }

        private void installOracle()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";

            startInfo.Arguments = "/C \\\\vcd\\systems\\applications\\oracle\\Ora_11_Client\\client\\setup.exe -silent -noconsole -responseFile \\\\vcd\\systems\\applications\\oracle\\Ora_11_Client\\client\\client_install.rsp";
            process.StartInfo = startInfo;
            process.Start();

            waitForProcess("Installing Oracle", "javaw");

            //tnsnames.ora
            if (!Directory.Exists("C:\\oracle\\product\\11.2.0\\client_1\\network\\admin"))
                Directory.CreateDirectory("C:\\oracle\\product\\11.2.0\\client_1\\network\\admin");

            File.Copy("\\\\vcd\\systems\\how to install\\tnsnames.ora", "C:\\oracle\\product\\11.2.0\\client_1\\network\\admin\\tnsnames.ora", true);

            this.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = value++;
            });
        }

        private void installDATS()
        {
            this.Invoke((MethodInvoker)delegate
            {
                feedbackLabel.Visible = true;
                feedbackLabel.Text = "Installing DATS";
                feedbackLabel.Update();
            });

            string installPath = "C:\\DATS";
            string storagePath = "\\\\data\\files\\PCapps\\DATS";

            bool exists = System.IO.Directory.Exists(installPath);

            if (!exists)
                System.IO.Directory.CreateDirectory(installPath);

            string desktop = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);

            File.Copy(storagePath + "\\DATS Launcher.exe", desktop + "\\DATS Launcher.exe", true);

            this.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = value++;
            });
        }

        private void installIHeartIT()
        {
            this.Invoke((MethodInvoker)delegate
            {
                feedbackLabel.Visible = true;
                feedbackLabel.Text = "Installing I❤IT";
                feedbackLabel.Update();
            });

            string storagePath = "\\\\data\\files\\PCapps\\I❤IT";
            string desktop = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);

            File.Copy(storagePath + "\\I❤IT.exe", desktop + "\\I❤IT.exe", true);

            this.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = value++;
            });
        }

        private void installChrome()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";

            startInfo.Arguments = "/C \\\\vcd\\systems\\chrome_installer.exe /silent /install";
            process.StartInfo = startInfo;
            process.Start();

            waitForProcess("Installing Chrome", "setup");

            this.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = value++;
            });
        }

        private void installClass()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";

            //startInfo.Arguments = "/C \\\\vcd\\Software\\Class_7_SP1\\setup.exe /s";
            startInfo.Arguments = "/C \\\\vcd\\Software\\Class_8\\Setup.exe /s /V\"/i LOGFILE=C:\\classinstall.log CONFIG=\\\\vcd\\systems\\classconfig.config\"";
            process.StartInfo = startInfo;
            process.Start();

            this.Invoke((MethodInvoker)delegate
            {
                feedbackLabel.Visible = true;
                feedbackLabel.Text = "Installing Class";
                feedbackLabel.Update();
            });

            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Class Software Solutions Ltd.\\Class for Windows\\8.00\\Databases\\class", "ConnectString", "Provider=SQLOLEDB.1;Initial Catalog=class;Data Source=reclass;Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=SYSGS-10-13;Use Encryption for Data=False;Tag with column collation when possible=False", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Class Software Solutions Ltd.\\Class for Windows\\8.00\\Databases\\class", "DatabaseEntry", "class", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Class Software Solutions Ltd.\\Class for Windows\\8.00\\Databases\\class", "DatabaseName", "class", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Class Software Solutions Ltd.\\Class for Windows\\8.00\\Databases\\class", "DatabaseType", "3", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Class Software Solutions Ltd.\\Class for Windows\\8.00\\Databases\\class", "HybridAgency", "", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Class Software Solutions Ltd.\\Class for Windows\\8.00\\Databases\\class", "HybridHashedPassword", "", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Class Software Solutions Ltd.\\Class for Windows\\8.00\\Databases\\class", "Location", "", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Class Software Solutions Ltd.\\Class for Windows\\8.00\\Databases\\class", "Password", "Bo6YTSPpYo/L5Zl5b1h2nw==", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Class Software Solutions Ltd.\\Class for Windows\\8.00\\Databases\\class", "PerformanceFileName", "", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Class Software Solutions Ltd.\\Class for Windows\\8.00\\Databases\\class", "PerformanceLogging", "0", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Class Software Solutions Ltd.\\Class for Windows\\8.00\\Databases\\class", "Server", "classdb", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Class Software Solutions Ltd.\\Class for Windows\\8.00\\Databases\\class", "Terminal", "", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Class Software Solutions Ltd.\\Class for Windows\\8.00\\Databases\\class", "UnifiedLogon", "0", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Class Software Solutions Ltd.\\Class for Windows\\8.00\\Databases\\class", "UseOracleProvider", "0", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Class Software Solutions Ltd.\\Class for Windows\\8.00\\Databases\\class", "UserCode", "class", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Class Software Solutions Ltd.\\Class for Windows\\8.00\\Databases\\class", "UserId", "0", Microsoft.Win32.RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Class Software Solutions Ltd.\\Class for Windows\\8.00\\Databases\\class", "UserParameters", "", Microsoft.Win32.RegistryValueKind.String);

            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Class Software Solutions Ltd.\\Class for Windows\\8.00\\Databases\\Configured Databases", "class", "", Microsoft.Win32.RegistryValueKind.String);

            waitForProcess("Installing Class", "setup");

            this.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = value++;
            });
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory doesn't exist, create it. 
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location. 
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process[] processlist = Process.GetProcesses();
            foreach (Process theprocess in processlist)
            {
                Console.WriteLine("Process: {0} ID: {1}", theprocess.ProcessName, theprocess.Id);
            }
        }

        private void standardBuildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.Items[i].ToString().ToLower().Contains("callpilot") ||
                    checkedListBox1.Items[i].ToString().ToLower().Contains("microsoft office") ||
                    checkedListBox1.Items[i].ToString().ToLower().Contains("java") ||
                    checkedListBox1.Items[i].ToString().ToLower().Contains("adobe reader") ||
                    checkedListBox1.Items[i].ToString().ToLower().Contains("windows updates") ||
                    checkedListBox1.Items[i].ToString().ToLower().Contains("flash"))
                    checkedListBox1.SetItemCheckState(i, CheckState.Checked);
                else
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            checkForAlreadyInstalled();
        }
    }
}
