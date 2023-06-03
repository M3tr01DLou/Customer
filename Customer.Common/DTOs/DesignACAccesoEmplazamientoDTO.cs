using Customer.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Common.DTOs
{
	public class DesignACAccesoEmplazamientoDTO
	{
		public int Id { get; set; }

        public int? CaminoAccesoId { get; set; }

        public List<TipoOK> CaminoAcceso { get; set; }

        public int? NecesidadGruaId { get; set; }

        public List<TipoOK> NecesidadGrua { get; set; }

		public bool Necesidad4x4 { get; set; }

        public int? TonelajeId { get; set; }

        public List<TipoTonelaje> Tonelaje { get; set; }

        public int? TipoGruaId { get; set; }

        public List<TipoGrua> TipoGrua { get; set; }

		public int? AccesoEmplazamientoId { get; set; }

		public List<TipoOK> AccesoEmplazamiento { get; set; }

		public int? CajetinLlavesId { get; set; }

		public List<TipoOK> CajetinLlaves { get; set; }

		public int? TipoLlaveId { get; set; }

		public List<TipoLlave> TipoLlave { get; set; }

		public int? AccesoEntradaMaterialId { get; set; }

		public List<TipoOK> AccesoEntradaMaterial { get; set; }

		public int? TodasLlaveOKId { get; set; }

		public List<TipoOK> TodasLlaveOK { get; set; }

		public int? AutorizacionEspecialId { get; set; }

		public List<TipoOK> AutorizacionEspecial { get; set; }

		public int? ContactoPropiedadId { get; set; }

		public List<TipoOK> ContactoPropiedad { get; set; }

		public int? TipoAccesoId { get; set; }

		public List<TipoAcceso> TipoAcceso { get; set; }

		public int? ProblemasDetectadosId { get; set; }

		public List<TipoOK> ProblemasDetectados { get; set; }

		public int? TipoRangoHorarioId { get; set; }

		public List<TipoRangoHorario> TipoRangoHorario { get; set; }

		public int? NecesidadAlpinistaId { get; set; }

		public List<TipoOK> NecesidadAlpinista { get; set; }

		public string Comentarios { get; set; }
	}
}
