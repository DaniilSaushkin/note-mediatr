using note_mediatr.api.Dto;

namespace note_mediatr.api.Database
{
    public class Database
    {
        public List<Order> Orders { get; }
        public List<Product> Products { get; }

        public Database()
        {
            Orders =
            [
                new() { Id = Guid.NewGuid(), CustomerName = "John Black", Amount = 314.22M, CreatedAt = DateTime.UtcNow, Paid = false },
                new() { Id = Guid.NewGuid(), CustomerName = "Amanda Williams", Amount = 1354.14M, CreatedAt = DateTime.UtcNow, Paid = true },
                new() { Id = Guid.NewGuid(), CustomerName = "Daniel Hot", Amount = 94234.55M, CreatedAt = DateTime.UtcNow, Paid = false },
                new() { Id = Guid.NewGuid(), CustomerName = "Sergey Brin", Amount = 8454.64M, CreatedAt = DateTime.UtcNow, Paid = true }
            ];

            Products = 
                [
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Notebook Dell XPS 13",
                    Price = 124999.99m,
                    IsArchived = false,
                    Version = 1,
                    CreatedAt = DateTime.UtcNow.AddDays(-30),
                    UpdatedAt = DateTime.UtcNow.AddDays(-5)
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Wireless headphones Sony WH-1000XM4",
                    Price = 29999.50m,
                    IsArchived = true,
                    Version = 3,
                    CreatedAt = DateTime.UtcNow.AddDays(-120),
                    UpdatedAt = DateTime.UtcNow.AddDays(-15)
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Mechanic keyboard Keychron K8",
                    Price = 8999.00m,
                    IsArchived = false,
                    Version = 2,
                    CreatedAt = DateTime.UtcNow.AddDays(-45),
                    UpdatedAt = DateTime.UtcNow.AddDays(-2)
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Lulipap",
                    Price = 0.00m,
                    IsArchived = false,
                    Version = 1,
                    CreatedAt = DateTime.UtcNow.AddDays(-10),
                    UpdatedAt = DateTime.UtcNow.AddDays(-10)
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Monitor Samsung Odyssey G7",
                    Price = 75999.00m,
                    IsArchived = false,
                    Version = 5,
                    CreatedAt = DateTime.UtcNow.AddDays(-200),
                    UpdatedAt = DateTime.UtcNow.AddHours(-3)
                }
            ];
        }
    }
}
