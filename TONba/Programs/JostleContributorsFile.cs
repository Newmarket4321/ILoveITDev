using System;
using System.Data;
using System.Diagnostics;

namespace I_IT
{
    class JostleContributorsFile
    {
        public JostleContributorsFile()
        {
            string filePath = @"T:\Corp Services\IT\ADExport\Output\jostleContributors.csv";
            Process.Start(filePath);
        }
    }
}
