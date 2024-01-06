using SimpleApi.Models;

namespace SimpleApi.Services.Builders;

/// Builder interface
public interface IUserBuilder
{
    IUserBuilder SetFirstName(string firstName);
    IUserBuilder SetLastName(string lastName);

    IUserBuilder SetAge(int age);

    // Additional methods for other properties...
    User Build();
}