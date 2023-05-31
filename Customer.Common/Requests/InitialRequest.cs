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

        public string Site { get; set; }

        public string User { get; set; }

        public string Operator { get; set; }

        public string OperatorId { get; set; }

        public string Company { get; set; }

        public string Organization { get; set; }

        public string Administrator { get; set; }

        public string Project { get; set; }

        public string Country { get; set; }

        public string Section { get; set; }
    }
}
