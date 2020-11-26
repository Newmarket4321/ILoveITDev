using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;

namespace I_IT
{
    public class AccessIT
    {
        const string BaseUrl = "http://accessit:8080/";

        private static XmlDocument getDocument(string technicianKey, RestRequest request)
        {
            request.AddParameter("TECHNICIAN_KEY", technicianKey);

            RestClient client = new RestClient();
            client.BaseUrl = new System.Uri(BaseUrl);
            IRestResponse<Request> response = client.Execute<Request>(request);
            XmlDocument doc = new XmlDocument();

            try
            {
                doc.LoadXml(response.Content);
            }
            catch
            {
                return null;
            }
            
            //Core.sendMail("gsmyth@newmarket.ca", "Test", response.Content);

            string status = "";

            try
            {
                status = doc.ChildNodes[1].ChildNodes[0].ChildNodes[0].ChildNodes[0].InnerText;
            }
            catch
            {
                status = doc.ChildNodes[0].ChildNodes[0].ChildNodes[0].InnerText;
            }

            if (status == "Failed")
                return null;

            return doc;
        }

        public static void assignTicket(string technicianName, int ticketID, int technicianID)
        {
            string technicianKey = SQL.RunString("select techniciankey from AccessITExpressTechnicians where displayname = @NAME", technicianName);

            RestRequest request = new RestRequest();
            request.Resource = "/sdpapi/request/{request_id}";
            request.AddParameter("request_id", ticketID, ParameterType.UrlSegment);
            request.AddParameter("OPERATION_NAME", "ASSIGN_REQUEST");
            request.AddParameter("INPUT_DATA", @"
<Operation>
    <Details>
        <parameter>
            <name>technicianid</name>
            <value>" + technicianID + @"</value>
        </parameter>
    </Details>
</Operation>");

            XmlDocument doc = getDocument(technicianKey, request);

            if (doc == null)
                return;

            log(ticketID + " - Ticket assigned to " + technicianID);

            return;
        }
        
        public static void createRequest(string technicianName, Request r)
        {
            string technicianKey = SQL.RunString("select techniciankey from AccessITExpressTechnicians where displayname = @NAME", technicianName);

            RestRequest request = new RestRequest();
            request.Resource = "/sdpapi/request/";
            request.AddParameter("OPERATION_NAME", "ADD_REQUEST");

            string input_data = @"
<Operation>
    <Details>
        ";

            if (r.attachment != null)
                input_data += "<parameter><name>Attachment</name><value>" + r.attachment + @"</value></parameter>";
            if (r.category != null)
                input_data += "<parameter><name>Category</name><value>" + r.category + @"</value></parameter>";
            if (r.completeddate != null)
                input_data += "<parameter><name>Completed Date</name><value>" + r.completeddate + @"</value></parameter>";
            if (r.createddate != null)
                input_data += "<parameter><name>Created Date</name><value>" + r.createddate + @"</value></parameter>";
            if (r.description != null)
                input_data += "<parameter><name>Description</name><value>" + r.description + @"</value></parameter>";
            if (r.duebydate != null)
                input_data += "<parameter><name>Due By Date</name><value>" + r.duebydate + @"</value></parameter>";
            if (r.emailcc != null)
                input_data += "<parameter><name>Email CC</name><value>" + r.emailcc + @"</value></parameter>";
            if (r.frduebydate != null)
                input_data += "<parameter><name>Fr Due By Date</name><value>" + r.frduebydate + @"</value></parameter>";
            if (r.group != null)
                input_data += "<parameter><name>Group</name><value>" + r.group + @"</value></parameter>";
            if (r.impact != null)
                input_data += "<parameter><name>Impact</name><value>" + r.impact + @"</value></parameter>";
            if (r.impactdetails != null)
                input_data += "<parameter><name>Impact Details</name><value>" + r.impactdetails + @"</value></parameter>";
            if (r.item != null)
                input_data += "<parameter><name>Item</name><value>" + r.item + @"</value></parameter>";
            if (r.level != null)
                input_data += "<parameter><name>Level</name><value>" + r.level + @"</value></parameter>";
            if (r.mode != null)
                input_data += "<parameter><name>Mode</name><value>" + r.mode + @"</value></parameter>";
            if (r.priority != null)
                input_data += "<parameter><name>Priority</name><value>" + r.priority + @"</value></parameter>";
            if (r.reason != null)
                input_data += "<parameter><name>Reason</name><value>" + r.reason + @"</value></parameter>";
            if (r.requester != null)
                input_data += "<parameter><name>Requester</name><value>" + r.requester + @"</value></parameter>";
            if (r.requestType != null)
                input_data += "<parameter><name>Request Type</name><value>" + r.requestType + @"</value></parameter>";
            if (r.resolveddate != null)
                input_data += "<parameter><name>Resolved Date</name><value>" + r.resolveddate + @"</value></parameter>";
            if (r.respondeddate != null)
                input_data += "<parameter><name>Responded Date</name><value>" + r.respondeddate + @"</value></parameter>";
            if (r.service != null)
                input_data += "<parameter><name>Service</name><value>" + r.service + @"</value></parameter>";
            if (r.status != null)
                input_data += "<parameter><name>Status</name><value>" + r.status + @"</value></parameter>";
            if (r.subcategory != null)
                input_data += "<parameter><name>Subcategory</name><value>" + r.subcategory + @"</value></parameter>";
            if (r.subject != null)
                input_data += "<parameter><name>Subject</name><value>" + r.subject + @"</value></parameter>";
            if (r.technician != null)
                input_data += "<parameter><name>Technician</name><value>" + r.technician + @"</value></parameter>";
            if (r.urgency != null)
                input_data += "<parameter><name>Urgency</name><value>" + r.urgency + @"</value></parameter>";
            if (r.workorderid != 0) //Shouldn't use this for creation
                input_data += "<parameter><name>Work Order ID</name><value>" + r.workorderid + @"</value></parameter>";
            
            input_data += @"
    </Details>
</Operation>";


            request.AddParameter("INPUT_DATA", input_data);

            XmlDocument doc = getDocument(technicianKey, request);

            if (doc == null)
                return;

            log("NEW - Created request");

            return;
        }

        public static void setResolution(string technicianName, int id, string resolution)
        {
            string technicianKey = SQL.RunString("select techniciankey from AccessITExpressTechnicians where displayname = @NAME", technicianName);

            RestRequest request = new RestRequest();
            request.Resource = "/sdpapi/request/{request_id}/resolution";
            request.AddParameter("request_id", id, ParameterType.UrlSegment);
            request.AddParameter("OPERATION_NAME", "ADD_RESOLUTION");
            request.AddParameter("INPUT_DATA", @"
<Operation>
    <Details>
        <resolution>
            <parameter>
                <name>resolutiontext</name>
                <value>" + resolution + @"</value>
            </parameter>
        </resolution>
    </Details>
</Operation>");

            XmlDocument doc = getDocument(technicianKey, request);

            if (doc == null)
                return;

            return;
        }

        public static void closeRequest(string technicianName, int id, string resolution)
        {
            string technicianKey = SQL.RunString("select techniciankey from AccessITExpressTechnicians where displayname = @NAME", technicianName);

            setResolution(technicianName, id, resolution);

            RestRequest request = new RestRequest();
            request.Resource = "/sdpapi/request/{request_id}";
            request.AddParameter("request_id", id, ParameterType.UrlSegment);
            request.AddParameter("OPERATION_NAME", "CLOSE_REQUEST");
            request.AddParameter("INPUT_DATA", @"
<Operation>
    <Details>
        <parameter>
            <name>closeAccepted</name>
            <value>Accepted</value>
        </parameter>
        <parameter>
            <name>closeComment</name>
            <value>" + resolution + @"</value>
        </parameter>
    </Details>
</Operation>");

            XmlDocument doc = getDocument(technicianKey, request);

            if (doc == null)
                return;

            log(id + " - Request closed");

            return;
        }

        public static Request getRequest(string technicianName, int id)
        {
            string technicianKey = SQL.RunString("select techniciankey from AccessITExpressTechnicians where displayname = @NAME", technicianName);

            RestRequest request = new RestRequest();
            request.Resource = "/sdpapi/request/{request_id}";
            request.AddParameter("request_id", id, ParameterType.UrlSegment);
            request.AddParameter("OPERATION_NAME", "GET_REQUEST");

            XmlDocument doc = getDocument(technicianKey, request);

            if (doc == null) 
                return null;

            XmlNodeList parameters = doc.ChildNodes[1].ChildNodes[0].ChildNodes[0].ChildNodes[1].ChildNodes;

            Request r = new Request();

            for (int i = 0; i < parameters.Count; i++)
            {
                if (parameters[i].ChildNodes.Count != 0)
                {
                    string name = parameters[i].ChildNodes[0].InnerText;
                    string value = parameters[i].ChildNodes[1].InnerText;

                    if (name == "workorderid")
                        r.workorderid = int.Parse(value);
                    else if (name == "requestType")
                        r.requestType = value;
                    else if (name == "impact")
                        r.impact = value;
                    else if (name == "status")
                        r.status = value;
                    else if (name == "impactdetails")
                        r.impactdetails = value;
                    else if (name == "mode")
                        r.mode = value;
                    else if (name == "urgency")
                        r.urgency = value;
                    else if (name == "level")
                        r.level = value;
                    else if (name == "priority")
                        r.priority = value;
                    else if (name == "requester")
                        r.requester = value;
                    else if (name == "category")
                        r.category = value;
                    else if (name == "group")
                        r.group = value;
                    else if (name == "subcategory")
                        r.subcategory = value;
                    else if (name == "technician")
                        r.technician = value;
                    else if (name == "item")
                        r.item = value;
                    else if (name == "service")
                        r.service = value;
                    else if (name == "emailcc")
                        r.emailcc = value;
                    else if (name == "subject")
                        r.subject = value;
                    else if (name == "description")
                        r.description = value;
                    else if (name == "createdtime")
                        r.createddate = Core.FromUnixTime(long.Parse(value));
                    else if (name == "respondedtime")
                        r.respondeddate = Core.FromUnixTime(long.Parse(value));
                    else if (name == "duebytime")
                        r.duebydate = Core.FromUnixTime(long.Parse(value));
                    else if (name == "completedtime")
                        r.completeddate = Core.FromUnixTime(long.Parse(value));
                    else if (name == "resolvedtime")
                        r.resolveddate = Core.FromUnixTime(long.Parse(value));
                    else if (name == "fr_duetime")
                        r.frduebydate = Core.FromUnixTime(long.Parse(value));
                    else if (name == "objectattachment")
                        r.attachment = value;
                    else if (name == "reason")
                        r.reason = value;
                }
            }

            return r;
        }

        public static List<Request> getRequests(string technicianName, int max, string viewName)
        {
            string technicianKey = SQL.RunString("select techniciankey from AccessITExpressTechnicians where displayname = @NAME", technicianName);

            RestRequest request = new RestRequest();
            request.Resource = "/sdpapi/request";
            request.AddParameter("OPERATION_NAME", "GET_REQUESTS");
            request.AddParameter("INPUT_DATA", @"
<Details>
    <parameter>
        <name>from</name>
        <value>0</value>
    </parameter>
    <parameter>
        <name>limit</name>
        <value>" + max + @"</value>
    </parameter>
    <parameter>
        <name>filterby</name>
        <value>" + viewName + @"</value>
    </parameter>
</Details>");

            XmlDocument doc = getDocument(technicianKey, request);

            if (doc == null)
                return null;

            XmlNodeList tickets = doc.ChildNodes[1].ChildNodes[0].ChildNodes[0].ChildNodes[1].ChildNodes;

            List<Request> list = new List<Request>();

            for (int i = 0; i < tickets.Count; i++)
            {
                if (tickets[i].ChildNodes.Count != 0)
                {
                    XmlNodeList parameters = tickets[i].ChildNodes;
                    Request r = new Request();
                    
                    for (int p = 0; p < parameters.Count; p++)
                    {
                        string name = parameters[p].ChildNodes[0].InnerText;
                        string value = parameters[p].ChildNodes[1].InnerText;

                        if (name == "workorderid")
                            r.workorderid = int.Parse(value);
                        else if (name == "requestType")
                            r.requestType = value;
                        else if (name == "impact")
                            r.impact = value;
                        else if (name == "status")
                            r.status = value;
                        else if (name == "impactdetails")
                            r.impactdetails = value;
                        else if (name == "mode")
                            r.mode = value;
                        else if (name == "urgency")
                            r.urgency = value;
                        else if (name == "level")
                            r.level = value;
                        else if (name == "priority")
                            r.priority = value;
                        else if (name == "requester")
                            r.requester = value;
                        else if (name == "category")
                            r.category = value;
                        else if (name == "group")
                            r.group = value;
                        else if (name == "subcategory")
                            r.subcategory = value;
                        else if (name == "technician")
                            r.technician = value;
                        else if (name == "item")
                            r.item = value;
                        else if (name == "service")
                            r.service = value;
                        else if (name == "emailcc")
                            r.emailcc = value;
                        else if (name == "subject")
                            r.subject = value;
                        else if (name == "description")
                            r.description = value;
                        else if (name == "createddate")
                            r.createddate = DateTime.Parse(value);
                        else if (name == "respondeddate")
                            r.respondeddate = DateTime.Parse(value);
                        else if (name == "duebydate")
                            r.duebydate = DateTime.Parse(value);
                        else if (name == "completeddate")
                            r.completeddate = DateTime.Parse(value);
                        else if (name == "resolveddate")
                            r.resolveddate = DateTime.Parse(value);
                        else if (name == "frduebydate")
                            r.frduebydate = DateTime.Parse(value);
                        else if (name == "objectattachment")
                            r.attachment = value;
                        else if (name == "reason")
                            r.reason = value;
                    }

                    list.Add(r);
                }
            }

            return list;
        }

        public static void reply(string technicianName, int ticketID, string description)
        {
            string technicianKey = SQL.RunString("select techniciankey from AccessITExpressTechnicians where displayname = @NAME", technicianName);

            Request r = getRequest(technicianName, ticketID);
            string to = Core.getADValueFromDisplayName(r.requester, "mail");
            string cc = r.emailcc;
            string subject = "RE: " + r.subject;

            RestRequest request = new RestRequest();
            request.Resource = "/sdpapi/request/{request_id}";
            request.AddParameter("request_id", ticketID, ParameterType.UrlSegment);
            request.AddParameter("OPERATION_NAME", "REPLY_REQUEST");
            request.AddParameter("INPUT_DATA", @"<Details>
<parameter>
    <name>to</name>
    <value>" + to + @"</value>
</parameter>
<parameter>
    <name>cc</name>
    <value>" + cc + @"</value>
</parameter>
<parameter>
    <name>subject</name>
    <value>" + subject + @"</value>
</parameter>
<parameter>
    <name>description</name>
    <value>" + description + @"</value>
</parameter>
</Details>");
            XmlDocument doc = getDocument(technicianKey, request);
            
            return;
        }

        public static void addNote(string technicianName, int ticketID, string description)
        {
            string technicianKey = SQL.RunString("select techniciankey from AccessITExpressTechnicians where displayname = @NAME", technicianName);

            RestRequest request = new RestRequest();
            request.Resource = "/sdpapi/request/{request_id}/notes";
            request.AddParameter("request_id", ticketID, ParameterType.UrlSegment);
            request.AddParameter("OPERATION_NAME", "ADD_NOTE");
            request.AddParameter("INPUT_DATA", @"<Operation>
<Details>
    <Notes>
        <Note>
            <parameter>
                <name>isPublic</name>
                <value>false</value>
            </parameter>
            <parameter>
                <name>notesText</name>
                <value>" + description + @"</value>
            </parameter>
        </Note>
    </Notes>
</Details>
</Operation>");
            XmlDocument doc = getDocument(technicianKey, request);

            return;
        }

        public static List<Message> getMessages(string technicianName, int ticketID)
        {
            string technicianKey = SQL.RunString("select techniciankey from AccessITExpressTechnicians where displayname = @NAME", technicianName);

            RestRequest request = new RestRequest();
            request.Resource = "/sdpapi/request/{request_id}/allconversation";
            request.AddParameter("request_id", ticketID, ParameterType.UrlSegment);
            request.AddParameter("OPERATION_NAME", "GET_ALL_CONVERSATIONS");

            XmlDocument doc = getDocument(technicianKey, request);

            if (doc == null)
                return null;

            XmlNodeList messages = doc.ChildNodes[1].ChildNodes[0].ChildNodes[0].ChildNodes[1].ChildNodes;

            List<Message> list = new List<Message>();

            for (int i = 0; i < messages.Count; i++)
            {
                if (messages[i].ChildNodes.Count != 0)
                {
                    XmlNodeList parameters = messages[i].ChildNodes;
                    Message m = new Message();

                    for (int p = 0; p < parameters.Count; p++)
                    {
                        string name = parameters[p].ChildNodes[0].InnerText;
                        string value = parameters[p].ChildNodes[1].InnerText;

                        if (name == "notifyid")
                            m.notifyid = int.Parse(value);
                        else if (name == "createddate")
                            m.createdDate = Core.FromUnixTime(long.Parse(value));
                        else if (name == "from")
                            m.from = value;
                        else if (name == "type")
                            m.type = value;
                        else if (name == "subtype")
                            m.subtype = value;
                        else if (name == "description")
                            m.description = value;
                    }

                    list.Add(m);
                }
            }

            return list;
        }

        public static List<Note> getNotes(string technicianName, int ticketID)
        {
            string technicianKey = SQL.RunString("select techniciankey from AccessITExpressTechnicians where displayname = @NAME", technicianName);

            RestRequest request = new RestRequest();
            request.Resource = "/sdpapi/request/{request_id}/notes";
            request.AddParameter("request_id", ticketID, ParameterType.UrlSegment);
            request.AddParameter("OPERATION_NAME", "GET_NOTES");

            XmlDocument doc = getDocument(technicianKey, request);

            if (doc == null || doc.ChildNodes[1].ChildNodes[0].ChildNodes[0].ChildNodes[0].InnerText.Contains("200SuccessNo Notes present for request"))
                return null;

            XmlNodeList notes = doc.ChildNodes[1].ChildNodes[0].ChildNodes[0].ChildNodes[1].ChildNodes[0].ChildNodes;

            List<Note> list = new List<Note>();

            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i].ChildNodes.Count != 0)
                {
                    XmlNodeList parameters = notes[i].ChildNodes;
                    Note n = new Note();

                    for (int p = 0; p < parameters.Count; p++)
                    {
                        string name = parameters[p].ChildNodes[0].InnerText;
                        string value = parameters[p].ChildNodes[1].InnerText;

                        if (name == "notesid")
                            n.notesid = int.Parse(value);
                        else if (name == "notesDate")
                            n.notesDate = Core.FromUnixTime(long.Parse(value));
                        else if (name == "userName")
                            n.username = value;
                        else if (name == "isPublic")
                            n.isPublic = bool.Parse(value);
                        else if (name == "notesuserid")
                            n.notesUserID = int.Parse(value);
                        else if (name == "notesText")
                            n.notesText = value;
                    }

                    list.Add(n);
                }
            }

            return list;
        }

        public static int getLatestRequest(string technicianName)
        {
            string technicianKey = SQL.RunString("select techniciankey from AccessITExpressTechnicians where displayname = @NAME", technicianName);

            RestRequest request = new RestRequest();
            request.Resource = "/sdpapi/request";
            request.AddParameter("OPERATION_NAME", "GET_REQUESTS");
            request.AddParameter("INPUT_DATA", @"
<operation>
    <details>
        <from>0</from>
        <limit>1</limit>
        <filterby>All_Requests</filterby>
    </details>  
</operation>");

            XmlDocument doc = getDocument(technicianKey, request);

            if (doc == null)
                return -1;

            XmlNodeList parameters = doc.ChildNodes[1].ChildNodes[0].ChildNodes[0].ChildNodes[1].ChildNodes[0].ChildNodes;

            Request r = new Request();

            for (int i = 0; i < parameters.Count; i++)
            {
                if (parameters[i].ChildNodes.Count != 0)
                {
                    string name = parameters[i].ChildNodes[0].InnerText;
                    string value = parameters[i].ChildNodes[1].InnerText;

                    if (name == "workorderid")
                        return int.Parse(value);
                }
            }

            return -2;
        }

        public static bool updateCategory(string technicianName, int id, string category)
        {
            string technicianKey = SQL.RunString("select techniciankey from AccessITExpressTechnicians where displayname = @NAME", technicianName);

            RestRequest request = new RestRequest();
            request.Resource = "/sdpapi/request/{request_id}";
            request.AddParameter("request_id", id, ParameterType.UrlSegment);
            request.AddParameter("OPERATION_NAME", "EDIT_REQUEST");
            request.AddParameter("INPUT_DATA", @"<Operation>
<Details>
<parameter>
    <name>Category</name>
    <value>" + category + @"</value>
</parameter>
</Details>
</Operation>");

            XmlDocument doc = getDocument(technicianKey, request);

            if (doc == null)
                return false;

            log(id + " - Set category to " + category);

            return true;
        }

        public static bool updateSubcategory(string technicianName, int id, string subcategory)
        {
            string technicianKey = SQL.RunString("select techniciankey from AccessITExpressTechnicians where displayname = @NAME", technicianName);

            RestRequest request = new RestRequest();
            request.Resource = "/sdpapi/request/{request_id}";
            request.AddParameter("request_id", id, ParameterType.UrlSegment);
            request.AddParameter("OPERATION_NAME", "EDIT_REQUEST");
            request.AddParameter("INPUT_DATA", @"<Operation>
<Details>
<parameter>
    <name>Subcategory</name>
    <value>" + subcategory + @"</value>
</parameter>
</Details>
</Operation>");

            XmlDocument doc = getDocument(technicianKey, request);

            if (doc == null)
                return false;

            log(id + " - Set subcategory to " + subcategory);

            return true;
        }

        public static bool updateGroup(string technicianName, int id, string group)
        {
            string technicianKey = SQL.RunString("select techniciankey from AccessITExpressTechnicians where displayname = @NAME", technicianName);

            RestRequest request = new RestRequest();
            request.Resource = "/sdpapi/request/{request_id}";
            request.AddParameter("request_id", id, ParameterType.UrlSegment);
            request.AddParameter("OPERATION_NAME", "EDIT_REQUEST");
            request.AddParameter("INPUT_DATA", @"
<Operation>
    <Details>
        <parameter>
            <name>Group</name>
            <value>" + group + @"</value>
        </parameter>
    </Details>
</Operation>");

            XmlDocument doc = getDocument(technicianKey, request);

            if (doc == null)
                return false;

            log(id + " - Set group to " + group);

            return true;
        }

        private static void log(string s)
        {
            Console.Write(s + Environment.NewLine);
            Core.log("AccessITAPI", "Log", s);
        }

        //http://accessit:8080/SetUpWizard.do?forwardTo=apidoc
        //Request --> View Request field details
        //Use a ticket not assigned to a group
        //View results to find new IDs
        public enum TechnicianID
            {
            AlarconErika = 52204,
            AnsellScott = 2847,
            CaldwellKevin = 66901,
            ChaseSusan = 6908,
            FerusTania = 2848,
            HillSteve = 47842,
            GaskellIan = 60001,
            JakopJulie = 54605,
            KellyJordan = 47914,
            KoopmanNicholas = 76501,
            MackenRobin = 52206,
            MathewsScott = 95108,
            MorganSteven = 51301,
            OberfrankJoshua = 92102,
            PatelJulien = 48310,
            SmythGraeme = 32103,
            SquiresMike = 2840,
            UrbanikWillie = 2845,
            VollickAnnaliese = 2846,
            WigmoreMaryAnne = 2838,
            WillattsRobert = 48609,
            WingAl = 2834,
            WrayWill = 60002
        }
    }

    public class Request
    {
        public int workorderid { get; set; }
        public string requestType { get; set; }
        public string impact { get; set; }
        public string status { get; set; }
        public string impactdetails { get; set; }
        public string mode { get; set; }
        public string urgency { get; set; }
        public string level { get; set; }
        public string priority { get; set; }
        public string requester { get; set; }
        public string category { get; set; }
        public string group { get; set; }
        public string subcategory { get; set; }
        public string technician { get; set; }
        public string item { get; set; }
        public string service { get; set; }
        public string emailcc { get; set; }
        public string subject { get; set; }
        public string description { get; set; }
        public DateTime createddate { get; set; }
        public DateTime respondeddate { get; set; }
        public DateTime duebydate { get; set; }
        public DateTime completeddate { get; set; }
        public DateTime resolveddate { get; set; }
        public DateTime frduebydate { get; set; }
        public object attachment { get; set; }
        public string reason { get; set; }
    }

    public class Message
    {
        public int notifyid { get; set; }
        public DateTime createdDate { get; set; }
        public string from { get; set; }
        public string type { get; set; }
        public string subtype { get; set; }
        public string description { get; set; }
    }

    public class Note
    {
        public int notesid { get; set; }
        public DateTime notesDate { get; set; }
        public string username { get; set; }
        public int notesUserID { get; set; }
        public bool isPublic { get; set; }
        public string notesText { get; set; }
    }
}
