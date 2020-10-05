using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class PayRateImport : Form
    {
        public PayRateImport()
        {
            InitializeComponent();

            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Spreadsheet file = new Spreadsheet(openFileDialog1.FileName);

            int RMAX = 2;

            while (file.Cells()[RMAX + 1, 1].Text != "")
                RMAX++;

            for (int i = 2; i <= RMAX; i++)
            {
                Oracle.Run("insert into CRPDTA.F060146 values (@JIAN8, @JIMCU, @JIUN, @JIJBCD, @JIBST, @JIPHRT, @JILOBJ, @JIEFTB, @JIEFTE, @JIPBRT, @JIPPRT, @JIBDRT, @JIB2RT)",
                    file.Cells()[i, 1].Text,
                    "            ",
                    "      ",
                    file.Cells()[i, 2].Text,
                    "    ",
                    (int)(double.Parse(file.Cells()[i, 3].Text) * 1000),
                    "      ",
                    Core.dateToJDE(DateTime.Parse(file.Cells()[i, 4].Text)),
                    Core.dateToJDE(DateTime.Parse(file.Cells()[i, 5].Text)),
                    0,
                    0,
                    0,
                    0
                    );
            }

            MessageBox.Show("Done!");

            file.Close();

            Close();
        }
    }
}
