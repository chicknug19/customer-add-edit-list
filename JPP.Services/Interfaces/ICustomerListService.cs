using JPP.Models.Customer.Responses;

namespace JPP.Services.Interfaces
{
    public interface ICustomerListService
    {
        Task<CustomerServiceResult> GetCustomerListAsync();
    }
}