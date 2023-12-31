namespace PracticeChallenge.Core.Abstractions.IRepositories
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id, CancellationToken cancellationToken);

        Task<List<T>> GetAll(CancellationToken cancellationToken);

        Task Add(T entity, CancellationToken cancellationToken);

        Task Update(T entity, CancellationToken cancellationToken);
    }
}