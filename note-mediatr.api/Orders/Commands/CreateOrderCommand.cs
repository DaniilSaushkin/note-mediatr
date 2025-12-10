using MediatR;
using note_mediatr.api.Dto;

namespace note_mediatr.api.Orders.Commands
{
    public class CreateOrderCommand : IRequest<Order>
    {
        public required string? CustomerName { get; init; }
        public decimal Amount { get; init; }
    }
}
