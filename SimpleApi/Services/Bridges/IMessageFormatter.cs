namespace SimpleApi.Services.Bridges;

// Implementor
public interface IMessageFormatter
{
    string Format(string body);
}