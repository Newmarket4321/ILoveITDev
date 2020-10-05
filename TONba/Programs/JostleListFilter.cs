using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace I_IT
{
    class JostleListFilter
    {
        public JostleListFilter()
        {
            bool sendMailIfError = true;

            try
            {
                string filenameInput = @"\\data\files\Corp Services\IT\ADExport\contributors.csv";
                string filenameOutput = @"\\data\files\Corp Services\IT\ADExport\Output\jostleContributors.csv";
                string output = "";

                using (StreamReader sr = new StreamReader(filenameInput))
                {
                    int lineNo = 1;
                    string line = "";
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();

                        if (lineNo == 1)
                        {
                            line += ",AllowManageRelationships";
                        }
                        else
                        {
                            line += ",False";
                        }

                        string commonName = line;

                        if (commonName.Contains("\""))
                        {
                            commonName = commonName.Substring(commonName.IndexOf('"') + 1, commonName.Length - commonName.IndexOf('"') - 1);
                            commonName = commonName.Substring(commonName.IndexOf('"') + 2, commonName.Length - commonName.IndexOf('"') - 2);

                            if (commonName[0] == '\"')
                            {
                                commonName = commonName.Substring(1, commonName.Length - 1);
                                commonName = commonName.Substring(0, commonName.IndexOf('"'));
                            }
                            else
                                commonName = commonName.Substring(0, commonName.IndexOf(','));

                            SQL sql = new SQL("select * from JostleAccountBlocker where ltrim(rtrim(lower(commonname)))=ltrim(rtrim(lower(@CN)))");
                            sql.AddParameter("@CN", commonName);
                            DataTable dt = sql.Run();

                            if (dt.Rows.Count > 0)
                                output += "";
                            else
                                output += line + Environment.NewLine;
                        }
                        else
                            output += line + Environment.NewLine;

                        lineNo++;
                    }
                }

                using (StreamWriter sw = new StreamWriter(filenameOutput))
                {
                    sw.Write(output);
                }
            }
            catch (Exception e)
            {
                if (sendMailIfError)
                {
                    Core.error(e);
                }
                else
                    throw e;
            }
        }
    }
}
