using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace I_IT
{
    class Core
    {
        //The assembly file name of this program, as [Name].exe
        public static string assemblyFileName = "TONba.exe";

        //The name of the temporary file used to handle update processes
        public static string updateFileName = "Update.exe";

        //The computer used for development
        public static string devMachineName = "SYSGS-11-13";

        //The path to the development project, used for deployment
        //public static string devProjectPath = @"\\" + devMachineName + @"\c$\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT";
        public static string devProjectPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        public static string devPath = devProjectPath + @"\" + assemblyFileName;
        // original code public static string devPath = devProjectPath + @"\I❤IT\bin\Debug\" + assemblyFileName;

        //Where the program is deployed to / where users' copies will look to for updates
        public static string deploymentPath = @"\\SQL2016\Apps\";
        public static string[] deploymentPathsAdditional = { @"\\sql2016\c$\I❤IT-DigiPenExport-dev.exe" };
        public static string[] prerequisites = {
            "Oracle.ManagedDataAccess.dll",
            "DocumentFormat.OpenXml.dll",
            "ClosedXML.dll",
            "RestSharp.dll"
        };

        //If backing up when deploying, where the backups will be kept
        public static string backupPath = @"Z:\" + assemblyFileName.Replace(".exe", "") + @"\" + assemblyFileName.Replace(".exe", "");

        //Where files will be stored, such as during exports
        public static string tempDirectory = @"C:\" + assemblyFileName.Replace(".exe", "") + @"\";

        //The server where scheduled tasks are stored
        public static string taskMachineName = "SQLdev";
        public static string[] taskRunners = { "IHeartIT", "SYSTEM", "gsmyth" };

        //Mailing
        public static string mailSentFrom = "IHeartIT@newmarket.ca";
        public static string mailServer = "mail.newmarket.ca";
        public static string windowsLogin = "iheartit";
        public static string windowsPassword = "Love2help";

        public static string getUsername()
        {
            string name = Environment.UserName;

            //if (Environment.MachineName == devMachineName)
            //    name = "mwigmore";
            
            return name;
        }

        public static string getDisplayName()
        {
            string name = System.DirectoryServices.AccountManagement.UserPrincipal.Current.DisplayName;

            if(name.Contains(','))
            {
                string last = name.Split(',')[0].Trim();
                string first = name.Substring(last.Length).Trim();

                name = first + " " + last;
            }

            return name;
        }

        public static int getNumberDecimals(double value)
        {
            return BitConverter.GetBytes(decimal.GetBits((decimal)value)[3])[2];
        }

        public static int getNumberDecimals(decimal value)
        {
            return BitConverter.GetBytes(decimal.GetBits(value)[3])[2];
        }

        public static int getEmployeeID()
        {
            try
            {
                int empID = int.Parse(SQL.RunString("select employeeid from JDEWindowsMapping where windowsusername = @USERNAME", Core.getUsername()));

                return empID;
            }
            catch
            {
                Core.sendMail("gsmyth@newmarket.ca", "Paycheque Application", Core.getUsername());

                Core.lookupMessageBox("Employee ID not on file", "I♥IT doesn't have your employee ID on file, therefore cannot look up your paycheques." + Environment.NewLine
                    + "An application has automatically been submitted to have this set up for you. You should hear back soon.");

                return -1;
            }
        }

        public static bool isIn(string leftSide, params string[] list)
        {
            for (int i = 0; i < list.Length; i++)
                if (leftSide == list[i])
                    return true;

            return false;
        }

        public static bool isIn(char leftSide, params char[] list)
        {
            for (int i = 0; i < list.Length; i++)
                if (leftSide == list[i])
                    return true;

            return false;
        }

        public static bool isIn(int leftSide, params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
                if (leftSide == list[i])
                    return true;

            return false;
        }

        public static bool isIn(double leftSide, params double[] list)
        {
            for (int i = 0; i < list.Length; i++)
                if (leftSide == list[i])
                    return true;

            return false;
        }

        public static bool isIn(decimal leftSide, params decimal[] list)
        {
            for (int i = 0; i < list.Length; i++)
                if (leftSide == list[i])
                    return true;

            return false;
        }

        public static bool isIn(DateTime leftSide, params DateTime[] list)
        {
            for (int i = 0; i < list.Length; i++)
                if (leftSide == list[i])
                    return true;

            return false;
        }
        
        //Every letter must be either alphabet or numeric
        public static bool isAlphanumeric(string s)
        {
            char[] c = s.ToCharArray();

            for (int i = 0; i < c.Length; i++)
                if (!char.IsLetterOrDigit(c[i]))
                    return false;

            return true;
        }

        //Every letter must be either alphabet or numeric, and must contain at least one of each
        //Else, this would just be one or the other
        public static bool isStrictlyAlphanumeric(string s)
        {
            bool containsLetters = false;
            bool containsNumbers = false;

            char[] c = s.ToCharArray();

            for (int i = 0; i < c.Length; i++)
            {
                if (char.IsLetter(c[i]))
                    containsLetters = true;
                else if (char.IsNumber(c[i]))
                    containsNumbers = true;
                else
                    return false;
            }

            return containsLetters && containsNumbers;
        }

        public static Color averageColours(Color c1, Color c2)
        {
            return Color.FromArgb((c1.R + c2.R)/2, (c1.G + c2.G)/2, (c1.B + c2.B)/2);
        }

        public static bool isAlphanumeric(char c)
        {
            return char.IsLetterOrDigit(c);
        }

        public static bool isNumeric(string s)
        {
            char[] c = s.ToCharArray();

            for (int i = 0; i < c.Length; i++)
                if (!char.IsDigit(c[i]))
                    return false;

            return true;
        }

        public static bool isNumeric(char c)
        {
            return char.IsDigit(c);
        }

        public static void fillListView(ListView list, DataTable dt)
        {
            list.Items.Clear();
            list.Columns.Clear();

            for (int i = 0; i < dt.Columns.Count; i++)
                list.Columns.Add(dt.Columns[i].ColumnName, dt.Columns[i].ColumnName);

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                ListViewItem li = new ListViewItem(dt.Rows[r][0].ToString());

                for (int c = 1; c < dt.Columns.Count; c++)
                    li.SubItems.Add(dt.Rows[r][c].ToString());

                list.Items.Add(li);
            }

            for (int i = 0; i < list.Columns.Count; i++)
            {
                list.Columns[i].Width = -2;
                list.Columns[i].Name = list.Columns[i].Text;
            }
        }

        public static void fillComboBox(ComboBox box, DataTable dt)
        {
            box.Items.Clear();

            for (int r = 0; r < dt.Rows.Count; r++)
                box.Items.Add(dt.Rows[r][0].ToString());
        }

        public static DateTime getVersion()
        {
            return File.GetLastWriteTime(Assembly.GetEntryAssembly().Location);
        }

        public static Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
        {
            //Type[] types = assembly.GetTypes(); 

            //DataTable dt = new DataTable();
            //dt.Columns.Add("Name");
            //dt.Columns.Add("Namespace");
            //dt.Columns.Add("IsPublic");
            //dt.Columns.Add("IsSealed");

            //for (int i = 0; i < types.Length; i++)
            //{
            //    dt.Rows.Add();
            //    dt.Rows[i]["Name"] = types[i].Name;
            //    dt.Rows[i]["Namespace"] = types[i].Namespace;
            //    dt.Rows[i]["IsPublic"] = types[i].IsPublic;
            //    dt.Rows[i]["IsSealed"] = types[i].IsSealed;
            //}

            //Report r = new Report("Hi!", dt);
            //r.ShowDialog();

            //Sealed includes <>c__DisplayClass, so let's exclude them
            return assembly.GetTypes().Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal) && !t.IsSealed).ToArray();
        }

        public static DateTime getLatestVersion()
        {
            return File.GetLastWriteTime(deploymentPath + assemblyFileName);
        }

        public static void log(string program, string eventName, string description)
        {
            if (getUsername() == "IHeartIT" && (eventName == "Log in" || eventName == "Run service") && (System.AppDomain.CurrentDomain.FriendlyName == "I❤IT-DigiPenExport-Dev.exe" || description.Contains("AccessITAPI")))
                return;

            SQL sql = new SQL("insert into log values (@PROGRAM, @EVENT, @TIMESTAMP, @USERNAME, @DESCRIPTION)");
            sql.AddParameter("@PROGRAM", program);
            sql.AddParameter("@EVENT", eventName);
            sql.AddParameter("@TIMESTAMP", DateTime.Now);
            sql.AddParameter("@USERNAME", getUsername());
            sql.AddParameter("@DESCRIPTION", description);
            sql.Run();
        }

        public static void backup(string source, string destination)
        {
            string targetDestination = destination + " " + DateTime.Today.ToString("MMMM d yyyy");
            
            for(int i = 2; Directory.Exists(targetDestination); i++)
                targetDestination = destination + " " + DateTime.Today.ToString("MMMM d yyyy") + " (" + i + ")";
            
            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(source, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(source, targetDestination));

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(source, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(source, targetDestination), true);
        }

        public static void run(string path)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                process.StartInfo.FileName = path;
                //process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.Start();
            }
            catch
            {
                //Old code, just in case new code doesn't work

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Verb = "runas";

                startInfo.Arguments = "/C \"" + path + "\"";
                process.StartInfo = startInfo;
                process.Start();
            }

            //string stderrx = process.StandardError.ReadToEnd();
            //process.WaitForExit();

            //if (stderrx.Trim() != "")
            //    throw new Exception("Core.run() exception" + Environment.NewLine
            //        + "Error = " + stderrx + Environment.NewLine
            //        + Environment.NewLine
            //        + "Path = " + path);
        }

        public static void run(string path, string arguments)
        {
            Process process = new Process();
            process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            process.StartInfo.FileName = path;
            //process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = arguments;
            process.Start();
            
            //string stderrx = process.StandardError.ReadToEnd();
            //process.WaitForExit();

            //if (stderrx.Trim() != "")
            //    throw new Exception("Core.run() exception" + Environment.NewLine
            //        + "Error = " + stderrx + Environment.NewLine
            //        + Environment.NewLine
            //        + "Path = " + path + Environment.NewLine
            //        + "Arguments = " + arguments);
        }
        
        public static void sleep(int milliseconds)
        {
            System.Threading.Thread.Sleep(milliseconds);
        }

        public static string getDeploymentPath()
        {
            return deploymentPath + Path.GetFileName(Assembly.GetEntryAssembly().Location);
        }

        public static string getExecutionDirectory()
        {
            return Path.GetDirectoryName(getExecutionPath());
        }

        public static string getExecutionPath()
        {
            return Assembly.GetEntryAssembly().Location.Replace(@"T:\", @"\\data\files\");
        }

        public static string getUserDesktopDirectory()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        public static string getPublicDesktopDirectory()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
        }

        public static void cleanDelete(string path)
        {
            try
            {
                if (File.Exists(path))
                    File.Delete(path);
            }
            catch
            {

            }
        }

        public static bool isProgramHidden(string program)
        {
            SQL sql = new SQL("select hidden from programs where code = @CODE");
            sql.AddParameter("@CODE", program);
            DataTable dt = sql.Run();

            if (dt.Rows.Count == 0)
                return false;
            else if (dt.Rows[0]["hidden"].ToString() == "")
                return false;
            else
                return bool.Parse(dt.Rows[0]["hidden"].ToString());
        }

        public static string getString(string title, out bool success)
        {
            GetString box = new GetString(title);
            box.ShowDialog();

            success = !box.quit;

            return box.r;
        }

        public static string getFile(out bool success)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if (ofd.FileName != null && ofd.FileName != "")
                success = true;
            else
                success = false;

            return ofd.FileName;
        }

        public static string getString(string title, bool multiline, out bool success)
        {
            GetString box = new GetString(title, multiline);
            box.ShowDialog();

            success = !box.quit;

            return box.r;
        }

        public static string getString(string title, string defaultQuery, out bool success)
        {
            GetString box = new GetString(title, defaultQuery);
            box.ShowDialog();

            success = !box.quit;

            return box.r;
        }

        public static string getString(string title, string defaultQuery, bool multiline, out bool success)
        {
            GetString box = new GetString(title, defaultQuery, multiline);
            box.ShowDialog();

            success = !box.quit;

            return box.r;
        }

        public static DataRow getSelect(string title, DataTable sourceData, out bool success)
        {
            Report r = new Report(title, sourceData, Report.ReportMode.SELECT);
            r.ShowDialog();

            success = r.selectedRow != null;

            return r.selectedRow;
        }

        public static string getSelect(string title, DataTable sourceData, string columnName, out bool success)
        {
            Report r = new Report(title, sourceData, Report.ReportMode.SELECT);
            r.ShowDialog();

            success = r.selectedRow != null;

            return r.selectedRow[columnName].ToString();
        }

        public static int getInt(string title, out bool success)
        {
            GetInt box = new GetInt(title);
            box.ShowDialog();

            success = !box.quit;

            return box.r;
        }

        public static int getInt(string title, int defaultValue, out bool success)
        {
            GetInt box = new GetInt(title, defaultValue);
            box.ShowDialog();

            success = !box.quit;

            return box.r;
        }

        public static int getInt(string title, int min, int max, out bool success)
        {
            GetInt box = new GetInt(title, min, max);
            box.ShowDialog();

            success = !box.quit;

            return box.r;
        }

        public static int getInt(string title, int min, int max, int defaultValue, out bool success)
        {
            GetInt box = new GetInt(title, min, max, defaultValue);
            box.ShowDialog();

            success = !box.quit;

            return box.r;
        }

        public static double getDouble(string title, out bool success)
        {
            GetDouble box = new GetDouble(title);
            box.ShowDialog();

            success = !box.quit;

            return box.r;
        }

        public static double getDouble(string title, double defaultValue, out bool success)
        {
            GetDouble box = new GetDouble(title, defaultValue);
            box.ShowDialog();

            success = !box.quit;

            return box.r;
        }

        public static double getDouble(string title, double min, double max, out bool success)
        {
            GetDouble box = new GetDouble(title, min, max);
            box.ShowDialog();

            success = !box.quit;

            return box.r;
        }

        public static double getDouble(string title, double min, double max, double defaultValue, out bool success)
        {
            GetDouble box = new GetDouble(title, min, max, defaultValue);
            box.ShowDialog();

            success = !box.quit;

            return box.r;
        }

        public static string lookupDropdown(string title, List<string> list)
        {
            LookupDropdown box = new LookupDropdown(title, list);
            box.ShowDialog();

            return box.r;
        }

        public static string lookupDropdown(string title, DataTable dt)
        {
            LookupDropdown box = new LookupDropdown(title, dt);
            box.ShowDialog();

            return box.r;
        }

        public static string lookupDropdown(string title, string[] items)
        {
            LookupDropdown box = new LookupDropdown(title, items);
            box.ShowDialog();

            return box.r;
        }

        public static string lookupDropdown(string title, DataColumnCollection columns)
        {
            LookupDropdown box = new LookupDropdown(title, columns);
            box.ShowDialog();

            return box.r;
        }

        public static string lookupComboBox(string title, DataTable dt)
        {
            LookupComboBox box = new LookupComboBox(title, dt);
            box.ShowDialog();

            return box.r;
        }

        public static string lookupComboBox(string title, string[] items)
        {
            LookupComboBox box = new LookupComboBox(title, items);
            box.ShowDialog();

            return box.r;
        }

        public static string lookupComboBox(string title, DataColumnCollection columns)
        {
            LookupComboBox box = new LookupComboBox(title, columns);
            box.ShowDialog();

            return box.r;
        }

        public static string lookupMessageBox(string title, string message, params string[] options)
        {
            MessageBoxCustom box = new MessageBoxCustom(title, message, options);
            box.ShowDialog();

            return box.response;
        }

        public static int lookupEmployee()
        {
            LookupEmployee box = new LookupEmployee();
            box.ShowDialog();

            return int.Parse(box.empNo);
        }

        public static string lookupIcon(ImageList icons, string current)
        {
            LookupIcon box = new LookupIcon(icons, current);
            box.ShowDialog();

            return box.r;
        }

        public static DateTime getDate(string title, out bool success)
        {
            GetDate box = new GetDate(title);
            box.ShowDialog();

            success = !box.quit;

            return box.r;
        }

        public static DateTime getDate(string title, DateTime defaultDate, out bool success)
        {
            GetDate box = new GetDate(title, defaultDate);
            box.ShowDialog();

            success = !box.quit;

            return box.r;
        }

        public static WorkOrder lookupWorkOrder()
        {
            LookupWorkOrder box = new LookupWorkOrder();
            box.ShowDialog();

            return box.r;
        }
        

        //Looks for an existing GL batch with the given description.
        //If such a batch exists, returns that batch
        //Otherwise, returns a new batch number
        public static int getOrFindGLBatchNumber(string env, string batchDescription, out int lineNumber)
        {
            string controlSchema = Core.getControlSchema(env);
            string schema = Core.getSchema(env);

            if (doesGLBatchExist(schema, batchDescription))
            {
                lineNumber = getExistingGLNextLineNumber(schema, batchDescription);
                return getExistingGLBatchNumber(schema, batchDescription);
            }
            else
            {
                lineNumber = 1000;
                return getGLBatchNumber(controlSchema);
            }
        }

        public static bool doesGLBatchExist(string schema, string batchDescription)
        {
            DataTable dt = Oracle.Run("select VNEDBT from " + schema + ".F0911Z1 where trim(VNEXA) = @DESCRIPTION", batchDescription.Trim());

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                DataTable temp = Oracle.Run("select count(VNEDSP) from " + schema + ".F0911Z1 where VNEDBT = @BATCH and VNEDSP = 1", dt.Rows[i]["VNEDBT"].ToString());

                if (int.Parse(temp.Rows[0][0].ToString()) == 0) //If this batch has no processed records
                    return true;
            }

            return false;
        }

        public static int getExistingGLBatchNumber(string schema, string batchDescription)
        {
            DataTable dt = Oracle.Run("select VNEDBT from " + schema + ".F0911Z1 where trim(VNEXA) = @DESCRIPTION", batchDescription.Trim());

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataTable temp = Oracle.Run("select count(VNEDSP) from " + schema + ".F0911Z1 where VNEDBT = @BATCH and VNEDSP = 1", dt.Rows[i]["VNEDBT"].ToString());

                if (int.Parse(temp.Rows[0][0].ToString()) == 0) //If this batch has no processed records
                    return int.Parse(dt.Rows[i]["VNEDBT"].ToString());
            }

            throw new Exception("getExistingGLBatchNumber() did not find a batch to return.");
        }

        public static int getExistingGLNextLineNumber(string schema, int batchNumber)
        {
            return 1000 + int.Parse(Oracle.RunString("select max(VNEDLN) from " + schema + ".F0911Z1 where VNEDBT = @BATCH", batchNumber));
        }

        public static int getExistingGLNextLineNumber(string schema, string batchDescription)
        {
            return 1000 + int.Parse(Oracle.RunString("select max(VNEDLN) from " + schema + ".F0911Z1 where trim(VNEXA) = @DESCRIPTION", batchDescription));
        }

        public static int getGLBatchNumber(string schema)
        {
            int r = int.Parse(Oracle.RunString("select NNN006 from " + schema + ".F0002 where trim(NNSY) = @VAR", "00"));

            Oracle.Run("update " + schema + ".F0002 set NNN006 = NNN006 + 1 where trim(NNSY) = @VAR", "00");

            return r;
        }

        public static string pad(string str, char padWith, int upToLength, PadSides side)
        {
            while (str.Length < upToLength)
                str = (side == PadSides.Left ? padWith.ToString() : "") + str + (side == PadSides.Right ? padWith.ToString() : "");

            return str;
        }

        public enum PadSides
        {
            Left,
            Right
        }

        public enum GLType
        {
            General,
            Inventory
        }

        public enum GLSides
        {
            Both,
            PositiveOnly,
            NegativeOnly
        }

        //Returns next line number
        public static int submitGL(string environment, int batchNumber, string batchDescription, int lineNumber, DateTime date, string explanationRemark, string reference, decimal amount, string positiveBranchPlant, string positiveObjectNumber, string positiveSub, string creditAccount, decimal? numberUnits, string unitType, int? workOrder, GLType type, GLSides sides)
        {
            string schema = getSchema(environment);

            int VNEDBT = batchNumber;
            int VNEDLN = 1000 * lineNumber;
            int VNJELN = 0;

            string VNICUT = "";

            if (type == GLType.General)
                VNICUT = "G ";
            else if (type == GLType.Inventory)
                VNICUT = "N ";
            
            string VNEXA = batchDescription.Substring(0, Math.Min(30, batchDescription.Length));
            string VNEXR = explanationRemark.Substring(0, Math.Min(30, explanationRemark.Length));
            string VNR1 = reference.Substring(0, Math.Min(8, reference.Length));
            string VNR2 = reference.Substring(0, Math.Min(8, reference.Length));

            string VNUM = unitType;
            decimal? positiveVNU = numberUnits * 100;
            decimal? negativeVNU = -positiveVNU;
            
            long positiveVNAA = (long)(Math.Round(amount, 2) * 100);
            long positiveVNAG = (long)(Math.Round(amount, 2) * 100);

            string positiveVNMCU = positiveBranchPlant;
            string positiveVNOBJ = positiveObjectNumber;
            string positiveVNSUB = positiveSub == null || positiveSub == "" ? "        " : positiveSub;
            //string positiveVNOBJ = Oracle.RunString("select FAAOBJ from " + schema + ".F1201 where trim(FAAPID) = trim(@ASSET)", asset);
            //string positiveVNSUB = Oracle.RunString("select FAASUB from " + schema + ".F1201 where trim(FAAPID) = trim(@ASSET)", asset);
            string positiveVNANI = positiveVNMCU + "." + positiveVNOBJ + (positiveVNSUB != "" && positiveVNSUB != null && positiveVNSUB != "        " ? "." + positiveVNSUB : "");

            if (type == GLType.Inventory)
            {
                positiveVNMCU = "";
                positiveVNOBJ = "";
                positiveVNSUB = "";
            }

            while (positiveVNMCU.Length < 12)
                positiveVNMCU = " " + positiveVNMCU;

            long negativeVNAA = -(long)(Math.Round(amount, 2) * 100);
            long negativeVNAG = -(long)(Math.Round(amount, 2) * 100);

            string negativeVNMCU = "";
            string negativeVNOBJ = "";
            string negativeVNSUB = "";
            string negativeVNANI = creditAccount;

            // string positiveVNSBL = "00" + workOrder.ToString();
            string positiveVNSBL = workOrder.ToString();
            string positiveVNSBLT = "W";
            object negativeVNSBL = DBNull.Value;
            object negativeVNSBLT = DBNull.Value;
            int nCounter=0;

            //Pads the work order number with 0s - EAC
            nCounter = positiveVNSBL.Length;
            for (int x = 0; x < 8 - nCounter; x++)
            {
                positiveVNSBL = "0" + positiveVNSBL;
            }

            string VNEDTY = "";

            if (type == GLType.General)
                VNEDTY = " ";
            else if (type == GLType.Inventory)
                VNEDTY = "N";

            //string VNASID = "/" + Oracle.RunString("SELECT FAAAID from PRODDTA.F1201 WHERE trim(FAAPID)=trim(@EquipmentNumber)", asset);

            //while (VNASID.Length < 9)
            //    VNASID = "/" + "0" + VNASID.Substring(1);

            //Positive
            if (sides == GLSides.Both || sides == GLSides.PositiveOnly)
            {
                Oracle ora = new Oracle("INSERT into " + schema + ".F0911Z1 VALUES (@VNEDUS, @VNEDTY, @VNEDSQ, @VNEDTN, @VNEDCT, @VNEDLN, @VNEDTS, @VNEDFT, @VNEDDT, @VNEDER, @VNEDDL, @VNEDSP, @VNEDTC, @VNEDTR, @VNEDBT, @VNEDGL, @VNEDAN, @VNKCO, @VNDCT, @VNDOC, @VNDGJ, @VNJELN, @VNEXTL, @VNPOST, @VNICU, @VNICUT, @VNDICJ, @VNDSYJ, @VNTICU, @VNCO, @VNANI, @VNAM, @VNAID, @VNMCU, @VNOBJ, @VNSUB, @VNSBL, @VNSBLT, @VNLT, @VNPN, @VNCTRY, @VNFY, @VNFQ, @VNCRCD, @VNCRR, @VNHCRR, @VNHDGJ, @VNAA, @VNU, @VNUM, @VNGLC, @VNRE, @VNEXA, @VNEXR, @VNR1, @VNR2, @VNR3, @VNSFX, @VNODOC, @VNODCT, @VNOSFX, @VNPKCO, @VNOKCO, @VNPDCT, @VNAN8, @VNCN, @VNDKJ, @VNDKC, @VNASID, @VNBRE, @VNRCND, @VNSUMM, @VNPRGE, @VNTNN, @VNALT1, @VNALT2, @VNALT3, @VNALT4, @VNALT5, @VNALT6, @VNALT7, @VNALT8, @VNALT9, @VNALT0, @VNALTT, @VNALTU, @VNALTV, @VNALTW, @VNALTX, @VNALTZ, @VNDLNA, @VNCFF1, @VNCFF2, @VNASM, @VNBC, @VNVINV, @VNIVD, @VNWR01, @VNPO, @VNPSFX, @VNDCTO, @VNLNID, @VNWY, @VNWN, @VNFNLP, @VNOPSQ, @VNJBCD, @VNJBST, @VNHMCU, @VNDOI, @VNALID, @VNALTY, @VNDSVJ, @VNTORG, @VNREGPOUND, @VNPYID, @VNUSER, @VNPID, @VNJOBN, @VNUPMJ, @VNUPMT, @VNCRRM, @VNACR, @VNDGM, @VNDGD, @VNDGY, @VNGDGPOUND, @VNDICM, @VNDICD, @VNDICY, @VNDICPOUND, @VNDSYM, @VNDSYS, @VNDSYY, @VNDSYPOUND, @VNDKM, @VNDKD, @VNDKY, @VNDKPOUND, @VNDSVM, @VNDSVD, @VNDSVY, @VNDSVPOUND, @VNHDGM, @VNHDGD, @VNHDGY, @VNHDGPOUND, @VNDKCM, @VNDKCD, @VNDKCY, @VNDKCPOUND, @VNIVDM, @VNIVDD, @VNIVDY, @VNIVDPOUND, @VNABR1, @VNABR2, @VNABR3, @VNABR4, @VNABT1, @VNABT2, @VNABT3, @VNABT4, @VNITM, @VNPM01, @VNPM02, @VNPM03, @VNPM04, @VNPM05, @VNPM06, @VNPM07, @VNPM08, @VNPM09, @VNPM10, @VNBCRC, @VNEXR1, @VNTXA1, @VNTXITM, @VNACTB, @VNSTAM, @VNCTAM, @VNAG, @VNAGF, @VNTKTX, @VNDLNID, @VNCKNU, @VNBUPC, @VNAHBU, @VNEPGC, @VNJPGC, @VNRC5, @VNSFXE, @VNOFM)");
                ora.AddParameter("@VNEDUS", "JDE");
                ora.AddParameter("@VNEDTY", VNEDTY);
                ora.AddParameter("@VNEDSQ", 0);
                ora.AddParameter("@VNEDTN", "1");
                ora.AddParameter("@VNEDCT", " ");
                ora.AddParameter("@VNEDLN", VNEDLN);
                ora.AddParameter("@VNEDTS", " ");
                ora.AddParameter("@VNEDFT", " ");
                ora.AddParameter("@VNEDDT", Core.dateToJDE(date));
                ora.AddParameter("@VNEDER", "B");
                ora.AddParameter("@VNEDDL", 0);
                ora.AddParameter("@VNEDSP", "0");
                ora.AddParameter("@VNEDTC", "A");
                ora.AddParameter("@VNEDTR", "J");
                ora.AddParameter("@VNEDBT", VNEDBT);
                ora.AddParameter("@VNEDGL", " ");
                ora.AddParameter("@VNEDAN", 0);
                ora.AddParameter("@VNKCO", "01000"); //Town of Newmarket
                ora.AddParameter("@VNDCT", "JE");
                ora.AddParameter("@VNDOC", 0);
                ora.AddParameter("@VNDGJ", Core.dateToJDE(date));
                ora.AddParameter("@VNJELN", VNJELN);
                ora.AddParameter("@VNEXTL", " ");
                ora.AddParameter("@VNPOST", " ");
                ora.AddParameter("@VNICU", 0);
                ora.AddParameter("@VNICUT", VNICUT);
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

                if (workOrder != null)
                    ora.AddParameter("@VNSBL", positiveVNSBL);
                else
                    ora.AddParameter("@VNSBL", DBNull.Value);

                if (workOrder != null)
                    ora.AddParameter("@VNSBLT", positiveVNSBLT);
                else
                    ora.AddParameter("@VNSBLT", DBNull.Value);

                ora.AddParameter("@VNLT", "AA");
                ora.AddParameter("@VNPN", date.Month.ToString());
                ora.AddParameter("@VNCTRY", 20);
                ora.AddParameter("@VNFY", date.Year.ToString().Substring(2, 2));
                ora.AddParameter("@VNFQ", " ");
                ora.AddParameter("@VNCRCD", " ");
                ora.AddParameter("@VNCRR", 0);
                ora.AddParameter("@VNHCRR", 0);
                ora.AddParameter("@VNHDGJ", 0);
                ora.AddParameter("@VNAA", positiveVNAA);
                ora.AddParameter("@VNU", positiveVNU);
                ora.AddParameter("@VNUM", VNUM);
                ora.AddParameter("@VNGLC", " ");
                ora.AddParameter("@VNRE", " ");
                ora.AddParameter("@VNEXA", VNEXA);
                ora.AddParameter("@VNEXR", VNEXR); //Asset description
                ora.AddParameter("@VNR1", VNR1);
                ora.AddParameter("@VNR2", VNR2);
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
                ora.AddParameter("@VNASID", "                         ");
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
                ora.AddParameter("@VNALTY", DBNull.Value);
                ora.AddParameter("@VNDSVJ", 0);
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
                ora.AddParameter("@VNAG", DBNull.Value); //Dollar amount, no decimal
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
                ora.Run();

                lineNumber++;
            }

            //Prepare for negative
            VNEDLN = 1000 * lineNumber;

            //Negative
            if (sides == GLSides.Both || sides == GLSides.NegativeOnly)
            {
                Oracle ora = new Oracle("INSERT into " + schema + ".F0911Z1 VALUES (@VNEDUS, @VNEDTY, @VNEDSQ, @VNEDTN, @VNEDCT, @VNEDLN, @VNEDTS, @VNEDFT, @VNEDDT, @VNEDER, @VNEDDL, @VNEDSP, @VNEDTC, @VNEDTR, @VNEDBT, @VNEDGL, @VNEDAN, @VNKCO, @VNDCT, @VNDOC, @VNDGJ, @VNJELN, @VNEXTL, @VNPOST, @VNICU, @VNICUT, @VNDICJ, @VNDSYJ, @VNTICU, @VNCO, @VNANI, @VNAM, @VNAID, @VNMCU, @VNOBJ, @VNSUB, @VNSBL, @VNSBLT, @VNLT, @VNPN, @VNCTRY, @VNFY, @VNFQ, @VNCRCD, @VNCRR, @VNHCRR, @VNHDGJ, @VNAA, @VNU, @VNUM, @VNGLC, @VNRE, @VNEXA, @VNEXR, @VNR1, @VNR2, @VNR3, @VNSFX, @VNODOC, @VNODCT, @VNOSFX, @VNPKCO, @VNOKCO, @VNPDCT, @VNAN8, @VNCN, @VNDKJ, @VNDKC, @VNASID, @VNBRE, @VNRCND, @VNSUMM, @VNPRGE, @VNTNN, @VNALT1, @VNALT2, @VNALT3, @VNALT4, @VNALT5, @VNALT6, @VNALT7, @VNALT8, @VNALT9, @VNALT0, @VNALTT, @VNALTU, @VNALTV, @VNALTW, @VNALTX, @VNALTZ, @VNDLNA, @VNCFF1, @VNCFF2, @VNASM, @VNBC, @VNVINV, @VNIVD, @VNWR01, @VNPO, @VNPSFX, @VNDCTO, @VNLNID, @VNWY, @VNWN, @VNFNLP, @VNOPSQ, @VNJBCD, @VNJBST, @VNHMCU, @VNDOI, @VNALID, @VNALTY, @VNDSVJ, @VNTORG, @VNREGPOUND, @VNPYID, @VNUSER, @VNPID, @VNJOBN, @VNUPMJ, @VNUPMT, @VNCRRM, @VNACR, @VNDGM, @VNDGD, @VNDGY, @VNGDGPOUND, @VNDICM, @VNDICD, @VNDICY, @VNDICPOUND, @VNDSYM, @VNDSYS, @VNDSYY, @VNDSYPOUND, @VNDKM, @VNDKD, @VNDKY, @VNDKPOUND, @VNDSVM, @VNDSVD, @VNDSVY, @VNDSVPOUND, @VNHDGM, @VNHDGD, @VNHDGY, @VNHDGPOUND, @VNDKCM, @VNDKCD, @VNDKCY, @VNDKCPOUND, @VNIVDM, @VNIVDD, @VNIVDY, @VNIVDPOUND, @VNABR1, @VNABR2, @VNABR3, @VNABR4, @VNABT1, @VNABT2, @VNABT3, @VNABT4, @VNITM, @VNPM01, @VNPM02, @VNPM03, @VNPM04, @VNPM05, @VNPM06, @VNPM07, @VNPM08, @VNPM09, @VNPM10, @VNBCRC, @VNEXR1, @VNTXA1, @VNTXITM, @VNACTB, @VNSTAM, @VNCTAM, @VNAG, @VNAGF, @VNTKTX, @VNDLNID, @VNCKNU, @VNBUPC, @VNAHBU, @VNEPGC, @VNJPGC, @VNRC5, @VNSFXE, @VNOFM)");
                ora.AddParameter("@VNEDUS", "JDE");
                ora.AddParameter("@VNEDTY", "N");
                ora.AddParameter("@VNEDSQ", 0);
                ora.AddParameter("@VNEDTN", "1");
                ora.AddParameter("@VNEDCT", " ");
                ora.AddParameter("@VNEDLN", VNEDLN);
                ora.AddParameter("@VNEDTS", " ");
                ora.AddParameter("@VNEDFT", " ");
                ora.AddParameter("@VNEDDT", Core.dateToJDE(date));
                ora.AddParameter("@VNEDER", "B");
                ora.AddParameter("@VNEDDL", 0);
                ora.AddParameter("@VNEDSP", "0");
                ora.AddParameter("@VNEDTC", "A");
                ora.AddParameter("@VNEDTR", "J");
                ora.AddParameter("@VNEDBT", VNEDBT);
                ora.AddParameter("@VNEDGL", " ");
                ora.AddParameter("@VNEDAN", 0);
                ora.AddParameter("@VNKCO", "01000"); //Town of Newmarket
                ora.AddParameter("@VNDCT", "JE");
                ora.AddParameter("@VNDOC", 0);
                ora.AddParameter("@VNDGJ", Core.dateToJDE(date));
                ora.AddParameter("@VNJELN", VNJELN);
                ora.AddParameter("@VNEXTL", " ");
                ora.AddParameter("@VNPOST", " ");
                ora.AddParameter("@VNICU", 0);
                ora.AddParameter("@VNICUT", VNICUT);
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

                if (workOrder != null)
                    ora.AddParameter("@VNSBL", negativeVNSBL);
                else
                    ora.AddParameter("@VNSBL", DBNull.Value);

                if (workOrder != null)
                    ora.AddParameter("@VNSBLT", negativeVNSBLT);
                else
                    ora.AddParameter("@VNSBLT", DBNull.Value);

                ora.AddParameter("@VNLT", "AA");
                ora.AddParameter("@VNPN", date.Month.ToString());
                ora.AddParameter("@VNCTRY", 20);
                ora.AddParameter("@VNFY", date.Year.ToString().Substring(2, 2));
                ora.AddParameter("@VNFQ", " ");
                ora.AddParameter("@VNCRCD", " ");
                ora.AddParameter("@VNCRR", 0);
                ora.AddParameter("@VNHCRR", 0);
                ora.AddParameter("@VNHDGJ", 0);
                ora.AddParameter("@VNAA", negativeVNAA);
                ora.AddParameter("@VNU", negativeVNU);
                ora.AddParameter("@VNUM", VNUM);
                ora.AddParameter("@VNGLC", " ");
                ora.AddParameter("@VNRE", " ");
                ora.AddParameter("@VNEXA", VNEXA);
                ora.AddParameter("@VNEXR", VNEXR); //Asset description
                ora.AddParameter("@VNR1", VNR1);
                ora.AddParameter("@VNR2", VNR2);
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
                ora.AddParameter("@VNASID", "                         ");
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
                ora.AddParameter("@VNALTY", "");
                ora.AddParameter("@VNDSVJ", 0);
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
                ora.AddParameter("@VNAG", ""); //Dollar amount, no decimal
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
                ora.Run();

                lineNumber++;
            }

            return lineNumber;
        }

        public static string encrypt(string x)
        {
            System.Security.Cryptography.SHA512 shaTransmute = System.Security.Cryptography.SHA512.Create();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(x);
            data = shaTransmute.ComputeHash(data);
            String sha2Hash = System.Text.Encoding.ASCII.GetString(data);

            return sha2Hash;
        }

        public static string getSalt()
        {
            Random r = new Random();
            char[] salt = new char[100];

            for (int i = 0; i < salt.Length; i++)
            {
                salt[i] = (char)r.Next(255);
            }

            return (new string(salt));
        }

        public static void checkPrerequisite(string filename)
        {
            try
            {
                string source = Path.GetDirectoryName(getDeploymentPath()) + "\\" + filename;
                string target = AppDomain.CurrentDomain.BaseDirectory + filename;
                
                if(!File.Exists(target)) //If it doesn't exist
                    File.Copy(source, target, true);

                long fileSize = (new FileInfo(target)).Length; //In bytes
                int attemptNo = 1;

                while (fileSize < 1024 && attemptNo <= 5) //If is a compressed stub
                {
                    File.Copy(source, target, true); //Try again
                    Core.sleep(1000);

                    fileSize = (new FileInfo(target)).Length;

                    attemptNo++;
                }

                File.SetAttributes(target, FileAttributes.Normal);
                File.SetAttributes(target, FileAttributes.Hidden);
            }
            catch (IOException e)
            {
                Core.log("Core", "checkPrerequisite", filename + ": " + e.Message);

                if (e.Message.Contains("already exists"))
                {
                    //Ignore
                    //Unsure why this exception happens when we check for existence
                }
                else
                    throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool isAdmin()
        {
            SQL sql = new SQL("select * from permissions where username=@USERNAME and Program='Admin'");
            sql.AddParameter("@USERNAME", Core.getUsername());
            DataTable dt = sql.Run();

            return dt.Rows.Count > 0;
        }

        public static int getStringWidth(string s, Font font)
        {
            return TextRenderer.MeasureText(s, font).Width;
        }

        public static string getErrorText(Exception e)
        {
            string stackTrace = "";

            try
            {
                for (int i = 0; i < e.StackTrace.Split('\n').Length; i++)
                {
                    if (e.StackTrace.Split('\n')[i].Contains(":line "))
                        stackTrace += e.StackTrace.Split('\n')[i];
                }
            }
            catch
            {
                stackTrace = "Couldn't read stack trace.";
            }

            stackTrace = stackTrace.Replace("   at I_IT.", "");
            stackTrace = stackTrace.Replace("C:\\Users\\graeme smyth\\Documents\\Visual Studio 2015\\Projects\\I❤IT\\I❤IT\\", "");
            stackTrace = stackTrace.Replace("..ctor()", " constructor");
            stackTrace = stackTrace.Replace("\r", "\r\n");

            string arguments = "";

            foreach (object arg in e.Data.Values)
                arguments += arg.ToString() + Environment.NewLine;

            if (arguments != "")
                arguments += Environment.NewLine;

            return "User - " + getUsername() + Environment.NewLine
                + "Machine - " + Environment.MachineName + Environment.NewLine
                + "Version - " + getVersion() + Environment.NewLine
                + Environment.NewLine
                + arguments
                + e.GetType().Name + Environment.NewLine
                + e.Message + Environment.NewLine
                + Environment.NewLine
                + (e.InnerException != null ? e.InnerException + Environment.NewLine : "")
                + stackTrace + Environment.NewLine;
        }

        public static string getVariable(string var)
        {
            return SQL.Run("select value from systemvariables where variable='" + var + "'").Rows[0]["value"].ToString();
        }

        public static void setVariable(string var, string val)
        {
            SQL.Run("update systemvariables set value='" + val + "' where variable='" + var + "'");
        }

        public static bool isTask()
        {
            if (Core.getUsername() != "IHeartIT" &&
                            Core.getUsername() != "SYSTEM" &&
                            Core.getUsername() != "Gsmyth")
                return false;

            if (Environment.MachineName != Core.taskMachineName &&
                Environment.MachineName != Core.devMachineName)
                return false;

            return true;
        }
        
        public static DateTime FromUnixTime(long unixTime) //GMT
        {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTime/1000).AddHours(-4); //Hours to convert to time-zone
        }

        public static void error(Exception e)
        {
            bool problem = true;

            if (e is ObjectDisposedException) //Form has been closed
                problem = false; //Not a problem
            else if (e is ArgumentNullException) //Form doesn't exist
                e = new Exception("A program of that name doesn't exist.");

            if (problem)
            {
                //Report to IT
                if (e is UnauthorizedAccessException && e.Message.Contains("Public") && e.Message.Contains("Desktop") && e.Message.Contains("Access to path") && e.Message.Contains("is denied"))
                    sendMail("accessit@newmarket.ca", "For Help Desk - " + assemblyFileName + " Error", getErrorText(e));
                else
                    sendMail("ealarcon@newmarket.ca", assemblyFileName + " Error", getErrorText(e));

                if (Core.isTask())
                {
                    throw e; //Servers can't display messages, so just throw, and let it sit in Event Viewer
                }
                else
                {
                    string response = Core.lookupMessageBox(
                            "Error",
                            "Unfortunately something went wrong, however this has automatically been reported to IT."
                            + Environment.NewLine + "You should receive an e-mail response soon.", "Show me the error", "OK");

                        if (response == "Show me the error")
                            MessageBox.Show(getErrorText(e));
                }
            }
        }

        public static bool isHoliday(DateTime date)
        {
            bool returnable = false;

            try
            {
                DataTable dt = SQL.Run("use DATS; select date, description from holidays");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (DateTime.Parse(dt.Rows[i][0].ToString()) == date)
                    {
                        returnable = true;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Crashed trying to find out whether or not today was a holiday.");
            }
            return returnable;
        }

        public static long dateToLong(DateTime date)
        {
            long x = 0;

            x += date.Second;
            x += 60 * date.Minute;
            x += 60 * date.Hour;
            x += 24 * date.DayOfYear;
            x += 365 * date.Year;

            return x;
        }
        
        public static void sendMail(string to, string subject, string body)
        {
            //Use commas to list
            sendMail(to, subject, body, mailSentFrom, windowsLogin, windowsPassword);
        }

        public static void sendMail(string to, string subject, string body, string from, string username, string password)
        {
            body = "<font face=\"arial\">" + body.Replace("\r\n", "<br />") + "</font>";
            MailMessage objMail = new MailMessage(from, to, subject, body);

            string emailGuess = "";

            if (Environment.UserName.Contains(' '))
                emailGuess = Environment.UserName.Split(' ')[0][0] + Environment.UserName.Split(' ')[1] + "@newmarket.ca";
            else
                emailGuess = Environment.UserName + "@newmarket.ca";

            objMail.ReplyToList.Add(emailGuess);
            objMail.IsBodyHtml = true;
            NetworkCredential objNC = new NetworkCredential(username, password);
            SmtpClient objsmtp = new SmtpClient(mailServer, 25);
            objsmtp.Credentials = objNC;
            objsmtp.Send(objMail);
        }

        public static void invoke(Action method)
        {
            MethodInvoker mi = new MethodInvoker(method);
            mi.BeginInvoke(null, null);
        }

        public static void passBack(Control passThis, Action method)
        {
            try
            {
                passThis.Invoke((MethodInvoker)delegate { method(); });
            }
            catch (InvalidOperationException) //If program is closed when thread returns
            {

            }
        }

        //Don't need to add .xlsx in filename when calling this
        public static void export(string filename, DataTable dt)
        {
            try
            {
                filename = filename.Replace('<', '-');
                filename = filename.Replace('>', '-');
                filename = filename.Replace(':', '-');
                filename = filename.Replace('"', '-');
                filename = filename.Replace('/', '-');
                filename = filename.Replace('\\', '-');
                filename = filename.Replace('|', '-');
                filename = filename.Replace('?', '-');
                filename = filename.Replace('*', '-');

                XLWorkbook wb = new XLWorkbook();
                var ws = wb.Worksheets.Add(dt, "Report");
                ws.Column(7).Style.NumberFormat.Format = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;

                
                string directory = tempDirectory;
                string filePath = directory + filename;
                string add = "";

                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                //Keep looking for file names untl you find one that doesn't exist.
                //Starts with filename.xlsx, then filename 2.xlsx, and so on.
                while (File.Exists(filePath + (add != "" ? " " : "") + add + ".xlsx"))
                {
                    if (add == "")
                        add = "2";
                    else
                        add = (int.Parse(add) + 1).ToString();
                }

                filePath += (add != "" ? " " : "") + add + ".xlsx";

                try
                {
                    wb.SaveAs(filePath);

                    Process.Start(filePath);
                }
                catch(ArgumentException) //Illegal characters in filename
                {
                    export("Report", dt);
                }
            }
            catch (FileNotFoundException e)
            {
                Core.error(e);
            }
            catch (OutOfMemoryException e)
            {
                if (isTask())
                    Core.error(e);
                else
                    MessageBox.Show("Your computer doesn't have enough memory to export this to Excel. A few things you could try..." + Environment.NewLine
                        + "- Close some of the programs you have open, which frees up more memory" + Environment.NewLine
                        + "- Reboot your computer, which forces closed a lot of the behind-the-scenes programs your computer might have open, which frees up more memory" + Environment.NewLine
                        + "- If you're exporting from a report, try filtering the report to have fewer rows, which reduces the memory needed to perform the export");
            }
        }

        //Takes a date in string format, and returns that string in JDE-style date
        public static string dateToJDE(string date)
        {
            string returnable = "1";

            DateTime temp = DateTime.Parse(date);

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

        public static string dateToJDE(DateTime date)
        {
            string returnable = "1";

            DateTime temp = date;

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

        public static int timeToJDE(DateTime date)
        {
            return (date.Hour * 10000) + (date.Minute * 100) + date.Second;
        }

        //Takes a date in JDE format, and returns that string as a date
        public static DateTime JDEToDate(string JDEDate)
        {
            int year = 0;
            int daysToAdd = 0;

            if (JDEDate.Length == 5)
            {
                year = int.Parse(JDEDate.Substring(0, 2)) + 1900;
                daysToAdd = int.Parse(JDEDate.Substring(2, 3));
            }
            else if (JDEDate.Length == 6)
            {
                if (JDEDate[0] == '0')
                    year = int.Parse(JDEDate.Substring(1, 2)) + 1900;
                else if (JDEDate[0] == '1')
                    year = int.Parse(JDEDate.Substring(1, 2)) + 2000;

                daysToAdd = int.Parse(JDEDate.Substring(3, 3));
            }

            DateTime date = new DateTime(year, 1, 1);

            date = date.AddDays(daysToAdd - 1);

            return date;
        }

        public static DateTime JDEToTime(string JDETime)
        {
            int x = int.Parse(JDETime);

            int second = x % 100;
            int minute = (x /= 100) % 100;
            int hour = (x /= 100) % 100;

            return DateTime.Today.AddHours(hour).AddMinutes(minute).AddSeconds(second);
        }

        public static double calculateStormwaterCredit(string rollNumber, double lowRate, double mediumRate, double highRate, double lowArea, double mediumArea, bool pollutionPrevention)
        {
            double areaTreated = lowArea + mediumArea;

            double creditIfAtHighRate = areaTreated * highRate;
            double creditAtRecalculatedRate = (lowArea * lowRate) + (mediumArea * mediumRate);

            double totalArea = getArea(rollNumber);
            double weightedAverageRate = 0;

            weightedAverageRate += ((totalArea - areaTreated) / totalArea) * highRate;
            weightedAverageRate += (mediumArea / totalArea) * mediumRate;
            weightedAverageRate += (lowArea / totalArea) * lowRate;

            double pollutionPreventionCredit = 0;

            if (pollutionPrevention)
                pollutionPreventionCredit = totalArea * weightedAverageRate * 0.05;

            return creditIfAtHighRate - creditAtRecalculatedRate + pollutionPreventionCredit;
        }

        private static double getArea(string rollNo)
        {
            double areaM = 0;
            string condoID = getCondoID(rollNo);

            if (condoID != "") //Condo
            {
                DataTable gis = GISPub.Run("select sde.st_area(shape) from tongis.view_asmnt_parcel where roll_no = '" + rollNo + "'");

                if (gis.Rows.Count > 0)
                    areaM = double.Parse(gis.Rows[0][0].ToString()); //Area of whole condo

                areaM /= getNumCondoUnits(condoID); //Divide by number of units to get unit's share
            }
            else //Not condo
            {
                Vailtech ora = new Vailtech("select site_area, uom, roll_no from TX_PROP_DATA where roll_no = @ROLLNO");
                ora.AddParameter("@ROLLNO", rollNo);
                DataTable dt = ora.Run();

                if (dt.Rows.Count == 0)
                    return 0;

                areaM = double.Parse(dt.Rows[0][0].ToString());
                string unit = dt.Rows[0][1].ToString();

                //Convert to square meters
                if (unit == "F")
                    areaM *= 0.092903;
                else if (unit == "A")
                    areaM *= 4046.86;
                else if (areaM == 0 || unit == "N")
                {
                    DataTable gis = GISPub.Run("select sde.st_area(shape) from tongis.view_asmnt_parcel where roll_no = '" + rollNo + "'");

                    if (gis.Rows.Count > 0)
                        areaM = double.Parse(gis.Rows[0][0].ToString());
                }
            }

            return (double)((int)(areaM * 1000)) / 1000;
        }

        static string getCondoID(string rollNo)
        {
            Vailtech ora = new Vailtech("select LEGAL1 from VAILTECH.TX_ROLL where ROLL_NO=@ROLLNO and (LEGAL1 like '%CONDO%' or LEGAL1 like '%YRSCP%' or LEGAL1 like '%YRCP%')");
            ora.AddParameter("@ROLLNO", rollNo);
            DataTable dt = ora.Run();

            if (dt.Rows.Count > 0)
                return dt.Rows[0][0].ToString();

            return "";
        }

        static bool isCondo(string rollNo)
        {
            return getCondoID(rollNo) != "";
        }

        static int getNumCondoUnits(string condoID)
        {
            int id = int.Parse(Regex.Match(condoID, @"\d+").Value);

            Vailtech ora = new Vailtech("select LEGAL1 from VAILTECH.TX_ROLL where (LEGAL1 like '%CONDO%' or LEGAL1 like '%YRSCP%' or LEGAL1 like '%YRCP%') and LEGAL1 like '%" + id + "%'");
            DataTable dt = ora.Run();

            return dt.Rows.Count;
        }

        public static string getSchema(string environment)
        {
            if (environment == "PD")
                return "CRPDTA";
            else if (environment == "PY")
                return "CRPDTA";
            else if (environment == "DV")
                //environment = "TESTDTA";
                return "TESTDTA";
            else
                throw new Exception("JDE environment not recognized, check Core for env: " + environment);

            //return "";
        }

        public static string getControlSchema(string environment)
        {
            if (environment == "PD")
                return "PRODCTL";
            else if (environment == "PY")
                return "CRPCTL";
            else if (environment == "DV")
                //environment = "TESTCTL";
                return "TESTCTL";
            else
                throw new Exception("JDE environment not recognized, check Core for env: " + environment);

            //return "";
        }

        public static string getEmployeeBusinessUnit(string env, int empID)
        {
            string s = getSchema(env);

            return Oracle.RunString("select YAHMCU from " + s + ".F060116 where YAAN8 = @EMPID", empID);
        }

        public static string getEmployeeName(string env, int empID)
        {
            string s = getSchema(env);

            return Oracle.RunString("select YAALPH from " + s + ".F060116 where YAAN8 = @EMPID", empID);
        }

        public static string getADValueFromDisplayName(string displayName, string columnName)
        {
            DirectoryEntry entry = new DirectoryEntry("LDAP://DC2012R2X3");
            DirectorySearcher dSearch = new DirectorySearcher(entry);
            dSearch.Filter = "(&(objectClass=user)(displayname=" + displayName + "))";

            DataTable dt = new DataTable();

            SearchResultCollection sResultSetCollection = dSearch.FindAll();

            if (sResultSetCollection.Count == 0)
                return "";

            foreach (SearchResult row in sResultSetCollection)
                if (row.Properties.Contains(columnName))
                    return row.Properties[columnName][0].ToString();

            return "";
        }

        public static string getADValueFromUsername(string windowsUsername, string columnName)
        {
            DirectoryEntry entry = new DirectoryEntry("LDAP://DC2012R2X3");
            DirectorySearcher dSearch = new DirectorySearcher(entry);
            dSearch.Filter = "(&(objectClass=user)(samaccountname=" + windowsUsername + "))";

            DataTable dt = new DataTable();

            SearchResultCollection sResultSetCollection = dSearch.FindAll();
            
            if(sResultSetCollection.Count == 0)
                return "";

            foreach (SearchResult row in sResultSetCollection)
                if (row.Properties.Contains(columnName))
                    return row.Properties[columnName][0].ToString();
            
            return "";
        }

        public static Employee getEmployee()
        {
            return getEmployee(Core.getUsername());
        }

        public static Employee getEmployee(string windowsUsername)
        {
            Employee e = new Employee();

            e.WindowsUsername = getADValueFromUsername(windowsUsername, "cn");
            e.AccountChanged = DateTime.Parse(getADValueFromUsername(windowsUsername, "whenChanged"));
            e.AccountCreated = DateTime.Parse(getADValueFromUsername(windowsUsername, "whenCreated"));
            e.AccountExpires = DateTime.FromFileTimeUtc(long.Parse(getADValueFromUsername(windowsUsername, "accountexpires")));
            e.Department = getADValueFromUsername(windowsUsername, "homePostalAddress");
            e.DisplayName = getADValueFromUsername(windowsUsername, "displayname");
            e.EmailAddress = getADValueFromUsername(windowsUsername, "mail");
            e.EmailNickname = getADValueFromUsername(windowsUsername, "mailnickname");
            e.FirstName = getADValueFromUsername(windowsUsername, "givenName");
            e.JobTitle = getADValueFromUsername(windowsUsername, "title");
            e.LastLogon = DateTime.FromFileTimeUtc(long.Parse(getADValueFromUsername(windowsUsername, "lastlogon")));
            e.LastName = getADValueFromUsername(windowsUsername, "sn");
            e.PhoneNumber = getADValueFromUsername(windowsUsername, "telephoneNumber");

            return e;
        }
    }
}

public class WorkOrder
{
    public int woID;
    public string woDesc;

    public WorkOrder()
    {

    }

    public WorkOrder(int i, string d)
    {
        woID = i;
        woDesc = d;
    }
}

public class Employee
{
    public string WindowsUsername;
    public string DisplayName;
    public string FirstName;
    public string LastName;
    public string Department;
    public string JobTitle;
    public string PhoneNumber;
    public string EmailAddress;
    public DateTime AccountCreated;
    public DateTime AccountChanged;
    public DateTime AccountExpires;
    public DateTime LastLogon;
    public string EmailNickname;
}