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
    public partial class NewUserItemManagement : Form
    {
        static string descriptionLabel = "What text should appear on the form?";
        static string helpTextLabel = "If someone clicks the \"help\" button for this item, what should it say?";
        static string priceLabel = "What will this item cost upfront to the department purchasing it?";
        static string pricePerYearLabel = "What will this item cost annually to the department purchasing it?";

        public NewUserItemManagement()
        {
            InitializeComponent();

            NewUserForm.refresh(tabControl1);
        }

        private void add_Click(object sender, EventArgs e)
        {
            string category = tabControl1.SelectedTab.Text;
            bool success;
            string description = Core.getString(descriptionLabel, out success);

            if (!success)
                return;

            string helpText = Core.getString(helpTextLabel, true, out success);

            int categorySortOrder = SQL.Run("select * from NewUserItemList where category = @CATEGORY", category).Rows.Count + 1;
            
            SQL.Run("insert into NewUserItemList (Description, Category, HelpText, CategorySortOrder) values (@DESCRIPTION, @CATEGORY, @HELPTEXT, @CATEGORYSORTORDER)", description, category, helpText, categorySortOrder);

            NewUserForm.refresh(tabControl1);
        }

        private void remove_Click(object sender, EventArgs e)
        {
            TabPage p = tabControl1.SelectedTab;
            string category = p.Text;

            //Iterate through items and remove any that are checked
            for (int c = p.Controls.Count - 1; c >= 0; c--)
            {
                if (p.Controls[c] is CheckBox)
                {
                    CheckBox box = p.Controls[c] as CheckBox;
                    int ID = int.Parse(box.Tag.ToString().Substring(1));

                    if (box.Checked)
                    {
                        SQL.Run("update NewUserItemList set CategorySortOrder = CategorySortOrder - 1 where category = @CATEGORY and categorysortorder > (select categorysortorder from NewUserItemList where ID = @ID)", category, ID);
                        SQL.Run("delete from NewUserItemList where ID = @ID", ID);
                    }
                }
            }

            NewUserForm.refresh(tabControl1);
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            TabPage p = tabControl1.SelectedTab;
            string category = p.Text;

            //Preserve selection to make repeated moves easier
            List<int> selectedIDs = new List<int>();

            //Iterate through items and move any that are checked
            for (int c = 0; c < p.Controls.Count; c++)
            {
                if (p.Controls[c] is CheckBox)
                {
                    CheckBox box = p.Controls[c] as CheckBox;
                    int ID = int.Parse(box.Tag.ToString().Substring(1));
                    int categorySortOrder = int.Parse(SQL.RunString("select categorysortorder from NewUserItemList where ID = @ID", ID));

                    if (box.Checked)
                    {
                        selectedIDs.Add(ID);
                        
                        if (categorySortOrder == 1)
                            continue; //This item cannot be moved up any further
                        
                        //Move the one you're replacing
                        SQL.Run("update NewUserItemList set CategorySortOrder = CategorySortOrder + 1 where category = @CATEGORY and categorysortorder = @CATEGORYSORTORDER", category, categorySortOrder - 1);

                        //Move yours
                        SQL.Run("update NewUserItemList set CategorySortOrder = CategorySortOrder - 1 where category = @CATEGORY and ID = @ID", category, ID);
                    }
                }
            }

            NewUserForm.refresh(tabControl1);

            //Load selection
            for (int c = 0; c < p.Controls.Count; c++)
            {
                if (p.Controls[c] is CheckBox)
                {
                    CheckBox box = p.Controls[c] as CheckBox;
                    int ID = int.Parse(box.Tag.ToString().Substring(1));

                    if (selectedIDs.Contains(ID))
                        box.Checked = true;
                }
            }
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            TabPage p = tabControl1.SelectedTab;
            string category = p.Text;

            //Preserve selection to make repeated moves easier
            List<int> selectedIDs = new List<int>();

            //Iterate through items and move any that are checked
            for (int c = p.Controls.Count - 1; c >= 0; c--)
            {
                if (p.Controls[c] is CheckBox)
                {
                    CheckBox box = p.Controls[c] as CheckBox;
                    int ID = int.Parse(box.Tag.ToString().Substring(1));
                    int categorySortOrder = int.Parse(SQL.RunString("select categorysortorder from NewUserItemList where ID = @ID", ID));
                    int lastCategorySortOrder = int.Parse(SQL.RunString("select max(categorysortorder) from NewUserItemList where category = @CATEGORY", category));

                    if (box.Checked)
                    {
                        selectedIDs.Add(ID);

                        if (categorySortOrder == lastCategorySortOrder)
                            continue; //This item cannot be moved down any further

                        //Move the one you're replacing
                        SQL.Run("update NewUserItemList set CategorySortOrder = CategorySortOrder - 1 where category = @CATEGORY and categorysortorder = @CATEGORYSORTORDER", category, categorySortOrder + 1);

                        //Move yours
                        SQL.Run("update NewUserItemList set CategorySortOrder = CategorySortOrder + 1 where category = @CATEGORY and ID = @ID", category, ID);
                    }
                }
            }

            NewUserForm.refresh(tabControl1);

            //Load selection
            for (int c = 0; c < p.Controls.Count; c++)
            {
                if (p.Controls[c] is CheckBox)
                {
                    CheckBox box = p.Controls[c] as CheckBox;
                    int ID = int.Parse(box.Tag.ToString().Substring(1));

                    if (selectedIDs.Contains(ID))
                        box.Checked = true;
                }
            }
        }

        private void editItemDescription_Click(object sender, EventArgs e)
        {
            TabPage p = tabControl1.SelectedTab;
            string category = p.Text;

            //Preserve selection to make repeated moves easier
            List<int> selectedIDs = new List<int>();

            //Iterate through items and edit any that are checked
            for (int c = 0; c < p.Controls.Count; c++)
            {
                if (p.Controls[c] is CheckBox)
                {
                    CheckBox box = p.Controls[c] as CheckBox;
                    int ID = int.Parse(box.Tag.ToString().Substring(1));
                    string description = box.Text;

                    if (box.Checked)
                    {
                        selectedIDs.Add(ID);

                        bool success;
                        string s = Core.getString(descriptionLabel, description, out success);

                        if (!success)
                            continue;

                        SQL.Run("update NewUserItemList set description = @DESCRIPTION where ID = @ID", s, ID);
                    }
                }
            }

            NewUserForm.refresh(tabControl1);

            //Load selection
            for (int c = 0; c < p.Controls.Count; c++)
            {
                if (p.Controls[c] is CheckBox)
                {
                    CheckBox box = p.Controls[c] as CheckBox;
                    int ID = int.Parse(box.Tag.ToString().Substring(1));

                    if (selectedIDs.Contains(ID))
                        box.Checked = true;
                }
            }
        }

        private void editHelpText_Click(object sender, EventArgs e)
        {
            TabPage p = tabControl1.SelectedTab;
            string category = p.Text;

            //Preserve selection to make repeated moves easier
            List<int> selectedIDs = new List<int>();

            //Iterate through items and edit any that are checked
            for (int c = 0; c < p.Controls.Count; c++)
            {
                if (p.Controls[c] is CheckBox)
                {
                    CheckBox box = p.Controls[c] as CheckBox;
                    int ID = int.Parse(box.Tag.ToString().Substring(1));
                    string helpText = SQL.RunString("select helptext from NewUserItemList where ID = @ID", ID);

                    if (box.Checked)
                    {
                        selectedIDs.Add(ID);

                        bool success;
                        string s = Core.getString(helpTextLabel, helpText, true, out success);

                        if (!success)
                            continue;

                        SQL.Run("update NewUserItemList set helptext = @HELPTEXT where ID = @ID", s, ID);
                    }
                }
            }

            NewUserForm.refresh(tabControl1);

            //Load selection
            for (int c = 0; c < p.Controls.Count; c++)
            {
                if (p.Controls[c] is CheckBox)
                {
                    CheckBox box = p.Controls[c] as CheckBox;
                    int ID = int.Parse(box.Tag.ToString().Substring(1));

                    if (selectedIDs.Contains(ID))
                        box.Checked = true;
                }
            }
        }

        private void priceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage p = tabControl1.SelectedTab;
            string category = p.Text;

            //Preserve selection to make repeated moves easier
            List<int> selectedIDs = new List<int>();

            //Iterate through items and edit any that are checked
            for (int c = 0; c < p.Controls.Count; c++)
            {
                if (p.Controls[c] is CheckBox)
                {
                    CheckBox box = p.Controls[c] as CheckBox;
                    int ID = int.Parse(box.Tag.ToString().Substring(1));
                    double price;

                    try
                    {
                        price = double.Parse(SQL.RunString("select price from NewUserItemList where ID = @ID", ID));
                    }
                    catch
                    {
                        price = 0;
                    }

                    if (box.Checked)
                    {
                        selectedIDs.Add(ID);

                        bool success;
                        double d = Core.getDouble(priceLabel, 0, 50000, price, out success);

                        if (!success)
                            continue;

                        if(d > 0)
                            SQL.Run("update NewUserItemList set price = @PRICE where ID = @ID", d, ID);
                        else
                            SQL.Run("update NewUserItemList set price = @PRICE where ID = @ID", DBNull.Value, ID);
                    }
                }
            }

            NewUserForm.refresh(tabControl1);

            //Load selection
            for (int c = 0; c < p.Controls.Count; c++)
            {
                if (p.Controls[c] is CheckBox)
                {
                    CheckBox box = p.Controls[c] as CheckBox;
                    int ID = int.Parse(box.Tag.ToString().Substring(1));

                    if (selectedIDs.Contains(ID))
                        box.Checked = true;
                }
            }
        }

        private void pricePerYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage p = tabControl1.SelectedTab;
            string category = p.Text;

            //Preserve selection to make repeated moves easier
            List<int> selectedIDs = new List<int>();

            //Iterate through items and edit any that are checked
            for (int c = 0; c < p.Controls.Count; c++)
            {
                if (p.Controls[c] is CheckBox)
                {
                    CheckBox box = p.Controls[c] as CheckBox;
                    int ID = int.Parse(box.Tag.ToString().Substring(1));
                    double pricePerYear;

                    try
                    {
                        pricePerYear = double.Parse(SQL.RunString("select priceperyear from NewUserItemList where ID = @ID", ID));
                    }
                    catch
                    {
                        pricePerYear = 0;
                    }

                    if (box.Checked)
                    {
                        selectedIDs.Add(ID);

                        bool success;
                        double d = Core.getDouble(pricePerYearLabel, 0, 50000, pricePerYear, out success);

                        if (!success)
                            continue;

                        if (d > 0)
                            SQL.Run("update NewUserItemList set priceperyear = @PRICE where ID = @ID", d, ID);
                        else
                            SQL.Run("update NewUserItemList set priceperyear = @PRICE where ID = @ID", DBNull.Value, ID);
                    }
                }
            }

            NewUserForm.refresh(tabControl1);

            //Load selection
            for (int c = 0; c < p.Controls.Count; c++)
            {
                if (p.Controls[c] is CheckBox)
                {
                    CheckBox box = p.Controls[c] as CheckBox;
                    int ID = int.Parse(box.Tag.ToString().Substring(1));

                    if (selectedIDs.Contains(ID))
                        box.Checked = true;
                }
            }
        }
    }
}
