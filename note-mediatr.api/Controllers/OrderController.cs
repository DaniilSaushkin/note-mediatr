using MediatR;
using Microsoft.AspNetCore.Mvc;
using note_mediatr.api.Commands;
using note_mediatr.api.Dto;
using note_mediatr.api.Queries;

namespace note_mediatr.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;
        public OrderController(IMediator mediator) => _mediator = mediator;

        [HttpPost]
        public async Task<Order> CreateOrder(
            [FromQuery] string? customerName,
            [FromQuery] decimal amount)
        {
            CreateOrderCommand command = new()
            {
                CustomerName = customerName,
                Amount = amount
            };

            return await _mediator.Send(command);
        }

        [HttpGet]
        public async Task<List<Order>> GetOrders()
        {
            return await _mediator.Send(new GetOrdersQuery());
        }

        [HttpPost("{id}/markAsPaid")]
        public async Task<Order> MarkOrderAsPaid([FromRoute] Guid id)
        {
            MarkOrderAsPaidCommand command = new()
            {
                Id = id
            };

            return await _mediator.Send(command);
        }
    }
}
