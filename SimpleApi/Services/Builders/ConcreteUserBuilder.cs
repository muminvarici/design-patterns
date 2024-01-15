using SimpleApi.Models;

namespace SimpleApi.Services.Builders;

/// Concrete builder
public class ConcreteUserBuilder : IUserBuilder
{
    private readonly User _user = new();

    public IUserBuilder SetName(string firstName)
    {
        _user.Name = firstName;
        return this;
    }

    public IUserBuilder SetEmailName(string email)
    {
        _user.Email = email;
        return this;
    }

    // Additional methods for other properties...

    public User Build()
    {
        return _user;
    }
}