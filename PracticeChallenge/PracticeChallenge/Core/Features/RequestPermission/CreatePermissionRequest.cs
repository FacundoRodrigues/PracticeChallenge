using MediatR;

namespace PracticeChallenge.Core.Features.RequestPermission
{
    public class CreatePermissionRequest : IRequest<CreatePermissionResponse>
    {
        public string EmployeeName { get; set; }
        public string EmployeeLastName { get; set; }
        public DateTime PermissionDate { get; set; }
        public int PermissionTypeId { get; set; }
    }
}