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
    public partial class ReportBackup : Form
    {
        DataTable original = null;
        DataTable storage = null;
        int currentSort = -1;
        
        public ReportBackup(string title, DataTable dt)
        {
            InitializeComponent();

            Text = title;
            toolStripStatusLabel1.Text = "";

            original = dt;
            storage = dt;

            ControlExtensions.DoubleBuffering(list, true);
        }

        public void Setup()
        {
            try
            {
                Invoke((MethodInvoker)delegate
                {
                    list.BeginUpdate();

                    list.Columns.Clear();
                    list.Items.Clear();

                    for (int i = 0; i < storage.Columns.Count; i++)
                        list.Columns.Add(storage.Columns[i].ColumnName);

                    toolStripProgressBar1.Value = 0;
                    toolStripProgressBar1.Maximum = storage.Rows.Count;
                    toolStripProgressBar1.Visible = true;

                    for (int i = 0; i < storage.Rows.Count; i++)
                    {
                        loadItem(i);
                        toolStripProgressBar1.Value = i;

                        toolStripStatusLabel1.Text = "Loaded " + (i+1) + " of " + storage.Rows.Count + " rows";
                        statusStrip1.Update();
                    }

                    toolStripProgressBar1.Value = toolStripProgressBar1.Maximum;
                    statusStrip1.Update();

                    toolStripProgressBar1.Visible = false;

                    for (int i = 0; i < list.Columns.Count; i++)
                        list.Columns[i].Width = -2;

                    list.EndUpdate();

                    //vScrollBar1.Maximum = dt.Rows.Count - 1 + (vScrollBar1.LargeChange - 1); //(LargeCharge - 1) because of the height of the height of the scrollbar's slider
                    //Bad design by Microsoft, but this workaround should suffice.

                    toolStripStatusLabel1.Text = "Returned " + storage.Rows.Count + " rows";
                });
            }
            catch
            {

            }
        }

        private void loadItem(int i)
        {
            if (i < storage.Rows.Count)
            {
                string[] data = new string[storage.Columns.Count];

                for (int j = 0; j < storage.Columns.Count; j++)
                    data[j] = storage.Rows[i][j].ToString();

                ListViewItem x = new ListViewItem(data);
                list.Items.Add(x);
            }
        }

        private void Report_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Core.export(Text, storage);
        }

        private void list_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            DataView dv = storage.DefaultView;
            dv.Sort = storage.Columns[e.Column].ColumnName + (currentSort == e.Column ? " desc" : " asc");
            storage = dv.ToTable();

            if (currentSort == e.Column)
                currentSort = -1;
            else
                currentSort = e.Column;

            Core.invoke(Setup);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Printer.PrintListView(Text, list);
            Printer.PrintDataTable(Text, storage);
        }

        private void Report_Shown(object sender, EventArgs e)
        {
            if (storage.Rows.Count == 0)
            {
                Hide();
                MessageBox.Show("The report returned no information.");
                Close();
            }
        }

        private void Report_Leave(object sender, EventArgs e)
        {
            //if (Text == "Timesheet History")
            //    Close();
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list.SelectedIndices.Count > 0)
            {
                toolStripStatusLabel1.Text = "Row " + (list.SelectedIndices[0] + 1) + " of " + storage.Rows.Count;

                if (list.SelectedIndices[0] + 1 == list.Items.Count)
                {
                    for(int i = 1; i <= 100; i++)
                        loadItem(list.SelectedIndices[0] + i);
                }
            }
        }

        private void whereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string x = "";
            bool success = false;

            do
            {
                x = Core.getString("Where...", x, out success);

                if (!success)
                    return;
                
                try
                {
                    DataRow[] result = storage.Select(x);

                    if (result.Length > 0)
                        storage = result.CopyToDataTable();
                    else
                        storage = new DataTable();

                    Core.invoke(Setup);

                    unfilterToolStripMenuItem.Visible = true;
                    success = true;
                }
                catch(Exception e2)
                {
                    MessageBox.Show("Something didn't quite work right. Possible syntax error." + Environment.NewLine
                        + Environment.NewLine
                        + Core.getErrorText(e2));
                }
            } while (!success);
        }

        private void unfilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            storage = original;
            Core.invoke(Setup);
            
            unfilterToolStripMenuItem.Visible = false;
        }

        private void testToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Get information
            string response = Core.lookupMessageBox("Graph type", "Select graph type.", "Bar", "Line", "Pie");
            
            if (response == "")
                return;
            
            string group = Core.lookupDropdown("Select column containing categories", storage.Columns);

            if (group == "")
                return;

            string data;

            if (storage.Columns.Count == 1)
                data = group;
            else if (storage.Columns.Count == 2)
                data = storage.Columns[(storage.Columns[group].Ordinal + 1) % 2].ColumnName;
            else
            {
                string[] newCols = new string[storage.Columns.Count - 1];

                int next = 0;

                for (int i = 0; i < storage.Columns.Count; i++)
                    if(i != storage.Columns[group].Ordinal) //If different
                        newCols[next++] = storage.Columns[i].ColumnName;

                data = Core.lookupDropdown("Select column containing numerical data", newCols);
            }

            if (data == "")
                return;

            //Create graph
            Dashboard db = new Dashboard("Dashboard");
            Graph graph = null;

            if (response == "Bar")
                graph = new BarGraph();
            else if (response == "Line")
                graph = new LineGraph();
            else if (response == "Pie")
                graph = new PieGraph();

            graph.GraphTitle = Text;

            //Group data by category
            DataTable dt = storage.Copy();

            for (int i = 0; i < dt.Columns.Count; i++)
                if (dt.Columns[i].ColumnName != group && dt.Columns[i].ColumnName != data)
                    dt.Columns.RemoveAt(i);

            dt = dt.AsEnumerable()
              .GroupBy(r => r[group])
              .Select(g =>
              {
                  var row = dt.NewRow();
                  Type t = dt.Columns[data].DataType;

                  row[group] = g.Key;
                  row[data] = g.Sum(r => Convert.ToDouble(r[data]));

                  return row;
              })//.OrderBy(r => r[group])
              .CopyToDataTable();

            //Populate graph
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                double value;
                bool parsed = double.TryParse(dt.Rows[i][data].ToString(), out value);

                if (!parsed)
                {
                    MessageBox.Show("In row " + (i + 1) + ", the value in the " + data + " column is \"" + dt.Rows[i][data].ToString() + "\"." + Environment.NewLine
                        + "This needs to be a number to work with the graphing framework.");

                    return;
                }

                graph.AddItem(dt.Rows[i][group].ToString(), value);
            }

            db.AddGraph(graph);

            db.ShowDialog();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Console.WriteLine("From " + e.OldValue + " to " + e.NewValue);

            list.SelectedItems.Clear();

            for (int i = list.Items.Count; i < e.NewValue + 50; i++)
                loadItem(i);

            if (e.NewValue < list.Items.Count)
            {
                list.Items[e.NewValue].Selected = true;
                list.Items[e.NewValue].EnsureVisible();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Core.invoke(Setup);
            timer1.Enabled = false;
        }
    }

    public static class ControlExtensions
    {
        public static void DoubleBuffering(this Control control, bool enable)
        {
            var method = typeof(Control).GetMethod("SetStyle", BindingFlags.Instance | BindingFlags.NonPublic);
            method.Invoke(control, new object[] { ControlStyles.OptimizedDoubleBuffer, enable });
        }
    }
}
