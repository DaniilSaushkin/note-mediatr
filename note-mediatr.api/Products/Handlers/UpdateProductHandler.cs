using MediatR;
using note_mediatr.api.Dto;
using note_mediatr.api.Products.Commands;
using note_mediatr.api.Repositories;

namespace note_mediatr.api.Products.Handlers
{
    public class UpdateProductHandler(ProductRepository productRepository) : IRequestHandler<UpdateProductCommand, Product>
    {
        private readonly ProductRepository _productRepository = productRepository;

        public Task<Product> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            Product product = _productRepository.GetProductById(request.Id);

            if (product.IsArchived)
                throw new ArgumentException("Product must not be archived");

            product.Name = request.Name;
            product.Price = request.Price;

            return Task.FromResult(_productRepository.Update(product));
        }
    }
}
