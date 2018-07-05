using System.IO;

namespace AutoTraderEmailer.Core
{
    public class XmlSerializer
    {
        public T DeserializeFromString<T>(string xmlString) where T : class
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (TextReader reader = new StringReader(xmlString))
            {
                return (T)serializer.Deserialize(reader);
            }  
        }

        public T DeserializeFromPath<T>(string path) where T : class
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (var reader = new StreamReader(path))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}
