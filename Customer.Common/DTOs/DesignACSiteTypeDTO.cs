using Customer.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Common.DTOs
{
    public class DesignACSiteTypeDTO
    {

        public int Id { get; set; }

        public int? StationId { get; set; }

        public List<TypeStation> TypeStations { get; set; }

        public int? StandId { get; set; }

        public List<TypeStand> TypeStands { get; set; }

        public int? OutdoorInstallationId { get; set; }

        public List<TypeOutdoorInstallation> TypeOutdoorInstallations { get; set; }

        public int? SiteOwnerId { get; set; }

        public List<TypeSiteOwner> TypeSiteOwners { get; set; }

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
