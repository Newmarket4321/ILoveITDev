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
    public partial class LineGraph : Graph
    {
        float maxPointSize = 9;

        double minTime = 0;
        double maxTime = 0;
        double time = -100;

        public Database pointClick = null;

        public LineGraph()
        {
            setup();
        }

        public LineGraph(Database input)
        {
            setup();

            data = input;
            RefreshData();
        }

        public override void PaintGraph(object sender, EventArgs e)
        {
            const float pointSpeed = 0.10F;
            const float shrinkSpeed = 0.10F;
            const double animationDuration = 0.14;

            double minValue = 0;
            double maxValue = 0;
            float bloomMultiplier = 2F;
            float bloomTolerance = (1F/5F) * bloomMultiplier;

            if(time < maxTime)
                time += (maxTime - minTime) * (timer1.Interval / 1000.0) / animationDuration;

            //Time and value
            for (int i = 0; i < items.Count; i++)
            {
                LinePoint point = items[i] as LinePoint;

                if (i == 0)
                {
                    minTime = point.time;
                    maxTime = point.time;
                    minValue = point.value;
                    maxValue = point.value;
                }
                else
                {
                    if (point.value < minValue)
                        minValue = point.value;

                    if (point.value > maxValue)
                        maxValue = point.value;

                    if (point.time < minTime)
                        minTime = point.time;

                    if (point.time > maxTime)
                        maxTime = point.time;

                    if (time < minTime)
                        time = minTime;

                    if (maxTime == minTime)
                        maxTime = minTime + 10;
                }
            }
            
            //Points
            for(int i = 0; i < items.Count; i++)
            {
                LinePoint point = items[i] as LinePoint;

                if (time >= point.time)
                {
                    if (!point.bloom)
                        point.size += pointSpeed * (bloomMultiplier * maxPointSize - point.size);
                    else
                        point.size += shrinkSpeed * (maxPointSize - point.size);

                    if (point.size >= (bloomMultiplier - bloomTolerance) * maxPointSize)
                        point.bloom = true;
                }

                point.x = margin + (float)((double)(point.time - minTime) / (maxTime - minTime)) * (Width - 2 * margin) - (point.size / 2);
                point.y = Bottom - margin - (float)((point.value - minValue) / (maxValue - minValue)) * (Height - 2 * margin) - (point.size / 2);

                if (float.IsNaN(point.y))
                    point.y = 0;
            }

            PaintGraph(minValue, maxValue);

            //Force redraw
            Invalidate();
        }

        private void PaintGraph(double minValue, double maxValue)
        {
            float lastX = margin;
            //float lineWidth = (float)((Width - 2 * margin) / (1.2 * lines.Count - 0.2)); //Because lines.Count is an integer, divisor will never be zero
            //float spacing = (Width - 2 * margin) / (6 * lines.Count - 1); //Because lines.Count is an integer, divisor will never be zero

            //Font font = new Font(new FontFamily("Calibri Light"), 11);
            Font bold = new Font(font, FontStyle.Bold);
            //Font titleFont = new Font(new FontFamily("Arial"), 20);

            g.Clear(Color.White);

            //Timeline (hah)
            //g.FillRectangle(new SolidBrush(Color.Blue), (float)(margin + time / (maxTime - minTime) * (Width - (2 * margin))), 0, 2, Height);

            //Gridlines & Y-axis markers
            int numGridlines = 5;
            for (int i = 0; i < numGridlines && numGridlines != 1; i++)
            {
                double sValue = (maxValue - (((double)i) / (numGridlines - 1)) * (maxValue - minValue));

                if (maxValue - minValue > numGridlines) //If the spread is wide enough, we don't need to show decimals
                    sValue = Math.Round(sValue, MidpointRounding.AwayFromZero);

                string s = sValue.ToString("N" + Core.getNumberDecimals(sValue).ToString());
                SizeF sSize = g.MeasureString(s, font);
                int lineSpacing = 3;
                int yBuffer = 0;
                //int adjust = -3;

                float x1 = margin;
                float x2 = Width - margin;
                float y = (float)(margin + ((double)i / (numGridlines - 1)) * (Height - 2 * margin) + maxPointSize / 2);
                
                g.DrawLine(new Pen(Color.LightGray, 1F), x1, y, x2, y);
                g.DrawString(s, font, new SolidBrush(Color.FromArgb(50, 50, 50)), x1 - sSize.Width - lineSpacing, y - (sSize.Height / 2) - yBuffer);
            }

            //Lines
            for (int i = 0; i < items.Count - 1; i++) //-1 because the last point doesn't have a line leading anywhere
            {
                LinePoint point = items[i] as LinePoint;
                LinePoint nextPoint = items[i + 1] as LinePoint;

                if (time > point.time)
                {
                    SolidBrush brush = new SolidBrush(point.colour);

                    //if (overlap(lines[i], mouse))
                    //    brush = new SolidBrush(Core.averageColours(Color.White, lines[i].colour));
                    
                    float x = point.x + point.size / 2;
                    float y = point.y + point.size / 2;
                    float x2 = nextPoint.x + nextPoint.size / 2;
                    float y2 = nextPoint.y + nextPoint.size / 2;

                    if (x2 - x != 0)
                    {
                        //y = mx + b
                        float xl = margin + (float)((Math.Min(time, nextPoint.time) - minTime) / (double)(maxTime - minTime)) * (Width - 2 * margin) - 0 * (maxPointSize / 2);
                        float m = (y2 - y) / ((x2 - x < 0 ? -1 : 1) * Math.Max(0.000001F, Math.Abs((x2 - x))));
                        float b = y - m * x;
                        float yl = m * xl + b;
                        
                        g.DrawLine(new Pen(point.colour, 2F), x, y, xl, yl);
                    }
                }
            }

            //Points & X-axis markers
            bool overlapFound = false;
            for (int i = 0; i < items.Count; i++)
            {
                //Point
                LinePoint point = items[i] as LinePoint;

                SolidBrush brush = new SolidBrush(point.colour);

                if (overlap(point, mouse) && !overlapFound)
                {
                    brush = new SolidBrush(Core.averageColours(Color.White, point.colour));
                    overlapFound = true;
                }

                float x = point.x;
                float y = point.y;

                g.FillEllipse(brush, x, y, point.size, point.size);

                //X-axis markers
                int overflowAt = 30;
                int overflowShowAmount = 7;
                if (items.Count < overflowAt || i % (items.Count / overflowShowAmount) == 0) //Do for all if < 50, otherwise just first and last
                {
                    int showAmount = items.Count > overflowAt ? overflowShowAmount : items.Count;

                    double spot = minTime + ((float)i / (items.Count - 1)) * (maxTime - minTime);
                    string s = point.type == LinePointType.Number ? spot.ToString() : DateTime.FromOADate(spot).ToString("MMMM d, yyyy");
                    float spacing = (Width - 2 * margin) / (6 * Math.Max(showAmount, 1) - 1); //Because items.Count is an integer, divisor will never be zero

                    while (g.MeasureString(s, boldFont).Width > ((Width - (2 * margin)) / showAmount) + spacing && s.Length > 0)
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

                    SizeF sSize = g.MeasureString(s, font);
                    int yBuffer = 0;

                    x = (margin + ((float)i / (items.Count - 1)) * (Width - 2 * margin)) - (sSize.Width / 2);

                    g.DrawString(s, font, new SolidBrush(Color.FromArgb(50, 50, 50)), x, Bottom - margin + (sSize.Height / 2) + yBuffer);
                }
            }

            lastX = margin;

            //Title
            g.DrawString(GraphTitle, titleFont, new SolidBrush(titleColour), (Width / 2) - (g.MeasureString(GraphTitle, titleFont).Width / 2), 8);

            //Hover
            bool found = false;
            for(int i = 0; i < items.Count && !found; i++)
            {
                LinePoint point = items[i] as LinePoint;

                if (overlap(point, mouse))
                {
                    found = true;

                    string s = point.type == LinePointType.Number ? point.time.ToString() : DateTime.FromOADate(point.time).ToString("MMMM d, yyyy");
                    string s2 = point.value.ToString("N" + Core.getNumberDecimals(point.value).ToString());

                    float xOffset = 10;
                    float yOffset = 0;
                    float x = mouse.X + xOffset;
                    float y = mouse.Y + yOffset;
                    float x2 = x;
                    float y2 = y + g.MeasureString(s, bold).Height;

                    int boxMargin = 3;
                    int boxWidth = (int)Math.Max(g.MeasureString(s, bold).Width, g.MeasureString(s2, font).Width) + 2 * boxMargin;
                    int boxHeight = (int)(g.MeasureString(s, bold).Height + g.MeasureString(s2, font).Height + 2 * boxMargin);
                    int boxBorder = 1;
                    
                    if(mouse.X + boxBorder + boxWidth > Width - 10) //From the left
                    {
                        x = mouse.X - xOffset - boxBorder - boxWidth;
                        x2 = x;
                    }

                    g.FillRectangle(new SolidBrush(Core.averageColours(Color.Black, point.colour)), x, mouse.Y + yOffset, boxWidth, boxHeight);
                    g.FillRectangle(new SolidBrush(Color.White), x + boxBorder, mouse.Y + yOffset + boxBorder, boxWidth - 2 * boxBorder, boxHeight - 2 * boxBorder);
                    g.DrawString(s, bold, new SolidBrush(Core.averageColours(Color.Black, point.colour)), x + boxMargin, y + boxMargin);
                    g.DrawString(s2, font, new SolidBrush(Core.averageColours(Color.Black, point.colour)), x2 + boxMargin, y2 + boxMargin);
                }
            }
        }

        public override bool overlap(GraphItem item, Point mouse)
        {
            LinePoint point = item as LinePoint;

            //Distance the cursor is from the center
            double distance = Math.Sqrt(Math.Pow(point.x + (point.size / 2) - mouse.X, 2) + Math.Pow(point.y + (point.size / 2) - mouse.Y, 2));
            
            return distance <= point.size;
        }

        public override void Reset()
        {
            g.Clear(Color.White);
            time = minTime;

            for (int i = 0; i < items.Count; i++)
            {
                LinePoint point = items[i] as LinePoint;

                point.size = 0;
                point.bloom = false;
            }
        }
        
        public override void AddItem(string time, double value)
        {
            LinePoint point = new LinePoint();
            point.value = value;
            point.colour = Color.FromArgb(255, 59, 48); //Temp

            double dValue;
            bool success = double.TryParse(time, out dValue);

            if (success)
            {
                point.time = dValue;
                point.type = LinePointType.Number;
            }
            else
            {
                DateTime dtValue;
                success = DateTime.TryParse(time, out dtValue);

                if (success)
                {
                    point.time = dtValue.ToOADate();
                    point.type = LinePointType.Date;
                }
                else
                    throw new Exception("Line value not set correctly");
            }

            point.bloom = false;

            items.Add(point);

            if(point.time < minTime)
                minTime = point.time;

            if(point.time > maxTime)
                maxTime = point.time;

            if(items.Count == 1)
            {
                minTime = point.time;
                maxTime = point.time;
            }

            this.time = minTime;
        }

        public override void AddItem(string time, double value, Color colour)
        {
            LinePoint point = new LinePoint();
            point.value = value;
            point.colour = colour;

            double dValue;
            bool success = double.TryParse(time, out dValue);

            if (success)
            {
                point.time = dValue;
                point.type = LinePointType.Number;
            }
            else
            {
                DateTime dtValue;
                success = DateTime.TryParse(time, out dtValue);

                if (success)
                {
                    point.time = dtValue.ToOADate();
                    point.type = LinePointType.Date;
                }
                else
                    throw new Exception("Line value not set correctly");
            }

            point.bloom = false;

            items.Add(point);

            if (point.time < minTime)
                minTime = point.time;

            if (point.time > maxTime)
                maxTime = point.time;

            if (items.Count == 1)
            {
                minTime = point.time;
                maxTime = point.time;
            }

            this.time = minTime;
        }

        private void lineGraph_MouseMove(object sender, MouseEventArgs e)
        {
            mouse = e.Location;
        }

        private void lineGraph_MouseDown(object sender, MouseEventArgs e)
        {
            bool found = false;

            if(pointClick != null)
            {
                for (int i = 0; i < items.Count && !found; i++)
                {
                    if (overlap(items[i], mouse))
                    {
                        //pointClick.ClearParameters();

                        //pointClick.AddParameter("@VAR", points[i].label);

                        //Report r = new Report(title + " - " + points[i].label, pointClick.Run());
                        //r.Show();

                        found = true;
                    }
                }
            }
        }
    }

    public enum LinePointType
    {
        Number,
        Date
    }

    public class LinePoint : GraphItem
    {
        public LinePointType type;
        public double time;
        public float size;
        public bool bloom;

        public float x;
        public float y;
    }

    public class Line
    {
        public double value;
        public float height;
        public Color colour;
        public string label;

        public int Top, Left, Right, Bottom;
    }
}
