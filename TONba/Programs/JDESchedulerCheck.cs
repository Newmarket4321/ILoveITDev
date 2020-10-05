using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Net;
using System.Threading;

namespace I_IT
{
    class JDESchedulerCheck
    {
        public JDESchedulerCheck()
        {
            //Intended to be run at 8:00AM
            int timeToRun = Core.timeToJDE(new DateTime(2017, 1, 1, 8, 0, 0));

            DataTable dt = Oracle.Run(@"
select JSSCHJBNM, JSUPMJ, JSUPMT

from SY920.F91320

where trim(JSSCHLNCSTAT) not in ('01', '10', '20')
and ((JSUPMJ = @YESTERDAY and JSUPMT >= @TIME) or JSUPMJ = @TODAY)
", Core.dateToJDE(DateTime.Today.AddDays(-1)), timeToRun, Core.dateToJDE(DateTime.Today));
            /*
            UDC H91, LS

        01	Scheduled                     
        10	Launched                      
        20	Job Completed Successfully    
        21	Job Ended in Error            
        22	Error: Resubmitted Immediately
        23	Error: Resubmitted After Delay
        24	Error: Cannot Resubmit        
        25	Error: Could not Submit       
        26	Submit Error: Resubmit Now    
        27	Submit Error; Resubmit Delayed
        28	Submit Error; Cannot Resubmit 
        30	Expired                       
        40	Terminated                    
        41	Terminated: Immediate Resubmit
        42	Terminated: Resubmit Delayed  
        43	Terminated: Cannot Resubmit   
        50	Hold                          
            */

            if (dt.Rows.Count > 0)
            {
                Console.WriteLine("Errors found. Sending e-mails.");

                string output = "<b>The following JDE reports have errored in the last day:</b><br/><br/>";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string line = (i + 1) + ") " + dt.Rows[i]["JSSCHJBNM"].ToString() + " (" + Core.JDEToDate(dt.Rows[i]["JSUPMJ"].ToString()).ToString("dddd, MMMM dd yyyy") + ", " + Core.JDEToTime(dt.Rows[i]["JSUPMT"].ToString()).ToString("h:mmtt") + ")<br/>";

                    output += line;
                    Core.log("JDESchedulerCheck", "Scheduler log", line);
                }

                Core.sendMail("ealarcon@newmarket.ca", "JDE Scheduler Error", output);
                Core.sendMail("msquires@newmarket.ca", "JDE Scheduler Error", output);
            }
            else
                Console.WriteLine("No errors found.");
        }
    }
}
