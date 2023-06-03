using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Common.Entities
{
    public class TipoEstadoDiseno
    {
        public int Id { get; set; }

        [MaxLength(150)]
        public string Estado { get; set; }

        public bool Activo { get; set; }
    }
}
