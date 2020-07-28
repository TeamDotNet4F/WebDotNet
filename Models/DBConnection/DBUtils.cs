using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Project.Models.DBConnection
{
    public class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "projectDotNet";
            string username = "root";
            string password = "StrongPass123";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}