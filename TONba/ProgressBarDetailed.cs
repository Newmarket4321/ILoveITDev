using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace I_IT
{
    public partial class ProgressBarDetailed : UserControl
    {
        DateTime startTime = new DateTime(1900, 1, 1);
        private int iValue = 0;

        public int Value
        {
            get
            {
                return iValue;
            }
            set
            {
                this.iValue = value;

                if (startTime.Year == 1900)
                    Start();
            }
        }

        public int Maximum = 1;
        
        public ProgressBarDetailed()
        {
            InitializeComponent();
            progressPanel.Width = 0;
            itemCounter.Text = "Loading...";
            timeRemaining.Text = "";

            //itemCounter.DoubleBuffering(true);
            //timeRemaining.DoubleBuffering(true);
            //progressPanel.DoubleBuffering(true);
            //backdropPanel.DoubleBuffering(true);
            DoubleBuffered = true;
            //typeof(Label).InvokeMember("DoubleBuffered",
            //    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            //    null, timeRemaining, new object[] { true });
        }

        public void Start()
        {
            startTime = DateTime.Now;
            timer.Enabled = true;
            //progressPanel.BackColor = Color.FromArgb(76, 217, 100);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(iValue > 0)
            {
                decimal percentage = (decimal)iValue / (decimal)Math.Max(1, Maximum);
                progressPanel.Width = (int)(percentage * backdropPanel.Width);

                TimeSpan timeSpent = DateTime.Now - startTime;
                int secondsRemaining = (int)timeSpent.TotalSeconds * (Maximum - iValue) / Math.Max(1, iValue);
                int minutesRemaining = secondsRemaining / 60;
                secondsRemaining %= 60;
                int hoursRemaining = minutesRemaining / 60;
                minutesRemaining %= 60;
                int daysRemaining = hoursRemaining / 24;
                hoursRemaining %= 24;
                //DateTime finish = DateTime.Now.AddSeconds(secondsRemaining);

                //timeRemaining.Text = finish.ToString("T");

                timeRemaining.Text = "";

                addText(daysRemaining, "day");
                addText(hoursRemaining, "hour");
                addText(minutesRemaining, "minute");
                addText(secondsRemaining, "second");

                if (timeRemaining.Text == "")
                    timeRemaining.Text = "0 seconds";

                itemCounter.Text = iValue + " of " + Maximum;
                timeRemaining.Location = new Point(Width - timeRemaining.Width, timeRemaining.Location.Y);
            }

            if(iValue >= Maximum)
            {
                progressPanel.Width = backdropPanel.Width;
                iValue = Maximum;
                itemCounter.Text = iValue + " of " + Maximum;
                timeRemaining.Text = "Finished " + DateTime.Now.ToString("h:mmtt");
                timeRemaining.Location = new Point(Width - timeRemaining.Width, timeRemaining.Location.Y);
                timer.Enabled = false;

                //progressPanel.BackColor = Color.FromArgb(90, 200, 250);
            }
        }

        private void addText(int remaining, string word)
        {
            if (remaining > 0)
            {
                if (timeRemaining.Text != "")
                    timeRemaining.Text += ", ";

                timeRemaining.Text += remaining + " " + word + (remaining == 1 ? "" : "s");
            }
        }
    }
}
