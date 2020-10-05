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
    public partial class OMERS : Form
    {
        public OMERS()
        {
            InitializeComponent();

            startYear.Value = DateTime.Now.Year - 1;
            endYear.Value = DateTime.Now.Year;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            process();
        }

        private double getHours(string empNo, string year)
        {
            Oracle ora = new Oracle(@"
SELECT
sum(YTPHRW) * 0.01 AS Hours_Worked

FROM CRPDTA.F0618

WHERE CRPDTA.F0618.YTAN8 = @EMPNO
AND CRPDTA.F0618.YTFY = @YEAR
AND CRPDTA.F0618.YTSBLT <> 'W'
AND CRPDTA.F0618.YTHMCU <> '91531'

GROUP BY
CRPDTA.F0618.YTAN8,
CRPDTA.F0618.YTFY
");
            ora.AddParameter("@EMPNO", int.Parse(empNo));
            ora.AddParameter("@YEAR", int.Parse(year));
            DataTable dt = ora.Run();

            if (dt.Rows.Count == 0)
                return 0;

            return double.Parse(dt.Rows[0][0].ToString());
        }

        private double getYMPEAmount(string empNo, string year)
        {
            Oracle ora = new Oracle(@"
SELECT
sum(((YTGPA * 0.01) * 0.04)+((YTGPA * 0.01))) AS YMPE_Amount

FROM CRPDTA.F0618

WHERE CRPDTA.F0618.YTHMCU <> '91531'
AND CRPDTA.F0618.YTSBLT <> 'W'
AND CRPDTA.F0618.YTAN8 = @EMPNO
AND CRPDTA.F0618.YTFY = @YEAR

GROUP BY
CRPDTA.F0618.YTHMCU,
CRPDTA.F0618.YTFY
");
            ora.AddParameter("@EMPNO", empNo);
            ora.AddParameter("@YEAR", year);
            DataTable dt = ora.Run();

            if (dt.Rows.Count == 0)
                return 0;

            return double.Parse(dt.Rows[0][0].ToString());
        }

        private double getVacAmount(string empNo, string year)
        {
            Oracle ora = new Oracle(@"
SELECT
sum(YTGPA * 0.01 * 0.04) AS Vac_Amount

FROM CRPDTA.F0618

WHERE CRPDTA.F0618.YTHMCU <> '91531'
AND CRPDTA.F0618.YTSBLT <> 'W'
AND CRPDTA.F0618.YTAN8 = @EMPNO
AND CRPDTA.F0618.YTFY = @YEAR

GROUP BY
CRPDTA.F0618.YTHMCU,
CRPDTA.F0618.YTFY
");
            ora.AddParameter("@EMPNO", empNo);
            ora.AddParameter("@YEAR", year);
            DataTable dt = ora.Run();

            if (dt.Rows.Count == 0)
                return 0;

            return double.Parse(dt.Rows[0][0].ToString());
        }

        private double getGrossAmount(string empNo, string year)
        {
            Oracle ora = new Oracle(@"
SELECT
sum(YTGPA * 0.01) AS Vac_Amount

FROM CRPDTA.F0618

WHERE CRPDTA.F0618.YTHMCU <> '91531'
AND CRPDTA.F0618.YTSBLT <> 'W'
AND CRPDTA.F0618.YTAN8 = @EMPNO
AND CRPDTA.F0618.YTFY = @YEAR

GROUP BY
CRPDTA.F0618.YTHMCU,
CRPDTA.F0618.YTFY
");
            ora.AddParameter("@EMPNO", empNo);
            ora.AddParameter("@YEAR", year);
            DataTable dt = ora.Run();

            if (dt.Rows.Count == 0)
                return 0;

            return double.Parse(dt.Rows[0][0].ToString());
        }

        private void process()
        {
            Oracle ora = new Oracle(@"
SELECT
CRPDTA.F0101.ABAN8 AS Employee_Number,
CRPDTA.F0101.ABALPH AS Employee_Name

FROM CRPDTA.F0101
INNER JOIN CRPDTA.F060116 ON CRPDTA.F0101.ABAN8 = CRPDTA.F060116.YAAN8
INNER JOIN CRPDTA.F0618 ON CRPDTA.F0101.ABAN8 = CRPDTA.F0618.YTAN8

WHERE CRPDTA.F0618.YTHMCU <> '91531'
AND CRPDTA.F0618.YTFY >= @DATEBEGIN
AND CRPDTA.F0618.YTFY <= @DATEEND
AND CRPDTA.F0618.YTSBLT <> 'W'
AND CRPDTA.F060116.YAPAST in ('0', '1', '8', '9', 'I', 'M', 'T', 'U')
AND CRPDTA.F060116.YAUN in ('CON', 'PTH', 'PTC', 'XGRD', 'SEIU.C', 'O/SCL.')

GROUP BY
CRPDTA.F0101.ABAN8,
CRPDTA.F0101.ABALPH
            ");
            ora.AddParameter("@DATEBEGIN", startYear.Value.ToString().Substring(2));
            ora.AddParameter("@DATEEND", endYear.Value.ToString().Substring(2));
            DataTable dt = ora.Run();

            DataTable results = new DataTable();
            results.Columns.Add("Employee ID");
            results.Columns.Add("Name");
            results.Columns.Add("Status");

            results.Columns.Add(startYear.Value + " Hours");
            results.Columns.Add(endYear.Value + " Hours");

            results.Columns.Add(startYear.Value + " Gross Pay");
            results.Columns.Add(endYear.Value + " Gross Pay");

            results.Columns.Add(startYear.Value + " Vacation Pay");
            results.Columns.Add(endYear.Value + " Vacation Pay");

            results.Columns.Add(startYear.Value + " YMPE");
            results.Columns.Add(endYear.Value + " YMPE");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                double startHours = getHours(dt.Rows[i][0].ToString(), startYear.Value.ToString().Substring(2));
                double endHours = getHours(dt.Rows[i][0].ToString(), endYear.Value.ToString().Substring(2));

                double startYMPEAmount = getYMPEAmount(dt.Rows[i][0].ToString(), startYear.Value.ToString().Substring(2));
                double endYMPEAmount = getYMPEAmount(dt.Rows[i][0].ToString(), endYear.Value.ToString().Substring(2));

                double startGrossAmount = getGrossAmount(dt.Rows[i][0].ToString(), startYear.Value.ToString().Substring(2));
                double endGrossAmount = getGrossAmount(dt.Rows[i][0].ToString(), endYear.Value.ToString().Substring(2));

                double startVacAmount = getVacAmount(dt.Rows[i][0].ToString(), startYear.Value.ToString().Substring(2));
                double endVacAmount = getVacAmount(dt.Rows[i][0].ToString(), endYear.Value.ToString().Substring(2));

                if (startHours >= 700 && endHours >= 700
                    || (startYMPEAmount >= 0.35 * double.Parse(numericUpDown1.Value.ToString()) && endYMPEAmount >= 0.35 * double.Parse(numericUpDown2.Value.ToString())))
                {
                    object[] items = { dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), "Offer", startHours, endHours, startGrossAmount, endGrossAmount, startVacAmount, endVacAmount, startYMPEAmount, endYMPEAmount };
                    results.Rows.Add(items);
                }
                else if (startHours >= 700 && endHours >= 600)
                {
                    object[] items = { dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), "Close", startHours, endHours, startGrossAmount, endGrossAmount, startVacAmount, endVacAmount, startYMPEAmount, endYMPEAmount };
                    results.Rows.Add(items);
                }
                else
                {
                    object[] items = { dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), "-", startHours, endHours, startGrossAmount, endGrossAmount, startVacAmount, endVacAmount, startYMPEAmount, endYMPEAmount };
                    results.Rows.Add(items);
                }
            }

            Report r = new Report(Text, results);
            r.Show();
        }
    }
}
