using MediatR;
using Microsoft.AspNetCore.Mvc;
using PracticeChallenge.Core.Features.GetPermissions;

namespace PracticeChallenge.Controllers
{
    [Route("permission")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PermissionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetPermissions()
        {
            var request = new GetPermissionsRequest();

            var response = await _mediator.Send(request);

            return Ok(response.Permissions);
        }
    }
}