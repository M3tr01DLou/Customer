using Customer.Common.DTOs;
using Customer.Common.Entities;

namespace Customer.API.Helpers
{
    public interface IConverterHelper
    {
        Task<DesignACTipoEmplazamientoDTO> ToDesignACTipoEmplazamientoDTO(DesignACTipoEmplazamiento model);

        DesignACResumenRadioDTO ToDesignACResumenRadioDTO(List<DesignACResumenRadio> model, string technology);

		Task<DesignACAccesoEmplazamientoDTO> ToDesignACAccesoEmplazamientoDTO(DesignACAccesoEmplazamiento model);

        Task<DesignACDatosDTO> ToDesignACDatosDTO(DesignACDatos model);
    }
}
