using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Data;
using Api.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarifasController : ControllerBase
    {
        private readonly Context _context;

        public TarifasController(Context context)
        {
            _context = context;
        }

        // GET: api/Tarifas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tarifa>>> GetTarifa()
        {
            return await _context.Tarifa.ToListAsync();
        }

        // GET: api/Tarifas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tarifa>> GetTarifa(int id)
        {
            var tarifa = await _context.Tarifa.FindAsync(id);

            if (tarifa == null)
            {
                return NotFound();
            }

            return tarifa;
        }

        // PUT: api/Tarifas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTarifa(int id, Tarifa tarifa)
        {
            if (id != tarifa.id)
            {
                return BadRequest();
            }

            _context.Entry(tarifa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TarifaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Tarifas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tarifa>> PostTarifa(Tarifa tarifa)
        {
            _context.Tarifa.Add(tarifa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTarifa", new { id = tarifa.id }, tarifa);
        }

        // DELETE: api/Tarifas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tarifa>> DeleteTarifa(int id)
        {
            var tarifa = await _context.Tarifa.FindAsync(id);
            if (tarifa == null)
            {
                return NotFound();
            }

            _context.Tarifa.Remove(tarifa);
            await _context.SaveChangesAsync();

            return tarifa;
        }

        private bool TarifaExists(int id)
        {
            return _context.Tarifa.Any(e => e.id == id);
        }
    }
}
