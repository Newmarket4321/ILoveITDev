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
    public partial class PAPSummaryByYear : Form
    {
        public PAPSummaryByYear()
        {
            InitializeComponent();
        }

        private void Visa_Load(object sender, EventArgs e)
        {
            Hide();

            bool success;
            int year = Core.getInt("Enter year", 1900, DateTime.Today.Year + 5, DateTime.Today.Year, out success);

            if(!success)
            {
                Close();
                return;
            }

            DataTable dt = Vailtech.Run(@"
select distinct
plan_type as PAP_Plan,
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

from vailtech.tx_roll_pap p
join vailtech.tx_billprint b on p.roll_no = b.roll_no
join vailtech.tx_roll r on p.roll_no = r.roll_no
where tax_year = @YEAR
and origin like 'STX%'", year);
            
            Report r = new Report(Text, dt);
            r.Show();
            
            Close();
        }
    }
}
