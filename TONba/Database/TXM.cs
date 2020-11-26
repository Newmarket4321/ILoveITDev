using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_IT
{
    class TXM : Database
    {
       static DatabaseType type = DatabaseType.Oracle;
        static string hostServer = "ORACLEDBdev.town.newmarket.on.ca";
        static string database = "txm";
        static string username = "system";
        static string password = "geezus";

        public TXM(string str) : base(type, str, hostServer, database, username, password)
        {

        }

        public static new DataTable Run(string str, params object[] list)
        {
            return Run(type, str, hostServer, database, username, password, list);
        }

        new public static string RunString(string str, params object[] list)
        {
            return Run(str, list).Rows[0][0].ToString();
        }
    }
}
