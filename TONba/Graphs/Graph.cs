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
    public abstract partial class Graph : UserControl
    {
        public string title = "";
        public int margin = 50;
        public const float speed = 0.03F;

        public List<Color> colourList = new List<Color>();
        public List<GraphItem> items = new List<GraphItem>();

        public Graphics g;
        public Bitmap bm = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

        public Point mouse = new Point();
        
        public Database data;
        public Database itemClickData = null;

        public static Font titleFont = new Font(new FontFamily("Segoe UI"), 20, FontStyle.Bold);
        public static Font font = new Font(new FontFamily("Calibri Light"), 11);
        public static Font boldFont = new Font(font, FontStyle.Bold);
        public static Color titleColour = Color.FromArgb(50, 50, 50);

        public Graph()
        {
            setup();
        }

        public Graph(Database input)
        {
            setup();

            data = input;
            RefreshData();
        }

        public void setup()
        {
            Width = 400;
            Height = 300;

            InitializeComponent();

            colourList.Add(Color.FromArgb(255, 59, 48));
            colourList.Add(Color.FromArgb(255, 149, 0));
            colourList.Add(Color.FromArgb(255, 204, 0));
            colourList.Add(Color.FromArgb(76, 217, 100));
            colourList.Add(Color.FromArgb(90, 200, 250));
            colourList.Add(Color.FromArgb(0, 122, 255));
            colourList.Add(Color.FromArgb(88, 86, 214));
            colourList.Add(Color.FromArgb(255, 45, 85));


            DoubleBuffered = true;

            //Link graphics handler to bitmap
            g = Graphics.FromImage(bm);

            //Anti-aliasing
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            //Fill bitmap with white
            g.Clear(Color.White);

            Graph_SizeChanged(null, null);
        }

        public Color getColour()
        {
            return colourList[items.Count % colourList.Count];
        }

        public void RefreshData()
        {
            if (data != null)
            {
                DataTable dt = data.Run();

                if (dt.Columns.Count < 2)
                    throw new Exception("Graph data doesn't have enough columns.");

                //Add, update
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string label = dt.Rows[i][0].ToString();
                    double value;

                    try
                    {
                        value = double.Parse(dt.Rows[i][1].ToString());
                    }
                    catch
                    {
                        throw new Exception("Graph data in column index 1 can't be parsed to double. Data is: " + dt.Rows[i][1].ToString());
                    }

                    int index = itemExists(label);

                    if (index != -1) //Exists at index
                    {
                        items[index].label = label;
                        items[index].value = value;
                    }
                    else //Doesn't exist yet
                        AddItem(label, value);
                }

                //Delete
                for (int i = items.Count - 1; i >= 0; i--)
                {
                    bool found = false;

                    for (int j = 0; j < dt.Rows.Count && !found; j++)
                    {
                        string label = dt.Rows[j][0].ToString();

                        if (items[i].label == label)
                            found = true;
                    }

                    if (!found)
                        items[i].toBeDeleted = true;
                }
            }
        }

        public abstract void PaintGraph(object sender, EventArgs e);

        public void Graph_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            e.Graphics.DrawImage(bm, 0, 0);
        }

        [Description("Title to display on the graph"), Category("Graph")]
        public string GraphTitle
        {
            get { return title; }
            set { title = value; }
        }

        public abstract bool overlap(GraphItem item, Point mouseLocation);

        public abstract void Reset();
                
        public abstract void AddItem(string label, double value);
        public abstract void AddItem(string label, double value, Color colour);

        public void Graph_MouseMove(object sender, MouseEventArgs e)
        {
            mouse = e.Location;
        }

        public void Graph_MouseDown(object sender, MouseEventArgs e)
        {
            bool found = false;

            if(itemClickData != null)
            {
                for (int i = 0; i < items.Count && !found; i++)
                {
                    if (overlap(items[i], mouse))
                    {
                        itemClickData.ClearParameters();

                        itemClickData.AddParameter("@VAR", items[i].label);

                        Report r = new Report(title + " - " + items[i].label, itemClickData.Run());
                        r.Show();

                        found = true;
                    }
                }
            }
        }

        public void Graph_SizeChanged(object sender, EventArgs e)
        {
            margin = Math.Max((Width + Height) / 12, 50);
        }

        private int itemExists(string label)
        {
            for (int i = 0; i < items.Count; i++)
                if (items[i].label == label)
                    return i;

            return -1;
        }
    }

    public class GraphItem
    {
        public double value;
        public Color colour;
        public string label;
        public bool toBeDeleted;
    }
}
