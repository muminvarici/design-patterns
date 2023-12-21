using SimpleApi.Models;
using SimpleApi.Services.DataAccess;

namespace SimpleApi.Services;

// Service using Abstract Factory
public class UserService
{
    private readonly IUserRepository _userRepository;

    // Abstract Factory injected through constructor
    public UserService(IDataAccessFactory dataAccessFactory)
    {
        _userRepository = dataAccessFactory.CreateUserRepository();
    }

    public void SaveUser(User user)
    {
        _userRepository.Save(user);
    }

    public User GetUserById(int userId)
    {
        return _userRepository.GetById(userId);
    }
}