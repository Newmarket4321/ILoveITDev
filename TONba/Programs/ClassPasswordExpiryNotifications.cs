using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_IT
{
    class ClassPasswordExpiryNotifications
    {
        public ClassPasswordExpiryNotifications()
        {
            DataTable dt = Class.Run(@"
select
name,
LOGINPROPERTY(name, 'DaysUntilExpiration') as days

from master..syslogins
where LOGINPROPERTY(name, 'DaysUntilExpiration') > 0
and LOGINPROPERTY(name, 'DaysUntilExpiration') < 7");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string name = dt.Rows[i]["name"].ToString();
                int days = int.Parse(dt.Rows[i]["days"].ToString());
                Core.sendMail(name + "@newmarket.ca", "Your Class password will expire in " + days + " day" + (days == 1 ? "." : "s."), "Once logged into Class, press the \"***\" button on the top-left to change your password.");

                Core.log("ClassPasswordExpiryNotifications", "E-mail sent", name + "@newmarket.ca");
            }
        }
    }
}
