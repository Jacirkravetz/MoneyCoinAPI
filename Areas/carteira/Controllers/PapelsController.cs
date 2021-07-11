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
    public class PapelsController : ControllerBase
    {
        private readonly CarteiraContext _context;

        public PapelsController(CarteiraContext context)
        {
            _context = context;
        }

        // GET: api/Papels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Papel>>> GetPapel()
        {
            return await _context.Papel.ToListAsync();
        }

        // GET: api/Papels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Papel>> GetPapel(int id)
        {
            var papel = await _context.Papel.FindAsync(id);

            if (papel == null)
            {
                return NotFound();
            }

            return papel;
        }

        // PUT: api/Papels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPapel(int id, Papel papel)
        {
            if (id != papel.Id)
            {
                return BadRequest();
            }

            _context.Entry(papel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PapelExists(id))
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

        // POST: api/Papels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Papel>> PostPapel(Papel papel)
        {
            _context.Papel.Add(papel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPapel", new { id = papel.Id }, papel);
        }

        // DELETE: api/Papels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePapel(int id)
        {
            var papel = await _context.Papel.FindAsync(id);
            if (papel == null)
            {
                return NotFound();
            }

            _context.Papel.Remove(papel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PapelExists(int id)
        {
            return _context.Papel.Any(e => e.Id == id);
        }
    }
}
