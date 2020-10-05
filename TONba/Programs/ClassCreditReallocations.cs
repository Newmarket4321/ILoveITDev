using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_IT
{
    class ClassCreditReallocations
    {
        public ClassCreditReallocations()
        {
            int k = 0;

            string notes = "";
            int count = 0;
            decimal totalReallocations = 0;

            Console.WriteLine("Searching for accounts");

            DataTable dt = Class.Run(@"
select a.account_id, a.title, a.third_party_billing,

(select sum(at.amount) from accounting_event ae join ACCOUNTING_TRANSACTION at on at.accounting_event_id = ae.accounting_event_id where ae.account_id = a.account_id and at.effective_date < dateadd(year, -5, getdate())) as 'Balance 5 Years Ago',
(select sum(at.amount) from accounting_event ae join ACCOUNTING_TRANSACTION at on at.accounting_event_id = ae.accounting_event_id where ae.account_id = a.account_id) as 'Balance Now'

from account a
group by a.account_id, a.title, a.third_party_billing
having

(select sum(at.amount) from accounting_event ae join ACCOUNTING_TRANSACTION at on at.accounting_event_id = ae.accounting_event_id where ae.account_id = a.account_id and at.effective_date < dateadd(year, -5, getdate())) < 0
and (select sum(at.amount) from accounting_event ae join ACCOUNTING_TRANSACTION at on at.accounting_event_id = ae.accounting_event_id where ae.account_id = a.account_id and at.effective_date < dateadd(year, -5, getdate())) = (select sum(at.amount) from accounting_event ae join ACCOUNTING_TRANSACTION at on at.accounting_event_id = ae.accounting_event_id where ae.account_id = a.account_id)

order by a.account_id
");

            Console.WriteLine(dt.Rows.Count + " accounts found.");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int third_party_billing = int.Parse(dt.Rows[i]["third_party_billing"].ToString());
                int account_id = int.Parse(dt.Rows[i]["account_id"].ToString());
                string accountTitle = dt.Rows[i]["title"].ToString().Trim();
                decimal credit_amount = Math.Abs(decimal.Parse(dt.Rows[i]["Balance Now"].ToString()));
                string datestamp = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");
                string date = DateTime.Now.ToString("dd MMM yyyy");
                string description = "Moving Credits from Customer Account to the CARE fund due to be unused";

                Console.WriteLine("Processing account " + (i + 1) + " of " + dt.Rows.Count);
                Core.log("ClassCreditReallocations", "Processing", "Account ID " + account_id);

                if (third_party_billing == 0)
                {
                    Class.Run("update ID_COUNTER set counter = counter + 1, datestamp = '" + datestamp + "', userstamp = 0 where table_name = 'ACCOUNTING_EVENT'");
                    int accounting_event_counter = int.Parse(Class.RunString("select counter from ID_COUNTER where table_name = 'ACCOUNTING_EVENT'"));

                    Class.Run("update ID_COUNTER set counter = counter + 1, datestamp = '" + datestamp + "', userstamp = 0 where table_name = 'ACCOUNTING_TRANSACTION'");
                    int accounting_transaction_counter = int.Parse(Class.RunString("select counter from ID_COUNTER where table_name = 'ACCOUNTING_TRANSACTION'"));

                    //To  8709 = C.A.R.E. Contributions POS (323560.7579)
                    DataTable miscDepositsAccount = Class.Run("select gl_account_name, gl_account_number, gl_group_id, gl_account_category_id, function_extension_flag, restrict_gl_acc_flag, system_supplied_flag, css_overshort_acc_flag, complex_extension_flag, active, datestamp, userstamp from GL_ACCOUNT where gl_account_id = 8709");

                    //From 900 = Accounts Receivable Account (1000.1287)
                    DataTable accountsReceivableAccount = Class.Run("select gl_account_name, gl_account_number, gl_group_id, gl_account_category_id, function_extension_flag, restrict_gl_acc_flag, system_supplied_flag, css_overshort_acc_flag, complex_extension_flag, active, datestamp, userstamp from GL_ACCOUNT where gl_account_id = 900");

                    decimal current_balance = decimal.Parse(Class.RunString("select current_balance from ACCOUNT where account_id = " + account_id));
                    //string account_status_id = Class.RunString("select account_status_id from ACCOUNT where account_id = " + account_id);

                    Class.Run("update ACCOUNT set current_balance = current_balance + " + credit_amount + ", future_balance = future_balance + 0, unallocated_balance = unallocated_balance + 0, datestamp = '" + datestamp + "', userstamp = 0 where account_id = " + account_id + " and account_status_id not in ('X','M')");

                    Class.Run("insert into ACCOUNTING_EVENT (accounting_event_id, accounting_event_type_id, account_id, amount, [reference], annotation, trl_annotation, language_id, creation_datetime, creation_location, creation_user_id, terminal_id, entity_type_id, datestamp, userstamp) values (" + accounting_event_counter + ", 850, " + account_id + ", " + credit_amount + ", " + account_id + ", '" + description + "', NULL, 1, '" + datestamp + "', 52, 0, 52,'M', '" + datestamp + "', 0)");
                    Class.Run("insert into ACCOUNTING_TRANSACTION (transaction_id, accounting_event_id, transaction_type_id, effective_date, amount, [reference], annotation, trl_annotation, language_id, post_location, post_terminal, post_user, post_datetime, userstamp, datestamp) values (" + accounting_transaction_counter + ", " + accounting_event_counter + ", 850, '" + date + "', " + credit_amount + ", " + account_id + ", '" + description + "', NULL, NULL, 52, 52, 0,'" + datestamp + "', 0, '" + datestamp + "')");
                    Class.Run("insert into ACCOUNTING_ALLOCATION (transaction_id, seq_counter, transaction_code_id, gl_account_id, function_gl_extension_id, complex_gl_extension_id, debit, credit, [reference], reference2, reference3, gl_account_prompt, datestamp, userstamp, reference_time_block_fee) values (" + accounting_transaction_counter + ", 1, 380, 8709, NULL, NULL, 0, " + credit_amount + ", 0, 0, 0, NULL, '" + datestamp + "', 0, 0)");
                    Class.Run("insert into ACCOUNTING_ALLOCATION (transaction_id, seq_counter, transaction_code_id, gl_account_id, function_gl_extension_id, complex_gl_extension_id, debit, credit, [reference], reference2, reference3, gl_account_prompt, datestamp, userstamp, reference_time_block_fee) values (" + accounting_transaction_counter + ", 2, 900, 900, NULL, NULL, " + credit_amount + ", 0, " + account_id + ", 0, 0, NULL, '" + datestamp + "', 0, 0)");

                    totalReallocations += credit_amount;

                    DataTable entityBalance = Class.Run("select balance_amount, entity_type_id, [reference], account_id, ar_export_flag, datestamp, userstamp from ENTITY_BALANCE where entity_type_id = 'M' and [reference] = " + account_id);
                    Class.Run("insert into ENTITY_BALANCE (balance_amount, entity_type_id, [reference], account_id, ar_export_flag, datestamp, userstamp) values (" + credit_amount + ", 'M', " + account_id + ", " + account_id + ", 0, '" + datestamp + "', 0)");
                    Class.Run("update PAYMENT_SCHEDULE set amount = amount + " + credit_amount + ", datestamp = '" + datestamp + "', userstamp = 0 where entity_type_id= 'M' and [reference] = " + account_id + " and payment_date = '" + date + "'");

                    Class.Run("insert into PAYMENT_SCHEDULE (entity_type_id, [reference], payment_date, amount, account_id, annotation, ar_export_flag, datestamp, userstamp) values ('M', " + account_id + ", '" + date + "', " + credit_amount + ", " + account_id + ", 'Account Adjustment', 0, '" + datestamp + "', 0)");

                    Class.Run("update ID_COUNTER set counter = counter + 1, datestamp = '" + datestamp + "', userstamp = 0 where table_name = 'RECEIPT'");
                    int receipt_counter = int.Parse(Class.RunString("select counter from ID_COUNTER where table_name = 'RECEIPT'"));

                    //Checking if the number we're about to use is still available; expecting 0 rows returned
                    //Class.Run("select receipt_id from RECEIPT where receipt_id = " + receipt_counter);

                    Class.Run("insert into RECEIPT (receipt_id, opening_current_balance, account_id, creation_datetime, creation_user_id, datestamp, userstamp, account_title, accelerated_amount) values (" + receipt_counter + ", -" + credit_amount + ", " + account_id + ", '" + datestamp + "', 0, '" + datestamp + "', 0, @TITLE, 0)", accountTitle);

                    Class.Run("update ID_COUNTER set counter = counter + 1, datestamp = '" + datestamp + "', userstamp = 0 where table_name = 'PRINT_JOB'");
                    int print_job_counter = int.Parse(Class.RunString("select counter from ID_COUNTER where table_name = 'PRINT_JOB'"));

                    //Redundant
                    //Class.Run("select title from ACCOUNT where account_id = " + account_id);

                    Class.Run("insert into PRINT_JOB ( print_job_id, type, reference1, reference2, reference_text, account_id, printed_flag, creation_datestamp, creation_userstamp, creation_location, datestamp, userstamp, language_id, emailed_flag ) values (" + print_job_counter + ", 1, " + receipt_counter + ", 0, @TITLE, " + account_id + ", 0, '" + datestamp + "', 0, 52, '" + datestamp + "', 0, 1, 0)", accountTitle);
                    Class.Run("insert into RECEIPT_ACCOUNTING_EVENT (receipt_id, accounting_event_id, datestamp, userstamp) values (" + receipt_counter + ", " + accounting_event_counter + ", '" + datestamp + "', 0)");

                    current_balance = decimal.Parse(Class.RunString("select current_balance from ACCOUNT where account_id = " + account_id));
                    Class.Run("update RECEIPT set closing_current_balance = " + current_balance + " where receipt_id = " + receipt_counter);

                    //Handled above
                    //Class.Run("select third_party_billing from ACCOUNT where account_id = " + account_id);
                    //Class.Run("select unallocated_balance from ACCOUNT where account_id = " + account_id);
                    //Class.Run("select datestamp from ACCOUNT where account_id=" + account_id);

                    //Sum of ACCOUNT_CREDIT_AVAILABLE.amount = ACCOUNT.unallocated_balance
                    DataTable paymentDetails = Class.Run("select ACCOUNT_CREDIT_AVAILABLE.transaction_id, ACCOUNT_CREDIT_AVAILABLE.amount, ACCOUNTING_TRANSACTION.effective_date, PAYMENT_DETAIL.payment_type_id, PAYMENT_DETAIL.reversal_transaction_id, PAYMENT_DETAIL.lock_until_date, PAYMENT_DETAIL.ar_export_flag, PAYMENT_DETAIL.ar_export_entity_type, PAYMENT_DETAIL.ar_export_reference_id, PAYMENT_DETAIL.datestamp, PAYMENT_DETAIL.userstamp from ACCOUNTING_TRANSACTION, PAYMENT_DETAIL, ACCOUNT_CREDIT_AVAILABLE where ACCOUNT_CREDIT_AVAILABLE.transaction_id = PAYMENT_DETAIL.transaction_id and PAYMENT_DETAIL.transaction_id = ACCOUNTING_TRANSACTION.transaction_id and ACCOUNT_CREDIT_AVAILABLE.account_id = " + account_id + " order by ACCOUNTING_TRANSACTION.transaction_id");

                    Class.Run("select endorse_before_image_scan from PAYMENT_TYPE");
                    Class.Run("select PAYMENT_TYPE.payment_type_id, PAYMENT_TYPE.gl_account_id, PAYMENT_TYPE.Title, PAYMENT_TYPE.name, PAYMENT_TYPE.authorization_required_flag,PAYMENT_TYPE.pay_info_required_flag, PAYMENT_TYPE.refundable_flag,PAYMENT_TYPE.refund_lock_days, PAYMENT_TYPE.default_refund_id, PAYMENT_TYPE.refund_when, PAYMENT_TYPE.refund_gl_account_id, PAYMENT_TYPE.postdated_payments_flag,PAYMENT_TYPE.show_on_daily_cash, PAYMENT_TYPE.include_in_export, PAYMENT_TYPE.Type, PAYMENT_TYPE.points_per_dollar, PAYMENT_TYPE.currency_id, PAYMENT_TYPE.tender_min_amount, PAYMENT_TYPE.tender_max_amount, PAYMENT_TYPE.change_max_amount, PAYMENT_TYPE.allow_restricted_change, PAYMENT_TYPE.preset_amount, PAYMENT_TYPE.bank_deposit_flag, PAYMENT_TYPE.prompt_for_amount_flag, PAYMENT_TYPE.over_tender_flag, PAYMENT_TYPE.Validate_flag, PAYMENT_TYPE.slip_flag, PAYMENT_TYPE.open_drawer_flag, PAYMENT_TYPE.change_id, PAYMENT_TYPE.default_refund_fee_id , PAYMENT_TYPE.active, PAYMENT_TYPE.Userstamp, PAYMENT_TYPE.Datestamp , PAYMENT_TYPE.digital_image, PAYMENT_TYPE.credit_card_length, PAYMENT_TYPE.pos_sp_id, PAYMENT_TYPE.verify_cheque, PAYMENT_TYPE.cheque_cashing_only_flag, PAYMENT_TYPE.cheque_numbers_required_flag ,PAYMENT_TYPE.require_other_info_type, PAYMENT_TYPE.eft_number_format, PAYMENT_TYPE.print_account_number, PAYMENT_TYPE.print_transit_number, PAYMENT_TYPE.print_cc_expiry_date, PAYMENT_TYPE.card_config_id, PAYMENT_TYPE.custom_payment_prompt_id, PAYMENT_TYPE.front_desk_flag, PAYMENT_TYPE.internet_check_out_flag, PAYMENT_TYPE.internet_sche_payments_flag, PAYMENT_TYPE.internet_display_name, PAYMENT_TYPE.endorsement_text, PAYMENT_TYPE.replace_terminal_endorsement, PAYMENT_TYPE.endorse_before_image_scan, POS_CURRENCY.title currency_title, POS_CURRENCY.exchange_rate from PAYMENT_TYPE, POS_CURRENCY  where PAYMENT_TYPE.currency_id = POS_CURRENCY.currency_id and PAYMENT_TYPE.payment_type_id = 3");
                    
                    for (int j = 0; j < paymentDetails.Rows.Count; j++)
                    {
                        int transaction_id = int.Parse(paymentDetails.Rows[j]["transaction_id"].ToString());
                        decimal balance = Math.Abs(decimal.Parse(Class.RunString("select amount from ACCOUNT_CREDIT_AVAILABLE where transaction_id=" + transaction_id)));

                        //Unsure
                        Class.Run("select transaction_id from AUTHORIZATION_REQUIRED where transaction_id = " + transaction_id);
                        Class.Run("select credit_locked_flag, amount_requested from REFUND_REQUESTED where transaction_id=" + transaction_id);
                        Class.Run("select entity_type_id, [reference], amount, payment_date, ar_export_flag from PAYMENT_SCHEDULE where account_id = " + account_id + " order by payment_date, datestamp, reference");
                        Class.Run("select balance_amount, entity_type_id, [reference] from ENTITY_BALANCE where entity_type_id = 'M' and [reference] = " + account_id);

                        //Tracks history of all payment allocations
                        Class.Run("update ID_COUNTER set counter = counter + 1, datestamp = '" + datestamp + "', userstamp = 0 where table_name = 'PAYMENT_ALLOCATION'");
                        int payment_allocation_counter = int.Parse(Class.RunString("select counter from ID_COUNTER where table_name = 'PAYMENT_ALLOCATION'"));
                        Class.Run("insert into PAYMENT_ALLOCATION (payment_allocation_id, transaction_id, account_id, [reference], entity_type_id, self_allocation_flag, amount, datestamp, userstamp) values (" + payment_allocation_counter + ", " + transaction_id + ", " + account_id + ", " + account_id + ", 'M', 0, " + balance + ", '" + datestamp + "', 0)");

                        //Sum of ACCOUNT_CREDIT_AVAILABLE.amount = ACCOUNT.unallocated_balance
                        Class.Run("delete from ACCOUNT_CREDIT_AVAILABLE where transaction_id = " + transaction_id);

                        
                        Class.Run("select balance_amount, entity_type_id, [reference], account_id, ar_export_flag, datestamp, userstamp from ENTITY_BALANCE where entity_type_id = 'M' and [reference] = " + account_id);
                        Class.Run("delete from ENTITY_BALANCE where entity_type_id = 'M' and [reference] = " + account_id);

                        Class.Run("select payment_date, entity_type_id, [reference], amount, datestamp, userstamp from PAYMENT_SCHEDULE where entity_type_id = 'M' and [reference] = " + account_id + " and payment_date = '" + date + "' order by payment_date");
                        Class.Run("delete from PAYMENT_SCHEDULE where entity_type_id = 'M' and [reference] = " + account_id + " and payment_date = '" + date + "'");

                        Class.Run("select balance_amount, entity_type_id, [reference], account_id, ar_export_flag, datestamp, userstamp from ENTITY_BALANCE where entity_type_id = 'A' and [reference] = " + account_id);
                        Class.Run("delete from ENTITY_BALANCE where entity_type_id = 'A' and [reference] = " + account_id);

                        //Check everything after here
                        Class.Run("delete from REFUND_REQUESTED where transaction_id = " + transaction_id + " and amount_requested <= " + balance + "");
                        Class.Run("update REFUND_REQUESTED set amount_requested = amount_requested - " + balance + ", refund_fee_id = NULL, datestamp = '" + datestamp + "', userstamp = 0 where transaction_id = " + transaction_id);

                        Class.Run("update ACCOUNT set current_balance = current_balance + 0, future_balance = future_balance + 0, unallocated_balance = unallocated_balance - " + balance + ", datestamp = '" + datestamp + "', userstamp = 0 where account_id = " + account_id + " and account_status_id not in ('X','M') and datestamp = '" + datestamp + "'");
                    }

                    count++;
                }
                else //Third party billing is not 0
                {
                    notes += "Account \"" + accountTitle + "\" (ID " + account_id + ") has third party billing, therefore must be handled manually." + Environment.NewLine;
                }
            }

            Console.WriteLine("Reallocations complete!" + Environment.NewLine);

            if (notes != "")
                Console.WriteLine(notes);

            Console.WriteLine(Environment.NewLine
                + "Total rellocations: " + count + Environment.NewLine
                + "Total credits reallocated: $" + totalReallocations + Environment.NewLine);
        }
    }
}
