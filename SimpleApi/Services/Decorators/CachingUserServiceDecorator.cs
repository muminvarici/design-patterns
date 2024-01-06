using SimpleApi.Models;
using SimpleApi.Services.Abstractions;

namespace SimpleApi.Services.Decorators;

/// Concrete Decorator for Caching
public class CachingUserServiceDecorator : IUserService
{
    private readonly Dictionary<int, User> _cache = new();
    private readonly IUserService _userService;
    private readonly ILogger _logger;

    public CachingUserServiceDecorator(IUserService userService, ILogger logger)
    {
        _userService = userService;
        _logger = logger;
    }

    public User SaveUser(string firstName, string lastName, int age)
    {
        var user = _userService.SaveUser(firstName, lastName, age);
        // Add the user to the cache
        _cache[user.Id] = user;

        return user;
    }

    public User? GetUserById(int userId)
    {
        // Try to get the user from the cache
        if (_cache.TryGetValue(userId, out var cachedUser))
        {
            _logger.LogInformation("User retrieved from cache.");
            return cachedUser;
        }

        // If not in the cache, fetch from the underlying service
        var user = _userService.GetUserById(userId);
        if (user == null)
            return null; //todo handle this (throw or implement result pattern)

        // Add to the cache for future use
        _cache[userId] = user;

        return user;
    }
}