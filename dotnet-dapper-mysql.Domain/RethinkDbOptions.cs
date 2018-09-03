namespace dotnet_dapper_mysql.Domain
{
    public class RethinkDbOptions
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string Database { get; set; }
        public int Timeout { get; set; }
    }
}