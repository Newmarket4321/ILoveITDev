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
    public partial class VisaErrorCheck : Form
    {
        public VisaErrorCheck()
        {
            InitializeComponent();
            Hide();
            Core.invoke(run);
        }

        public void run()
        {
            try
            {
                //Get file
                Core.lookupMessageBox("", "On the next screen, select the Visa Excel file.");

                bool success = false;
                string filepath = "";

                Core.passBack(this, delegate { filepath = Core.getFile(out success); });


                if (!success)
                {
                    Core.lookupMessageBox("", "Not successful retrieving file.");
                    Core.passBack(this, delegate { Close(); });
                    return;
                }

                //Open spreadsheet
                Spreadsheet file = new Spreadsheet(filepath);
                List<string> columns = new List<string>();

                for (int i = 1; i <= file.Cells().Columns.Count; i++)
                {
                    if (file.Cells()[1, i].Text.Trim() != "")
                        columns.Add(file.Cells()[1, i].Text.Trim());
                    else
                        break;
                }

                string columnAccountNumber;
                string columnNationalTax;
                string columnRegionalTax;

                if (Core.getUsername() == "ssargent")
                {
                    columnAccountNumber = "Allocation Accounting Code Value";
                    columnNationalTax = "National Tax";
                    columnRegionalTax = "Regional Tax";
                }
                else
                {
                    columnAccountNumber = Core.lookupDropdown("Which column contains the account numbers?", columns);
                    columnNationalTax = Core.lookupDropdown("Which column contains the national tax?", columns);
                    columnRegionalTax = Core.lookupDropdown("Which column contains the regional tax?", columns);
                }

                int colIndexAccount = -1;
                int colIndexNational = -1;
                int colIndexRegional = -1;

                for (int i = 0; i < columns.Count; i++)
                {
                    if (columns[i] == columnAccountNumber)
                        colIndexAccount = i + 1; //Excel starts at 1

                    if (columns[i] == columnNationalTax)
                        colIndexNational = i + 1; //Excel starts at 1

                    if (columns[i] == columnRegionalTax)
                        colIndexRegional = i + 1; //Excel starts at 1
                }

                DataTable dt = new DataTable();
                dt.Columns.Add("Excel Row Number");
                dt.Columns.Add("Error");

                int numRows = 0;

                for (int i = 2; i <= file.Cells().Rows.Count; i++, numRows++)
                {
                    string k = file.Cells()[i, 1].Text.Trim();

                    if (k == "")
                        break;
                }

                Core.passBack(this, delegate
                {
                    Show();
                    progressBarDetailed1.Maximum = numRows;
                    progressBarDetailed1.Start();
                });

                //Go through each row
                //Spreadsheets start counting at 1
                //Loop starts at 2 because we want to skip row 1 (headers)
                //Keep going until you run out of rows, or until the 1st column in a row is blank
                for (int i = 2; i <= file.Cells().Rows.Count && file.Cells()[i, 1].Text.Trim() != ""; i++)
                {
                    string dataAccount = file.Cells()[i, colIndexAccount].Text.Trim();
                    string dataNational = file.Cells()[i, colIndexNational].Text.Trim().Replace("$", "").Replace("(", "-").Replace(")", "");
                    string dataRegional = file.Cells()[i, colIndexRegional].Text.Trim().Replace("$", "").Replace("(", "-").Replace(")", "");

                    try
                    {
                        processAndGetError(i, dataAccount, dataNational, dataRegional, colIndexAccount, colIndexNational, colIndexRegional);
                    }
                    catch (Exception e)
                    {
                        string[] error = { i.ToString(), e.Message };
                        dt.Rows.Add(error);
                    }

                    Core.passBack(this, delegate
                    {                        
                        progressBarDetailed1.Value++;
                    });
                }

                Core.passBack(this, delegate { progressBarDetailed1.Value = progressBarDetailed1.Maximum; });
                
                if (dt.Rows.Count > 0)
                {
                    try
                    {
                        Core.export("Visa Error Check - " + DateTime.Now.ToString(), dt);
                    }
                    catch
                    {
                        MessageBox.Show("The results finished calculating, however there was a problem opening the results in Excel." + Environment.NewLine
                            + "Please report this to IT, e-mailing them the input file used.");
                    }
                }
                else
                    MessageBox.Show("The process has finished. There were no errors.");

                file.Close();
                Core.passBack(this, delegate { Close(); });
            }
            catch(Exception e)
            {
                Core.error(e);
            }
        }

        public void processAndGetError(int i, string account, string national, string regional, int colIndexAccount, int colIndexNational, int colIndexRegional)
        {
            string mcu = "";
            string obj = "";
            string sub = "";
            decimal nationalTax = 0;
            decimal regionalTax = 0;
            
            try { nationalTax = decimal.Parse(national); }
            catch { throw new Exception("Couldn't parse national tax (" + national + ")."); }

            try { regionalTax = decimal.Parse(regional); }
            catch { throw new Exception("Couldn't parse regional tax (" + regional + ")."); }

            if (regionalTax != 0)
                throw new Exception("Regional tax is not zero (" + regional + ").");

            //Condense spaces to help for later use of Split()
            while (account.Contains("  "))
                account = account.Replace("  ", " ");

            //Parse information
            if (account.Contains("A") || account.Contains("a"))
            {
                if (account.Split(' ').Length < 4)
                    throw new Exception("Not formatted as expected. (XXXX   XXXX   XXXX A)");
                
                mcu = account.Split(' ')[0];
                obj = account.Split(' ')[1];
                mcu.Contains("0000000");
                if (mcu.Contains("0000000"))
                {
                    mcu = mcu.Substring(6);
                }
                if (mcu.Contains("00"))
                {
                    obj = obj.Substring(3);
                }
            }
            else if (account.Contains("W") || account.Contains("w"))
            {
                int wo = -1;

                if (account.Split(' ').Length < 3 || account.Split(' ').Length > 4)
                    throw new Exception("Not formatted as expected. (   XXXX   XXXX W)");

                obj = account.Split(' ')[0];
                if (obj.StartsWith("00"))
                {
                    obj = obj.Substring(3);
                }

                if (account.Split(' ').Length == 4)
                {
                    sub = account.Split(' ')[1];

                    try { wo = int.Parse(account.Split(' ')[2]); }
                    catch { throw new Exception("Couldn't parse work order number (" + account.Split(' ')[2] + ")."); }
                }
                else
                {
                    try { wo = int.Parse(account.Split(' ')[1]); }
                    catch { throw new Exception("Couldn't parse work order number (" + account.Split(' ')[1] + ")."); }
                }

                if (obj != "" && wo != -1)
                {
                    DataTable dt = Oracle.Run("select * from CRPDTA.F4801 where WADOCO = @WO", wo);

                    if (dt.Rows.Count == 0)
                        throw new Exception("Work order number not found (" + wo + ").");

                    mcu = dt.Rows[0]["WAMCU"].ToString().Trim();
                }
            }
            else
            {
                if (account.Split(' ').Length < 2 || account.Split(' ').Length > 3)
                {
                    if(account.Contains("0000000") || account.Contains("00"))
                    {
                        var temp = "";
                        if (account.Contains("0000000"))
                        {
                            int idx = account.IndexOf("0000000");
                            temp = account.Remove(idx, 7);
                            mcu = temp.Substring(0, 5);
                        }
                        if(account.Contains("00"))
                        {
                            temp = temp.Substring(5);
                            int idx = temp.IndexOf("00");
                            obj = temp.Remove(idx, 2);
                        }
                        
                    }
                    
                    else
                    {
                        throw new Exception("Not formatted as expected. (XXXX   XXXX, or XXXX   XXXX XX)");
                    }
                }
                    

                mcu = account.Split(' ')[0];
                obj = account.Split(' ')[1];
                if (mcu.Contains("0000000"))
                {
                    mcu = mcu.Substring(6);
                }
                if(obj.Contains("000"))
                {
                    obj = obj.Substring(3);
                }
                    
                if (account.Split(' ').Length == 3)
                    sub = account.Split(' ')[2];
            }

            if(obj == "4478" && !account.Contains("A") && !account.Contains("a"))
                throw new Exception("Allocating to 4478 without an 'A'.");

            if (mcu == "1000" && nationalTax != 0)
                throw new Exception("Business unit is 1000, but national tax is non-zero (" + nationalTax.ToString("C") + ")");

            if (mcu == "1000" && regionalTax != 0)
                throw new Exception("Business unit is 1000, but regional tax is non-zero (" + regionalTax.ToString("C") + ")");

            if (!accountExists(mcu))
                throw new Exception("Business unit " + mcu + " doesn't exist.");

            if (!accountExists(mcu, obj))
                throw new Exception("Within business unit " + mcu + ", the object code " + obj + " doesn't exist.");

            if (sub != "" && !accountExists(mcu, obj, sub))
                throw new Exception("Within account " + mcu + "." + obj + ", the sub " + sub + " doesn't exist.");

            if (sub == "" && isNonPostingAccount(mcu, obj))
                throw new Exception(mcu + "." + obj + " is a non-posting account.");

            if (sub != "" && isNonPostingAccount(mcu, obj, sub))
                throw new Exception(mcu + "." + obj + "." + sub + " is a non-posting account.");
        }

        public bool isNonPostingAccount(string mcu, string obj)
        {
            return isNonPostingAccount(mcu, obj, "");
        }

        public bool isNonPostingAccount(string mcu, string obj, string sub)
        {
            if (obj == "" && sub == "")
                return Oracle.RunString("select trim(GMPEC) from CRPDTA.F0901 where trim(GMMCU) = @MCU", mcu) == "N";
            else if (obj != "" && sub == "")
                return Oracle.RunString("select trim(GMPEC) from CRPDTA.F0901 where trim(GMMCU) = @MCU and trim(GMOBJ) = @OBJ", mcu, obj) == "N";
            else
                return Oracle.RunString("select trim(GMPEC) from CRPDTA.F0901 where trim(GMMCU) = @MCU and trim(GMOBJ) = @OBJ and trim(GMSUB) = @SUB", mcu, obj, sub) == "N";
        }

        public bool accountExists(string mcu)
        {
            return accountExists(mcu, "", "");
        }

        public bool accountExists(string mcu, string obj)
        {
            return accountExists(mcu, obj, "");
        }

        public bool accountExists(string mcu, string obj, string sub)
        {
            if(obj == "" && sub == "")
                return Oracle.Run("select * from CRPDTA.F0901 where trim(GMMCU) = @MCU", mcu).Rows.Count > 0;
            else if(obj != "" && sub == "")
                return Oracle.Run("select * from CRPDTA.F0901 where trim(GMMCU) = @MCU and trim(GMOBJ) = @OBJ", mcu, obj).Rows.Count > 0;
            else
                return Oracle.Run("select * from CRPDTA.F0901 where trim(GMMCU) = @MCU and trim(GMOBJ) = @OBJ and trim(GMSUB) = @SUB", mcu, obj, sub).Rows.Count > 0;
        }
    }
}
