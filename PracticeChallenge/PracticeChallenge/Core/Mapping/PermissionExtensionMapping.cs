using PracticeChallenge.Core.Domain;
using PracticeChallenge.Core.Model;

namespace PracticeChallenge.Core.Mapping
{
    public static class PermissionExtensionMapping
    {
        public static List<PermissionModel> ToModel(this List<Permission> permission) => permission.Select(x => x.ToModel()).ToList();

        public static PermissionModel ToModel(this Permission permission)
        {
            return new PermissionModel
            {
                EmployeeName = permission.EmployeeName,
                EmployeeLastName = permission.EmployeeLastName,
                PermissionDate = permission.PermissionDate,
                PermissionType = permission.PermissionType.ToModel(permission.PermissionTypeId)
            };
        }
    }
}