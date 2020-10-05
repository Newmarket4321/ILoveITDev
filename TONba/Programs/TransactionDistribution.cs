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
    public partial class TransactionDistribution : Form
    {
        public TransactionDistribution()
        {
            InitializeComponent();

            Transactions transactions = new Transactions();
            tbRollNumber.Text = Transactions.rollNumber;
            search();
        }

        private DataTable GetData(string rollNumber, string origin)
        {
            string constr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TX_HISTORY_DIST WHERE ROLL_NO = @rollNumber AND ORIGIN = @origin" ))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Parameters.AddWithValue("@rollNumber", rollNumber);
                        cmd.Parameters.AddWithValue("@origin", rollNumber);
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

        private void search()
        {
            
            //DataTable dtHeader = this.GetHeaderData(tbRollNumber.Text);
            //DataTable table = new DataTable();
            DataTable table = Transactions.dtHeader;
            DataGridViewRow row = Transactions.row;
            DataTable dt = this.GetData(tbRollNumber.Text, row.Cells["ORIGIN"].ToString());

            tbActivityNumber.Text = table.Rows[0]["ACTIVITY_NO"].ToString();
            tbOwner1.Text = table.Rows[0]["OWNER_1"].ToString();
            tbOwner2.Text = table.Rows[0]["OWNER_2"].ToString();
            tbOwner3.Text = table.Rows[0]["OWNER_3"].ToString();
            tbStreetNumber.Text = table.Rows[0]["STREET_NO"].ToString();
            tbStreetQual.Text = table.Rows[0]["STREET_QUAL"].ToString();
            tbStreetName.Text = table.Rows[0]["STREET_NAME"].ToString();
            tbStreetUnit.Text = table.Rows[0]["STREET_UNIT"].ToString();


            //tbActivityNumber.Text = table.Cells["ACTIVITY_NO"].Value.ToString();
            //tbOwner1.Text = table.Cells["OWNER_1"].Value.ToString();
            //tbOwner2.Text = table.Cells["OWNER_2"].Value.ToString();
            //tbOwner3.Text = table.Cells["OWNER_3"].Value.ToString();
            //tbStreetNumber.Text = table.Cells["STREET_NO"].Value.ToString();
            //tbStreetQual.Text = table.Cells["STREET_QUAL"].Value.ToString();
            //tbStreetName.Text = row.Cells["STREET_NAME"].Value.ToString();
            //tbStreetUnit.Text = row.Cells["STREET_UNIT"].Value.ToString();

            dgTransactionDistributions.DataSource = dt;
        }
    }


}
