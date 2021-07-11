using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoneyCoinAPI.Areas.carteira.Data;
using MoneyCoinAPI.Areas.carteira.Models;

namespace MoneyCoinAPI.Areas.carteira.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorretorasController : ControllerBase
    {
        private readonly CarteiraContext _context;

        public CorretorasController(CarteiraContext context)
        {
            _context = context;
        }

        // GET: api/Corretoras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Corretora>>> GetCorretora()
        {
            return await _context.Corretora.ToListAsync();
        }

        // GET: api/Corretoras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Corretora>> GetCorretora(int id)
        {
            var corretora = await _context.Corretora.FindAsync(id);

            if (corretora == null)
            {
                return NotFound();
            }

            return corretora;
        }

        // PUT: api/Corretoras/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCorretora(int id, Corretora corretora)
        {
            if (id != corretora.Id)
            {
                return BadRequest();
            }

            _context.Entry(corretora).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CorretoraExists(id))
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

        // POST: api/Corretoras
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Corretora>> PostCorretora(Corretora corretora)
        {
            _context.Corretora.Add(corretora);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCorretora", new { id = corretora.Id }, corretora);
        }

        // DELETE: api/Corretoras/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCorretora(int id)
        {
            var corretora = await _context.Corretora.FindAsync(id);
            if (corretora == null)
            {
                return NotFound();
            }

            _context.Corretora.Remove(corretora);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CorretoraExists(int id)
        {
            return _context.Corretora.Any(e => e.Id == id);
        }
    }
}
