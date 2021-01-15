using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT.Programs
{
    public partial class HydroAddressList : Form
    {
        public HydroAddressList()
        {
            InitializeComponent();
        }
        private void Hydroaddress_Load()
        {

            SQL sql = new SQL("select OldAddress,RollNumber,id from HydroAddresses order by id");
            Report r = new Report("ManageHydroAddresses", sql, true, true, true);

            r.Add_Click += (s, e2) =>
            {
                SQL.Run(@"

                ");

                int id = int.Parse(r.selectedRow["id"].ToString());

                ManageHydroAddresses item = new ManageHydroAddresses();
                item.ShowDialog();
            };

            r.Edit_Click += (s, e2) =>
            {
                int id = int.Parse(r.selectedRow["id"].ToString());
                ManageHydroAddresses item = new ManageHydroAddresses(id);
                item.ShowDialog();
            };

            r.Delete_Click += (s, e2) =>
            {
                int id = int.Parse(r.selectedRow["id"].ToString());
                SQL.Run("delete from HydroAddresses where ID = @ID", id);
            };
        }
    }
}
