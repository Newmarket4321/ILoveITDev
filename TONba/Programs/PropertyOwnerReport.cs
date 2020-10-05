using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_IT
{
    class PropertyOwnerReport
    {
        public PropertyOwnerReport()
        {
            Report r = new Report("Property Owner Report", Vailtech.Run("select street_no, street_name, street_unit from sysadmin.tx_roll order by street_name, street_no"));
            r.Show();
        }
    }
}
