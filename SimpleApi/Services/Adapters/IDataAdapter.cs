namespace SimpleApi.Services.Adapters;

public interface IDataAdapter
{
    T? Deserialize<T>(string data);
}