using Customer.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Common.DTOs
{
    public class DesignACTipoEmplazamientoDTO
    {

        public int Id { get; set; }

        public int? TipoEstacionId { get; set; }

        public List<TipoEstacion> TipoEstacion { get; set; }

        public int? TipoCasetaId { get; set; }

        public List<TipoCaseta> TipoCaseta { get; set; }

        public int? TipoInstalacionExteriorId { get; set; }

        public List<TipoInstalacionExterior> TipoInstalacionExterior { get; set; }

        public int? TipoPropiertarioEmplazamientoId { get; set; }

        public List<TipoPropiertarioEmplazamiento> TipoPropiertarioEmplazamiento { get; set; }

        public bool NotShared { get; set; }

        public bool Vodafone { get; set; }

        public bool Orange { get; set; }

        public bool Telxius { get; set; }

        public bool Yoigo { get; set; }

        public bool Adif { get; set; }

        public bool Others { get; set; }

        public bool Cellnex { get; set; }
    }
}
