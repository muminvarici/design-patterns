using Refit;
using SimpleApi.Models;

namespace SimpleApi.Services.Facades;

public interface ICommentsApi
{
    [Get("/comments")]
    Task<IEnumerable<Comment>> GetAllComments();
}