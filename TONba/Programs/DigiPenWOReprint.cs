using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_IT
{
    class DigiPenWOReprint
    {
        public DigiPenWOReprint()
        {
            bool success;
            int wo = Core.getInt("Enter work order number", out success);

            if(!success)
                return;

            Oracle.Run("delete from CRPDTA.F554801 where WADOCO = @WO", wo);

            Core.log("DigiPenWOReprint", "WO Reprint", wo.ToString());
            Console.WriteLine(wo + " has been marked for reprint.");
        }
    }
}
