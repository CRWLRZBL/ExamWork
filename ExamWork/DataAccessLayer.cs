using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWork
{
    public static class DataAccessLayer
    {
        public static string ServerName { get; set; } = @"prserver\SQLEXPRESS";
        public static string DataBaseName { get; set; } = "ispp2111";
        public static string Login { get; set; } = "ispp2111";
        public static string Password { get; set; } = "2111";
        public static string ConnectionString { get;} = GetConnectionString();

        public static string GetConnectionString()
        {
            SqlConnectionStringBuilder builder = new()
            {
                DataSource = @"prserver\SQLEXPRESS", // server
                UserID = "ispp2111", // login
                Password = "2111",
                InitialCatalog = "ispp2111", // DB
                TrustServerCertificate = true
            };
            return builder.ConnectionString;
        }
    }
}
