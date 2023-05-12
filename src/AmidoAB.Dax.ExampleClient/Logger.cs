// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Logger.cs" company="Amido AB">
//   Copyright © 2023 Amido AB. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Microsoft.Extensions.Logging;

namespace AmidoAB.Dax.ExampleClient;

internal class Logger : ILogger
{
    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception,
        Func<TState, Exception, string> formatter)
    {
        var level = logLevel.ToString().Substring(0, 3).ToUpper();
        var ts = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        var msg = formatter(state, exception);

        Console.WriteLine($"[{ts}] [{level}] {msg}");
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        return true;
    }

    public IDisposable BeginScope<TState>(TState state)
    {
        return null;
    }
}