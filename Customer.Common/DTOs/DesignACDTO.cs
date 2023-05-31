using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Common.DTOs
{
    public class DesignACDTO
    {
        public int DesignACId { get; set; }

        public DesignACSiteTypeDTO DesignACSiteTypeDTO { get; set; }

        public List<DesignACRadioSummaryDTO> DesignACRadioSummaryDTO { get; set; }
    }
}
