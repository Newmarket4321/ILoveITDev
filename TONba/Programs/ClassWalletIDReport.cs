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
    public partial class ClassWalletIDReport : Form
    {
        public ClassWalletIDReport()
        {
            InitializeComponent();

            Class sql = new Class(@"
select distinct
acc.account_id as 'Account ID',
acc.title as 'Title',
cli.barcode_number as 'Barcode Number'

from person per
join client cli on cli.person_id = per.person_id
join account acc on per.person_id = acc.person_id
join FUTURE_PAYMENT_DETAIL FPD on FPD.account_id = acc.account_ID
join credit_card_detail CCD on CCD.credit_card_id = FPD.credit_card_id
join credit_card_detail CCD_payproc on CCD_payproc.wallet_id = CCD.wallet_id
join payproc_payment PPP on CCD_payproc.credit_card_id = PPP.credit_card_id

where PPP.payproc_payment_state = 11
");
            DataTable dt = sql.Run();

            Report r = new Report(Text, dt);
            r.Show();

            Close();
        }
    }
}
