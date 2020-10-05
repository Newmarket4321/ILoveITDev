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
    public partial class InventoryStickerPrint : Form
    {
        Button[] buttons;

        public InventoryStickerPrint()
        {
            InitializeComponent();

            buttons = new Button[] { sticker1, sticker2, sticker3, sticker4, sticker5, sticker6, sticker7, sticker8, sticker9, sticker10, sticker11, sticker12, sticker13, sticker14, sticker15, sticker16, sticker17, sticker18, sticker19, sticker20, sticker21, sticker22, sticker23, sticker24, sticker25, sticker26, sticker27, sticker28, sticker29, sticker30 };

            for (int i = 0; i < buttons.Length; i++)
                buttons[i].Text = (i+1).ToString();

            string fontName = "IDAutomationHC39M";
            float fontSize = 12;

            using (Font fontTester = new Font(
                    fontName,
                    fontSize,
                    FontStyle.Regular,
                    GraphicsUnit.Pixel))
            {
                if (fontTester.Name == fontName)
                {
                    // Font exists
                }
                else
                {
                    // Font doesn't exist
                    MessageBox.Show("Your computer is missing the barcode font." + Environment.NewLine
                        + Environment.NewLine
                        + "Please call 2300 and let them know you need this installed." + Environment.NewLine
                        + "The font is located here:" + Environment.NewLine
                        + Environment.NewLine
                        + @"T:\Public\IT\IDAutomationHC39M.ttf");
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int labelFontSize = (int)numericUpDown1.Value;
            int barcodeFontSize = (int)numericUpDown2.Value;

            int numLines = textBox1.Text.Split('\n').Length;
            bool anyDisabled = false;

            for (int i = 0; i < buttons.Length; i++)
                if (buttons[i].BackColor == Color.Red)
                    anyDisabled = true;

            if(numLines >= 30 && anyDisabled)
            {
                MessageBox.Show("Choosing which labels have already been used is only available when printing 29 or fewer labels." + Environment.NewLine
                    + "Please print fewer labels at a time, or use completely unused label sheets.");

                return;
            }

            int[] items = new int[numLines];
            string inVar = "";

            try
            {
                for (int i = 0; i < numLines; i++)
                {
                    items[i] = int.Parse(textBox1.Text.Split('\n')[i].Trim());
                    inVar += (i != 0 ? ", " : "") + items[i];
                }
            }
            catch
            {
                MessageBox.Show("The program didn't understand what you wrote in the cherry pick box." + Environment.NewLine
                    + "Please enter one item number per line. No commas, spaces, periods, or semicolons.");
                
                return;
            }

            DataTable dt = Oracle.Run("select IMITM, IMDSC1 from " + (checkBox1.Checked ? "CRPDTA" : "PRODDTA") + ".F4101 where IMITM in (" + inVar + ") order by IMITM");

            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("No items found matching the criteria. Print cancelled.");
                return;
            }
            
            Printer print = new Printer();

            const int x = 12;
            const int col2 = 395;
            const int maxString = 26;
            const int maxStringWidth = 205;
            const int barcodeDiff = maxStringWidth + 5;
            const int maxStringHeight = 100;

            for (int blanksDone = 0, stickersDone = 0; blanksDone < trackBar1.Value || stickersDone < dt.Rows.Count;)
            {
                if ((blanksDone + stickersDone) % 30 == 0)
                {
                    print.font = new Font("IDAutomationHC39M", 4F);
                    print.AddLine();
                }

                string description, itemNumber;

                if (blanksDone < trackBar1.Value)
                {
                    description = "";
                    itemNumber = "";

                    blanksDone++;
                }
                else
                {
                    description = dt.Rows[stickersDone]["IMDSC1"].ToString();
                    itemNumber = "*" + dt.Rows[stickersDone]["IMITM"].ToString() + "*";

                    stickersDone++;
                }

                if (description.Length > maxString)
                    description = description.Substring(0, maxString);

                print.font = new Font("Arial", labelFontSize);
                print.AddWrap(description, maxStringWidth, maxStringHeight, x);
                print.font = new Font("IDAutomationHC39M", barcodeFontSize);
                print.Add(itemNumber, x + barcodeDiff);

                if (blanksDone < trackBar1.Value || stickersDone < dt.Rows.Count)
                {
                    if (blanksDone < trackBar1.Value)
                    {
                        description = "";
                        itemNumber = "";

                        blanksDone++;
                    }
                    else
                    {
                        description = dt.Rows[stickersDone]["IMDSC1"].ToString();
                        itemNumber = "*" + dt.Rows[stickersDone]["IMITM"].ToString() + "*";

                        stickersDone++;
                    }

                    if (description.Length > maxString)
                        description = description.Substring(0, maxString);

                    print.font = new Font("Arial", labelFontSize);
                    print.AddWrap(description, maxStringWidth, maxStringHeight, x + col2);
                    print.font = new Font("IDAutomationHC39M", barcodeFontSize);
                    print.Add(itemNumber, x + col2 + barcodeDiff);
                    
                    if ((blanksDone + stickersDone) % 30 == 0)
                        print.AddPage();
                    else
                    {
                        print.font = new Font("IDAutomationHC39M", 6.4F);
                        print.AddLine();
                        print.AddLine();
                    }
                }
            }

            print.Print();

            Close();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stickerClicker(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (b.BackColor == Color.Red)
                b.BackColor = Color.LightGray;
            else
                b.BackColor = Color.Red;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            for (int i = 0; i < buttons.Length; i++)
                buttons[i].BackColor = Color.LightGray;

            for(int i = 0; i < trackBar1.Value; i++)
                buttons[i].BackColor = Color.Red;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            labelExample.Font = new Font("Arial", (float)numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            barcodeExample.Font = new Font("IDAutomationHC39M", (float)numericUpDown2.Value);
        }
    }
}
