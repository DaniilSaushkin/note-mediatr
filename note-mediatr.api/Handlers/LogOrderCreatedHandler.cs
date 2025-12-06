using MediatR;
using note_mediatr.api.Notifications;

namespace note_mediatr.api.Handlers
{
    public class LogOrderCreatedHandler(ILogger<LogOrderCreatedHandler> logger) : INotificationHandler<OrderCreatedNotification>
    {
        private readonly ILogger<LogOrderCreatedHandler> _logger = logger;

        public Task Handle(OrderCreatedNotification notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Order created: {notificationId} - {notificationCustomerName}", notification.id, notification.customerName);

            return Task.CompletedTask;
        }
    }
}
