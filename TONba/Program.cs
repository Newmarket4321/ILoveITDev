using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Add the event handler for handling UI thread exceptions to the event.
                Application.ThreadException += new ThreadExceptionEventHandler(threadException);

                // Set the unhandled exception mode to force all Windows Forms errors
                // to go through our handler.
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

                // Add the event handler for handling non-UI thread exceptions to the event. 
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(unhandledException);

                bool isInstallation = Core.getExecutionPath().ToLower() == Core.getDeploymentPath().ToLower() || Core.getExecutionPath().ToLower() == @"\\data\files\PCapps\I❤IT\TONba.exe".ToLower();
                bool iAmUpdate = AppDomain.CurrentDomain.FriendlyName.ToLower() == Core.updateFileName.ToLower();
                bool updateAvailable = Core.getVersion() < Core.getLatestVersion();

                string arguments = "";

                for (int i = 0; i < args.Length; i++)
                    arguments += (i != 0 ? " " : "") + "\"" + args[i] + "\"";
                
                //Install
                if (isInstallation)
                {
                    File.Copy(Core.getDeploymentPath(), Core.getUserDesktopDirectory() + @"\" + Core.assemblyFileName, true);
                    MessageBox.Show(Core.assemblyFileName + " has been installed! Check your desktop for the new icon.");
                    return;
                }

                //Prerequisites
                if (!iAmUpdate)
                {
                    Core.cleanDelete(Core.getExecutionDirectory() + @"\" + Core.updateFileName);

                    for (int i = 0; i < Core.prerequisites.Length; i++)
                        Core.checkPrerequisite(Core.prerequisites[i]);
                }

                //Must go below, otherwise Oracle errors will happen.
                Core.log(iAmUpdate ? Core.updateFileName : "Main", "Log in", Environment.MachineName + " on ver. " + Core.getVersion().ToString("MMMM d, yyyy (h:mm:ss tt)") + (arguments == "" ? "" : " - " + arguments));

                //Update is needed - send off to Update.exe
                if (updateAvailable && !iAmUpdate)
                {
                    Core.log("Main", "Update", "Update is needed. Beginning update.");
                    update(arguments);
                    return;
                }

                //Update - Pick up as Update.exe
                if (iAmUpdate)
                {
                    Core.log(Core.updateFileName, "Open Update Class", (arguments != "" ? "Arguments: " + arguments : ""));
                    Update update = new Update(arguments);
                    return;
                }

                //Run program
                if (args.Length == 0) //No parameters
                    Application.Run(new Form1());
                else //With parameters
                {
                    if (args[0].Contains(".jpg") || args[0].Contains(".bmp") || args[0].Contains(".png") || args[0].Contains(".jpeg"))
                    {
                        Core.log("Main", "Run service", args[0]);
                        CompressPicture cp = new CompressPicture(args);
                    }
                    else //First parameter is other
                    {
                        if (!Core.isIn(Core.getUsername(), Core.taskRunners))
                            throw new Exception("Program trying to be run by " + Core.getUsername() + ", who is not a task runner in Core.");

                        if (Environment.MachineName != Core.taskMachineName &&
                            Environment.MachineName != Core.devMachineName)
                            throw new Exception("Program trying to be run on " + Environment.MachineName + " which isn't authorized.");

                        Type type = Type.GetType(typeof(Program).Namespace + "." + args[0]);

                        if (type == null)
                            throw new Exception("Program \"" + args[0] + "\" does not exist.");

                        Core.log("Main", "Run service", args[0]);
                        Activator.CreateInstance(type);
                    }
                }
            }
            catch (Exception e)
            {
                for(int i = 0; i < args.Length; i++)
                    e.Data.Add(i, "Argument " + i + " - " + args[i]);

                Core.error(e);
            }
        }

        static void threadException(object sender, ThreadExceptionEventArgs t)
        {
            //MessageBox.Show("Got one!");
            Core.error(t.Exception);
        }

        static void unhandledException(object sender, UnhandledExceptionEventArgs u)
        {
            //MessageBox.Show("The one that tried to get away!");
            Core.error((Exception)u.ExceptionObject);
        }

        static void update(string arguments)
        {
            string source = Assembly.GetEntryAssembly().Location;
            string destination = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\" + Core.updateFileName;

            try
            {
                File.Copy(source, destination, true);
            }
            catch
            {
                foreach (var process in Process.GetProcessesByName("Update"))
                    process.Kill();

                Thread.Sleep(1000);

                try
                {
                    File.Copy(source, destination, true);
                }
                catch
                {
                    Thread.Sleep(1000);
                    File.Copy(source, destination, true);
                }
            }

            Core.run(destination, arguments);
        }
    }
}
