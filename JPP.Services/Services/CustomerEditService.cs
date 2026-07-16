using JPP.Data.Interfaces;
using JPP.Models.Customer.Request;
using JPP.Models.Customer.Responses;
using JPP.Services.Interfaces;

namespace JPP.Services.Services
{
    public class CustomerEditService : ICustomerEditService
    {
        private readonly ICustomerEditRepository _customerEditRepository;

        public CustomerEditService(ICustomerEditRepository customerEditRepository)
        {
            _customerEditRepository = customerEditRepository;
        }

        public async Task<CustomerDetailViewModel?> BuildEditViewModelAsync(int id)
        {
            if (id <= 0)
            {
                return null;
            }

            var customer = await _customerEditRepository.GetCustomerByIdAsync(id);

            if (customer == null)
            {
                return null;
            }

            return new CustomerDetailViewModel
            {
                Form = new CustomerRequest
                {
                    ID = customer.CustomerId,
                    Title = customer.Title,
                    FirstName = customer.FirstName,
                    MiddleName = customer.MiddleName,
                    LastName = customer.LastName,
                    IdentityNo = customer.IdentityNo,
                    DOB = customer.DOB,
                    MaritalStatus = customer.MaritalStatus,
                    Gender = customer.Gender,
                    Race = customer.Race,
                    Nation = customer.Nation,
                    Occupation = customer.Occupation,
                    PhoneNumber = customer.PhoneNumber,
                    HPNum = customer.HPNum,
                    EmailAddress = customer.EmailAddress,
                    Password = customer.Password,
                    Password_WEB = customer.Password_WEB,
                    BlockHouseNo = customer.BlockHouseNo,
                    UnitNo = customer.UnitNo,
                    Address1 = customer.Address1,
                    Address2 = customer.Address2,
                    City = customer.City,
                    State = customer.State,
                    Country = customer.Country,
                    Zip = customer.Zip,
                    CategoryID = customer.CategoryID,
                    StoreID = customer.StoreID,
                    AcceptSMS = customer.AcceptSMS,
                    AcceptMailEmail = customer.AcceptMailEmail
                },
                IsReadOnly = false
            };
        }
    }
}