using System.Xml;
using System.Xml.Serialization;

namespace Weather.Mobile.Services
{
    public class XmlService
    {
        public T CreateObjectFromXml<T>(string xmlText)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using var xmlReader = XmlReader.Create(new StringReader(xmlText));
            return (T)xmlSerializer.Deserialize(xmlReader);
        }
    }
}
