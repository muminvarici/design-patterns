using SimpleApi.Models;
using SimpleApi.Services.Builders;
using SimpleApi.Services.DataAccess;

namespace SimpleApi.Services;

// Service using Abstract Factory
public class UserService
{
    // Abstract Factory injected through constructor
    private readonly IUserRepository _userRepository;
    private readonly IUserBuilder _userBuilder;

    // Abstract Factory and Builder injected through constructor
    public UserService(IDataAccessFactory dataAccessFactory, IUserBuilder userBuilder)
    {
        _userRepository = dataAccessFactory.CreateUserRepository();
        _userBuilder = userBuilder;
    }

    public void SaveUser(string firstName, string lastName, int age)
    {
        // Use the builder to construct the User object
        var user = _userBuilder
            .SetFirstName(firstName)
            .SetLastName(lastName)
            .SetAge(age)
            .Build();

        // Save the user using the repository
        _userRepository.Save(user);
    }

    public User GetUserById(int userId)
    {
        return _userRepository.GetById(userId);
    }
}