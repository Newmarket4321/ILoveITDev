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
    public partial class JDEToDate : Form
    {
        public JDEToDate()
        {
            InitializeComponent();

            bool success;
            string jde = Core.getString("Enter JDE date", out success);

            if (!success)
                return;

            try
            {
                MessageBox.Show("The date is " + Core.JDEToDate(jde).ToString("dddd, dd MMMM yyyy") + ".");
            }
            catch
            {
                MessageBox.Show("Something didn't work correctly.");
            }

            Close();
        }
    }
}
