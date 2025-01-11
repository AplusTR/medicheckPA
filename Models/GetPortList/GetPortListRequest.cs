namespace ThyUcusArama.Models.GetPortList
{
    public class GetPortListRequest
    {
        public RequestHeader RequestHeader { get; set; }
    }

    public class RequestHeader
    {
        public string ClientUsername { get; set; } = "OPENAPI";
        public string ClientTransactionId { get; set; } = Guid.NewGuid().ToString();
    }
}