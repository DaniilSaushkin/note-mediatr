using MediatR;
using note_mediatr.api.Dto;
using note_mediatr.api.Products.Commands;
using note_mediatr.api.Repositories;

namespace note_mediatr.api.Products.Handlers
{
    public class DeleteProductHandler(ProductRepository productRepository) : IRequestHandler<DeleteProductCommand, Product>
    {
        private readonly ProductRepository _productRepository = productRepository;

        public Task<Product> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_productRepository.Remove(request.Id));
        }
    }
}
