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
    public partial class QueryTable : UserControl
    {
        public string tableName
        {
            get
            {
                return label1.Text;
            }

            set
            {
                label1.Text = value;
            }
        }

        public QueryTable()
        {
            InitializeComponent();
        }

        private void QueryTable_Click(object sender, EventArgs e)
        {
            BringToFront();
        }
    }
}
