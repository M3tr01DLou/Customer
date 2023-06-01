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
            var asp = await _dataContext.Asps.FirstOrDefaultAsync(a => a.Name == initialRequest.Company);
            if (asp == null)
            {
                _dataContext.Add(new Asp
                {
                    Name = initialRequest.Company,
                    GenericUserGestDoc = "asp_instalacion",
                });
                await _dataContext.SaveChangesAsync();
            }

            var country = await _dataContext.Countries.FirstOrDefaultAsync(c => c.Name == initialRequest.Country);
            if (country == null)
            {
                _dataContext.Add(new Country
                {
                    Name = initialRequest.Country,
                    Active = true,
                });
                await _dataContext.SaveChangesAsync();
            }

            var project = await _dataContext.Projects.FirstOrDefaultAsync(p => p.Name == initialRequest.Project);
            if (project == null)
            {
                _dataContext.Add(new Project
                {
                    Name = initialRequest.Project,
                    Active = true,
                });
                await _dataContext.SaveChangesAsync();
            }

            var operador = await _dataContext.Operators.FirstOrDefaultAsync(o => o.Name == initialRequest.Operator && o.OperatorId.ToString() == initialRequest.OperatorId);
            if (operador == null)
            {
                _dataContext.Add(new Operator
                {
                    OperatorId = int.Parse(initialRequest.OperatorId),
                    Name = initialRequest.Operator,
                    Active = true,
                });
                await _dataContext.SaveChangesAsync();
            }

            var user = await _dataContext.Users.FirstOrDefaultAsync(u => u.Login == initialRequest.User);
            if (user == null)
            {
                _dataContext.Add(new User
                {
                    Name = initialRequest.User,
                    Login = initialRequest.User,
                    Asp = await _dataContext.Asps.FirstOrDefaultAsync(a => a.Name == initialRequest.Company),
                    Organization = initialRequest.Organization,
                    Administrator = bool.Parse(initialRequest.Administrator)
                });
            }
            else
            {
                user.Asp = await _dataContext.Asps.FirstOrDefaultAsync(a => a.Name == initialRequest.Company);
                user.Organization = initialRequest.Organization;
                user.Administrator = bool.Parse(initialRequest.Administrator);
                _dataContext.Update(user);
            }
            await _dataContext.SaveChangesAsync();

            if (initialRequest.Section == "actuacionCaseta")
            {
                var design = await _dataContext.DesignACs
                    .Include(u => u.User)
                    .Include(o => o.Operator)
                    .Include(p => p.Project)
                    .Include(c => c.Country)
                    .Include(s => s.State)
                    .FirstOrDefaultAsync(d => d.VersionId.ToString() == initialRequest.VersionId);
                if (design == null)
                {
                    design = new DesignAC {
                        VersionId = int.Parse(initialRequest.VersionId),
                        Site = initialRequest.Site,
                        User = await _dataContext.Users.FirstOrDefaultAsync(u => u.Login == initialRequest.User),
                        Operator = await _dataContext.Operators.FirstOrDefaultAsync(o => o.Name == initialRequest.Operator && o.OperatorId.ToString() == initialRequest.OperatorId),
                        Project = await _dataContext.Projects.FirstOrDefaultAsync(p => p.Name == initialRequest.Project),
                        Country = await _dataContext.Countries.FirstOrDefaultAsync(c => c.Name == initialRequest.Country),
                        State = await _dataContext.States.FirstOrDefaultAsync(s => s.Status == "On Going"),
                    };
                    _dataContext.Add(design);
                    await _dataContext.SaveChangesAsync();

                    DesignACSiteType designACSiteType = new() { DesignAC = design };
                    _dataContext.Add(designACSiteType);
                    await _dataContext.SaveChangesAsync();
                }
                else
                {
                    design.User = await _dataContext.Users.FirstOrDefaultAsync(u => u.Login == initialRequest.User);
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
