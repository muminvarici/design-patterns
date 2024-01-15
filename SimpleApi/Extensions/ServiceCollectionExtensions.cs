using SimpleApi.Services;
using SimpleApi.Services.Abstractions;
using SimpleApi.Services.Adapters;
using SimpleApi.Services.Builders;
using SimpleApi.Services.DataAccess;
using SimpleApi.Services.Decorators;
using SimpleApi.Services.Repositories;

namespace SimpleApi.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<MongoDataAccessFactory>();
        services.AddScoped<SqlDataAccessFactory>();
        services.AddScoped<ExternalDataAccessFactory>();
        services.AddScoped<IDataAccessFactory>((service) =>
        {
            //todo write some logic to inject services
            return service.GetRequiredService<ExternalDataAccessFactory>();
        });

        services.AddScoped<IUserRepository, SqlUserRepository>();
        services.AddScoped<IUserRepository, MongoUserRepository>();
        var uri = new Uri("http://78.135.86.41:5216");
        services.AddHttpClient<ExternalUserRepository>(client => client.BaseAddress = uri);
        services.AddScoped<IUserRepository, ExternalUserRepository>();

        services.AddScoped<UserService>();
        services.AddScoped<IUserService>(serviceProvider =>
        {
            var decoratedUserService = CreateUserDecorators(serviceProvider);
            return decoratedUserService;
        });

        services.AddScoped<IUserBuilder, ConcreteUserBuilder>();


        // Register the ILogger interface with the ApplicationLogger implementation
        services.AddSingleton<ILogger>(_ => ApplicationLogger.GetInstance());

        services.AddSingleton<IDataAdapterFactory, DataAdapterFactory>();

        return services;
    }


    private static IUserService CreateUserDecorators(IServiceProvider serviceProvider) // Factory method to produce user service decorators
    {
        var userService = serviceProvider.GetRequiredService<UserService>();
        var loggingService = new LoggingUserServiceDecorator(userService, serviceProvider.GetRequiredService<ILogger>());
        var cachingService = new CachingUserServiceDecorator(loggingService, serviceProvider.GetRequiredService<ILogger>());
        var notification = new NotificationUserServiceDecorator(cachingService, serviceProvider.GetRequiredService<ILogger>());
        return notification;
    }
}