namespace SimpleApi.Services.DataAccess;

// Concrete Factory 2: MongoDB Factory
public class MongoDataAccessFactory : IDataAccessFactory
{
    // Factory method
    public IUserRepository CreateUserRepository()
    {
        return new MongoUserRepository();
    }
}