using System.Xml.Serialization;

namespace SimpleApi.Services.Adapters;

public class XmlAdapter : IDataAdapter
{
    public T Deserialize<T>(string data)
    {
        var serializer = new XmlSerializer(typeof(T));

        using var reader = new StringReader(data);
        return (T)serializer.Deserialize(reader)!;
    }
}