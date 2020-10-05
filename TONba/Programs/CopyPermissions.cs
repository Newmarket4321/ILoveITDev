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
    public partial class CopyPermissions : Form
    {
        public CopyPermissions()
        {
            InitializeComponent();
        }

        private void Visa_Load(object sender, EventArgs e)
        {
            Hide();

            string from = Core.lookupDropdown("Copy from?", SQL.Run("select distinct username from permissions order by [username]"));

            if (from == "")
            {
                Close();
                return;
            }

            bool success;
            string to = Core.getString("Copy to?", out success);

            if (!success)
            {
                Close();
                return;
            }

            int before = int.Parse(SQL.RunString("select count(*) from permissions where username = @TARGETNAME", to));

            SQL.Run(@"
insert into permissions
    select @TARGETNAME, program
    from permissions
    where username = @SOURCENAME
    and program not in (select program from permissions where username = @TARGETNAME2)", to, from, to);

            int after = int.Parse(SQL.RunString("select count(*) from permissions where username = @TARGETNAME", to));

            if (after > before)
                MessageBox.Show((after - before) + " permissions copied.");
            else
                MessageBox.Show(to + " already has those permissions.");
            
            Close();
        }
    }
}
