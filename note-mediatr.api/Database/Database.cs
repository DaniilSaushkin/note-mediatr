using note_mediatr.api.Dto;

namespace note_mediatr.api.Database
{
    public class Database
    {
        public List<Order> Orders { get; }

        public Database()
        {
            Orders =
            [
                new() { Id = Guid.NewGuid(), CustomerName = "John Black", Amount = 314.22M, CreatedAt = DateTime.UtcNow, Paid = false },
                new() { Id = Guid.NewGuid(), CustomerName = "Amanda Williams", Amount = 1354.14M, CreatedAt = DateTime.UtcNow, Paid = true },
                new() { Id = Guid.NewGuid(), CustomerName = "Daniel Hot", Amount = 94234.55M, CreatedAt = DateTime.UtcNow, Paid = false },
                new() { Id = Guid.NewGuid(), CustomerName = "Sergey Brin", Amount = 8454.64M, CreatedAt = DateTime.UtcNow, Paid = true }
            ];
        }

        public void Create(Order order) => Orders.Add(order);
        public void Remove(Order order) => Orders.Remove(order);
    }
}
