namespace SimpleApi.Services.Bridges;

// Concrete Implementor 2
public class HtmlFormatter : IMessageFormatter
{
    public string Format(string body)
    {
        return $"HTML: {body}";
    }
}