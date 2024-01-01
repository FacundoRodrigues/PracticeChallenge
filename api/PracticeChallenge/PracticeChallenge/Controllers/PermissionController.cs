using MediatR;
using Microsoft.AspNetCore.Mvc;
using PracticeChallenge.Core.Features.GetPermissionById;
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
        [Route("permissions")]
        public async Task<ActionResult> GetPermissions()
        {
            var request = new GetPermissionsRequest();

            var response = await _mediator.Send(request);

            return Ok(response.Permissions);
        }

        [HttpGet]
        [Route("permissions/{id}")]
        public async Task<ActionResult> GetPermissionById(int id)
        {
            var request = new GetPermissionByIdRequest { Id = id };

            var response = await _mediator.Send(request);

            return Ok(response.Permission);
        }

        [HttpPost]
        [Route("permissions")]
        public async Task<ActionResult> RequestPermissions(CreatePermissionRequest request)
        {
            var response = await _mediator.Send(request);

            return Created(string.Empty, response.Permission);
        }

        [HttpPut]
        [Route("permissions")]
        public async Task<ActionResult> ModifyPermissions(ModifyPermissionRequest request)
        {
            var response = await _mediator.Send(request);

            return Ok(response.Permission);
        }
    }
}