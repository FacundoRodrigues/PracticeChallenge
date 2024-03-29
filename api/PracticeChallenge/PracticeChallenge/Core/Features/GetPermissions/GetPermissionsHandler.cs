﻿using MediatR;
using PracticeChallenge.Core.Abstractions.IRepositories;
using PracticeChallenge.Core.Mapping;

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
        var permission = await _permissionRepository.GetAllPermissions(cancellationToken);

        return new GetPermissionsResponse { Permissions = permission.ToModel() };
    }
}