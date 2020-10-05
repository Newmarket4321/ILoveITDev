using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace I_IT
{
    public class FormNotifications
    {
        public FormNotifications()
        {
            DataTable dt = SQL.Run("use forms; select * from forms");
       
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string title = dt.Rows[i]["title"].ToString();
                string formID = dt.Rows[i]["ID"].ToString();
                string emailTo = dt.Rows[i]["notifywho"].ToString();
                string frequency = dt.Rows[i]["notifywhen"].ToString();

                if(frequency != "Never")
                    notify(title, formID, emailTo, frequency);
            }
        }

        public void notify(string title, string formID, string emailTo, string frequency)
        {
            DateTime pointInTime = DateTime.Parse(SQL.RunString("use forms; select notificationslastsent from forms where formid = @ID", formID));
            string words = "";

            if (frequency == "Weekly" && DateTime.Now.DayOfWeek != DayOfWeek.Sunday)
                return;

            if (frequency == "Monthly" && DateTime.Now.Day != 1)
                return;

            if (frequency == "Weekly")
                words = "week";
            else if (frequency == "Monthly")
                words = "month";
            else if (frequency == "Daily")
                words = "day";
            else
                throw new Exception("Frequency not found");

            DataTable responses = SQL.Run("use forms; select submissionid from answers where formid = @ID and timestamp >= @DATE group by submissionid", formID, pointInTime);

            if (responses.Rows.Count > 0)
            {
                string body = "Your form <a href=\"http://forms.newmarket.ca/Form.aspx?id=" + formID + "\">" + title + "</a> has " + responses.Rows.Count + " new response" + (responses.Rows.Count == 1 ? "" : "s") + " from the last " + words + ".<br/>"
                    + "To view these responses, please open I♥IT.<br/>"
                    + "<br/>"
                    + "For any questions, please contact IT.";

                Core.sendMail(emailTo, "New responses to " + title, body);

                SQL.Run("use forms; update forms set notificationslastsent = @NEWDATE where formid = @ID", DateTime.Now, formID);

                Core.log("FormNotifications", "Send notification", "E-mailing " + emailTo + " regarding " + responses.Rows.Count + " new response" + (responses.Rows.Count == 1 ? "" : "s") + " to " + title);
                Console.WriteLine("E-mailing " + emailTo + " regarding " + responses.Rows.Count + " new response" + (responses.Rows.Count == 1 ? "" : "s") + " to " + title);
            }
        }
    }
}