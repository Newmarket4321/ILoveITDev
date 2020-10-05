using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_IT
{
    class WinfuelJDEExport
    {
        public WinfuelJDEExport()
        {
            //          const string environment = "PD";
            const string environment = "PY";
            //          EAC
            string schema = Core.getSchema(environment);
            string controlSchema = Core.getControlSchema(environment);
            string contact = "aagoncillo@newmarket.ca,dschellenberg@newmarket.ca";


            DateTime from = (new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)).AddMonths(-1);
            DateTime to = from.AddMonths(1);

            Console.WriteLine("Running from " + from.ToString("MMMM dd, yyyy") + " to " + to.ToString("MMMM dd, yyyy"));

            bool databaseSynced = SQL.Run(@"SELECT transactdate, errormessage
  FROM [Winfuel].[dbo].[EReport]
  where transactdate >= @DATE
  and errormessage = 'Communication performed'
  order by transactdate asc", to).Rows.Count > 0;

            if(!databaseSynced)
            {
                Console.WriteLine("Winfuel batch not yet exported", "Export aborted, as the Winfuel database hasn't synced with the gas pumps recently. Please check the sync, and Winfuel table \"EReport\".");

                //Core.sendMail(contact, "Winfuel batch not yet exported", "The Winfuel batch attempted to export, however didn't as there was a sync issue." + Environment.NewLine
                //    + "IT is aware of the issue and will be looking after it. You will be notified when the batch is ready later today.");
                
                Core.sendMail("ealarcon@newmarket.ca,msquires@newmarket.ca", "Winfuel batch failed to export", "Export aborted, as the Winfuel database hasn't synced with the gas pumps recently." + Environment.NewLine
                    + Environment.NewLine
                    + "Please check the sync and Winfuel table \"EReport\", then try WinfuelJDEExport again within IHeartIT.");

                return;
            }

            DataTable wf = SQL.Run(@"
use winfuel;

SELECT t.VehDescription as Asset
      ,sum([TotalCost]) as TotalCost
      ,sum(fuelunits) as FuelUnits

  FROM [Winfuel].[dbo].[Transact] t
  join division d on t.division = d.number

  where transactdate >= @STARTDATE
  and transactdate < @ENDDATE
  and fuelunits <> 0

  group by t.VehDescription

  order by VehDescription", from, to);

            string VNEDBT = Oracle.RunString("SELECT NNN006 from " + controlSchema + ".F0002 where NNSY='00'");
            Oracle.Run("UPDATE " + controlSchema + ".F0002 SET NNN006=NNN006+1");

            Core.log("WinfuelJDEExport", "Batch exporting", VNEDBT);

            Console.WriteLine("Batch number is " + VNEDBT);

            for (int i = 0, lineNumber = 1; i < wf.Rows.Count; i++)
            {
                Console.WriteLine(i);

                try
                {
                    int batchNumber = int.Parse(VNEDBT);
                    DateTime glDate = DateTime.Today.AddDays(-1);
                    string batchDescription = "Winfuel Import " + glDate.ToString("MM\\/dd\\/yy");
                    string asset = wf.Rows[i]["Asset"].ToString();
                    decimal amount = decimal.Parse(wf.Rows[i]["TotalCost"].ToString());
                    string positiveBranchPlant = ""; //See below
                    string positiveObjectNumber = "4231";
                    string positiveSub = "";
                    string creditAccount = "32361.4231";
                    decimal fuelUnits = decimal.Parse(wf.Rows[i]["FuelUnits"].ToString());

                    //Try to find responsible department
                    try
                    {
                        positiveBranchPlant = Oracle.RunString("select FAMCU from " + Core.getSchema(environment) + ".F1201 where trim(FAAPID) = trim(@ASSET)", asset);
                    }
                    catch
                    {
                        try
                        {
                            positiveBranchPlant = SQL.RunString("use winfuel; select branchplant from divisionbranchplants d join vehicle v on v.division = d.number where v.description = @ASSET", asset);
                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                    }

                    //Submit
                    lineNumber = Core.submitGL(environment, batchNumber, batchDescription, lineNumber, glDate, asset, "", amount, positiveBranchPlant, positiveObjectNumber, positiveSub, creditAccount, fuelUnits, "LT", null, Core.GLType.General, Core.GLSides.Both);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
            Core.sendMail(contact, "Winfuel batch exported- TEST environment", "Batch number is " + VNEDBT);
            Console.WriteLine("The export has completed successfully.");
        }
    }
}
