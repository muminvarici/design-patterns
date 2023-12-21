using SimpleApi.Services;
using SimpleApi.Services.DataAccess;

namespace SimpleApi.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IDataAccessFactory, MongoDataAccessFactory>();
        services.AddScoped<IDataAccessFactory, SqlDataAccessFactory>();

        services.AddScoped<IUserRepository, SqlUserRepository>();
        services.AddScoped<IUserRepository, MongoUserRepository>();
        
        services.AddScoped<UserService>();

        return services;
    }
}