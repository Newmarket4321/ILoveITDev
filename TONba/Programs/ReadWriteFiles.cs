using ClosedXML.Excel;
using Excel = Microsoft.Office.Interop.Excel;
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
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;

namespace I_IT
{
    class ReadWriteFiles
    {
        static ReadWriteFiles()
        {
           
            try
            {
                string[] dirs = Directory.GetDirectories(@"T:\DI Services\Building\Plans Examination\00-APPLICATION DRAWINGS\");
                string filepaths = "";
                string foldername = "";
                foreach (string dir in dirs)
                {
                    try
                    {
                        // Only get files that begin with the letter "pdf".
                        string[] subdirs = Directory.GetFiles(dir, "*pdf");
                        foldername += dir + "^$";
                        
                        foreach (string subdir in subdirs)
                        {
                            filepaths += subdir + "^$";
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("The process failed: {0}", e.ToString());
                    }
                }
                
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Sheet1");

                    string[] splitpath = filepaths.Split(new string[] { "^$" }, StringSplitOptions.RemoveEmptyEntries);
                    string[] splitfoldername = foldername.Split(new string[] { "^$" }, StringSplitOptions.RemoveEmptyEntries);
                        //worksheet.Cell("A1").Value = "ISUPLOADED";
                        //worksheet.Cell("B1").Value = "ENTITY_TYPE";
                        //worksheet.Cell("c1").Value = "B1_PER_ID1";
                        //worksheet.Cell("D1").Value = "B1_PER_ID2";
                        //worksheet.Cell("E1").Value = "B1_PER_ID3";
                        //worksheet.Cell("F1").Value = "B1_ALT_ID";
                        //worksheet.Cell("G1").Value = "ENTITY_ID";
                        //worksheet.Cell("H1").Value = "DOC_GROUP";
                        //worksheet.Cell("I1").Value = "DOC_TYPE";
                        //worksheet.Cell("J1").Value = "FILEPATH";
                        //worksheet.Cell("K1").Value = "DESCRIPTION";
                    
                      for (int i= 0 ; i < splitpath.Length; i++)
                     {
                        string[] filesplit = splitpath[i].Split('\\');

                        worksheet.Cell("A" + (i + 1)).Value = "0";
                            worksheet.Cell("B" + (i + 1)).Value = "CAP";
                            worksheet.Cell("c" + (i + 1)).Value = "";
                            worksheet.Cell("D" + (i + 1)).Value = "";
                            worksheet.Cell("E" + (i + 1)).Value = "";
                            worksheet.Cell("F" + (i + 1)).Value = filesplit[filesplit.Length - 2];
                            worksheet.Cell("G" + (i + 1)).Value = "";
                            worksheet.Cell("H" + (i + 1)).Value = "";
                            worksheet.Cell("I" + (i + 1)).Value = "";
                            worksheet.Cell("J" + (i + 1)).Value = splitpath[i];
                            worksheet.Cell("K" + (i + 1)).Value = "";

                      }

                    workbook.SaveAs(@"C:\Users\"+ Environment.UserName + @"\00-APPLICATION DRAWINGS.xlsx");
                }
                string[] dirs1 = Directory.GetDirectories(@"T:\DI Services\Building\Plans Examination\1- Issued Permits\");
                string filepaths1 = "";
                string foldername1 = "";
                foreach (string dir1 in dirs1)
                {
                    try
                    {
                        // Only get files that begin with the letter "pdf".
                        string[] subdirs1 = Directory.GetFiles(dir1, "*pdf");
                        foldername1 += dir1 + "^$";

                        foreach (string subdir1 in subdirs1)
                        {
                            filepaths1 += subdir1 + "^$";
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("The process failed: {0}", e.ToString());
                    }
                }

                using (var workbook1 = new XLWorkbook())
                {
                    var worksheet1 = workbook1.Worksheets.Add("Sheet1");
                    
                    string[] splitpath1 = filepaths1.Split(new string[] { "^$" }, StringSplitOptions.RemoveEmptyEntries);
                    string[] splitfoldername1 = foldername1.Split(new string[] { "^$" }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < splitpath1.Length; i++)
                    {
                        string[] filesplit1 = splitpath1[i].Split('\\');

                        worksheet1.Cell("A" + (i + 1)).Value = "0";
                        worksheet1.Cell("B" + (i + 1)).Value = "CAP";
                        worksheet1.Cell("c" + (i + 1)).Value = "";
                        worksheet1.Cell("D" + (i + 1)).Value = "";
                        worksheet1.Cell("E" + (i + 1)).Value = "";
                        worksheet1.Cell("F" + (i + 1)).Value = filesplit1[filesplit1.Length - 2];
                        worksheet1.Cell("G" + (i + 1)).Value = "";
                        worksheet1.Cell("H" + (i + 1)).Value = "";
                        worksheet1.Cell("I" + (i + 1)).Value = "";
                        worksheet1.Cell("J" + (i + 1)).Value = splitpath1[i];
                        worksheet1.Cell("K" + (i + 1)).Value = "";

                    }

                    workbook1.SaveAs(@"C:\Users\" + Environment.UserName + @"\1- Issued Permits.xlsx");
                    MessageBox.Show(@"Your file is saved in C:\Users\"+Environment.UserName);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }
       
    }
}
