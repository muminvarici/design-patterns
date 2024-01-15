using System.Net.Mime;

namespace SimpleApi.Services.Adapters;

public class DataAdapterFactory : IDataAdapterFactory
{
    public IDataAdapter CreateAdapter(string contentType)
    {
        if (contentType.Contains(MediaTypeNames.Application.Json))
        {
            return new JsonAdapter();
        }
        
        if (contentType.Contains(MediaTypeNames.Application.Xml))
        {
            return new XmlAdapter();
        }
        
        throw new NotSupportedException("Unsupported content type");
    }
}