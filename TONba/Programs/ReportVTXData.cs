using I_IT.Properties;
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
    public partial class ReportVTXData : Form
    {
        DataTable storage = null;
        Printer queue = new Printer();


        public ReportVTXData(string title, DateTime Transdate)
        {
            InitializeComponent();
            double tbalance = 0;
            double nAmount = 0;
            DateTime uptoDate = Transdate.AddDays(-1);

            DataTable dtMainHt = this.GetTXMAINTXMaxYearData(title);
            DataTable dtMainHt2 = this.GetTXMAINTXPrevYearData(title);
            DataTable dtMainHt3 = this.GetTXMAINTXNextYearData(title);
            DataTable dtMainHt4 = this.GetTXMAINTXMidYearData(title);
            DataTable dtMainHt5 = this.GetTXMAINTXPrevYearsData(title);
            DataTable dtAssessment = this.GetAssessmentData(title);

            label6.Text = title;
            label1.Text = DateTime.Now.ToString().Substring(0, 10);

            //Header Data
            DataTable dt = SQL.Run(@"select street_no, street_name, owner_1, owner_2, mailing1, mailing2, mailing3, mailing4, mailing5,legal1, legal2,legal3  from vtx.vailtech.tx_roll where roll_no =  @title", title);

            if (dt.Rows.Count > 0)
            {

                label9.Text = dt.Rows[0]["street_no"].ToString() + " " + dt.Rows[0]["street_name"].ToString();
                label13.Text = dt.Rows[0]["owner_1"].ToString();
                label14.Text = dt.Rows[0]["owner_2"].ToString();
                label15.Text = dt.Rows[0]["mailing1"].ToString() + " " + dt.Rows[0]["mailing2"].ToString();
                label16.Text = dt.Rows[0]["mailing3"].ToString() + " " + dt.Rows[0]["mailing4"].ToString() + " " + dt.Rows[0]["mailing5"].ToString();

                label18.Text = dt.Rows[0]["owner_1"].ToString();
                label19.Text = dt.Rows[0]["owner_2"].ToString();
            }
            //Transaction Summary

            listHeader.Columns.Add("Year");
            listHeader.Columns[0].TextAlign = HorizontalAlignment.Right;
            listHeader.Columns.Add("Tax Levied");
            listHeader.Columns[1].TextAlign = HorizontalAlignment.Right;
            listHeader.Columns.Add("Penalty/Interest");
            listHeader.Columns[2].TextAlign = HorizontalAlignment.Right;
            listHeader.Columns.Add("Adjustments");
            listHeader.Columns[3].TextAlign = HorizontalAlignment.Right;
            listHeader.Columns.Add("Payments");
            listHeader.Columns[4].TextAlign = HorizontalAlignment.Right;
            listHeader.Columns.Add("Balance");
            listHeader.Columns[5].TextAlign = HorizontalAlignment.Right;

            tbalance = tbalance + TransSummary(dtMainHt);
            tbalance = tbalance + TransSummary(dtMainHt2);
            tbalance = tbalance + TransSummary(dtMainHt3);
            tbalance = tbalance + TransSummary(dtMainHt4);
            tbalance = tbalance + TransSummary(dtMainHt5);


            // Detail Data
            lblAccBalance.Text = String.Format( "{0:0,0.00}",tbalance);
            DataTable dt2 = SQL.Run(@"SELECT  due_date as DueDate, Origin, receipt_no as ReceiptNo, '' as debit, '' as credit, 0 as Balance , Reference, post_date as PostDate,amount FROM vtx.vailtech.TX_HISTORY WHERE ROLL_NO = @title and due_date > @uptoDate  ORDER BY DUE_DATE DESC", title, uptoDate);
            //DataTable dt2 = SQL.Run(@"SELECT  due_date as DueDate, Origin, receipt_no as ReceiptNo, '' as debit, '' as credit, 0 as Balance , Reference, post_date as PostDate,amount FROM vtx.vailtech.TX_HISTORY WHERE ROLL_NO = @title and (year(POST_DATE))>2017  ORDER BY DUE_DATE DESC", title);
            // DataTable dt2 = SQL.Run(@"SELECT  due_date as DueDate, Origin, receipt_no as ReceiptNo, '' as debit, '' as credit, 0 as Balance , Reference, post_date as PostDate,amount FROM vtx.vailtech.TX_HISTORY WHERE ROLL_NO = @title ORDER BY DUE_DATE DESC", title);
            if (dt2.Rows.Count > 0)
            {


                for (int i = 0; i < dt2.Columns.Count - 1; i++)
                {
                    list.Columns.Add(dt2.Columns[i].ColumnName);
                    list.Columns[i].TextAlign = HorizontalAlignment.Right;
                }
                string[] dataS = new string[dt2.Columns.Count];

                for (int i = 0; i < dt2.Rows.Count; i++)
                {

                    tbalance = tbalance - nAmount;

                    for (int j = 0; j < dt2.Columns.Count; j++)
                    {
                        dataS[j] = dt2.Rows[i][j].ToString();
                        if (j == 0)
                            dataS[j] = dt2.Rows[i][j].ToString().Substring(0, 10);
                        if (j == 7)
                            dataS[j] = dt2.Rows[i][j].ToString().Substring(0, 10);


                        if (j == 8 && decimal.Parse(dataS[8].Trim()) > 0)
                        {
                            dataS[3] = dataS[8];
                            nAmount = double.Parse(dt2.Rows[i][j].ToString());
                        }

                        if (j == 8 && decimal.Parse(dataS[8].Trim()) < 0)
                        { 
                            dataS[4] = dataS[8];
                            nAmount = double.Parse(dt2.Rows[i][j].ToString());
                        }
                    }
                    dataS[5] = String.Format("{0:0,0.00}", tbalance);
                    ListViewItem x = new ListViewItem(dataS);
                    list.Items.Add(x);
                }
 
            }
            Core.log("ReportVTXData", "Report", "roll_no:" + title);
        }


        private Double TransSummary(DataTable dtSummary)

        {
            double dbalance = 0;
            string[] data = new string[6];
            // Account balance information
            if (dtSummary.Rows.Count > 0)
            {


                for (int j = 0; j < dtSummary.Columns.Count ; j++)
                {
                    switch (j)
                    {
                        case 3:
                            dbalance = dtSummary.Rows[0][j].ToString()==""?0:Convert.ToDouble(data[2]) + double.Parse(dtSummary.Rows[0][j].ToString());
                            //      data[2] = dbalance.ToString();
                            data[2] = String.Format("{0:0,0.00}", dbalance);

                            break;
                        case 4:
                            dbalance = dtSummary.Rows[0][j].ToString()==""?0:Convert.ToDouble(data[3]) + double.Parse(dtSummary.Rows[0][j].ToString());
                            data[3] = String.Format("{0:0,0.00}", dbalance);
                            break;
                        case 5:
                            dbalance = dtSummary.Rows[0][j].ToString()==""?0:Convert.ToDouble(data[3]) + double.Parse(dtSummary.Rows[0][j].ToString());
                            data[3] = String.Format("{0:0,0.00}", dbalance);
                            break;
                        case 6:
                            dbalance = dtSummary.Rows[0][j].ToString()==""?0:Convert.ToDouble(data[3]) + double.Parse(dtSummary.Rows[0][j].ToString());
                            data[3] = String.Format("{0:0,0.00}", dbalance);
                            break;
                        case 7:
                            dbalance = dtSummary.Rows[0][j].ToString()==""?0:Convert.ToDouble(data[4]) + double.Parse(dtSummary.Rows[0][j].ToString());
                            data[4] = String.Format("{0:0,0.00}", dbalance);
                            break;
                        case 8:
                            dbalance = dtSummary.Rows[0][j].ToString()==""?0:Convert.ToDouble(data[4]) + double.Parse(dtSummary.Rows[0][j].ToString());
                            data[4] = String.Format("{0:0,0.00}", dbalance);
                            break;
                        case 9:
                            dbalance = dtSummary.Rows[0][j].ToString()==""?0:Convert.ToDouble(data[4]) + double.Parse(dtSummary.Rows[0][j].ToString());
                            data[4] = String.Format("{0:0,0.00}", dbalance);
                            break;
                        default:
                            data[j] = dtSummary.Rows[0][j].ToString();
                            break;
                    }

                }

                dbalance = (dtSummary.Rows[0][1].ToString()==""?0:double.Parse(dtSummary.Rows[0][1].ToString()) +
                    dtSummary.Rows[0][2].ToString()==""?0:double.Parse(dtSummary.Rows[0][2].ToString()) + dtSummary.Rows[0][3].ToString()==""?0:double.Parse(dtSummary.Rows[0][3].ToString()) +
                    dtSummary.Rows[0][4].ToString()==""?0:double.Parse(dtSummary.Rows[0][4].ToString()) + dtSummary.Rows[0][5].ToString()==""?0:double.Parse(dtSummary.Rows[0][5].ToString()) +
                    dtSummary.Rows[0][6].ToString()==""?0:double.Parse(dtSummary.Rows[0][6].ToString())) - (dtSummary.Rows[0][7].ToString()==""?0:double.Parse(dtSummary.Rows[0][7].ToString()) +
                    dtSummary.Rows[0][8].ToString()==""?0:double.Parse(dtSummary.Rows[0][8].ToString()) + dtSummary.Rows[0][9].ToString()==""?0:double.Parse(dtSummary.Rows[0][9].ToString()));

                data[5] = String.Format("{0:0,0.00}", dbalance);

                ListViewItem y = new ListViewItem(data);
                listHeader.Items.Add(y);
            }

 
            return dbalance;

        }

        private void Report_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Core.export(Text, storage);
        }


        private DataTable GetTXMAINTXMaxYearData(string rollNumber)
        {
            DataTable dtMain = SQL.Run(@"SELECT HIS_YEAR, TAX_LEVIED as 'Tax Levied', PEN_DUE as 'Penalty Due', OTHER_DUE as 'Other Due', TAX_ADJ as 'Tax Adjust', PEN_ADJ as 'Penalty Adjust', OTHER_ADJ as 'Other Adjustment', TAX_PAID as 'Tax Paid', PEN_PAID as 'Penalty Paid', OTHER_PAID as 'Other Paid' FROM [vtx].[VAILTECH].[TX_MAINHT] WHERE ROLL_NO = @rollNumber AND HIS_YEAR = (SELECT MAX(HIS_YEAR) FROM [vtx].[VAILTECH].[TX_MAINHT] WHERE ROLL_NO = @rollNumber)", rollNumber);
            return dtMain;
        }

        private DataTable GetTXMAINTXPrevYearData(string rollNumber)

        {
            DataTable dtMain = SQL.Run(@"SELECT HIS_YEAR, TAX_LEVIED as 'Tax Levied', PEN_DUE as 'Penalty Due', OTHER_DUE as 'Other Due', TAX_ADJ as 'Tax Adjust', PEN_ADJ as 'Penalty Adjust', OTHER_ADJ as 'Other Adjustment', TAX_PAID as 'Tax Paid', PEN_PAID as 'Penalty Paid', OTHER_PAID as 'Other Paid' FROM [vtx].[VAILTECH].[TX_MAINHT] WHERE ROLL_NO = @rollNumber AND HIS_YEAR = (SELECT MAX(HIS_YEAR)-1 FROM [vtx].[VAILTECH].[TX_MAINHT] WHERE ROLL_NO = @rollNumber)", rollNumber);
            return dtMain;
        }

        private DataTable GetTXMAINTXNextYearData(string rollNumber)

        {
            DataTable dtMain = SQL.Run(@"SELECT HIS_YEAR, TAX_LEVIED as 'Tax Levied', PEN_DUE as 'Penalty Due', OTHER_DUE as 'Other Due', TAX_ADJ as 'Tax Adjust', PEN_ADJ as 'Penalty Adjust', OTHER_ADJ as 'Other Adjustment', TAX_PAID as 'Tax Paid', PEN_PAID as 'Penalty Paid', OTHER_PAID as 'Other Paid' FROM [vtx].[VAILTECH].[TX_MAINHT] WHERE ROLL_NO = @rollNumber AND HIS_YEAR = (SELECT MAX(HIS_YEAR)-2 FROM [vtx].[VAILTECH].[TX_MAINHT] WHERE ROLL_NO = @rollNumber)", rollNumber);
            return dtMain;
        }

        private DataTable GetTXMAINTXMidYearData(string rollNumber)

        {
            DataTable dtMain = SQL.Run(@"SELECT HIS_YEAR, TAX_LEVIED as 'Tax Levied', PEN_DUE as 'Penalty Due', OTHER_DUE as 'Other Due', TAX_ADJ as 'Tax Adjust', PEN_ADJ as 'Penalty Adjust', OTHER_ADJ as 'Other Adjustment', TAX_PAID as 'Tax Paid', PEN_PAID as 'Penalty Paid', OTHER_PAID as 'Other Paid' FROM [vtx].[VAILTECH].[TX_MAINHT] WHERE ROLL_NO = @rollNumber AND HIS_YEAR = (SELECT MAX(HIS_YEAR)-3 FROM [vtx].[VAILTECH].[TX_MAINHT] WHERE ROLL_NO = @rollNumber)", rollNumber);
            return dtMain;
        }
        private DataTable GetTXMAINTXPrevYearsData(string rollNumber)
        {
            DataTable dtMain = SQL.Run(@"SELECT '< 2015' HIS_YEAR,SUM(TAX_LEVIED) as 'Tax Levied', SUM(PEN_DUE) as 'Penalty Due', SUM(OTHER_DUE) as 'Other Due', SUM(TAX_ADJ) as 'Tax Adjust', SUM(PEN_ADJ) as 'Penalty Adjust', SUM(OTHER_ADJ) as 'Other Adjustment' ,SUM(TAX_PAID) as 'Tax Paid', SUM(PEN_PAID) as 'Penalty Paid', SUM(OTHER_PAID) as 'Other Paid'  FROM [vtx].[VAILTECH].[TX_MAINHT] WHERE ROLL_NO = @rollNumber AND HIS_YEAR < (SELECT MAX(HIS_YEAR) -4 FROM [vtx].[VAILTECH].[TX_MAINHT] WHERE ROLL_NO = @rollNumber) ", rollNumber);
            return dtMain;

        }

        private DataTable GetAssessmentData(string rollNumber)
        {
            DataTable dtMain = SQL.Run(@"SELECT * FROM  [vtx].[VAILTECH].[TX_ROLL_ASSESS] WHERE ROLL_NO = @rollNumber AND ASS_YEAR = '2019'", rollNumber);
            return dtMain;

        }



        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int buffer = 10;
            int pCt = 1;

            AddTitle(pCt);
           
            queue.AddBold(label10.Text, 300);
            queue.Add(label9.Text, 450);
            queue.AddLine();

            queue.AddBold(label11.Text, 300);
            queue.Add(label12.Text, 450);
            queue.AddLine();
            //Owner
            queue.Add(label13.Text, 10);
            queue.AddBold(label17.Text, 300);
            queue.Add(label18.Text, 450);

            queue.AddLine();
            queue.Add(label14.Text, 10);
            queue.Add(label19.Text, 450);

            queue.AddLine();
            queue.Add(label15.Text, 10);

            queue.AddLine();
            queue.Add(label16.Text, 10);

            //           queue.AddBold("Account Balance: " +lblAccBalance.Text,450) ;
            queue.AddBold(String.Format("Account Balance: "+ lblAccBalance.Text), 450);

            queue.AddLine();
            queue.AddLine();

            // Transaction Summary

            queue.AddDivider();

            queue.font = new Font("Times New Roman", 16);

            queue.AddBold("Account Balance Information:", 10);
            queue.font = new Font("Times New Roman", 11);

            queue.AddLine();
            queue.AddLine();
            float[] columnTS = new float[listHeader.Columns.Count];

            columnTS[0] = 70;
            columnTS[1] = 90;
            columnTS[2] = 100;
            columnTS[3] = 100;
            columnTS[4] = 100;
            columnTS[5] = 150;

            int x = 0;
            for (int c = 0; c < listHeader.Columns.Count; c++)
            {
                queue.AddBold(listHeader.Columns[c].Text, x);

                x += (int)columnTS[c] + buffer;
            }

            queue.AddLine();

            for (int r = 0; r < listHeader.Items.Count; r++)
            {
                x = 0;
                for (int c = 0; c < listHeader.Columns.Count; c++)
                {
                    queue.Add(listHeader.Items[r].SubItems[c].Text.Trim(), x);

                    x += (int)columnTS[c] + buffer;
                }
                queue.AddLine();
            }


            queue.AddLine();

            //Detail

            queue.font = new Font("Times New Roman", 16);

            queue.AddBold("Transactions:", 10);
            queue.font = new Font("Times New Roman", 11);

            queue.AddLine();
            queue.AddLine();

            float[] columnWidths = new float[list.Columns.Count];

            columnWidths[0] = 70;
            columnWidths[1] = 60;
            columnWidths[2] = 80;
            columnWidths[3] = 80;
            columnWidths[4] = 80;
            columnWidths[5] = 100;
            columnWidths[6] = 80;
            columnWidths[7] = 50;

   
            x = 0;
            for (int c = 0; c < list.Columns.Count; c++)
            {
                queue.AddBold(list.Columns[c].Text, x);

                x += (int)columnWidths[c] + buffer;
            }

            queue.AddLine();

            for (int r = 0; r < list.Items.Count; r++)
            {
                x = 0;
                for (int c = 0; c < list.Columns.Count; c++)
                {
                    queue.Add(list.Items[r].SubItems[c].Text.Trim(), x);

                    x += (int)columnWidths[c] + buffer;
                }
                queue.AddLine();
                if (r == 27 || r ==74 || r ==121) // Page break
                {
                    queue.AddLine();
                    queue.AddLine();
                    pCt++;
                    AddTitle(pCt);
                }
            }

            queue.Print();
        }
        private void AddTitle(int PageNumber)
        {

            queue.font = new Font("Times New Roman", 16);

            queue.AddBold(label2.Text, 240);
            queue.font = new Font("Times New Roman", 11);
            queue.Add("Page : " + PageNumber.ToString(), 650);

            queue.AddLine();
            queue.AddLine();

            queue.AddBold("Roll Number", 2);
            queue.Add(label6.Text, 100);
            queue.Add(label8.Text, 330);
            queue.Add(label1.Text, 620);


            queue.AddLine();
            queue.AddDivider();

            queue.AddItalics(label7.Text, 10); // This statement....
            queue.AddLine();
            queue.AddLine();


        }
    }
}
