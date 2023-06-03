using System.ComponentModel.DataAnnotations;

namespace Customer.Common.Entities
{
    public class DesignAC
    {
        public int Id { get; set; }

        public int VersionId { get; set; }

        [MaxLength(50)]
        public string Emplazamiento { get; set; }

        public Usuario Usuario { get; set; }

        public Operador Operador { get; set; }

        public Proyecto Proyecto { get; set; }

        public Pais Pais { get; set; }

        public TipoEstadoDiseno TipoEstadoDiseno { get; set; }
    }
}
