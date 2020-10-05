using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class InventoryDataExport : Form
    {
        public InventoryDataExport()
        {
            InitializeComponent();
            
            SQL sql = new SQL("select * from programs where code=@CODE");
            sql.AddParameter("@CODE", Name);
            DataTable dt = sql.Run();

            Text = dt.Rows[0]["Description"].ToString();
        }

        private void Visa_Load(object sender, EventArgs e)
        {
            DataTable dt = Oracle.Run(@"
SELECT
ABALPH AS Supplier,
IVAN8 AS ""JDE Vendor Number"",
IVCITM AS ""Supplier Item #"",
IMITM AS ""TON Item No"",
'' AS ""2nd Item Number"",
'' AS ""Catalogue Number"",
IVDSC2 AS ""Vendor Item Description"",
IMDSC1 AS ""TON Item Description"",
'' AS ""Business Unit"",
COUNCS/10000 AS ""Item Price"",
IVDSC1 AS Search,
'' AS Location,
'' AS ""Primary Location Aisle/Shelf"",
'' AS ""Secondary Location Aisle/Shelf"",
'' AS ""Tertiary Location Aisle/Shelf"",
'' AS ""Cost Method"",
'' AS ""Cycle Count M or Q"",
'' AS ""Primary UOM"",
'' AS Purchasing,
'' AS ""UOM conv. on Branch Plant"",
'' AS ""Lead Time"",
IMUOM1 AS ""Issue UOM"",
IMUOM2 AS ""Purchasing UOM"",
IBUPC AS ""Quantity / Purchasing UOM"",
IBROQI/100 AS ""Reorder Qty"",
IBROPI/100 AS ""Reorder Point"",
IBRQMN/100 AS ""Min"",
IBRQMX/100 AS ""Max""

FROM CRPDTA.F4101
LEFT JOIN CRPDTA.F4102 ON CRPDTA.F4101.IMITM = CRPDTA.F4102.IBITM
LEFT JOIN CRPDTA.F4104 ON CRPDTA.F4104.IVITM = CRPDTA.F4101.IMITM
LEFT JOIN CRPDTA.F0101 ON CRPDTA.F0101.ABAN8 = CRPDTA.F4104.IVAN8
LEFT JOIN CRPDTA.F4105 ON CRPDTA.F4105.COITM = CRPDTA.F4101.IMITM

WHERE IMITM >= 11183
AND COLEDG = '08'

ORDER BY IMITM ASC");

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string itemNo = dt.Rows[i]["TON Item No"].ToString();

                dt.Rows[i]["Primary Location Aisle/Shelf"] = Oracle.RunString("select LILOCN from CRPDTA.F41021 where LIITM = @ITEMNO and LIPBIN = 'P'", itemNo);

                try
                {
                    dt.Rows[i]["Secondary Location Aisle/Shelf"] = Oracle.RunString("select min(LILOCN) from CRPDTA.F41021 where LIITM = @ITEMNO and LIPBIN = 'S'", itemNo);

                    if(Oracle.Run("select * from CRPDTA.F41021 where LIITM = @ITEMNO", itemNo).Rows.Count >= 3)
                        dt.Rows[i]["Tertiary Location Aisle/Shelf"] = Oracle.RunString("select max(LILOCN) from CRPDTA.F41021 where LIITM = @ITEMNO and LIPBIN = 'S'", itemNo);
                }
                catch
                {
                    
                }
            }

            Report r = new Report(Text, dt);
            r.Show();

            Close();
        }
    }
}
