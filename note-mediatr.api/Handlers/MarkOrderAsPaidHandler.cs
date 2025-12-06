using MediatR;
using note_mediatr.api.Commands;
using note_mediatr.api.Dto;

namespace note_mediatr.api.Handlers
{
    public class MarkOrderAsPaidHandler(Database.Database database) : IRequestHandler<MarkOrderAsPaidCommand, Order>
    {
        private readonly Database.Database _database = database;

        public Task<Order> Handle(MarkOrderAsPaidCommand request, CancellationToken cancellationToken)
        {
            Order order = _database.Orders.First(x => x.Id == request.Id);
            order.Paid = true;

            return Task.FromResult(order);
        }
    }
}
