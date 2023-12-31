using PracticeChallenge.Core.Model;

namespace PracticeChallenge.Core.Features.GetPermissions;

public class GetPermissionsResponse
{
    public List<PermissionModel> Permissions { get; set; }
}