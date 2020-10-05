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
    public partial class OwnershipChangeReport : Form
    {
        public OwnershipChangeReport()
        {
            InitializeComponent();

            textBox3.Text = DateTime.Today.Year.ToString();
            textBox4.Text = DateTime.Today.Year.ToString();
        }

        private void Visa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vailtech ora = new Vailtech(@"
SELECT
r.ROLL_NO,
substr(r.ROLL_NO,1,3) AS Roll1,
substr(r.ROLL_NO,4,3) AS Roll2,
substr(r.ROLL_NO,7,5) AS Roll3,
substr(r.ROLL_NO,12,4) AS Roll4,
r.OWNER_1 AS First_Name,
r.OWNER_2 AS SECOND_Name,
r.MAILING1 AS Address_Line_1,
r.MAILING2 AS Address_Line_2,
r.MAILING3 AS City,
r.MAILING4 AS Province,
r.MAILING5 AS Postal_Code,
r.STREET_NO || decode(r.STREET_QUAL, '-', '-' || r.STREET_UNIT, null, '', r.STREET_QUAL) || ' ' || r.STREET_NAME AS Property, 

b.INSTALL_AMT1 + m.PEN_DUE + m.TAX_ADJ + m.PEN_ADJ + m.OTHER_ADJ - m.TAX_PAID - m.PEN_PAID - m.OTHER_PAID as draw_amount1,
b.INSTALL_AMT2 AS draw_amount2,
b.INSTALL_AMT3 AS draw_amount3,
b.INST_DATE1 AS due_date1,
b.INST_DATE2 AS due_date2,
b.INST_DATE3 AS due_date3

FROM VAILTECH.TX_HISTORY_DIST hd
JOIN VAILTECH.TX_ROLL r ON hd.ROLL_NO = r.ROLL_NO and hd.ACTIVITY_NO = r.ACTIVITY_NO
JOIN VAILTECH.TX_BILLPRINT b ON r.ROLL_NO = b.ROLL_NO and r.ACTIVITY_NO = b.ACTIVITY_NO
JOIN VAILTECH.TX_MAINHT m on r.ROLL_NO = m.ROLL_NO and r.ACTIVITY_NO = m.ACTIVITY_NO

WHERE b.ORIGIN = @ORIDUE
AND hd.ORIGIN = @ORILIST
AND m.HIS_YEAR = @MHTYEAR
AND b.TAX_YEAR = @BPYEAR
"); //010040356000000
            ora.AddParameter("@ORIDUE", textBox2.Text);
            ora.AddParameter("@ORILIST", textBox1.Text);
            ora.AddParameter("@MHTYEAR", textBox4.Text);
            ora.AddParameter("@BPYEAR", textBox3.Text);
            DataTable dt = ora.Run();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //If we're currently looking at a billing beyond the first, we need to ensure
                //former billings this year don't throw off our numbers.

                //Former billings will give us a TAX_PAID from above, but that money is already accounted for.
                //We need to do this adjustment to ensure we don't double-dip and think TAX_PAID is a credit.
                DataTable tempTable = Vailtech.Run(@"
select (install_amt1 + install_amt2 + install_amt3) as install_amt
from VAILTECH.TX_BILLPRINT
where ROLL_NO = @ROLLNO
and INTERIM_FIN_SUP <> 'F'
and TAX_YEAR = @YEAR", dt.Rows[i]["ROLL_NO"].ToString(), DateTime.Today.Year);

                double formerTaxPaid = 0;

                for (int j = 0; j < tempTable.Rows.Count; j++)
                    formerTaxPaid += double.Parse(tempTable.Rows[j]["install_amt"].ToString());

                //Also, we need to ensure we look in past years for any credits / unpaid amounts that
                //may not have been moved over to the current year.

                tempTable = Vailtech.Run(@"
select
TAX_LEVIED + PEN_DUE + TAX_ADJ + PEN_ADJ + OTHER_ADJ - TAX_PAID - PEN_PAID - OTHER_PAID as Balance
from VAILTECH.TX_MAINHT
where ROLL_NO = @ROLLNO
and HIS_YEAR <> @YEAR
", dt.Rows[i]["ROLL_NO"].ToString(), DateTime.Today.Year);

                double outstandingAmounts = 0;

                for (int j = 0; j < tempTable.Rows.Count; j++)
                    outstandingAmounts += double.Parse(tempTable.Rows[j]["Balance"].ToString());

                //Apply aforementioned adjustments
                //-- Disabled February 2nd, 2018 due to AccessIT ticket #45233
                //-- Enabled June 12th, 2018 due to AccessIT ticket #47344
                //-- Added condition July 4th, 2018 after a conversation with Birgit
                if(DateTime.Today >= new DateTime(DateTime.Today.Year, 5, 1)) //If after May 1st of the current year
                    dt.Rows[i]["draw_amount1"] = double.Parse(dt.Rows[i]["draw_amount1"].ToString()) + formerTaxPaid + outstandingAmounts;

                //Now we can start our calculations
                string m = dt.Rows[i]["Province"].ToString().Replace(",", " ").Trim();
                string[] split = m.Split(' ');

                string province = split[split.Length - 1];
                string city = m.Substring(0, m.Length - province.Length);

                if (province.Length > 2)
                    province = province.Substring(0, 2);

                dt.Rows[i]["Province"] = province;
                dt.Rows[i]["City"] = city;

                //

                if(DateTime.Parse(dt.Rows[i]["due_date1"].ToString()) <= DateTime.Today)
                {
                    dt.Rows[i]["due_date1"] = DBNull.Value;
                    dt.Rows[i]["draw_amount2"] = double.Parse(dt.Rows[i]["draw_amount1"].ToString()) + double.Parse(dt.Rows[i]["draw_amount2"].ToString());
                    dt.Rows[i]["draw_amount1"] = DBNull.Value;
                }

                if (dt.Rows[i]["due_date2"].ToString().Trim() != "" && DateTime.Parse(dt.Rows[i]["due_date2"].ToString()) <= DateTime.Today)
                {
                    dt.Rows[i]["due_date2"] = DBNull.Value;
                    dt.Rows[i]["draw_amount3"] = double.Parse(dt.Rows[i]["draw_amount2"].ToString()) + double.Parse(dt.Rows[i]["draw_amount3"].ToString());
                    dt.Rows[i]["draw_amount2"] = DBNull.Value;
                }

                double temp, temp2, temp3;
                double.TryParse(dt.Rows[i]["draw_amount1"].ToString(), out temp);

                if (temp < 0)
                {
                    double.TryParse(dt.Rows[i]["draw_amount2"].ToString(), out temp2);

                    double amountToMove = Math.Min(Math.Abs(temp), Math.Abs(temp2));

                    temp += amountToMove;
                    temp2 -= amountToMove;

                    dt.Rows[i]["draw_amount1"] = temp;
                    dt.Rows[i]["draw_amount2"] = temp2;

                    if (temp < 0) //If more to move
                    {
                        double.TryParse(dt.Rows[i]["draw_amount3"].ToString(), out temp3);

                        amountToMove = Math.Min(Math.Abs(temp), Math.Abs(temp3));

                        temp += amountToMove;
                        temp3 -= amountToMove;

                        dt.Rows[i]["draw_amount1"] = temp;
                        dt.Rows[i]["draw_amount3"] = temp3;

                        if (temp < 0) //If overpaid
                            dt.Rows[i]["draw_amount1"] = 0;
                    }
                }
                
                double.TryParse(dt.Rows[i]["draw_amount2"].ToString(), out temp2);

                if (temp2 < 0)
                {
                    double.TryParse(dt.Rows[i]["draw_amount3"].ToString(), out temp3);

                    double amountToMove = Math.Min(Math.Abs(temp2), Math.Abs(temp3));

                    temp2 += amountToMove;
                    temp3 -= amountToMove;

                    dt.Rows[i]["draw_amount2"] = temp2;
                    dt.Rows[i]["draw_amount3"] = temp3;

                    if (temp2 < 0) //If overpaid
                        dt.Rows[i]["draw_amount2"] = 0;
                }

                temp = 0;
                temp2 = 0;
                temp3 = 0;

                double.TryParse(dt.Rows[i]["draw_amount1"].ToString(), out temp);
                double.TryParse(dt.Rows[i]["draw_amount2"].ToString(), out temp2);
                double.TryParse(dt.Rows[i]["draw_amount3"].ToString(), out temp3);
                
                if ((temp == 0 && temp2 == 0 && temp3 == 20) ||
                    (temp == 0 && temp2 == 20 && temp3 == 0))
                {
                    dt.Rows[i]["draw_amount1"] = 20;
                    dt.Rows[i]["draw_amount2"] = 0;
                    dt.Rows[i]["draw_amount3"] = 0;

                    if (dt.Rows[i]["due_date1"] == DBNull.Value)
                    {
                        dt.Rows[i]["draw_amount1"] = DBNull.Value;
                        dt.Rows[i]["draw_amount2"] = 20;
                        dt.Rows[i]["draw_amount3"] = 0;
                    }

                    if (dt.Rows[i]["due_date2"] == DBNull.Value)
                    {
                        dt.Rows[i]["draw_amount1"] = DBNull.Value;
                        dt.Rows[i]["draw_amount2"] = DBNull.Value;
                        dt.Rows[i]["draw_amount3"] = 20;
                    }
                }
            }

            Report r = new Report(Text, dt);
            r.Show();

            Close();
        }

        private void OwnershipChangeReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(null, null);
            else if (e.KeyCode == Keys.Escape)
                Close();
        }

        //private void z(Delegate method)
        //{
        //    MethodInvoker mi = new MethodInvoker(method);
        //    mi.BeginInvoke(null, null);
        //}
    }
}
