using PracticeChallenge.Core.Abstractions.IRepositories;

namespace PracticeChallenge.Core.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        //IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;

        Task HandleErrorsAsync(Func<Task> action);

        IPermissionRepository Permissions { get; }

        Task CreateTransactionAsync();

        Task CommitAsync();

        Task RollbackAsync();

        Task SaveAsync();
    }
}