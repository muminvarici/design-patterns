using SimpleApi.Models;

namespace SimpleApi.Services.Builders;

/// Builder interface
public interface IUserBuilder
{
    IUserBuilder SetName(string firstName);
    IUserBuilder SetEmailName(string email);

    // Additional methods for other properties...
    User Build();
}