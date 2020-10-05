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
    public partial class PieGraph : Graph
    {
        public PieGraph()
        {
            setup();
        }

        public PieGraph(Database input)
        {
            setup();

            data = input;
            RefreshData();
        }

        public override void AddItem(string label, double value, Color colour)
        {
            Slice slice = new Slice();
            slice.value = value;
            slice.colour = colour;
            slice.label = label;

            items.Add(slice);
        }

        public override void AddItem(string label, double value)
        {
            Slice slice = new Slice();
            slice.value = value;
            slice.colour = getColour();
            slice.label = label;
            slice.toBeDeleted = false;

            items.Add(slice);
        }

        public override void PaintGraph(object sender, EventArgs e)
        {
            double totalValue = 0;

            //Start with a clean slate
            g.Clear(Color.White);

            //If to be deleted and finished animating, delete
            for (int i = items.Count - 1; i >= 0; i--)
            {
                Slice slice = (Slice)items[i];

                if (slice.toBeDeleted)
                {
                    slice.value = 0;

                    if(slice.angle <= 0.01)
                        items.RemoveAt(i);
                }
            }
            
            //Calculate total value
            for (int i = 0; i < items.Count; i++)
                totalValue += items[i].value;
            
            //Calculate slice angles
            for(int i = 0; i < items.Count; i++)
            {
                Slice slice = (Slice)items[i];
                float proportion = (float)(slice.value / totalValue);
                float target = proportion * 360;

                slice.angle += speed * (target - slice.angle);
            }

            //Slices
            float startAngle = 0F;
            float itemsizeAngle = 0F;
            
            for (int i = 0; i < items.Count; i++)
            {
                Slice slice = (Slice)items[i];

                startAngle += itemsizeAngle;
                itemsizeAngle = slice.angle;

                SolidBrush brush = new SolidBrush(items[i].colour);

                if (overlap(items[i], mouse))
                    brush = new SolidBrush(Core.averageColours(Color.White, items[i].colour));

                float w = Math.Max(Math.Min(Width, Height) - 2 * margin, 1);
                float h = Math.Max(Math.Min(Width, Height) - 2 * margin, 1);
                float x = (Width / 2) - (w / 2);
                float y = (Height / 2) - (h / 2);

                g.FillPie(brush, x, y, w, h, startAngle, itemsizeAngle);
            }

            //Text
            startAngle = 0F;
            itemsizeAngle = 0F;

            for (int i = 0; i < items.Count; i++)
            {
                Slice slice = (Slice)items[i];

                if (!slice.toBeDeleted)
                {
                    startAngle += itemsizeAngle;
                    itemsizeAngle = slice.angle;

                    double angle = startAngle + (slice.angle / 2) - 90;

                    float cirW = Math.Max(Math.Min(Width, Height) - 2 * margin, 1);
                    float cirH = Math.Max(Math.Min(Width, Height) - 2 * margin, 1);
                    float cirX = (Width / 2) - (cirW / 2);
                    float cirY = (Height / 2) - (cirH / 2);

                    float r = (Math.Min(Width, Height) - 2 * margin) / 2;
                    string s = items[i].label;
                    string s2 = items[i].value.ToString("N" + Core.getNumberDecimals(items[i].value).ToString());
                    double radians = -angle * Math.PI / 180;
                    float x = (float)(r * Math.Sin(radians)) + cirX + r - (g.MeasureString(s, boldFont).Width / 2);
                    float y = (float)(r * Math.Cos(radians)) + cirY + r - (g.MeasureString(s, boldFont).Height / 2);
                    float x2 = x + (g.MeasureString(s, boldFont).Width / 2) - (g.MeasureString(s2, font).Width / 2);
                    float y2 = y + g.MeasureString(s, boldFont).Height;

                    g.DrawString(s, boldFont, new SolidBrush(Core.averageColours(Color.Black, items[i].colour)), x, y);
                    g.DrawString(s2, font, new SolidBrush(Core.averageColours(Color.Black, items[i].colour)), x2, y2);
                }
            }

            //Hover
            for (int i = 0; i < items.Count; i++)
            {
                Slice slice = (Slice)items[i];
                
                if (overlap(slice, mouse))
                {
                    string s = slice.label;
                    string s2 = slice.value.ToString("N" + Core.getNumberDecimals(slice.value).ToString());

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

                    g.FillRectangle(new SolidBrush(Core.averageColours(Color.Black, slice.colour)), mouse.X + xOffset, mouse.Y + yOffset, boxWidth, boxHeight);
                    g.FillRectangle(new SolidBrush(Color.White), mouse.X + xOffset + boxBorder, mouse.Y + yOffset + boxBorder, boxWidth - 2 * boxBorder, boxHeight - 2 * boxBorder);
                    g.DrawString(s, boldFont, new SolidBrush(Core.averageColours(Color.Black, slice.colour)), x + boxMargin, y + boxMargin);
                    g.DrawString(s2, font, new SolidBrush(Core.averageColours(Color.Black, slice.colour)), x2 + boxMargin, y2 + boxMargin);
                }
            }
            
            //Title
            g.DrawString(GraphTitle, titleFont, new SolidBrush(titleColour), (Width / 2) - (g.MeasureString(GraphTitle, titleFont).Width / 2), 8);

            //Force redraw
            Invalidate();
        }

        public override void Reset()
        {
            g.Clear(Color.White);

            for (int i = 0; i < items.Count; i++)
                ((Slice)items[i]).angle = 0;
        }

        public override bool overlap(GraphItem item, Point point)
        {
            Slice slice = item as Slice;

            double r = (Math.Min(Width, Height) - 2 * margin) / 2;
            
            double x = Width / 2;
            double y = Height / 2;
            double x2 = point.X;
            double y2 = point.Y;
            
            //Atan can't tell the difference between 1 / -1, and -1 / 1, therefore it can't tell quadrants.
            //Atan2 solves this problem.
            double angle = Math.Atan2((y2 - y), (x2 - x)) * 180 / Math.PI;

            //g.DrawString(angle.ToString(), boldFont, new SolidBrush(Core.averageColours(Color.Black, item.colour)), 5, 5);

            //Tangent doesn't know we want to measure beyond 180°, therefore putting in this quick fix
            if (y2 - y < 0)
                angle = 360 + angle;

            //Distance the cursor is from the center
            double distX = x2 - x;
            double distY = y2 - y;
            double distance = Math.Sqrt(Math.Pow(distX, 2) + Math.Pow(distY, 2));

            double lowerBound = 0;

            bool found = false;
            for (int i = 0; i < items.Count && !found; i++)
            {
                Slice temp = (Slice)items[i];

                if (items[i] != slice)
                    lowerBound += temp.angle;
                else
                    found = true;
            }

            double upperBound = lowerBound + slice.angle;

            return distance <= r && angle >= lowerBound && angle <= upperBound;
        }
    }

    class Slice : GraphItem
    {
        public float angle;
    }
}
