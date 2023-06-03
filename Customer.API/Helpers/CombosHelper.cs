using Customer.API.Data;
using Customer.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace Customer.API.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _context;

        public CombosHelper(DataContext context)
        {
            _context = context;
        }

        public async Task<List<TipoInstalacionExterior>> GetComboTipoInstalacionExteriorAsync()
        { 
            return await _context.TipoInstalacionExterior.ToListAsync();
        }

        public async Task<List<TipoPropiertarioEmplazamiento>> GetComboTipoPropietarioEmplazamientoAsync()
        {
            return await _context.TipoPropiertarioEmplazamiento.ToListAsync();
        }

        public async Task<List<TipoCaseta>> GetComboTipoCasetaAsync()
        {
            return await _context.TipoCaseta.ToListAsync();
        }

        public async Task<List<TipoEstacion>> GetComboTipoEstacionAsync()
        {
            return await _context.TipoEstacion.ToListAsync();
        }

		public async Task<List<TipoOK>> GetComboTipoOkAsync()
		{
			return await _context.TipoOK.ToListAsync();
		}

		public async Task<List<TipoTonelaje>> GetComboTipoTonelajeAsync()
		{
			return await _context.TipoTonelaje.ToListAsync();
		}

		public async Task<List<TipoGrua>> GetComboTipoGruaAsync()
		{
			return await _context.TipoGrua.ToListAsync();
		}

		public async Task<List<TipoLlave>> GetComboTipoLlaveAsync()
		{
			return await _context.TipoLlave.ToListAsync();
		}

		public async Task<List<TipoAcceso>> GetComboTipoAccesoAsync()
		{
			return await _context.TipoAcceso.ToListAsync();
		}

		public async Task<List<TipoRangoHorario>> GetComboTipoRangoHorarioAsync()
		{
			return await _context.TipoRangoHorario.ToListAsync();
        }

        public async Task<List<TipoSiNo>> GetComboTipoSiNoAsync()
        {
            return await _context.TipoSiNo.ToListAsync();
        }
    }
}