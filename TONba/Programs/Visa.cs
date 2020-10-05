using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class Visa : Form
    {
        public Visa()
        {
            InitializeComponent();
            
            SQL sql = new SQL("select * from programs where code=@CODE");
            sql.AddParameter("@CODE", Name);
            DataTable dt = sql.Run();

            Text = dt.Rows[0]["Description"].ToString();
        }

        public void process()
        {
            try
            {
                OpenFileDialog browse = new OpenFileDialog();
                Invoke((MethodInvoker)delegate { browse.ShowDialog(); });

                string blockType = "";
                int numRecords = 0;

                if (browse.FileName != "")
                {
                    string[] lines = File.ReadAllLines(browse.FileName);

                    Oracle.Run("delete from CRPDTA.F550001");
                    Oracle.Run("delete from CRPDTA.F550002");
                    Oracle.Run("delete from CRPDTA.F550003");
                    Oracle.Run("delete from CRPDTA.F550004");
                    Oracle.Run("delete from CRPDTA.F550005");
                    Oracle.Run("delete from CRPDTA.F550006");
                    Oracle.Run("delete from CRPDTA.F550007");
                    Oracle.Run("delete from CRPDTA.F550008");
                    Oracle.Run("delete from CRPDTA.F550009");
                    Oracle.Run("delete from CRPDTA.F55000A");
                    Oracle.Run("delete from CRPDTA.F55000B");
                    Oracle.Run("delete from CRPDTA.F55000C");
                    Oracle.Run("delete from CRPDTA.F55000D");
                    Oracle.Run("delete from CRPDTA.F55000E");
                    Oracle.Run("delete from CRPDTA.F55000F");
                    Oracle.Run("delete from CRPDTA.F55001A");
                    Oracle.Run("delete from CRPDTA.F55001B");

                    Invoke((MethodInvoker)delegate { progressBar1.Value = 0; });
                    Invoke((MethodInvoker)delegate { progressBar1.Maximum = lines.Length; });
                    Invoke((MethodInvoker)delegate { progressBar1.Update(); });

                    for (int i = 0; i < lines.Length; i++)
                    {
                        Invoke((MethodInvoker)delegate { progressBar1.Value = i + 1; });
                        Invoke((MethodInvoker)delegate { progressBar1.Update(); });
                        Invoke((MethodInvoker)delegate { label1.Text = (i + 1) + " of " + lines.Length; });
                        Invoke((MethodInvoker)delegate { label1.Update(); });

                        if (lines[i].Length > 0) //If line has characters
                        {
                            string tableName = "";

                            if (lines[i][0] == '6') //Start file
                            {
                                //Insert into F550001
                                tableName = "CRPDTA.F550001";
                            }
                            else if (lines[i][0] == '7') //End file
                            {
                                //Insert into F550001
                                tableName = "CRPDTA.F550001";
                            }
                            else if (lines[i][0] == '8') //Start block
                            {
                                //Insert into F550001
                                tableName = "CRPDTA.F550001";
                                blockType = lines[i].Split('\t')[4];
                            }
                            else if (lines[i][0] == '9') //End block
                            {
                                //Insert into F550001
                                tableName = "CRPDTA.F550001";
                                blockType = "";
                            }
                            else if (lines[i][0] == '4') //Data
                            {
                                if (blockType == "01") //Account balance
                                {
                                    tableName = "CRPDTA.F550002";
                                }
                                else if (blockType == "03") //Card account
                                {
                                    tableName = "CRPDTA.F550003";
                                }
                                else if (blockType == "04") //Cardholder
                                {
                                    tableName = "CRPDTA.F550004";
                                }
                                else if (blockType == "05") //Card transaction
                                {
                                    tableName = "CRPDTA.F550005";
                                }
                                else if (blockType == "06") //Company
                                {
                                    tableName = "CRPDTA.F550006";
                                }
                                else if (blockType == "07") //Line item detail
                                {
                                    tableName = "CRPDTA.F550007";
                                }
                                else if (blockType == "08") //Line item summary
                                {
                                    tableName = "CRPDTA.F550008";
                                }
                                else if (blockType == "09") //Lodging summary
                                {
                                    tableName = "CRPDTA.F550009";
                                }
                                else if (blockType == "10") //Organization
                                {
                                    tableName = "CRPDTA.F55000A";
                                }
                                else if (blockType == "11") //Period
                                {
                                    tableName = "CRPDTA.F55000B";
                                }
                                else if (blockType == "14") //Passenger itinerary
                                {
                                    tableName = "CRPDTA.F55000C";
                                }
                                else if (blockType == "15") //Leg-specific information
                                {
                                    tableName = "CRPDTA.F55000D";
                                }
                                else if (blockType == "16") //Supplier
                                {
                                    tableName = "CRPDTA.F55000E";
                                }
                                else if (blockType == "26") //Lodging detail
                                {
                                    tableName = "CRPDTA.F55000F";
                                }
                                else if (blockType == "28") //Allocation
                                {
                                    tableName = "CRPDTA.F55001A";
                                }
                                else if (blockType == "29") //Allocation description
                                {
                                    tableName = "CRPDTA.F55001B";
                                }
                                else
                                {
                                    //MessageBox.Show("Block type unknown");
                                }
                            }

                            //Process
                            if (tableName != "")
                            {
                                string values = "";

                                //Prepare SQL
                                for (int p = 0; p < lines[i].Split('\t').Length; p++)
                                    values += values == "" ? "@VAR" + p : ", @VAR" + p;

                                Oracle ora = new Oracle("insert into " + tableName + " values (" + values + ", 0)");

                                //Add parameters
                                for (int p = 0; p < lines[i].Split('\t').Length; p++)
                                {
                                    if (tableName == "CRPDTA.F550001" && p == 4)
                                        ora.AddParameter("@VAR" + p, lines[i].Split('\t')[p] == "" ? "  " : lines[i].Split('\t')[p]);
                                    else if (tableName == "CRPDTA.F550001" && p == 2)
                                        ora.AddParameter("@VAR" + p, lines[i].Split('\t')[p] == "" ? "     " : lines[i].Split('\t')[p]);
                                    else if (tableName == "CRPDTA.F55001A" && p == 15)
                                        ora.AddParameter("@VAR" + p, lines[i].Split('\t')[p].Length > 110 ? lines[i].Split('\t')[p].Substring(0, 110) : lines[i].Split('\t')[p]);
                                    else
                                        ora.AddParameter("@VAR" + p, lines[i].Split('\t')[p]);
                                }

                                ora.Run();
                                numRecords++;
                            }
                        }
                    }

                    MessageBox.Show("The file was processed successfully. " + numRecords + " records entered.");
                    Invoke((MethodInvoker)delegate { Close(); });
                }
                else
                {
                    Invoke((MethodInvoker)delegate { Close(); });
                }
            }
            catch(Exception e2)
            {
                Core.error(e2);
            }
        }

        private void Visa_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            //process();
            Core.invoke(process);
        }
    }
}
