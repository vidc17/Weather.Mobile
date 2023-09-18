using System.Xml.Serialization;

namespace Weather.Mobile.API.OutputData
{
    [XmlRoot("metData")]
    public class ForecastItemData
    {
        [XmlElement("valid_day")]
        public string Day { get; set; }
        
        [XmlElement("valid")]
        public string Date { get; set; }

        [XmlElement("nn_icon")]
        public string SkyVisibility { get; set; }
        
        [XmlElement("wwsyn_icon")]
        public string WeatherPhenomenon { get; set; }

        [XmlElement("tnsyn")]
        public string MinimumTemperature { get; set; }

        [XmlElement("txsyn")]
        public string MaximumTemperature { get; set; }

        [XmlElement("tn")]
        public string MinimumTemperatureCountry { get; set; }

        [XmlElement("tx")]
        public string MaximumTemperatureCountry { get; set; }

        [XmlElement("dd_longText")]
        public string WindDirection { get; set; }

        [XmlElement("ff_minimum")]
        public string WindSpeedMinimum { get; set; }

        [XmlElement("ff_maximum")]
        public string WindSpeedMaximum { get; set; }
    }
}
