using Customer.Common.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Customer.API.Helpers
{
    public interface ICombosHelper
    {
        Task<List<TipoEstacion>> GetComboTipoEstacionAsync();

        Task<List<TipoCaseta>> GetComboTipoCasetaAsync();

        Task<List<TipoPropiertarioEmplazamiento>> GetComboTipoPropietarioEmplazamientoAsync();

        Task<List<TipoInstalacionExterior>> GetComboTipoInstalacionExteriorAsync();

		Task<List<TipoOK>> GetComboTipoOkAsync();

		Task<List<TipoTonelaje>> GetComboTipoTonelajeAsync();

		Task<List<TipoGrua>> GetComboTipoGruaAsync();

		Task<List<TipoLlave>> GetComboTipoLlaveAsync();

		Task<List<TipoAcceso>> GetComboTipoAccesoAsync();

		Task<List<TipoRangoHorario>> GetComboTipoRangoHorarioAsync();

        Task<List<TipoSiNo>> GetComboTipoSiNoAsync();
    }
}
