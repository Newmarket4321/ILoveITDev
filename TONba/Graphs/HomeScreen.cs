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
    public partial class HomeScreen : UserControl
    {
        public string title = "";
        public int margin = 10;
        public const float speed = 0.15F; //Move % of the remaining difference towards target
        public int scrollPos = 0;
        public int scrollBarWidth = 15;
        public int iconTextSpacing = 5;

        public List<Color> colourList = new List<Color>();
        public List<ScreenItem> programs = new List<ScreenItem>();
        public List<ScreenItem> groups = new List<ScreenItem>();
        public List<ScreenItem> viewList = new List<ScreenItem>();

        string openGroup = "";

        public Graphics g;
        public Bitmap bm = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

        public Point mouse = new Point();
        public Point mouseClickSpot = new Point();
        public bool draggingScrollbar = false;
        RectangleF scrollBarCursor = new RectangleF();

        public Database data;
        public Database itemClickData = null;

        public static Font titleFont = new Font(new FontFamily("Segoe UI"), 20, FontStyle.Bold);
        public static Font font = new Font(new FontFamily("Calibri Light"), 11);
        public static Font boldFont = new Font(font, FontStyle.Bold);
        public static Color titleColour = Color.FromArgb(50, 50, 50);

        public float itemHeight = 30;
        public float spacing = 3;
        public float iconSize = 32;
        public ImageList list;

        public HomeScreen()
        {
            setup();

            this.MouseWheel += HomeScreen_MouseWheel;
        }

        private void HomeScreen_MouseWheel(object sender, MouseEventArgs e)
        {
            moveScreenPos((e.Delta / Math.Abs(e.Delta)) * 120);
        }

        public int getMaxScrollPos()
        {
            return -1 * (int)(viewList[viewList.Count - 1].Bottom - viewList[0].Top + (2 * margin) - Bottom);
        }

        public bool isScrollable()
        {
            if (viewList.Count == 0)
                return false;
            else if (viewList[0].Top < 0 || viewList[viewList.Count - 1].Bottom > Height)
                return true;
            else
                return false;
        }

        public void moveScreenPos(int delta)
        {
            if (programs.Count == 0)
                return;
            else if (isScrollable())
            {
                scrollPos += delta;

                if (scrollPos > 0)
                    scrollPos = 0;

                if (scrollPos < getMaxScrollPos())
                    scrollPos = getMaxScrollPos();
            }
        }

        public void setup()
        {
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
        }

        public void AddItem(ScreenItem item)
        {
            item.type = ScreenItemType.Program;
            programs.Add(item);

            if (!groupExists(item.group))
            {
                ScreenItem group = new ScreenItem();
                group.hover = "Click to open group";
                group.icon = list.Images["Folder.png"];
                group.title = item.group;
                group.type = ScreenItemType.Group;
                groups.Add(group);
            }

            createViewList();
        }

        public bool groupExists(string name)
        {
            for (int i = 0; i < groups.Count; i++)
                if (groups[i].title == name)
                    return true;

            return false;
        }

        public void createViewList()
        {
            viewList.Clear();

            groups = groups.OrderBy(o => o.title).ToList();
            programs = programs.OrderBy(o => o.title).ToList();

            for (int i = 0; i < groups.Count; i++)
            {
                viewList.Add(groups[i]);

                if(openGroup == groups[i].title)
                {
                    for (int j = 0; j < programs.Count; j++)
                    {
                        programs[j].Left = groups[i].Left;
                        programs[j].Right = groups[i].Right;
                        programs[j].Bottom = groups[i].Bottom;
                        programs[j].Top = groups[i].Top;

                        if (programs[j].group == groups[i].title)
                        {
                            viewList.Add(programs[j]);
                        }
                    }
                }
            }

            if(groups.Count == 0)
                for (int i = 0; i < programs.Count; i++)
                    viewList.Add(programs[i]);
        }

        public void PaintGraph(object sender, EventArgs e)
        {
            float target;

            //Start with a clean slate
            g.Clear(Color.White);

            //Calculate how high each bar should be
            for(int i = 0; i < viewList.Count; i++)
            {
                ScreenItem item = viewList[i];
                
                if (item.type == ScreenItemType.Group || groups.Count == 0)
                    target = margin;
                else
                    target = margin + iconSize;
                
                item.Left += speed * (target - item.Left);

                target = Right - margin - (isScrollable() ? scrollBarWidth : 0);
                item.Right += speed * (target - item.Right);

                target = margin + i * (itemHeight + spacing) + scrollPos;
                item.Top += speed * (target - item.Top);

                item.Bottom = item.Top + itemHeight;
            }

            for (int i = 0; i < viewList.Count; i++)
                if(overlap(viewList[i], mouse))
                    g.FillRectangle(new SolidBrush(Color.FromArgb(224, 245, 254)), viewList[i].Left, viewList[i].Top, viewList[i].Right - viewList[i].Left, viewList[i].Bottom - viewList[i].Top);

            //Icon
            for (int i = 0; i < viewList.Count; i++)
            {
                ScreenItem item = viewList[i];
                SolidBrush brush = new SolidBrush(Color.Black);

                float x = item.Left;
                float y = item.Top;
                
                if(item.icon != null)
                    g.DrawImage(item.icon, x, y, iconSize, iconSize);
            }

            //Text
            for (int i = 0; i < viewList.Count; i++)
            {
                string s = viewList[i].title;

                ScreenItem item = viewList[i];

                float x = item.Left + iconSize + iconTextSpacing;
                float y = item.Top;

                g.DrawString(s, boldFont, new SolidBrush(Color.Black), x, y);
            }

            //Hover
            for (int i = 0; i < viewList.Count; i++)
            {
                if (overlap(viewList[i], mouse) && viewList[i] is ScreenItem)
                {
                    string s = viewList[i].hover;
                    
                    float xOffset = 10;
                    float yOffset = 0;
                    float x = mouse.X + xOffset;
                    float y = mouse.Y + yOffset;
                    float rightSide = isScrollable() ? Right - scrollBarWidth : Right;
                    
                    int boxMargin = 3; //Internal padding
                    int boxWidth = (int)(g.MeasureString(s, font, new SizeF(rightSide - x, Bottom - y), StringFormat.GenericTypographic).Width + 2 * boxMargin);
                    int boxHeight = (int)(g.MeasureString(s, font, new SizeF(rightSide - x, Bottom - y), StringFormat.GenericTypographic).Height + 2 * boxMargin);
                    int boxBorder = 1; //Width of border

                    RectangleF borderBox = new RectangleF(x, y, boxWidth, boxHeight);
                    RectangleF backgroundBox = new RectangleF(x + boxBorder, y + boxBorder, boxWidth - 2 * boxBorder, boxHeight - 2 * boxBorder);

                    if (s != "" && s != null)
                    {
                        g.FillRectangle(new SolidBrush(Color.Black), borderBox);
                        g.FillRectangle(new SolidBrush(Color.White), backgroundBox);
                        g.DrawString(s, font, new SolidBrush(Color.Black), new RectangleF(x + boxMargin, y + boxMargin, rightSide - x, Bottom - y), StringFormat.GenericTypographic);
                    }
                }
            }

            //Scrollbar
            if (isScrollable())
            {
                float cursorHeightPercentage = Height / ((margin * 2) + viewList.Count * (itemHeight + spacing));
                int cursorHeight = (int)(Height * cursorHeightPercentage);
                int emptyScrollHeight = Height - cursorHeight;

                float scrollPercentage = 0;

                if (getMaxScrollPos() != 0)
                    scrollPercentage = (float)Math.Abs(scrollPos) / (float)Math.Abs(getMaxScrollPos());

                float sTop = scrollBarCursor.Top;
                float sHeight = scrollBarCursor.Height;

                target = scrollPercentage * emptyScrollHeight;
                if (draggingScrollbar)
                    sTop = target;
                else
                    sTop += speed * (target - scrollBarCursor.Top);

                target = cursorHeight;
                sHeight += speed * (target - scrollBarCursor.Height);

                RectangleF scrollBar = new RectangleF(Right - scrollBarWidth, 0, scrollBarWidth, Height);
                scrollBarCursor = new RectangleF(Right - scrollBarWidth, sTop, scrollBarWidth, sHeight);

                g.FillRectangle(new SolidBrush(Color.LightGray), scrollBar);
                g.FillRectangle(new SolidBrush(Color.Gray), scrollBarCursor);
            }
            else
            {
                scrollBarCursor = new RectangleF();
            }

            //Force redraw
            Invalidate();
        }

        public void Graph_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            e.Graphics.DrawImage(bm, 0, 0);
        }

        public bool overlap(ScreenItem item, Point point)
        {
            return point.X >= item.Left && point.X <= item.Right && point.Y >= item.Top && point.Y <= item.Bottom;
        }
        
        public void Graph_MouseMove(object sender, MouseEventArgs e)
        {
            mouse = e.Location;

            if (draggingScrollbar)
            {
                if (viewList.Count == 0)
                    return;

                float totalHeight = viewList[viewList.Count - 1].Bottom - viewList[0].Top;
                float amplifier = totalHeight / Height;

                moveScreenPos((int)(amplifier * (mouseClickSpot.Y - mouse.Y)));
                mouseClickSpot = mouse;
            }
        }

        public void Graph_MouseDown(object sender, MouseEventArgs e)
        {
            bool found = false;

            for (int i = 0; i < viewList.Count && !found; i++)
            {
                ScreenItem item = viewList[i];

                if (overlap(item, mouse))
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        if (item.type == ScreenItemType.Group)
                        {
                            if (openGroup == item.title)
                                openGroup = "";
                            else
                                openGroup = item.title;

                            createViewList();
                        }
                        else if (item.type == ScreenItemType.Program)
                            openProgram(item);
                    }
                    else if (item.type == ScreenItemType.Program && e.Button == MouseButtons.Right && Core.isAdmin())
                    {
                        EditProgram ep = new EditProgram(item.tag, list);
                        ep.ShowDialog();
                    }

                    found = true;
                }
                else if(!draggingScrollbar && mouse.X >= scrollBarCursor.Left && mouse.X <= scrollBarCursor.Right && mouse.Y >= scrollBarCursor.Top && mouse.Y <= scrollBarCursor.Bottom)
                {
                    mouseClickSpot = mouse;
                    draggingScrollbar = true;
                }
            }
        }

        public void openProgram(ScreenItem program)
        {
            try
            {
               
                Type type = Type.GetType("I_IT." + program.tag).BaseType;
                if (type.Name == "Object" && program.group == "Services" )
                {
                    if (MessageBox.Show("Would you like to run " + program.title + "?", program.title, MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                }
                 if(program.title == "Read Write Files" && program.group == "Admin" && type.Name == "Object")
                {
                    if (MessageBox.Show("Would you like to run " + program.title + "?", program.title, MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                }

                object instance = Activator.CreateInstance(Type.GetType("I_IT." + program.tag));
                Core.log("Form1", "Open program", program.tag);

                if (type.Name == "Form")
                {
                    Form form = (Form)instance;

                    //May throw ObjectDisposedException if the form is closed during load, before showing
                    form.Show();
                }
                else if (type.Name == "Object" && program.group == "Services")
                    Console.WriteLine("Service run complete.\n");
            }
            catch (Exception e2)
            {
                if (e2 is ArgumentNullException || e2 is NullReferenceException) //Form doesn't exist
                    MessageBox.Show("Unable to find " + program.tag + " form.");
                else if (e2 is ObjectDisposedException)
                {
                    //Form has been closed
                }
                else
                    Core.error(e2);
            }
        }

        private void HomeScreen_MouseUp(object sender, MouseEventArgs e)
        {
            if(mouseClickSpot != null)
                draggingScrollbar = false;
        }
    }

    public class ScreenItem
    {
        public string title;
        public float height;
        public float Top, Left, Right, Bottom;
        public Image icon;
        public string tag;
        public string group;
        public string hover;
        public ScreenItemType type;
    }

    public enum ScreenItemType
    {
        Program = 1,
        Group = 2
    }
}
