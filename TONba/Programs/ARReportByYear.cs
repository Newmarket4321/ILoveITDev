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
    public partial class ARReportByYear : Form
    {
        public ARReportByYear()
        {
            InitializeComponent();
            
            SQL sql = new SQL("select * from programs where code=@CODE");
            sql.AddParameter("@CODE", Name);
            DataTable dt = sql.Run();

            Text = dt.Rows[0]["Description"].ToString();
        }

        private void Visa_Load(object sender, EventArgs e)
        {
            Vailtech ora = new Vailtech(@"
SELECT
VAILTECH.TX_MAINHT.HIS_YEAR AS ""Year"",
VAILTECH.TX_MAINHT.ROLL_NO AS ""Roll Number"",
TAX_DUE+PEN_DUE+TAX_ADJ+PEN_ADJ+OTHER_ADJ+OTHER_DUE-TAX_PAID-PEN_PAID-OTHER_PAID AS ""Tax Due Balance""

FROM VAILTECH.TX_MAINHT

WHERE TAX_DUE+PEN_DUE+TAX_ADJ+PEN_ADJ+OTHER_ADJ+OTHER_DUE-TAX_PAID-PEN_PAID-OTHER_PAID <> 0

ORDER BY
VAILTECH.TX_MAINHT.ROLL_NO,
VAILTECH.TX_MAINHT.HIS_YEAR
");
            Report r = new Report(Text, ora.Run());
            r.Show();

            Close();
        }
    }
}
