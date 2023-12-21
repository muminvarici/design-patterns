using SimpleApi.Models;

namespace SimpleApi.Services;


// Concrete Product 1: SQL Server
public class SqlUserRepository : IUserRepository
{
    public void Save(User user)
    {
        // Logic to save user to SQL Server
    }

    public User GetById(int userId)
    {
        // Logic to retrieve user from SQL Server
        return new User();
    }
}