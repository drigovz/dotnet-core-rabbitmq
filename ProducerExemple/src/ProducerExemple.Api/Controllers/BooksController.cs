using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProducerExemple.Application.Core.Books.Commands;

namespace ProducerExemple.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BookCreateCommand request) =>
            Ok(await _mediator.Send(request));
    }
}
