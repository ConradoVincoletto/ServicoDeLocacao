using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServicoDeLocacao_API.Data;
using ServicoDeLocacao_API.Models;

namespace ServicoDeLocacao_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalCarsController : ControllerBase
    {
        private readonly Contexto _context;

        public RentalCarsController(Contexto context)
        {
            _context = context;
        }

        // GET: api/RentalCars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RentalCar>>> GetRentalCars()
        {
          if (_context.RentalCars == null)
          {
              return NotFound();
          }
            return await _context.RentalCars.ToListAsync();
        }

        // GET: api/RentalCars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RentalCar>> GetRentalCar(int id)
        {
          if (_context.RentalCars == null)
          {
              return NotFound();
          }
            var rentalCar = await _context.RentalCars.FindAsync(id);

            if (rentalCar == null)
            {
                return NotFound();
            }

            return rentalCar;
        }

        // PUT: api/RentalCars/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRentalCar(int id, RentalCar rentalCar)
        {
            if (id != rentalCar.Id)
            {
                return BadRequest();
            }

            _context.Entry(rentalCar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RentalCarExists(id))
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

        // POST: api/RentalCars
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RentalCar>> PostRentalCar(RentalCar rentalCar)
        {
          if (_context.RentalCars == null)
          {
              return Problem("Entity set 'Contexto.RentalCars'  is null.");
          }
            _context.RentalCars.Add(rentalCar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRentalCar", new { id = rentalCar.Id }, rentalCar);
        }

        // DELETE: api/RentalCars/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRentalCar(int id)
        {
            if (_context.RentalCars == null)
            {
                return NotFound();
            }
            var rentalCar = await _context.RentalCars.FindAsync(id);
            if (rentalCar == null)
            {
                return NotFound();
            }

            _context.RentalCars.Remove(rentalCar);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RentalCarExists(int id)
        {
            return (_context.RentalCars?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
