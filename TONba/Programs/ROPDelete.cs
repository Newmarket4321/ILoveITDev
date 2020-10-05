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
    public partial class ROPDelete : Form
    {
        public ROPDelete()
        {
            InitializeComponent();

            Hide();

            bool success;
            int id = Core.getInt("Which ROP ID# would you like to delete?", out success);

            if(!success)
            {
                Close();
                return;
            }

            bool exists = SQL.Run("use roa; select * from applications where ID = @ID", id).Rows.Count > 0;

            if (exists)
            {
                SQL.Run("use roa; delete from applications where ID = @ID", id);

                MessageBox.Show("ROP #" + id + " has been deleted from the system.");
            }
            else
            {
                MessageBox.Show("There is no ROP with that ID#.");
            }

            Close();
        }
    }
}
