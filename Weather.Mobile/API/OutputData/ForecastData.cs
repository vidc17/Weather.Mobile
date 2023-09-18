using System.Xml.Serialization;

namespace Weather.Mobile.API.OutputData
{
    [XmlRoot("data")]
    public class ForecastData
    {
        [XmlElement("metData")]
        public List<ForecastItemData> Days { get; set; }
    }
}