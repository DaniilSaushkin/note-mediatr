using note_mediatr.api.Dto;

namespace note_mediatr.api.Repositories
{
    public class ProductRepository(Database.Database database)
    {
        private readonly Database.Database _database = database;

        public List<Product> GetProducts() => _database.Products;
        public List<Product> GetOnlyActiveProducts() => [.. _database.Products.Where(x => !x.IsArchived)];
        public Product GetProductById(Guid id) => _database.Products.First(x => x.Id == id);

        public Product Create(Product product)
        {
            _database.Products.Add(product);
            return _database.Products.First(x => x.Id == product.Id);
        }

        public Product Update(Product product)
        {
            Product currentProduct = _database.Products.First(x => x.Id == product.Id);

            currentProduct = product;
            currentProduct.UpdatedAt = DateTime.UtcNow;

            return _database.Products.First(x => x.Id == product.Id);
        }

        public Product Remove(Guid id)
        {
            Product product = GetProductById(id);
            _database.Products.Remove(product);
            return product;
        }
    }
}
