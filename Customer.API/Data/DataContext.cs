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

        public DbSet<Country> Countries{ get; set; }

        public DbSet<DesignAC> DesignACs { get; set; }

        public DbSet<DesignACRadioSummary> DesignACRadioSummaries { get; set; }

        public DbSet<DesignACSiteType> DesignACSiteTypes { get; set; }

        public DbSet<Operator> Operators { get; set; }

        public DbSet<TypeOutdoorInstallation> TypeOutdoorInstallations { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<TypeSiteOwner> TypeSiteOwners { get; set; }

        public DbSet<TypeStand> TypeStands { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<TypeStation> TypeStations { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
