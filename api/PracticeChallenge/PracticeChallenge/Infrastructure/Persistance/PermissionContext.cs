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
        public DbSet<PermissionType> PermissionTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permission>()
                .HasOne(p => p.PermissionType)
                .WithMany()
                .HasForeignKey(p => p.PermissionTypeId);
        }
    }
}