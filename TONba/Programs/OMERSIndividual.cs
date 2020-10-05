using System;
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
    public partial class OMERSIndividual : Form
    {
        public OMERSIndividual()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            process();
        }

        private void process()
        {
            Oracle ora = new Oracle(@"
SELECT
CRPDTA.F0618.YTAN8 AS Employee_Number,
CRPDTA.F0101.ABALPH AS Employee_Name,
CRPDTA.F0618.YTFY AS Year,
sum(YTPHRW) * 0.01 AS Hours_Worked,
sum(YTGPA * 0.01) AS Gross_Amount,
sum(YTGPA * 0.01 * 0.04) AS Vac_Amount,
sum(((YTGPA * 0.01) * 0.04)+((YTGPA * 0.01))) AS YMPE_Amount

FROM CRPDTA.F0618
INNER JOIN CRPDTA.F0101 ON CRPDTA.F0101.ABAN8 = CRPDTA.F0618.YTAN8

WHERE CRPDTA.F0618.YTSBLT <> 'W'
AND CRPDTA.F0618.YTAN8 = @EMPNO
AND CRPDTA.F0618.YTFY >= 3

GROUP BY
CRPDTA.F0618.YTAN8,
CRPDTA.F0101.ABALPH,
CRPDTA.F0618.YTFY

ORDER BY
YTFY
            ");
            ora.AddParameter("@EMPNO", textBox1.Text);
            DataTable dt = ora.Run();
            
            Report r = new Report(Text, dt);
            r.Show();
        }

        private void OMERSIndividual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(null, null);
            else if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
