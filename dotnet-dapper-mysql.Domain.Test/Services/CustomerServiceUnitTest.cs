using System;
using System.Linq;
using dotnet_dapper_mysql.Domain.Dtos;
using dotnet_dapper_mysql.Domain.Services;
using NUnit.Framework;
using NSubstitute;

namespace dotnet_dapper_mysql.Domain.Test
{
    public class CustomerServiceUnitTest
    {
        [SetUp]
        public void SetUp()
        {
            
        }
        
        [Test]
        public void GetMembers_Verify_Count()
        {
            // Arrange
            var target = 1;

            // Act
            var actual = CustomerService.Instance.GetMembers().Result.Count;

            // Assert
            Assert.AreEqual(target,actual);
            
            // Arrange 
            Assert.AreEqual(actual,target);
        }
        
        [Test]
        public void GetMembers_Verify_FirstContent_Id()
        {
            // Arrange 
            var target = new Member
            {
                Id = 1,
                Code = "blackie1019",
                Name = "Blackie Tsai"
            };
            
            // Act
            var actual = CustomerService.Instance.GetMembers().Result.First();
            
            // Assert
            Assert.AreEqual(actual.Id,target.Id);
        }
        
        [Test]
        public void GetMembers_Verify_FirstContent_Code()
        {
            // Arrange 
            var target = new Member
            {
                Id = 1,
                Code = "blackie1019",
                Name = "Blackie Tsai"
            };
            
            // Act
            var actual = CustomerService.Instance.GetMembers().Result.First();
            
            // Assert
            Assert.AreEqual(actual.Code,target.Code);
        }
        
        [Test]
        public void GetMembers_Verify_FirstContent_Name()
        {
            // Arrange 
            var target = new Member
            {
                Id = 1,
                Code = "blackie1019",
                Name = "Blackie Tsai"
            };
            
            // Act
            var actual = CustomerService.Instance.GetMembers().Result.First();
            
            // Assert
            Assert.AreEqual(actual.Name,target.Name);
        }

        [Test]
        public void AddMember_Verify_ReturnCode()
        {
            Assert.Inconclusive("Not implement Yet");
        }
    }
}