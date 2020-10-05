using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public class Printer
    {
        Queue<PrintItem> queue = new Queue<PrintItem>();
        Queue<Font> fontQueue = new Queue<Font>();
        public Font font = new Font(new FontFamily("Arial"), 8);
        public static Rectangle margins = new Rectangle(30, 30, 760, 1040);
        bool nextNewlineOverride = false;
        float nextNewlineOverrideHeight = 0;

        public PrintItem Next()
        {
            return queue.Dequeue();
        }

        public void AddDivider()
        {
            queue.Enqueue(new DividerPrintItem());
        }

        public void AddPage()
        {
            queue.Enqueue(new PagePrintItem());
        }

        public void AddImage(Image picture)
        {
            queue.Enqueue(new ImagePrintItem(picture));
        }

        public void AddImage(Image picture, int x)
        {
            queue.Enqueue(new ImagePrintItem(picture, x));
        }

        public void AddImage(Image picture, int w, int h)
        {
            queue.Enqueue(new ImagePrintItem(picture, w, h));
        }

        public void AddImage(Image picture, int x, int w, int h)
        {
            queue.Enqueue(new ImagePrintItem(picture, x, w, h));
        }

        public void AddImage(Image picture, double percentSize)
        {
            queue.Enqueue(new ImagePrintItem(picture, percentSize));
        }

        public void AddImage(Image picture, int x, double percentSize)
        {
            queue.Enqueue(new ImagePrintItem(picture, x, percentSize));
        }

        public void Add(string item)
        {
            queue.Enqueue(new StringPrintItem(item));
            fontQueue.Enqueue(font);
        }

        public void Add(string item, int x)
        {
            queue.Enqueue(new StringPrintItem(item, x));
            fontQueue.Enqueue(font);
        }

        public void AddWrap(string item, int width, int height)
        {
            queue.Enqueue(new WrapPrintItem(item, width, height));
            fontQueue.Enqueue(font);
        }

        public void AddWrap(string item, int width, int height, int x)
        {
            queue.Enqueue(new WrapPrintItem(item, x, width, height));
            fontQueue.Enqueue(font);
        }

        public void AddBold(string item)
        {
            StringPrintItem spi = new StringPrintItem(item);
            spi.Bold = true;

            queue.Enqueue(spi);
            fontQueue.Enqueue(new Font(font, FontStyle.Bold));
        }

        public void AddBold(string item, int x)
        {
            StringPrintItem spi = new StringPrintItem(item, x);
            spi.Bold = true;

            queue.Enqueue(spi);
            fontQueue.Enqueue(new Font(font, FontStyle.Bold));
        }

        public void AddItalics(string item)
        {
            StringPrintItem spi = new StringPrintItem(item);
            spi.Italics = true;

            queue.Enqueue(spi);
            fontQueue.Enqueue(new Font(font, FontStyle.Italic));
        }

        public void AddItalics(string item, int x)
        {
            StringPrintItem spi = new StringPrintItem(item, x);
            spi.Italics = true;

            queue.Enqueue(spi);
            fontQueue.Enqueue(new Font(font, FontStyle.Italic));
        }

        public void AddLine()
        {
            StringPrintItem item = new StringPrintItem("");
            item.newLine = true;

            queue.Enqueue(item);
            fontQueue.Enqueue(font); //Even though there's no text, this is a StringPrintItem
                                     //needed to keep queues lined up
        }

        public PrintItem Peek()
        {
            return queue.Peek();
        }

        public void Print()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            PrintDialog dia = new PrintDialog();
            dia.Document = pd;

            // Print the document.
            if (dia.ShowDialog() == DialogResult.OK)
                pd.Print();
        }

        // The PrintPage event is raised for each page to be printed.
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            //Rectangle margins = ev.MarginBounds;
            float yPos = margins.Top;

            // Calculate the number of lines per page.

            //ev.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(margins.Left, margins.Top, margins.Width, margins.Height));

            // Iterate over the file, printing each line.
            bool stopEarly = false;
            while (!stopEarly && queue.Count > 0)
            {
                PrintItem peek = queue.Peek();

                if (peek is StringPrintItem)
                {
                    StringPrintItem item = ((StringPrintItem)peek);
                    font = fontQueue.Peek();
                    
                    SizeF sf = ev.Graphics.MeasureString(item.Text == "" ? "." : item.Text, font, (int)(margins.Right - item.X));
                    SizeF oneLine = ev.Graphics.MeasureString(".", font, margins.Width);

                    if (yPos + sf.Height < margins.Bottom)
                    {
                        if(peek is WrapPrintItem)
                            ev.Graphics.DrawString(item.Text, font, Brushes.Black,
                                        new RectangleF(margins.Left + item.X, yPos, ((WrapPrintItem)item).Width, ((WrapPrintItem)item).Height),
                                        StringFormat.GenericTypographic);
                        else
                            ev.Graphics.DrawString(item.Text, font, Brushes.Black,
                                        new RectangleF(new PointF(margins.Left + item.X, yPos), sf),
                                        StringFormat.GenericTypographic);
                        
                        if(sf.Height > oneLine.Height) //If this text is wrapped
                        {
                            nextNewlineOverride = true;
                            nextNewlineOverrideHeight = sf.Height;
                        }

                        if (item.newLine)
                        {
                            if (!nextNewlineOverride)
                                yPos += sf.Height;
                            else
                            {
                                yPos += nextNewlineOverrideHeight;
                                nextNewlineOverride = false;
                            }
                        }

                        queue.Dequeue();
                        fontQueue.Dequeue();
                    }
                    else
                        stopEarly = true;
                }
                else if (peek is DividerPrintItem)
                {
                    DividerPrintItem item = ((DividerPrintItem)peek);

                    SizeF sf = ev.Graphics.MeasureString(".", font, margins.Width);

                    if (yPos + sf.Height < margins.Bottom)
                    {
                        ev.Graphics.DrawLine(new Pen(Brushes.Black), new Point(margins.Left, (int)yPos), new Point(margins.Right, (int)yPos));

                        if (item.newLine)
                        {
                            if (!nextNewlineOverride)
                                yPos += sf.Height;
                            else
                            {
                                yPos += nextNewlineOverrideHeight;
                                nextNewlineOverride = false;
                            }
                        }

                        queue.Dequeue();
                    }
                    else
                        stopEarly = true;
                }
                else if (peek is PagePrintItem)
                {
                    queue.Dequeue();
                    stopEarly = true;
                }
                else if (peek is ImagePrintItem)
                {
                    ImagePrintItem item = ((ImagePrintItem)peek);

                    //Include a catch for if the picture is super-huge, to not push it to the next page
                    //Without catch, super-huge images will cause infinite loops
                    if (yPos + item.picture.Height < margins.Bottom || item.picture.Height >= margins.Height)
                    {
                        ev.Graphics.DrawImage(item.picture, margins.Left + item.X, yPos, item.Width, item.Height);
                        queue.Dequeue();
                    }
                    else
                        stopEarly = true;
                }

            }

            // If more lines exist, print another page.
            if (queue.Count > 0)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        public static float GetWidth(string text, Font font)
        {
            Graphics g = Graphics.FromImage(new Bitmap(1, 1));
            SizeF sf = g.MeasureString(text, font, Printer.margins.Width);

            return sf.Width;
        }

        public static void PrintListView(string reportTitle, ListView list)
        {
            Printer queue = new Printer();
            int buffer = 10;

            queue.AddBold(reportTitle, 0);
            queue.Add("Printed:", 612);
            queue.Add(DateTime.Now.ToString(), 667);
            queue.AddLine();
            queue.AddLine();
            queue.AddDivider();

            float[] columnWidths = new float[list.Columns.Count];

            for (int c = 0; c < list.Columns.Count; c++)
            {
                columnWidths[c] = Printer.GetWidth(list.Columns[c].Text, queue.font);

                for (int r = 0; r < list.Items.Count; r++)
                {
                    if (Printer.GetWidth(list.Items[r].SubItems[c].Text, queue.font) > columnWidths[c])
                        columnWidths[c] = Printer.GetWidth(list.Items[r].SubItems[c].Text, queue.font);
                }
            }

            int x = 0;
            for (int c = 0; c < list.Columns.Count; c++)
            {
                queue.AddBold(list.Columns[c].Text, x);

                x += (int)columnWidths[c] + buffer;
            }

            queue.AddLine();

            for (int r = 0; r < list.Items.Count; r++)
            {
                x = 0;
                for (int c = 0; c < list.Columns.Count; c++)
                {
                    queue.Add(list.Items[r].SubItems[c].Text, x);

                    x += (int)columnWidths[c] + buffer;
                }

                queue.AddLine();
            }

            queue.Print();
        }

        public static void PrintDataTable(string reportTitle, DataTable dt)
        {
            Printer queue = new Printer();
            int buffer = 10;

            queue.AddBold(reportTitle, 0);
            queue.Add("Printed:", 612);
            queue.Add(DateTime.Now.ToString(), 667);
            queue.AddLine();
            queue.AddLine();
            queue.AddDivider();

            float[] columnWidths = new float[dt.Columns.Count];

            for (int c = 0; c < dt.Columns.Count; c++)
            {
                columnWidths[c] = Printer.GetWidth(dt.Columns[c].ColumnName, queue.font);

                for (int r = 0; r < dt.Rows.Count; r++)
                {
                    if (Printer.GetWidth(dt.Rows[r][c].ToString(), queue.font) > columnWidths[c])
                        columnWidths[c] = Printer.GetWidth(dt.Rows[r][c].ToString(), queue.font);
                }
            }

            int x = 0;
            for (int c = 0; c < dt.Columns.Count; c++)
            {
                queue.AddBold(dt.Columns[c].ColumnName, x);

                x += (int)columnWidths[c] + buffer;
            }

            queue.AddLine();

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                x = 0;
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    queue.Add(dt.Rows[r][c].ToString(), x);

                    x += (int)columnWidths[c] + buffer;
                }

                queue.AddLine();
            }

            queue.Print();
        }
    }

    public abstract class PrintItem
    {
        public float X;
        public bool newLine = false;
    }

    public class StringPrintItem : PrintItem
    {
        public string Text;
        public bool Bold = false;
        public bool Italics = false;

        public StringPrintItem()
        {
            Text = "";
            X = -1F;
        }

        public StringPrintItem(string text)
        {
            Text = text;
            X = -1F;
        }

        public StringPrintItem(string text, int x)
        {
            Text = text;
            X = (float)x;
        }
    }

    public class WrapPrintItem : StringPrintItem
    {
        public float Width, Height;

        public WrapPrintItem(string text, int w, int h)
        {
            Text = text;
            X = -1F;
            Width = (float)w;
            Height = (float)h;
        }

        public WrapPrintItem(string text, int x, int w, int h)
        {
            Text = text;
            X = (float)x;
            Width = (float)w;
            Height = (float)h;
        }
    }

    public class ImagePrintItem : PrintItem
    {
        public float Width, Height;
        public Image picture;

        public ImagePrintItem(Image image)
        {
            picture = image;
            Width = image.Width;
            Height = image.Height;
            X = -1F;
        }

        public ImagePrintItem(Image image, int x)
        {
            picture = image;
            Width = image.Width;
            Height = image.Height;
            X = (float)x;
        }

        public ImagePrintItem(Image image, int w, int h)
        {
            picture = image;
            Width = w;
            Height = h;
            X = -1F;
        }

        public ImagePrintItem(Image image, int x, int w, int h)
        {
            picture = image;
            Width = w;
            Height = h;
            X = (float)x;
        }

        public ImagePrintItem(Image image, double percentSize)
        {
            picture = image;
            Width = image.Width * (float)percentSize;
            Height = image.Height * (float)percentSize;
            X = -1F;
        }

        public ImagePrintItem(Image image, int x, double percentSize)
        {
            picture = image;
            Width = image.Width * (float)percentSize;
            Height = image.Height * (float)percentSize;
            X = x;
        }
    }

    public class DividerPrintItem : PrintItem
    {
        public DividerPrintItem()
        {

        }
    }

    public class PagePrintItem : PrintItem
    {
        public PagePrintItem()
        {

        }
    }
}
