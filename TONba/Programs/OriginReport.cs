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
    public partial class OriginReport : Form
    {
        public OriginReport()
        {
            InitializeComponent();
        }

        private void Visa_Load(object sender, EventArgs e)
        {
            Hide();

            string origin = Core.lookupComboBox("Origin number", Vailtech.Run(@"
select
origin || ' - ' || to_char(max(post_date), 'FMMonth DD, YYYY')

from vailtech.tx_history_dist

where post_date >= @STARTDATE
and origin like 'ADJ%'

group by origin

order by max(post_date) desc", DateTime.Today.AddDays(-7)));

            if(origin == "")
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
r.STREET_NO || decode(r.STREET_QUAL, '-', '-' || r.STREET_UNIT, null, '', r.STREET_QUAL) || ' ' || r.STREET_NAME AS Property

FROM VAILTECH.TX_HISTORY_DIST hd
JOIN VAILTECH.TX_ROLL r ON hd.ROLL_NO = r.ROLL_NO and hd.ACTIVITY_NO = r.ACTIVITY_NO

WHERE hd.ORIGIN = @ORILIST
");
            ora.AddParameter("@ORILIST", origin);
            DataTable dt = ora.Run();
            
            Report r = new Report(Text, dt);
            r.Show();
            
            Close();
        }
    }
}
