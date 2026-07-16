using Dapper;
using JPP.Data.DataAccess;
using JPP.Data.Interfaces;
using JPP.Models.Customer.Responses.CustomerDto;

namespace JPP.Data.Repositories
{
    public class CustomerEditRepository : ICustomerEditRepository
    {
        private readonly ICrmDbConnectionFactory _crmDbConnectionFactory;

        public CustomerEditRepository(ICrmDbConnectionFactory crmDbConnectionFactory)
        {
            _crmDbConnectionFactory = crmDbConnectionFactory;
        }

        public async Task<CustomerDto?> GetCustomerByIdAsync(int id)
        {
            if (id <= 0)
            {
                return null;
            }

            const string sql = @"
                SELECT
                    ID AS CustomerId,
                    Title,
                    FirstName,
                    MiddleName,
                    LastName,
                    IdentityNo,
                    DOB,
                    MaritalStatus,
                    Gender,
                    Race,
                    Nation,
                    Occupation,
                    PhoneNumber,
                    HPNum,
                    EmailAddress,
                    [Password],
                    Password_WEB,
                    BlockHouseNo,
                    UnitNo,
                    Address1,
                    Address2,
                    City,
                    State,
                    Country,
                    Zip,
                    CategoryID,
                    StoreID,
                    AcceptSMS,
                    AcceptMailEmail
                FROM BIZ_Customer
                WHERE ID = @Id";

            using var conn = _crmDbConnectionFactory.Create();
            return await conn.QuerySingleOrDefaultAsync<CustomerDto>(sql, new { Id = id });
        }
    }
}