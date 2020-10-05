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
    public partial class Oncall : Form
    {
        public Oncall()
        {
            InitializeComponent();

            DataTable dt = SQL.Run("select id, oncall from oncall order by id");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                batchBox.Items.Add(dt.Rows[i][0].ToString());
                if (dt.Rows[i][1].ToString() == "True")
                    batchBox.Text = dt.Rows[i][0].ToString();
            }

            checkBox1.Checked = SQL.RunString("select value from systemvariables where variable='SummerHours'") == "True";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL.Run("update oncall set oncall=0");
            SQL.Run("update oncall set oncall=1 where id='" + batchBox.Text + "'");

            SQL.Run("update systemvariables set value=@RESULT where variable='SummerHours'", checkBox1.Checked ? "True" : "False");

            Close();
        }
    }
}
