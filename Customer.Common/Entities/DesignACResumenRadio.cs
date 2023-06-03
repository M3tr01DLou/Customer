using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Common.Entities
{
    public class DesignACResumenRadio
    {
        public int Id { get; set; }

        public DesignAC DesignAC { get; set; }

        [MaxLength(50)]
        public string Tecnologia { get; set; }

        [MaxLength(1000)]
        public string Comentarios { get; set; }

        [MaxLength(1000)]
        public string Necesita { get; set; }
    }
}
