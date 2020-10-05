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
    public partial class BarGraph : Graph
    {
        float barWidth;
        float spacing;
        
        public BarGraph()
        {
            barSetup();
            setup();
        }

        public BarGraph(Database input)
        {
            barSetup();
            setup();

            data = input;
            RefreshData();
        }

        public void barSetup()
        {
            barWidth = (float)((Width - 2 * margin) / (1.2 * Math.Max(items.Count, 1) - 0.2)); //Because items.Count is an integer, divisor will never be zero
            spacing = ((float)(Width - 2 * margin)) / (6 * Math.Max(items.Count, 1) - 1); //Because items.Count is an integer, divisor will never be zero
        }

        public override void AddItem(string label, double value, Color colour)
        {
            Bar bar = new Bar();
            bar.value = value;
            bar.colour = colour;
            bar.label = label;
            bar.Left = margin + items.Count * (barWidth + spacing);
            bar.Right = bar.Left + barWidth;

            items.Add(bar);
        }

        public override void AddItem(string label, double value)
        {
            Bar bar = new Bar();
            bar.value = value;
            bar.colour = getColour();
            bar.label = label;
            bar.Left = margin + items.Count * (barWidth + spacing);
            bar.Right = bar.Left + barWidth;

            items.Add(bar);
        }

        public override void PaintGraph(object sender, EventArgs e)
        {
            double maxValue = 0;
            
            //Start with a clean slate
            barSetup();
            g.Clear(Color.White);

            //If to be deleted and finished animating, delete
            for (int i = items.Count - 1; i >= 0; i--)
            {
                Bar bar = (Bar)items[i];

                if (bar.toBeDeleted)
                {
                    bar.value = 0;

                    if (bar.height <= 2)
                        items.RemoveAt(i);
                }
            }

            //Calculate the max value
            for (int i = 0; i < items.Count; i++)
                if (items[i].value > maxValue)
                    maxValue = items[i].value;
            
            //Calculate how high each bar should be
            for(int i = 0; i < items.Count; i++)
            {
                Bar bar = items[i] as Bar;

                float proportion = (float)(items[i].value / maxValue);
                float target;

                if (!bar.toBeDeleted)
                {
                    target = proportion * (Height - (2 * margin));
                    bar.height += speed * (target - bar.height);

                    target = margin + i * (barWidth + spacing);
                    bar.Left += speed * (target - bar.Left);

                    target = margin + i * (barWidth + spacing) + barWidth;
                    bar.Right += speed * (target - bar.Right);
                }
                else
                {
                    target = 0;
                    bar.height += speed * (target - bar.height);

                    target = margin + i * (barWidth + spacing) + (barWidth / 2);
                    bar.Left += speed * (target - bar.Left);
                    bar.Right += speed * (target - bar.Right);
                }

                bar.Top = Height - margin - bar.height;

                bar.Bottom = Height - margin;
            }

            //Bars
            for (int i = 0; i < items.Count; i++)
            {
                Bar bar = items[i] as Bar;
                SolidBrush brush = new SolidBrush(bar.colour);

                if (overlap(bar, mouse))
                    brush = new SolidBrush(Core.averageColours(Color.White, bar.colour));
                
                g.FillRectangle(brush, bar.Left, bar.Top, bar.Right - bar.Left, bar.height);
            }

            //Text
            for (int i = 0; i < items.Count; i++)
            {
                if (!items[i].toBeDeleted)
                {
                    string s = items[i].label;

                    while (g.MeasureString(s, boldFont).Width > barWidth + spacing && s.Length > 0)
                    {
                        s = s.Replace("...", "");

                        if (s.Length <= 1)
                            s = "";
                        else if (s.Length == 2)
                            s = ".";
                        else if (s.Length == 3)
                            s = "..";
                        else
                        {
                            s = s.Substring(0, s.Length - 1);
                            s = s.Substring(0, s.Length - 3) + "...";
                        }
                    }

                    string s2 = items[i].value.ToString("N" + Core.getNumberDecimals(items[i].value).ToString());

                    while (g.MeasureString(s2, font).Width > barWidth + spacing && s2.Length > 0)
                    {
                        s2 = s2.Replace("...", "");

                        if (s2.Length <= 1)
                            s2 = "";
                        else if (s2.Length == 2)
                            s2 = ".";
                        else if (s2.Length == 3)
                            s2 = "..";
                        else
                        {
                            s2 = s2.Substring(0, s2.Length - 1);
                            s2 = s2.Substring(0, s2.Length - 3) + "...";
                        }
                    }

                    Bar bar = items[i] as Bar;

                    float x = bar.Left + (barWidth / 2) - (g.MeasureString(s, boldFont).Width / 2);
                    float y = Height - margin;
                    float x2 = x + (g.MeasureString(s, boldFont).Width / 2) - (g.MeasureString(s2, font).Width / 2);
                    float y2 = y + g.MeasureString(s, boldFont).Height;

                    g.DrawString(s, boldFont, new SolidBrush(Core.averageColours(Color.Black, items[i].colour)), x, y);
                    g.DrawString(s2, font, new SolidBrush(Core.averageColours(Color.Black, items[i].colour)), x2, y2);
                }
            }

            //Title
            g.DrawString(GraphTitle, titleFont, new SolidBrush(titleColour), (Width / 2) - (g.MeasureString(GraphTitle, titleFont).Width / 2), 8);

            //Hover
            for (int i = 0; i < items.Count; i++)
            {
                if (overlap(items[i], mouse))
                {
                    string s = items[i].label;
                    string s2 = items[i].value.ToString("N" + Core.getNumberDecimals(items[i].value).ToString());

                    float xOffset = 10;
                    float yOffset = 0;
                    float x = mouse.X + xOffset;
                    float y = mouse.Y + yOffset;
                    float x2 = x;
                    float y2 = y + g.MeasureString(s, boldFont).Height;

                    int boxMargin = 3;
                    int boxWidth = (int)Math.Max(g.MeasureString(s, boldFont).Width, g.MeasureString(s2, font).Width) + 2 * boxMargin;
                    int boxHeight = (int)(g.MeasureString(s, boldFont).Height + g.MeasureString(s2, font).Height + 2 * boxMargin);
                    int boxBorder = 1;

                    g.FillRectangle(new SolidBrush(Core.averageColours(Color.Black, items[i].colour)), mouse.X + xOffset, mouse.Y + yOffset, boxWidth, boxHeight);
                    g.FillRectangle(new SolidBrush(Color.White), mouse.X + xOffset + boxBorder, mouse.Y + yOffset + boxBorder, boxWidth - 2 * boxBorder, boxHeight - 2 * boxBorder);
                    g.DrawString(s, boldFont, new SolidBrush(Core.averageColours(Color.Black, items[i].colour)), x + boxMargin, y + boxMargin);
                    g.DrawString(s2, font, new SolidBrush(Core.averageColours(Color.Black, items[i].colour)), x2 + boxMargin, y2 + boxMargin);
                }
            }

            //Force redraw
            Invalidate();
        }
        
        public override bool overlap(GraphItem item, Point point)
        {
            Bar bar = item as Bar;

            return point.X >= bar.Left && point.X <= bar.Right && point.Y >= margin && point.Y <= Bottom - margin;
        }

        public override void Reset()
        {
            g.Clear(Color.White);

            for (int i = 0; i < items.Count; i++)
                ((Bar)items[i]).height = 0;
        }
    }

    class Bar : GraphItem
    {
        public float height;
        public float Top, Left, Right, Bottom;
    }
}
