using System.Text.Json;

namespace SimpleApi.Services.Adapters;

public class JsonAdapter : IDataAdapter
{
    public T? Deserialize<T>(string data)
    {
        return JsonSerializer.Deserialize<T>(data);
    }
}