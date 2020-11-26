using System.Data;

namespace I_IT
{
    class Oracle : Database
    {
        static DatabaseType type = DatabaseType.Oracle;
        static string hostServer = "ORACLEDBJDE";
        static string database = "E1JDEDB";
        static string username = "JDETON";
        static string password = "jT7Y4!fd6k";
        
        public Oracle(string str) : base(type, str, hostServer, database, username, password)
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
