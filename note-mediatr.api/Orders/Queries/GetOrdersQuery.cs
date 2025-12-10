using MediatR;
using note_mediatr.api.Dto;

namespace note_mediatr.api.Orders.Queries
{
    public class GetOrdersQuery : IRequest<List<Order>>;
}
