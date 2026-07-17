using JPP.Models.Shared.Requests;

namespace JPP.Models.Event.Request
{
    public class EventListFilterRequest : PaginationRequest
    {
        public string? Keyword { get; set; }

    }
}