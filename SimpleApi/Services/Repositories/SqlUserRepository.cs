using SimpleApi.Models;

namespace SimpleApi.Services.Repositories;

/// Concrete Product 1: SQL Server
public class SqlUserRepository : IUserRepository
{
    public Task<User?> Save(User user)
    {
        // Logic to save user to SQL Server
        throw new NotImplementedException();
    }

    public Task<User?> GetById(int userId)
    {
        // Logic to retrieve user from SQL Server
        throw new NotImplementedException();
    }
}