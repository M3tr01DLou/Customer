using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Common.Entities
{
    public class DesignACDatos
    {
        public int Id { get; set; }

        public DesignAC DesignAC { get; set; }

        public DateTime FechaVisita { get; set; }

        public DateTime FechaUltimoDiseno { get; set; }

        public DateTime FechaUltimoDisenoAceptado { get; set; }

        public TipoSiNo ActuacionTorres { get; set; }

        public bool SinObra { get; set; }

        public bool Sustancial { get; set; }

        public bool NoSustancial { get; set; }

        public string ComentariosTelxius { get; set; }

        public TipoSiNo NecesarioAdecuacion { get; set; }

        public string ObservacionesAdecuacion { get; set; }

        public string RBS { get; set; }

        public string SSRR { get; set; }

        public string Energia { get; set; }

        public string Equipo { get; set; }

        public string Otro { get; set; }

        public string TomaTierra { get; set; }

        public string Repartidor { get; set; }

        public string AlarmasExternas { get; set; }

        public string AntenasPasivosComentarios { get; set; }

        public string AntenasPasivosAcciones { get; set; }

        public string AlimentacionComentarios { get; set; }

        public string AlimentacionAcciones { get; set; }

        public string TCUComentarios { get; set; }

        public string TXComentarios { get; set; }
    }
}
