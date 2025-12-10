using MediatR;
using note_mediatr.api.Dto;
using note_mediatr.api.Orders.Commands;
using note_mediatr.api.Repositories;

namespace note_mediatr.api.Orders.Handlers
{
    public class CreateOrderHandler(OrderRepository orderRepository, IMediator mediator) :
        IRequestHandler<CreateOrderCommand, Order>
    {
        private readonly OrderRepository _orderRepository = orderRepository;
        private readonly IMediator _mediator = mediator;

        public async Task<Order> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            if (request.CustomerName == null)
                throw new ArgumentException("Customer name must not be null");

            Order order = new()
            {
                Id = Guid.NewGuid(),
                CustomerName = request.CustomerName,
                Amount = request.Amount,
                Paid = false,
                CreatedAt = DateTime.UtcNow,
            };

            _orderRepository.Create(order);
            await _mediator.Publish(new Notifications.OrderCreatedNotification(order.Id, order.CustomerName), cancellationToken);

            return order;
        }
    }
}
