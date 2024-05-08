using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LuxeBalloonDecor_website.Server.Data;
using LuxeBalloonDecor_website.Server.Models;

namespace LuxeBalloonDecor_website.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VariantPricesController : ControllerBase
    {
        private readonly LuxeBalloonContext _context;

        public VariantPricesController(LuxeBalloonContext context)
        {
            _context = context;
        }

        // GET: api/VariantPrices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VariantPrice>>> GetVariantPrice()
        {
            return await _context.VariantPrice.ToListAsync();
        }

        // GET: api/VariantPrices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VariantPrice>> GetVariantPrice(int id)
        {
            var variantPrice = await _context.VariantPrice.FindAsync(id);

            if (variantPrice == null)
            {
                return NotFound();
            }

            return variantPrice;
        }

        // PUT: api/VariantPrices/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVariantPrice(int id, VariantPrice variantPrice)
        {
            if (id != variantPrice.PriceId)
            {
                return BadRequest();
            }

            _context.Entry(variantPrice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VariantPriceExists(id))
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

        // POST: api/VariantPrices
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VariantPrice>> PostVariantPrice(VariantPrice variantPrice)
        {
            _context.VariantPrice.Add(variantPrice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVariantPrice", new { id = variantPrice.PriceId }, variantPrice);
        }

        // DELETE: api/VariantPrices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVariantPrice(int id)
        {
            var variantPrice = await _context.VariantPrice.FindAsync(id);
            if (variantPrice == null)
            {
                return NotFound();
            }

            _context.VariantPrice.Remove(variantPrice);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VariantPriceExists(int id)
        {
            return _context.VariantPrice.Any(e => e.PriceId == id);
        }
    }
}
