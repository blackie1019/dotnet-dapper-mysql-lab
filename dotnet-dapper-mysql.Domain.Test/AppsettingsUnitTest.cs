using System;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace dotnet_dapper_mysql.Domain.Test.Services
{
    public class AppsettingsUnitTest
    {
        private IConfiguration config;
        
        [SetUp]
        public void SetUp()
        {
            config =  new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            
        }

        [Test]
        public void GetRethinkDbConnection_Verify_By_GetSection()
        {
            // Arrange
            var variableHost = "localhost";
            var variablePort = 28015;
            var variableTimeout = 10;
            var variableDatabase = "TokenStore";
            
            // Action
            var dbConnection = config.GetSection("RethinkDbConnection");
            
            // Assert
            Assert.AreEqual(variableHost, dbConnection.GetSection("Host").Value);
            Assert.AreEqual(variablePort, Convert.ToInt32(dbConnection.GetSection("Port").Value));
            Assert.AreEqual(variableTimeout, Convert.ToInt32(dbConnection.GetSection("Timeout").Value));
            Assert.AreEqual(variableDatabase, dbConnection.GetSection("Database").Value);
            
        }
        
        [Test]
        public void GetRethinkDbConnection_Verify_By_JsonMapping()
        {
            // Arrange
            var variableHost = "localhost";
            var variablePort = 28015;
            var variableTimeout = 10;
            var variableDatabase = "TokenStore";
            
            // Action
            var setting = new RethinkDbOptions();
            config.GetSection("RethinkDbConnection").Bind(setting);
            
            // Assert
            Assert.AreEqual(variableHost, setting.Host);
            Assert.AreEqual(variablePort, setting.Port);
            Assert.AreEqual(variableTimeout, setting.Timeout);
            Assert.AreEqual(variableDatabase, setting.Database);
            
        }
    }
    

}