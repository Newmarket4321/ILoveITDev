using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class InventoryLoadTest : Form
    {
        string environment = "PY";
        //EAC
        string schema = "";
        string controlSchema = "";

        public InventoryLoadTest()
        {
            InitializeComponent();
            label4.Text = environment;

            if (environment == "PD")
            {
                schema = "PRODDTA";
                controlSchema = "PRODCTL";
            }
            else if (environment == "PY")
            {
                schema = "CRPDTA";
                controlSchema = "CRPCTL";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Spreadsheet file = new Spreadsheet(textBox1.Text);

            bool success;
            string branchPlant = Core.getString("What is the branch plant?", out success);

            if (!success)
                return;

            while (branchPlant.Length < 12)
                branchPlant = ' ' + branchPlant;

            int RMAX = 2;

            while (file.Cells()[RMAX + 1, 1].Text != "")
                RMAX++;

            Oracle ora = new Oracle(@"
select NNN001, NNN002

from " + controlSchema + @".F0002

where NNSY = @VAR
");
            ora.AddParameter("@VAR", "47  ");
            DataTable dt = ora.Run();

            int transactionNumber = int.Parse(dt.Rows[0]["NNN001"].ToString());
            int batchNumber = int.Parse(dt.Rows[0]["NNN002"].ToString());
            string userID = "JDE";

            ora = new Oracle(@"
update " + controlSchema + @".F0002

set NNN001 = NNN001 + 1,
NNN002 = NNN002 + 1

where NNSY = @VAR");
            ora.AddParameter("@VAR", "47  ");
            ora.Run();

            //////

            Oracle.Run("delete from " + schema + @".F4101Z1");
            Oracle.Run("delete from " + schema + @".F4105Z1");
            Oracle.Run("delete from " + schema + @".F4104 where IVPID = @IVPID and IVUPMJ = @IVUPMJ", "IHeartIT", Core.dateToJDE(DateTime.Today));

            string variables4101 = "@SZEDUS, @SZEDBT, @SZEDTN, @SZTNAC, @SZITM, @SZLITM, @SZAITM, @SZDSC1, @SZDSC2, @SZSRTX, @SZGLPT, @SZSTKT, @SZEDLN, @SZTYTN, @SZDRIN, @SZUOM1, @SZUOM2, @SZUOM3, @SZLOCN, @SZROPI, @SZROQI, @SZRQMX, @SZRQMN, @SZSRP9, @SZURAB, " + /*@SZDUAL, */ "@SZUPC, @SZBPFG";
            string columns4101 = variables4101.Replace("@", "");

            string variables4105 = "@SZEDUS, @SZEDBT, @SZEDTN, @SZEDLN, @SZITM, @SZLITM, @SZAITM, @SZMCU, @SZLOCN, @SZLOTN, @SZLOTG, @SZLEDG, @SZUNCS, @SZCSPO, @SZCSIN, @SZTYTN, @SZEDSP, @SZDRIN, @SZTNAC";
            string columns4105 = variables4105.Replace("@", "");

            string variables4104 = "@IVAN8, @IVXRT, @IVITM, @IVEXDJ, @IVEFTJ, @IVMCU, @IVCITM, @IVDSC1, @IVDSC2, @IVALN, @IVLITM, @IVAITM, @IVURCD, @IVURDT, @IVURAT, @IVURAB, @IVURRF, @IVUSER, @IVPID, @IVJOBN, @IVUPMJ, @IVTDAY, @IVRATO, @IVAPSP, @IVIDEM, @VAPSS, @IVCIRV, @IVADIND, @IVBPIND, @IVCARDNO";
            string columns4104 = variables4105.Replace("@", "");

            int[] itemNumber = new int[RMAX + 1];

            for (int r = 2; r <= RMAX; r++)
            {
                progressBar1.Maximum = RMAX;
                progressBar1.Value = r;
                label2.Text = r + " / " + RMAX;
                
                string description = file.Cells()[r, 8].Text;
                description = description.Substring(0, Math.Min(30, description.Length)).ToUpper();

                string description2 = file.Cells()[r, 7].Text;
                description2 = description2.Substring(0, Math.Min(30, description2.Length)).ToUpper();

                string description3 = file.Cells()[r, 11].Text;
                description3 = description3.Substring(0, Math.Min(30, description3.Length)).ToUpper();

                string uom = file.Cells()[r, 22].Text.Trim().ToUpper();

                if (uom.Contains("BOX"))
                    uom = "BX";

                if (uom.Contains("CASE"))
                    uom = "CA";

                if (uom.Contains("CASES"))
                    uom = "CA";

                if (uom.Contains("PKG"))
                    uom = "PK";

                if (uom.Contains("TUB"))
                    uom = "TU";

                if (uom.Contains("REAM"))
                    uom = "RM";

                if (uom.Contains("ROLL"))
                    uom = "RL";

                if (uom.Contains("BOTTLE"))
                    uom = "BT";

                /////////

                string uomp = file.Cells()[r, 23].Text.Trim().ToUpper();

                if (uomp.Contains("BOX"))
                    uomp = "BX";

                if (uomp.Contains("CASE"))
                    uomp = "CA";

                if (uomp.Contains("CASES"))
                    uomp = "CA";

                if (uomp.Contains("PKG"))
                    uomp = "PK";

                if (uomp.Contains("TUB"))
                    uomp = "TU";

                if (uomp.Contains("REAM"))
                    uomp = "RM";

                if (uomp.Contains("ROLL"))
                    uomp = "RL";

                if (uomp.Contains("BOTTLE"))
                    uomp = "BT";

                //if (uomp.Trim() == "")
                //    uomp = uom;

                string qpuomp = file.Cells()[r, 24].Text;

                string aitm = file.Cells()[r, 3].Text;
                aitm = aitm.Substring(0, Math.Min(25, aitm.Length));

                string location = file.Cells()[r, 13].Text;

                string vendorNumber = file.Cells()[r, 2].Text;

                double reorderQty = 0, reorderPoint = 0, reorderMin = 0, reorderMax = 0;

                try
                {
                    reorderQty = (int)((double.Parse(file.Cells()[r, 25].Text) * 100));
                }
                catch
                {

                }

                try
                {
                    reorderPoint = (int)((double.Parse(file.Cells()[r, 26].Text) * 100));
                }
                catch
                {

                }

                try
                {
                    reorderMin = (int)((double.Parse(file.Cells()[r, 27].Text) * 100));
                }
                catch
                {

                }

                try
                {
                    reorderMax = (int)((double.Parse(file.Cells()[r, 28].Text) * 100));
                }
                catch
                {
                    
                }

                itemNumber[r] = int.Parse(Oracle.Run("select max(IMITM) as max from " + schema + @".F4101").Rows[0]["max"].ToString()) + (r - 1);
                file.Cells()[r, 4] = itemNumber[r];
                
                ora = new Oracle(@"insert into " + schema + @".F4101Z1 (" + columns4101 + ") values (" + variables4101 + ")");
                ora.AddParameter("@SZEDUS", userID);
                ora.AddParameter("@SZEDBT", batchNumber);
                ora.AddParameter("@SZEDTN", transactionNumber);
                ora.AddParameter("@SZTNAC", "A");
                ora.AddParameter("@SZITM", itemNumber[r]);
                ora.AddParameter("@SZLITM", itemNumber[r]);
                ora.AddParameter("@SZAITM", itemNumber[r]);
                ora.AddParameter("@SZDSC1", description);
                ora.AddParameter("@SZDSC2", description2);
                ora.AddParameter("@SZSRTX", description3);
                ora.AddParameter("@SZGLPT", "IN10");
                ora.AddParameter("@SZSTKT", "S");
                ora.AddParameter("@SZEDLN", (r - 1) * 1000);
                ora.AddParameter("@SZTYTN", "JDEITEM");
                ora.AddParameter("@SZDRIN", "1");
                ora.AddParameter("@SZUOM1", uom);
                ora.AddParameter("@SZUOM2", uomp != "" ? uomp : uom != "" ? uom : "");
                ora.AddParameter("@SZUOM3", uomp);
                ora.AddParameter("@SZLOCN", location);
                ora.AddParameter("@SZROPI", reorderPoint);
                ora.AddParameter("@SZROQI", reorderQty);
                ora.AddParameter("@SZRQMX", reorderMax);
                ora.AddParameter("@SZRQMN", reorderMin);
                ora.AddParameter("@SZSRP9", "MSQRES");
                ora.AddParameter("@SZURAB", vendorNumber);
                //ora.AddParameter("@SZDUAL", uomp != "" ? "1" : " ");
                ora.AddParameter("@SZUPC", qpuomp);
                ora.AddParameter("@SZBPFG", "P");
                ora.Run();
            }

            MessageBox.Show("F4101Z1 done. Go to the right environment, bv, R4101Z1I, ZJDE1. When that is done, press OK to proceed.");
            
            Oracle.Run("update " + schema + @".F4101Z1 set SZMCU = @BRANCH, SZITBR = 2, SZEDSP = null where SZEDBT = @SZEDBT", branchPlant, batchNumber);
            MessageBox.Show("F4101Z1 updated for F4102. Go rerun the same process again. When that is done, press OK to proceed.");


            string variables41021 = "@LIITM, @LIMCU, @LILOCN, @LILOTN, @LIPBIN, @LIGLPT, @LILOTS, @LILRCJ, @LIPQOH, @LIPBCK, @LIPREQ, @LIQWBO, @LIOT1P, @LIOT2P, @LIOT1A, @LIHCOM, @LIPCOM, @LIFCOM, @LIFUN1, @LIQOWO, @LIQTTR, @LIQTIN, @LIQONL, @LIQTRI, @LIQTRO, @LINCDJ, @LIQTY1, @LIQTY2, @LIURAB, @LIURRF, @LIURAT, @LIURCD, @LIJOBN, @LIPID, @LIUPMJ, @LIUSER, @LITDAY, @LIURDT, @LIQTO1, @LIQTO2, @LIHCMS, @LIPJCM, @LIPJDM, @LISCMS, @LISIBW, @LISOBW, @LISQOH, @LISQWO, @LISREQ, @LISWHC, @LISWSC, @LICHDF, @LIWPDF, @LICFGSID";
            string columns41021 = variables41021.Replace("@", "");
            
            for (int r = 2; r <= RMAX; r++)
            {
                progressBar1.Maximum = RMAX;
                progressBar1.Value = r;
                label2.Text = r + " / " + RMAX;

                string location2 = file.Cells()[r, 14].Text;
                string location3 = file.Cells()[r, 15].Text;

                if (location2.Trim() != "")
                {
                    ora = new Oracle(@"insert into " + schema + @".F41021 (" + columns41021 + @") values (" + variables41021 + @")");
                    ora.AddParameter("@LIITM", itemNumber[r]);
                    ora.AddParameter("@LIMCU", "        1001");
                    ora.AddParameter("@LILOCN", location2);
                    ora.AddParameter("@LILOTN", "                              ");
                    ora.AddParameter("@LIPBIN", "S");
                    ora.AddParameter("@LIGLPT", "IN10");
                    ora.AddParameter("@LILOTS", " ");
                    ora.AddParameter("@LILRCJ", 0); //Last receipt date
                    ora.AddParameter("@LIPQOH", 0); //Primary quantity on hand
                    ora.AddParameter("@LIPBCK", 0); //Quantity on backorder
                    ora.AddParameter("@LIPREQ", 0); //Quantity on purchase order
                    ora.AddParameter("@LIQWBO", 0);
                    ora.AddParameter("@LIOT1P", 0);
                    ora.AddParameter("@LIOT2P", 0);
                    ora.AddParameter("@LIOT1A", 0);
                    ora.AddParameter("@LIHCOM", 0);
                    ora.AddParameter("@LIPCOM", 0);
                    ora.AddParameter("@LIFCOM", 0);
                    ora.AddParameter("@LIFUN1", 0);
                    ora.AddParameter("@LIQOWO", 0);
                    ora.AddParameter("@LIQTTR", 0);
                    ora.AddParameter("@LIQTIN", 0);
                    ora.AddParameter("@LIQONL", 0);
                    ora.AddParameter("@LIQTRI", 0);
                    ora.AddParameter("@LIQTRO", 0);
                    ora.AddParameter("@LINCDJ", 0);
                    ora.AddParameter("@LIQTY1", 0);
                    ora.AddParameter("@LIQTY2", 0);
                    ora.AddParameter("@LIURAB", 0);
                    ora.AddParameter("@LIURRF", "               ");
                    ora.AddParameter("@LIURAT", 0);
                    ora.AddParameter("@LIURCD", "  ");
                    ora.AddParameter("@LIJOBN", "E1        ");
                    ora.AddParameter("@LIPID", "IHeartIT  ");
                    ora.AddParameter("@LIUPMJ", Core.dateToJDE(DateTime.Now));
                    ora.AddParameter("@LIUSER", "JDE       ");
                    ora.AddParameter("@LITDAY", Core.timeToJDE(DateTime.Now));
                    ora.AddParameter("@LIURDT", 0);
                    ora.AddParameter("@LIQTO1", 0);
                    ora.AddParameter("@LIQTO2", 0);
                    ora.AddParameter("@LIHCMS", 0);
                    ora.AddParameter("@LIPJCM", 0);
                    ora.AddParameter("@LIPJDM", 0);
                    ora.AddParameter("@LISCMS", 0);
                    ora.AddParameter("@LISIBW", 0);
                    ora.AddParameter("@LISOBW", 0);
                    ora.AddParameter("@LISQOH", 0); //Secondary quantity on hand
                    ora.AddParameter("@LISQWO", 0);
                    ora.AddParameter("@LISREQ", 0);
                    ora.AddParameter("@LISWHC", 0);
                    ora.AddParameter("@LISWSC", 0);
                    ora.AddParameter("@LICHDF", " ");
                    ora.AddParameter("@LIWPDF", " ");
                    ora.AddParameter("@LICFGSID", "                                ");
                    ora.Run();
                }

                if (location3.Trim() != "")
                {
                    ora = new Oracle(@"insert into " + schema + @".F41021 (" + columns41021 + @") values (" + variables41021 + @")");
                    ora.AddParameter("@LIITM", itemNumber[r]);
                    ora.AddParameter("@LIMCU", "        1001");
                    ora.AddParameter("@LILOCN", location3);
                    ora.AddParameter("@LILOTN", "                              ");
                    ora.AddParameter("@LIPBIN", "S");
                    ora.AddParameter("@LIGLPT", "IN10");
                    ora.AddParameter("@LILOTS", " ");
                    ora.AddParameter("@LILRCJ", 0); //Last receipt date
                    ora.AddParameter("@LIPQOH", 0); //Primary quantity on hand
                    ora.AddParameter("@LIPBCK", 0); //Quantity on backorder
                    ora.AddParameter("@LIPREQ", 0); //Quantity on purchase order
                    ora.AddParameter("@LIQWBO", 0);
                    ora.AddParameter("@LIOT1P", 0);
                    ora.AddParameter("@LIOT2P", 0);
                    ora.AddParameter("@LIOT1A", 0);
                    ora.AddParameter("@LIHCOM", 0);
                    ora.AddParameter("@LIPCOM", 0);
                    ora.AddParameter("@LIFCOM", 0);
                    ora.AddParameter("@LIFUN1", 0);
                    ora.AddParameter("@LIQOWO", 0);
                    ora.AddParameter("@LIQTTR", 0);
                    ora.AddParameter("@LIQTIN", 0);
                    ora.AddParameter("@LIQONL", 0);
                    ora.AddParameter("@LIQTRI", 0);
                    ora.AddParameter("@LIQTRO", 0);
                    ora.AddParameter("@LINCDJ", 0);
                    ora.AddParameter("@LIQTY1", 0);
                    ora.AddParameter("@LIQTY2", 0);
                    ora.AddParameter("@LIURAB", 0);
                    ora.AddParameter("@LIURRF", "               ");
                    ora.AddParameter("@LIURAT", 0);
                    ora.AddParameter("@LIURCD", "  ");
                    ora.AddParameter("@LIJOBN", "E1        ");
                    ora.AddParameter("@LIPID", "IHeartIT  ");
                    ora.AddParameter("@LIUPMJ", Core.dateToJDE(DateTime.Now));
                    ora.AddParameter("@LIUSER", "JDE       ");
                    ora.AddParameter("@LITDAY", Core.timeToJDE(DateTime.Now));
                    ora.AddParameter("@LIURDT", 0);
                    ora.AddParameter("@LIQTO1", 0);
                    ora.AddParameter("@LIQTO2", 0);
                    ora.AddParameter("@LIHCMS", 0);
                    ora.AddParameter("@LIPJCM", 0);
                    ora.AddParameter("@LIPJDM", 0);
                    ora.AddParameter("@LISCMS", 0);
                    ora.AddParameter("@LISIBW", 0);
                    ora.AddParameter("@LISOBW", 0);
                    ora.AddParameter("@LISQOH", 0); //Secondary quantity on hand
                    ora.AddParameter("@LISQWO", 0);
                    ora.AddParameter("@LISREQ", 0);
                    ora.AddParameter("@LISWHC", 0);
                    ora.AddParameter("@LISWSC", 0);
                    ora.AddParameter("@LICHDF", " ");
                    ora.AddParameter("@LIWPDF", " ");
                    ora.AddParameter("@LICFGSID", "                                ");
                    ora.Run();
                }
            }

            for (int r = 2; r <= RMAX; r++)
            {
                progressBar1.Maximum = RMAX;
                progressBar1.Value = r;
                label2.Text = r + " / " + RMAX;

                string vendorNumber = file.Cells()[r, 2].Text;
                if (vendorNumber == "")
                    vendorNumber = "0";

                string supplierItemNumber = file.Cells()[r, 3].Text;

                string desc1 = file.Cells()[r, 8].Text;
                string desc2 = file.Cells()[r, 7].Text;

                string search = file.Cells()[r, 11].Text.ToUpper();

                ora = new Oracle(@"insert into " + schema + @".F4104 values (" + variables4104 + @")");
                ora.AddParameter("@IVAN8", vendorNumber);
                ora.AddParameter("@IVXRT", "VN");
                ora.AddParameter("@IVITM", itemNumber[r]);
                ora.AddParameter("@IVEXDJ", int.Parse(Core.dateToJDE(new DateTime(2099, 12, 31))));
                ora.AddParameter("@IVEFTJ", int.Parse(Core.dateToJDE(DateTime.Today)));
                ora.AddParameter("@IVMCU", branchPlant);
                ora.AddParameter("@IVCITM", supplierItemNumber);
                ora.AddParameter("@IVDSC1", desc1.Substring(0, Math.Min(desc1.Length, 30)));
                ora.AddParameter("@IVDSC2", desc2.Substring(0, Math.Min(desc2.Length, 30)));
                ora.AddParameter("@IVALN", search.Substring(0, Math.Min(search.Length, 30)));
                ora.AddParameter("@IVLITM", itemNumber[r].ToString());
                ora.AddParameter("@IVAITM", itemNumber[r].ToString());
                ora.AddParameter("@IVURCD", "");
                ora.AddParameter("@IVURDT", 0);
                ora.AddParameter("@IVURAT", 0);
                ora.AddParameter("@IVURAB", 0);
                ora.AddParameter("@IVURRF", "");
                ora.AddParameter("@IVUSER", "MGS");
                ora.AddParameter("@IVPID", "IHeartIT");
                ora.AddParameter("@IVJOBN", Environment.MachineName.Substring(0, Math.Min(Environment.MachineName.Length, 10)));
                ora.AddParameter("@IVUPMJ", int.Parse(Core.dateToJDE(DateTime.Today)));
                ora.AddParameter("@IVTDAY", Core.timeToJDE(DateTime.Now));
                ora.AddParameter("@IVRATO", 0);
                ora.AddParameter("@IVAPSP", 0);
                ora.AddParameter("@IVIDEM", "");
                ora.AddParameter("@VAPSS", "");
                ora.AddParameter("@IVCIRV", "                    ");
                ora.AddParameter("@IVADIND", "");
                ora.AddParameter("@IVBPIND", "");
                ora.AddParameter("@IVCARDNO", "");
                ora.Run();
            }

            //41002
            string variables41002 = "@UMMCU, @UMITM, @UMUM, @UMRUM, @UMUSTR, @UMCONV, @UMCNV1, @UMUSER, @UMPID, @UMJOBN, @UMUPMJ, @UMTDAY, @UMEXPO, @UMEXSO, @UMPUPC, @UMSEPC";
            string columns41002 = variables41002.Replace("@", "");

            for (int r = 2; r <= RMAX; r++)
            {
                progressBar1.Maximum = RMAX;
                progressBar1.Value = r;
                label2.Text = r + " / " + RMAX;

                string vendorNumber = file.Cells()[r, 2].Text;

                string uom = file.Cells()[r, 22].Text.Trim().ToUpper();

                if (uom.Contains("BOX"))
                    uom = "BX";

                if (uom.Contains("CASE"))
                    uom = "CA";

                if (uom.Contains("CASES"))
                    uom = "CA";

                if (uom.Contains("PKG"))
                    uom = "PK";

                if (uom.Contains("TUB"))
                    uom = "TU";

                if (uom.Contains("REAM"))
                    uom = "RM";

                if (uom.Contains("ROLL"))
                    uom = "RL";

                if (uom.Contains("BOTTLE"))
                    uom = "BT";

                /////////

                string uomp = file.Cells()[r, 23].Text.Trim().ToUpper();

                if (uomp.Contains("BOX"))
                    uomp = "BX";

                if (uomp.Contains("CASE"))
                    uomp = "CA";

                if (uomp.Contains("CASES"))
                    uomp = "CA";

                if (uomp.Contains("PKG"))
                    uomp = "PK";

                if (uomp.Contains("TUB"))
                    uomp = "TU";

                if (uomp.Contains("REAM"))
                    uomp = "RM";

                if (uomp.Contains("ROLL"))
                    uomp = "RL";

                if (uomp.Contains("BOTTLE"))
                    uomp = "BT";

                //if (uomp.Trim() == "")
                //    uomp = uom;

                string qpuomp = file.Cells()[r, 24].Text;

                if (uomp != "")
                {
                    ora = new Oracle(@"insert into " + schema + @".F41002 (" + columns41002 + @") values (" + variables41002 + @")");
                    ora.AddParameter("@UMMCU", "            ");
                    ora.AddParameter("@UMITM", itemNumber[r]);
                    ora.AddParameter("@UMUM", uom);
                    ora.AddParameter("@UMRUM", uomp);
                    ora.AddParameter("@UMUSTR", " ");
                    ora.AddParameter("@UMCONV", (long.Parse(qpuomp) * 10000000).ToString());
                    ora.AddParameter("@UMCNV1", 10000000);
                    ora.AddParameter("@UMUSER", "MSQRES");
                    ora.AddParameter("@UMPID", "IHeartIT");
                    ora.AddParameter("@UMJOBN", Environment.MachineName.Substring(0, Math.Min(10, Environment.MachineName.Length)));
                    ora.AddParameter("@UMUPMJ", Core.dateToJDE(DateTime.Today));
                    ora.AddParameter("@UMTDAY", Core.timeToJDE(DateTime.Now));
                    ora.AddParameter("@UMEXPO", " ");
                    ora.AddParameter("@UMEXSO", " ");
                    ora.AddParameter("@UMPUPC", 0);
                    ora.AddParameter("@UMSEPC", 0);
                    ora.Run();
                }
            }

            //4105
            int ln = 1000;

            for (int r = 2; r <= RMAX; r++)
            {
                progressBar1.Maximum = RMAX;
                progressBar1.Value = r;
                label2.Text = r + " / " + RMAX;

                int unitCost = 0;

                try
                {
                    double temp = (double)(file.Cells()[r, 10] as Microsoft.Office.Interop.Excel.Range).Value;
                    //double.TryParse(((file.Cells()[r, 10] as Microsoft.Office.Interop.Excel.Range).Value), out temp);

                    unitCost = (int)(temp * 10000);
                }
                catch
                {

                }

                textBox2.Text += unitCost.ToString() + Environment.NewLine;

                ora = new Oracle(@"insert into " + schema + @".F4105Z1 (" + columns4105 + @") values (" + variables4105 + @")");
                ora.AddParameter("@SZEDUS", userID);
                ora.AddParameter("@SZEDBT", batchNumber);
                ora.AddParameter("@SZEDTN", transactionNumber);
                ora.AddParameter("@SZEDLN", ln);
                ora.AddParameter("@SZITM", itemNumber[r]);
                ora.AddParameter("@SZLITM", itemNumber[r]);
                ora.AddParameter("@SZAITM", itemNumber[r]);
                ora.AddParameter("@SZMCU", branchPlant);
                ora.AddParameter("@SZLOCN", "");
                ora.AddParameter("@SZLOTN", "");
                ora.AddParameter("@SZLOTG", ""); //Optional
                ora.AddParameter("@SZLEDG", "07");
                ora.AddParameter("@SZUNCS", unitCost);
                ora.AddParameter("@SZCSPO", "");
                ora.AddParameter("@SZCSIN", "I");
                ora.AddParameter("@SZTYTN", "JDEIC");
                ora.AddParameter("@SZEDSP", " ");
                ora.AddParameter("@SZDRIN", "1");
                ora.AddParameter("@SZTNAC", "A");
                ora.Run();

                ln += 1000;

                ora = new Oracle(@"insert into " + schema + @".F4105Z1 (" + columns4105 + @") values (" + variables4105 + @")");
                ora.AddParameter("@SZEDUS", userID);
                ora.AddParameter("@SZEDBT", batchNumber);
                ora.AddParameter("@SZEDTN", transactionNumber);
                ora.AddParameter("@SZEDLN", ln);
                ora.AddParameter("@SZITM", itemNumber[r]);
                ora.AddParameter("@SZLITM", itemNumber[r]);
                ora.AddParameter("@SZAITM", itemNumber[r]);
                ora.AddParameter("@SZMCU", branchPlant);
                ora.AddParameter("@SZLOCN", "");
                ora.AddParameter("@SZLOTN", "");
                ora.AddParameter("@SZLOTG", ""); //Optional
                ora.AddParameter("@SZLEDG", "08");
                ora.AddParameter("@SZUNCS", unitCost);
                ora.AddParameter("@SZCSPO", "P");
                ora.AddParameter("@SZCSIN", "");
                ora.AddParameter("@SZTYTN", "JDEIC");
                ora.AddParameter("@SZEDSP", " ");
                ora.AddParameter("@SZDRIN", "1");
                ora.AddParameter("@SZTNAC", "A");
                ora.Run();

                ln += 1000;
            }

            MessageBox.Show("F4105Z1 done. Go run R4105Z1I, TON2.");


            //4117
            string variables4117 = "@PRITM, @PRPRODM, @PRPRODF, @PRMCUZ, @PRDCD1, @PRDCD2, @PRDCD3, @PRDCD4, @PRDCD5, @PRCRTU, @PRUSER, @PRPID, @PRJOBN, @PRUPMJ, @PRUPMT, @PRRTRND, @PRRPRBL, @PRCCOST, @PRRETPOL, @PRSRYN, @PRIBYN, @PRVMRS33";
            string columns4117 = variables4117.Replace("@", "");

            for (int r = 2; r <= RMAX; r++)
            {
                progressBar1.Maximum = RMAX;
                progressBar1.Value = r;
                label2.Text = r + " / " + RMAX;

                ora = new Oracle(@"insert into " + schema + @".F4117 (" + columns4117 + @") values (" + variables4117 + @")");
                ora.AddParameter("@PRITM", itemNumber[r]);
                ora.AddParameter("@PRPRODM", "        ");
                ora.AddParameter("@PRPRODF", "        ");
                ora.AddParameter("@PRMCUZ", "            ");
                ora.AddParameter("@PRDCD1", "   ");
                ora.AddParameter("@PRDCD2", "   ");
                ora.AddParameter("@PRDCD3", "   ");
                ora.AddParameter("@PRDCD4", "   ");
                ora.AddParameter("@PRDCD5", "   ");
                ora.AddParameter("@PRCRTU", "MGS");
                ora.AddParameter("@PRUSER", "MGS");
                ora.AddParameter("@PRPID", "IHeartIT");
                ora.AddParameter("@PRJOBN", "E1");
                ora.AddParameter("@PRUPMJ", Core.dateToJDE(DateTime.Now));
                ora.AddParameter("@PRUPMT", Core.timeToJDE(DateTime.Now));
                ora.AddParameter("@PRRTRND", 0);
                ora.AddParameter("@PRRPRBL", 0);
                ora.AddParameter("@PRCCOST", "   ");
                ora.AddParameter("@PRRETPOL", " ");
                ora.AddParameter("@PRSRYN", " ");
                ora.AddParameter("@PRIBYN", 0);
                ora.AddParameter("@PRVMRS33", "          ");
                ora.Run();
            }

            //41171
            string variables41171 = "@PBITM, @PBMMCU, @PBPRODM, @PBPRODF, @PBMCUZ, @PBDCD1, @PBDCD2, @PBDCD3, @PBDCD4, @PBDCD5, @PBCRTU, @PBUSER, @PBPID, @PBJOBN, @PBUPMJ, @PBUPMT, @PBRTRND, @PBRPRBL, @PBCCOST, @PBRETPOL, @PBSRYN, @PBIBYN, @PBVMRS33";
            string columns41171 = variables41171.Replace("@", "");

            for (int r = 2; r <= RMAX; r++)
            {
                progressBar1.Maximum = RMAX;
                progressBar1.Value = r;
                label2.Text = r + " / " + RMAX;

                ora = new Oracle(@"insert into " + schema + @".F41171 (" + columns41171 + @") values (" + variables41171 + @")");
                ora.AddParameter("@PBITM", itemNumber[r]);
                ora.AddParameter("@PBMMCU", branchPlant);
                ora.AddParameter("@PBPRODM", "        ");
                ora.AddParameter("@PBPRODF", "        ");
                ora.AddParameter("@PBMCUZ", "            ");
                ora.AddParameter("@PBDCD1", "   ");
                ora.AddParameter("@PBDCD2", "   ");
                ora.AddParameter("@PBDCD3", "   ");
                ora.AddParameter("@PBDCD4", "   ");
                ora.AddParameter("@PBDCD5", "   ");
                ora.AddParameter("@PBCRTU", "MGS");
                ora.AddParameter("@PBUSER", "MGS");
                ora.AddParameter("@PBPID", "IHeartIT");
                ora.AddParameter("@PBJOBN", "E1");
                ora.AddParameter("@PBUPMJ", Core.dateToJDE(DateTime.Now));
                ora.AddParameter("@PBUPMT", Core.timeToJDE(DateTime.Now));
                ora.AddParameter("@PBRTRND", 0);
                ora.AddParameter("@PBRPRBL", 0);
                ora.AddParameter("@PBCCOST", "   ");
                ora.AddParameter("@PBRETPOL", " ");
                ora.AddParameter("@PBSRYN", " ");
                ora.AddParameter("@PBIBYN", 0);
                ora.AddParameter("@PBVMRS33", "          ");
                ora.Run();
            }

            //43090
            string variables43090 = "@PCLITM, @PCAITM, @PCMCU, @PCCERS, @PCNROU, @PCTROU, @PCURCD, @PCURRF, @PCROTP, @PCPOC, @PCAN8, @PCITM, @PCCEFJ, @PCCXPJ, @PCTFRQ, @PCORDS, @PCTFRD, @PCLTDJ, @PCDAYE, @PCDAYL, @PCLTQP, @PCLTNM, @PCLTTS, @PCALTD, @PCLLTD, @PCACST, @PCLCST, @PCNOOD, @PCQTYS, @PCQTYR, @PCQTYC, @PCQTYW, @PCQTYJ, @PCQTYA, @PCUODR, @PCUREC, @PCUPTD, @PCUONT, @PCUEAR, @PCULAT, @PCAODR, @PCAREC, @PCAPTD, @PCAONT, @PCAEAR, @PCALAT, @PCRONT, @PCREAR, @PCRLAT, @PCURDT, @PCURAT, @PCURAB";
            string columns43090 = variables43090.Replace("@", "");

            for (int r = 2; r <= RMAX; r++)
            {
                progressBar1.Maximum = RMAX;
                progressBar1.Value = r;
                label2.Text = r + " / " + RMAX;

                string vendorNumber = file.Cells()[r, 2].Text;

                ora = new Oracle(@"insert into " + schema + @".F43090 (" + columns43090 + @") values (" + variables43090 + @")");
                ora.AddParameter("@PCLITM", itemNumber[r]);
                ora.AddParameter("@PCAITM", itemNumber[r]);
                ora.AddParameter("@PCMCU", branchPlant);
                ora.AddParameter("@PCCERS", "  ");
                ora.AddParameter("@PCNROU", "    ");
                ora.AddParameter("@PCTROU", "    ");
                ora.AddParameter("@PCURCD", " ");
                ora.AddParameter("@PCURRF", "               ");
                ora.AddParameter("@PCROTP", " ");
                ora.AddParameter("@PCPOC", " ");
                ora.AddParameter("@PCAN8", vendorNumber);
                ora.AddParameter("@PCITM", itemNumber[r]);
                ora.AddParameter("@PCCEFJ", Core.dateToJDE(DateTime.Now));
                ora.AddParameter("@PCCXPJ", 0);
                ora.AddParameter("@PCTFRQ", 0);
                ora.AddParameter("@PCORDS", 0);
                ora.AddParameter("@PCTFRD", 0);
                ora.AddParameter("@PCLTDJ", 0);
                ora.AddParameter("@PCDAYE", 0);
                ora.AddParameter("@PCDAYL", 0);
                ora.AddParameter("@PCLTQP", 0);
                ora.AddParameter("@PCLTNM", 0);
                ora.AddParameter("@PCLTTS", 0);
                ora.AddParameter("@PCALTD", 0);
                ora.AddParameter("@PCLLTD", 0);
                ora.AddParameter("@PCACST", 0);
                ora.AddParameter("@PCLCST", 0);
                ora.AddParameter("@PCNOOD", 0);
                ora.AddParameter("@PCQTYS", 0);
                ora.AddParameter("@PCQTYR", 0);
                ora.AddParameter("@PCQTYC", 0);
                ora.AddParameter("@PCQTYW", 0);
                ora.AddParameter("@PCQTYJ", 0);
                ora.AddParameter("@PCQTYA", 0);
                ora.AddParameter("@PCUODR", 0);
                ora.AddParameter("@PCUREC", 0);
                ora.AddParameter("@PCUPTD", 0);
                ora.AddParameter("@PCUONT", 0);
                ora.AddParameter("@PCUEAR", 0);
                ora.AddParameter("@PCULAT", 0);
                ora.AddParameter("@PCAODR", 0);
                ora.AddParameter("@PCAREC", 0);
                ora.AddParameter("@PCAPTD", 0);
                ora.AddParameter("@PCAONT", 0);
                ora.AddParameter("@PCAEAR", 0);
                ora.AddParameter("@PCALAT", 0);
                ora.AddParameter("@PCRONT", 0);
                ora.AddParameter("@PCREAR", 0);
                ora.AddParameter("@PCRLAT", 0);
                ora.AddParameter("@PCURDT", 0);
                ora.AddParameter("@PCURAT", 0);
                ora.AddParameter("@PCURAB", 0);
                ora.Run();
            }
            
            file.Show();

            MessageBox.Show("Done!");

            file.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Oracle.Run("delete from " + schema + @".F4101 where IMSRP9='MSQRES'");
            Oracle.Run("delete from " + schema + @".F4102 where IBSRP9='MSQRES'");
            Oracle.Run("delete from " + schema + @".F4104 where IVPID = 'IHeartIT'");
            Oracle.Run("delete from " + schema + @".F43090 where PCCXPJ = 0");
            Oracle.Run("delete from " + schema + @".F41171 where PBPID = 'IHeartIT'");
            Oracle.Run("delete from " + schema + @".F4117 where PRPID = 'IHeartIT'");

            Oracle.Run("delete from " + schema + @".F4105 where COITM not in (select IMITM from " + schema + @".F4101)");
            Oracle.Run("delete from " + schema + @".F41021 where LIITM not in (select IBITM from " + schema + @".F4102)");
            Oracle.Run("delete from " + schema + @".F4101G where IBITM not in (select IMITM from " + schema + @".F4101)");
            Oracle.Run("delete from " + schema + @".F4101A where IMITM not in (select IMITM from " + schema + @".F4101)");
            Oracle.Run("delete from " + schema + @".F4101C where IMITM not in (select IMITM from " + schema + @".F4101)");
            Oracle.Run("delete from " + schema + @".F4101M where IMITM not in (select IMITM from " + schema + @".F4101)");
            Oracle.Run("delete from " + schema + @".F41002 where UMITM not in (select IMITM from " + schema + @".F4101)");

            Oracle.Run("delete from " + schema + @".F3111Z1"); //Transactions

            MessageBox.Show("Done!");
        }
    }
}
