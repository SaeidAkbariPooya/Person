using MediatR;
using Microsoft.AspNetCore.Mvc;
using MiniPerson.Application.Features.LeaveTypes.Requests.Commands;
using MiniPerson.Application.Features.Persons.Requests.Commands;

namespace MiniPerson.Controllers.Person
{
    public class PersonCommandController : BaseController
    {
        private readonly IMediator _mediator;
        public PersonCommandController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreatePersonCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeletePersonCommand command)
        {
            try
            {
                var result = await _mediator.Send(command);
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdatePersonCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
