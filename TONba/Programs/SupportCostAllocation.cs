using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace I_IT
{
    public partial class SupportCostAllocation : Form
    {
        int year = DateTime.Now.Year + 1;
        private string xlsxFileName = "";
        private int columnRowCount = 0;
        private int columnCount = 0;
        private int rowCount = 0;
        private int rowColumnCount = 0;
        private int sum = 0;
        private double percent = 0;
        private int count = 0;
        private string m = "";
        private int remainder = 0;
        private int periodCounter = 0;
        private int remains = 0;
        private int cellCount = 4;

        ArrayList cellContent = new ArrayList();
        ArrayList columnContent = new ArrayList();
        ArrayList columnObject = new ArrayList();
        ArrayList columnAmount = new ArrayList();
        ArrayList distribCode = new ArrayList();
        ArrayList bSUM = new ArrayList();
        ArrayList percentagesInUse = new ArrayList();
        ArrayList periodsInUse = new ArrayList();
        ArrayList periodRemainder = new ArrayList();
        ArrayList excelSheets = new ArrayList();

        public int[,] allPercent = new int[100, 14];

        public SupportCostAllocation()
        {
            InitializeComponent();
            Hide();

            openFileDialog1.ShowDialog();

            string path = openFileDialog1.FileName;

            setXLSXFilePath(path);
            openXLSXFile(year);

            MessageBox.Show("Finished!");
            Close();
        }
        
        public void setXLSXFilePath(string filename)
        {
            xlsxFileName = filename;
        }

        public void openXLSXFile(int year)
        {
            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel.Range oRng;
            
            oXL = new Excel.Application();
            oXL.Visible = false;

            oWB = (Excel._Workbook)(oXL.Workbooks.Open(xlsxFileName));
            
            //Go through each sheet
            for (int i = 1; i <= oXL.ActiveWorkbook.Sheets.Count; i++)
            {
                cellCount = 4;
                columnObject = new ArrayList();

                oXL.ActiveWorkbook.Sheets[i].Select();
                Excel._Worksheet oSheet = (Excel._Worksheet)oWB.ActiveSheet;
                String oSheetName = oSheet.Name;

                columnRowCount = oSheet.UsedRange.Rows.Count;
                columnCount = oSheet.UsedRange.Columns.Count;

                //If the sheet is this
                if (oSheetName.Equals("Corp alloc") || oSheetName.Equals("Dept alloc"))
                {
                    for (int c = 1; c < columnRowCount; c++)
                    {
                        if (oSheet.Cells[c, 1].Value != null)
                        {
                            cellContent.Add(oSheet.Cells[c, 1].Value.ToString());
                        }
                    }

                    for (int i2 = 1; i2 < columnCount; i2++)
                    {
                        if (oSheet.Cells[1, i2].Value != null)
                        {
                            columnContent.Add(oSheet.Cells[1, i2].Value.ToString());
                        }
                    }

                    if (oSheetName.Equals("Corp alloc"))
                    {
                        for (int i2 = 0; i2 < columnContent.Count; i2++)
                        {
                            columnObject.Add(columnContent[i2].ToString().Split(' ')[0]);
                        }
                    }
                    else if (oSheetName.Equals("Dept alloc"))
                    {
                        for (int i2 = 0; i2 < columnContent.Count * 2; i2++)
                        {
                            if (oSheet.Cells[2, i2 + 4].Value != null)
                            {
                                columnObject.Add(oSheet.Cells[2, i2 + 4].Value.ToString().Split(' ')[0]);
                                i2++;
                            }
                        }
                    }

                    calculatePercentage();

                    for (int i2 = 0; i2 < columnObject.Count; i2++)
                    {
                        int counter = 0;

                        for (int i3 = 3; i3 < cellContent.Count; i3++)
                        {
                            if (oSheet.Cells[i3, cellCount].Value == null)
                            {

                            }
                            else if (oSheet.Cells[i3, cellCount].Value == 0)
                            {
                                if (oSheetName == "Corp alloc")
                                {
                                    if (i2 == 2)
                                        i2++;

                                    columnAmount.Add(oSheet.Cells[i3, cellCount].Value.ToString());
                                    updateTotalBudget("0", cellContent[i3 - 2].ToString(), columnObject[i2 + 2].ToString(), year);
                                    updatePeriods("0", cellContent[i3 - 2].ToString(), columnObject[i2 + 2].ToString(), year);

                                    counter++;
                                }
                                else if (oSheetName == "Dept alloc")
                                {
                                    columnAmount.Add(oSheet.Cells[i3, cellCount].Value.ToString());
                                    updateTotalBudget("0", cellContent[i3 - 2].ToString(), columnObject[i2].ToString(), year);
                                    updatePeriods("0", cellContent[i3 - 2].ToString(), columnObject[i2].ToString(), year);

                                    counter++;
                                }
                            }
                            else
                            {
                                if (oSheetName == "Corp alloc")
                                {
                                    if (i2 == 2)
                                        i2++;

                                    columnAmount.Add(oSheet.Cells[i3, cellCount].Value.ToString());
                                    updateTotalBudget(columnAmount[counter].ToString(), cellContent[i3 - 2].ToString(), columnObject[i2 + 2].ToString(), year);
                                    updatePeriods(oSheet.Cells[i3, cellCount].Value.ToString(), cellContent[i3 - 2].ToString(), columnObject[i2 + 2].ToString(), year);

                                    counter++;
                                }
                                else if (oSheetName == "Dept alloc")
                                {
                                    columnAmount.Add(oSheet.Cells[i3, cellCount].Value.ToString());
                                    updateTotalBudget(columnAmount[counter].ToString(), cellContent[i3 - 2].ToString(), columnObject[i2].ToString(), year);
                                    updatePeriods(oSheet.Cells[i3, cellCount].Value.ToString(), cellContent[i3 - 2].ToString(), columnObject[i2].ToString(), year);

                                    counter++;
                                }
                            }
                        }

                        cellCount = cellCount + 2;
                        columnAmount = new ArrayList();
                    }
                }
            }

            oWB.Close();
        }

        public void updateTotalBudget(string amount, string bunit, string objec, int year)
        {
            Oracle ora = new Oracle("select * from CRPDTA.F0902 WHERE GBFY = @year AND GBLT = @ba AND GBMCU = @bu AND GBOBJ = @obj");
            ora.AddParameter("@year", year);
            ora.AddParameter("@ba", "BA");
            ora.AddParameter("@bu", "       " + bunit);
            ora.AddParameter("@obj", objec + "  ");
            ora.Run();
            
            ora = new Oracle("UPDATE CRPDTA.F0902 SET GBBORG = @amount, GBBREQ = @amount2, GBBAPR = @amount3 WHERE GBFY = @year AND GBLT = @ba AND GBMCU = @bu AND GBOBJ = @obj");
            ora.AddParameter("@amount", amount + "00");
            ora.AddParameter("@amount2", amount + "00");
            ora.AddParameter("@amount3", amount + "00");
            ora.AddParameter("@year", year);
            ora.AddParameter("@ba", "BA");
            ora.AddParameter("@bu", "       " + bunit);
            ora.AddParameter("@obj", objec + "  ");
            ora.Run();
        }

        public void updatePeriods(string amount, string bunit, string objec, int year)
        {
            Oracle ora = new Oracle("SELECT GMBPC FROM CRPDTA.F0901 WHERE GMMCU = @bu AND GMOBJ = @obj");
            ora.AddParameter("@bu", "       " + bunit);
            ora.AddParameter("@obj", objec + "  ");
            DataTable dt = ora.Run();

            remainder = Convert.ToInt32((double.Parse(amount) * 100).ToString());

            if (dt.Rows.Count != 0)
            {
                if (dt.Rows[0][0].ToString() == "DNS")
                {
                    if (m != "")
                    {
                        Oracle oraora = new Oracle("UPDATE CRPDTA.F0901 SET GMBPC = @code WHERE GMBPC = @staticCode AND GMMCU = @bu AND GMOBJ = @obj");
                        oraora.AddParameter("@code", m);
                        oraora.AddParameter("@staticCode", "DNS");
                        oraora.AddParameter("@bu", "       " + bunit);
                        oraora.AddParameter("@obj", objec + "  ");
                        oraora.Run();
                    }
                }
                else
                    m = dt.Rows[0][0].ToString();

                for (int i = 0; i < rowCount; i++)
                {
                    if (m == distribCode[i].ToString())
                        break;
                    else
                        count = i + 1;
                }


                for (int i = 0; i < rowColumnCount; i++)
                {
                    percentagesInUse.Add(allPercent[count, i]);

                    if (Convert.ToInt32(percentagesInUse[i]) != 0)
                    {
                        periodsInUse.Add((Convert.ToInt32((double.Parse(amount) * 100).ToString()) * Convert.ToInt32(percentagesInUse[i])) / 100);
                        remainder = remainder - Convert.ToInt32(periodsInUse[i]);
                        periodCounter++;
                    }
                    else
                        periodsInUse.Add(0);
                }

                if (periodCounter != 0)
                    remains = remainder / periodCounter;

                for (int i = 0; i < rowColumnCount; i++)
                {
                    if (Convert.ToInt32(percentagesInUse[i]) != 0)
                    {
                        periodsInUse[i] = Convert.ToInt32(periodsInUse[i]) + remains;
                        remainder = remainder - remains;
                    }
                }

                for (int i = 0; i < rowColumnCount; i++)
                {
                    if (Convert.ToInt32(percentagesInUse[i]) != 0)
                    {
                        periodRemainder.Add((((Convert.ToInt32(periodsInUse[i]) + 50) / 100) * 100) - 100);
                        remainder = remainder + (Convert.ToInt32(periodsInUse[i]) - Convert.ToInt32(periodRemainder[i]));
                    }
                    else
                        periodRemainder.Add((((Convert.ToInt32(periodsInUse[i]) + 50) / 100) * 100));
                }

                while (remainder > 0)
                {
                    for (int i4 = 0; i4 < rowColumnCount; i4++)
                    {
                        if (i4 < periodCounter)
                        {
                            if (remainder != 0)
                            {
                                periodsInUse[i4] = Convert.ToInt32(periodRemainder[i4]) + 100;

                                remainder = remainder - 100;
                            }
                            else
                                periodsInUse[i4] = Convert.ToInt32(periodRemainder[i4]);
                        }
                    }

                }

                Oracle oraoraora = new Oracle("UPDATE CRPDTA.F0902 SET GBAN01 = @amount1, GBAN02 = @amount2, GBAN03 = @amount3, GBAN04 = @amount4, GBAN05 = @amount5, GBAN06 = @amount6, GBAN07 = @amount7, GBAN08 = @amount8, GBAN09 = @amount9, GBAN10 = @amount10, GBAN11 = @amount11, GBAN12 = @amount12, GBAN13 = @amount13, GBAN14 = @amount14 WHERE GBFY = @year AND GBLT = @ba AND GBMCU = @bu AND GBOBJ = @obj");

                for(int i = 0; i < periodsInUse.Count; i++)
                    oraoraora.AddParameter("@amount" + (i + 1), periodsInUse[i].ToString());
                
                oraoraora.AddParameter("@year", year);
                oraoraora.AddParameter("@ba", "BA");
                oraoraora.AddParameter("@bu", "       " + bunit);
                oraoraora.AddParameter("@obj", objec + "  ");
                oraoraora.Run();

                count = 0;
                periodCounter = 0;
                percentagesInUse = new ArrayList();
                periodsInUse = new ArrayList();
                periodRemainder = new ArrayList();
            }
        }

        public void calculatePercentage()
        {
            Oracle oraora = new Oracle("SELECT BPBPC FROM CRPDTA.F1401");
            rowCount = oraora.Run().Rows.Count;

            for (int i = 0; i < rowCount; i++)
            {
                distribCode.Add(oraora.Run().Rows[i][0].ToString());
                Oracle oraoraora = new Oracle("SELECT BPPG01, BPPG02, BPPG03, BPPG04, BPPG05, BPPG06, BPPG07, BPPG08, BPPG09, BPPG10, BPPG11, BPPG12, BPPG13, BPPG14 FROM CRPDTA.F1401 WHERE BPBPC = @bCode");
                oraoraora.AddParameter("@bCode", distribCode[i].ToString());
                rowColumnCount = oraoraora.Run().Columns.Count;

                for (int i2 = 0; i2 < rowColumnCount; i2++)
                {
                    sum = sum + Convert.ToInt32(oraoraora.Run().Rows[0][i2].ToString());
                }

                for (int i3 = 0; i3 < rowColumnCount; i3++)
                {
                    allPercent[i, i3] = (Convert.ToInt32(oraoraora.Run().Rows[0][i3].ToString()) * 100) / sum;
                }

                sum = 0;
            }
        }
    }
}
