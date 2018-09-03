using RethinkDb.Driver.Net;

namespace dotnet_dapper_mysql.Domain
{
    public interface IRethinkDbConnectionFactory
    {
        Connection CreateConnection();
        void CloseConnection();
        RethinkDbOptions GetOptions();
    }
}