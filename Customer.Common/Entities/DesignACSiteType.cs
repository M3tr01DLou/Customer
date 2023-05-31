using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Common.Entities
{
    public class DesignACSiteType
    {
        public int Id { get; set; }

        public DesignAC DesignAC { get; set; }

        public TypeStation Station { get; set; }

        public TypeStand Stand { get; set; }

        public TypeOutdoorInstallation OutdoorInstallation { get; set; }

        public TypeSiteOwner  SiteOwner { get; set; }

        public bool SharedLocationNotShared { get; set; }

        public bool SharedLocationVodafone { get; set; }

        public bool SharedLocationOrange { get; set; }

        public bool SharedLocationTelxius { get; set; }

        public bool SharedLocationYoigo { get; set; }

        public bool SharedLocationAdif { get; set; }

        public bool SharedLocationOthers { get; set; }

        public bool SharedLocationCellnex { get; set; }
    }
}
