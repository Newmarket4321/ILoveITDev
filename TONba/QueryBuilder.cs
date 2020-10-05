using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class QueryBuilder : Form
    {
        public QueryBuilder()
        {
            InitializeComponent();

            DataTable dt = Vailtech.Run(@"SELECT table_name as ""Table"", 'Vailtech' as ""Description"" FROM dba_tables where owner = 'VAILTECH'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listView1.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void QueryBuilder_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void queryPanel1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DirectoryEntry entry = new DirectoryEntry("LDAP://DC2012R2X3");
            DirectorySearcher dSearch = new DirectorySearcher(entry);
            //string name = "Graeme";
            dSearch.Filter = "(&(objectClass=user))";
            //dSearch.Filter = "(&(objectClass=user)(l=" + name + "))";

            DataTable dt = new DataTable();
            
            SearchResultCollection sResultSetCollection = dSearch.FindAll();


            for (int i = 0; i < 50; i++)
                dt.Columns.Add();

            string[] s = new string[50];

            // get all entries from the active directory.
            // Last Name, name, initial, homepostaladdress, title, company etc..
            foreach (SearchResult sResultSet in sResultSetCollection)
            {
                int c = 0;

                // Login Name
                s[c++] = GetProperty(sResultSet, "cn");
                // First Name
                s[c++] = GetProperty(sResultSet, "givenName");
                // Middle Initials
                s[c++] = GetProperty(sResultSet, "initials");
                // Last Name
                s[c++] = GetProperty(sResultSet, "sn");
                // Address
                string tempAddress = GetProperty(sResultSet, "homePostalAddress");

                if (tempAddress != string.Empty)
                {
                    string[] addressArray = tempAddress.Split(';');
                    string taddr1, taddr2;
                    taddr1 = addressArray[0];
                    s[c++] = taddr1;
                    taddr2 = addressArray[1];
                    s[c++] = taddr2;
                }
                // title
                s[c++] = GetProperty(sResultSet, "title");
                // company
                s[c++] = GetProperty(sResultSet, "company");
                //state
                s[c++] = GetProperty(sResultSet, "st");
                //city
                s[c++] = GetProperty(sResultSet, "l");
                //country
                s[c++] = GetProperty(sResultSet, "co");
                //postal code
                s[c++] = GetProperty(sResultSet, "postalCode");
                // telephonenumber
                s[c++] = GetProperty(sResultSet, "telephoneNumber");
                //extention
                s[c++] = GetProperty(sResultSet, "otherTelephone");
                //fax
                s[c++] = GetProperty(sResultSet, "facsimileTelephoneNumber");

                // email address
                s[c++] = GetProperty(sResultSet, "mail");
                // Challenge Question
                s[c++] = GetProperty(sResultSet, "extensionAttribute1");
                // Challenge Response
                s[c++] = GetProperty(sResultSet, "extensionAttribute2");
                //Member Company
                s[c++] = GetProperty(sResultSet, "extensionAttribute3");
                // Company Relation ship Exits
                s[c++] = GetProperty(sResultSet, "extensionAttribute4");
                //status
                s[c++] = GetProperty(sResultSet, "extensionAttribute5");
                // Assigned Sales Person
                s[c++] = GetProperty(sResultSet, "extensionAttribute6");
                // Accept T and C
                s[c++] = GetProperty(sResultSet, "extensionAttribute7");
                // jobs
                s[c++] = GetProperty(sResultSet, "extensionAttribute8");
                string tEmail = GetProperty(sResultSet, "extensionAttribute9");

                // email over night
                if (tEmail != string.Empty)
                {
                    string em1, em2, em3;
                    string[] emailArray = tEmail.Split(';');
                    em1 = emailArray[0];
                    em2 = emailArray[1];
                    em3 = emailArray[2];
                    s[c++] = em1 + em2 + em3;

                }
                // email daily emerging market
                s[c++] = GetProperty(sResultSet, "extensionAttribute10");
                // email daily corporate market
                s[c++] = GetProperty(sResultSet, "extensionAttribute11");
                // AssetMgt Range
                s[c++] = GetProperty(sResultSet, "extensionAttribute12");
                // date of account created
                s[c++] = GetProperty(sResultSet, "whenCreated");
                // date of account changed
                s[c++] = GetProperty(sResultSet, "whenChanged");

                dt.Rows.Add(s);
            }

            Report r = new Report("Active Directory Test", dt);
            r.Show();
        }

        public static string GetProperty(SearchResult searchResult, string PropertyName)
        {
            if (searchResult.Properties.Contains(PropertyName))
            {
                return searchResult.Properties[PropertyName][0].ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DirectoryEntry entry = new DirectoryEntry("LDAP://DC2012R2X3");
            DirectorySearcher dSearch = new DirectorySearcher(entry);
            string name = "Graeme Smyth";
            //dSearch.Filter = "(&(objectClass=user))";
            dSearch.Filter = "(&(objectClass=user)(cn=" + name + "))";

            DataTable dt = new DataTable();

            SearchResultCollection sResultSetCollection = dSearch.FindAll();

            foreach (var item in sResultSetCollection[0].Properties.PropertyNames)
                dt.Columns.Add(item.ToString());

            string[] s = new string[dt.Columns.Count];

            // get all entries from the active directory.
            // Last Name, name, initial, homepostaladdress, title, company etc..
            foreach (SearchResult row in sResultSetCollection)
            {
                for (int c = 0; c < dt.Columns.Count; c++)
                    s[c] = GetProperty(row, dt.Columns[c].ColumnName);

                dt.Rows.Add(s);
            }

            Report r = new Report("Active Directory Test", dt);
            r.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee emp = Core.getEmployee();
        }
    }
}
