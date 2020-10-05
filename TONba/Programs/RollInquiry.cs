using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class RollInquiry : Form
    {
        public RollInquiry()
        {
            InitializeComponent();
        }

        private DataTable GetTXROLLData(string rollNumber)
        {
            string constr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TX_ROLL WHERE ROLL_NO = @rollNumber"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Parameters.AddWithValue("@rollNumber", rollNumber);
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        private DataTable GetTXMAINTXMaxYearData(string rollNumber)
        {
            string constr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT HIS_YEAR, TAX_LEVIED as 'Tax Levied', PEN_DUE as 'Penalty Due', OTHER_DUE as 'Other Due', TAX_ADJ as 'Tax Adjust', PEN_ADJ as 'Penalty Adjust', OTHER_ADJ as 'Other Adjustment', TAX_PAID as 'Tax Paid', PEN_PAID as 'Penalty Paid', OTHER_PAID as 'Other Paid' FROM TX_MAIN_HT WHERE ROLL_NO = @rollNumber AND HIS_YEAR = (SELECT MAX(HIS_YEAR) FROM TX_MAIN_HT)"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Parameters.AddWithValue("@rollNumber", rollNumber);
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        private DataTable GetTXMAINTXPrevYearData(string rollNumber)
        {
            string constr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT HIS_YEAR, TAX_LEVIED as 'Tax Levied', PEN_DUE as 'Penalty Due', OTHER_DUE as 'Other Due', TAX_ADJ as 'Tax Adjust', PEN_ADJ as 'Penalty Adjust', OTHER_ADJ as 'Other Adjustment', TAX_PAID as 'Tax Paid', PEN_PAID as 'Penalty Paid', OTHER_PAID as 'Other Paid' FROM TX_MAIN_HT WHERE ROLL_NO = @rollNumber AND HIS_YEAR = (SELECT MAX(HIS_YEAR) -1 FROM TX_MAIN_HT)"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Parameters.AddWithValue("@rollNumber", rollNumber);
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        private DataTable GetTXMAINTXPrevYearsData(string rollNumber)
        {
            string constr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(" SELECT SUM(TAX_LEVIED) as 'Tax Levied', SUM(PEN_DUE) as 'Penalty Due', SUM(OTHER_DUE) as 'Other Due', SUM(TAX_ADJ) as 'Tax Adjust', SUM(PEN_ADJ) as 'Penalty Adjust', SUM(OTHER_ADJ) as 'Other Adjustment' ,SUM(TAX_PAID) as 'Tax Paid', SUM(PEN_PAID) as 'Penalty Paid', SUM(OTHER_PAID) as 'Other Paid'  FROM TX_MAIN_HT WHERE ROLL_NO = @rollNumber AND HIS_YEAR <> (SELECT MAX(HIS_YEAR) -1 FROM TX_MAIN_HT) AND HIS_YEAR <> (SELECT MAX(HIS_YEAR) FROM TX_MAIN_HT)"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Parameters.AddWithValue("@rollNumber", rollNumber);
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        private DataTable GetAssessmentData(string rollNumber)
        {
            string constr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TX_ROLL_ASSESS WHERE ROLL_NO = @rollNumber AND ASS_YEAR = '2019'"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Parameters.AddWithValue("@rollNumber", rollNumber);
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        //protected void btnSearch1_Click(object sender, EventArgs e)
        //{
        //    DataTable dtRoll = this.GetTXROLLData(tbRollNumber.Text);
        //    DataTable dtMainHt = this.GetTXMAINTXMaxYearData(tbRollNumber.Text);
        //    DataTable dtMainHt2 = this.GetTXMAINTXPrevYearData(tbRollNumber.Text);
        //    DataTable dtMainHt3 = this.GetTXMAINTXPrevYearsData(tbRollNumber.Text);
        //    tbActivityNumber.Text = dtRoll.Rows[0][1].ToString();
        //    tbStreetNumber.Text = dtRoll.Rows[0][2].ToString();
        //    tbStreetName.Text = dtRoll.Rows[0][4].ToString();
        //    tbStreetUnit.Text = dtRoll.Rows[0][5].ToString();
        //    tbOwner1.Text = dtRoll.Rows[0][6].ToString();
        //    tbOwner2.Text = dtRoll.Rows[0][9].ToString();
        //    tbOwner3.Text = dtRoll.Rows[0][12].ToString();
        //    tbMailing1.Text = dtRoll.Rows[0][15].ToString();
        //    tbMailing2.Text = dtRoll.Rows[0][16].ToString();
        //    tbMailing3.Text = dtRoll.Rows[0][17].ToString();
        //    tbMailing4.Text = dtRoll.Rows[0][18].ToString();
        //    tbMailing5.Text = dtRoll.Rows[0][19].ToString();
        //    tbLegal1.Text = dtRoll.Rows[0][20].ToString();
        //    tbLegal2.Text = dtRoll.Rows[0][21].ToString();
        //    tbLegal3.Text = dtRoll.Rows[0][22].ToString();
        //    tbLegal4.Text = dtRoll.Rows[0][23].ToString();
        //    tbLegal5.Text = dtRoll.Rows[0][24].ToString();
        //    tbMortgageCode.Text = dtRoll.Rows[0][25].ToString();
        //    tbGroupCode.Text = dtRoll.Rows[0][39].ToString();


        //    tbYear1.Text = dtMainHt.Rows[0][0].ToString();
        //    tbYear2.Text = dtMainHt2.Rows[0][0].ToString();
        //    tbYear3.Text = "2017+";

        //    double taxLevied1 = double.Parse(dtMainHt.Rows[0][1].ToString());
        //    double taxLevied2 = double.Parse(dtMainHt2.Rows[0][1].ToString());
        //    double taxLevied3 = double.Parse(dtMainHt3.Rows[0][0].ToString());

        //    tbTaxLevied1.Text = String.Format("{0:C2}", taxLevied1);
        //    tbTaxLevied2.Text = String.Format("{0:C2}", taxLevied2);
        //    tbTaxLevied3.Text = String.Format("{0:C2}", taxLevied3);

        //    double penalty1 = (double.Parse(dtMainHt.Rows[0][2].ToString()) + double.Parse(dtMainHt.Rows[0][3].ToString()));
        //    double penalty2 = (double.Parse(dtMainHt2.Rows[0][2].ToString()) + double.Parse(dtMainHt2.Rows[0][3].ToString()));
        //    double penalty3 = (double.Parse(dtMainHt3.Rows[0][1].ToString()) + double.Parse(dtMainHt3.Rows[0][2].ToString()));

        //    tbPenalty1.Text = String.Format("{0:C2}", penalty1);
        //    tbPenalty2.Text = String.Format("{0:C2}", penalty2);
        //    tbPenalty3.Text = String.Format("{0:C2}", penalty3);

        //    double adjustment1 = (double.Parse(dtMainHt.Rows[0][4].ToString()) + double.Parse(dtMainHt.Rows[0][5].ToString()) + double.Parse(dtMainHt.Rows[0][6].ToString()));
        //    double adjustment2 = (double.Parse(dtMainHt2.Rows[0][4].ToString()) + double.Parse(dtMainHt2.Rows[0][5].ToString()) + double.Parse(dtMainHt2.Rows[0][6].ToString()));
        //    double adjustment3 = (double.Parse(dtMainHt3.Rows[0][3].ToString()) + double.Parse(dtMainHt3.Rows[0][4].ToString()) + double.Parse(dtMainHt3.Rows[0][5].ToString()));

        //    tbAdjustment1.Text = String.Format("{0:C2}", adjustment1);
        //    tbAdjustment2.Text = String.Format("{0:C2}", adjustment2);
        //    tbAdjustment3.Text = String.Format("{0:C2}", adjustment3);

        //    double payment1 = (double.Parse(dtMainHt.Rows[0][7].ToString()) + double.Parse(dtMainHt.Rows[0][8].ToString()) + double.Parse(dtMainHt.Rows[0][9].ToString()));
        //    double payment2 = (double.Parse(dtMainHt2.Rows[0][7].ToString()) + double.Parse(dtMainHt2.Rows[0][8].ToString()) + double.Parse(dtMainHt2.Rows[0][9].ToString()));
        //    double payment3 = (double.Parse(dtMainHt3.Rows[0][6].ToString()) + double.Parse(dtMainHt3.Rows[0][7].ToString()) + double.Parse(dtMainHt3.Rows[0][8].ToString()));
        //    tbPayment1.Text = String.Format("{0:C2}", payment1);
        //    tbPayment2.Text = String.Format("{0:C2}", payment2);
        //    tbPayment3.Text = String.Format("{0:C2}", payment3);

        //    tbBalance1.Text = String.Format("{0:C2}", (taxLevied1 + penalty1 + adjustment1) - payment1);
        //    tbBalance2.Text = String.Format("{0:C2}", (taxLevied2 + penalty2 + adjustment2) - payment2);
        //    tbBalance3.Text = String.Format("{0:C2}", (taxLevied3 + penalty3 + adjustment3) - payment3);
        //    //tbBalance2.Text = ((double.Parse(tbTaxLevied2.Text) + double.Parse(tbPenalty2.Text) + double.Parse(tbAdjustment2.Text)) - double.Parse(tbPayment2.Text)).ToString();
        //    //tbBalance3.Text = ((double.Parse(tbTaxLevied3.Text) + double.Parse(tbPenalty3.Text) + double.Parse(tbAdjustment3.Text)) - double.Parse(tbPayment3.Text)).ToString();
        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dtRoll = this.GetTXROLLData(tbRollNumber.Text);
            DataTable dtMainHt = this.GetTXMAINTXMaxYearData(tbRollNumber.Text);
            DataTable dtMainHt2 = this.GetTXMAINTXPrevYearData(tbRollNumber.Text);
            DataTable dtMainHt3 = this.GetTXMAINTXPrevYearsData(tbRollNumber.Text);
            DataTable dtAssessment = this.GetAssessmentData(tbRollNumber.Text);
            tbActivityNumber.Text = dtRoll.Rows[0][1].ToString();
            tbStreetNumber.Text = dtRoll.Rows[0][2].ToString();
            tbStreetName.Text = dtRoll.Rows[0][4].ToString();
            tbStreetUnit.Text = dtRoll.Rows[0][5].ToString();
            tbOwner1.Text = dtRoll.Rows[0][6].ToString();
            tbOwner2.Text = dtRoll.Rows[0][9].ToString();
            tbOwner3.Text = dtRoll.Rows[0][12].ToString();
            tbMailing1.Text = dtRoll.Rows[0][15].ToString();
            tbMailing2.Text = dtRoll.Rows[0][16].ToString();
            tbMailing3.Text = dtRoll.Rows[0][17].ToString();
            tbMailing4.Text = dtRoll.Rows[0][18].ToString();
            tbMailing5.Text = dtRoll.Rows[0][19].ToString();
            tbLegal1.Text = dtRoll.Rows[0][20].ToString();
            tbLegal2.Text = dtRoll.Rows[0][21].ToString();
            tbLegal3.Text = dtRoll.Rows[0][22].ToString();
            tbLegal4.Text = dtRoll.Rows[0][23].ToString();
            tbLegal5.Text = dtRoll.Rows[0][24].ToString();
            tbMortgageCode.Text = dtRoll.Rows[0][25].ToString();
            tbGroupCode.Text = dtRoll.Rows[0][39].ToString();

            var verticalHeight = 0;
            foreach(DataRow row in dtAssessment.Rows)
            {
                TextBox textboxcode = new TextBox();
                TextBox textbox = new TextBox();
                textbox.Location = new Point(110, verticalHeight);
                textboxcode.Location = new Point(0, verticalHeight);
                textboxcode.Text = row[3].ToString();
                textbox.Text = row[4].ToString();
                this.pnlAssessment.Controls.Add(textbox);
                this.pnlAssessment.Controls.Add(textboxcode);
                verticalHeight = verticalHeight + 25;
            }
            //tbAssessmentCode1.Text = dtAssessment.Rows[0][3].ToString();
            //tbAssessmentCode2.Text = dtAssessment.Rows[0][0].ToString();
            //tbAssessmentCode3.Text = dtAssessment.Rows[0][0].ToString();
            //tbAssessment1.Text = dtAssessment.Rows[0][4].ToString();
            //tbAssessment2.Text = dtAssessment.Rows[0][0].ToString();
            //tbAssessment3.Text = dtAssessment.Rows[0][0].ToString();

          


            tbYear1.Text = dtMainHt.Rows[0][0].ToString();
            tbYear2.Text = dtMainHt2.Rows[0][0].ToString();
            tbYear3.Text = "2017+";

            double taxLevied1 = double.Parse(dtMainHt.Rows[0][1].ToString());
            double taxLevied2 = double.Parse(dtMainHt2.Rows[0][1].ToString());
            double taxLevied3 = double.Parse(dtMainHt3.Rows[0][0].ToString());

            tbTaxLevied1.Text = String.Format("{0:C2}", taxLevied1);
            tbTaxLevied2.Text = String.Format("{0:C2}", taxLevied2);
            tbTaxLevied3.Text = String.Format("{0:C2}", taxLevied3);

            double penalty1 = (double.Parse(dtMainHt.Rows[0][2].ToString()) + double.Parse(dtMainHt.Rows[0][3].ToString()));
            double penalty2 = (double.Parse(dtMainHt2.Rows[0][2].ToString()) + double.Parse(dtMainHt2.Rows[0][3].ToString()));
            double penalty3 = (double.Parse(dtMainHt3.Rows[0][1].ToString()) + double.Parse(dtMainHt3.Rows[0][2].ToString()));

            tbPenalty1.Text = String.Format("{0:C2}", penalty1);
            tbPenalty2.Text = String.Format("{0:C2}", penalty2);
            tbPenalty3.Text = String.Format("{0:C2}", penalty3);

            double adjustment1 = (double.Parse(dtMainHt.Rows[0][4].ToString()) + double.Parse(dtMainHt.Rows[0][5].ToString()) + double.Parse(dtMainHt.Rows[0][6].ToString()));
            double adjustment2 = (double.Parse(dtMainHt2.Rows[0][4].ToString()) + double.Parse(dtMainHt2.Rows[0][5].ToString()) + double.Parse(dtMainHt2.Rows[0][6].ToString()));
            double adjustment3 = (double.Parse(dtMainHt3.Rows[0][3].ToString()) + double.Parse(dtMainHt3.Rows[0][4].ToString()) + double.Parse(dtMainHt3.Rows[0][5].ToString()));

            tbAdjustment1.Text = String.Format("{0:C2}", adjustment1);
            tbAdjustment2.Text = String.Format("{0:C2}", adjustment2);
            tbAdjustment3.Text = String.Format("{0:C2}", adjustment3);

            double payment1 = (double.Parse(dtMainHt.Rows[0][7].ToString()) + double.Parse(dtMainHt.Rows[0][8].ToString()) + double.Parse(dtMainHt.Rows[0][9].ToString()));
            double payment2 = (double.Parse(dtMainHt2.Rows[0][7].ToString()) + double.Parse(dtMainHt2.Rows[0][8].ToString()) + double.Parse(dtMainHt2.Rows[0][9].ToString()));
            double payment3 = (double.Parse(dtMainHt3.Rows[0][6].ToString()) + double.Parse(dtMainHt3.Rows[0][7].ToString()) + double.Parse(dtMainHt3.Rows[0][8].ToString()));
            tbPayment1.Text = String.Format("{0:C2}", payment1);
            tbPayment2.Text = String.Format("{0:C2}", payment2);
            tbPayment3.Text = String.Format("{0:C2}", payment3);

            tbBalance1.Text = String.Format("{0:C2}", (taxLevied1 + penalty1 + adjustment1) - payment1);
            tbBalance2.Text = String.Format("{0:C2}", (taxLevied2 + penalty2 + adjustment2) - payment2);
            tbBalance3.Text = String.Format("{0:C2}", (taxLevied3 + penalty3 + adjustment3) - payment3);
            //tbBalance2.Text = ((double.Parse(tbTaxLevied2.Text) + double.Parse(tbPenalty2.Text) + double.Parse(tbAdjustment2.Text)) - double.Parse(tbPayment2.Text)).ToString();
            //tbBalance3.Text = ((double.Parse(tbTaxLevied3.Text) + double.Parse(tbPenalty3.Text) + double.Parse(tbAdjustment3.Text)) - double.Parse(tbPayment3.Text)).ToString();
        }
    }
}
