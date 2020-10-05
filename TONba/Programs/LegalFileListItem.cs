using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace I_IT
{
    public partial class LegalFileListItem : Form
    {
        public LegalFileListItem() //New
        {
            InitializeComponent();
        }

        public LegalFileListItem(int id) : this() //Edit
        {

        }

        private void JostleAccountBlocker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void dateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            DateTimePicker s = sender as DateTimePicker;

            s.Format = DateTimePickerFormat.Custom;
            s.CustomFormat = " ";
        }

        private void dateTimePicker_CloseUp(object sender, EventArgs e)
        {
            DateTimePicker s = sender as DateTimePicker;

            s.Format = DateTimePickerFormat.Long;
        }
    }
}
