using System.Data;

namespace I_IT
{
    public class SQL : Database
    {
        static DatabaseType type = DatabaseType.SQL;
        // static string hostServer = "172.16.0.34";  //Prod


        static string hostServer = "172.16.0.46";  
        static string database = "IHeartIT";
        static string username = "DATS";
        static string password = "SQL2008@r2";

        public SQL(string str) : base(type, str, hostServer, database, username, password)
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
