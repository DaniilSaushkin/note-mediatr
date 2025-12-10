using MediatR;
using note_mediatr.api.Dto;

namespace note_mediatr.api.Products.Commands
{
    public class CreateProductCommand : IRequest<Product>
    {
        public required string? Name { get; set; }
        public decimal Price { get; set; }
        public int Version { get; set; }
    }
}
