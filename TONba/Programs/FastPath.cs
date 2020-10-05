using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class FastPath : Form
    {
        public FastPath()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = textBox1.Text.ToUpper();
            string description = textBox2.Text;
            string application = textBox3.Text;
            string form = textBox4.Text;
            string version = textBox5.Text;

            string path = "AP:" + application;

            if (form != "")
                path += "|" + form;

            if (version != "")
                path += "|" + version;

            if (code.Length > 10)
            {
                MessageBox.Show("Code cannot be more then 10 characters.");
                return;
            }

            if (description.Length > 30)
            {
                MessageBox.Show("Description cannot be more then 30 characters.");
                return;
            }

            if (path.Length > 30)
            {
                MessageBox.Show("Path is \"" + path + "\". It cannot be more then 30 characters.");
                return;
            }

            if(Oracle.Run("select * from CRPCTL.F0005 where trim(DRSY) = 'H90' and trim(DRRT) = 'FP' and trim(DRKY) = @CODE", code).Rows.Count > 0)
            {
                MessageBox.Show("That code is already in use.");
                return;
            }

            addCode(code, description, path);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            MessageBox.Show("Fast Path code " + code + " added!");

            textBox1.Focus();
        }

        private void addCode(string code, string description, string path)
        {
            Oracle ora = new Oracle("insert into CRPCTL.F0005 values (@DRSY, @DRRT, @DRKY, @DRDL01, @DRDL02, @DRSPHD, @DRUDCO, @DRHRDC, @DRUSER, @DRPID, @DRUPMJ, @DRJOBN, @DRUPMT)");
            ora.AddParameter("@DRSY", "H90 ");
            ora.AddParameter("@DRRT", "FP");
            ora.AddParameter("@DRKY", Core.pad(code, ' ', 10, Core.PadSides.Right)); //Code
            ora.AddParameter("@DRDL01", Core.pad(description, ' ', 30, Core.PadSides.Right)); //Description
            ora.AddParameter("@DRDL02", Core.pad(path, ' ', 30, Core.PadSides.Right)); //Path
            ora.AddParameter("@DRSPHD", "          ");
            ora.AddParameter("@DRUDCO", " ");
            ora.AddParameter("@DRHRDC", "N");
            ora.AddParameter("@DRUSER", "JDE       ");
            ora.AddParameter("@DRPID", "EP0004A   ");
            ora.AddParameter("@DRUPMJ", "102154");
            ora.AddParameter("@DRJOBN", "JDE       ");
            ora.AddParameter("@DRUPMT", "80000");
            ora.Run();

            try
            {
                SQL.Run("insert into JDEFastPath values (@CODE, @DESCRIPTION, @PATH)", code, description, path);
            }
            catch
            {
                
            }
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report r = new Report("Fast Path Codes", Oracle.Run("select * from CRPCTL.F0005 where trim(DRSY) = 'H90' and trim(DRRT) = 'FP' order by DRKY"));
            r.Show();
        }

        private void regenerateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = SQL.Run("select * from JDEFastPath");

            int numRowsBefore = Oracle.Run("select * from CRPCTL.F0005 where trim(DRSY) = 'H90' and trim(DRRT) = 'FP'").Rows.Count;

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string code = dt.Rows[i]["code"].ToString();
                string description = dt.Rows[i]["description"].ToString();
                string path = dt.Rows[i]["path"].ToString();

                try
                {
                    addCode(code, description, path);
                }
                catch
                {

                }
            }

            int numRowsAfter = Oracle.Run("select * from CRPCTL.F0005 where trim(DRSY) = 'H90' and trim(DRRT) = 'FP'").Rows.Count;

            MessageBox.Show((numRowsAfter - numRowsBefore) + " new codes generated.");
        }
    }
}
