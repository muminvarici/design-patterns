namespace SimpleApi.Services.Bridges;

// Concrete Implementor 2
public class SmsMessageSender : IMessageSender
{
    private readonly ILogger _logger;

    public SmsMessageSender(ILogger logger)
    {
        _logger = logger;
    }

    public void SendMessage(string message)
    {
        _logger.LogWarning("Sending SMS: {message}", message);
    }
}