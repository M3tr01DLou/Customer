using Customer.API.Data;
using Customer.Common.DTOs;
using Customer.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace Customer.API.Helpers
{
	public class ConverterHelper : IConverterHelper
    {
        private readonly ICombosHelper _combosHelper;
        private readonly DataContext _context;

        public ConverterHelper(ICombosHelper combosHelper, DataContext context)
        {
            _combosHelper = combosHelper;
            _context = context;
        }

		public async Task<DesignACAccesoEmplazamientoDTO> ToDesignACAccesoEmplazamientoDTO(DesignACAccesoEmplazamiento designACAccesoEmplazamiento)
		{
            return new DesignACAccesoEmplazamientoDTO
			{
				Id = designACAccesoEmplazamiento.Id,
				CaminoAccesoId = designACAccesoEmplazamiento.CaminoAcceso?.Id,
				NecesidadGruaId = designACAccesoEmplazamiento.NecesidadGrua?.Id,
				Necesidad4x4 = designACAccesoEmplazamiento.Necesidad4x4,
				TonelajeId = designACAccesoEmplazamiento.Tonelaje?.Id,
				TipoGruaId = designACAccesoEmplazamiento.TipoGrua?.Id,
				AccesoEmplazamientoId = designACAccesoEmplazamiento.AccesoEmplazamiento?.Id,
				CajetinLlavesId = designACAccesoEmplazamiento.CajetinLlaves?.Id,
				TipoLlaveId = designACAccesoEmplazamiento.TipoLlave?.Id,
				AccesoEntradaMaterialId = designACAccesoEmplazamiento.AccesoEntradaMaterial?.Id,
				TodasLlaveOKId = designACAccesoEmplazamiento.TodasLlaveOK?.Id,
				AutorizacionEspecialId = designACAccesoEmplazamiento.AutorizacionEspecial?.Id,
				ContactoPropiedadId = designACAccesoEmplazamiento.ContactoPropiedad?.Id,
				TipoAccesoId = designACAccesoEmplazamiento.TipoAcceso?.Id,
				ProblemasDetectadosId = designACAccesoEmplazamiento.ProblemasDetectados?.Id,
				TipoRangoHorarioId = designACAccesoEmplazamiento.TipoRangoHorario?.Id,
				NecesidadAlpinistaId = designACAccesoEmplazamiento.NecesidadAlpinista?.Id,
				Comentarios = designACAccesoEmplazamiento.Comentarios,
				CaminoAcceso = await _combosHelper.GetComboTipoOkAsync(),
				NecesidadGrua = await _combosHelper.GetComboTipoOkAsync(),
				Tonelaje = await _combosHelper.GetComboTipoTonelajeAsync(),
				TipoGrua = await _combosHelper.GetComboTipoGruaAsync(),
				AccesoEmplazamiento = await _combosHelper.GetComboTipoOkAsync(),
				CajetinLlaves = await _combosHelper.GetComboTipoOkAsync(),
				TipoLlave = await _combosHelper.GetComboTipoLlaveAsync(),
				AccesoEntradaMaterial = await _combosHelper.GetComboTipoOkAsync(),
				TodasLlaveOK = await _combosHelper.GetComboTipoOkAsync(),
				AutorizacionEspecial = await _combosHelper.GetComboTipoOkAsync(),
				ContactoPropiedad = await _combosHelper.GetComboTipoOkAsync(),
				TipoAcceso = await _combosHelper.GetComboTipoAccesoAsync(),
				ProblemasDetectados = await _combosHelper.GetComboTipoOkAsync(),
				TipoRangoHorario = await _combosHelper.GetComboTipoRangoHorarioAsync(),
				NecesidadAlpinista = await _combosHelper.GetComboTipoOkAsync()
			};
		}

        public async Task<DesignACDatosDTO> ToDesignACDatosDTO(DesignACDatos designACDatos)
        {
            return new DesignACDatosDTO
            {
                Id = designACDatos.Id,
                FechaVisita = designACDatos.FechaVisita,
                FechaUltimoDiseno = designACDatos.FechaUltimoDiseno,
                FechaUltimoDisenoAceptado = designACDatos.FechaUltimoDisenoAceptado,
                ActuacionTorresId = designACDatos.ActuacionTorres?.Id,
                SinObra = designACDatos.SinObra,
                Sustancial = designACDatos.Sustancial,
                NoSustancial = designACDatos.NoSustancial,
                ComentariosTelxius = designACDatos.ComentariosTelxius,
                NecesarioAdecuacionId = designACDatos.NecesarioAdecuacion?.Id,
                ObservacionesAdecuacion = designACDatos.ObservacionesAdecuacion,
                RBS = designACDatos.RBS,
                SSRR = designACDatos.SSRR,
                Energia = designACDatos.Energia,
                Equipo = designACDatos.Equipo,
                Otro = designACDatos.Otro,
                TomaTierra = designACDatos.TomaTierra,
                Repartidor = designACDatos.Repartidor,
                AlarmasExternas = designACDatos.AlarmasExternas,
                AntenasPasivosComentarios = designACDatos.AntenasPasivosComentarios,
                AntenasPasivosAcciones = designACDatos.AntenasPasivosAcciones,
                AlimentacionComentarios = designACDatos.AlimentacionComentarios,
                AlimentacionAcciones = designACDatos.AlimentacionAcciones,
                TCUComentarios = designACDatos.TCUComentarios,
                TXComentarios = designACDatos.TXComentarios,
                ActuacionTorres = await _combosHelper.GetComboTipoSiNoAsync(),
                NecesarioAdecuacion = await _combosHelper.GetComboTipoSiNoAsync(),
            };
        }

        public DesignACResumenRadioDTO ToDesignACResumenRadioDTO(List<DesignACResumenRadio> model, string technology)
        {
            DesignACResumenRadio designACRadioSummary = model.Where(rs => rs.Tecnologia.Equals(technology)).FirstOrDefault()!;
            return new DesignACResumenRadioDTO 
            { 
                Id = designACRadioSummary.Id,
                Tecnologia = designACRadioSummary.Tecnologia,
                Comentarios = designACRadioSummary.Comentarios,
                Necesita = designACRadioSummary.Necesita
            };  
        }

        public async Task<DesignACTipoEmplazamientoDTO> ToDesignACTipoEmplazamientoDTO(DesignACTipoEmplazamiento designACTipoEmplazamiento)
        {
            return new DesignACTipoEmplazamientoDTO
            {
                Id = designACTipoEmplazamiento.Id,
                TipoPropiertarioEmplazamientoId = designACTipoEmplazamiento.TipoPropiertarioEmplazamiento?.Id,
                TipoEstacionId = designACTipoEmplazamiento.TipoEstacion?.Id,
                TipoCasetaId = designACTipoEmplazamiento.TipoCaseta?.Id,
                TipoInstalacionExteriorId = designACTipoEmplazamiento.TipoInstalacionExterior?.Id,
                NotShared = designACTipoEmplazamiento.NoCompartido,
                Vodafone = designACTipoEmplazamiento.Vodafone,
                Orange = designACTipoEmplazamiento.Orange,
                Telxius = designACTipoEmplazamiento.Telxius,
                Yoigo = designACTipoEmplazamiento.Yoigo,
                Adif = designACTipoEmplazamiento.Adif,
                Others = designACTipoEmplazamiento.Others,
                Cellnex = designACTipoEmplazamiento.Cellnex,
                TipoEstacion = await _combosHelper.GetComboTipoEstacionAsync(),
                TipoCaseta = await _combosHelper.GetComboTipoCasetaAsync(),
                TipoPropiertarioEmplazamiento = await _combosHelper.GetComboTipoPropietarioEmplazamientoAsync(),
                TipoInstalacionExterior = await _combosHelper.GetComboTipoInstalacionExteriorAsync()
            };
        }



        public async Task<DesignACTipoEmplazamiento> ToDesignACTipoEmplazamiento(DesignACTipoEmplazamientoDTO designACTipoEmplazamiento, DesignAC designAC)
        {
            return new DesignACTipoEmplazamiento
            {
                Id = designACTipoEmplazamiento.Id,
                DesignAC = designAC,
                TipoEstacion = await _context.TipoEstacion.FindAsync(designACTipoEmplazamiento.TipoEstacionId),
                TipoCaseta = await _context.TipoCaseta.FindAsync(designACTipoEmplazamiento.TipoCasetaId),
                TipoInstalacionExterior = await _context.TipoInstalacionExterior.FindAsync(designACTipoEmplazamiento.TipoInstalacionExteriorId),
                TipoPropiertarioEmplazamiento = await _context.TipoPropiertarioEmplazamiento.FindAsync(designACTipoEmplazamiento.TipoPropiertarioEmplazamientoId),
                NoCompartido = designACTipoEmplazamiento.NotShared,
                Adif = designACTipoEmplazamiento.Adif,
                Cellnex = designACTipoEmplazamiento.Cellnex,
                Orange = designACTipoEmplazamiento.Orange,
                Others = designACTipoEmplazamiento.Others,
                Telxius = designACTipoEmplazamiento.Telxius,
                Vodafone = designACTipoEmplazamiento.Vodafone,
                Yoigo = designACTipoEmplazamiento.Yoigo,
            };
        }

        public DesignACResumenRadio ToDesignACResumenRadio(DesignACResumenRadioDTO designACResumenRadio, DesignAC designAC)
        {
            return new DesignACResumenRadio
            {
                Id = designACResumenRadio.Id,
                DesignAC = designAC,
                Tecnologia = designACResumenRadio.Tecnologia,
                Comentarios = designACResumenRadio.Comentarios,
               Necesita = designACResumenRadio.Necesita 
            };
        }

        public async Task<DesignACAccesoEmplazamiento> ToDesignACAccesoEmplazamiento(DesignACAccesoEmplazamientoDTO designACAccesoEmplazamiento, DesignAC designAC)
        {
            return new DesignACAccesoEmplazamiento
            {
                Id = designACAccesoEmplazamiento.Id,
                DesignAC = designAC,
                CaminoAcceso = await _context.TipoOK.FindAsync(designACAccesoEmplazamiento.CaminoAccesoId),
                NecesidadGrua = await _context.TipoOK.FindAsync(designACAccesoEmplazamiento.NecesidadGruaId),
                Necesidad4x4 = designACAccesoEmplazamiento.Necesidad4x4,
                Tonelaje = await _context.TipoTonelaje.FindAsync(designACAccesoEmplazamiento.TonelajeId),
                TipoGrua = await _context.TipoGrua.FindAsync(designACAccesoEmplazamiento.TipoGruaId),
                AccesoEmplazamiento = await _context.TipoOK.FindAsync(designACAccesoEmplazamiento.AccesoEmplazamientoId),
                CajetinLlaves = await _context.TipoOK.FindAsync(designACAccesoEmplazamiento.CajetinLlavesId),
                TipoLlave = await _context.TipoLlave.FindAsync(designACAccesoEmplazamiento.TipoLlaveId),
                AccesoEntradaMaterial = await _context.TipoOK.FindAsync(designACAccesoEmplazamiento.AccesoEntradaMaterialId),
                TodasLlaveOK = await _context.TipoOK.FindAsync(designACAccesoEmplazamiento.TodasLlaveOKId),
                AutorizacionEspecial = await _context.TipoOK.FindAsync(designACAccesoEmplazamiento.AutorizacionEspecialId),
                ContactoPropiedad = await _context.TipoOK.FindAsync(designACAccesoEmplazamiento.ContactoPropiedadId),
                TipoAcceso = await _context.TipoAcceso.FindAsync(designACAccesoEmplazamiento.TipoAccesoId),
                ProblemasDetectados = await _context.TipoOK.FindAsync(designACAccesoEmplazamiento.ProblemasDetectadosId),
                TipoRangoHorario = await _context.TipoRangoHorario.FindAsync(designACAccesoEmplazamiento.TipoRangoHorarioId),
                NecesidadAlpinista = await _context.TipoOK.FindAsync(designACAccesoEmplazamiento.NecesidadAlpinistaId),
                Comentarios = designACAccesoEmplazamiento.Comentarios,
            };
        }

        public async Task<DesignACDatos> ToDesignACDatos(DesignACDatosDTO designACDatos, DesignAC designAC)
        {
            return new DesignACDatos
            {
                Id = designACDatos.Id,
                DesignAC = designAC,
                FechaVisita = designACDatos.FechaVisita,
                FechaUltimoDiseno = designACDatos.FechaUltimoDiseno,
                FechaUltimoDisenoAceptado = designACDatos.FechaUltimoDisenoAceptado,
                ActuacionTorres = await _context.TipoSiNo.FindAsync(designACDatos.ActuacionTorresId),
                SinObra = designACDatos.SinObra,
                Sustancial = designACDatos.Sustancial,
                NoSustancial = designACDatos.NoSustancial,
                NecesarioAdecuacion = await _context.TipoSiNo.FindAsync(designACDatos.NecesarioAdecuacionId),
                ObservacionesAdecuacion = designACDatos.ObservacionesAdecuacion,
                AlarmasExternas = designACDatos.AlarmasExternas,
                AlimentacionAcciones = designACDatos.AlimentacionAcciones,
                AlimentacionComentarios = designACDatos.AlimentacionComentarios,
                AntenasPasivosAcciones = designACDatos.AntenasPasivosAcciones,
                AntenasPasivosComentarios = designACDatos.AntenasPasivosComentarios,
                ComentariosTelxius = designACDatos.ComentariosTelxius,
                Energia = designACDatos.Energia,
                Equipo = designACDatos.Equipo,
                Otro = designACDatos.Otro,
                RBS = designACDatos.RBS,
                Repartidor = designACDatos.Repartidor,
                SSRR = designACDatos.SSRR,
                TCUComentarios = designACDatos.TCUComentarios,
                TomaTierra = designACDatos.TomaTierra,
                TXComentarios = designACDatos.TXComentarios,
            };
        }
    }
}
