using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class QueryPanel : UserControl
    {
        private Point MouseDownLocation;

        public QueryPanel()
        {
            InitializeComponent();
        }

        private void QueryPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                // move to dest LV

                //e = Mouse relative to screen
                //Location = QueryPanel relative to containing form
                //Parent = Containing form relative to screen

                int x = e.X - Location.X - Parent.Location.X - 9;
                int y = e.Y - Location.Y - Parent.Location.Y - 32;

                QueryTable table = new QueryTable();
                table.Location = new Point(x, y);
                table.tableName = item.Text;

                Controls.Add(table);

                table.BringToFront();
            }
        }

        private void QueryPanel_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the Dataformat of the data can be accepted
            // (we only accept file drops from Explorer, etc.)
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
                e.Effect = DragDropEffects.Copy; // Okay
            else
                e.Effect = DragDropEffects.None; // Unknown data, ignore it
        }

        private void QueryPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = this.PointToScreen(e.Location);
                var formLocation = FindForm().Location;
                MouseDownLocation.X -= formLocation.X;
                MouseDownLocation.Y -= formLocation.Y;
            }
        }

        private void QueryPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X - Location.X - Parent.Location.X - 9;
                int y = e.Y - Location.Y - Parent.Location.Y - 32;

                Point newLocation = new Point(x, y);

                for (int i = 0; i < Controls.Count; i++)
                    Controls[i].Location = newLocation;
            }
        }
    }
}
