using MediatR;
using Microsoft.AspNetCore.Mvc;
using PracticeChallenge.Core.Features.GetPermissions;
using PracticeChallenge.Core.Features.ModifyPermission;
using PracticeChallenge.Core.Features.RequestPermission;

namespace PracticeChallenge.Controllers
{
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PermissionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("permission")]
        public async Task<ActionResult> GetPermissions()
        {
            var request = new GetPermissionsRequest();

            var response = await _mediator.Send(request);

            return Ok(response.Permissions);
        }

        [HttpPost]
        [Route("permission")]
        public async Task<ActionResult> RequestPermissions(CreatePermissionRequest request)
        {
            var response = await _mediator.Send(request);

            return Created(string.Empty, response.Permission);
        }

        [HttpPut]
        [Route("permission")]
        public async Task<ActionResult> ModifyPermissions(ModifyPermissionRequest request)
        {
            var response = await _mediator.Send(request);

            return Ok(response.Permission);
        }
    }
}