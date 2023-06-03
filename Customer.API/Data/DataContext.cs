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

        public DbSet<Pais> Paises { get; set; }

        public DbSet<Operador> Operadores { get; set; }

        public DbSet<TipoInstalacionExterior> TipoInstalacionExterior { get; set; }

        public DbSet<Proyecto> Proyectos { get; set; }

		public DbSet<TipoOK> TipoOK { get; set; }

		public DbSet<TipoPropiertarioEmplazamiento> TipoPropiertarioEmplazamiento { get; set; }

		public DbSet<TipoTonelaje> TipoTonelaje { get; set; }

		public DbSet<TipoCaseta> TipoCaseta { get; set; }

        public DbSet<TipoEstadoDiseno> TipoEstadoDiseno { get; set; }

        public DbSet<TipoEstacion> TipoEstacion { get; set; }

		public DbSet<TipoGrua> TipoGrua { get; set; }

		public DbSet<TipoLlave> TipoLlave { get; set; }

		public DbSet<TipoAcceso> TipoAcceso { get; set; }

		public DbSet<TipoRangoHorario> TipoRangoHorario { get; set; }

        public DbSet<TipoSiNo> TipoSiNo { get; set; }



        public DbSet<DesignAC> DesignAC { get; set; }

		public DbSet<DesignACResumenRadio> DesignACResumenRadio { get; set; }

		public DbSet<DesignACTipoEmplazamiento> DesignACTipoEmplazamiento { get; set; }

		public DbSet<DesignACAccesoEmplazamiento> DesignACAccesoEmplazamiento { get; set; }

		public DbSet<DesignACDatos> DesignACDatos { get; set; }

		public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
