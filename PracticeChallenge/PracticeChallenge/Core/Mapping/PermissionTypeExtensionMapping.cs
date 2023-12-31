using PracticeChallenge.Core.Domain;
using PracticeChallenge.Core.Model;

namespace PracticeChallenge.Core.Mapping
{
    public static class PermissionTypeExtensionMapping
    {
        public static PermissionType ToDomain(this int permissionType)
        {
            return new PermissionType(permissionType, string.Empty);
        }

        public static PermissionTypeModel ToModel(this PermissionType permissionType, int permissionTypeId)
        {
            if (permissionType != null)
            {
                return new PermissionTypeModel
                {
                    Id = permissionType.Id,
                    Description = permissionType.Description
                };
            }

            return new PermissionTypeModel
            {
                Id = permissionTypeId
            };
        }
    }
}