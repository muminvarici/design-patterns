namespace SimpleApi.Services.DataAccess;

// Concrete Factory 1: SQL Server Factory
public class SqlDataAccessFactory : IDataAccessFactory
{
    public IUserRepository CreateUserRepository()
    {
        return new SqlUserRepository();
    }
}