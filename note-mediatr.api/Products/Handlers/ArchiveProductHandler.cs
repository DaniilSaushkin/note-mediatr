using MediatR;
using note_mediatr.api.Products.Commands;
using note_mediatr.api.Repositories;
using note_mediatr.api.Dto;

namespace note_mediatr.api.Products.Handlers
{
    public class ArchiveProductHandler(ProductRepository productRepository) : IRequestHandler<ArchiveProductCommand, Product>
    {
        private readonly ProductRepository _productRepository = productRepository;

        public Task<Product> Handle(ArchiveProductCommand request, CancellationToken cancellationToken)
        {
            Product product = _productRepository.GetProductById(request.Id);

            if (product.IsArchived)
                throw new ArgumentException("Product already archived");

            product.IsArchived = true;

            return Task.FromResult(_productRepository.Update(product));
        }
    }
}
