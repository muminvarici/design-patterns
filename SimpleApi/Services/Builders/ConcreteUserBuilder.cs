using SimpleApi.Models;

namespace SimpleApi.Services.Builders;

// Concrete builder
public class ConcreteUserBuilder : IUserBuilder
{
    private readonly User _user = new User();

    public IUserBuilder SetFirstName(string firstName)
    {
        _user.FirstName = firstName;
        return this;
    }

    public IUserBuilder SetLastName(string lastName)
    {
        _user.LastName = lastName;
        return this;
    }

    public IUserBuilder SetAge(int age)
    {
        _user.Age = age;
        return this;
    }

    // Additional methods for other properties...

    public User Build()
    {
        return _user;
    }
}