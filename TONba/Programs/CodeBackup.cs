using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_IT
{
    class CodeBackup
    {
        public CodeBackup()
        {
            Core.backup(Core.devProjectPath, Core.backupPath);
        }
    }
}
