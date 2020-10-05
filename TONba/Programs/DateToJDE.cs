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
    public partial class DateToJDE : Form
    {
        public DateToJDE()
        {
            InitializeComponent();

            bool success;
            DateTime date = Core.getDate("Enter date", out success);

            if (!success)
                return;

            try
            {
                MessageBox.Show("The JDE date is " + Core.dateToJDE(date) + ".");
            }
            catch
            {
                MessageBox.Show("Something didn't work correctly.");
            }

            Close();
        }
    }
}
