namespace SimpleApi.Services;

public class ApplicationLogger : ILogger
{
    // Singleton instance
    private static ApplicationLogger? _instance;

    // Lock object for thread safety
    private static readonly object LockObject = new();

    // Private constructor to prevent instantiation
    private ApplicationLogger()
    {
    }

    // Public method to get or create the singleton instance
    public static ApplicationLogger GetInstance()
    {
        if (_instance != null) return _instance;

        lock (LockObject)
        {
            _instance ??= new ApplicationLogger();
        }

        return _instance;
    }

    // Implement the ILogger methods
    public IDisposable? BeginScope<TState>(TState state) where TState : notnull
    {
        return null;
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        // Customize the log level based on your requirements
        return true;
    }

    public void Log<TState>(
        LogLevel logLevel,
        EventId eventId,
        TState state,
        Exception? exception,
        Func<TState, Exception?, string> formatter)
    {
        // Implement the actual logging logic here
        Console.WriteLine($"{logLevel}: {formatter(state, exception)}");
    }
}