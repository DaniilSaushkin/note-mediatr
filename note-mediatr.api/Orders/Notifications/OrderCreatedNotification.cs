using MediatR;

namespace note_mediatr.api.Orders.Notifications
{
    public record OrderCreatedNotification(Guid id, string customerName) : INotification;
}
