using MediatR;

namespace note_mediatr.api.Notifications
{
    public record OrderCreatedNotification(Guid id, string customerName) : INotification;
}
