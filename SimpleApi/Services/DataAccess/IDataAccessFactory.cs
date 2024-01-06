using SimpleApi.Services.Repositories;

namespace SimpleApi.Services.DataAccess;

/// Abstract Factory Interface
public interface IDataAccessFactory
{
    /// Factory method
    IUserRepository CreateUserRepository();
}