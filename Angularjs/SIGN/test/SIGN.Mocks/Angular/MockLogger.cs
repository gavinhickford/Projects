using Microsoft.Extensions.Logging;
using SIGN.Angular.Controllers.Api;
using System;

namespace SIGN.Mocks.Angular
{
    public class MockLogger : ILogger<GuidelineController>
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            return;
        }
    }
}
