using Customer.API.Data;
using Customer.Common.DTOs;
using Customer.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace Customer.API.Helpers
{
	public class ConverterHelper : IConverterHelper
    {
        private readonly ICombosHelper _combosHelper;

        public ConverterHelper(ICombosHelper combosHelper)
        {
            _combosHelper = combosHelper;
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

    }
}
