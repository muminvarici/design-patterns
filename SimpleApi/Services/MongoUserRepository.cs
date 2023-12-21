using SimpleApi.Models;

namespace SimpleApi.Services;

// Concrete Product 2: MongoDB
public class MongoUserRepository : IUserRepository
{
    public void Save(User user)
    {
        // Logic to save user to MongoDB
    }

    public User GetById(int userId)
    {
        // Logic to retrieve user from MongoDB
        return new User();
    }
}