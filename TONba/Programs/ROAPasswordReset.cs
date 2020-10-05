using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class ROAPasswordReset : Form
    {
        public ROAPasswordReset()
        {
            InitializeComponent();

            SQL sql;

            try
            {
                sql = new SQL("select * from programs where code=@CODE");
                sql.AddParameter("@CODE", Name);
                DataTable dt = sql.Run();

                Text = dt.Rows[0]["Description"].ToString();
            }
            catch
            {
                
            }

            GetString box = new GetString("Enter username");
            box.ShowDialog();
            string username = box.r;

            box = new GetString("Enter new password");
            box.ShowDialog();
            string newPassword = box.r;

            string salt = Core.getSalt();

            sql = new SQL(@"
use roa;

update users

set password = @Password,
salt = @Salt

where username = @username");
            sql.AddParameter("@username", username);
            sql.AddParameter("@password", Core.encrypt(salt + newPassword));
            sql.AddParameter("@salt", salt);
            sql.Run();

            MessageBox.Show("Password updated.");

            Close();
        }

        public void process()
        {
            
        }

        private void Visa_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
