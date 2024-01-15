using SimpleApi.Services.Repositories;

namespace SimpleApi.Services.DataAccess;

/// Concrete Factory 1: External Service Factory
public class ExternalDataAccessFactory : IDataAccessFactory
{
    private readonly IServiceProvider _serviceProvider;

    public ExternalDataAccessFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    /// Factory method
    public IUserRepository CreateUserRepository()
    {
        return _serviceProvider.GetRequiredService<ExternalUserRepository>();
    }
}