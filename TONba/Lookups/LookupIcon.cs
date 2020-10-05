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
    public partial class LookupIcon : Form
    {
        public string r = "";

        public LookupIcon(ImageList icons, string current)
        {
            InitializeComponent();

            iconView.SmallImageList = icons;
            iconView.LargeImageList = icons;
            iconView.Items.Clear();

            for(int i = 0; i < icons.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = icons.Images.Keys[i];
                item.ImageKey = icons.Images.Keys[i];
                iconView.Items.Add(item);
            }
        }

        private void AddPermission_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void iconView_MouseClick(object sender, MouseEventArgs e)
        {
            if (iconView.SelectedItems.Count > 0)
                r = iconView.SelectedItems[0].Tag.ToString();

            Close();
        }
    }
}
