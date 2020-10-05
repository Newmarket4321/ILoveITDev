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
    public partial class DATSEngPayrollExport : Form
    {
        public int batchID = -1;

        public DATSEngPayrollExport()
        {
            InitializeComponent();

            label6.Text = "";

            process();

            //MethodInvoker myProcessStarter = new MethodInvoker(process);
            //myProcessStarter.BeginInvoke(null, null);
        }

        private void process()
        {
            string type = "H";
            string environment = "PY";
            string schema = "";
            string controlSchema = "";

            if(environment == "PD")
            {
                schema = "PRODDTA";
                controlSchema = "PRODCTL";
            }
            else if (environment == "PY")
            {
                schema = "CRPDTA";
                controlSchema = "CRPCTL";
            }
            else if (environment == "DV")
            {
                schema = "TESTDTA";
                controlSchema = "TESTCTL";
            }

            if(MessageBox.Show("About to export to " + environment, "Payroll Export", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;

            DATSEngineeringSQL sql = null;
            string F0002NumberPayroll = "";
            string F0002NumberWorkOrder = "";
            FindPeriod fp = null;

            if (type != "S")
            {
                fp = new FindPeriod();
                fp.ShowDialog();
            }

            label1.Font = new Font(label1.Font, FontStyle.Bold); 
            label1.Update(); 

            if ((fp != null && fp.period != "") || type == "S")
            {
                updateEmployeeTypes(schema);

                label1.Font = new Font(label1.Font, FontStyle.Regular); 
                label1.ForeColor = Color.Gray; 
                label1.Update(); 
                label2.Font = new Font(label1.Font, FontStyle.Bold); 
                label2.Update(); 

                if (environment == "PD")
                {
                    //1. Get local batch ID
                    sql = new DATSEngineeringSQL("select max(batchid) from batchids");
                    batchID = int.Parse(sql.Run().Rows[0][0].ToString()) + 1;

                    //2. Insert new local batch ID
                    sql = new DATSEngineeringSQL("insert into batchids (batchid, bdate) values (@BATCHID, @BDATE)");
                    sql.AddParameter("@BATCHID", batchID);
                    sql.AddParameter("@BDATE", DateTime.Today);
                    sql.Run();

                    //3. Mark timesheets as exported, and give them local batch ID
                    if (type == "S") //Salary
                    {
                        Oracle ora = new Oracle("select max(JDPPED) from " + schema + ".F069066 where JDPCCD='SAL  ' and JDPPED <= @TODAY");
                        ora.AddParameter("@TODAY", Core.dateToJDE(DateTime.Today.ToString()));
                        string cutoff = ora.Run().Rows[0][0].ToString();

                        //SALARY
                        sql = new DATSEngineeringSQL(@"
update timesheetdetail

set exported='True',
BatchId=@BATCHID

where dateworked<=@CUTOFF
and recordlocked='True'
and exported='False'
and paytype <> 0
and EmployeeID in (select EmployeeID from Users where EMPTYPE = @EMPTYPE)");
                        sql.AddParameter("@BATCHID", batchID);
                        sql.AddParameter("@CUTOFF", Core.JDEToDate(cutoff));
                        sql.AddParameter("@EMPTYPE", type);
                        sql.Run();
                    }
                    else //Hourly
                    {
                        //HOURLY
                        sql = new DATSEngineeringSQL(@"
update timesheetdetail

set exported='True',
BatchId=@BATCHID

where period<=@PERIOD
and recordlocked='True'
and exported='False'
and paytype <> 0
and EmployeeID in (select EmployeeID from Users where EMPTYPE = @EMPTYPE)");
                        sql.AddParameter("@BATCHID", batchID);
                        sql.AddParameter("@PERIOD", fp.period);
                        sql.AddParameter("@EMPTYPE", type);
                        sql.Run();
                    }
                }

                //4. Clear F06116Z1
                Oracle.Run("delete from " + schema + ".F06116Z1");

                //5. Get JDE batch IDs
                F0002NumberPayroll = Oracle.Run("Select NNN006 from " + controlSchema + ".F0002 where NNSY='00'").Rows[0][0].ToString();
                F0002NumberWorkOrder = (int.Parse(F0002NumberPayroll) + 1).ToString();

                //6. Use JDE batch IDs
                Oracle.Run("UPDATE " + controlSchema + ".F0002 Set NNN006 = NNN006 + 2 where NNSY='00'");

                //7. Get data from the new batch in DATS
                if (environment == "PD")
                {
                    sql = new DATSEngineeringSQL(@"select t.employeeid, t.workorder, t.hours, p.rate_exp, p.rate_r, t.lumpsum, t.dateworked, t.timecarddetailid
from timesheetdetail t
join PayCodes p on t.PayType = p.PayType
where t.batchid=@BATCHID");
                    sql.AddParameter("@BATCHID", batchID);
                }
                else
                {
                    if (type == "S")
                    {
                        Oracle ora = new Oracle("select max(JDPPED) from " + schema + ".F069066 where JDPCCD='SAL  ' and JDPPED <= @TODAY");
                        ora.AddParameter("@TODAY", Core.dateToJDE(DateTime.Today.ToString()));
                        string cutoff = ora.Run().Rows[0][0].ToString();

                        sql = new DATSEngineeringSQL(@"
select t.employeeid, t.workorder, t.hours, p.Rate_Exp, p.rate_r, t.lumpsum, t.dateworked, t.timecarddetailid
from timesheetdetail t
join PayCodes p on t.PayType = p.PayType

where dateworked<=@CUTOFF
and recordlocked='True'
and exported='False'
and p.paytype <> 0
and EmployeeID in (select EmployeeID from Users where EMPTYPE = @EMPTYPE)");
                        sql.AddParameter("@CUTOFF", Core.JDEToDate(cutoff));
                        sql.AddParameter("@EMPTYPE", type);
                    }
                    else //Hourly
                    {
                        sql = new DATSEngineeringSQL(@"
select t.employeeid, t.workorder, t.hours, 1, 1, 0, t.dateworked, t.timecarddetailid
from timesheetdetail t

where period<=@PERIOD
and recordlocked='True'
and exported='False'");
                        sql.AddParameter("@PERIOD", fp.period);
                    }

                }
                DataTable dt = sql.Run();

                //8. Insert into F06116Z1 (Payroll)
                double totalHours = 0;
                double totalLSum = 0;
                int lineNumber = 1000;

                label2.Font = new Font(label1.Font, FontStyle.Regular); 
                label2.ForeColor = Color.Gray; 
                label2.Update(); 
                label3.Font = new Font(label1.Font, FontStyle.Bold); 
                label3.Update(); 

                progressBar1.Value = 0; 
                progressBar1.Maximum = dt.Rows.Count; 
                progressBar1.Update(); 

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    label6.Text = (i + 1) + " of " + dt.Rows.Count; 
                    label6.Update(); 

                    progressBar1.Value = i + 1; 
                    progressBar1.Update(); 

                    //if (dt.Rows[i]["rate_exp"].ToString() == "0")
                    //    MessageBox.Show("Pay Type ""Absent"" is coming across. This shouldn't happen. Please speak to IT.");

                    double lsum = 0;
                    //double.TryParse(dt.Rows[i]["lumpsum"].ToString(), out lsum);
                    int recordType = 1;
                    int hours = int.Parse((double.Parse(dt.Rows[i]["hours"].ToString()) * 100).ToString());
                    double hourRate = 1;
                    hours = (int)((double)hours * hourRate);

                    Oracle ora = new Oracle("INSERT INTO " + schema + ".F06116Z1 ( VLEDUS, VLICU, VLEDBT, VLAN8, VLDWK, VLPDBA, VLPHRW, VLANI, VLEPA, VLSHRT, VLRCCD, VLEDLN, VLEDTN ) VALUES ( @VLEDUS, @VLICU, @VLEDBT, @VLAN8, @VLDWK, @VLPDBA, @VLPHRW, @VLANI, @VLEPA, @VLSHRT, @VLRCCD, @VLEDLN, @VLEDTN )");
                    ora.AddParameter("@VLEDUS", "JDE"); //Create user
                    ora.AddParameter("@VLICU", 0);
                    ora.AddParameter("@VLEDBT", F0002NumberPayroll); //Batch number
                    ora.AddParameter("@VLAN8", dt.Rows[i]["employeeid"].ToString()); //Employee number
                    ora.AddParameter("@VLDWK", Core.dateToJDE(dt.Rows[i]["dateworked"].ToString())); //Date worked, JDE format
                    ora.AddParameter("@VLPDBA", 1); //Pay code
                    ora.AddParameter("@VLPHRW", hours); //Hours*100
                    ora.AddParameter("@VLANI", DBNull.Value); //Work order
                    ora.AddParameter("@VLEPA", int.Parse((lsum * 100).ToString())); //Lump sum
                    ora.AddParameter("@VLSHRT", DBNull.Value); //Override rate
                    ora.AddParameter("@VLRCCD", recordType); //Record type
                    ora.AddParameter("@VLEDLN", lineNumber);
                    ora.AddParameter("@VLEDTN", 0);
                    ora.Run();

                    totalLSum += lsum;
                    totalHours += ((double)hours) / 100;
                    lineNumber += 1000;
                }

                string output1 = "Done!"
                    + Environment.NewLine
                    + Environment.NewLine + "Batch type is PAYROLL."
                    + Environment.NewLine + "JDE Batch ID is " + F0002NumberPayroll + "."
                    + Environment.NewLine
                    + Environment.NewLine + "Total records is " + dt.Rows.Count + "."
                    + Environment.NewLine + "Total hours is " + totalHours + "."
                    + Environment.NewLine + "Total lump sum is $" + totalLSum + ".";

                //9. Insert into F06116Z1 (Work order)
                totalHours = 0;
                totalLSum = 0;
                lineNumber = 1000;

                label3.Font = new Font(label1.Font, FontStyle.Regular); 
                label3.ForeColor = Color.Gray; 
                label3.Update(); 
                label4.Font = new Font(label1.Font, FontStyle.Bold); 
                label4.Update(); 

                progressBar1.Value = 0; 
                progressBar1.Maximum = dt.Rows.Count; 
                progressBar1.Update(); 

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    label6.Text = (i + 1) + " of " + dt.Rows.Count; 
                    label6.Update(); 

                    progressBar1.Value = i + 1; 
                    progressBar1.Update(); 

                    if (dt.Rows[i]["workorder"].ToString().Trim() != "")
                    {
                        double lsum = 0;
                        //double.TryParse(dt.Rows[i]["lumpsum"].ToString(), out lsum);
                        int recordType = 3;
                        string workorder = dt.Rows[i]["workorder"].ToString().Trim() == "" ? "" : "\"" + dt.Rows[i]["workorder"].ToString() + ".";
                        int hours = int.Parse((double.Parse(dt.Rows[i]["hours"].ToString()) * 100).ToString());
                        double hourRate = 1;
                        hours = (int)((double)hours * hourRate);

                        Oracle ora = new Oracle("INSERT INTO " + schema + ".F06116Z1 ( VLEDUS, VLICU, VLEDBT, VLAN8, VLDWK, VLPDBA, VLPHRW, VLANI, VLEPA, VLSHRT, VLRCCD, VLEDLN, VLEDTN ) VALUES ( @VLEDUS, @VLICU, @VLEDBT, @VLAN8, @VLDWK, @VLPDBA, @VLPHRW, @VLANI, @VLEPA, @VLSHRT, @VLRCCD, @VLEDLN, @VLEDTN )");
                        ora.AddParameter("@VLEDUS", "JDE"); //Create user
                        ora.AddParameter("@VLICU", 0);
                        ora.AddParameter("@VLEDBT", F0002NumberWorkOrder); //Batch number
                        ora.AddParameter("@VLAN8", dt.Rows[i]["employeeid"].ToString()); //Employee number
                        ora.AddParameter("@VLDWK", Core.dateToJDE(dt.Rows[i]["dateworked"].ToString())); //Date worked, JDE format
                        ora.AddParameter("@VLPDBA", 1); //Pay code
                        ora.AddParameter("@VLPHRW", hours); //Hours*100
                        ora.AddParameter("@VLANI", workorder); //Work order
                        ora.AddParameter("@VLEPA", int.Parse((lsum * 100).ToString())); //Lump sum
                        ora.AddParameter("@VLSHRT", DBNull.Value); //Override rate
                        ora.AddParameter("@VLRCCD", recordType); //Record type
                        ora.AddParameter("@VLEDLN", lineNumber);
                        ora.AddParameter("@VLEDTN", 0);
                        ora.Run();

                        totalLSum += lsum;
                        totalHours += ((double)hours) / 100;
                        lineNumber += 1000;
                    }
                }

                label4.Font = new Font(label1.Font, FontStyle.Regular); 
                label4.ForeColor = Color.Gray; 
                label4.Update(); 
                label5.Font = new Font(label1.Font, FontStyle.Bold); 
                label5.Update(); 

                string output2 = "Done!"
                    + Environment.NewLine
                    + Environment.NewLine + "Batch type is WORKORDER."
                    + Environment.NewLine + "JDE Batch ID is " + F0002NumberWorkOrder + "."
                    + Environment.NewLine
                    + Environment.NewLine + "Total records is " + ((lineNumber / 1000) - 1) + "."
                    + Environment.NewLine + "Total hours is " + totalHours + "."
                    + Environment.NewLine + "Total lump sum is $" + totalLSum + ".";

                //10. Update timesheet histories
                if (environment == "PD")
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        label6.Text = (i + 1) + " of " + dt.Rows.Count; 
                        label6.Update(); 

                        progressBar1.Value = i + 1; 
                        progressBar1.Update(); 
                    }
                }

                label5.Font = new Font(label1.Font, FontStyle.Regular); 
                label5.ForeColor = Color.Gray; 
                label5.Update(); 

                label6.Text = ""; 
                label6.Update(); 

                string email = "";

                if (environment != "PD")
                    email = "ealarcon@newmarket.ca";
                else
                    email = Core.getVariable("PayrollContact");

                Core.sendMail(email, "DATS Engineering Export #" + batchID, output1 + Environment.NewLine + Environment.NewLine + output2);
                MessageBox.Show("The export has finished. Please check your e-mail for results.");

                Close(); 
            }
            else
            {
                Close(); 
            }
        }

        private static void updateEmployeeTypes(string schema)
        {
            DataTable dt = DATSEngineeringSQL.Run("select employeeid from users where employeeid <> '999999' order by employeeid");

            //string emp = "";

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    if (i > 0)
            //        emp += ", ";

            //    emp += dt.Rows[i][0].ToString();
            //}

            //DataTable dt2 = Oracle.Run("select YASALY from PRODDTA.F060116 where YAAN8 in (" + emp + ")");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {

                    Oracle ora = new Oracle("select YASALY, YAAN8 from " + schema + ".F060116 where YAAN8 = @EMPID");
                    ora.AddParameter("@EMPID", dt.Rows[i][0].ToString());
                    string empType = ora.Run().Rows[0]["YASALY"].ToString();

                    DATSEngineeringSQL sql = new DATSEngineeringSQL("update users set emptype = @EMPTYPE where employeeid = @EMPID");
                    sql.AddParameter("@EMPTYPE", empType);
                    sql.AddParameter("@EMPID", dt.Rows[i][0].ToString());
                    sql.Run();
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
