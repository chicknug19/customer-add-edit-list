using JPP.Models.Shared.Responses;
using System.Collections.Generic;

namespace JPP.Models.Event.Responses
{
    public class EventListServiceResult : BaseResult
    {
        public List<EventListDto>? Data { get; set; }

        public new static EventListServiceResult Ok(
            List<EventListDto>? data = null,
            string statusMessage = "Success",
            int statusCode = 200)
        {
            return new EventListServiceResult
            {
                StatusCode = statusCode,
                StatusMessage = statusMessage,
                Data = data
            };
        }

        public new static EventListServiceResult Fail(string statusMessage, int statusCode = 400)
        {
            return new EventListServiceResult
            {
                StatusCode = statusCode,
                StatusMessage = statusMessage
            };
        }
    }
}