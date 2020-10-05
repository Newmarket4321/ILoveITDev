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
    public partial class RenameAccounts : Form
    {
        public RenameAccounts()
        {
            InitializeComponent();
        }

        private void Visa_Load(object sender, EventArgs e)
        {
            Hide();

            string from = Core.lookupDropdown("Rename which I♥IT account? (Close this window to skip I♥IT.)", SQL.Run("select distinct username from permissions order by [username]"));

            if (from != "")
            {
                bool success;
                string to = Core.getString("Copy to? (Close this window to skip I♥IT.)", out success);

                if (success)
                {
                    bool alreadyExists = SQL.Run("select * from permissions where username = @TARGETNAME", to).Rows.Count > 0;

                    if (!alreadyExists)
                    {
                        SQL.Run("update permissions set username = @TARGETNAME where username = @SOURCENAME", to, from);
                        MessageBox.Show("\"" + from + "\" has been updated to \"" + to + "\" in I♥IT.");
                    }
                    else
                        MessageBox.Show("\"" + to + "\" already exists.");
                }
            }

            //DATS
             from = Core.lookupDropdown("Rename which DATS account? (Close this window to skip DATS.)", SQL.Run("use dats; select username from users order by [username]"));

            if (from != "")
            {
                bool success;
                string to = Core.getString("Copy to? (Close this window to skip DATS.)", out success);

                if (success)
                {
                    bool alreadyExists = SQL.Run("use dats; select * from users where username = @TARGETNAME", to).Rows.Count > 0;

                    if (!alreadyExists)
                    {
                        SQL.Run("use dats; update users set username = @TARGETNAME where username = @SOURCENAME", to, from);
                        MessageBox.Show("\"" + from + "\" has been updated to \"" + to + "\" in DATS.");
                    }
                    else
                        MessageBox.Show("\"" + to + "\" already exists.");
                }
            }

            Close();
        }
    }
}
