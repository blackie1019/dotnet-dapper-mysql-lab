using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_dapper_mysql.Domain.Dtos;

namespace dotnet_dapper_mysql.Domain.Services
{
    public class CustomerService
    {
        private static readonly Lazy<CustomerService> Lazy = new Lazy<CustomerService>(() => new CustomerService());

        private CustomerService()
        {
        }

        public static CustomerService Instance => Lazy.Value;

        public async Task<IList<Member>> GetMembers()
        {
            var data = new List<Member>();

            using (var db = new AppMySqlDb())
            {
                await db.Connection.OpenAsync();
                using (var cmd = db.Connection.CreateCommand())
                {
                    var sqlString = "SELECT Id, Code, Name FROM Member;";
                    cmd.CommandText = sqlString;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                            data.Add(new Member
                                {
                                    Id = reader.GetInt32(0),
                                    Code = reader.GetString(1),
                                    Name = reader.GetString(2)
                                }
                            );
                    }
                }
            }

            return data;
        }
    }
}