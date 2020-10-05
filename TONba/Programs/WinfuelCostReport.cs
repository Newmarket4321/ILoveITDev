using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_IT
{
    class WinfuelCostReport
    {
        public WinfuelCostReport()
        {
            bool success;

            DateTime start = Core.getDate("Find all transactions starting...", out success);

            if (!success)
                return;

            DateTime end = Core.getDate("...until...", out success);
            
            if (!success)
                return;

            DataTable winfuel = SQL.Run(@"
use winfuel;
SELECT rtrim(ltrim(v.Description)) as Vehicle,
v.Description2 as Description,
d.branchplant as 'Business Unit',
sum(t.TotalCost) as Fuel,
max(t.Odometer) as Mileage
  FROM [Winfuel].[dbo].[Transact] t
  join vehicle v on t.vehicle = v.number
  join divisionbranchplants d on v.division = d.number
  where t.TransactDate >= @STARTDATE
  and t.TransactDate <= @ENDDATE
  group by rtrim(ltrim(v.Description)), v.description2, d.branchplant
  order by rtrim(ltrim(v.Description))", start, end);

            DataTable jde = Oracle.Run(@"
select
trim(e.FAAPID) as ""Vehicle"",
sum(w.WALBAM)/100 as ""Labour Cost"",
sum(w.WAMTAM)/100 as ""Materials Cost"",
sum(t.WAOTAM)/100 as ""Other Cost"",
udc1.DRDL01 as ""Department"",
e.FAMCU as ""Business Unit"",
e.FADL01 as ""Description"",
e.FADL02 as ""Description 2"",
e.FADL03 as ""Description 3"",
e.FAKITL as ""Purchase Price"",
udc2.DRDL01 as ""Model Year"",
udc3.DRDL01 as ""Manufacturer"",
e.FAASID as ""Serial Number"",
count(*) as ""Count""

from CRPDTA.F4801 w
join CRPDTA.F4801T t on w.WADOCO = t.WADOCO
join CRPDTA.F1201 e on w.WANUMB = e.FANUMB
join CRPCTL.F0005 udc1 on trim(udc1.DRKY) = trim(e.FAACL9) and udc1.DRSY='12' and udc1.DRRT='C9'
join CRPCTL.F0005 udc2 on trim(udc2.DRKY) = trim(e.FAACL4) and udc2.DRSY='12' and udc2.DRRT='C4'
join CRPCTL.F0005 udc3 on trim(udc3.DRKY) = trim(e.FAACL3) and udc3.DRSY='12' and udc3.DRRT='C3'
where (not (w.WASTRT < @STARTDATE1 and w.WASTRX < @STARTDATE2)
and not (w.WASTRT > @ENDDATE1 and w.WASTRX > @ENDDATE2))
or (w.WASTRT >= @STARTDATE3 and w.WASTRT <= @ENDDATE3 and w.WASTRX = 0)

group by
trim(e.FAAPID),
udc1.DRDL01,
e.FADL01,
e.FADL02,
e.FADL03,
udc2.DRDL01,
udc3.DRDL01,
e.FAASID,
e.FAKITL,
e.FAMCU
", Core.dateToJDE(start), Core.dateToJDE(start), Core.dateToJDE(end), Core.dateToJDE(end), Core.dateToJDE(start), Core.dateToJDE(end));

            DataTable dt = new DataTable();

            dt.Columns.Add("Vehicle");
            dt.Columns.Add("Vehicle Description 1");
            dt.Columns.Add("Vehicle Description 2");
            dt.Columns.Add("Vehicle Description 3");
            dt.Columns.Add("Total Cost", typeof(decimal));
            dt.Columns.Add("Fuel Cost", typeof(decimal));
            dt.Columns.Add("Labour Cost", typeof(decimal));
            dt.Columns.Add("Materials Cost", typeof(decimal));
            dt.Columns.Add("Other Cost", typeof(decimal));
            dt.Columns.Add("Mileage", typeof(int));
            dt.Columns.Add("Department");
            dt.Columns.Add("Business Unit");
            dt.Columns.Add("Model Year", typeof(int));
            dt.Columns.Add("Manufacturer");
            dt.Columns.Add("Serial Number");
            dt.Columns.Add("Purchase Price", typeof(decimal));
            dt.Columns.Add("Number of Work Orders", typeof(int));

            for (int i = 0; i < winfuel.Rows.Count; i++)
            {
                dt.Rows.Add();

                dt.Rows[i]["Vehicle"] = winfuel.Rows[i]["Vehicle"].ToString().Trim();
                dt.Rows[i]["Vehicle Description 1"] = winfuel.Rows[i]["Description"].ToString().Trim();
                dt.Rows[i]["Vehicle Description 2"] = "";
                dt.Rows[i]["Vehicle Description 3"] = "";
                dt.Rows[i]["Total Cost"] = winfuel.Rows[i]["Fuel"].ToString();
                dt.Rows[i]["Fuel Cost"] = winfuel.Rows[i]["Fuel"].ToString();
                dt.Rows[i]["Labour Cost"] = 0;
                dt.Rows[i]["Materials Cost"] = 0;
                dt.Rows[i]["Other Cost"] = 0;
                dt.Rows[i]["Mileage"] = winfuel.Rows[i]["Mileage"].ToString();
                dt.Rows[i]["Department"] = "";
                dt.Rows[i]["Business Unit"] = winfuel.Rows[i]["Business Unit"].ToString();
                dt.Rows[i]["Model Year"] = DBNull.Value;
                dt.Rows[i]["Manufacturer"] = "";
                dt.Rows[i]["Serial Number"] = "";
                dt.Rows[i]["Purchase Price"] = DBNull.Value;
                dt.Rows[i]["Number of Work Orders"] = 0;
                
                DataTable temp = Oracle.Run(@"
select
udc1.DRDL01 as ""Department"",
e.FADL01 as ""Description"",
e.FADL02 as ""Description 2"",
e.FADL03 as ""Description 3"",
e.FAMCU as ""Business Unit"",
udc2.DRDL01 as ""Model Year"",
udc3.DRDL01 as ""Manufacturer"",
e.FAASID as ""Serial Number"",
e.FAKITL as ""Purchase Price""

from CRPDTA.F1201 e
join CRPCTL.F0005 udc1 on trim(udc1.DRKY) = trim(e.FAACL9) and udc1.DRSY='12' and udc1.DRRT='C9'
join CRPCTL.F0005 udc2 on trim(udc2.DRKY) = trim(e.FAACL4) and udc2.DRSY='12' and udc2.DRRT='C4'
join CRPCTL.F0005 udc3 on trim(udc3.DRKY) = trim(e.FAACL3) and udc3.DRSY='12' and udc3.DRRT='C3'
where trim(e.FAAPID) = @ASSETID
", winfuel.Rows[i]["Vehicle"].ToString());

                if(temp.Rows.Count > 0)
                {
                    decimal purchasePrice = 0;
                    decimal.TryParse(temp.Rows[0]["Purchase Price"].ToString(), out purchasePrice);

                    dt.Rows[i]["Vehicle Description 1"] = temp.Rows[0]["Description"].ToString();
                    dt.Rows[i]["Vehicle Description 2"] = temp.Rows[0]["Description 2"].ToString();
                    dt.Rows[i]["Vehicle Description 3"] = temp.Rows[0]["Description 3"].ToString();
                    dt.Rows[i]["Department"] = temp.Rows[0]["Department"].ToString();
                    dt.Rows[i]["Business Unit"] = temp.Rows[0]["Business Unit"].ToString();
                    dt.Rows[i]["Model Year"] = temp.Rows[0]["Model Year"].ToString();
                    dt.Rows[i]["Manufacturer"] = temp.Rows[0]["Manufacturer"].ToString();
                    dt.Rows[i]["Purchase Price"] = purchasePrice;
                    dt.Rows[i]["Serial Number"] = temp.Rows[0]["Serial Number"].ToString();
                }
            }

            for (int i = 0; i < jde.Rows.Count; i++)
            {
                string vehicle = jde.Rows[i]["Vehicle"].ToString().Trim();
                decimal labour = decimal.Parse(jde.Rows[i]["Labour Cost"].ToString());
                decimal materials = decimal.Parse(jde.Rows[i]["Materials Cost"].ToString());
                decimal other = decimal.Parse(jde.Rows[i]["Other Cost"].ToString());
                decimal fuel;
                decimal total;

                int index = -1;

                for (int j = 0; j < dt.Rows.Count && index == -1; j++)
                    if (dt.Rows[j]["Vehicle"].ToString() == vehicle)
                        index = j;

                if (index == -1) //This vehicle is new
                {
                    fuel = 0;
                    total = labour + materials + fuel + other;

                    dt.Rows.Add();
                    index = dt.Rows.Count - 1;

                    decimal purchasePrice = 0;
                    decimal.TryParse(jde.Rows[i]["Purchase Price"].ToString(), out purchasePrice);

                    dt.Rows[index]["Vehicle"] = vehicle;
                    dt.Rows[index]["Vehicle Description 1"] = jde.Rows[i]["Description"].ToString();
                    dt.Rows[index]["Vehicle Description 2"] = jde.Rows[i]["Description 2"].ToString();
                    dt.Rows[index]["Vehicle Description 3"] = jde.Rows[i]["Description 3"].ToString();
                    dt.Rows[index]["Total Cost"] = total;
                    dt.Rows[index]["Fuel Cost"] = fuel;
                    dt.Rows[index]["Labour Cost"] = labour;
                    dt.Rows[index]["Materials Cost"] = materials;
                    dt.Rows[index]["Other Cost"] = other;
                    dt.Rows[index]["Mileage"] = 0;
                    dt.Rows[index]["Department"] = jde.Rows[i]["Department"].ToString();
                    dt.Rows[index]["Business Unit"] = jde.Rows[i]["Business Unit"].ToString();
                    dt.Rows[index]["Model Year"] = jde.Rows[i]["Model Year"].ToString();
                    dt.Rows[index]["Manufacturer"] = jde.Rows[i]["Manufacturer"].ToString();
                    dt.Rows[index]["Serial Number"] = jde.Rows[i]["Serial Number"].ToString();
                    dt.Rows[index]["Purchase Price"] = purchasePrice;
                    dt.Rows[index]["Number of Work Orders"] = jde.Rows[i]["Count"].ToString();
                }
                else //We have this vehicle via Winfuel
                {
                    fuel = decimal.Parse(dt.Rows[index]["Fuel Cost"].ToString());
                    total = labour + materials + fuel + other;

                    decimal purchasePrice = 0;
                    decimal.TryParse(jde.Rows[i]["Purchase Price"].ToString(), out purchasePrice);

                    //dt.Rows[index]["Vehicle"] = vehicle;
                    dt.Rows[index]["Vehicle Description 1"] = jde.Rows[i]["Description"].ToString();
                    dt.Rows[index]["Vehicle Description 2"] = jde.Rows[i]["Description 2"].ToString();
                    dt.Rows[index]["Vehicle Description 3"] = jde.Rows[i]["Description 3"].ToString();
                    dt.Rows[index]["Total Cost"] = total;
                    //dt.Rows[index]["Fuel Cost"] = jde.Rows[i]["Fuel Cost"].ToString();
                    dt.Rows[index]["Labour Cost"] = labour;
                    dt.Rows[index]["Materials Cost"] = materials;
                    dt.Rows[index]["Other Cost"] = other;
                    //dt.Rows[index]["Mileage"] = jde.Rows[i]["Mileage"].ToString();
                    dt.Rows[index]["Department"] = jde.Rows[i]["Department"].ToString();
                    dt.Rows[index]["Business Unit"] = jde.Rows[i]["Business Unit"].ToString();
                    dt.Rows[index]["Model Year"] = jde.Rows[i]["Model Year"].ToString();
                    dt.Rows[index]["Manufacturer"] = jde.Rows[i]["Manufacturer"].ToString();
                    dt.Rows[index]["Serial Number"] = jde.Rows[i]["Serial Number"].ToString();
                    dt.Rows[index]["Purchase Price"] = purchasePrice;
                    dt.Rows[index]["Number of Work Orders"] = jde.Rows[i]["Count"].ToString();
                }
            }

            //for(int i = 0; i < dt.Rows.Count; i++)
            //{
            //    dt.Rows[i]["Total Cost"] = decimal.Parse(dt.Rows[i]["Total Cost"].ToString()).ToString("C");
            //    dt.Rows[i]["Fuel Cost"] = decimal.Parse(dt.Rows[i]["Fuel Cost"].ToString()).ToString("C");
            //    dt.Rows[i]["Labour Cost"] = decimal.Parse(dt.Rows[i]["Labour Cost"].ToString()).ToString("C");
            //    dt.Rows[i]["Materials Cost"] = decimal.Parse(dt.Rows[i]["Materials Cost"].ToString()).ToString("C");
            //    dt.Rows[i]["Other Cost"] = decimal.Parse(dt.Rows[i]["Other Cost"].ToString()).ToString("C");
            //}
            
            Report r = new Report("Winfuel Cost Report", dt);
            r.Show();
        }
    }
}
