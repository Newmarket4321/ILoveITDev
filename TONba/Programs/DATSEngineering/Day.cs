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
    public partial class Day : UserControl
    {
        private decimal totalHours = 0;
        List<PictureBox> boxes = new List<PictureBox>();
        int nextTop = 18;
        private DateTime date;

        public Day()
        {
            InitializeComponent();
            //update();
        }

        public void blackText()
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is Label)
                {
                    Label la = Controls[i] as Label;

                    la.ForeColor = Color.Black;
                }
            }

            label1.ForeColor = Color.White;
        }

        public void resize(int size)
        {
            Width = size;
        }

        public void addHours(decimal h, string username)
        {
            PictureBox box = new PictureBox();
            Random r = new Random();

            totalHours += h;
            label1.Text = ((double)totalHours).ToString();
            label1.Visible = true;

            if (label1.Text == "0")
            {
                label1.Text = "";
                label1.BackColor = Color.Transparent;
            }
            else if (totalHours > 7)
                label1.BackColor = Color.Red;
            else
                label1.BackColor = Color.Black;

            box.BackColor = DATSEngineeringCore.getPayTypeColor("Regular");

            //box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            box.MouseEnter += Day_MouseEnter;
            box.MouseLeave += Day_MouseLeave;
            box.MouseClick += Day_MouseClick;
            //box.BackColor = Color.FromArgb((int)(r.NextDouble() * 255), (int)(r.NextDouble() * 255), (int)(r.NextDouble() * 255));
            box.Tag = h;

            Controls.Add(box);
            //Controls.SetChildIndex(box, 0);

            nextTop = 18;
            bool firstHit = false;
            int lastBottom = 0;

            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is PictureBox)
                {
                    decimal hours = (decimal)((PictureBox)Controls[i]).Tag;
                    int newHeight = (int)(hours * 65 / Math.Max(7, totalHours));

                    if (i == Controls.Count - 1 && totalHours >= 7)
                    {
                        if (!firstHit)
                        {
                            newHeight = 65;
                            firstHit = true;
                        }
                        else
                            newHeight = 65 - lastBottom;
                    }

                    ((PictureBox)Controls[i]).Size = new Size(Width, newHeight);
                    ((PictureBox)Controls[i]).Anchor = AnchorStyles.Right | AnchorStyles.Left;
                    ((PictureBox)Controls[i]).Location = new Point(-1, nextTop);
                    lastBottom = ((PictureBox)Controls[i]).Bottom;

                    nextTop += ((PictureBox)Controls[i]).Size.Height;
                }
            }
        }

        void box_MouseEnter(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        public decimal getHours()
        {
            return totalHours;
        }

        public void clearHours()
        {
            nextTop = 18;
            totalHours = 0;
            label1.Text = "";
            label1.BackColor = Color.Transparent;
            label3.Visible = false;

            for (int i = Controls.Count - 1; i > 0; i--)
            {
                if (Controls[i] is PictureBox)
                    Controls.RemoveAt(i);
            }
        }

        public void setLabel(DateTime day)
        {
            date = day;
            label2.Text = day.Day.ToString();

            DateTime today = DateTime.Today;

            if (day.Year == today.Year && day.Month == today.Month && day.Day == today.Day)
                label1.BackColor = Color.Blue; //Today
            else
                label1.BackColor = Color.Black; //Other
        }

        public DateTime getDate()
        {
            return date;
        }

        public void update()
        {
            //int topOfBar = label1.Bottom;

            //pictureBox1.Location = new Point(pictureBox1.Location.X, (int)((decimal)this.Height - Math.Min((Hours / DATSCore.getDepartmentDailyHours()) * (decimal)(this.Height - topOfBar), this.Height - topOfBar)));
            //pictureBox1.Height = Math.Min((int)((Hours / DATSCore.getDepartmentDailyHours()) * (this.Height - topOfBar)), this.Height - topOfBar);
            //label1.Text = double.Parse(Hours.ToString()).ToString() + "h"; //Parse to double so it shows up as 8 instead of 8.0 when multiple timesheets are added up
            ////label1.Location = new Point((int)(this.Width/2), (int)(this.Height/2));

            ////if (Hours > DATSCore.getDepartmentDailyHours())
            //pictureBox1.BackColor = Color.FromArgb(12, 163, 232);
            ////else
            ////    pictureBox1.BackColor = Color.FromArgb(107, (int)(176 + (255 - 176) * (Math.Min(Hours / DATSCore.getDepartmentDailyHours(), 1))), (int)(255 - (255 - 176) * (Math.Min(Hours / DATSCore.getDepartmentDailyHours(), 1))));

            ////107,176,255
        }

        double fade = 0.8;

        private void Day_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(100, 0, 0, 0);
            this.Cursor = Cursors.Hand;

            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is PictureBox)
                {
                    PictureBox box = ((PictureBox)Controls[i]);
                    int r = Math.Min(255, Math.Max(0, (int)(fade * box.BackColor.R)));
                    int g = Math.Min(255, Math.Max(0, (int)(fade * box.BackColor.G)));
                    int b = Math.Min(255, Math.Max(0, (int)(fade * box.BackColor.B)));

                    box.BackColor = Color.FromArgb(r, g, b);
                }

                if (Controls[i] == label3)
                {
                    Label la = ((Label)Controls[i]);
                    int r = (int)(fade * la.BackColor.R);
                    int g = (int)(fade * la.BackColor.G);
                    int b = (int)(fade * la.BackColor.B);

                    la.BackColor = Color.FromArgb(r, g, b);
                }
            }
        }

        private void Day_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromName("Transparent");
            this.Cursor = Cursors.Default;

            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is PictureBox)
                {
                    PictureBox box = ((PictureBox)Controls[i]);
                    int r = Math.Min(255, Math.Max(0, (int)((1 / fade) * box.BackColor.R)));
                    int g = Math.Min(255, Math.Max(0, (int)((1 / fade) * box.BackColor.G)));
                    int b = Math.Min(255, Math.Max(0, (int)((1 / fade) * box.BackColor.B)));

                    box.BackColor = Color.FromArgb(r, g, b);
                }

                if (Controls[i] == label3)
                {
                    Label la = ((Label)Controls[i]);
                    int r = Math.Min(255, Math.Max(0, (int)((1 / fade) * la.BackColor.R)));
                    int g = Math.Min(255, Math.Max(0, (int)((1 / fade) * la.BackColor.G)));
                    int b = Math.Min(255, Math.Max(0, (int)((1 / fade) * la.BackColor.B)));

                    la.BackColor = Color.FromArgb(r, g, b);
                }
            }
        }

        public delegate void DayEventHandler(DateTime x);
        public event DayEventHandler DayClicked;

        private void Day_MouseClick(object sender, MouseEventArgs e)
        {
            DayClicked(date);
        }
    }
}
