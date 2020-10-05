using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace I_IT
{
    public partial class Form1_Backup : Form
    {
        string search = "";

        public Form1_Backup()
        {
            InitializeComponent();

            refreshList();
        }

        private void refreshList()
        {
            programs.Items.Clear();
            programs.Groups.Clear();

            SQL sql = new SQL("select category from programs where hidden = 'False' group by category order by category");
            DataTable dt = sql.Run();

            for (int i = 0; i < dt.Rows.Count; i++)
                programs.Groups.Add(dt.Rows[i]["Category"].ToString(), dt.Rows[i]["Category"].ToString());

            //Programs
            Type[] programList = Core.GetTypesInNamespace(Assembly.GetExecutingAssembly(), "I_IT");

            for (int i = 0; i < programList.Length; i++)
            {
                if(hasPermission(programList[i].Name))
                {
                    DataTable details = SQL.Run("select * from programs where code = '" + programList[i].Name + "' order by category, description");

                    ListViewItem item = new ListViewItem(details.Rows.Count > 0 ? details.Rows[0]["description"].ToString() : programList[i].Name);
                    item.Tag = programList[i].Name;

                    if (details.Rows.Count > 0)
                    {
                        item.ImageKey = details.Rows[0]["icon"].ToString();
                        item.Group = programs.Groups[details.Rows[0]["category"].ToString()];
                        item.ToolTipText = details.Rows[0]["tooltip"].ToString();
                    }
                    else
                        item.ImageKey = "Services.png"; //Default icon

                    if(search == "" || item.Text.ToLower().Contains(search.ToLower()))
                        programs.Items.Add(item);
                }
            }

            selectFirstItem();
        }

        private bool hasPermission(string program)
        {
            SQL sql = new SQL(@"
select *
from permissions
where (username=@USERNAME or username = 'Everyone')
and (program=@PROGRAM or program = 'Admin')
");
            sql.AddParameter("@USERNAME", Core.getUsername());
            sql.AddParameter("@PROGRAM", program);
            DataTable dt = sql.Run();

            return dt.Rows.Count > 0 && !Core.isProgramHidden(program); //True if query returned something, and the program is not hidden
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string program = programs.SelectedItems[0].Tag.ToString();

            try
            {
                Type type = Type.GetType("I_IT." + program).BaseType;

                if (type.Name == "Object")
                {
                    Console.SetOut(new TextBoxConsole(console));
                    console.Visible = true;
                }

                object instance = Activator.CreateInstance(Type.GetType("I_IT." + program));
                Core.log("Form1", "Open program", program);

                if (type.Name == "Form")
                {
                    Form form = (Form)instance;

                    //May throw ObjectDisposedException if the form is closed during load, before showing
                    form.Show(); 
                }
                else if (type.Name == "Object")
                    Console.WriteLine((console.Text == "" ? "" : "\n") + "Service run complete.");
            }
            catch (Exception e2)
            {
                if (e2 is ArgumentNullException || e2 is NullReferenceException) //Form doesn't exist
                    MessageBox.Show("Unable to find " + program + " form.");
                else if (e2 is ObjectDisposedException)
                {
                    //Form has been closed
                }
                else
                    Core.error(e2);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Automatic cases
            if (programs.Items.Count == 0)
            {
                MessageBox.Show("You don't have permission to use this program.");
                Close();
            }
            else if (programs.Items.Count == 1)
            {
                programs.Select();
                programs.Items[0].Selected = true;
                listView1_DoubleClick(null, null);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back)
            {
                search = search.Substring(0, Math.Max(search.Length - 1, 0));
                refreshList();
            }
            else if (Core.isIn(e.KeyCode.ToString(), "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Space", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D0"))
            {
                search += (char)e.KeyValue;
                
                for (int i = programs.Items.Count - 1; i >= 0; i--)
                    if (!programs.Items[i].Text.ToUpper().Contains(search))
                        programs.Items.Remove(programs.Items[i]);

                selectFirstItem();
            }
            else if (e.KeyCode == Keys.Escape && search != "")
            {
                search = "";
                refreshList();
            }
            else if(e.KeyCode == Keys.Enter)
            {
                if(programs.SelectedItems.Count > 0)
                    listView1_DoubleClick(null, null);
            }
        }

        private void selectFirstItem()
        {
            int index = -1;

            for (int g = 0; g < programs.Groups.Count && index == -1; g++)
                if (programs.Groups[g].Items.Count > 0)
                    index = g;

            if (index != -1)
                programs.Groups[index].Items[0].Selected = true;
        }

        private void programs_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right && Core.isAdmin())
            {
                EditProgram ep = new EditProgram(programs.SelectedItems[0].Tag.ToString(), imageList);
                ep.ShowDialog();

                refreshList();
            }
        }
    }
}
