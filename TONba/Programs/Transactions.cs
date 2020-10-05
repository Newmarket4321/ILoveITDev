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
    public partial class Transactions : Form
    {

        public static string rollNumber = "";
        public static DataGridViewRow row;
        public static DataTable dtHeader;
        public Transactions()
        {
            InitializeComponent();
            dgTransactions.CellClick += new DataGridViewCellEventHandler(dgTransactionsRow_click);
        }

        private DataTable GetData(string rollNumber)
        {
            string constr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TX_HISTORY WHERE ROLL_NO = @rollNumber ORDER BY DUE_DATE DESC"))
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

        private DataTable GetHeaderData(string rollNumber)
        {
            string constr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT TOP (1) txh.[ROLL_NO], [OWNER_1], [OWNER_2], [OWNER_3], txr.[ACTIVITY_NO],[STREET_NO],[STREET_QUAL],[STREET_NAME],[STREET_UNIT] FROM [VailtechHistory].[dbo].[TX_HISTORY] as txh inner join [VailtechHistory].[dbo].[TX_ROLL] as txr ON txr.ROLL_NO = txh.ROLL_NO where txh.ROLL_NO = @rollNumber"))
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

        private void dgTransactionsRow_click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            row = dgTransactions.Rows[rowIndex];
            TransactionDistribution transaction = new TransactionDistribution();
            transaction.Show();
            //textBox5.Text = dataGridView1.Rows[1].Cells[1].Value.ToString();// row.Cells[1].Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = this.GetData(tbRollNumber.Text);
            dtHeader = this.GetHeaderData(tbRollNumber.Text);
            DataTable table = new DataTable();

        
            tbActivityNumber.Text = dtHeader.Rows[0]["ACTIVITY_NO"].ToString();
            tbOwner1.Text = dtHeader.Rows[0]["OWNER_1"].ToString();
            tbOwner2.Text = dtHeader.Rows[0]["OWNER_2"].ToString();
            tbOwner3.Text = dtHeader.Rows[0]["OWNER_3"].ToString();
            tbStreetNumber.Text = dtHeader.Rows[0]["STREET_NO"].ToString();
            tbStreetQual.Text = dtHeader.Rows[0]["STREET_QUAL"].ToString();
            tbStreetName.Text = dtHeader.Rows[0]["STREET_NAME"].ToString();
            tbStreetUnit.Text = dtHeader.Rows[0]["STREET_UNIT"].ToString();

            rollNumber = tbRollNumber.Text;

            dgTransactions.DataSource = dt;

        }

        //protected void btnSearch_Click(object sender, EventArgs e)
        //{
        //    DataTable dt = this.GetData(tbRollNumber.Text);
        //    DataTable dtHeader = this.GetHeaderData(tbRollNumber.Text);

        //    tbActivityNumber.Text = dtHeader.Rows[0]["ACTIVITY_NO"].ToString();
        //    tbOwner1.Text = dtHeader.Rows[0]["OWNER_1"].ToString();
        //    tbOwner2.Text = dtHeader.Rows[0]["OWNER_2"].ToString();
        //    tbOwner3.Text = dtHeader.Rows[0]["OWNER_3"].ToString();
        //    tbStreetNumber.Text = dtHeader.Rows[0]["STREET_NO"].ToString();
        //    tbStreetQual.Text = dtHeader.Rows[0]["STREET_QUAL"].ToString();
        //    tbStreetName.Text = dtHeader.Rows[0]["STREET_NAME"].ToString();
        //    tbStreetUnit.Text = dtHeader.Rows[0]["STREET_UNIT"].ToString();

        //    ////Building an HTML string.
        //    //StringBuilder html = new StringBuilder();

        //    ////Table start.
        //    //html.Append("<table class='table table-striped'>");
        //    //html.Append("<thead>");

        //    ////Building the Header row.
        //    //html.Append("<tr>");
        //    //foreach (DataColumn column in dt.Columns)
        //    //{
        //    //    html.Append("<th scope='col'>");
        //    //    html.Append(column.ColumnName);
        //    //    html.Append("</th>");
        //    //}
        //    //html.Append("</tr>");
        //    //html.Append("</thead>");
        //    ////Building the Data rows.
        //    //html.Append("<tbody>");
        //    //foreach (DataRow row in dt.Rows)
        //    //{
        //    //    html.Append("<tr>");
        //    //    foreach (DataColumn column in dt.Columns)
        //    //    {
        //    //        html.Append("<td>");
        //    //        html.Append(row[column.ColumnName]);
        //    //        html.Append("</td>");
        //    //    }
        //    //    html.Append("</tr>");
        //    //}
        //    //html.Append("</tbody>");
        //    ////Table end.
        //    //html.Append("</table>");
        //    //string strText = html.ToString();

        //    //////Append the HTML string to Placeholder.
        //    //placeholder.Controls.Add(new Literal { Text = html.ToString() });

        //}
    }
}
