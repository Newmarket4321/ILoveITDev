using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class ROAExtension : Form
    {
        public ROAExtension()
        {
            InitializeComponent();

            GetString box = new GetString("Extend which permit?");
            box.ShowDialog();

            if (box.r != "")
            {
                GetDate date = new GetDate("Extend until when?");
                date.ShowDialog();

                if(date.r != new DateTime(1900, 1, 1))
                {
                    SQL sql = new SQL("use roa; update applications set completiondate=@DATE where id=@ID");
                    sql.AddParameter("@DATE", date.r);
                    sql.AddParameter("@ID", box.r.Replace("ROP", "").Replace("-", "").Trim());
                    sql.Run();

                    MessageBox.Show("Done!");
                }
            }

            Close();
        }
    }
}
