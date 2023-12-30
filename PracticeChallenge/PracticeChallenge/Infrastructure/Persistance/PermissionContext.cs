using Microsoft.EntityFrameworkCore;
using PracticeChallenge.Core.Domain;

namespace PracticeChallenge.Infrastructure.Persistance
{
    public class PermissionContext : DbContext
    {
        public PermissionContext(DbContextOptions<PermissionContext> options) : base(options)
        {
        }

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionType> PermissionType { get; set; }
    }
}