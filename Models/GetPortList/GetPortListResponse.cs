using System.Collections.Generic;

namespace ThyUcusArama.Models.GetPortList
{
    public class GetPortListResponse
    {
        public string Status { get; set; }
        public ResponseMessage Message { get; set; }
        public PortListData Data { get; set; }
    }

    public class ResponseMessage
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class PortListData
    {
        public List<Port> Port { get; set; }
    }

    public class Port
    {
        public bool IsDomestic { get; set; }
        public bool IsSPA { get; set; }
        public LanguageInfo LanguageInfo { get; set; }
        public PortTag PortTag { get; set; }
        public bool validForAwardTicket { get; set; }
        public Coordinate Coordinate { get; set; }
        public Country Country { get; set; }
        public Region Region { get; set; }
        public bool HasComfort { get; set; }
        public City City { get; set; }
        public string Code { get; set; }
    }

    public class LanguageInfo
    {
        public List<Language> Language { get; set; }
    }

    public class Language
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class PortTag
    {
        public List<PortTagLanguage> PortTagLanguage { get; set; }
    }

    public class PortTagLanguage
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class Coordinate
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

    public class Country
    {
        public LanguageInfo LanguageInfo { get; set; }
        public string Code { get; set; }
    }

    public class Region
    {
        public LanguageInfo LanguageInfo { get; set; }
        public string code { get; set; }
    }

    public class City
    {
        public LanguageInfo LanguageInfo { get; set; }
        public PortsInCity PortsInCity { get; set; }
        public string Code { get; set; }
    }

    public class PortsInCity
    {
        public List<CityPort> Port { get; set; }
    }
    public class CityPort
    {
        public string Code { get; set; }
    }
}