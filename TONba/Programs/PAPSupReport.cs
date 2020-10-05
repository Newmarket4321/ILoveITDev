using System;
using System.Data;
using System.Windows.Forms;

namespace I_IT
{
    public partial class PAPSupReport : Form
    {
        public PAPSupReport()
        {
            InitializeComponent();
        }

        private void Visa_Load(object sender, EventArgs e)
        {
            Hide();

            bool success;
            string origins = Core.getString("Enter origins", true, out success);

            if (!success)
            {
                Close();
                return;
            }

            string origin = Core.lookupComboBox("Origin number", Vailtech.Run(@"
select
origin || ' - ' || to_char(max(post_date), 'FMMonth DD, YYYY')

from vailtech.tx_history_dist

where post_date >= @STARTDATE
and (origin like 'FTX%' or origin like 'STX%')

group by origin

order by max(post_date) desc", DateTime.Today.AddDays(-7)));

            if (origin == "")
            {
                Close();
                return;
            }

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
h1.AMOUNT  AS draw_amount1,
h2.AMOUNT AS draw_amount2,
h3.AMOUNT AS draw_amount3

FROM VAILTECH.TX_ROLL r
JOIN (select * from VAILTECH.TX_HISTORY where reference = '1') h1 ON r.ACTIVITY_NO = h1.ACTIVITY_NO AND r.ROLL_NO = h1.ROLL_NO
JOIN (select * from VAILTECH.TX_HISTORY where reference = '2') h2 ON r.ACTIVITY_NO = h2.ACTIVITY_NO AND r.ROLL_NO = h2.ROLL_NO
JOIN (select * from VAILTECH.TX_HISTORY where reference = '3') h3 ON r.ACTIVITY_NO = h3.ACTIVITY_NO AND r.ROLL_NO = h3.ROLL_NO
JOIN VAILTECH.TX_ROLL_AUDIT  a ON r.ACTIVITY_NO = a.ACTIVITY_NO AND r.ROLL_NO = a.ROLL_NO

WHERE h1.ORIGIN = @ORIGIN1
AND h2.ORIGIN = @ORIGIN2
AND h3.ORIGIN = @ORIGIN3
AND a.POST_DATE >= @SDATE
AND a.POST_DATE <= @EDATE
AND a.ATYPE = '07'
AND a.FLD_TO = '00'
");
            ora.AddParameter("@ORIGIN1", origin);
            ora.AddParameter("@ORIGIN2", origin);
            //ora.AddParameter("@ORIGIN3", origin);
            //ora.AddParameter("@SDATE", start.Date);
            //ora.AddParameter("@EDATE", end.Date.AddDays(1));
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
    }
}
