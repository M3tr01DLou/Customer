using Customer.API.Data;
using Customer.Common.Entities;
using Customer.Common.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Customer.API.Controllers
{
    [ApiController]
    [Route("/api/core")]
    public class CoresController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public CoresController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost("InitialChecks")]
        public async Task<ActionResult> InitialChecks([FromBody] InitialRequest initialRequest)
        {
            var asp = await _dataContext.Asps.FirstOrDefaultAsync(a => a.Nombre == initialRequest.Empresa);
            if (asp == null)
            {
                asp = new Asp { Nombre = initialRequest.Empresa, UsuarioGenericoGestorDocumental = "asp_instalacion" };
                _dataContext.Add(asp);
                await _dataContext.SaveChangesAsync();
            }

            var country = await _dataContext.Paises.FirstOrDefaultAsync(c => c.Nombre == initialRequest.Pais);
            if (country == null)
            {
                country = new Pais { Nombre = initialRequest.Pais, Activo = true };
                _dataContext.Add(country);
                await _dataContext.SaveChangesAsync();
            }

            var project = await _dataContext.Proyectos.FirstOrDefaultAsync(p => p.Nombre == initialRequest.Proyecto);
            if (project == null)
            {
                project = new Proyecto { Nombre = initialRequest.Proyecto, Activo = true };
                _dataContext.Add(project);
                await _dataContext.SaveChangesAsync();
            }

            var operador = await _dataContext.Operadores.FirstOrDefaultAsync(o => o.Nombre == initialRequest.Operador && o.OperatorId.ToString() == initialRequest.OperadorId);
            if (operador == null)
            {
                operador = new Operador { OperatorId = int.Parse(initialRequest.OperadorId), Nombre = initialRequest.Operador, Activo = true };
                _dataContext.Add(operador);
                await _dataContext.SaveChangesAsync();
            }

            var user = await _dataContext.Usuarios.FirstOrDefaultAsync(u => u.Login == initialRequest.Usuario);
            if (user == null)
            {
                user = new Usuario { Nombre = initialRequest.Usuario, Login = initialRequest.Usuario, Asp = asp, Organizacion = initialRequest.Organizacion, Administrador = bool.Parse(initialRequest.Administrador) };
                _dataContext.Add(user);
            }
            else
            {
                user.Asp = asp;
                user.Organizacion = initialRequest.Organizacion;
                user.Administrador = bool.Parse(initialRequest.Administrador);
                _dataContext.Update(user);
            }
            await _dataContext.SaveChangesAsync();

            if (initialRequest.Seccion == "actuacionCaseta")
            {
                var design = await _dataContext.DesignAC
                    .Include(u => u.Usuario)
                    .Include(o => o.Operador)
                    .Include(p => p.Proyecto)
                    .Include(c => c.Pais)
                    .Include(s => s.TipoEstadoDiseno)
                    .FirstOrDefaultAsync(d => d.VersionId.ToString() == initialRequest.VersionId);
                if (design == null)
                {
                    design = new DesignAC {
                        VersionId = int.Parse(initialRequest.VersionId),
                        Emplazamiento = initialRequest.Emplazamiento,
                        Usuario = user,
                        Operador = operador,
                        Proyecto = project,
                        Pais =country,
                        TipoEstadoDiseno = await _dataContext.TipoEstadoDiseno.FirstOrDefaultAsync(s => s.Estado == "On Going"),
                    };
                    _dataContext.Add(design);
                    await _dataContext.SaveChangesAsync();

                    DesignACTipoEmplazamiento designACSiteType = new() { DesignAC = design };
                    _dataContext.Add(designACSiteType);
                    await _dataContext.SaveChangesAsync();

                    DesignACResumenRadio designACRadioSummary;
                    designACRadioSummary = new() { DesignAC = design, Tecnologia = "L800", Comentarios = "N/A", Necesita = "N/A" };
                    _dataContext.Add(designACRadioSummary);
                    designACRadioSummary = new() { DesignAC = design, Tecnologia = "G900", Comentarios = "N/A", Necesita = "N/A" };
                    _dataContext.Add(designACRadioSummary);
                    designACRadioSummary = new() { DesignAC = design, Tecnologia = "U900", Comentarios = "N/A", Necesita = "N/A" };
                    _dataContext.Add(designACRadioSummary);
                    designACRadioSummary = new() { DesignAC = design, Tecnologia = "L900", Comentarios = "N/A", Necesita = "N/A" };
                    _dataContext.Add(designACRadioSummary);
                    designACRadioSummary = new() { DesignAC = design, Tecnologia = "G1800", Comentarios = "N/A", Necesita = "N/A" };
                    _dataContext.Add(designACRadioSummary);
                    designACRadioSummary = new() { DesignAC = design, Tecnologia = "L1800", Comentarios = "N/A", Necesita = "N/A" };
                    _dataContext.Add(designACRadioSummary);
                    designACRadioSummary = new() { DesignAC = design, Tecnologia = "U2100", Comentarios = "N/A", Necesita = "N/A" };
                    _dataContext.Add(designACRadioSummary);
                    designACRadioSummary = new() { DesignAC = design, Tecnologia = "L2100", Comentarios = "N/A", Necesita = "N/A" };
                    _dataContext.Add(designACRadioSummary);
                    designACRadioSummary = new() { DesignAC = design, Tecnologia = "L2600", Comentarios = "N/A", Necesita = "N/A" };
                    _dataContext.Add(designACRadioSummary);
                    designACRadioSummary = new() { DesignAC = design, Tecnologia = "L3500", Comentarios = "N/A", Necesita = "N/A" };
                    _dataContext.Add(designACRadioSummary);
                    designACRadioSummary = new() { DesignAC = design, Tecnologia = "NR3600", Comentarios = "N/A", Necesita = "N/A" };
                    _dataContext.Add(designACRadioSummary);
                    designACRadioSummary = new() { DesignAC = design, Tecnologia = "ESS700", Comentarios = "N/A", Necesita = "N/A" };
                    _dataContext.Add(designACRadioSummary);
                    await _dataContext.SaveChangesAsync();

                    DesignACAccesoEmplazamiento designACAccesoEmplazamiento = new() { DesignAC = design };
                    _dataContext.Add(designACAccesoEmplazamiento);
                    await _dataContext.SaveChangesAsync();

                    DesignACDatos designACDatos = new() { DesignAC = design };
                    _dataContext.Add(designACDatos);
                    await _dataContext.SaveChangesAsync();
                }
                else
                {
                    design.Usuario = user;
                    _dataContext.Update(design);
                    await _dataContext.SaveChangesAsync();
                }

                //design = await _dataContext.DesignACs
                //    .Include(s => s.State)
                //    .FirstOrDefaultAsync(d => d.VersionId.ToString() == initialRequest.VersionId);
                //if (design.State == null)
                //{
                //    design.State = await _dataContext.States.FirstOrDefaultAsync(s => s.Status == "On Going");
                //    await _dataContext.SaveChangesAsync();
                //}

                return Ok(design);
            }

            return BadRequest();
        }

    }
}
