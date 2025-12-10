using MediatR;
using note_mediatr.api.Dto;

namespace note_mediatr.api.Products.Commands
{
    public class UpdateProductCommand : IRequest<Product>
    {
        public Guid Id { get; init; }
        public required string? Name { get; init; }
        public decimal Price { get; init; }
    }
}
