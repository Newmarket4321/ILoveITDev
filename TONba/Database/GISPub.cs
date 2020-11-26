﻿using System.Data;

namespace I_IT
{
    class GISPub : Database
    {
        static DatabaseType type = DatabaseType.Oracle;
        static string hostServer = "e2";
        static string database = "ESRI10PUB";
        static string username = "system";
        static string password = "geezus";

        public GISPub(string str) : base(type, str, hostServer, database, username, password)
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
