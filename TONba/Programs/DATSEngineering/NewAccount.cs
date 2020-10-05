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
    public partial class NewAccount : Form
    {
        string oldUsername = "";
        const int NEWMODE = 0;
        const int EDITMODE = 1;
        int mode = NEWMODE;

        public NewAccount()
        {
            InitializeComponent();

            startup(Core.getUsername());
        }

        public NewAccount(string username)
        {
            InitializeComponent();

            startup(username);

            this.Text = "Edit Account";
            button8.Text = "Save";

            textBox3.Text = username;
            oldUsername = username;
            mode = EDITMODE;

            DATSEngineeringSQL sql = new DATSEngineeringSQL("select u.username, u.employeeid as EmpID, u.approver, u.active from users u where u.displayname = @USERNAME");
            sql.AddParameter("@USERNAME", username);
            DataTable dt = sql.Run();

            textBox2.Text = dt.Rows[0]["EmpId"].ToString();
            textBox1.Text = dt.Rows[0]["username"].ToString();
            oldUsername = dt.Rows[0]["username"].ToString();
            
            bool approver = bool.Parse(dt.Rows[0]["approver"].ToString());
            bool active = bool.Parse(dt.Rows[0]["active"].ToString());

            if (approver)
                comboBox1.Text = "Approver";
            else
                comboBox1.Text = "User";

            checkBox1.Checked = active;
        }

        private void startup(string username)
        {
            comboBox1.Items.Clear();

            comboBox1.Items.Add("User");
            comboBox1.Items.Add("Approver");
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") //Username is not blank
            {
                if (!DATSEngineeringCore.isUsernameTaken(textBox1.Text) || mode == EDITMODE) //Username is not taken
                {
                    if (textBox2.Text != "") //Employee ID is not blank
                    {
                        try
                        {
                            if (DATSEngineeringCore.isEmpIDValid(textBox2.Text)) //Employee ID is valid
                            {
                                if (mode == NEWMODE)
                                {
                                    //Create DATS user
                                    DATSEngineeringSQL sql = new DATSEngineeringSQL("INSERT INTO Users VALUES (@Username, @DisplayName, @EmpID, @EmpType, @CanApprove, @Active)");
                                    sql.AddParameter("@Username", textBox1.Text);
                                    sql.AddParameter("@DisplayName", textBox3.Text);
                                    sql.AddParameter("@EmpID", textBox2.Text);
                                    sql.AddParameter("@EmpType", "");
                                    sql.AddParameter("@CanReview", comboBox1.Text == "Reviewer" || comboBox1.Text == "Approver");
                                    sql.AddParameter("@CanApprove", comboBox1.Text == "Approver");
                                    sql.AddParameter("@Active", checkBox1.Checked);
                                    sql.Run();

                                    try
                                    {
                                        //Create I❤IT user
                                        SQL sql2 = new SQL("insert into permissions values (@username, @program)");
                                        sql2.AddParameter("@username", textBox1.Text);
                                        sql2.AddParameter("@program", "DATSEngineering");
                                        sql2.Run();
                                    }
                                    catch
                                    {
                                            
                                    }

                                    //Grab userID
                                    sql = new DATSEngineeringSQL("select userid from users where username=@USERNAME");
                                    sql.AddParameter("@USERNAME", textBox1.Text);
                                    string userID = sql.Run().Rows[0]["userid"].ToString();
                                }
                                else if (mode == EDITMODE)
                                {
                                    //Update the user
                                    DATSEngineeringSQL sql = new DATSEngineeringSQL("UPDATE Users SET Username=@USERNAME, DisplayName=@DISPLAYNAME, approver=@CANAPPROVE, EmployeeID=@EMPLOYEEID, Active=@ACTIVE where Username=@OLDUSERNAME");
                                    sql.AddParameter("@USERNAME", textBox1.Text);
                                    sql.AddParameter("@DISPLAYNAME", textBox3.Text);
                                    sql.AddParameter("@CANAPPROVE", comboBox1.Text == "Approver");
                                    sql.AddParameter("@EMPLOYEEID", textBox2.Text);
                                    sql.AddParameter("@OLDUSERNAME", oldUsername);
                                    sql.AddParameter("@ACTIVE", checkBox1.Checked);
                                    sql.Run();
                                }

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Employee ID invalid. Ensure it was entered correctly.\n\nIf the employee is new, it could be that HR hasn't entered them into JDE yet. If you believe this to be the case, please contact HR.");
                            }
                        }
                        catch (System.TypeInitializationException)
                        {
                            MessageBox.Show("This component requires Oracle to be installed. Please call IT to have this done.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter an employee ID.");
                    }
                }
                else
                {
                    MessageBox.Show("That username is taken.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a username.");
            }
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {

        }

        private void NewAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.Enter)
                button2_Click(null, null);
        }
    }
}
