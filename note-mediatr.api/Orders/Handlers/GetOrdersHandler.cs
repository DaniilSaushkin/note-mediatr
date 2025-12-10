using MediatR;
using note_mediatr.api.Dto;
using note_mediatr.api.Orders.Queries;

namespace note_mediatr.api.Orders.Handlers
{
    public class GetOrdersHandler(Database.Database database) :
        IRequestHandler<GetOrdersQuery, List<Order>>
    {
        private readonly Database.Database _database = database;

        public Task<List<Order>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_database.Orders);
        }
    }
}
