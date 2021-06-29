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
    public partial class HydroAddressesItem : Form
    {
        public HydroAddressesItem()
        {
            InitializeComponent();
            getRollNumbers();
        }

        public void getRollNumbers()
        {
            Database db  = new SQL("select OldAddress,RollNumber,id from HydroAddresses order by id");

            Report r = new Report(Text, db ,true,true,true);

            r.Delete_Click += (s, e2) =>
            {
                int id = int.Parse(r.selectedRow["ID"].ToString());
                SQL.Run("delete from HydroAddresses where ID = @ID", id);
            };

            r.Show();

            Close();
        }
    }
}
