namespace ThyUcusArama.Models.GetPortList
{
    public class PortListResponse
    {
        public string Status { get; set; }
        public PortListData Data { get; set; }
    }

    public class PortListData
    {
        public List<Port> Port { get; set; }
    }

    public class Port
    {
        public string Code { get; set; }
        public City City { get; set; }
    }

    public class City
    {
        public LanguageInfo LanguageInfo { get; set; }
    }

    public class LanguageInfo
    {
        public List<Language> Language { get; set; }
    }

    public class Language
    {
        public string Name { get; set; }
    }
}