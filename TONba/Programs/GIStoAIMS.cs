using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_IT
{
    class GIStoAIMS
    {
        public GIStoAIMS()
        {
            DataTable dt = GISPub.Run("select * from TONGIS.View_AIMS_Address");

            //Report r = new Report("Test", dt);
            //r.ShowDialog();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine("Entering " + (i + 1) + " of " + dt.Rows.Count);
                
                int active = 1;
                int streetNoLower = int.Parse(dt.Rows[i]["street_no"].ToString());
                int streetNoUpper = streetNoLower;
                string streetQual = dt.Rows[i]["street_qual"].ToString();
                string streetName = dt.Rows[i]["street_name"].ToString().ToUpper();
                string aptNo = "";
                string numSpaces = "";
                string permitProgram = "";
                string sideOfStreet = "";
                string streetComment = "";

                if (streetQual == "-")
                    streetNoUpper = int.Parse(dt.Rows[i]["street_unit"].ToString());
                else
                    aptNo = dt.Rows[i]["street_unit"].ToString();
                
                for(int j = streetNoLower; j <= streetNoUpper; j++)
                {
                    //If doesn't exist
                    if (SQL.Run("use aims; select * from ap_resstreets where streetnum = @STREETNO and streetname = @STREETNAME and aptnum = @APTNO", j, streetName, aptNo).Rows.Count == 0)
                    {
                        int counter = int.Parse(SQL.RunString("use aims; select next_id from as_seqnum where name='INTCODETYPEID'"));
                        SQL.Run("use aims; update as_seqnum set next_id = next_id + 1 where name = 'INTCODETYPEID'");

                        SQL.Run("use aims; insert into ap_resstreets values (@COUNTER, @ACTIVE, @STREETNO, @STREETNAME, @APTNO, @NUMSPACES, @PERMITPROGRAM, @SIDEOFSTREET, @STREETCOMMENT)", counter, active, j, streetName, aptNo, numSpaces, permitProgram, sideOfStreet, streetComment);
                    }
                }
            }
        }
    }
}
