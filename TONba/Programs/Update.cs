using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    class Update
    {
        public Update()
        {
            MessageBox.Show("This program is meant for automatic processes only.");
        }

        public Update(string arguments)
        {
            try
            {
                string source = Core.deploymentPath + Core.assemblyFileName;
                string destination = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\" + Core.assemblyFileName;

                bool copied = false;

                for(int i = 0; !copied; i++)
                {
                    try
                    {
                        File.Copy(source, destination, true);
                        copied = true;
                    }
                    catch(Exception e)
                    {
                        if (i < 10)
                            Core.sleep(1000);
                        else
                        {
                            Core.log("Update", "Crash note", Core.updateFileName + " unable to copy from " + source + " to " + destination);
                            throw e;
                        }
                    }
                }

                Core.run(destination, arguments);
            }
            catch(Exception e)
            {
                Core.error(e);
            }
        }
    }
}
