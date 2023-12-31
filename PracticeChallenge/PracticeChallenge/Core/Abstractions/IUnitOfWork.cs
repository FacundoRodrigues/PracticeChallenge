namespace PracticeChallenge.Core.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;

        Task HandleErrorsAsync(Func<Task> action);
    }
}