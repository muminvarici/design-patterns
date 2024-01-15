using SimpleApi.Models;
using SimpleApi.Services.Abstractions;
using SimpleApi.Services.Builders;
using SimpleApi.Services.DataAccess;
using SimpleApi.Services.Repositories;

namespace SimpleApi.Services;

//// Service using Abstract Factory
public class UserService : IUserService
{
    private readonly IUserBuilder _userBuilder;

    /// Abstract Factory injected through constructor
    private readonly IUserRepository _userRepository;

    /// Abstract Factory and Builder injected through constructor
    /// Factory Method injected through constructor
    public UserService(IDataAccessFactory dataAccessFactory, IUserBuilder userBuilder)
    {
        _userRepository = dataAccessFactory.CreateUserRepository();
        _userBuilder = userBuilder;
    }

    public User SaveUser(string firstName, string lastName, int age)
    {
        // Use the builder to construct the User object
        var user = _userBuilder
            .SetName(firstName)
            .SetEmailName(lastName)
            .Build();

        // Save the user using the repository
        _userRepository.Save(user);
        return user;
    }

    public Task<User?> GetUserById(int userId)
    {
        return _userRepository.GetById(userId);
    }

    public User CloneUser(User prototypeUser)
    {
        // Clone the prototype to create a new instance with the same properties
        var clonedUser = (User)prototypeUser.Clone();
        clonedUser.Id = 0;
        _userRepository.Save(clonedUser);
        return clonedUser;
    }
}