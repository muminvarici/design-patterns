using Refit;
using SimpleApi.Models;

namespace SimpleApi.Services.Facades;

public interface IPhotosApi
{
    [Get("/photos")]
    Task<IEnumerable<Photo>> GetAllPhotos();
}