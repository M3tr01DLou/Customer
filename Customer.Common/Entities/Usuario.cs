using System.ComponentModel.DataAnnotations;

namespace Customer.Common.Entities
{
    public class Usuario
    {
        public int Id { get; set; }

        [MaxLength(170)]
        public string Nombre { get; set; }

        [MaxLength(150)]
        public string Login { get; set; }

        public Asp Asp { get; set; }

        [MaxLength(50)]
        public string Organizacion { get; set; }

        [MaxLength(150)]
        public bool Administrador { get; set; }
    }
}
