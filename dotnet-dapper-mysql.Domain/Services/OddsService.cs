using System;

namespace dotnet_dapper_mysql.Domain.Services
{
    public class OddsService
    {
        private static readonly Lazy<OddsService> Lazy = new Lazy<OddsService>(() => new OddsService());

        private OddsService()
        {
        }

        public static OddsService Instance => Lazy.Value;
        
//        public string UpdateOdds

    }
}