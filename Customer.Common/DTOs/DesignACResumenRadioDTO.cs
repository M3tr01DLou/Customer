using Customer.Common.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Common.DTOs
{
    public class DesignACResumenRadioDTO
    {
        public int Id { get; set; }

        public string Tecnologia { get; set; }

        public string Comentarios { get; set; }

        public string Necesita { get; set; }
    }
}
