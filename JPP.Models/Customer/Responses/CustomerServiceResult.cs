using JPP.Models.Shared.Responses;

namespace JPP.Models.Customer.Responses
{
    public class CustomerServiceResult : BaseResult
    {
        public List<CustomerListDto>? Data { get; set; }

        public new static CustomerServiceResult Ok(
            List<CustomerListDto>? data = null,
            string statusMessage = "Success",
            int statusCode = 200)
        {
            return new CustomerServiceResult
            {
                StatusCode = statusCode,
                StatusMessage = statusMessage,
                Data = data
            };
        }

        public new static CustomerServiceResult Fail(string statusMessage, int statusCode = 400)
        {
            return new CustomerServiceResult
            {
                StatusCode = statusCode,
                StatusMessage = statusMessage
            };
        }
    }
}