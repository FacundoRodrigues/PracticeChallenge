using Dawn;
using MediatR;
using PracticeChallenge.Core.Abstractions;
using PracticeChallenge.Core.Model;
using PracticeChallenge.Core.Mapping;
using PracticeChallenge.Core.Domain;

namespace PracticeChallenge.Core.Features.ModifyPermission
{
    public class ModifyPermissionRequest : IRequest<ModifyPermissionResponse>
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeLastName { get; set; }
        public DateTime PermissionDate { get; set; }
        public int PermissionTypeId { get; set; }
    }

    public class ModifyPermissionResponse
    {
        public PermissionModel Permission { get; set; }
    }

    public class ModifyPermissionHandler : IRequestHandler<ModifyPermissionRequest, ModifyPermissionResponse>
    {
        private readonly IPermissionRepository _permissionRepository;

        public ModifyPermissionHandler(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }

        public async Task<ModifyPermissionResponse> Handle(ModifyPermissionRequest request, CancellationToken cancellationToken)
        {
            Guard.Argument(request.Id, nameof(request.Id)).GreaterThan(0);

            var permissionToUpdate = await _permissionRepository.GetByIdAsync(request.Id);

            if (permissionToUpdate == null) throw new NullReferenceException();

            permissionToUpdate.Update(request.EmployeeName, request.EmployeeLastName, request.PermissionDate,
                request.PermissionTypeId);

            await _permissionRepository.Update(permissionToUpdate, cancellationToken);

            return new ModifyPermissionResponse { Permission = permissionToUpdate.ToModel() };
        }
    }
}