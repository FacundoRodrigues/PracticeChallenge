using PracticeChallenge.Core.Abstractions;
using PracticeChallenge.Core.Domain;

namespace PracticeChallenge.Infrastructure
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Permission> _repository;

        public PermissionRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<Permission>();
        }

        public async Task<Permission> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<List<Permission>> GetAll(CancellationToken cancellationToken)
        {
            return await _repository.GetAll(cancellationToken);
        }

        public async Task Add(Permission entity, CancellationToken cancellationToken)
        {
            await _unitOfWork.HandleErrorsAsync(async () => await _repository.Add(entity, cancellationToken));
        }

        public async Task Update(Permission entity, CancellationToken cancellationToken)
        {
            await _unitOfWork.HandleErrorsAsync(async () => await _repository.Update(entity, cancellationToken));
        }
    }
}