namespace SimpleApi.Services.Bridges;

// Concrete Implementor 1
public class EmailMessageSender : IMessageSender
{
    private readonly ILogger _logger;

    public EmailMessageSender(ILogger logger)
    {
        _logger = logger;
    }

    public void SendMessage(string message)
    {
        _logger.LogWarning("Sending email: {message}", message);
    }
}