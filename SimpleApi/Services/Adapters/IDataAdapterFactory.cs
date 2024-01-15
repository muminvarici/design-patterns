namespace SimpleApi.Services.Adapters;

public interface IDataAdapterFactory
{
    IDataAdapter CreateAdapter(string contentType);
}