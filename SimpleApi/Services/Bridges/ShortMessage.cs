namespace SimpleApi.Services.Bridges;

// Refined Abstraction
public class ShortMessage : MessageBase
{
    public ShortMessage(IMessageSender messageSender, IMessageFormatter messageFormatter)
        : base(messageSender, messageFormatter)
    {
    }

    public override void Send(string body)
    {
        var formattedBody = MessageFormatter.Format(body);
        MessageSender.SendMessage(formattedBody);
    }
}