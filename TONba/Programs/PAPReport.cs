using System;
using System.Data;
using System.Windows.Forms;

namespace I_IT
{
    public partial class PAPReport : Form
    {
        public PAPReport()
        {
            InitializeComponent();
        }

        private void Visa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year;

            if (DateTime.Today.Month <= 10)
                year = DateTime.Today.Year - 1;
            else
                year = DateTime.Today.Year;

            Vailtech ora = new Vailtech(@"
SELECT
substr(r.ROLL_NO,1,3) AS Roll1,
substr(r.ROLL_NO,4,3) AS Roll2,
substr(r.ROLL_NO,7,5) AS Roll3,
substr(r.ROLL_NO,12,4) AS Roll4,
r.OWNER_1 AS First_Name,
r.OWNER_2 AS SECOND_Name,
r.MAILING1 AS Address_Line_1,
r.MAILING2 AS Address_Line_2,
r.MAILING3 AS City,
r.MAILING4 AS Province,
r.MAILING5 AS Postal_Code,
r.STREET_NO || decode(r.STREET_QUAL, '-', '-' || r.STREET_UNIT, null, '', r.STREET_QUAL) || ' ' || r.STREET_NAME AS Property,
ps.AMOUNT AS draw_amount,
m.TAX_LEVIED AS total_taxes

FROM VAILTECH.TX_ROLL r
INNER JOIN VAILTECH.TX_ROLL_PAP p ON r.ACTIVITY_NO = p.ACTIVITY_NO AND r.ROLL_NO = p.ROLL_NO
LEFT JOIN VAILTECH.TX_ROLL_PAP_SCHEDULE ps ON p.ACTIVITY_NO = ps.ACTIVITY_NO AND p.ROLL_NO = ps.ROLL_NO
LEFT JOIN VAILTECH.TX_MAINHT m ON m.ACTIVITY_NO = ps.ACTIVITY_NO AND m.ROLL_NO = ps.ROLL_NO

WHERE p.PLAN_TYPE = @PAPTYPE
AND p.ENROLLMENT_DATE = @EDATE
AND (m.HIS_YEAR = @LASTYEAR or m.HIS_YEAR is null)
AND (ps.SCHEDULE_NO = (select min(VAILTECH.TX_ROLL_PAP_SCHEDULE.schedule_no) from VAILTECH.TX_ROLL_PAP_SCHEDULE where VAILTECH.TX_ROLL_PAP_SCHEDULE.roll_no = r.roll_no) or ps.SCHEDULE_NO is null)
");
            ora.AddParameter("@PAPTYPE", textBox1.Text);
            ora.AddParameter("@EDATE", dateTimePicker1.Value.Date);
            ora.AddParameter("@LASTYEAR", year);
            DataTable dt = ora.Run();

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string m = dt.Rows[i]["Province"].ToString().Replace(",", " ").Trim();
                string[] split = m.Split(' ');

                string province = split[split.Length - 1];
                string city = m.Substring(0, m.Length - province.Length);

                if (province.Length > 2)
                    province = province.Substring(0, 2);

                dt.Rows[i]["Province"] = province;
                dt.Rows[i]["City"] = city;
            }

            Report r = new Report(Text, dt);
            r.Show();

            Close();
        }

        private void OwnershipChangeReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(null, null);
            else if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
