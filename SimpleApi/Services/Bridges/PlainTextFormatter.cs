namespace SimpleApi.Services.Bridges;

// Concrete Implementor 1
public class PlainTextFormatter : IMessageFormatter
{
    public string Format(string body)
    {
        return $"PlainText: {body}";
    }
}