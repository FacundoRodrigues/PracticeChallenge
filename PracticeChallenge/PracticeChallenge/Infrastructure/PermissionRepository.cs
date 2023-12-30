using PracticeChallenge.Core.Abstractions;
using PracticeChallenge.Core.Domain;

namespace PracticeChallenge.Infrastructure
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Permission> _permissionRepository;

        public PermissionRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _permissionRepository = _unitOfWork.GetRepository<Permission>();
        }

        public IEnumerable<Permission> GetAll()
        {
            return _permissionRepository.GetAll();
        }

        public void Add(Permission entity)
        {
            try
            {
                _permissionRepository.Add(entity);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
            }
        }

        public void Update(Permission entity)
        {
            try
            {
                _permissionRepository.Update(entity);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
            }
        }
    }
}