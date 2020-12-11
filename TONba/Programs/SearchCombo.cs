using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace I_IT
{
    public partial class SearchCombo : Form
    {
       public string itemSelected { get; set; }

        public  SearchCombo(DataTable dtCombo,int opt)
        {
            InitializeComponent();
            ArrayList alData = new ArrayList();

   

            if (dtCombo.Rows.Count > 0)
            {
                if (opt == 1) // Search by address
                {
                    for (int i = 0; i < dtCombo.Rows.Count; i++)
                    {
                        alData.Add(new alDatas(dtCombo.Rows[i]["street_no"].ToString() + " " + dtCombo.Rows[i]["street_name"].ToString(), dtCombo.Rows[i]["roll_no"].ToString()));
                        //lstResults.Items.Add(dtCombo.Rows[i]["street_no"].ToString() +" "+ dtCombo.Rows[0]["street_name"].ToString());
                    }
                }
                else
                {
                    for (int i = 0; i < dtCombo.Rows.Count; i++)
                    {
                        alData.Add(new alDatas(dtCombo.Rows[i]["owner_1"].ToString() + " " + dtCombo.Rows[i]["owner_2"].ToString(), dtCombo.Rows[i]["roll_no"].ToString()));
                        //lstResults.Items.Add(dtCombo.Rows[i]["owner_1"].ToString() + "-" +dtCombo.Rows[0]["owner_2"].ToString());
                    }
                }
            }

            lstResults.DataSource = alData;
            lstResults.DisplayMember = "LongName";
            lstResults.ValueMember = "ShortName";

        }

        public class alDatas
        {
            private string myShortName;
            private string myLongName;

            public alDatas(string strLongName, string strShortName)
            {

                this.myShortName = strShortName;
                this.myLongName = strLongName;
            }

            public string ShortName
            {
                get
                {
                    return myShortName;
                }
            }

            public string LongName
            {

                get
                {
                    return myLongName;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.itemSelected = lstResults.SelectedValue.ToString();


        }

        private void lstResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button1_Click(sender,e);

        }
    }
}
