using Customer.API.Data;
using Customer.Common.DTOs;
using Customer.Common.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Customer.API.Controllers
{
    [ApiController]
    [Route("/api/designac")]
    public class DesignACsController : ControllerBase
    {
        private readonly DataContext _context;

        public DesignACsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            DesignACDTO designACDTO = new()
            {
                DesignACId = id,
                DesignACSiteTypeDTO = new(),
                DesignACRadioSummaryDTO = new()
            };

            var designACSiteType = await _context.DesignACSiteTypes
                .Include(d => d.DesignAC)
                .Include(st => st.Station)
                .Include(s => s.Stand)
                .Include(so => so.SiteOwner)
                .Include(oi => oi.OutdoorInstallation)
                .Where(d => d.DesignAC.Id == id).FirstOrDefaultAsync();
            if (designACSiteType != null)
            {
                designACDTO.DesignACSiteTypeDTO.SiteOwnerId = designACSiteType.SiteOwner?.Id;
                designACDTO.DesignACSiteTypeDTO.StationId = designACSiteType.Station?.Id;
                designACDTO.DesignACSiteTypeDTO.StandId = designACSiteType.Stand?.Id;
                designACDTO.DesignACSiteTypeDTO.OutdoorInstallationId = designACSiteType.OutdoorInstallation?.Id;
                designACDTO.DesignACSiteTypeDTO.SharedLocationNotShared = designACSiteType.SharedLocationNotShared;
                designACDTO.DesignACSiteTypeDTO.SharedLocationVodafone = designACSiteType.SharedLocationVodafone;
                designACDTO.DesignACSiteTypeDTO.SharedLocationOrange = designACSiteType.SharedLocationOrange;
                designACDTO.DesignACSiteTypeDTO.SharedLocationTelxius = designACSiteType.SharedLocationTelxius;
                designACDTO.DesignACSiteTypeDTO.SharedLocationYoigo = designACSiteType.SharedLocationYoigo;
                designACDTO.DesignACSiteTypeDTO.SharedLocationAdif = designACSiteType.SharedLocationAdif;
                designACDTO.DesignACSiteTypeDTO.SharedLocationOthers = designACSiteType.SharedLocationOthers;
                designACDTO.DesignACSiteTypeDTO.SharedLocationCellnex = designACSiteType.SharedLocationCellnex;
            }
            designACDTO.DesignACSiteTypeDTO.TypeStations = await _context.TypeStations.ToListAsync();
            designACDTO.DesignACSiteTypeDTO.TypeStands = await _context.TypeStands.ToListAsync();
            designACDTO.DesignACSiteTypeDTO.TypeSiteOwners = await _context.TypeSiteOwners.ToListAsync();
            designACDTO.DesignACSiteTypeDTO.TypeOutdoorInstallations = await _context.TypeOutdoorInstallations.ToListAsync();

            designACDTO.DesignACRadioSummaryDTO = await _context.DesignACRadioSummaries!
                .Include(d => d.DesignAC)
                .Where(d => d.DesignAC.Id == id)
                .Select(rs => new DesignACRadioSummaryDTO {
                    Technology = rs.Technology,
                    Comments = rs.Comments,
                    Needs = rs.Needs
                })
                .ToListAsync();

            return Ok(designACDTO);
        }
    }
}
