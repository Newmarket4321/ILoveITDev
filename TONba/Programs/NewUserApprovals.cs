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
    public partial class NewUserApprovals : Form
    {
        public NewUserApprovals()
        {
            InitializeComponent();

            Core.fillListView(listView1, SQL.Run(@"
select employeename
from newuserform n
join departments d on n.department = d.department
where (approved is null or approved = 'false') and director = @USERNAME", Core.getUsername()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string name = listView1.SelectedItems[0].Text;

                fileRequest(name);

                SQL.Run("update newuserform set approved = 1, approvedby = @BY, approveddate = @DATE where employeename = @NAME",
                    Core.getUsername(),
                    DateTime.Now,
                    name);

                listView1.SelectedItems[0].Remove();

                Core.log(Text, "Approved user", name);
                MessageBox.Show(name + " has been approved. IT will now begin processing the request.");
            }
            else
                MessageBox.Show("Please select an employee.");
        }

        private void fileRequest(string name)
        {
            string details = "";
            
            DataTable dt = SQL.Run("select * from newuserform where employeename = @NAME", name);

            for (int i = 0; i < dt.Columns.Count; i++)
                details += "<b>" + dt.Columns[i].ColumnName + ": </b>" + dt.Rows[0][i].ToString() + Environment.NewLine;

            details += Environment.NewLine;

            dt = SQL.Run("select * from newuserformitems where empformid = (select id from newuserform where employeename = @NAME) order by category", name);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string accountNumber = dt.Rows[i]["AccountNumber"].ToString();

                details += "<b>" + dt.Rows[i]["ItemDesc"].ToString() + ": </b>" + (accountNumber != "" ? accountNumber + "-" : "") + dt.Rows[i]["Details"].ToString() + Environment.NewLine;
            }

            Core.sendMail("accessit@newmarket.ca", "New User Request", details);
        }
    }
}
