using Customer.Common.DTOs;
using Customer.Common.Entities;

namespace Customer.API.Helpers
{
    public interface IConverterHelper
    {
        Task<DesignACSiteTypeDTO> ToDesignACSiteTypeDTO(DesignACSiteType model);

        DesignACRadioSummaryDTO ToDesignACRadioSummaryDTO(List<DesignACRadioSummary> model, string technology);
    }
}
