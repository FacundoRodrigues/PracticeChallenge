using MediatR;

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
}