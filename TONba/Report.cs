using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace I_IT
{
    public partial class Report : Form
    {
        Database db = null;
        DataTable original = null;
        DataTable storage = null;
        //bool updatable = false;
        public char separator = '쓰'; //Something you don't expect to see in everyday text
        public event EventHandler Add_Click;
        public event EventHandler Edit_Click;
        public event EventHandler Delete_Click;

        ReportMode mode = ReportMode.REPORT;
        public DataRow selectedRow = null;

        public enum ReportMode {
            REPORT,     //Show a report
            SELECT,     //Allow user to select one row to be returned
            DATALIST    //Allow user to add, edit and delete records
        }
        

        public Report(string title, DataTable dt)
        {
            InitializeComponent();

            Text = title;
            toolStripStatusLabel1.Text = "";
           
            original = dt;
            storage = dt;

            //If from JDE, add column description
            bool quit = false;
            for (int i = 0; i < dt.Columns.Count && !quit; i++)
            {
                string alias = getJDEDesc(dt.Columns[i].ColumnName);

                //If the first isn't from JDE, this query probably isn't applicable, so save time
                if (alias == "" && i == 0)
                    quit = true;
                else
                {
                    dt.Columns[i].ColumnName = alias + Environment.NewLine + "(" + dt.Columns[i].ColumnName + ")";
                    //dt.Columns[i].ColumnName = alias + Environment.NewLine + dt.Columns[i].ColumnName;
                    grid.Rows.HeaderHeight = 35;
                }
            }
           
            grid.DataTable = dt;
            
            grid.Selection.EnableMultiSelection = true;
          
            toolStripStatusLabel1.Text = "Returned " + grid.DataTable.Rows.Count + " rows";
            if(Text == "POS Summary")
            {
                var total = dt.Compute("Sum(PAYMENT_AMT)", "").ToString();
                DataRow workRow = dt.NewRow();
                
                workRow["PAYMENT_AMT"] = total;
                workRow["NAME1"] = "TOTAL";
                dt.Rows.Add(workRow);                
                grid.DataTable = dt;
            }
            if (Text == "Post Dated Cheque Summary")
            {
                var total = dt.Compute("Sum(AMT)", "").ToString();
                DataRow workRow = dt.NewRow();

                workRow["AMT"] = total;
                //workRow["NAME1"] = "TOTAL";
                dt.Rows.Add(workRow);

               
                grid.DataTable = dt;
            }


            SourceGrid.Cells.Views.ColumnHeader headerView = new SourceGrid.Cells.Views.ColumnHeader();
            headerView.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            headerView.ForeColor = Color.FromArgb(38, 38, 38); //Off-black

            CellBackColorAlternate alternatingView = new CellBackColorAlternate(Color.Khaki, Color.DarkKhaki);
            PopupMenu menuController = new PopupMenu(this);
            ValueChangedEvent valueChangedController = new ValueChangedEvent();
            Font font = new Font(menuStrip1.Font.FontFamily, 12);
            
            SourceGrid.Cells.Views.Link alternateView = new SourceGrid.Cells.Views.Link();
            alternateView.BackColor = Color.FromArgb(0, 0, 255); //Off-black

            SourceGrid.Cells.Views.Cell numericView = new SourceGrid.Cells.Views.Cell();
            numericView.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleRight;

            bool addBefore = grid.Columns.Count > 25;

            if (addBefore)
                addCustomOption(font);

            //Width of columns
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                grid.Columns[i].AutoSizeMode = SourceGrid.AutoSizeMode.Default;
                grid.GetCell(0, i).View = headerView;
                grid.GetCell(0, i).AddController(menuController);
                grid.GetCell(1, i).AddController(menuController);
                grid.GetCell(1, i).AddController(valueChangedController);
                grid.GetCell(1, i).Editor.EnableEdit = false;

                Type type = grid.DataTable.Columns[i].DataType;
                bool isString = type == typeof(String) || type == typeof(DateTime);

                if (type == typeof(int) || type == typeof(double) || type == typeof(decimal))
                    grid.GetCell(1, i).View = numericView;

                ToolStripMenuItem item = new ToolStripMenuItem(grid.Columns[i].PropertyName);
                item.Font = font;

                ToolStripMenuItem temp = new ToolStripMenuItem("Is");
                temp.Image = Properties.Resources.EqualsIcon;
                temp.Click += Equals_Click;
                item.DropDownItems.Add(temp);

                temp = new ToolStripMenuItem("Is not");
                temp.Image = Properties.Resources.NotEquals;
                temp.Click += NotEquals_Click;
                item.DropDownItems.Add(temp);

                if (isString)
                {
                    temp = new ToolStripMenuItem("Contains");
                    temp.Image = Properties.Resources.Contains;
                    temp.Click += Contains_Click;
                    item.DropDownItems.Add(temp);

                    temp = new ToolStripMenuItem("Does not contain");
                    temp.Image = Properties.Resources.NotContains;
                    temp.Click += NotContains_Click;
                    item.DropDownItems.Add(temp);
                }

                temp = new ToolStripMenuItem("In list");
                temp.Image = Properties.Resources.List;
                temp.Click += List_Click;
                item.DropDownItems.Add(temp);

                temp = new ToolStripMenuItem("Not in list");
                temp.Image = Properties.Resources.NotList;
                temp.Click += NotList_Click;
                item.DropDownItems.Add(temp);

                temp = new ToolStripMenuItem("Less than");
                temp.Image = Properties.Resources.LessThan;
                temp.Click += LessThan_Click;
                item.DropDownItems.Add(temp);

                temp = new ToolStripMenuItem("Less than or equal to");
                temp.Image = Properties.Resources.LeEquals;
                temp.Click += LessThanEq_Click;
                item.DropDownItems.Add(temp);

                temp = new ToolStripMenuItem("Greater than");
                temp.Image = Properties.Resources.GreaterThan;
                temp.Click += GreaterThan_Click;
                item.DropDownItems.Add(temp);

                temp = new ToolStripMenuItem("Greater than or equal to");
                temp.Image = Properties.Resources.GrEquals;
                temp.Click += GreaterThanEq_Click;
                item.DropDownItems.Add(temp);

                filterMenuItem.DropDownItems.Add(item);
            }

            if (!addBefore)
                addCustomOption(font);
            
            grid.AutoSizeCells();
            grid.Focus();
        }

        

        public Report(string title, DataTable dt, ReportMode reportMode) : this(title, dt)
        {
            mode = reportMode;

            if (mode == ReportMode.SELECT)
            {
                selectMenuItem.Visible = true;
                grid.SelectionMode = SourceGrid.GridSelectionMode.Row;
            }
        }

        public Report(string title, Database database, bool allowAdd, bool allowEdit, bool allowDelete) : this(title, database.Run())
        {
            addMenuItem.Visible = allowAdd;
            editMenuItem.Visible = allowEdit;
            deleteMenuItem.Visible = allowDelete;
            db = database;

            if(allowEdit || allowDelete) //Actions performed on a row
                grid.SelectionMode = SourceGrid.GridSelectionMode.Row;
        }
        
        public static string getJDEDesc(string column)
        {
            try
            {
                return Oracle.RunString(@"
SELECT min(DD910.F9202.FRDSCR)
FROM DD910.F9202
WHERE trim(FRDTAI) = '" + column.Substring(2) + "'").Trim();
            }
            catch
            {
                return "";
            }
        }

        public static bool isUDCColumn(string column)
        {
            try
            {
                string dataItem = column.Substring(2);
                DataTable dt = Oracle.Run("select FROER1, FROER2 from DD910.F9210 where trim(FRDTAI) = '" + dataItem + "' and trim(FROWER) = 'UDC'");

                if (dt.Rows.Count > 0)
                    return true;
            }
            catch
            {

            }

            return false;
        }

        private void addCustomOption(Font font)
        {
            ToolStripMenuItem customItem = new ToolStripMenuItem("Custom");
            customItem.Font = font;
            customItem.Image = Properties.Resources.Custom;
            customItem.Click += whereToolStripMenuItem_Click;
            filterMenuItem.DropDownItems.Add(customItem);
        }

        //////////////////
        //Filter functions
        //////////////////
        public void GreaterThanEq_Click(object sender, EventArgs e)
        {
            string column = "";

            if (sender is ToolStripMenuItem)
                column = (sender as ToolStripMenuItem).OwnerItem.Text;
            else if (sender is MenuItem)
                column = (sender as MenuItem).Tag.ToString();

            bool success;
            string filter = getFilterFromType(column, ">=", "is greater than or equal to", out success);

            if (success)
            {
                grid.DataTable = Report.filter(grid.DataTable, filter, out success);

                addUnfilter(filter);
            }
        }

        public void GreaterThan_Click(object sender, EventArgs e)
        {
            string column = "";

            if (sender is ToolStripMenuItem)
                column = (sender as ToolStripMenuItem).OwnerItem.Text;
            else if (sender is MenuItem)
                column = (sender as MenuItem).Tag.ToString();

            bool success;
            string filter = getFilterFromType(column, ">", "is greater than", out success);

            if (success)
            {
                grid.DataTable = Report.filter(grid.DataTable, filter, out success);

                addUnfilter(filter);
            }
        }

        public void LessThanEq_Click(object sender, EventArgs e)
        {
            string column = "";

            if (sender is ToolStripMenuItem)
                column = (sender as ToolStripMenuItem).OwnerItem.Text;
            else if (sender is MenuItem)
                column = (sender as MenuItem).Tag.ToString();

            bool success;
            string filter = getFilterFromType(column, "<=", "is less than or equal to", out success);

            if (success)
            {
                grid.DataTable = Report.filter(grid.DataTable, filter, out success);

                addUnfilter(filter);
            }
        }

        public void LessThan_Click(object sender, EventArgs e)
        {
            string column = "";

            if (sender is ToolStripMenuItem)
                column = (sender as ToolStripMenuItem).OwnerItem.Text;
            else if (sender is MenuItem)
                column = (sender as MenuItem).Tag.ToString();

            bool success;
            string filter = getFilterFromType(column, "<", "is less than", out success);

            if (success)
            {
                grid.DataTable = Report.filter(grid.DataTable, filter, out success);

                addUnfilter(filter);
            }
        }

        public void NotList_Click(object sender, EventArgs e)
        {
            string column = "";

            if (sender is ToolStripMenuItem)
                column = (sender as ToolStripMenuItem).OwnerItem.Text;
            else if (sender is MenuItem)
                column = (sender as MenuItem).Tag.ToString();

            bool success;
            string filter = getFilterFromType(column, "not in", "not list", out success);

            if (success)
            {
                grid.DataTable = Report.filter(grid.DataTable, filter, out success);

                addUnfilter(filter);
            }
        }

        public void List_Click(object sender, EventArgs e)
        {
            string column = "";

            if (sender is ToolStripMenuItem)
                column = (sender as ToolStripMenuItem).OwnerItem.Text;
            else if (sender is MenuItem)
                column = (sender as MenuItem).Tag.ToString();

            bool success;
            string filter = getFilterFromType(column, "in", "list", out success);

            if (success)
            {
                grid.DataTable = Report.filter(grid.DataTable, filter, out success);

                addUnfilter(filter);
            }
        }

        public void NotContains_Click(object sender, EventArgs e)
        {
            string column = "";

            if (sender is ToolStripMenuItem)
                column = (sender as ToolStripMenuItem).OwnerItem.Text;
            else if (sender is MenuItem)
                column = (sender as MenuItem).Tag.ToString();

            bool success;
            string filter = getFilterFromType(column, "not like", "does not contain", out success);

            if (success)
            {
                grid.DataTable = Report.filter(grid.DataTable, filter, out success);

                addUnfilter(filter);
            }
        }

        public void Contains_Click(object sender, EventArgs e)
        {
            string column = "";

            if (sender is ToolStripMenuItem)
                column = (sender as ToolStripMenuItem).OwnerItem.Text;
            else if (sender is MenuItem)
                column = (sender as MenuItem).Tag.ToString();

            bool success;
            string filter = getFilterFromType(column, "like", "contains", out success);

            if (success)
            {
                grid.DataTable = Report.filter(grid.DataTable, filter, out success);

                addUnfilter(filter);
            }
        }

        public void NotEquals_Click(object sender, EventArgs e)
        {
            string column = "";

            if (sender is ToolStripMenuItem)
                column = (sender as ToolStripMenuItem).OwnerItem.Text;
            else if (sender is MenuItem)
                column = (sender as MenuItem).Tag.ToString();

            bool success;
            string filter = getFilterFromType(column, "<>", "is not", out success);

            if (success)
            {
                grid.DataTable = Report.filter(grid.DataTable, filter, out success);

                addUnfilter(filter);
            }
        }

        public void Equals_Click(object sender, EventArgs e)
        {
            string column = "";

            if (sender is ToolStripMenuItem)
                column = (sender as ToolStripMenuItem).OwnerItem.Text;
            else if (sender is MenuItem)
                column = (sender as MenuItem).Tag.ToString();

            bool success;
            string filter = getFilterFromType(column, "=", "is", out success);
            
            if (success)
            {
                grid.DataTable = Report.filter(grid.DataTable, filter, out success);

                addUnfilter(filter);
            }
        }

        public string getFilterFromType(string column, string code, string wording, out bool success)
        {
            string filter = "";
            string value = "";
            DataColumn dataColumn = grid.DataTable.Columns[column.Split(separator)[0]];

            Type type = dataColumn != null ? dataColumn.DataType : typeof(string);
            bool useQuotes = (type == typeof(string) || type == typeof(DateTime));
            bool useBrackets = code == "in" || code == "not in";
            bool useWildcards = code == "like" || code == "not like";

            if(code == "in" || code == "not in")
            {
                string output = Core.getString("Enter your list, one item per line, no punctuation.", true, out success);

                for (int i = 0; i < output.Split('\n').Length; i++)
                    value += (i != 0 ? ", " : "") + "'" + output.Split('\n')[i].Trim() + "'";

                useQuotes = false; //Already taken care of
            }
            else if (column.Contains(separator))
            {
                string[] temp = column.Split(separator);
                column = temp[0];
                value = temp[1];
                success = true;
            } else if (type == typeof(string))
                value = Core.getString("Only show records where " + column + " " + wording + " what value?", out success).Trim();
            else if (type == typeof(DateTime))
                value = Core.getDate("Only show records where " + column + " " + wording + " what value?", out success).ToString("yyyy-MM-dd");
            else if (type == typeof(short) || type == typeof(int) || type == typeof(long)) //Int16, Int32, Int64
                value = Core.getInt("Only show records where " + column + " " + wording + " what value?", out success).ToString();
            else if (type == typeof(double) || type == typeof(decimal))
                value = Core.getDouble("Only show records where " + column + " " + wording + " what value?", out success).ToString();
            else
            {
                success = false;
                MessageBox.Show("Data type not recognized.");
            }
            
            filter = value;
            filter = (useWildcards ? "%" : "") + filter + (useWildcards ? "%" : "");
            filter = (useQuotes ? "'" : "") + filter + (useQuotes ? "'" : "");
            filter = (useBrackets ? "(" : "") + filter + (useBrackets ? ")" : "");
            filter = "[" + column + "] " + code + " " + filter;
            DateTime dtTemp;
            if(Text == "POS Summary" && DateTime.TryParse(value, out dtTemp))
            {
                filter = filterDateandTotal(value, "PAYMENT_DATE", "PAYMENT_AMT");
            }
            if (Text == "Post Dated Cheque Summary" && DateTime.TryParse(value, out dtTemp))
            {
                filter = filterDateandTotal(value, "TRAN_DATE", "AMT");
            }
            return filter;
        }

        private string filterDateandTotal(string value, string dateFilter, string totalColumn)
        {
            string filter = "";
            var from_date = value + " 00:00:00";
            var to_date = value + " 23:59:59";
            filter = dateFilter + " >= #" + from_date + "# AND " + dateFilter + " <= #" + to_date + "# OR "+ dateFilter + " IS NULL";
            DataRow row = (DataRow)grid.DataTable.Rows[grid.DataTable.Rows.Count - 1];
            row[totalColumn] = DBNull.Value;
            var total = grid.DataTable.Compute("Sum("+ totalColumn + ")", filter).ToString();
            if(total != "")
            {
                row[totalColumn] = total;

            }
            return filter;
        }

        private void Report_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            if (!e.Control && e.KeyCode == Keys.Home)
            {
                SourceGrid.Position current = grid.Selection.ActivePosition;
                SourceGrid.Position now = new SourceGrid.Position(current.Row, 0);

                grid.Selection.Focus(now, true);
            }

            if (!e.Control && e.KeyCode == Keys.End)
            {
                SourceGrid.Position current = grid.Selection.ActivePosition;

                if (current.Column == -1 || current.Row == -1)
                    return;

                SourceGrid.Position now = new SourceGrid.Position(current.Row, grid.Columns.Count - 1);

                grid.Selection.Focus(now, true);
            }

            if (e.Control && e.KeyCode == Keys.Home)
            {
                SourceGrid.Position current = grid.Selection.ActivePosition;
                SourceGrid.Position now = new SourceGrid.Position(1, current.Column);

                grid.Selection.Focus(now, true);
            }

            if (e.Control && e.KeyCode == Keys.End)
            {
                SourceGrid.Position current = grid.Selection.ActivePosition;

                if (current.Column == -1 || current.Row == -1)
                    return;

                SourceGrid.Position now = new SourceGrid.Position(grid.Rows.Count - 1, current.Column);

                grid.Selection.Focus(now, true);
            }

            if (e.Control && e.KeyCode == Keys.F)
                toolStripMenuItem3_Click(null, null);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Core.export(Text, grid.DataTable);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Printer.PrintListView(Text, list);
            Printer.PrintDataTable(Text, grid.DataTable);
        }

        private void Report_Shown(object sender, EventArgs e)
        {
            if (storage.Rows.Count == 0
                && addMenuItem.Visible == false
                && editMenuItem.Visible == false
                && deleteMenuItem.Visible == false)
            {
                Hide();
                MessageBox.Show("The report returned no information.");
                Close();
            }
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (list.SelectedIndices.Count > 0)
            //{
            //    toolStripStatusLabel1.Text = "Row " + (list.SelectedIndices[0] + 1) + " of " + storage.Rows.Count;

            //    if (list.SelectedIndices[0] + 1 == list.Items.Count)
            //    {
            //        for(int i = 1; i <= 100; i++)
            //            loadItem(list.SelectedIndices[0] + i);
            //    }
            //}
        }

        private void whereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string x = "";
            bool success = false;

            //Where filterForm = new Where(grid.DataTable);
            //filterForm.ShowDialog();

            do
            {
                x = Core.getString("Where...", x, out success);

                if (!success)
                    return;

                grid.DataTable = filter(grid.DataTable, x, out success);

                if(success)
                    addUnfilter(x);
            } while (!success);
        }

        public void addUnfilter(string text)
        {
            unfilterMenuItem.Visible = true;
            Font font = new Font(menuStrip1.Font.FontFamily, 12);

            if (unfilterMenuItem.DropDownItems.Count == 0)
            {
                ToolStripMenuItem removeAll = new ToolStripMenuItem();
                removeAll.Text = "Remove all filters";
                removeAll.Image = Properties.Resources.False;
                removeAll.Click += Item_Click_All;
                removeAll.Font = font;
                unfilterMenuItem.DropDownItems.Add(removeAll);

                ToolStripSeparator line = new ToolStripSeparator();
                unfilterMenuItem.DropDownItems.Add(line);
            }                

            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Text = text;
            item.Image = Properties.Resources.False;
            item.Click += Item_Click;
            item.Tag = "Dynamic";
            item.Font = font;
            unfilterMenuItem.DropDownItems.Add(item);
        }

        private void Item_Click(object sender, EventArgs e)
        {
            unfilterMenuItem.DropDownItems.Remove(sender as ToolStripMenuItem);
            DataTable temp = original;
            int count = 0;

            for (int i = 0; i < unfilterMenuItem.DropDownItems.Count; i++)
            {
                if (unfilterMenuItem.DropDownItems[i].Tag != null && unfilterMenuItem.DropDownItems[i].Tag.ToString() == "Dynamic")
                {
                    DataRow[] result = temp.Select(unfilterMenuItem.DropDownItems[i].Text);

                    if (result.Length > 0)
                        temp = result.CopyToDataTable();
                    else
                        temp.Rows.Clear();
                    
                    count++;
                }
            }

            if (count == 0)
            {
                unfilterMenuItem.DropDownItems.Clear();
                unfilterMenuItem.Visible = false;
            }

            grid.DataTable = temp;
        }

        private void Item_Click_All(object sender, EventArgs e)
        {

            unfilterMenuItem.DropDownItems.Clear();
            unfilterMenuItem.Visible = false;

            grid.DataTable = original;
            if(Text == "POS Summary")
            {
                DataRow row = (DataRow)grid.DataTable.Rows[grid.DataTable.Rows.Count - 1];
                row["PAYMENT_AMT"] = DBNull.Value;
                var total = grid.DataTable.Compute("Sum(PAYMENT_AMT)", "").ToString();

                row["PAYMENT_AMT"] = total;
            }
            if (Text == "Post Dated Cheque Summary")
            {
                DataRow row = (DataRow)grid.DataTable.Rows[grid.DataTable.Rows.Count - 1];
                row["AMT"] = DBNull.Value;
                var total = grid.DataTable.Compute("Sum(AMT)", "").ToString();

                row["AMT"] = total;
            }

        }

        public static DataTable filter(DataTable dt, string filter, out bool success)
        {
            try
            {
                DataRow[] result = dt.Select(filter);         
                if (result.Length > 0)
                    dt = result.CopyToDataTable();
                else
                    dt = dt.Clone(); //Structure without data
                
                success = true;
            }
            catch (Exception e2)
            {
                if (e2.Message.Contains("Cannot perform '<>' operation")
                    && filter.Contains("<> ''"))
                {
                    filter = filter.Replace("<> ''", "is not null");

                    return Report.filter(dt, filter, out success);
                } else if(e2.Message.Contains("Cannot perform '=' operation")
                 && filter.Contains("= ''"))
                {
                    filter = filter.Replace("= ''", "is null");

                    return Report.filter(dt, filter, out success);
                }

                MessageBox.Show("Something didn't quite work right. Possible syntax error." + Environment.NewLine
                    + Environment.NewLine
                    + Core.getErrorText(e2));

                success = false;
            }

            return dt;
        }

        private void unfilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //storage = original;
            //grid.DataTable = storage;
        }

        private void testToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            const string countColumnName = "Count";
            string valueColumn = "";

            List<string> numericColumnsNames = new List<string>();
            List<string> dateColumnNames = new List<string>();
            List<string> lineColumnNames = new List<string>();

            List<string> viableTypes = new List<string>();

            Dashboard dashboard = new Dashboard("Dashboard");
            Graph graph = null;
            string textX = "";
            string textY = "";

            DataTable dt = grid.DataTable.Copy();

            if (grid.Columns.Count == 0)
            {
                MessageBox.Show("Not enough columns to graph.");
                return;
            }

            //Calculate viable columns
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                Type t = grid.DataTable.Columns[i].DataType;
                if (t == typeof(sbyte)
                        || t == typeof(short)
                        || t == typeof(int)
                        || t == typeof(long)
                        || t == typeof(ushort)
                        || t == typeof(uint)
                        || t == typeof(ulong)
                        || t == typeof(decimal)
                        || t == typeof(double)
                        || t == typeof(float))
                {
                    numericColumnsNames.Add(grid.DataTable.Columns[i].ColumnName);
                    lineColumnNames.Add(grid.DataTable.Columns[i].ColumnName);
                }
                else if (t == typeof(DateTime))
                {
                    dateColumnNames.Add(grid.DataTable.Columns[i].ColumnName);
                    lineColumnNames.Add(grid.DataTable.Columns[i].ColumnName);
                }
                else if (t == typeof(Guid)
                        || t == typeof(bool)
                        || t == typeof(byte)
                        || t == typeof(char)
                        || t == typeof(string)
                        || t == typeof(TimeSpan))
                {
                    //Other types
                }
            }

            //Technically could do with 1 column if you use "count"
            viableTypes.Add("Bar");
            viableTypes.Add("Pie");

            if (numericColumnsNames.Count >= 1 && (numericColumnsNames.Count + dateColumnNames.Count >= 2))
                viableTypes.Add("Line");

            //Get information
            string graphType = Core.lookupMessageBox("Graph type", "Select graph type.", viableTypes.ToArray());
            if (graphType == "")
                return;

            //Create graph
            if (graphType == "Bar")
            {
                textX = "Select column containing the names of each bar";
                textY = "Select column containing the values for the Y axis";
                graph = new BarGraph();
            }
            else if (graphType == "Pie")
            {
                textX = "Select column containing categories to name each slice";
                textY = "Select column containing the values for the size of the pie slices";
                graph = new PieGraph();
            }
            else if (graphType == "Line")
            {
                textX = "Select column containing numbers/dates for the X axis";
                textY = "Select column containing the values for the Y axis";
                graph = new LineGraph();
            }

            graph.GraphTitle = Text;

            //Get columns
            string groupByColumn = "";

            if (Core.isIn(graphType, "Bar", "Pie"))
                groupByColumn = Core.lookupDropdown(textX, storage.Columns);
            else if (Core.isIn(graphType, "Line"))
                groupByColumn = Core.lookupDropdown(textX, lineColumnNames.ToArray());

            if (groupByColumn == "")
                return;

            if (graphType == "Line")
            {
                valueColumn = Core.lookupDropdown(textY, numericColumnsNames.ToArray());
                if (valueColumn == "")
                    return;
            }
            else
            {
                //How would you like to aggregate the data?
                viableTypes = new List<string>();

                numericColumnsNames.Remove(groupByColumn); //If you group by this, it can't be used elsewhere

                if (numericColumnsNames.Count > 0)
                    viableTypes.Add("Sum");

                viableTypes.Add("Count");

                string aggregateMethod = "";

                aggregateMethod = Core.lookupMessageBox("How to present data", "Would you like to sum the values or count them?" + Environment.NewLine
                    + "Some types may not show if your report doesn't have enough numeric columns.", viableTypes.ToArray());

                if (aggregateMethod == "Sum")
                {
                    valueColumn = Core.lookupDropdown(textY, numericColumnsNames.ToArray());
                    if (valueColumn == "")
                        return;
                }

                //Group data by category
                for (int i = dt.Columns.Count - 1; i >= 0; i--)
                    if (dt.Columns[i].ColumnName != groupByColumn && (dt.Columns[i].ColumnName != valueColumn || aggregateMethod == "Count"))
                        dt.Columns.RemoveAt(i);

                if (aggregateMethod == "Count") //You don't count a specific column, so we use some magic here
                {
                    dt.Columns.Add(countColumnName);
                    valueColumn = countColumnName;
                }

                dt = dt.AsEnumerable()
                  .GroupBy(r => r[groupByColumn])
                  .Select(g =>
                  {
                      var row = dt.NewRow();

                      row[groupByColumn] = g.Key;

                      if (aggregateMethod == "Sum")
                          row[valueColumn] = g.Sum(r => Convert.ToDouble(r[valueColumn]));

                      if (aggregateMethod == "Count")
                          row[valueColumn] = dt.AsEnumerable().Count(r => r[groupByColumn].ToString() == row[groupByColumn].ToString());

                      return row;
                  })//.OrderBy(r => r[group])
                  .CopyToDataTable();
            }

            //Populate graph
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                double value;
                bool parsed = double.TryParse(dt.Rows[i][valueColumn].ToString(), out value);

                if (!parsed)
                {
                    MessageBox.Show("In row " + (i + 1) + ", the value in the " + valueColumn + " column is \"" + dt.Rows[i][valueColumn].ToString() + "\"." + Environment.NewLine
                        + "This needs to be a number to work with the graphing framework.");

                    return;
                }

                graph.AddItem(dt.Rows[i][groupByColumn].ToString(), value);
            }
            
            dashboard.AddGraph(graph);
            
            dashboard.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(grid.DataTable.Rows.Count == original.Rows.Count)
                toolStripStatusLabel1.Text = "Returned " + grid.DataTable.Rows.Count + " rows";
            else
                toolStripStatusLabel1.Text = "Showing " + grid.DataTable.Rows.Count + " of " + original.Rows.Count + " rows";
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            bool success;
            string s = Core.getString("Find what?", out success).ToLower();

            if (!success)
                return;

            for (int c = 0; c < grid.DataTable.Columns.Count; c++)
            {
                if (grid.DataTable.Columns[c].ColumnName.ToLower().Contains(s))
                {
                    grid.SelectCell(0, c);
                    return;
                }
            }

            for (int r = 0; r < grid.DataTable.Rows.Count; r++)
            {
                for (int c = 0; c < grid.DataTable.Columns.Count; c++)
                {
                    if (grid.DataTable.Rows[r][c].ToString().ToLower().Contains(s))
                    {
                        grid.SelectCell(r, c);
                        return;
                    }
                }
            }

            MessageBox.Show("Text not found.");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (grid.SelectedDataRows.Count() > 0)
            {
                selectedRow = ((DataRowView)grid.SelectedDataRows[0]).Row;
                Close();
            }
            else
                MessageBox.Show("Please click on the row you would like selected.");
        }

        private void refreshData()
        {
            DataTable dt = db.Run();
            original = dt;
            grid.DataTable = dt;
        }

        private void addMenuItem_Click(object sender, EventArgs e)
        {
            Add_Click(sender, e);
            refreshData();
        }

        private void editMenuItem_Click(object sender, EventArgs e)
        {
            if (grid.SelectedDataRows.Count() > 0)
            {
                selectedRow = ((DataRowView)grid.SelectedDataRows[0]).Row;
                Edit_Click(sender, e);
                refreshData();
            }
            else
                MessageBox.Show("Please click on the row you would like to edit.");
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            if (grid.SelectedDataRows.Count() > 0)
            {
                selectedRow = ((DataRowView)grid.SelectedDataRows[0]).Row;
                Delete_Click(sender, e);
                refreshData();
            }
            else
                MessageBox.Show("Please click on the row you would like to edit.");
        }

        internal void DeleteRow_Click(object sender, EventArgs e)
        {
            string column = (sender as MenuItem).Tag.ToString();
            DataColumn dataColumn = grid.DataTable.Columns[column.Split(separator)[0]];
            string[] selectedColumns = column.Split(separator);
            column = selectedColumns[0];
            string value = selectedColumns[1];
            DataRow[] foundRows = grid.DataTable.Select("ID = " + value);
            if (column == "ID")
            {
                DateTime tranDate = Convert.ToDateTime(foundRows[0]["TRAN_DATE"].ToString());
                if(tranDate.Date > DateTime.Now.Date)
                {
                    //test2
                    var businessDays = CalculateTenBusinessDaysFromInputDate(tranDate);
                    if (businessDays.Date >= DateTime.Now.Date)
                    {
                        grid.DeleteSelectedRows();
                        grid.Refresh();
                        TXM ora = new TXM("BEGIN delete from txmadm.temppymt where ID = @ID; COMMIT; END;");
                        ora.AddParameter("@ID", value);
                        ora.Run();
                    }
                    else
                    {
                        MessageBox.Show("Transaction date is less then 5 business days. Contact IT if you need it deleted");
                    }
                }               
                else
                {
                    MessageBox.Show("Transaction date is less then 5 business days. Contact IT if you need it deleted");
                }             
            }               
        }

        public System.DateTime CalculateTenBusinessDaysFromInputDate(System.DateTime StartDate)
        {
            //This simply adds at least 2 full weeks to the start date.
            var workDays = 6;
            DateTime tmpDate = StartDate;
            while (workDays > 0)
            {
                tmpDate = tmpDate.AddDays(1);
                if (tmpDate.DayOfWeek < DayOfWeek.Saturday &&
                    tmpDate.DayOfWeek > DayOfWeek.Sunday)                 
                    workDays--;
            }
            return tmpDate;
        }
    }

    //Configuring alternating colours for rows
    public class CellBackColorAlternate : SourceGrid.Cells.Views.Cell
    {
        public CellBackColorAlternate(Color firstColor, Color secondColor)
        {
            FirstBackground = new DevAge.Drawing.VisualElements.BackgroundSolid(firstColor);
            SecondBackground = new DevAge.Drawing.VisualElements.BackgroundSolid(secondColor);
        }

        private DevAge.Drawing.VisualElements.IVisualElement mFirstBackground;
        public DevAge.Drawing.VisualElements.IVisualElement FirstBackground
        {
            get { return mFirstBackground; }
            set { mFirstBackground = value; }
        }

        private DevAge.Drawing.VisualElements.IVisualElement mSecondBackground;
        public DevAge.Drawing.VisualElements.IVisualElement SecondBackground
        {
            get { return mSecondBackground; }
            set { mSecondBackground = value; }
        }

        protected override void PrepareView(SourceGrid.CellContext context)
        {
            base.PrepareView(context);

            if (Math.IEEERemainder(context.Position.Row, 2) == 0)
                Background = FirstBackground;
            else
                Background = SecondBackground;
        }
    }

    //Configuring right-click menu
    public class PopupMenu : SourceGrid.Cells.Controllers.ControllerBase
    {
        Report r;
        ContextMenu menu = new ContextMenu();
        SourceGrid.CellContext cell;

        public PopupMenu(Report sender)
        {
            this.r = sender;
        }

        public override void OnMouseUp(SourceGrid.CellContext sender, MouseEventArgs e)
        {
            base.OnMouseUp(sender, e);
            cell = sender;

            if (e.Button == MouseButtons.Right)
            {
                SourceGrid.DataGrid grid = cell.Grid as SourceGrid.DataGrid;
                SourceGrid.Cells.ICellVirtual header = grid.GetCell(0, cell.Position.Column);
                Type type;

                try
                {
                    type = grid.DataTable.Columns[cell.Position.Column].DataType;
                }
                catch
                {
                    return;
                }
                bool isString = type == typeof(String) || type == typeof(DateTime);

                string column = header.Model.ValueModel.GetValue(cell).ToString();
                string alias = column;

                if(alias.Contains("(") && alias.Contains(")"))
                {
                    try
                    {
                        alias = alias.Substring(alias.IndexOf("(")).Replace("(", "").Replace(")", "").Trim();
                    }
                    catch
                    {

                    }
                }

                string value = cell.DisplayText;

                menu.MenuItems.Clear();

                bool isUDCCol = Report.isUDCColumn(alias);

                if (isUDCCol)
                {
                    if (cell.Position.Row == 0)
                    {
                        string columnDescription = Report.getJDEDesc(alias);
                        menu.MenuItems.Add("Lookup in UDC table", new EventHandler(UDC_Click));
                        menu.MenuItems.Add("-");
                    }
                    else
                    {
                        string udcValue = getUDCValue(alias, value);
                        menu.MenuItems.Add("Lookup in UDC table (\"" + udcValue + "\")", new EventHandler(UDC_Click));
                        menu.MenuItems.Add("-");
                    }
                }
                //else
                //{
                //    if (cell.Position.Row == 0)
                //    {
                //        string columnDescription = Report.getJDEDesc(alias);
                //        menu.MenuItems.Add("\"" + columnDescription + "\"");
                //        menu.MenuItems.Add("-");
                //    }
                //}

                MenuItem item;

                if (cell.Position.Row == 0) //If header
                {
                    item = new MenuItem("Filter where \"" + column + "\" is a specific value", new EventHandler(r.Equals_Click));
                    item.Tag = column;
                    menu.MenuItems.Add(item);

                    item = new MenuItem("Filter where \"" + column + "\" is not a specific value", new EventHandler(r.NotEquals_Click));
                    item.Tag = column;
                    menu.MenuItems.Add(item);

                    if (isString)
                    {
                        item = new MenuItem("Filter where \"" + column + "\" contains specific text", new EventHandler(r.Contains_Click));
                        item.Tag = column;
                        menu.MenuItems.Add(item);

                        item = new MenuItem("Filter where \"" + column + "\" does not contain specific text", new EventHandler(r.NotContains_Click));
                        item.Tag = column;
                        menu.MenuItems.Add(item);
                    }

                    item = new MenuItem("Filter where \"" + column + "\" is within a list", new EventHandler(r.List_Click));
                    item.Tag = column;
                    menu.MenuItems.Add(item);

                    item = new MenuItem("Filter where \"" + column + "\" is not within a list", new EventHandler(r.NotList_Click));
                    item.Tag = column;
                    menu.MenuItems.Add(item);

                    item = new MenuItem("Filter where \"" + column + "\" is less than a specific value", new EventHandler(r.LessThan_Click));
                    item.Tag = column;
                    menu.MenuItems.Add(item);

                    item = new MenuItem("Filter where \"" + column + "\" is less than or equal to a specific value", new EventHandler(r.LessThanEq_Click));
                    item.Tag = column;
                    menu.MenuItems.Add(item);

                    item = new MenuItem("Filter where \"" + column + "\" is greater than a specific value", new EventHandler(r.GreaterThan_Click));
                    item.Tag = column;
                    menu.MenuItems.Add(item);

                    item = new MenuItem("Filter where \"" + column + "\" is greater than or equal to a specific value", new EventHandler(r.GreaterThanEq_Click));
                    item.Tag = column;
                    menu.MenuItems.Add(item);
                }
                else if (cell.Position.Row > 0) //If on a specific cell
                {
                    item = new MenuItem("Filter where \"" + column + "\" is \"" + value + "\"", new EventHandler(r.Equals_Click));
                    item.Tag = column + r.separator + value;
                    menu.MenuItems.Add(item);

                    item = new MenuItem("Filter where \"" + column + "\" is not \"" + value + "\"", new EventHandler(r.NotEquals_Click));
                    item.Tag = column + r.separator + value;
                    menu.MenuItems.Add(item);

                    item = new MenuItem("Filter where \"" + column + "\" is less than \"" + value + "\"", new EventHandler(r.LessThan_Click));
                    item.Tag = column + r.separator + value;
                    menu.MenuItems.Add(item);

                    item = new MenuItem("Filter where \"" + column + "\" is less than or equal to \"" + value + "\"", new EventHandler(r.LessThanEq_Click));
                    item.Tag = column + r.separator + value;
                    menu.MenuItems.Add(item);

                    item = new MenuItem("Filter where \"" + column + "\" is greater than \"" + value + "\"", new EventHandler(r.GreaterThan_Click));
                    item.Tag = column + r.separator + value;
                    menu.MenuItems.Add(item);

                    item = new MenuItem("Filter where \"" + column + "\" is greater than or equal to \"" + value + "\"", new EventHandler(r.GreaterThanEq_Click));
                    item.Tag = column + r.separator + value;
                    menu.MenuItems.Add(item);
                    if(column == "ID")
                    {
                        SQL sql = new SQL("select * from postdatepermission where username=@USERNAME");
                        sql.AddParameter("@USERNAME", Core.getUsername());
                        var userTable = sql.Run();
                        if(userTable.Rows.Count > 0)
                        {
                            item = new MenuItem("Delete where \"" + column + "\" is equal to \"" + value + "\"", new EventHandler(r.DeleteRow_Click));
                            item.Tag = column + r.separator + value;
                            menu.MenuItems.Add(item);
                        }
                        
                    }                   
                }
                
                menu.Show(sender.Grid, new Point(e.X, e.Y));
            }
        }

        private string getUDCValue(string column, string value)
        {
            try
            {
                string dataItem = column.Substring(2);
                DataTable dt = Oracle.Run("select FROER1, FROER2 from DD910.F9210 where trim(FRDTAI) = '" + dataItem + "' and trim(FROWER) = 'UDC'");

                if(dt.Rows.Count > 0)
                {
                    string udc1 = dt.Rows[0]["FROER1"].ToString().Trim();
                    string udc2 = dt.Rows[0]["FROER2"].ToString().Trim();

                    return Oracle.RunString("select DRDL01 from CRPCTL.F0005 where trim(DRSY) = @UDC1 and trim(DRRT) = @UDC2 and trim(DRKY) = @UDCVAL", udc1, udc2, value.Trim()).Trim();
                }
                else
                {

                }
            }
            catch
            {

            }

            return "";
        }

        private void UDC_Click(object sender, EventArgs e)
        {
            SourceGrid.DataGrid grid = cell.Grid as SourceGrid.DataGrid;
            SourceGrid.Cells.ICellVirtual header = grid.GetCell(0, cell.Position.Column);

            string column = header.Model.ValueModel.GetValue(cell).ToString();
            string alias = column;

            if (alias.Contains("(") && alias.Contains(")"))
            {
                try
                {
                    alias = alias.Substring(alias.IndexOf("(")).Replace("(", "").Replace(")", "").Trim();
                }
                catch
                {

                }
            }

            string dataItem = alias.Substring(2);
            DataTable dt = Oracle.Run("select FROER1, FROER2 from DD910.F9210 where trim(FRDTAI) = '" + dataItem + "' and trim(FROWER) = 'UDC'");

            if (dt.Rows.Count > 0)
            {
                string udc1 = dt.Rows[0]["FROER1"].ToString().Trim();
                string udc2 = dt.Rows[0]["FROER2"].ToString().Trim();

                dt = Oracle.Run("select * from CRPCTL.F0005 where trim(DRSY) = @UDC1 and trim(DRRT) = @UDC2 order by DRKY", udc1, udc2);

                Report r = new Report("UDC Lookup " + udc1 + "/" + udc2, dt);
                r.Show();
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(cell.DisplayText);
        }
    }

    //Configuring when a value changes
    public class ValueChangedEvent : SourceGrid.Cells.Controllers.ControllerBase
    {
        public override void OnValueChanged(SourceGrid.CellContext sender, EventArgs e)
        {
            base.OnValueChanged(sender, e);
        }
    }
}
