using SimpleApi.Models;

namespace SimpleApi.Services.Abstractions;

/// Component interface
public interface IUserService
{
    User SaveUser(string firstName, string lastName, int age);
    Task<User?> GetUserById(int userId);
}