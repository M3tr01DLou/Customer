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

        public DesignACRadioSummaryDTO ToDesignACRadioSummaryDTO(List<DesignACRadioSummary> model, string technology)
        {
            DesignACRadioSummary designACRadioSummary = model.Where(rs => rs.Technology.Equals(technology)).FirstOrDefault()!;
            return new DesignACRadioSummaryDTO 
            { 
                Id = designACRadioSummary.Id,
                Technology = designACRadioSummary.Technology,
                Comments = designACRadioSummary.Comments,
                Needs = designACRadioSummary.Needs
            };  
        }

        public async Task<DesignACSiteTypeDTO> ToDesignACSiteTypeDTO(DesignACSiteType designACSiteType)
        {
            return new DesignACSiteTypeDTO
            {
                Id = designACSiteType.Id,
                SiteOwnerId = designACSiteType.SiteOwner?.Id,
                StationId = designACSiteType.Station?.Id,
                StandId = designACSiteType.Stand?.Id,
                OutdoorInstallationId = designACSiteType.OutdoorInstallation?.Id,
                SharedLocationNotShared = designACSiteType.SharedLocationNotShared,
                SharedLocationVodafone = designACSiteType.SharedLocationVodafone,
                SharedLocationOrange = designACSiteType.SharedLocationOrange,
                SharedLocationTelxius = designACSiteType.SharedLocationTelxius,
                SharedLocationYoigo = designACSiteType.SharedLocationYoigo,
                SharedLocationAdif = designACSiteType.SharedLocationAdif,
                SharedLocationOthers = designACSiteType.SharedLocationOthers,
                SharedLocationCellnex = designACSiteType.SharedLocationCellnex,
                TypeStations = await _combosHelper.GetComboTypeStationsAsync(),
                TypeStands = await _combosHelper.GetComboTypeStandsAsync(),
                TypeSiteOwners = await _combosHelper.GetComboTypeSiteOwnersAsync(),
                TypeOutdoorInstallations = await _combosHelper.GetComboTypeOutdoorInstallationsAsync()
            };
        }

    }
}
