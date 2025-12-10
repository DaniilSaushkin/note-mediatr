using MediatR;
using note_mediatr.api.Dto;
using note_mediatr.api.Products.Queries;
using note_mediatr.api.Repositories;

namespace note_mediatr.api.Products.Handlers
{
    public class GetProductHandler(ProductRepository productRepository) : IRequestHandler<GetProductsQuery, List<Product>>
    {
        private readonly ProductRepository _productRepository = productRepository;

        public Task<List<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            if (request.OnlyActive)
                return Task.FromResult(_productRepository.GetOnlyActiveProducts());

            return Task.FromResult(_productRepository.GetProducts());
        }
    }
}
