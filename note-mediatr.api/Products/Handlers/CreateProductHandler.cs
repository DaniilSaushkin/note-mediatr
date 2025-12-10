using MediatR;
using note_mediatr.api.Dto;
using note_mediatr.api.Products.Commands;
using note_mediatr.api.Repositories;

namespace note_mediatr.api.Products.Handlers
{
    public class CreateProductHandler(ProductRepository productRepository) :
        IRequestHandler<CreateProductCommand, Product>
    {
        private readonly ProductRepository _productRepository = productRepository;

        public Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            bool productNameIsNotUnique = _productRepository.GetProducts()
                .Where(x => x.Name == request.Name)
                .Select(x => x.Name)
                .Contains(request.Name);

            if (productNameIsNotUnique)
                throw new ArgumentException("Product name must be unique");

            Product product = new()
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Price = request.Price,
                Version = request.Version,
                IsArchived = false,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            return Task.FromResult(_productRepository.Create(product));
        }
    }
}
