using Customer.API.Data;
using Customer.API.Helpers;
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
        private readonly IConverterHelper _converterHelper;

        public DesignACsController(DataContext context, IConverterHelper converterHelper)
        {
            _context = context;
            _converterHelper = converterHelper;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            DesignACDTO designACDTO = new()
            {
                DesignACId = id,
                DesignACSiteTypeDTO = new(),
                DesignACRadioSummaryL800_DTO = new(),
                DesignACRadioSummaryG900_DTO = new(),
                DesignACRadioSummaryU900_DTO = new(),
                DesignACRadioSummaryL900_DTO = new(),
                DesignACRadioSummaryG1800_DTO = new(),
                DesignACRadioSummaryL1800_DTO = new(),
                DesignACRadioSummaryU2100_DTO = new(),
                DesignACRadioSummaryL2100_DTO = new(),
                DesignACRadioSummaryL2600_DTO = new(),
                DesignACRadioSummaryL3500_DTO = new(),
                DesignACRadioSummaryNR3600_DTO = new(),
                DesignACRadioSummaryESS700_DTO = new()
            };

            var designACSiteType = await _context.DesignACSiteTypes
                .Include(d => d.DesignAC)
                .Include(st => st.Station)
                .Include(s => s.Stand)
                .Include(so => so.SiteOwner)
                .Include(oi => oi.OutdoorInstallation)
                .Where(d => d.DesignAC.Id == id)
                .FirstOrDefaultAsync();
            designACDTO.DesignACSiteTypeDTO = await _converterHelper.ToDesignACSiteTypeDTO(designACSiteType!);

            List<DesignACRadioSummary> designACRadioSummary = await _context.DesignACRadioSummaries!
                .Include(d => d.DesignAC)
                .Where(d => d.DesignAC.Id == id)
                .ToListAsync();

            designACDTO.DesignACRadioSummaryL800_DTO = _converterHelper.ToDesignACRadioSummaryDTO(designACRadioSummary, "L800");
            designACDTO.DesignACRadioSummaryG900_DTO = _converterHelper.ToDesignACRadioSummaryDTO(designACRadioSummary, "G900");
            designACDTO.DesignACRadioSummaryU900_DTO = _converterHelper.ToDesignACRadioSummaryDTO(designACRadioSummary, "U900");
            designACDTO.DesignACRadioSummaryL900_DTO = _converterHelper.ToDesignACRadioSummaryDTO(designACRadioSummary, "L900");
            designACDTO.DesignACRadioSummaryG1800_DTO = _converterHelper.ToDesignACRadioSummaryDTO(designACRadioSummary, "G1800");
            designACDTO.DesignACRadioSummaryL1800_DTO = _converterHelper.ToDesignACRadioSummaryDTO(designACRadioSummary, "L1800");
            designACDTO.DesignACRadioSummaryU2100_DTO = _converterHelper.ToDesignACRadioSummaryDTO(designACRadioSummary, "U2100");
            designACDTO.DesignACRadioSummaryL2100_DTO = _converterHelper.ToDesignACRadioSummaryDTO(designACRadioSummary, "L2100");
            designACDTO.DesignACRadioSummaryL2600_DTO = _converterHelper.ToDesignACRadioSummaryDTO(designACRadioSummary, "L2600");
            designACDTO.DesignACRadioSummaryL3500_DTO = _converterHelper.ToDesignACRadioSummaryDTO(designACRadioSummary, "L3500");
            designACDTO.DesignACRadioSummaryNR3600_DTO = _converterHelper.ToDesignACRadioSummaryDTO(designACRadioSummary, "NR3600");
            designACDTO.DesignACRadioSummaryESS700_DTO = _converterHelper.ToDesignACRadioSummaryDTO(designACRadioSummary, "ESS700");

            return Ok(designACDTO);
        }
    }
}
