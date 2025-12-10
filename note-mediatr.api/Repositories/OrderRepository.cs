using note_mediatr.api.Dto;

namespace note_mediatr.api.Repositories
{
    public class OrderRepository(Database.Database database)
    {
        private readonly Database.Database _database = database;

        public List<Order> GetOrders() => _database.Orders;
        public Order GetOrderById(Guid id) => _database.Orders.First(x => x.Id == id);

        public Order Create(Order order)
        {
            _database.Orders.Add(order);
            return _database.Orders.First(x => x.Id == order.Id);
        }

        public Order Update(Order order)
        {
            Order currentOrder = _database.Orders.First(x => x.Id == order.Id);

            currentOrder = order;

            return _database.Orders.First(x => x.Id == order.Id);
        }
    }
}
