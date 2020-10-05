using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    class CityViewAddressChange
    {
        public CityViewAddressChange()
        {
            bool success;

            string permit = Core.getString("Enter permit number, including the A or P.", out success).Trim();

            if (!success)
                return;

            if(CityView.Run("select * from sysadmin.building_permits where application_number = @PERMIT", permit).Rows.Count == 0) 
            {
                MessageBox.Show("Permit not found.");
                return;
            }

            Report r = new Report("Select new address", CityView.Run("select recordid as ID, ROLL_NUM, STREET_NUMBER, STREET_NAME, UNIT_NUMBER from sysadmin.ASSESS order by ID"), Report.ReportMode.SELECT);
            r.ShowDialog();

            int newID;

            if (r.selectedRow != null)
                newID = int.Parse(r.selectedRow["ID"].ToString());
            else
                return;
            
            int oldID = int.Parse(CityView.RunString("select assess_id from sysadmin.building_permits where application_number = @PERMIT", permit));
            CityView.Run("update sysadmin.building_permits set assess_id = @ASSESS where application_number = @PERMIT", newID, permit);
            Core.log("CityViewAddressChange", "Address changed", permit + "'s ASSESS_ID from " + oldID + " to " + newID);

            MessageBox.Show(permit + "'s address has been updated.");
        }
    }
}
