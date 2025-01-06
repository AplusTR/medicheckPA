namespace ThyUcusArama.Models.GetPortList
{
    public class GetPortListRequest
    {
        public RequestHeader RequestHeader { get; set; }
        public List<ExtraParameter> extraParameters { get; set; }
        public GetPortsOTARequest getPortsOTARequest { get; set; }
    }

    public class RequestHeader
    {
        public string clientUsername { get; set; } = "OPENAPI";
        public string clientTransactionId { get; set; }
        public string channel { get; set; } = "WEB";
        public string languageCode { get; set; } = "TR";
        public string airlineCode { get; set; } = "TK";
        public string clientCode { get; set; }
        public string application { get; set; }
        public string agent { get; set; }
        public string agencyOfficeCode { get; set; }
        public string userAgencyCode { get; set; }
        public string agencyCode { get; set; }
        public string dutyCode { get; set; }
        public int? Ton { get; set; }
        public string Currency { get; set; }
    }

    public class ExtraParameter
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class GetPortsOTARequest
    {
        public string AirlineCode { get; set; }
        public string languageCode { get; set; }
    }
}