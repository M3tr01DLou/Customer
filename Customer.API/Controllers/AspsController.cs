using Customer.API.Data;
using Customer.Common.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace Customer.API.Controllers
{
    [ApiController]
    [Route("/api/asps")]
    public class AspsController : ControllerBase
    {
        private readonly DataContext _context;

        public AspsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllAsps")]
        public async Task<IActionResult> GetAspsAsync()
        {
            return Ok(await _context.Asps.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAspAsync(int id)
        {
            var asp = await _context.Asps.FindAsync(id);
            if(asp == null)
            {
                return NotFound();
            }

            return Ok(asp);
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync(Asp asp)
        {
            try
            {
                _context.Add(asp);
                await _context.SaveChangesAsync();
                return Ok(asp);
            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("Ya existe una asp con el mismo nombre.");
                }

                return BadRequest(dbUpdateException.Message);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> PutAsync(Asp asp)
        {
            try
            {
                _context.Update(asp);
                await _context.SaveChangesAsync();
                return Ok(asp);
            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("Ya existe una asp con el mismo nombre.");
                }

                return BadRequest(dbUpdateException.Message);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var asp = await _context.Asps.FirstOrDefaultAsync(x => x.Id == id);
            if (asp == null)
            {
                return NotFound();
            }

            _context.Remove(asp);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
