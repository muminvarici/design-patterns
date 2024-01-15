using Refit;
using SimpleApi.Models;

namespace SimpleApi.Services.Facades;

public interface IPostsApi
{
    [Get("/posts")]
    Task<IEnumerable<Post>> GetAllPosts();
}