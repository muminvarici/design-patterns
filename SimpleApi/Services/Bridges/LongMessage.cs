namespace SimpleApi.Services.Bridges;

// Refined Abstraction
public class LongMessage : MessageBase
{
    public LongMessage(IMessageSender messageSender, IMessageFormatter messageFormatter)
        : base(messageSender, messageFormatter)
    {
    }

    public override void Send(string body)
    {
        var formattedBody = MessageFormatter.Format(body);
        MessageSender.SendMessage(formattedBody);
    }
}