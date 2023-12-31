using PracticeChallenge.Core.Abstractions;
using PracticeChallenge.Infrastructure.Persistance;

namespace PracticeChallenge.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PermissionContext _context;
        private readonly Dictionary<Type, object> _repositories;
        private readonly IPermissionRepository _permissionRepository;

        public UnitOfWork(PermissionContext context)
        {
            _context = context;
            _repositories = new Dictionary<Type, object>();
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (_repositories.ContainsKey(typeof(TEntity)))
            {
                return (IRepository<TEntity>)_repositories[typeof(TEntity)];
            }

            var repository = new Repository<TEntity>(_context);
            _repositories.Add(typeof(TEntity), repository);
            return repository;
        }

        public async Task HandleErrorsAsync(Func<Task> action)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                await action();

                await _context.SaveChangesAsync();

                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async void Dispose()
        {
            await _context.DisposeAsync();
        }
    }
}