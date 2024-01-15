using SimpleApi.Models;

namespace SimpleApi.Services.Repositories;

/// Concrete Product 2: MongoDB
public class MongoUserRepository : IUserRepository
{
    public Task Save(User user)
    {
        // Logic to save user to MongoDB
        throw new NotImplementedException();
    }

    public Task<User?> GetById(int userId)
    {
        // Logic to retrieve user from MongoDB
        throw new NotImplementedException();
    }
}