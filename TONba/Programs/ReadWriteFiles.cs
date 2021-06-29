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
using System.IO.Compression;
using Color = System.Drawing.Color;

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
                        foldername += "^$" + dir;
                        
                        foreach (string subdir in subdirs)
                        {
                            filepaths += "^$" + subdir;
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

                    string[] splitpath = filepaths.Split(new string[] { "^$" }, StringSplitOptions.None);
                    string[] splitfoldername = foldername.Split(new string[] { "^$" }, StringSplitOptions.None);
                    worksheet.Cell("A1").Value = "ISUPLOADED";
                    worksheet.Cell("B1").Value = "ENTITY_TYPE";
                    worksheet.Cell("c1").Value = "B1_PER_ID1";
                    worksheet.Cell("D1").Value = "B1_PER_ID2";
                    worksheet.Cell("E1").Value = "B1_PER_ID3";
                    worksheet.Cell("F1").Value = "B1_ALT_ID";
                    worksheet.Cell("G1").Value = "ENTITY_ID";
                    worksheet.Cell("H1").Value = "DOC_GROUP";
                    worksheet.Cell("I1").Value = "DOC_TYPE";
                    worksheet.Cell("J1").Value = "FILEPATH";
                    worksheet.Cell("K1").Value = "DESCRIPTION";

                    for (int i = 1; i < splitpath.Length; i++)
                    {
                        string[] filesplit = splitpath[i].Split('\\');
                        worksheet.Cell("A" + (i + 1)).Value = "0";
                        worksheet.Cell("B" + (i + 1)).Value = "CAP";
                        worksheet.Cell("c" + (i + 1)).Value = "";
                        worksheet.Cell("D" + (i + 1)).Value = "";
                        worksheet.Cell("E" + (i + 1)).Value = "";
                        string[] pathsplit;
                        string strpath = "";

                        if (filepaths.Contains(" - "))
                        {
                            pathsplit = filesplit[filesplit.Length - 2].Split('-');
                            string[] path;

                            path = pathsplit[1].Split(',');

                            strpath = pathsplit[0] + "-" + path[0];
                        }
                        SQL sql = new SQL("use accelastage;select PERMITNUM from AATABLE_PERMIT_HISTORY where PERMITNUM like '%" + strpath.Trim() + "%'");
                        DataTable dt = sql.Run();
                        if (dt.Rows.Count > 0)
                        {
                            string str1 = dt.Rows[0]["PERMITNUM"].ToString().Remove(0, 1);
                            if (str1 == strpath.Trim())
                                worksheet.Cell("F" + (i + 1)).Value = dt.Rows[0]["PERMITNUM"].ToString();



                        }

                        worksheet.Cell("G" + (i + 1)).Value = "";
                        worksheet.Cell("H" + (i + 1)).Value = "";
                        worksheet.Cell("I" + (i + 1)).Value = "";

                        worksheet.Cell("J" + (i + 1)).Value = splitpath[i].Replace("T:\\DI Services\\Building\\Plans Examination\\00-APPLICATION DRAWINGS\\", "\\");
                        worksheet.Cell("K" + (i + 1)).Value = "";

                    }
                    worksheet.Cell("A1").Style.Alignment.WrapText = true;
                    worksheet.Cell("A1").Style.Fill.BackgroundColor = XLColor.PeachOrange;

                    worksheet.Cell("B1").Style.Alignment.WrapText = true;
                    worksheet.Cell("B1").Style.Fill.BackgroundColor = XLColor.PeachOrange;

                    worksheet.Cell("C1").Style.Fill.BackgroundColor = XLColor.PeachOrange;
                    worksheet.Cell("C1").Style.Alignment.WrapText = true;

                    worksheet.Cell("D1").Style.Fill.BackgroundColor = XLColor.PeachOrange;
                    worksheet.Cell("D1").Style.Alignment.WrapText = true;

                    worksheet.Cell("E1").Style.Fill.BackgroundColor = XLColor.PeachOrange;
                    worksheet.Cell("E1").Style.Alignment.WrapText = true;

                    worksheet.Cell("F1").Style.Fill.BackgroundColor = XLColor.PeachOrange;
                    worksheet.Cell("F1").Style.Alignment.WrapText = true;

                    worksheet.Cell("G1").Style.Fill.BackgroundColor = XLColor.PeachOrange;
                    worksheet.Cell("G1").Style.Alignment.WrapText = true;

                    worksheet.Cell("H1").Style.Fill.BackgroundColor = XLColor.PeachOrange;
                    worksheet.Cell("H1").Style.Alignment.WrapText = true;

                    worksheet.Cell("I1").Style.Fill.BackgroundColor = XLColor.PeachOrange;
                    worksheet.Cell("I1").Style.Alignment.WrapText = true;

                    worksheet.Cell("J1").Style.Fill.BackgroundColor = XLColor.PeachOrange;
                    worksheet.Cell("J1").Style.Alignment.WrapText = true;

                    worksheet.Cell("K1").Style.Fill.BackgroundColor = XLColor.PeachOrange;
                    worksheet.Cell("K1").Style.Alignment.WrapText = true;

                    worksheet.Columns("A").Width = 4;
                    worksheet.Columns("B").Width = 4;
                    worksheet.Columns("F").Width = 52;
                    worksheet.Columns("J").Width = 120;
                    workbook.SaveAs(@"C:\Users\" + Environment.UserName + @"\00-APPLICATION DRAWINGS.xlsx");
                }
                string[] dirs1 = Directory.GetDirectories(@"T:\DI Services\Building\Plans Examination\1- Issued Permits\");
                string filepaths1 = "";
                string foldername1 = "";
                string subfoldername = "";
                foreach (string dir1 in dirs1)
                {
                    try
                    {
                        string[] subdirectoryEntries = Directory.GetDirectories(dir1);
                        foreach (string Subfolder in subdirectoryEntries)
                        {
                            if (Directory.GetDirectories(Subfolder).ToString() != "")
                            {
                                string[] subdirectoryEntries2 = Directory.GetDirectories(Subfolder);
                                foreach (string Subfolder2 in subdirectoryEntries2)
                                {

                                    // Only get files that begin with the letter "pdf".
                                    string[] subdirs1 = Directory.GetFiles(Subfolder2, "*pdf");
                                    foldername1 += "^$" + Subfolder2;

                                    foreach (string subdir1 in subdirs1)
                                    {
                                        filepaths1 += "^$" + subdir1;
                                    }
                                }
                            }
                           
                                // Only get files that begin with the letter "pdf".
                                string[] subdirs2 = Directory.GetFiles(Subfolder, "*pdf");
                                foldername1 += "^$" + Subfolder;

                                //MessageBox.Show(foldername1);
                                foreach (string subdir1 in subdirs2)
                                {
                                   // MessageBox.Show(filepaths1);
                                    filepaths1 += "^$" + subdir1;
                                }
                               
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
                    string[] splitpath1 = filepaths1.Split(new string[] { "^$" }, StringSplitOptions.None);
                    string[] splitfoldername1 = foldername1.Split(new string[] { "^$" }, StringSplitOptions.None);
                    worksheet1.Cell("A1").Value = "ISUPLOADED";
                    worksheet1.Cell("B1").Value = "ENTITY_TYPE";
                    worksheet1.Cell("c1").Value = "B1_PER_ID1";
                    worksheet1.Cell("D1").Value = "B1_PER_ID2";
                    worksheet1.Cell("E1").Value = "B1_PER_ID3";
                    worksheet1.Cell("F1").Value = "B1_ALT_ID";
                    worksheet1.Cell("G1").Value = "ENTITY_ID";
                    worksheet1.Cell("H1").Value = "DOC_GROUP";
                    worksheet1.Cell("I1").Value = "DOC_TYPE";
                    worksheet1.Cell("J1").Value = "FILEPATH";
                    worksheet1.Cell("K1").Value = "DESCRIPTION";
                    for (int i = 1; i < splitpath1.Length; i++)
                    {
                        string[] filesplit1 = splitpath1[i].Split('\\');
                        //T:\DI Services\Building\Plans Examination\00-APPLICATION DRAWINGS

                        worksheet1.Cell("A" + (i + 1)).Value = "0";
                        worksheet1.Cell("B" + (i + 1)).Value = "CAP";
                        worksheet1.Cell("c" + (i + 1)).Value = "";
                        worksheet1.Cell("D" + (i + 1)).Value = "";
                        worksheet1.Cell("E" + (i + 1)).Value = "";
                        string[] pathsplit1;
                        string strpath1 = "";
                        if (filepaths1.Contains(" - "))
                        {
                            pathsplit1 = filesplit1[filesplit1.Length - 2].Split('-');
                            string[] path1;
                            try
                            {
                                if (pathsplit1[1].Contains(","))
                                {
                                    path1 = pathsplit1[1].Split(',');
                                    strpath1 = pathsplit1[0] + "-" + path1[0];

                                }
                                else
                                {
                                    path1 = pathsplit1[1].Split(new string[] { "." }, StringSplitOptions.None);
                                    strpath1 = pathsplit1[0] + "-" + path1[0];
                                }
                                if (strpath1.Contains("to"))
                                {
                                    path1 = strpath1.Split(new string[] { "to" }, StringSplitOptions.None);
                                    strpath1 = path1[0];
                                }
                                else
                                {

                                    path1 = strpath1.Split(new string[] { "TO" }, StringSplitOptions.None);
                                    strpath1 = path1[0];
                                }
                               
                            }
                            catch (Exception e)
                            {

                            }
                        }
                        SQL sql1 = new SQL("use accelastage;select PERMITNUM from AATABLE_PERMIT_HISTORY where PERMITNUM like '%" + strpath1.Trim() + "%'");
                        DataTable dt1 = sql1.Run();
                        if (dt1.Rows.Count > 0)
                        {
                            string str11 = dt1.Rows[0]["PERMITNUM"].ToString().Remove(0, 1);
                            if (str11 == strpath1.Trim())
                                worksheet1.Cell("F" + (i + 1)).Value = dt1.Rows[0]["PERMITNUM"].ToString();
                           
                        }
                        //worksheet1.Cell("F" + (i + 1)).Value ="";
                        ///  worksheet1.Cell("F" + (i + 1)).Value = filesplit1[filesplit1.Length - 2];
                        worksheet1.Cell("G" + (i + 1)).Value = "";
                        worksheet1.Cell("H" + (i + 1)).Value = "";
                        worksheet1.Cell("I" + (i + 1)).Value = "";
                        worksheet1.Cell("J" + (i + 1)).Value = splitpath1[i].Replace("T:\\DI Services\\Building\\Plans Examination\\1- Issued Permits\\", "\\");

                        worksheet1.Cell("K" + (i + 1)).Value = "";

                    }

                    worksheet1.Cell("A1").Style.Alignment.WrapText = true;
                    worksheet1.Cell("A1").Style.Fill.BackgroundColor = XLColor.PeachOrange;

                    worksheet1.Cell("B1").Style.Alignment.WrapText = true;
                    worksheet1.Cell("B1").Style.Fill.BackgroundColor = XLColor.PeachOrange;

                    worksheet1.Cell("C1").Style.Fill.BackgroundColor = XLColor.PeachOrange;
                    worksheet1.Cell("C1").Style.Alignment.WrapText = true;

                    worksheet1.Cell("D1").Style.Fill.BackgroundColor = XLColor.PeachOrange;
                    worksheet1.Cell("D1").Style.Alignment.WrapText = true;

                    worksheet1.Cell("E1").Style.Fill.BackgroundColor = XLColor.PeachOrange;
                    worksheet1.Cell("E1").Style.Alignment.WrapText = true;

                    worksheet1.Cell("F1").Style.Fill.BackgroundColor = XLColor.PeachOrange;
                    worksheet1.Cell("F1").Style.Alignment.WrapText = true;

                    worksheet1.Cell("G1").Style.Fill.BackgroundColor = XLColor.PeachOrange;
                    worksheet1.Cell("G1").Style.Alignment.WrapText = true;

                    worksheet1.Cell("H1").Style.Fill.BackgroundColor = XLColor.PeachOrange;
                    worksheet1.Cell("H1").Style.Alignment.WrapText = true;

                    worksheet1.Cell("I1").Style.Fill.BackgroundColor = XLColor.PeachOrange;
                    worksheet1.Cell("I1").Style.Alignment.WrapText = true;

                    worksheet1.Cell("J1").Style.Fill.BackgroundColor = XLColor.PeachOrange;
                    worksheet1.Cell("J1").Style.Alignment.WrapText = true;

                    worksheet1.Cell("K1").Style.Fill.BackgroundColor = XLColor.PeachOrange;
                    worksheet1.Cell("K1").Style.Alignment.WrapText = true;
                    worksheet1.Columns("A").Width = 4;
                    worksheet1.Columns("B").Width = 4;
                    worksheet1.Columns("F").Width = 52;
                    worksheet1.Columns("J").Width = 120;
                    workbook1.SaveAs(@"C:\Users\" + Environment.UserName + @"\1- Issued Permits.xlsx");
                    MessageBox.Show(@"Your file is saved in C:\Users\" + Environment.UserName);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }
       
    }
}
