using Customer.Common.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Common.DTOs
{
    public class DesignACRadioSummaryDTO
    {
        [MaxLength(50)]
        public string Technology { get; set; }

        [MaxLength(1000)]
        public string Comments { get; set; }

        [MaxLength(1000)]
        public string Needs { get; set; }
    }
}
