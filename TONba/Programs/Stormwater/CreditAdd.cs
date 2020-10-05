using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class CreditAdd : Form
    {
        public double lowRunoff = 0;
        public double mediumRunoff = 0;
        public double highRunoff = 0;

        public CreditAdd()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today.AddYears(5);

            area = Vailtech.Run("select site_area, uom, roll_no from TX_PROP_DATA");
        }

        public CreditAdd(string rollno)
        {
            InitializeComponent();

            area = Vailtech.Run("select site_area, uom, roll_no from TX_PROP_DATA");

            Vailtech sql = new Vailtech("select * from stormwatercredits where roll_no = @rollno");
            sql.AddParameter("@rollno", rollno);
            DataTable dt = sql.Run();

            if (dt.Rows.Count > 0)
            {
                textBox1.Text = rollno;
                textBox3.Text = dt.Rows[0]["LOW_AREA"].ToString();
                textBox4.Text = dt.Rows[0]["MED_AREA"].ToString();
                checkBox1.Checked = dt.Rows[0]["POLLUTION_PREVENTION"].ToString() == "Y";
                dateTimePicker1.Value = DateTime.Parse(dt.Rows[0]["EXPIRY"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double temp;

            Vailtech sql = new Vailtech("delete from stormwatercredits where roll_no = @rollno");
            sql.AddParameter("@rollno", textBox1.Text);
            sql.Run();

            sql = new Vailtech("insert into stormwatercredits values (@rollno, @low_area, @med_area, @pollution_prevention, @expiry)");
            sql.AddParameter("@rollno", textBox1.Text);
            sql.AddParameter("@low_area", double.TryParse(textBox3.Text, out temp) ? double.Parse(textBox3.Text) : 0);
            sql.AddParameter("@med_area", double.TryParse(textBox4.Text, out temp) ? double.Parse(textBox4.Text) : 0);
            sql.AddParameter("@pollution_prevention", checkBox1.Checked ? "Y" : "N");
            sql.AddParameter("@expiry", dateTimePicker1.Value);
            sql.Run();

            Close();
        }


        int getNumCondoUnits(string condoID)
        {
            int id = int.Parse(Regex.Match(condoID, @"\d+").Value);

            Vailtech ora = new Vailtech("select LEGAL1 from VAILTECH.TX_ROLL where (LEGAL1 like '%CONDO%' or LEGAL1 like '%YRSCP%' or LEGAL1 like '%YRCP%') and LEGAL1 like '%" + id + "%'");
            DataTable dt = ora.Run();

            return dt.Rows.Count;
        }

        string getCondoID(string rollNo)
        {
            Vailtech ora = new Vailtech("select LEGAL1 from VAILTECH.TX_ROLL where ROLL_NO=@ROLLNO and (LEGAL1 like '%CONDO%' or LEGAL1 like '%YRSCP%' or LEGAL1 like '%YRCP%')");
            ora.AddParameter("@ROLLNO", rollNo);
            DataTable dt = ora.Run();

            if (dt.Rows.Count > 0)
                return dt.Rows[0][0].ToString();

            return "";
        }

        private double calculateCredit()
        {
            try
            {
                double credit = Core.calculateStormwaterCredit(textBox1.Text, lowRunoff, mediumRunoff, highRunoff, double.Parse(textBox3.Text), double.Parse(textBox4.Text), checkBox1.Checked);
                label3.Text = "$" + credit.ToString("F");

                return credit;
            }
            catch
            {
                label3.Text = "Error";
            }

            return 0;
        }

        private void AddPermission_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.Enter)
                button1_Click(null, null);
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            //Give credit equal to 5% of how much they pay within a year (property bill)
            //Check with Grace


            //Other stuff:
            //Calculate credit at run time
            //Expiry date, default 5 years
            //On credit view, list how long before expiry

            calculateCredit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calculateCredit();

            try
            {
                calculateArea();
            }
            catch
            {

            }

            calculateCharge();
        }

        public void calculateArea()
        {
            label10.Text = getArea(textBox1.Text).ToString() + "m²";
        }

        public void calculateCharge()
        {
            double charge = getCharge(textBox1.Text);
            label8.Text = charge == 0 ? "-" : "$" + charge.ToString("F");
        }

        public double getCharge(string rollno)
        {
            //Vailtech ora = new Vailtech("select charge from stormwater where roll_no=@ROLLNO and year = @YEAR");
            //ora.AddParameter("@ROLLNO", rollno);
            //ora.AddParameter("@YEAR", DateTime.Now.Year);
            //DataTable dt = ora.Run();

            //if(dt.Rows.Count > 0)
            //    return double.Parse(dt.Rows[0][0].ToString());

            //return 0;

            return getArea(rollno) * highRunoff;
        }


        DataTable area;

        public double getArea(string rollNo)
        {
            try
            {
                double areaM = 0;
                string condoID = getCondoID(rollNo);

                if (condoID != "") //Condo
                {
                    DataTable gis = GISPub.Run("select sde.st_area(shape) from tongis.view_asmnt_parcel where roll_no = '" + rollNo + "'");

                    if (gis.Rows.Count > 0)
                        areaM = double.Parse(gis.Rows[0][0].ToString()); //Area of whole condo

                    areaM /= getNumCondoUnits(condoID); //Divide by number of units to get unit's share
                }
                else //Not condo
                {
                    DataRow[] rows = area.Select("roll_no = " + rollNo);

                    if (rows.Count() == 0)
                        return 0;

                    areaM = double.Parse(rows[0][0].ToString());
                    string unit = rows[0][1].ToString();

                    //Convert to square meters
                    if (unit == "F")
                        areaM *= 0.092903;
                    else if (unit == "A")
                        areaM *= 4046.86;
                    else if (areaM == 0 || unit == "N")
                    {
                        DataTable gis = GISPub.Run("select sde.st_area(shape) from tongis.view_asmnt_parcel where roll_no = '" + rollNo + "'");

                        if (gis.Rows.Count > 0)
                            areaM = double.Parse(gis.Rows[0][0].ToString());
                    }
                }

                return (double)((int)(areaM * 1000)) / 1000;
            }
            catch
            {

            }

            return 0;
        }

        private void CreditAdd_Shown(object sender, EventArgs e)
        {
            calculateCredit();
            calculateArea();
            calculateCharge();
        }
    }
}
