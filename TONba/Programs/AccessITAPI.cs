using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace I_IT
{
    public class AccessITAPI
    {
        const string technicianName = "Smyth, Graeme";
        const string BaseUrl = "http://accessit:8080/";

        public AccessITAPI()
        {
            bool debug = false;

            bool summerHours = Core.getVariable("SummerHours") == "True";
            string email = SQL.RunString("select email from oncall where oncall = 1");
            DateTime now = DateTime.Now;

            if (debug)
            {
                now = new DateTime(2018, 5, 7, 20, 0, 0);
                email = "gsmyth@newmarket.ca";
            }

            bool outsideWorkHours = now.Hour < 8
    || now.Hour > 16
    || (now.Hour == 8 && now.Minute < 30)
    || (now.Hour == 16 && now.Minute >= 30)
    || (summerHours && now.DayOfWeek == DayOfWeek.Friday && now.Hour == 16)
    || now.DayOfWeek == DayOfWeek.Saturday
    || now.DayOfWeek == DayOfWeek.Sunday
    || (now.Month == 12 && now.Day >= 25) //Soft close
    || Core.isHoliday(now.Date);

            int lastTicket = int.Parse(Core.getVariable("AccessITLastTicket"));
            int latest = AccessIT.getLatestRequest(technicianName);

            if (latest <= 0)
                return;

            for (int i = lastTicket + 1; i <= latest; i++)
            {
                Request request = AccessIT.getRequest(technicianName, i);

                if (request != null)
                {
                    if (request.status == "Open")
                    {
                        if (request.technician != null && request.technician.Contains("Graeme") && request.group == null)
                            AccessIT.updateGroup(technicianName, i, "Enterprise Application Support");
                        
                        if ((
                            (request.technician != null && request.technician.Contains("Graeme"))
                            || (request.group != null && request.group.Contains("Enterprise")))
                            && request.category == null)
                            AccessIT.updateCategory(technicianName, i, "Enterprise Application/Software");

                        //Set group and category for HR tickets
                        if (request.subject.Contains("Employee Status Change") && (request.category == null || request.group == null))
                        {
                            AccessIT.updateCategory(technicianName, i, "User Administration");
                            AccessIT.updateGroup(technicianName, i, "PC/Printer/Desktop App Support");
                        }

                        //Set group and category for DATS tickets
                        if (request.subject.Contains("DATS"))
                        {
                            if (request.category == null || request.category == "Enterprise Application/Software")
                            {
                                AccessIT.updateCategory(technicianName, i, "Enterprise Application/Software");
                                AccessIT.updateSubcategory(technicianName, i, "DATS");
                            }
                            
                            if(request.group == null)
                                AccessIT.updateGroup(technicianName, i, "Enterprise Application Support");

                            if (request.technician == null)
                                AccessIT.assignTicket(technicianName, request.workorderid, 32103); //Graeme
                        }

                        //Set group and category for GIS tickets
                        //if (request.subject.Contains("GIS") || request.subject.Contains("Map"))
                        //{
                        //    if (request.category == null || request.category == "GIS")
                        //    {
                        //        AccessIT.updateCategory(i, "GIS");
                        //        AccessIT.updateSubcategory(i, "Map");
                        //    }

                        //    if (request.group == null)
                        //        AccessIT.updateGroup(i, "GIS Support");
                        //}

                        //Mail for on-call
                        if (outsideWorkHours)
                        {
                            string body = "<b>\"" + request.subject + "\" ticket has been created.</b>" + Environment.NewLine;
                            body += "http://accessit.newmarket.ca:8080/WorkOrder.do?woMode=viewWO&woID=" + request.workorderid + Environment.NewLine;
                            body += Environment.NewLine;
                            body += "<b>Requester:</b>" + Environment.NewLine;
                            body += request.requester + Environment.NewLine;
                            body += Environment.NewLine;
                            body += "<b>Ticket information:</b>" + Environment.NewLine;
                            body += request.description;

                            Core.sendMail(email, "AccessIT: \"" + request.subject + "\" ticket entered", body);
                            log(request.workorderid.ToString() + " sent to " + email);
                        }
                        else
                            log(request.workorderid + " - Not outside work hours");
                    }
                    else
                        log(request.workorderid + " - Status " + request.status);
                }
                else
                    log(i + " - Ticket not found");
            }

            Core.setVariable("AccessITLastTicket", latest.ToString());
        }

        public void log(string s)
        {
            Console.Write(s + Environment.NewLine);
            Core.log("AccessITAPI", "Log", s);
        }
    }
}