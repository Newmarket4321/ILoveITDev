using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class Deploy : Form
    {
        public Deploy()
        {
            InitializeComponent();

            string response = Core.lookupMessageBox("Are you sure?", "Deploy new version?", "Deploy", "Deploy with backup", "Cancel");
            
            if (response == "Deploy" || response == "Deploy with backup")
            {
                //Deploy
                File.Copy(Core.devPath, Core.getDeploymentPath(), true);
                
                bool success = false;
                int attempts = 0;

                //Extra deployments, with multiple attempts
                for (int i = 0; i < Core.deploymentPathsAdditional.Length; i++)
                {
                    while (!success && attempts <= 50)
                    {
                        try
                        {
                            File.Copy(Core.devPath, Core.deploymentPathsAdditional[i], true);
                            success = true;
                        }
                        catch
                        {
                            attempts++;
                            Core.sleep(5000);
                        }
                    }
                }

                if(response == "Deploy with backup")
                    Core.backup(Core.devProjectPath, Core.backupPath);
            }

            Close();
        }
    }
}
