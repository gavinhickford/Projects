using Microsoft.Extensions.Logging;
using SIGN.MVC.Controllers.Web;
using System;

namespace SIGN.Mocks.MVC
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
