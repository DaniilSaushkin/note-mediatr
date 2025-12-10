using MediatR;
using System.Diagnostics;

namespace note_mediatr.api.Behaviors
{
    public class LoggingBehavior<TRequest, TResponse>(ILogger<LoggingBehavior<TRequest, TResponse>> logger) : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly ILogger<LoggingBehavior<TRequest, TResponse>> _logger = logger;

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling {RequestName} with content: {@Request}", typeof(TRequest).Name, request);
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            var response = await next(cancellationToken);
            stopwatch.Stop();

            if (stopwatch.ElapsedMilliseconds > 100)
                _logger.LogWarning("Request processing too much time");

            _logger.LogInformation("Handled {RequestName} -> {@Response}", typeof(TRequest).Name, response);
            return response;
        }
    }
}
