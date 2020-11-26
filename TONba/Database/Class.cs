using System.Data;

namespace I_IT
{
    class Class : Database
    {
        static DatabaseType type = DatabaseType.SQL;
        static string hostServer = "172.21.0.16";
     // static string database = "Class";
        static string database = "Trainer";
        static string username = "IHeartIT";
        static string password = "Love2help";

        public Class(string str) : base(type, str, hostServer, database, username, password)
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
