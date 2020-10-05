using System;
using System.Data;

namespace I_IT
{
    class AppealCalendarNotification
    {
        public AppealCalendarNotification()
        {
            DataTable dt = SQL.Run(@"
select a.rollno,
a.appealno,
a.commencementdate,
e.description,
e.startdate,
e.enddate

from AppealCalendar_Appeals a
join AppealCalendar_Events e on a.appealid = e.appealid

where e.startdate <= @NOW
and e.sent = 0

order by a.appealid, e.startdate
", DateTime.Today);

            string body = "";

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                body += "<b>Roll number:</b> " + dt.Rows[i]["rollno"].ToString() + Environment.NewLine;
                body += "<b>Appeal number:</b> " + dt.Rows[i]["appealno"].ToString() + Environment.NewLine;
                body += "<b>Commencement date:</b> " + DateTime.Parse(dt.Rows[i]["commencementdate"].ToString()).ToString("d MMMM, yyyy") + Environment.NewLine;
                body += Environment.NewLine;

                body += "<b>Event start day:</b> " + DateTime.Parse(dt.Rows[i]["startdate"].ToString()).ToString("d MMMM, yyyy") + Environment.NewLine;
                body += "<b>Event final day:</b> " + DateTime.Parse(dt.Rows[i]["enddate"].ToString()).ToString("d MMMM, yyyy") + Environment.NewLine;
                body += "<b>Event:</b> " + dt.Rows[i]["description"].ToString() + Environment.NewLine;

                if(i + 1 < dt.Rows.Count)
                    body += Environment.NewLine + "----------" + Environment.NewLine + Environment.NewLine;
            }

            if (dt.Rows.Count > 0)
            {
                Core.sendMail("aknegje@newmarket.ca,AppealsRep@newmarket.ca", "Assessment Management Appeal Event", body);

                SQL.Run("update AppealCalendar_Events set sent = 1 where startdate <= @NOW and sent = 0", DateTime.Today);

                Core.log("AppealCalendarNotification", "E-mail sent", dt.Rows.Count + " events run today");
            }
        }
    }
}
