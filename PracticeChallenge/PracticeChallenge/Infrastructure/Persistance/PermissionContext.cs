using Microsoft.EntityFrameworkCore;
using PracticeChallenge.Core.Domain;

namespace PracticeChallenge.Infrastructure.Persistance
{
    public class PermissionContext : DbContext
    {
        protected PermissionContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Permission> Permission { get; set; }
        public DbSet<PermissionType> PermissionType { get; set; }
    }
}