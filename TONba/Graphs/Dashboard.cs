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
    public partial class Dashboard : Form
    {
        int numGraphs = 0;
        List<Graph> graphs = new List<Graph>();

        public Dashboard(string title)
        {
            InitializeComponent();
            
            Text = title;
        }

        public void AddGraph(Graph graph)
        {
            Controls.Add(graph);
            graphs.Add(graph);

            numGraphs++;

            Dashboard_SizeChanged(null, null);
        }

        private void Report_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void Dashboard_SizeChanged(object sender, EventArgs e)
        {
            if (numGraphs == 1)
            {
                graphs[0].Location = new Point(0, 0);
                graphs[0].Size = new Size(Width, Height - 39);
            }
            else if (numGraphs == 2)
            {
                graphs[0].Location = new Point(0, 0);
                graphs[0].Size = new Size(Width / 2, Height - 39);

                graphs[1].Location = new Point(Width / 2, 0);
                graphs[1].Size = new Size(Width / 2, Height - 39);
            }
            else if (numGraphs == 3)
            {
                graphs[0].Location = new Point(0, 0);
                graphs[0].Size = new Size(Width, (Height - 39) / 2);

                graphs[1].Location = new Point(0, (Height - 39) / 2);
                graphs[1].Size = new Size(Width / 2, (Height - 39) / 2);

                graphs[2].Location = new Point(Width / 2, (Height - 39) / 2);
                graphs[2].Size = new Size(Width / 2, (Height - 39) / 2);
            }
            else if (numGraphs == 4)
            {
                graphs[0].Location = new Point(0, 0);
                graphs[0].Size = new Size(Width / 2, (Height - 39) / 2);

                graphs[1].Location = new Point(Width / 2, 0);
                graphs[1].Size = new Size(Width / 2, (Height - 39) / 2);

                graphs[2].Location = new Point(0, (Height - 39) / 2);
                graphs[2].Size = new Size(Width / 2, (Height - 39) / 2);

                graphs[3].Location = new Point(Width / 2, (Height - 39) / 2);
                graphs[3].Size = new Size(Width / 2, (Height - 39) / 2);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < graphs.Count; i++)
                graphs[i].RefreshData();
        }
    }
}
