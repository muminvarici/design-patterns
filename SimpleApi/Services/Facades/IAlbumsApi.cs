using Refit;
using SimpleApi.Models;

namespace SimpleApi.Services.Facades;

public interface IAlbumsApi
{
    [Get("/albums")]
    Task<IEnumerable<Album>> GetAllAlbums();
}