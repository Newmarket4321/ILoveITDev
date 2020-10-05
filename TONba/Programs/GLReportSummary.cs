using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_IT
{
    class GLReportSummary
    {
        public GLReportSummary()
        {
            bool success;
            DateTime start = Core.getDate("Select start date", out success);

            if (!success)
                return;

            DateTime end = Core.getDate("Select end date", out success);

            if (!success)
                return;

            Class sql = new Class(@"
SELECT
    GL_ACCOUNT.gl_account_category_id as 'Category',
    ltrim(rtrim(GL_ACCOUNT.gl_account_number)) + case when f.extension is not null then f.extension else '' end as 'Number',
	GL_ACCOUNT.gl_account_name as 'Account',
    cast(Sum(ACCOUNTING_ALLOCATION.debit) as varchar) AS Debit,
    cast(Sum(ACCOUNTING_ALLOCATION.credit) as varchar) AS Credit,
    cast(Sum(ACCOUNTING_ALLOCATION.debit) - Sum(ACCOUNTING_ALLOCATION.credit) as varchar) AS Net

FROM ACCOUNTING_ALLOCATION
INNER JOIN GL_ACCOUNT ON ACCOUNTING_ALLOCATION.gl_account_id = GL_ACCOUNT.gl_account_id
INNER JOIN ACCOUNTING_TRANSACTION ON ACCOUNTING_ALLOCATION.transaction_id = ACCOUNTING_TRANSACTION.transaction_id
left join FUNCTION_GL_EXTENSION f on ACCOUNTING_ALLOCATION.function_gl_extension_id = f.function_gl_extension_id

WHERE
    ACCOUNTING_ALLOCATION.datestamp >= @START
    AND ACCOUNTING_ALLOCATION.datestamp < @END

GROUP BY
    ltrim(rtrim(GL_ACCOUNT.gl_account_number)) + case when f.extension is not null then f.extension else '' end,
    GL_ACCOUNT.gl_account_name,
    GL_ACCOUNT.gl_account_category_id

HAVING Sum(ACCOUNTING_ALLOCATION.debit) - Sum(ACCOUNTING_ALLOCATION.credit) <> 0
");
            sql.AddParameter("@START", start);
            sql.AddParameter("@END", end.AddDays(1));
            DataTable dt = sql.Run();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["Debit"] = string.Format("{0:C}", decimal.Parse(dt.Rows[i]["Debit"].ToString()));
                dt.Rows[i]["Credit"] = string.Format("{0:C}", decimal.Parse(dt.Rows[i]["Credit"].ToString()));
                dt.Rows[i]["Net"] = string.Format("{0:C}", decimal.Parse(dt.Rows[i]["Net"].ToString()));
                
                int obj = int.Parse(dt.Rows[i]["Number"].ToString().Split('.')[1]);

                if (obj < 8224 || obj > 8263)
                    dt.Rows.RemoveAt(i--);
            }

            Spreadsheet ss = new Spreadsheet();

            for (int c = 0; c < dt.Columns.Count; c++)
            {
                ss.Cells()[3, c + 3] = dt.Columns[c].ColumnName;
                ss.Bold((char)('A' + c + 2) + "3");
            }

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    if (c == 0)
                        ss.Cells()[r + 4, c + 3] = getCategory(dt.Rows[r][c].ToString().Trim());
                    else
                        ss.Cells()[r + 4, c + 3] = dt.Rows[r][c].ToString().Trim();
                }
            }

            ss.Cells()[3, 10] = start.ToString("dddd MMMM dd, yyyy") + " - " + end.ToString("dddd MMMM dd, yyyy");
            ss.Cells()[4, 10] = "8224 - 8263";

            ss.AutoFit("A1", "Z100");

            ss.Show();
        }

        private string getCategory(string x)
        {
            if (x == "100") return "Course Registration Revenue";
            else if (x == "150") return "Deferred Revenue";
            else if (x == "200") return "Facility Rental Revenue";
            else if (x == "250") return "Unearned Revenue";
            else if (x == "300") return "Extra Fee Revenue";
            else if (x == "370") return "Marketing Expense";
            else if (x == "400") return "Point of Sale Revenue";
            else if (x == "450") return "Non-add Point of Sale Revenue";
            else if (x == "500") return "Membership Pass Revenue";
            else if (x == "600") return "Rental Deposit";
            else if (x == "700") return "Tax";
            else if (x == "800") return "Payments";
            else if (x == "900") return "Accounts Receivable";
            else if (x == "960") return "Opening Balance";
            else return x;
        }
    }
}
