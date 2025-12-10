using MediatR;
using note_mediatr.api.Dto;
using note_mediatr.api.Orders.Commands;
using note_mediatr.api.Repositories;

namespace note_mediatr.api.Orders.Handlers
{
    public class MarkOrderAsPaidHandler(OrderRepository orderRepository) : IRequestHandler<MarkOrderAsPaidCommand, Order>
    {
        private readonly OrderRepository _orderRepository = orderRepository;

        public Task<Order> Handle(MarkOrderAsPaidCommand request, CancellationToken cancellationToken)
        {
            Order order = _orderRepository.GetOrderById(request.Id);
            order.Paid = true;
            return Task.FromResult(_orderRepository.Update(order));
        }
    }
}
