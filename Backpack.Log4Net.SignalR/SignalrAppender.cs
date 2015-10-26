using log4net.Appender;
using log4net.Core;
using Microsoft.AspNet.SignalR;

namespace Backpack.Log4Net.SignalR
{
    public class SignalrAppender : AppenderSkeleton
    {
        protected override void Append(LoggingEvent loggingEvent)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<SignalrAppenderHub>();
            if (hubContext == null) return;

            var @event = new {
                loggingEvent.Domain,
                Exception = loggingEvent.GetExceptionString(),
                loggingEvent.Identity,
                Level = loggingEvent.Level.Name,
                Logger = loggingEvent.LoggerName,
                Message = loggingEvent.RenderedMessage,
                FormattedMessage = RenderLoggingEvent(loggingEvent),
                Thread = loggingEvent.ThreadName,
                Timestamp = loggingEvent.TimeStamp,
                Username = loggingEvent.UserName
            };

            hubContext.Clients.All.onLogging(@event);
        }
    }
}