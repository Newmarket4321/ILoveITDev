using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_IT
{
    class InspectorCapitalization
    {
        public InspectorCapitalization()
        {
            CityView.Run("update sysadmin.inspections set inspector = upper(inspector)");
        }
    }
}
