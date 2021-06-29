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
    public partial class HydroAddresses : Form
    {
        public HydroAddresses()
        {
            InitializeComponent();
            getRollNumbers();
        }

        public void getRollNumbers()
        {
            DialogResult result;
            Database db  = new SQL("select OldAddress,RollNumber,id from HydroAddresses order by id");

            Report r = new Report(Text, db ,true,true,true);

            r.Delete_Click += (s, e2) =>
            {
                int id = int.Parse(r.selectedRow["ID"].ToString());
                result = MessageBox.Show("Are You sure want to Delete record?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes && id != 0)
                    SQL.Run("delete from HydroAddresses where ID = @ID", id);
            };

            r.Add_Click += (s, e2) =>
            {
                SQL.Run(@"

");

                int id = int.Parse(r.selectedRow["ID"].ToString());

                HydroAddressesItem item = new HydroAddressesItem();
                item.ShowDialog();
            };

            r.Edit_Click += (s, e2) =>
            {
                int id = int.Parse(r.selectedRow["ID"].ToString());
                HydroAddressesItem item = new HydroAddressesItem();

                item.ShowDialog();
            };
            r.Show();

            Close();
        }
    }
}
