using SimpleApi.Models;
using SimpleApi.Services.Abstractions;

namespace SimpleApi.Services.Decorators;

/// Concrete Decorator for Logging
public class LoggingUserServiceDecorator : IUserService
{
    private readonly IUserService _userService;
    private readonly ILogger<LoggingUserServiceDecorator> _logger;

    public LoggingUserServiceDecorator(IUserService userService, ILogger<LoggingUserServiceDecorator> logger)
    {
        _userService = userService;
        _logger = logger;
    }

    public User SaveUser(string firstName, string lastName, int age)
    {
        _logger.LogInformation("Saving user: {firstName} {lastName}", firstName, lastName);
        var user = _userService.SaveUser(firstName, lastName, age);
        _logger.LogInformation("User saved successfully.");
        return user;
    }

    public User? GetUserById(int userId)
    {
        _logger.LogInformation("Retrieving user with ID: {userId}", userId);
        var user = _userService.GetUserById(userId);
        _logger.LogInformation("User retrieved: {firstName} {lastName}", user?.FirstName, user?.LastName);
        return user;
    }
}