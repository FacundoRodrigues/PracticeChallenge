namespace PracticeChallenge.Core.Abstractions
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        void Add(T entity);

        void Update(T entity);
    }
}