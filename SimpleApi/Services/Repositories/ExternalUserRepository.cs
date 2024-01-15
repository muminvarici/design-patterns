using System.Text.Json;
using SimpleApi.Models;
using SimpleApi.Services.Adapters;

namespace SimpleApi.Services.Repositories;

public class ExternalUserRepository : IUserRepository
{
    private readonly HttpClient _httpClient;
    private readonly IDataAdapter _dataAdapter;
    private const string ContentType = "application/xml";

    public ExternalUserRepository(HttpClient httpClient, IDataAdapterFactory dataAdapterFactory)
    {
        _httpClient = httpClient;
        _dataAdapter = dataAdapterFactory.CreateAdapter(ContentType);
    }

    public async Task<User?> Save(User user)
    {
        var request = new HttpRequestMessage(HttpMethod.Post, "api/v1/Users");
        request.Headers.Add("accept", ContentType);
        var content = new StringContent(JsonSerializer.Serialize(user), null, "application/json");
        request.Content = content;
        var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();
        var responseContent = await response.Content.ReadAsStringAsync();
        var result = _dataAdapter.Deserialize<User>(responseContent);
        return result;
    }

    public async Task<User?> GetById(int userId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"api/v1/Users/{userId}");
        request.Headers.Add("accept", ContentType);
        var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        return _dataAdapter.Deserialize<User>(content);
    }
}