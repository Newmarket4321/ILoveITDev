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
    public partial class Where : Form
    {
        DataTable dt = null;
        int y = 0;
        static int verticalBuffer = 2;

        public Where(DataTable table)
        {
            InitializeComponent();

            dt = table;

            addRow();
            addRow();
            addRow();
        }

        private void addRow()
        {
            ComboBox columns = new ComboBox();
            columns.Location = new Point(0, y);

            ComboBox methods = new ComboBox();
            methods.Location = new Point(0, y);

            for (int i = 0; i < dt.Columns.Count; i++)
                columns.Items.Add(dt.Columns[i].ColumnName);

            methods.Items.Add("");
            methods.Items.Add("Is exactly");
            methods.Items.Add("Is anything but");
            methods.Items.Add("Is greater than");
            methods.Items.Add("Is greater than or equal to");
            methods.Items.Add("Is less than");
            methods.Items.Add("Is less than or equal to");
            methods.Items.Add("Starts with");
            methods.Items.Add("Ends with");
            methods.Items.Add("Contains");
            methods.Items.Add("Does not contain");
            methods.Items.Add("Between");
            methods.Items.Add("");

            Controls.Add(columns);
            Controls.Add(methods);

            y += methods.Height + verticalBuffer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
