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
        public int Id { get; set; }

        public string Technology { get; set; }

        public string Comments { get; set; }

        public string Needs { get; set; }
    }
}
