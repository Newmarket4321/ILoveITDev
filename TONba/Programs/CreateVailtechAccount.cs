using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    class CreateVailtechAccount
    {
        public CreateVailtechAccount()
        {
            bool success;
            string firstName = Core.getString("What is the employee's first name?", out success);

            if (!success || firstName == "")
                return;

            string lastName = Core.getString("What is the employee's last name?", out success);

            if (!success || lastName == "")
                return;

            string username = (firstName[0] + lastName).ToUpper();

            if (username.Length > 8)
                username = username.Substring(0, 8);

            string password = (firstName[0] + "1" + lastName[0] + "234").ToLower();
            string targetEmail = (firstName[0] + lastName + "@newmarket.ca").ToLower();

            DataTable temp = Vailtech.Run(@"
select user_id from vailtech.tx_security
union
select user_id from vailtech.tx_security_roll
union
select user_id from vailtech.tx_security_roll_inq
");

            DataRow row = Core.getSelect("Select a user to copy permissions from", temp, out success);

            if (!success || row == null)
                return;

            try
            {
                Vailtech.Run(@"
CREATE USER " + username + @"
IDENTIFIED BY " + password + @"
DEFAULT TABLESPACE DATA
TEMPORARY TABLESPACE TEMP
PROFILE DEFAULT
");

                Core.log("CreateVailtechAccount", "Account created", username);

                string copyLike = row["USER_ID"].ToString();

                Vailtech.Run("insert into vailtech.tx_security select '" + username + "', group_id, program_name, access_query, access_add, access_delete, access_update, access_print from vailtech.tx_security where user_id = @COPYLIKE", copyLike);
                Vailtech.Run("insert into vailtech.tx_security_roll select '" + username + "', owner_info, mailing_address, legal_description, mortgage_co, group_code, details, local_improve, billing_address, assessment, postdated, remarks, pap, warrants, collections, phasein_capping, allow_access_rem, allow_create_roll from vailtech.tx_security_roll where user_id = @COPYLIKE", copyLike);
                Vailtech.Run("insert into vailtech.tx_security_roll_inq select '" + username + "', appeals, archive_trans, assessments_button, audits, bill_detail, collections, detail, correspondence, installments, local_charge, pap, phasein_etc, phone_etc, post_dated, receivables, remarks, schedules, tax_sale, transactions, vacancy, owners, legal, mailing, mortgage_group, tax_block_1, tax_block_2, tax_block_3, tax_block_4, tax_block_5, tax_block_6, assessments, other_1, other_2, other_3, other_4, other_5, custom_1, custom_2, custom_3, custom_4, custom_5, projected_balance from vailtech.tx_security_roll_inq where user_id = @COPYLIKE", copyLike);

                if(MessageBox.Show("Account created successfully." + Environment.NewLine
                    + Environment.NewLine
                    + "Username: " + username + Environment.NewLine
                    + "Password: " + password + Environment.NewLine
                    + "Database: vtx.newmarket" + Environment.NewLine
                    + Environment.NewLine
                    + "E-mail a copy to " + targetEmail + "?", "Account created", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Core.sendMail(targetEmail, "Vailtech Credentials",
                        "<b>Username:<\b> " + username + "<br/>"
                        + "<b>Password:</b> " + password + "<br/>"
                        + "<b>Database:</b> vtx.newmarket");

                    Core.log("CreateVailtechAccount", "Credentials sent", targetEmail);
                }
            }
            catch(Exception e)
            {
                if (e.Message.Contains("conflicts with another user or role name"))
                {
                    MessageBox.Show("An account named " + username + " already exists.");
                }
                else throw e;
            }
        }
    }
}
