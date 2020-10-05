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
    public partial class MortgageMembershipReport : Form
    {
        public MortgageMembershipReport()
        {
            InitializeComponent();
        }

        private void Visa_Load(object sender, EventArgs e)
        {
            Hide();

            DataTable dt = Vailtech.Run(@"
select
MORTGAGE_NO,
MORTGAGE_NAME,
count(R_MORT_CO) as NO_MEMBERS

from vailtech.tx_mortg m
join vailtech.tx_roll r on r.r_mort_co = m.mortgage_no

group by mortgage_no, mortgage_name

order by mortgage_no");
            
            Report r = new Report(Text, dt);
            r.Show();
            
            Close();
        }
    }
}
