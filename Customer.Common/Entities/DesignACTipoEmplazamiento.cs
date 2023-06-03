using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Common.Entities
{
    public class DesignACTipoEmplazamiento
    {
        public int Id { get; set; }

        public DesignAC DesignAC { get; set; }

        public TipoEstacion TipoEstacion { get; set; }

        public TipoCaseta TipoCaseta { get; set; }

        public TipoInstalacionExterior TipoInstalacionExterior { get; set; }

        public TipoPropiertarioEmplazamiento TipoPropiertarioEmplazamiento { get; set; }

        public bool NoCompartido { get; set; }

        public bool Vodafone { get; set; }

        public bool Orange { get; set; }

        public bool Telxius { get; set; }

        public bool Yoigo { get; set; }

        public bool Adif { get; set; }

        public bool Others { get; set; }

        public bool Cellnex { get; set; }
    }
}
