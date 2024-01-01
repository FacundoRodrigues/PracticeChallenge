using Microsoft.EntityFrameworkCore;
using PracticeChallenge.Core.Abstractions.IRepositories;
using PracticeChallenge.Core.Domain;
using PracticeChallenge.Infrastructure.Persistance;

namespace PracticeChallenge.Infrastructure.Repositories
{
    public class PermissionRepository : Repository<Permission>, IPermissionRepository
    {
        private readonly PermissionContext _context;

        public PermissionRepository(PermissionContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Permission> GetPermissionByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Permissions
                .Include(x => x.PermissionType)
                .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<List<Permission>> GetAllPermissions(CancellationToken cancellationToken)
        {
            return await _context.Permissions
                .Include(x => x.PermissionType)
                .ToListAsync(cancellationToken);
        }

        //public async Task Add(Permission entity, CancellationToken cancellationToken)
        //{
        //    return Task.CompletedTask;
        //    // await _unitOfWork.HandleErrorsAsync(async () => await _repository.Add(entity, cancellationToken));
        //}

        //public async Task Update(Permission entity, CancellationToken cancellationToken)
        //{
        //    await _unitOfWork.HandleErrorsAsync(async () => await _repository.Update(entity, cancellationToken));
        //}
    }
}