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
    public partial class FindNonpostingAccounts : Form
    {
        public FindNonpostingAccounts()
        {
            InitializeComponent();
        }

        private void Visa_Load(object sender, EventArgs e)
        {
            GetString box = new GetString("Enter batch number");
            box.ShowDialog();

            if (box.r != "")
            {
                Oracle ora = new Oracle(@"
select
VNEDLN/1000 as ""Line Number"",
trim(GMMCU || '.' || GMOBJ || '.' || GMSUB) as Account,
GMDL01 as Description,
GMPEC as ""Account Posting Code"",
DRDL01 as ""Account Posting Description"",
VNSBLT,
VNU,
VNUM

from CRPDTA.F0911Z1
left join CRPDTA.F0901 on GMMCU = VNMCU and GMOBJ = VNOBJ and GMSUB = VNSUB
left join CRPCTL.F0005 on trim(DRKY) = trim(GMPEC)

where (DRSY = 'H00' or DRSY is null)
and (DRRT = 'PE' or DRRT is null)
and trim(VNEDBT) = @BATCH

order by VNEDLN
");
                ora.AddParameter("@BATCH", box.r);

                Core.export(Text, ora.Run());
            }

            Close();
        }

        //private void z(Delegate method)
        //{
        //    MethodInvoker mi = new MethodInvoker(method);
        //    mi.BeginInvoke(null, null);
        //}
    }
}
