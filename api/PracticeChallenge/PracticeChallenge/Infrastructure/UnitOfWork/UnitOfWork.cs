using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using PracticeChallenge.Core.Abstractions;
using PracticeChallenge.Core.Abstractions.IRepositories;
using PracticeChallenge.Infrastructure.Persistance;
using PracticeChallenge.Infrastructure.Repositories;

namespace PracticeChallenge.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly PermissionContext _context;
        //private readonly Dictionary<Type, object> _repositories;

        private IDbContextTransaction? _objTran = null;
        public IPermissionRepository _permissionsRepository { get; private set; }

        public IPermissionRepository Permissions
        {
            get { return _permissionsRepository = _permissionsRepository ?? new PermissionRepository(_context); }
        }

        public UnitOfWork(PermissionContext context)
        {
            _context = context;
            //_repositories = new Dictionary<Type, object>();
        }

        public async Task CreateTransactionAsync()
        {
            _objTran = await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            await _objTran?.CommitAsync();
        }

        public async Task RollbackAsync()
        {
            await _objTran?.RollbackAsync();

            _objTran?.Dispose();
        }

        public async Task SaveAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task HandleErrorsAsync(Func<Task> action)
        {
            await CreateTransactionAsync();

            try
            {
                await action();

                await SaveAsync();

                await CommitAsync();
            }
            catch
            {
                await RollbackAsync();
                throw;
            }
        }

        //public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        //{
        //    if (_repositories.ContainsKey(typeof(TEntity)))
        //    {
        //        return (IRepository<TEntity>)_repositories[typeof(TEntity)];
        //    }

        //    var repository = new Repository<TEntity>(_context);
        //    _repositories.Add(typeof(TEntity), repository);
        //    return repository;
        //}
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}