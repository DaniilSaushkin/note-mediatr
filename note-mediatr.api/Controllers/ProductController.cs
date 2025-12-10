using MediatR;
using Microsoft.AspNetCore.Mvc;
using note_mediatr.api.Dto;
using note_mediatr.api.Products.Queries;

namespace note_mediatr.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpGet]
        public async Task<IEnumerable<Product>> GetProducts([FromQuery] bool onlyActive)
        {
            return await _mediator.Send(new GetProductsQuery() { OnlyActive = onlyActive });
        }
    }
}
