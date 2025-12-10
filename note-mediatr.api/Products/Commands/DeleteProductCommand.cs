using MediatR;
using note_mediatr.api.Dto;

namespace note_mediatr.api.Products.Commands
{
    public class DeleteProductCommand : IRequest<Product>
    {
        public Guid Id { get; init; }
    }
}
