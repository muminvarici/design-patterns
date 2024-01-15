using SimpleApi.Models;

namespace SimpleApi.Services.Repositories;

/// Abstract Product Interface
public interface IUserRepository
{
    Task<User?> Save(User user);
    Task<User?> GetById(int userId);
}