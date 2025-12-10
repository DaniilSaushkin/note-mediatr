using MediatR;
using note_mediatr.api.Dto;

namespace note_mediatr.api.Orders.Commands
{
    public class MarkOrderAsPaidCommand : IRequest<Order>
    {
        public Guid Id { get; init; }
    }
}
