using SimpleApi.Models;
using SimpleApi.Services.Abstractions;

namespace SimpleApi.Services.Decorators;

/// Concrete Decorator for Logging
public class LoggingUserServiceDecorator : IUserService
{
    private readonly IUserService _userService;
    private readonly ILogger _logger;

    public LoggingUserServiceDecorator(IUserService userService, ILogger logger)
    {
        _userService = userService;
        _logger = logger;
    }

    public User SaveUser(string firstName, string lastName)
    {
        _logger.LogInformation("Saving user: {firstName} {lastName}", firstName, lastName);
        var user = _userService.SaveUser(firstName, lastName);
        _logger.LogInformation("User saved successfully.");
        return user;
    }

    public async Task<User?> GetUserById(int userId)
    {
        _logger.LogInformation("Retrieving user with ID: {userId}", userId);
        var user = await _userService.GetUserById(userId);
        _logger.LogInformation("User retrieved: {userId} {firstName} {lastName}", userId, user?.Name, user?.Username);
        return user;
    }

    public async Task<User?> CreateUser(User user)
    {
        _logger.LogInformation("Retrieving user with ID: @{userId}", user);
        var result = await _userService.CreateUser(user);
        _logger.LogInformation("User retrieved: {userId} {firstName} {lastName}", result!.Id, result.Name, result?.Username);
        return result;
    }
}