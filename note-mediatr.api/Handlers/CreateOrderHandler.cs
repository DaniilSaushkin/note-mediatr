using MediatR;
using note_mediatr.api.Commands;
using note_mediatr.api.Dto;

namespace note_mediatr.api.Handlers
{
    public class CreateOrderHandler(Database.Database database, IMediator mediator) : 
        IRequestHandler<CreateOrderCommand, Order>
    {
        private readonly Database.Database _database = database;
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

            _database.Create(order);
            await _mediator.Publish(new Notifications.OrderCreatedNotification(order.Id, order.CustomerName), cancellationToken);

            return order;
        }
    }
}
