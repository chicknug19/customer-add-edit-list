using JPP.Models.Customer.Responses;

namespace JPP.Services.Interfaces
{
    public interface ICustomerEditService
    {
        Task<CustomerDetailViewModel?> BuildEditViewModelAsync(int id);
    }
}