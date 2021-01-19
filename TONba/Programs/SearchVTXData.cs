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
    public partial class SearchVTXData : Form
    {
        DataTable dt = null;

        private void button2_Click(object sender, EventArgs e)
        {
            ReportVTXData rpt = new ReportVTXData(textBox1.Text, dtpTo.Value.Date);
            rpt.ShowDialog();
        }

        private void chkLoc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLoc.Checked == true)
            {
                chkRoll.Checked = false;
                chkOwn.Checked = false;
               
                textBox1.Enabled = false;
                LocationText.Enabled = true;
                OwnerText.Enabled = false;
                OwnerText.Text = "";
                textBox1.Text = "";
            }
        }

        private void chkOwn_CheckedChanged(object sender, EventArgs e)
        {

                if (chkOwn.Checked == true)
                {
                    chkRoll.Checked = false;
                    chkLoc.Checked = false;
                    textBox1.Enabled = false;
                    LocationText.Enabled = false;
                    OwnerText.Enabled = true;
                    LocationText.Text = "";
                    textBox1.Text = "";
            }

        }

        private void chkRoll_CheckedChanged(object sender, EventArgs e)
        {

                if (chkRoll.Checked == true)
                {
                    chkLoc.Checked = false;
                    chkOwn.Checked = false;
                    
                    LocationText.Enabled = false;
                    OwnerText.Enabled = false;
                    LocationText.Text = "";
                    OwnerText.Text = "";
                textBox1.Enabled = true;
            }

        }

        public SearchVTXData()
        {
            InitializeComponent();
            chkLoc.Enabled = true;
            chkOwn.Enabled = true;
            chkRoll.Enabled = true;
            if (chkRoll.Checked == true)
            {
                LocationText.Enabled = false;
                OwnerText.Enabled = false;
            }

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string sRoll, sOwner;

            if (chkOwn.Checked == true)
            {
                sOwner = OwnerText.Text+"%";
                dt = SQL.Run(@"select street_no, street_name, owner_1, owner_2, mailing1, mailing2, mailing3, mailing4, mailing5,legal1, legal2,legal3,roll_no  from vtx.vailtech.tx_roll where owner_1 like @sOwner or owner_2 like @sOwner ", sOwner);
                if (dt.Rows.Count > 0)
                {
                    SearchCombo scbo = new SearchCombo(dt, 2);
                    scbo.Show();
                }
                        
            }

            if (chkLoc.Checked == true)
            {
                sOwner = LocationText.Text + "%";
                dt = SQL.Run(@"select street_no, street_name, owner_1, owner_2, mailing1, mailing2, mailing3, mailing4, mailing5,legal1, legal2,legal3,roll_no  from vtx.vailtech.tx_roll where street_name like @sOwner ", sOwner);
                if (dt.Rows.Count > 0)
                {
                    SearchCombo scbo = new SearchCombo(dt, 1);
                    scbo.Show();
                    sRoll = scbo.itemSelected;
                }

            }

            if (chkRoll.Checked == true)
            { 
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please enter a roll number.");
                    return;
                }
                else
                {
                    sRoll = textBox1.Text;
                    dt = SQL.Run(@"select street_no, street_name, owner_1, owner_2, mailing1, mailing2, mailing3, mailing4, mailing5,legal1, legal2,legal3  from vtx.vailtech.tx_roll where roll_no =  @sRoll", sRoll);

                    if (dt.Rows.Count > 0)
                    {
                        LocationText.Text = dt.Rows[0]["street_no"].ToString() + " " + dt.Rows[0]["street_name"].ToString();
                        OwnerText.Text = dt.Rows[0]["Owner_1"].ToString() + " " + dt.Rows[0]["Owner_2"].ToString();
                        button2.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("There are no matching accounts with this roll number");
                        button2.Enabled = false;
                    }
                }
            }
          
        }

  
    }
}
