using SimpleApi.Models;
using SimpleApi.Services.Abstractions;
using SimpleApi.Services.Bridges;

namespace SimpleApi.Services.Decorators;

public class NotificationUserServiceDecorator : IUserService
{
    private readonly IUserService _userService;
    private readonly ILogger _logger;

    public NotificationUserServiceDecorator(IUserService userService, ILogger logger)
    {
        _userService = userService;
        _logger = logger;
    }

    public User SaveUser(string firstName, string lastName)
    {
        return _userService.SaveUser(firstName, lastName);
    }

    public Task<User?> GetUserById(int userId)
    {
        return _userService.GetUserById(userId);
    }

    public async Task<User?> CreateUser(User user)
    {
        var result = await _userService.CreateUser(user);

        /*
         the MessageBase abstraction is separated from its implementations (ShortMessage and LongMessage).
         The IMessageSender and IMessageFormatter interfaces define the bridge between the abstraction and its concrete implementations
         */

        // Using Email with PlainText
        var emailPlainTextMessage = new LongMessage(new EmailMessageSender(_logger), new HtmlFormatter());
        emailPlainTextMessage.Send("This is a notification built as long email message with HTML formatting.");

        // Using SMS with HTML
        var smsHtmlMessage = new ShortMessage(new SmsMessageSender(_logger), new PlainTextFormatter());
        smsHtmlMessage.Send("This is a notification built as short SMS message in plain text.");

        return result;
    }
}