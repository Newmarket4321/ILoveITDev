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
    public partial class NewUserForm : Form
    {
        public static int titleY = 56;

        public static int itemX = 9;
        public static int itemY = 86;
        public static string itemCode = "A";

        public static int priceX = 345;
        public static int priceY = itemY;
        public static int priceW = 80;
        public static int priceH = 27;
        public static string priceCode = "B";

        public static int pricePerYearX = 445;
        public static int pricePerYearY = itemY;
        public static int pricePerYearW = 80;
        public static int pricePerYearH = 27;
        public static string pricePerYearCode = "C";

        public static int accountX = 549;
        public static int accountY = itemY;
        public static int accountW = 107;
        public static int accountH = 27;
        public static string accountCode = "D";

        public static int descriptionX = 661;
        public static int descriptionY = itemY;
        public static int descriptionW = 215;
        public static int descriptionH = 27;
        public static string descriptionCode = "E";

        public static int helpX = descriptionX + descriptionW + 5;
        public static int helpY = itemY;
        public static int helpSize = 27;
        public static string helpCode = "F";

        public static int rowHeight = 29;

        public static string[] submitItemTabNames = { "Hardware", "Software" };

        string jdeDetails = "";

        public NewUserForm()
        {
            InitializeComponent();

            Core.fillComboBox(comboBox2, SQL.Run("select department from departments order by department"));

            refresh(tabControl1);
        }

        private void Visa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!errors())
            {
                if (MessageBox.Show("This form has multiple tabs at the top, which you may have missed." + Environment.NewLine
                + "Are you sure you would like to submit?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string director = SQL.RunString("select director from departments where department = @DEPARTMENT", comboBox2.Text);
                    string directorMail = SQL.RunString("select emailcontact from departments where department = @DEPARTMENT", comboBox2.Text);
                    string name = nameBox.Text;

                    SQL.Run("insert into newuserform values (@EMPNAME, @POSITION, @STATUS, @STARTINGDATE, @FINISHINGDATE, @DEPARTMENT, @REPLACESEMP, @EMPREPLACED, @APPROVED, @APPROVEDBY, @APPROVEDDATE)",
                        nameBox.Text,
                        positionBox.Text,
                        statusBox.Text,
                        startDateBox.Value,
                        checkBox1.Checked ? DBNull.Value : (object)finishDateBox.Value,
                        comboBox2.Text,
                        checkBox2.Checked,
                        textBox4.Text,
                        false,
                        DBNull.Value,
                        DBNull.Value);

                    for (int i = 0; i < submitItemTabNames.Length; i++)
                    {
                        TabPage p = tabControl1.TabPages[submitItemTabNames[i]];
                        string category = p.Text;

                        for (int c = 0; c < p.Controls.Count; c++)
                        {
                            if (p.Controls[c] is CheckBox)
                            {
                                CheckBox item = p.Controls[c] as CheckBox;
                                TextBox account = null;
                                TextBox description = null;
                                Label price = null;

                                int ID = int.Parse(p.Controls[c].Tag.ToString().Substring(1));

                                //Find associated boxes
                                for (int c2 = 0; c2 < p.Controls.Count; c2++)
                                {
                                    if (p.Controls[c2] is TextBox && int.Parse(p.Controls[c].Tag.ToString().Substring(1)) == ID)
                                    {
                                        TextBox box = p.Controls[c2] as TextBox;

                                        if (box.Tag.ToString().Contains(accountCode))
                                        {
                                            account = box;
                                            break;
                                        }
                                        else if (box.Tag.ToString().Contains(descriptionCode))
                                        {
                                            description = box;
                                            break;
                                        }
                                    }
                                    else if (p.Controls[c2] is Label && int.Parse(p.Controls[c].Tag.ToString().Substring(1)) == ID)
                                    {
                                        Label lab = p.Controls[c2] as Label;

                                        if (lab.Tag.ToString().Contains(priceCode))
                                        {
                                            price = lab;
                                            break;
                                        }
                                    }
                                }

                                insertItem(item, price, account, description, category);
                            }
                        }
                    }

                    if (textBox22.Text != "")
                    {
                        if (comboBox3.Text != "")
                        {
                            SQL.Run("insert into newuserformitems values (@EMPFORMID, @ITEMDESC, @ACCOUNTNO, @CATEGORY, @DETAILS)",
                                SQL.RunString("select max(ID) from newuserform"),
                                label13.Text,
                                DBNull.Value,
                                "Additional Access",
                                textBox22.Text + " - " + comboBox3.Text);
                        }

                        if (comboBox4.Text != "")
                        {
                            SQL.Run("insert into newuserformitems values (@EMPFORMID, @ITEMDESC, @ACCOUNTNO, @CATEGORY, @DETAILS)",
                                SQL.RunString("select max(ID) from newuserform"),
                                label17.Text,
                                DBNull.Value,
                                "Additional Access",
                                textBox22.Text + " - " + comboBox4.Text);
                        }

                        if (comboBox5.Text != "")
                        {
                            SQL.Run("insert into newuserformitems values (@EMPFORMID, @ITEMDESC, @ACCOUNTNO, @CATEGORY, @DETAILS)",
                                SQL.RunString("select max(ID) from newuserform"),
                                label18.Text,
                                DBNull.Value,
                                "Additional Access",
                                textBox22.Text + " - " + comboBox5.Text);
                        }

                        if (comboBox6.Text != "")
                        {
                            SQL.Run("insert into newuserformitems values (@EMPFORMID, @ITEMDESC, @ACCOUNTNO, @CATEGORY, @DETAILS)",
                                SQL.RunString("select max(ID) from newuserform"),
                                label19.Text,
                                DBNull.Value,
                                "Additional Access",
                                textBox22.Text + " - " + comboBox6.Text);
                        }
                    }

                    if (textBox23.Text != "")
                    {
                        SQL.Run("insert into newuserformitems values (@EMPFORMID, @ITEMDESC, @ACCOUNTNO, @CATEGORY, @DETAILS)",
                            SQL.RunString("select max(ID) from newuserform"),
                            "This new mailbox to be adminstered by",
                            DBNull.Value,
                            "Additional Access",
                            textBox23.Text);
                    }

                    string details = "";

                    DataTable dt = SQL.Run(@"
select 
EmployeeName as 'Employee Name',
Position as 'Position/Title',
Status as 'Status',
StartingDate as 'Starting Date',
FinishingDate as 'Finish Date',
Department as 'Department',
EmployeeReplaced as 'Replacing'

from newuserform
where id =  (select max(ID)
            from newuserform)");

                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        string columnName = dt.Columns[i].ColumnName;
                        string value = dt.Rows[0][i].ToString();

                        if (columnName == "Replacing" && value == "")
                            break;

                        if (columnName.Contains("Date"))
                        {
                            try
                            {
                                value = DateTime.Parse(value).ToString("MMMM dd, yyyy");
                            }
                            catch
                            {

                            }
                        }
                        details += "<b>" + columnName + ": </b>" + value + Environment.NewLine;
                    }

                    details += Environment.NewLine;

                    dt = SQL.Run("select * from newuserformitems where empformid = (select max(ID) from newuserform) order by category");

                    if (dt.Rows.Count > 0)
                    {
                        details += "<table><tr><td><b>Item</b></td><td><b>" + Core.getDisplayName() + "'s Comment</b></td><td><b>Account Number</b></td><td><b>Price</b></td></tr>";

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            string accountNumber = dt.Rows[i]["AccountNumber"].ToString();

                            details += "<tr><td><b>" + dt.Rows[i]["ItemDesc"].ToString() + ": </b></td><td>" + dt.Rows[i]["Details"].ToString() + "</td><td>" + accountNumber + "</td><td>" + dt.Rows[i]["Price"].ToString() + "</td></tr>";
                        }

                        details += "</table>";
                    }
                    
                    Core.sendMail(directorMail, "New User Form", Core.getDisplayName() + " has submitted a request to IT for new accounts for " + name + "." + Environment.NewLine
                        + "The request is pending your approval before IT can begin processing." + Environment.NewLine
                        + Environment.NewLine
                        + "Please open I❤IT to approve the below details for " + name + "." + Environment.NewLine
                        + "If you don't have I❤IT, please <a href=\"" + Core.getDeploymentPath() + "\">click here</a> to install it." + Environment.NewLine
                        + Environment.NewLine
                        + details);

                    Core.log(Text, "Submitted new form", name);

                    MessageBox.Show("The form has been successfully submitted." + Environment.NewLine
                        + "An e-mail has been sent to " + director + " for approval.", "Success");
                }
            }
        }

        private bool errors()
        {
            //Employee
            if(nameBox.Text == "")
            {
                tabControl1.SelectedIndex = 0;
                nameBox.Focus();
                MessageBox.Show("New Employee Name is blank.");

                return true;
            }

            if (positionBox.Text == "")
            {
                tabControl1.SelectedIndex = 0;
                positionBox.Focus();
                MessageBox.Show("Position/Title is blank.");

                return true;
            }

            if (statusBox.Text == "")
            {
                tabControl1.SelectedIndex = 0;
                statusBox.Focus();
                MessageBox.Show("Status is blank.");

                return true;
            }

            if (comboBox2.Text == "")
            {
                tabControl1.SelectedIndex = 0;
                comboBox2.Focus();
                MessageBox.Show("Department is blank.");

                return true;
            }

            if (textBox4.Text == "" && checkBox2.Checked)
            {
                tabControl1.SelectedIndex = 0;
                textBox4.Focus();
                MessageBox.Show("This user is said to replace an existing, however Previous Employee's Computer Name is blank.");

                return true;
            }

            //Dynamic items
            for (int i = 0; i < submitItemTabNames.Length; i++)
            {
                TabPage p = tabControl1.TabPages[submitItemTabNames[i]];

                //Fill out controls above
                for (int c = 0; c < p.Controls.Count; c++)
                {
                    CheckBox item = null;
                    TextBox account = null;
                    TextBox description = null;

                    if (p.Controls[c] is CheckBox)
                    {
                        item = p.Controls[c] as CheckBox;
                        int ID = getIDFromControl(item);
                        account = getDynamicControl(accountCode, ID) as TextBox;
                        description = getDynamicControl(descriptionCode, ID) as TextBox;

                        if (account.Text == "" && item.Checked)
                        {
                            tabControl1.SelectedTab = p;
                            account.Focus();
                            MessageBox.Show("Account number is required." + Environment.NewLine
                                + Environment.NewLine
                                + "Tab: " + p.Text + Environment.NewLine
                                + "Line: " + item.Text);

                            return true;
                        }

                        if (item.Checked && item.Text == "Other" && description.Text == "")
                        {
                            tabControl1.SelectedTab = p;
                            description.Focus();
                            MessageBox.Show("Comment/explanation is required for the \"Other\" category." + Environment.NewLine
                                + Environment.NewLine
                                + "Tab: " + p.Text + Environment.NewLine
                                + "Line: " + item.Text);

                            return true;
                        }
                    }
                }
            }
            
            //Additional access?
            //No errors for this section

            return false;
        }

        private Control getDynamicControl(string controlCode, int ID)
        {
            for (int i = 0; i < submitItemTabNames.Length; i++)
            {
                TabPage p = tabControl1.TabPages[submitItemTabNames[i]];
                CheckBox item = null;
                TextBox account = null;
                TextBox description = null;

                //Fill out controls above
                for (int c = 0; c < p.Controls.Count; c++)
                {
                    Control r = p.Controls[c];

                    if (r != null
                        && r.Tag != null
                        && r.Tag.ToString().Contains(controlCode)
                        && getIDFromControl(r) == ID)
                        return r;
                }
            }

            return null;
        }

        private int getIDFromControl(Control c)
        {
            try
            {
                if (c.Tag != null)
                    return int.Parse(c.Tag.ToString().Substring(1));
            }
            catch
            {
                return -1;
            }

            return -1;
        }

        private void insertItem(CheckBox item, TextBox accountNo, string category)
        {
            if(item.Checked)
            {
                SQL.Run("insert into newuserformitems values (@EMPFORMID, @ITEMDESC, @ACCOUNTNO, @CATEGORY, @DETAILS)",
                    SQL.RunString("select max(ID) from newuserform"),
                    item.Text,
                    accountNo.Text != "" ? (object)accountNo.Text : DBNull.Value,
                    category,
                    DBNull.Value);
            }
        }

        private void insertItem(CheckBox item, Label price, TextBox accountNo, TextBox description, string category)
        {
            if (item.Checked)
            {
                SQL.Run("insert into newuserformitems values (@EMPFORMID, @ITEMDESC, @ACCOUNTNO, @CATEGORY, @DETAILS)",
                    SQL.RunString("select max(ID) from newuserform"),
                    item.Text,
                    price.Text.Replace("$", ""),
                    accountNo != null && accountNo.Text != "" ? (object)accountNo.Text : DBNull.Value, 
                    description != null && description.Text != "" ? (object)description.Text : DBNull.Value,                    
                    category);
            }
        }

        private void OwnershipChangeReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(null, null);
            else if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Enabled = checkBox2.Checked;
            textBox4.Enabled = checkBox2.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            finishDateBox.Enabled = !checkBox1.Checked;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            string response = Core.lookupMessageBox("JDE Details", "You will need to specify what permissions this person will have in JDE." + Environment.NewLine
                + "Would you like to specify specific permissions, or give identical permissions to an existing employee?", "Specific permissions", "Copy existing employee");


            if (response == "Specific permissions")
            {
                bool success;
                string s = Core.getString("Enter JDE groups", out success);

                if (!success)
                    return;

                jdeDetails = "Groups: " + s;
            }
            else
            {
                bool success;
                string s = Core.getString("Enter existing employee to copy", out success);

                if (!success)
                    return;

                jdeDetails = "Copy permissions: " + s;
            }
        }

        public static void loadHelpText(object sender, EventArgs e)
        {
            Button helpButton = sender as Button;
            int ID = int.Parse(helpButton.Tag.ToString().Substring(1));

            string helpText = SQL.RunString("select helptext from NewUserItemList where ID = @ID", ID);

            MessageBox.Show(helpText);
        }

        public static void enableBoxes(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            int ID = int.Parse(box.Tag.ToString().Substring(1));
            
            Control p = box.Parent;

            for(int i = 0; i < p.Controls.Count; i++)
            {
                if (p.Controls[i].Tag != null)
                {
                    int thisID = int.Parse(p.Controls[i].Tag.ToString().Substring(1));
                    string thisCode = p.Controls[i].Tag.ToString()[0].ToString();

                    if (ID == thisID && (thisCode == descriptionCode || thisCode == accountCode || thisCode == priceCode || thisCode == pricePerYearCode))
                        p.Controls[i].Enabled = box.Checked;
                }
            }
        }

        public static void refresh(TabControl tabControl)
        {
            for (int i = 0; i < submitItemTabNames.Length; i++)
            {
                TabPage p = tabControl.TabPages[submitItemTabNames[i]];
                string category = p.Text;

                //Clear existing controls
                for (int c = p.Controls.Count - 1; c >= 0; c--)
                    if (p.Controls[c] is CheckBox || p.Controls[c] is TextBox || p.Controls[c] is Button || p.Controls[c] is Label)
                        p.Controls.RemoveAt(c);

                //Get existing items
                DataTable dt = SQL.Run("select * from NewUserItemList where category = @CATEGORY order by categorysortorder asc", category);

                //Iterate through items, and add them to their tabs
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    CheckBox item = new CheckBox();
                    item.Text = dt.Rows[j]["Description"].ToString();
                    item.Location = new Point(NewUserForm.itemX, NewUserForm.itemY + (j * NewUserForm.rowHeight));
                    item.Tag = itemCode + dt.Rows[j]["ID"].ToString();
                    item.AutoSize = true;
                    item.CheckedChanged += NewUserForm.enableBoxes;
                    p.Controls.Add(item);

                    string priceS = dt.Rows[j]["Price"].ToString();
                    if (priceS != "")
                        priceS = string.Format("{0:C}", decimal.Parse(priceS));

                    Label price = new Label();
                    price.Text = priceS;
                    price.Location = new Point(priceX, NewUserForm.priceY + (j * NewUserForm.rowHeight));
                    price.Tag = priceCode + dt.Rows[j]["ID"].ToString();
                    price.Enabled = false;
                    p.Controls.Add(price);

                    string pricePerYearS = dt.Rows[j]["PricePerYear"].ToString();
                    if (pricePerYearS != "")
                        pricePerYearS = string.Format("{0:C}", decimal.Parse(pricePerYearS));

                    Label pricePerYear = new Label();
                    pricePerYear.Text = pricePerYearS;
                    pricePerYear.Location = new Point(pricePerYearX, NewUserForm.pricePerYearY + (j * NewUserForm.rowHeight));
                    pricePerYear.Tag = pricePerYearCode + dt.Rows[j]["ID"].ToString();
                    pricePerYear.Enabled = false;
                    p.Controls.Add(pricePerYear);

                    TextBox account = new TextBox();
                    account.Size = new Size(NewUserForm.accountW, NewUserForm.accountH);
                    account.Location = new Point(NewUserForm.accountX, NewUserForm.accountY + (j * NewUserForm.rowHeight));
                    account.Tag = accountCode + dt.Rows[j]["ID"].ToString();
                    account.Enabled = false;
                    p.Controls.Add(account);

                    TextBox description = new TextBox();
                    description.Size = new Size(NewUserForm.descriptionW, NewUserForm.descriptionH);
                    description.Location = new Point(NewUserForm.descriptionX, NewUserForm.descriptionY + (j * NewUserForm.rowHeight));
                    description.Tag = descriptionCode + dt.Rows[j]["ID"].ToString();
                    description.Enabled = false;
                    p.Controls.Add(description);

                    if (dt.Rows[j]["HelpText"].ToString().Trim() != "")
                    {
                        Button help = new Button();
                        help.Text = "?";
                        help.Size = new Size(NewUserForm.helpSize, NewUserForm.helpSize);
                        help.Location = new Point(NewUserForm.helpX, NewUserForm.helpY + (j * NewUserForm.rowHeight));
                        help.Tag = helpCode + dt.Rows[j]["ID"].ToString();
                        help.Click += NewUserForm.loadHelpText;
                        p.Controls.Add(help);
                    }
                }

                //Add titles and disclaimers
                Label itemTitle = new Label();
                itemTitle.Text = "Item";
                itemTitle.Location = new Point(itemX, titleY);
                p.Controls.Add(itemTitle);
                
                Label descriptionTitle = new Label();
                descriptionTitle.Text = "Comment";
                descriptionTitle.Location = new Point(descriptionX, titleY);
                p.Controls.Add(descriptionTitle);

                Label accountTitle = new Label();
                accountTitle.Text = "Account" + Environment.NewLine + "Number";
                accountTitle.Location = new Point(accountX, titleY - accountTitle.Size.Height);
                accountTitle.Size = new Size(accountTitle.Size.Width, 2 * accountTitle.Size.Height);
                p.Controls.Add(accountTitle);

                Label priceTitle = new Label();
                priceTitle.Text = "Upfront" + Environment.NewLine + "Cost";
                priceTitle.Location = new Point(priceX, titleY - priceTitle.Size.Height);
                priceTitle.Size = new Size(priceW, 2 * priceTitle.Size.Height);
                p.Controls.Add(priceTitle);

                Label pricePerYearTitle = new Label();
                pricePerYearTitle.Text = "Annual" + Environment.NewLine + "Cost";
                pricePerYearTitle.Location = new Point(pricePerYearX, titleY - pricePerYearTitle.Size.Height);
                pricePerYearTitle.Size = new Size(pricePerYearW, 2 * pricePerYearTitle.Size.Height);
                p.Controls.Add(pricePerYearTitle);

                Label disclaimer = new Label();
                disclaimer.Text = "Costs are subject to change without notice. Values are approximate.";
                disclaimer.Font = new Font(pricePerYearTitle.Font, FontStyle.Bold);
                disclaimer.TextAlign = ContentAlignment.MiddleCenter;
                disclaimer.Location = new Point(3, 3);
                disclaimer.Size = new Size(900, 20);
                p.Controls.Add(disclaimer);
            }
        }
    }
}
