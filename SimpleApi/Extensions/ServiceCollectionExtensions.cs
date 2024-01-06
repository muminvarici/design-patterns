using SimpleApi.Services;
using SimpleApi.Services.Abstractions;
using SimpleApi.Services.Builders;
using SimpleApi.Services.DataAccess;
using SimpleApi.Services.Decorators;
using SimpleApi.Services.Repositories;

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
        services.AddScoped<IUserService>(serviceProvider =>
        {
            var decoratedUserService = CreateUserDecorators(serviceProvider);
            return decoratedUserService;
        });

        services.AddScoped<IUserBuilder, ConcreteUserBuilder>();
        return services;
    }


    private static IUserService CreateUserDecorators(IServiceProvider serviceProvider) // Factory method to produce user service decorators
    {
        var userService = serviceProvider.GetRequiredService<UserService>();
        var loggingService = new LoggingUserServiceDecorator(userService, serviceProvider.GetRequiredService<ILogger<LoggingUserServiceDecorator>>());
        var cachingService = new CachingUserServiceDecorator(loggingService, serviceProvider.GetRequiredService<ILogger<CachingUserServiceDecorator>>());
        return cachingService;
    }
}