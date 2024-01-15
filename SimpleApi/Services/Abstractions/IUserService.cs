using SimpleApi.Models;

namespace SimpleApi.Services.Abstractions;

/// Component interface
public interface IUserService
{
    User SaveUser(string firstName, string lastName);
    Task<User?> GetUserById(int userId);
    Task<User?> CreateUser(User user);
}