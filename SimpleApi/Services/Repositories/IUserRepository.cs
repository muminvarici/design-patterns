using SimpleApi.Models;

namespace SimpleApi.Services.Repositories;

/// Abstract Product Interface
public interface IUserRepository
{
    Task Save(User user);
    Task<User?> GetById(int userId);
}