using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace I_IT
{
    public partial class ManageHydroAddresses : Form
    {
        DataTable storage = null;
        public int Newid = 0;
        public static string Rollno;
        public static string RID;
        public static string RNo;
        public string Rollnumber
        {
            get { return Rollno; }
            set { Rollno = value; }
        }
        public string RecordID
        {
            get { return RID; }
            set { RID = value; }
        }
        public string Rnumber
        {
            get { return RNo; }
            set { RNo = value; }
        }
        public ManageHydroAddresses()
        {
            InitializeComponent();
            loaddata();
        }
        public void loaddata()
        {
            SQL sql = new SQL("select OldAddress,RollNumber,id from HydroAddresses order by id");

            DataTable dt = sql.Run();
            dataGridView1.DataSource = dt;
            for (int i = 0; i <= dataGridView1.ColumnCount - 1; i++)
            {
                dataGridView1.Columns[i].ReadOnly = true;
            }
            storage = dt;
            Text = "ManageHydroAddresses";
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                if ((e.Exception) is System.FormatException)
                {
                    //MessageBox.Show("Please enter valid values");
                    MessageBox.Show(e.Exception.Message, "Error FormatException", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Suppress a ConstraintException
                    e.ThrowException = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR: dataGridView1_DataError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DialogResult result;
            if (e.ColumnIndex == 1)
            {
                // if(dataGridView1.Rows[e.RowIndex].Cells[3].Value != null)
                Rollno = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["RollNumber"].Value);
                RID = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                Delete.Name = Rollnumber + "_Delete";
                string Task = "";
                if (Delete.Name == "Delete" || Delete.Name == "Cancel" || dataGridView1.Rows[e.RowIndex].Cells[1].Value != null)
                    Task = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                else
                    return;

                if (Task == "Delete")
                {

                    //SQL sql = new SQL("Select count(*) from HydroAddresses where RollNumber = @RollNumber");
                    //sql.AddParameter("@RollNumber", Rollnumber);
                    result = MessageBox.Show("Are You sure want to Delete?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == System.Windows.Forms.DialogResult.Yes &&
                            dataGridView1.CurrentCell.OwningColumn.Name == Rollnumber + "_Delete")
                        {
                           SQL sql = new SQL("delete from HydroAddresses where RollNumber = @RollNumber");
                            sql.AddParameter("@RollNumber", Rollnumber);

                            sql.Run();
                            MessageBox.Show("Record deleted !");
                            loaddata();
                            dataGridView1.Update();
                            dataGridView1.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Record not deleted !");
                        }
                }
                else if (Task == "Cancel")
                {

                    dataGridView1.Rows[e.RowIndex].Cells[0].Value = "Edit";
                    dataGridView1.Rows[e.RowIndex].Cells[1].Value = "Delete";
                    Edit.UseColumnTextForLinkValue = true;
                    Edit.Name = RID + "_Edit";
                    if (dataGridView1.CurrentCell.OwningColumn.Name != RID + "_Edit" || dataGridView1.CurrentCell.OwningColumn.Name != RID + "_Save")
                    {

                        dataGridView1.CurrentCell.ReadOnly = true;
                    }
                    Delete.UseColumnTextForLinkValue = true;
                    Delete.Name = Rollnumber + "_Delete";
                    loaddata();
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }
            }
            if (e.ColumnIndex == 0)
            {
                Rollno = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["RollNumber"].Value);
                RID = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                string Task = "";
                if (Edit.Name == "Edit" || Edit.Name == "Save" || dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
                    Task = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                else
                    return;
                if (Task == "Edit")
                {
                    result = MessageBox.Show("Are You sure want to Edit this record?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Edit.Name = RID + "_Edit";

                        if (dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString() == RID &&
                            dataGridView1.CurrentCell.OwningColumn.Name == RID + "_Edit" &&
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != "Save")
                        {
                            for (int i = 0; i <= dataGridView1.Rows[e.RowIndex].Cells.Count - 1; i++)
                            {
                                if (i != 1 || i != 0)
                                {
                                    dataGridView1.Rows[e.RowIndex].Cells[i].ReadOnly = false;

                                }
                            }
                            dataGridView1.Rows[e.RowIndex].Cells["id"].ReadOnly = true;
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Save";
                            Edit.Name = RID + "_Save";
                            Edit.UseColumnTextForLinkValue = false;
                            dataGridView1.Rows[e.RowIndex].Cells[1].Value = "Cancel";
                            Delete.Name = RID + "_Cancel";
                            Delete.UseColumnTextForLinkValue = false;
                            Delete.ReadOnly = true;
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                        }
                    }
                }
                else if (Task == "Save")
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells["RollNumber"].Value.ToString().Length == 19)
                    {
                        result = MessageBox.Show("Are You sure want to Save this record?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            if (dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString() == RID &&
                                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != "Edit" && dataGridView1.CurrentCell.OwningColumn.Name == RID + "_Save")
                            {
                                if (dataGridView1.CurrentCell.OwningColumn.Name != RID + "_Edit" || dataGridView1.CurrentCell.OwningColumn.Name != RID + "_Save")
                                {

                                    for (int i = 0; i <= dataGridView1.ColumnCount - 1; i++)
                                    {
                                        if (dataGridView1.CurrentCell.ReadOnly == dataGridView1.Columns[i].ReadOnly)
                                            dataGridView1.Columns[i].ReadOnly = false;
                                        else
                                            dataGridView1.Columns[i].ReadOnly = true;
                                    }
                                }
                                dataGridView1.Rows[e.RowIndex].Cells["id"].ReadOnly = true;
                                SQL sql = new SQL(@"UPDATE HydroAddresses SET OldAddress=@OldAddress, RollNumber=@RollNumber
                                    where id in  (" + dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString() + @")");

                                sql.AddParameter("@OldAddress", dataGridView1.Rows[e.RowIndex].Cells["OldAddress"].Value.ToString());
                                sql.AddParameter("@RollNumber", dataGridView1.Rows[e.RowIndex].Cells["RollNumber"].Value.ToString());

                               sql.Run();

                                MessageBox.Show("Record Saved successfully!");
                                Edit.UseColumnTextForLinkValue = true;
                                Edit.Name = RID + "_Edit";
                                Delete.UseColumnTextForLinkValue = true;
                                Delete.Name = Rollnumber + "_Delete";
                                loaddata();
                                dataGridView1.Update();
                                dataGridView1.Refresh();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Roll Number!The Roll Number must in range of 19 character");
                    }
                }
            }
        }
            private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Core.export(Text, storage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int output;
            if (RollNo.Text.All(char.IsDigit) && RollNo.Text.Length == 19)
            { 
                //MessageBox.Show("output " + TypeText.ToString());  //Print 123434
                RNo = RollNo.Text;
                SQL sql = new SQL("Select count(*) from HydroAddresses where RollNumber = @RollNumber");
                sql.AddParameter("@RollNumber", Rnumber);

                if (int.Parse(sql.Run().Rows[0][0].ToString()) >= 1)
                {
                    MessageBox.Show("That RollNumber is already associated with a DATS account.");
                }
                else
                {
                    if ( RollNo.Text != "")
                    {

                    // descreption = Description_txt.Text;
                    sql = new SQL("select max(id) from HydroAddresses");
                    Newid = int.Parse(sql.Run().Rows[0][0].ToString()) + 1;

                    sql = new SQL(@"insert into HydroAddresses values (@Id,@OldAddress, @NewAddress, @RollNumber,@ParentRoll)");
                        sql.AddParameter("@Id", Newid);
                        sql.AddParameter("@OldAddress", OldAdd.Text);
                        sql.AddParameter("@NewAddress", "");
                        sql.AddParameter("@RollNumber", RollNo.Text);
                        sql.AddParameter("@ParentRoll", "False");

                    sql.Run();

                        MessageBox.Show("Record Saved successfuly.");
                        loaddata();
                        dataGridView1.Update();
                        dataGridView1.Refresh();
                        OldAdd.Text = "";
                        RollNo.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Roll Number is required ! Please fill it with valid values");
                    }
                }
        }
            else
            {
                MessageBox.Show("Invalid number! Plese Enter valid Roll Number.");
            }
}
    }
}
