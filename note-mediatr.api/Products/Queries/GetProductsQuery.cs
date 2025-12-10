using MediatR;
using note_mediatr.api.Dto;

namespace note_mediatr.api.Products.Queries
{
    public class GetProductsQuery : IRequest<List<Product>>
    {
        public bool OnlyActive { get; set; }
    }
}
