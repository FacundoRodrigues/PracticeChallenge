using MediatR;
using PracticeChallenge.Core.Abstractions;
using PracticeChallenge.Core.Abstractions.IRepositories;
using PracticeChallenge.Core.Domain;
using PracticeChallenge.Core.Mapping;

namespace PracticeChallenge.Core.Features.RequestPermission;

public class CreatePermissionHandler : IRequestHandler<CreatePermissionRequest, CreatePermissionResponse>
{
    private readonly IPermissionRepository _permissionRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreatePermissionHandler(IPermissionRepository permissionRepository, IUnitOfWork unitOfWork)
    {
        _permissionRepository = permissionRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<CreatePermissionResponse> Handle(CreatePermissionRequest request, CancellationToken cancellationToken)
    {
        var permission = new Permission(request.EmployeeName,
            request.EmployeeLastName,
            request.PermissionDate,
            request.PermissionTypeId);

        await _unitOfWork.HandleErrorsAsync(async () => await _permissionRepository.Add(permission, cancellationToken));

        return new CreatePermissionResponse { Permission = permission.ToModel() };
    }
}