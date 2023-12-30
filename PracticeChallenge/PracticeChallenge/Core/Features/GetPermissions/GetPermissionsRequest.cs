using MediatR;
using PracticeChallenge.Core.Domain;

namespace PracticeChallenge.Core.Features.GetPermissions
{
    public class GetPermissionsRequest : IRequest<GetPermissionsResponse>
    {
    }

    public class GetPermissionsResponse
    {
        public List<Permission> Permissions { get; set; }
    }
}