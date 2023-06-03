using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Common.Entities
{
	public class DesignACAccesoEmplazamiento
	{
		public int Id { get; set; }

		public DesignAC DesignAC { get; set; }

        public TipoOK CaminoAcceso { get; set; }

		public TipoOK NecesidadGrua { get; set; }

        public bool Necesidad4x4 { get; set; }

		public TipoTonelaje Tonelaje { get; set; }

		public TipoGrua TipoGrua { get; set; }

		public TipoOK AccesoEmplazamiento { get; set; }

		public TipoOK CajetinLlaves { get; set; }

		public TipoLlave TipoLlave { get; set; }

		public TipoOK AccesoEntradaMaterial { get; set; }

		public TipoOK TodasLlaveOK { get; set; }

		public TipoOK AutorizacionEspecial { get; set; }

		public TipoOK ContactoPropiedad { get; set; }

		public TipoAcceso TipoAcceso { get; set; }

		public TipoOK ProblemasDetectados { get; set; }

		public TipoRangoHorario TipoRangoHorario { get; set; }

		public TipoOK NecesidadAlpinista { get; set; }

        public string Comentarios { get; set; }
    }
}
