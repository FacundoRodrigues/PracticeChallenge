using PracticeChallenge.Core.Domain;

namespace PracticeChallenge.Core.Abstractions.IRepositories
{
    public interface IPermissionRepository : IRepository<Permission>
    {
        Task<Permission> GetPermissionByIdAsync(int id, CancellationToken cancellationToken);

        Task<List<Permission>> GetAllPermissions(CancellationToken cancellationToken);
    }
}