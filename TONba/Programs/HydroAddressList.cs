﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT.Programs
{
    public partial class HydroAddressList : Form
    {
        public int Newid = 0;
        public static string RNo;
        bool Edit = false;
        public string Rnumber
        {
            get { return RNo; }
            set { RNo = value; }
        }
        public HydroAddressList()
        {
            InitializeComponent();
        }
        public HydroAddressList(int id,string Rollnum, string Oldadd) : this() //Edit
        {
            RollNo.Text = Rollnum;
            OldAdd.Text = Oldadd;
            Newid = id;
            Edit = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(Edit == true)
            {

                if (RollNo.Text.All(char.IsDigit) && RollNo.Text.Length == 19)
                {

                    SQL sql = new SQL(@"UPDATE HydroAddresses SET OldAddress=@OldAddress, RollNumber=@RollNumber
                                    where id=@ID");
                    sql.AddParameter("@ID", Newid);
                    sql.AddParameter("@OldAddress", OldAdd.Text);
                    sql.AddParameter("@RollNumber", RollNo.Text);

                    sql.Run();
                }
                else
                {
                    MessageBox.Show("Invalid number! Plese Enter valid Roll Number.");
                }
            }
            else
            {

                if (RollNo.Text.All(char.IsDigit) && RollNo.Text.Length == 19)
                {
                    RNo = RollNo.Text;
                    SQL sql = new SQL("Select count(*) from HydroAddresses where OldAddress = @OldAddress");
                    sql.AddParameter("@OldAddress", OldAdd.Text);

                    if (int.Parse(sql.Run().Rows[0][0].ToString()) >= 1)
                    {
                        MessageBox.Show("This Address already exist");
                    }
                    else
                    {
                        if (RollNo.Text != "")
                        {
                            sql = new SQL("select max(id) from HydroAddresses");
                            Newid = int.Parse(sql.Run().Rows[0][0].ToString()) + 1;

                            sql = new SQL(@"insert into HydroAddresses values (@Id,@OldAddress, @NewAddress, @RollNumber,@ParentRoll)");
                            sql.AddParameter("@Id", Newid);
                            sql.AddParameter("@OldAddress", OldAdd.Text);
                            sql.AddParameter("@NewAddress", "");
                            sql.AddParameter("@RollNumber", RollNo.Text);
                            sql.AddParameter("@ParentRoll", "False");

                            sql.Run();
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

            MessageBox.Show("Record Saved successfuly.");
            Close();
        }
    }
}
