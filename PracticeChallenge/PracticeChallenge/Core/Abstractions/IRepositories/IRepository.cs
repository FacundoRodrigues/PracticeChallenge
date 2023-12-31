namespace PracticeChallenge.Core.Abstractions.IRepositories
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id);

        Task<List<T>> GetAll(CancellationToken cancellationToken);

        Task Add(T entity, CancellationToken cancellationToken);

        Task Update(T entity, CancellationToken cancellationToken);
    }
}