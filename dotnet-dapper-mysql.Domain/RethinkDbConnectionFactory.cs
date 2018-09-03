using RethinkDb.Driver;
using RethinkDb.Driver.Net;
using Microsoft.Extensions.Options;

namespace dotnet_dapper_mysql.Domain
{
    public class RethinkDbConnectionFactory : IRethinkDbConnectionFactory
    {
        private static RethinkDB R = RethinkDB.R;
        private Connection conn;
        private RethinkDbOptions _options;

        public RethinkDbConnectionFactory(IOptions<RethinkDbOptions> options)
        {
            _options = options.Value;
        }

        public Connection CreateConnection()
        {
            if (conn == null)
            {
                conn = R.Connection()
                    .Hostname(_options.Host)
                    .Port(_options.Port)
                    .Timeout(_options.Timeout)
                    .Connect();
            }

            if(!conn.Open)
            {
                conn.Reconnect();
            }

            return conn;
        }

        public void CloseConnection()
        {
            if (conn != null && conn.Open)
            {
                conn.Close(false);
            }
        }

        public RethinkDbOptions GetOptions()
        {
            return _options;
        }
    }
}