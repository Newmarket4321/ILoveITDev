using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_IT
{
    class SwimAppReport
    {
        public SwimAppReport()
        {
            Report r = new Report("SwimApp Report", SQL.Run("use swimapp; select ID, Timestamp, IP, box1 as 'Guardians', box2 as 'Ages 10+', box3 as 'Ages 6-9', box4 as 'Ages 0-5', success as 'Meets Safe Swim Admission Standards' from log order by timestamp desc"));
            r.Show();
        }
    }
}
