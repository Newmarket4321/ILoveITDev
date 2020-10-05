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
    public partial class ROPAddStreet : Form
    {
        public ROPAddStreet()
        {
            InitializeComponent();

            Hide();

            bool success;
            string streetName = Core.getString("Street name (eg, Yonge St)", out success);

            if(!success)
            {
                Close();
                return;
            }

            bool regionalStreet = MessageBox.Show("Is this street regional?", "Region", MessageBoxButtons.YesNo) == DialogResult.Yes;
            bool privateStreet = MessageBox.Show("Is this street private?", "Private", MessageBoxButtons.YesNo) == DialogResult.Yes;

            SQL.Run("use roa; insert into streets values (@NAME, @REGION, @PRIV)", streetName, regionalStreet, privateStreet);

            MessageBox.Show(streetName + " has been added to the system.");

            Close();
        }
    }
}
