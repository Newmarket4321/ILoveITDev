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
    public partial class FindPeriod : Form
    {
        public string period = "";

        public FindPeriod()
        {
            InitializeComponent();

            DataTable cur = Oracle.Run("select YDCTRY, YDDTEY, YDPPNB from CRPDTA.F07210 where YDPAYD='SALARY06  '");
            string currentPeriod = cur.Rows[0]["YDCTRY"].ToString() + cur.Rows[0]["YDDTEY"].ToString() + cur.Rows[0]["YDPPNB"].ToString().Substring(1, 2);

            DataTable dt = Oracle.Run("select JDDTEY, JDPPNB from CRPDTA.F069066 where JDPCCD='SAL'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string period = "20" + (dt.Rows[i]["JDDTEY"].ToString().Length == 2 ? dt.Rows[i]["JDDTEY"].ToString() : ("0" + dt.Rows[i]["JDDTEY"].ToString())) + dt.Rows[i]["JDPPNB"].ToString().Substring(1, 2);

                DateTime from = DATSEngineeringCore.getPeriodStart(int.Parse(period));
                DateTime to = DATSEngineeringCore.getPeriodEnd(int.Parse(period));

                comboBox1.Items.Add(period + " - " + from.ToString(@"MMM d") + " to " + to.ToString(@"MMM d") + (currentPeriod == period ? " (Current)" : ""));

                if (currentPeriod == period)
                    comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            }

            //DataTable dt = SQL.Run("select [from], [to], period, [current period] from periods order by period");

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    DateTime from = DateTime.Parse(dt.Rows[i]["from"].ToString());
            //    DateTime to = DateTime.Parse(dt.Rows[i]["to"].ToString());
            //    string period = dt.Rows[i]["period"].ToString();
            //    string currentPeriod = dt.Rows[i]["current period"].ToString();

            //    comboBox1.Items.Add(period + " - " + from.ToString("MMMM d") + " to " + to.ToString("MMMM d") + (currentPeriod == "True" ? " (Current period)" : ""));

            //    if (currentPeriod == "True")
            //        comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            //}
        }

        public FindPeriod(bool auto)
        {
            InitializeComponent();

            DataTable cur = Oracle.Run("select YDCTRY, YDDTEY, YDPPNB from CRPDTA.F07210 where YDPAYD='SALARY06  '");
            string currentPeriod = cur.Rows[0]["YDCTRY"].ToString() + cur.Rows[0]["YDDTEY"].ToString() + cur.Rows[0]["YDPPNB"].ToString().Substring(1, 2);

            DataTable dt = Oracle.Run("select JDDTEY, JDPPNB from CRPDTA.F069066 where JDPCCD='SAL'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string period = "20" + (dt.Rows[i]["JDDTEY"].ToString().Length == 2 ? dt.Rows[i]["JDDTEY"].ToString() : ("0" + dt.Rows[i]["JDDTEY"].ToString())) + dt.Rows[i]["JDPPNB"].ToString().Substring(1, 2);

                DateTime from = DATSEngineeringCore.getPeriodStart(int.Parse(period));
                DateTime to = DATSEngineeringCore.getPeriodEnd(int.Parse(period));

                comboBox1.Items.Add(period + " - " + from.ToString(@"MMM d") + " to " + to.ToString(@"MMM d") + (currentPeriod == period ? " (Current)" : ""));

                if (currentPeriod == period)
                    comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            }

            //DataTable dt = SQL.Run("select [from], [to], period, [current period] from periods order by period");

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    DateTime from = DateTime.Parse(dt.Rows[i]["from"].ToString());
            //    DateTime to = DateTime.Parse(dt.Rows[i]["to"].ToString());
            //    string period = dt.Rows[i]["period"].ToString();
            //    string currentPeriod = dt.Rows[i]["current period"].ToString();

            //    comboBox1.Items.Add(period + " - " + from.ToString("MMMM d") + " to " + to.ToString("MMMM d") + (currentPeriod == "True" ? " (Current period)" : ""));

            //    if (currentPeriod == "True")
            //        comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            //}

            if(auto)
                button8_Click(null, null);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            period = comboBox1.Text.Substring(0, 6);

            Close();
        }
    }
}
