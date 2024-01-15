namespace SimpleApi.Services.Bridges;

// Abstraction
public abstract class MessageBase
{
    protected readonly IMessageSender MessageSender;
    protected readonly IMessageFormatter MessageFormatter;

    protected MessageBase(IMessageSender messageSender, IMessageFormatter messageFormatter)
    {
        MessageSender = messageSender;
        MessageFormatter = messageFormatter;
    }

    public abstract void Send(string body);
}