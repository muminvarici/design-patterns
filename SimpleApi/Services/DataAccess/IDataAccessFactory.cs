namespace SimpleApi.Services.DataAccess;

// Abstract Factory Interface
public interface IDataAccessFactory
{
    IUserRepository CreateUserRepository();
}