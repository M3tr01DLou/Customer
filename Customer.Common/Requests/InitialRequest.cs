using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Common.Requests
{
    public class InitialRequest
    {
        public string VersionId { get; set; }

        public string Emplazamiento { get; set; }

        public string Usuario { get; set; }

        public string Operador { get; set; }

        public string OperadorId { get; set; }

        public string Empresa { get; set; }

        public string Organizacion { get; set; }

        public string Administrador { get; set; }

        public string Proyecto { get; set; }

        public string Pais { get; set; }

        public string Seccion { get; set; }
    }
}
