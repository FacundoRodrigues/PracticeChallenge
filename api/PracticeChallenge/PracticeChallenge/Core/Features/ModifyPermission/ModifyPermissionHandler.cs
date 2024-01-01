using Dawn;
using MediatR;
using PracticeChallenge.Core.Abstractions;
using PracticeChallenge.Core.Abstractions.IRepositories;
using PracticeChallenge.Core.Mapping;

namespace PracticeChallenge.Core.Features.ModifyPermission;

public class ModifyPermissionHandler : IRequestHandler<ModifyPermissionRequest, ModifyPermissionResponse>
{
    private readonly IPermissionRepository _permissionRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ModifyPermissionHandler(IPermissionRepository permissionRepository, IUnitOfWork unitOfWork)
    {
        _permissionRepository = permissionRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ModifyPermissionResponse> Handle(ModifyPermissionRequest request, CancellationToken cancellationToken)
    {
        Guard.Argument(request.Id, nameof(request.Id)).GreaterThan(0);

        var permissionToUpdate = await _permissionRepository.GetPermissionByIdAsync(request.Id, cancellationToken);

        if (permissionToUpdate == null) throw new NullReferenceException();

        permissionToUpdate.Update(request.EmployeeName, request.EmployeeLastName, request.PermissionDate,
            request.PermissionTypeId);

        await _unitOfWork.HandleErrorsAsync(async () => await _permissionRepository.Update(permissionToUpdate, cancellationToken));

        return new ModifyPermissionResponse { Permission = permissionToUpdate.ToModel() };
    }
}