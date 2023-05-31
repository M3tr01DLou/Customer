using Customer.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace Customer.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Asp> Asps { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Asp>().HasIndex(n => n.Name).IsUnique();
        }
    }
}
