using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace dotnet_dapper_mysql.Domain.Test.Services
{
    public class OddsServiceUnitTest
    {
        private IConfiguration config;
        
        [SetUp]
        public void SetUp()
        {
            config =  new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var dbConnection = config.GetSection("RethinkDbConnection");
             
        }

        [Test]
        public void InsertOInsertOddsServcieddsServcie()
        {

        }
    }
    

}