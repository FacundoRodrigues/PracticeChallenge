using Microsoft.EntityFrameworkCore;
using PracticeChallenge.Core.Abstractions.IRepositories;

namespace PracticeChallenge.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<List<TEntity>> GetAll(CancellationToken cancellationToken)
        {
            return await _dbSet.ToListAsync(cancellationToken);
        }

        public async Task Add(TEntity entity, CancellationToken cancellationToken)
        {
            await _dbSet.AddAsync(entity, cancellationToken);
        }

        public Task Update(TEntity entity, CancellationToken cancellationToken)
        {
            _dbSet.Update(entity);
            _context.Entry(entity).State = EntityState.Modified;

            return Task.CompletedTask;
        }
    }
}