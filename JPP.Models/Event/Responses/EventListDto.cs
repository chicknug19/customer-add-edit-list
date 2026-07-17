namespace JPP.Models.Event.Responses
{
    public class EventListDto
    {
        public int EventId { get; set; }
        public string EventName { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}