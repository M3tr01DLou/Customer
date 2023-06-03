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
                DesignACTipoEmplazamientoDTO = new(),
                DesignACResumenRadioL800_DTO = new(),
                DesignACResumenRadioG900_DTO = new(),
                DesignACResumenRadioU900_DTO = new(),
                DesignACResumenRadioL900_DTO = new(),
                DesignACResumenRadioG1800_DTO = new(),
                DesignACResumenRadioL1800_DTO = new(),
                DesignACResumenRadioU2100_DTO = new(),
                DesignACResumenRadioL2100_DTO = new(),
                DesignACResumenRadioL2600_DTO = new(),
                DesignACResumenRadioL3500_DTO = new(),
                DesignACResumenRadioNR3600_DTO = new(),
                DesignACResumenRadioESS700_DTO = new(),
				DesignACAccesoEmplazamientoDTO = new(),
			};

            var designACTipoEmplazazamiento = await _context.DesignACTipoEmplazamiento
                .Include(d => d.DesignAC)
                .Include(st => st.TipoEstacion)
                .Include(s => s.TipoCaseta)
                .Include(so => so.TipoPropiertarioEmplazamiento)
                .Include(oi => oi.TipoInstalacionExterior)
                .Where(d => d.DesignAC.Id == id)
                .FirstOrDefaultAsync();
            designACDTO.DesignACTipoEmplazamientoDTO = await _converterHelper.ToDesignACTipoEmplazamientoDTO(designACTipoEmplazazamiento!);

            var designACResumenRadio = await _context.DesignACResumenRadio!
                .Include(d => d.DesignAC)
                .Where(d => d.DesignAC.Id == id)
                .ToListAsync();

            designACDTO.DesignACResumenRadioL800_DTO = _converterHelper.ToDesignACResumenRadioDTO(designACResumenRadio, "L800");
            designACDTO.DesignACResumenRadioG900_DTO = _converterHelper.ToDesignACResumenRadioDTO(designACResumenRadio, "G900");
            designACDTO.DesignACResumenRadioU900_DTO = _converterHelper.ToDesignACResumenRadioDTO(designACResumenRadio, "U900");
            designACDTO.DesignACResumenRadioL900_DTO = _converterHelper.ToDesignACResumenRadioDTO(designACResumenRadio, "L900");
            designACDTO.DesignACResumenRadioG1800_DTO = _converterHelper.ToDesignACResumenRadioDTO(designACResumenRadio, "G1800");
            designACDTO.DesignACResumenRadioL1800_DTO = _converterHelper.ToDesignACResumenRadioDTO(designACResumenRadio, "L1800");
            designACDTO.DesignACResumenRadioU2100_DTO = _converterHelper.ToDesignACResumenRadioDTO(designACResumenRadio, "U2100");
            designACDTO.DesignACResumenRadioL2100_DTO = _converterHelper.ToDesignACResumenRadioDTO(designACResumenRadio, "L2100");
            designACDTO.DesignACResumenRadioL2600_DTO = _converterHelper.ToDesignACResumenRadioDTO(designACResumenRadio, "L2600");
            designACDTO.DesignACResumenRadioL3500_DTO = _converterHelper.ToDesignACResumenRadioDTO(designACResumenRadio, "L3500");
            designACDTO.DesignACResumenRadioNR3600_DTO = _converterHelper.ToDesignACResumenRadioDTO(designACResumenRadio, "NR3600");
            designACDTO.DesignACResumenRadioESS700_DTO = _converterHelper.ToDesignACResumenRadioDTO(designACResumenRadio, "ESS700");

            var designACAccesoEmplazamiento = await _context.DesignACAccesoEmplazamiento
				.Include(c => c.CaminoAcceso)
				.Include(c => c.NecesidadGrua)
				.Include(c => c.Tonelaje)
				.Include(c => c.TipoGrua)
				.Include(c => c.AccesoEmplazamiento)
				.Include(c => c.CajetinLlaves)
				.Include(c => c.TipoLlave)
				.Include(c => c.AccesoEntradaMaterial)
				.Include(c => c.TodasLlaveOK)
				.Include(c => c.AutorizacionEspecial)
				.Include(c => c.ContactoPropiedad)
				.Include(c => c.TipoAcceso)
				.Include(c => c.ProblemasDetectados)
				.Include(c => c.TipoRangoHorario)
				.Include(c => c.NecesidadAlpinista)
				.Where(d => d.DesignAC.Id == id)
				.FirstOrDefaultAsync();
			designACDTO.DesignACAccesoEmplazamientoDTO = await _converterHelper.ToDesignACAccesoEmplazamientoDTO(designACAccesoEmplazamiento!);

            var designACDatos = await _context.DesignACDatos
                .Include(a => a.ActuacionTorres)
                .Include(n => n.NecesarioAdecuacion)
                .Where(d => d.DesignAC.Id == id)
                .FirstOrDefaultAsync();
            designACDTO.DesignACDatosDTO = await _converterHelper.ToDesignACDatosDTO(designACDatos!);

            return Ok(designACDTO);
        }
    }
}
