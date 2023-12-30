using MediatR;
using PracticeChallenge.Core.Abstractions;

namespace PracticeChallenge.Core.Features.GetPermissions;

public class GetPermissionsHandler : IRequestHandler<GetPermissionsRequest, GetPermissionsResponse>
{
    private readonly IPermissionRepository _permissionRepository;

    public GetPermissionsHandler(IPermissionRepository permissionRepository)
    {
        _permissionRepository = permissionRepository;
    }

    public async Task<GetPermissionsResponse> Handle(GetPermissionsRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var permission = _permissionRepository.GetAll().ToList();

            return new GetPermissionsResponse { Permissions = permission };
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}