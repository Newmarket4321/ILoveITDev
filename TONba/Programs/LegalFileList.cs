using System;
using System.Data;

namespace I_IT
{
    class LegalFileList
    {
        public LegalFileList()
        {
            SQL sql = new SQL(@"
select
ID as 'File Num',
FILE_NAME as 'File Name',
LOCATION as 'Location',
COMMENTS as 'Comments',
BOX_FILE as 'Box File Num',
CORPORATE_FILE_NO as 'Corp File Num',
CREATED_BY as 'Created By',
ASSIGNED_LAWYER as 'Assigned Lawyer',
DATE_OPENED as 'Date Opened',
DATE_BRING_FORWARD as 'Date Bring Forward',
DATE_IN as 'Date In',
DATE_OUT as 'Date Out',
DATE_MOVED as 'Date Moved',
DATE_CLOSED as 'Date Closed', 
DATE_TOBE_DESTRYD as 'Date to be Destroyed',
DATE_DESTROYED as 'Date Destroyed',
FILE_STATUS as 'File Status'

from LegalFileList
order by ID desc");
            Report r = new Report("Legal File List", sql, true, true, true);

            r.Add_Click += (s, e2) =>
            {
                SQL.Run(@"

");

                int id = int.Parse(r.selectedRow["File Num"].ToString());

                LegalFileListItem item = new LegalFileListItem();
                item.ShowDialog();
            };

            r.Edit_Click += (s, e2) =>
            {
                int id = int.Parse(r.selectedRow["File Num"].ToString());
                LegalFileListItem item = new LegalFileListItem(id);
                item.ShowDialog();
            };

            r.Delete_Click += (s, e2) =>
            {
                int id = int.Parse(r.selectedRow["File Num"].ToString());
                SQL.Run("delete from LegalFileList where ID = @ID", id);
            };

            r.ShowDialog();
        }
    }
}
