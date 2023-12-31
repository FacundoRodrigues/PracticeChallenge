using Dawn;

namespace PracticeChallenge.Core.Domain
{
    public class Permission
    {
        public int Id { get; protected set; }
        public string EmployeeName { get; protected set; }
        public string EmployeeLastName { get; protected set; }
        public DateTime PermissionDate { get; protected set; }
        public int PermissionTypeId { get; protected set; }

        public Permission()
        {
        }

        public Permission(string employeeName, string employeeLastName, DateTime permissionDate, int permissionTypeId)
        {
            Update(employeeName, employeeLastName, permissionDate, permissionTypeId);
        }

        public void Update(string employeeName, string employeeLastName, DateTime permissionDate, int permissionTypeId)
        {
            Guard.Argument(employeeName, nameof(employeeName)).NotNull();
            Guard.Argument(employeeLastName, nameof(employeeLastName)).NotNull();
            Guard.Argument(permissionDate, nameof(permissionDate)).NotDefault();
            Guard.Argument(permissionTypeId, nameof(permissionTypeId)).Positive().GreaterThan(0);

            EmployeeName = employeeName;
            EmployeeLastName = employeeLastName;
            PermissionDate = permissionDate;
            PermissionTypeId = permissionTypeId;
        }
    }
}