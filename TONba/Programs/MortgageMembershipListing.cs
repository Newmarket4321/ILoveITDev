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
    public partial class MortgageMembershipListing : Form
    {
        public MortgageMembershipListing()
        {
            InitializeComponent();
        }

        private void Visa_Load(object sender, EventArgs e)
        {
            Hide();

            string mort = Core.lookupComboBox("Mortgage company", Vailtech.Run(@"
select
MORTGAGE_NO || ' - ' || MORTGAGE_NAME

from vailtech.tx_mortg
order by mortgage_no"));

            if (mort == "")
            {
                Close();
                return;
            }

            DataTable dt = Vailtech.Run(@"
select
ROLL_NO,
STREET_NO,
STREET_NAME,
STREET_UNIT,
MORTGAGE_NO,
R_MORT_IDENTIFIER,
OWNER_1,
OWNER_2,
OWNER_3,
MAILING1,
MAILING2,
MAILING3,
MAILING4,
MAILING5

from vailtech.tx_mortg m
join vailtech.tx_roll r on r.r_mort_co = m.mortgage_no

where mortgage_no = @MORT

order by r.roll_no", mort);
            
            Report r = new Report(Vailtech.RunString("select mortgage_no || ' - ' || mortgage_name from vailtech.tx_mortg where mortgage_no = @MORT", mort), dt);
            r.Show();
            
            Close();
        }
    }
}
