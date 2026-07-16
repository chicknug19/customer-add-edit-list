using JPP.Models.Customer.Responses.CustomerDto;

namespace JPP.Data.Interfaces
{
    public interface ICustomerEditRepository
    {
        Task<CustomerDto?> GetCustomerByIdAsync(int id);
    }
}