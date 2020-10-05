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
    class NewUserReport : Form
    {
        public NewUserReport()
        {
            DataTable dt = SQL.Run(@"
select
ID,
employeename as 'New Employee',
department as 'Department',
approveddate as 'Approved',
approvedby as 'Approved By'

from NewUserForm
order by ID desc");

            bool success;
            DataRow r = Core.getSelect("New User Forms", dt, out success);

            if (!success)
            {
                Close();
                return;
            }

            if (!Directory.Exists(Core.tempDirectory))
                Directory.CreateDirectory(Core.tempDirectory);

            int ID = int.Parse(r["ID"].ToString());
            string output = getHTML(ID);

            string path = Core.tempDirectory + "NewUserReport " + ID + ".html";

            File.WriteAllText(path, output);
            Core.run(path);

            Core.log("NewUserReport", "Export to file", "NewUserReport " + ID.ToString());

            Close();
        }

        public static string getHTML(int ID)
        {
            DataTable dt = SQL.Run("select * from NewUserForm where ID = @ID", ID);
            DataTable hw = SQL.Run("select * from NewUserFormItems where category = 'Hardware' and EmpFormID = @ID order by ID", ID);
            DataTable sw = SQL.Run("select * from NewUserFormItems where category = 'Software' and EmpFormID = @ID order by ID", ID);
            DataTable aa = SQL.Run("select * from NewUserFormItems where category = 'Additional Access' and EmpFormID = @ID order by ID", ID);

            string start = "";
            string finish = "";
            string approvedDate = "";
            bool approved = false;

            try
            {
                DateTime temp = DateTime.Parse(dt.Rows[0]["StartingDate"].ToString());
                start = temp.ToString("MMMM dd, yyyy");
            }
            catch
            {

            }

            try
            {
                DateTime temp = DateTime.Parse(dt.Rows[0]["FinishingDate"].ToString());
                finish = temp.ToString("MMMM dd, yyyy");
            }
            catch
            {

            }

            try
            {
                DateTime temp = DateTime.Parse(dt.Rows[0]["ApprovedDate"].ToString());
                approvedDate = temp.ToString("MMMM dd, yyyy, h:mmtt");
            }
            catch
            {

            }

            try
            {
                approved = bool.Parse(dt.Rows[0]["Approved"].ToString());
            }
            catch
            {

            }

            string s = @"<meta http-equiv=""Content-Type"" content=""text/html; charset=us-ascii"">
<div style=""background-color: #F2F2F2; font: 15px Helvetica;"">
<div style=""padding: 20px 20px 0px 20px; background-color: #FFFFFF; width: 450px; margin-right: auto; margin-left: auto; margin-top: 5px; text-align: center;"">
<div style=""font:30px Helvetica;""><b>New User Form</b></div>
<br/>
<br/>
<table width=""100%"" cellspacing=""2"" cellpadding=""2"" border=""0"">
	<tr>
		<td colspan=""2"" bgcolor=""#cfdfff"" style=""font:18px Helvetica;"">
			<b>Employee</b>
		</td>
	</tr>
	<tr>
		<td style=""font:15px Helvetica; vertical-align:top;"" width=""225px""><b>New Employee Name</b></td>
		<td style=""font:15px Helvetica; vertical-align:top;"">" + dt.Rows[0]["EmployeeName"].ToString() + @"</td>
	</tr>
	<tr>
		<td style=""font:15px Helvetica; vertical-align:top;""><b>Department</b></td>
		<td style=""font:15px Helvetica; vertical-align:top;"">" + dt.Rows[0]["Department"].ToString() + @"</td>
	</tr>
	<tr>
		<td style=""font:15px Helvetica; vertical-align:top;""><b>Position/Title</b></td>
		<td style=""font:15px Helvetica; vertical-align:top;"">" + dt.Rows[0]["Position"].ToString() + @"</td>
	</tr>
	<tr>
		<td style=""font:15px Helvetica; vertical-align:top;""><b>Employee being replaced</b></td>
		<td style=""font:15px Helvetica; vertical-align:top;"">" + dt.Rows[0]["EmployeeReplaced"].ToString() + @"</td>
	</tr>
	<tr>
		<td style=""font:15px Helvetica; vertical-align:top;""><b>Status</b></td>
		<td style=""font:15px Helvetica; vertical-align:top;"">" + dt.Rows[0]["Status"].ToString() + @"</td>
	</tr>
	<tr><td>&nbsp;</td></tr>
	<tr>
		<td style=""font:15px Helvetica; vertical-align:top;""><b>Starting Date</b></td>
		<td style=""font:15px Helvetica; vertical-align:top;"">" + start + @"</td>
	</tr>
	<tr>
		<td style=""font:15px Helvetica; vertical-align:top;""><b>Finish Date</b></td>
		<td style=""font:15px Helvetica; vertical-align:top;"">" + finish + @"</td>
	</tr>
	<tr><td>&nbsp;</td></tr>
	</table>
	";

            if (hw.Rows.Count + sw.Rows.Count > 0)
            {
                s += @"
    <table width=""100%"" cellspacing=""2"" cellpadding=""2"" border=""0"">";

                if (hw.Rows.Count > 0)
                {
                    s += @"
    <tr>
		<td colspan=""2"" bgcolor=""#cfdfff"" style=""font:18px Helvetica;"">
			<b>Hardware</b>
		</td>
	</tr>
    ";
                    for (int i = 0; i < hw.Rows.Count; i++)
                        s += @"
	<tr>
		<td style=""font:15px Helvetica; vertical-align:top;"" width=""500px""><b>" + hw.Rows[i]["ItemDesc"].ToString() + @"</b></td>
		<td style=""font:15px Helvetica; text-align:right; vertical-align:top;"">" + hw.Rows[i]["AccountNumber"].ToString() + @"</td>
	</tr>
";
                    if(sw.Rows.Count + aa.Rows.Count > 0)
                        s += @"
    <tr><td>&nbsp;</td></tr>
";
                }

                if(sw.Rows.Count > 0)
                {
                    s += @"
    <tr>
		<td colspan=""2"" bgcolor=""#cfdfff"" style=""font:18px Helvetica;"">
			<b>Software</b>
		</td>
	</tr>
    ";
                    for (int i = 0; i < sw.Rows.Count; i++)
                        s += @"
	<tr>
		<td style=""font:15px Helvetica; vertical-align:top;"" width=""500px""><b>" + sw.Rows[i]["ItemDesc"].ToString() + @"</b></td>
		<td style=""font:15px Helvetica; text-align:right; vertical-align:top;"">" + sw.Rows[i]["AccountNumber"].ToString() + @"</td>
	</tr>
";
                    if (aa.Rows.Count > 0)
                        s += @"
    <tr><td>&nbsp;</td></tr>
";
                }

                s += @"
    </table>
";
            }

            if(aa.Rows.Count > 0)
            {
                s += @"
	<table width=""100%"" cellspacing=""2"" cellpadding=""2"" border=""0"">
	<tr>
		<td colspan=""2"" bgcolor=""#cfdfff"" style=""font:18px Helvetica;"">
			<b>Additional Access</b>
		</td>
	</tr>";

                for (int i = 0; i < aa.Rows.Count; i++)
                {
                    s += @"
	<tr>
		<td style=""font:15px Helvetica; vertical-align:top;"" width=""225px""><b>Will need access to</b></td>
		<td style=""font:15px Helvetica; vertical-align:top;"">Erika Alarcon
		<br/>- Mail
		<br/>- Calendar</td>
	</tr>
	<tr>
		<td style=""font:15px Helvetica; vertical-align:top;""><b>New mailbox administered by</b></td>
		<td style=""font:15px Helvetica; vertical-align:top;"">Mike Squires</td>
	</tr>
</table>";
                }
            }

            if(approved)
            {
                s += @"
<hr>
Approved by " + dt.Rows[0]["ApprovedBy"].ToString() + @"
<br/>" + approvedDate + @"
";
            }

            s += @"
</div>
</div>
";
    
            return s;
        }
    }
}
