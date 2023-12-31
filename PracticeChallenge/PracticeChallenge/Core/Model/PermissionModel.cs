namespace PracticeChallenge.Core.Model
{
    public class PermissionModel
    {
        public string EmployeeName { get; set; }
        public string EmployeeLastName { get; set; }
        public DateTime PermissionDate { get; set; }
        public PermissionTypeModel PermissionType { get; set; }

    }
}