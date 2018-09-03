using System;
using MySql.Data.MySqlClient;

namespace dotnet_dapper_mysql.Domain
{
    public class AppMySqlDb:IDisposable
    {
        public readonly MySqlConnection Connection;

        public AppMySqlDb()
        {
            Connection = new MySqlConnection("host=127.0.0.1;port=3306;user id=root;password=pass.123;database=dapper-test;");
        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}