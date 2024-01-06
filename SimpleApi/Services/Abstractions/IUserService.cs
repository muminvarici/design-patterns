using SimpleApi.Models;

namespace SimpleApi.Services.Abstractions;

/// Component interface
public interface IUserService
{
    User SaveUser(string firstName, string lastName, int age);
    User? GetUserById(int userId);
}