using Refit;
using SimpleApi.Models;

namespace SimpleApi.Services.Facades;

public interface IUsersApi
{
    [Get("/users")]
    Task<IEnumerable<User>> GetAllUsers();
}