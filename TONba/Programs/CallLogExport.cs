using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    class CallLogExport
    {
        public CallLogExport()
        {
            bool success;
            int callID = Core.getInt("Enter call ID", out success);

            if (!success)
                return;

            DataTable dt = CRM.Run(@"
select *
from FRS_HC_CallLog
where callid = @CALLID", callID);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Call " + callID + " not found.");
                return;
            }

            DataTable notes = CRM.Run(@"
select *
from Journal
where journaltype = 'Notes'
and parentlink_recid = @RECID
order by createddatetime desc", dt.Rows[0]["RecID"].ToString());

            DataTable assignments = CRM.Run(@"
select *
from Task
where tasktype = 'Assignment'
and ParentLink_RecID = @RECID
order by createddatetime desc", dt.Rows[0]["RecID"].ToString());

            DataTable attachments = CRM.Run(@"
select *
from Attachment
where ParentLink_RecID = @RECID
order by createddatetime desc", dt.Rows[0]["RecID"].ToString());

            if (!Directory.Exists(Core.tempDirectory))
                Directory.CreateDirectory(Core.tempDirectory);

            string path = Core.tempDirectory + callID + ".html";

            string output = @"
<meta http-equiv=""Content-Type"" content=""text/html; charset=us-ascii"">
<table width=""800"" cellspacing=""2"" cellpadding=""2"" border=""0"">
    <tbody>
        <tr>
            <td colspan=""2"" bgcolor=""#cfdfff"">
                <b>Call Log</b>
            </td>
        </tr>
        <tr>
            <td>
                Call ID:
            </td>
            <td>
                " + dt.Rows[0]["CallID"].ToString() + @"
            </td>
        </tr>
        <tr>
            <td>
                <br>
            </td>
            <td>
                <br>
            </td>
        </tr>
        <tr>
            <td>
                <b>Caller:</b>
            </td>
            <td>
                <b>" + dt.Rows[0]["FirstName"].ToString() + " " + dt.Rows[0]["LastName"].ToString() + @"</b>
            </td>
        </tr>
        <tr>
            <td>
                Phone #:
            </td>
            <td>
                " + dt.Rows[0]["Phone"].ToString() + @"
            </td>
        </tr>
        <tr>
            <td>
                <br>
            </td>
            <td>
                <br>
            </td>
        </tr>
        <tr>
            <td>
                <b>Service Location:</b>
            </td>
            <td>
                <b>" + dt.Rows[0]["ServiceLocation"].ToString() + @"</b>
            </td>
        </tr>
        <tr>
            <td>
                <br>
            </td>
            <td>
                <br>
            </td>
        </tr>
        <tr>
            <td>
                Call Type:
            </td>
            <td>
                " + dt.Rows[0]["CallType"].ToString() + @"
            </td>
        </tr>
        <tr>
            <td>
                Sub Call Type:
            </td>
            <td>
                " + dt.Rows[0]["SubCategory"].ToString() + @"
            </td>
        </tr>
        <tr>
            <td>
                Item:
            </td>
            <td>
                " + dt.Rows[0]["Item"].ToString() + @"
            </td>
        </tr>
        <tr>
            <td>
                Call Description:
            </td>
            <td>
                " + dt.Rows[0]["CallDesc"].ToString() + @"
            </td>
        </tr>
        <tr>
            <td>
                Received:
            </td>
            <td>
                " + DateTime.Parse(dt.Rows[0]["CreatedDateTime"].ToString()).ToLocalTime().ToString() + @"
            </td>
        </tr>
        <tr>
            <td>
                Solution:
            </td>
            <td>
                " + dt.Rows[0]["CloseDesc"].ToString() + @"
            </td>
        </tr>
        <tr>
            <td>
                <br>
            </td>
            <td>
                <br>
            </td>
        </tr>
        
        <tr>
            <td colspan=""2"" bgcolor=""#cfdfff"">
                <b>Journal Notes</b>
            </td>
        </tr>
        <tr>
            <td colspan=""2"">";

            for (int i = 0; i < notes.Rows.Count; i++)
                output += (i != 0 ? "<br>" : "") + DateTime.Parse(notes.Rows[0]["CreatedDateTime"].ToString()).ToLocalTime().ToString() + " | " + notes.Rows[i]["CreatedBy"].ToString() + " | " + notes.Rows[i]["Subject"].ToString() + " | " + notes.Rows[i]["NotesBody"].ToString();
            
            output += @"
            </td>
        </tr>
        <tr>
            <td colspan=""2"" bgcolor=""#cfdfff"">
                <b>Attachments</b>
            </td>
        </tr>
        <tr>
            <td colspan=""2"">";

            for (int i = 0; i < attachments.Rows.Count; i++)
                output += (i != 0 ? "<br>" : "") + DateTime.Parse(attachments.Rows[0]["CreatedDateTime"].ToString()).ToLocalTime().ToString() + " | " + attachments.Rows[i]["AttachName"].ToString();

            output += @"
            </td>
        </tr>
</tbody>
</table>
<br>
<font color=""#222222"">
    Thank you,<br>
    <br>
    Access Newmarket
</font>
";

            File.WriteAllText(path, output);
            Core.run(path);

            Core.log("CallLogExport", "Export to file", "Call ID " + callID.ToString());
        }
    }
}
