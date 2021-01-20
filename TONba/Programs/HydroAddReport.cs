using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using I_IT.Programs;

namespace I_IT
{
    class HydroAddReport
    {
        public HydroAddReport()
        {

             SQL sql = new SQL("select OldAddress,RollNumber,id from HydroAddresses order by id");
            Report r = new Report("ManageHydroAddresses", sql, true, true, true);

            r.Add_Click += (s, e2) =>
            {
                HydroAddressList item = new HydroAddressList();
                item.ShowDialog();
            };

            r.Edit_Click += (s, e2) =>
            {
                int id = int.Parse(r.selectedRow["id"].ToString());
                string Rollnum = r.selectedRow["RollNumber"].ToString();
                string Oldadd= r.selectedRow["OldAddress"].ToString();
                HydroAddressList item = new HydroAddressList(id,Rollnum,Oldadd);
                item.ShowDialog();
            };

            r.Delete_Click += (s, e2) =>
            {
                int id = int.Parse(r.selectedRow["id"].ToString());
                SQL.Run("delete from HydroAddresses where ID = @ID", id);
            };
            r.Show();
        }
    }
}
