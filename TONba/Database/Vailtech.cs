using System.Data;

namespace I_IT
{
    class Vailtech : Database
    {
        static DatabaseType type = DatabaseType.Oracle;
        static string hostServer = "oracle2003r2";
        static string database = "btx";
        static string username = "vailtech";
        static string password = "geezus";

        public Vailtech(string str) : base(type, str, hostServer, database, username, password)
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
