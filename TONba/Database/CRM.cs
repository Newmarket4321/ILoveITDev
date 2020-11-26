using System.Data;

namespace I_IT
{
    class CRM : Database
    {
        static DatabaseType type = DatabaseType.SQL;
        //        static string hostServer = "172.16.0.34";
        static string hostServer = "172.16.0.46";
        //        static string database = "HEATCRM";
        static string database = "HEATCRM-STG";

        static string username = "IHeartIT";
        static string password = "Love2help";

        public CRM(string str) : base(type, str, hostServer, database, username, password)
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
