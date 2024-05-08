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
    public class InventoryVariantsController : ControllerBase
    {
        private readonly LuxeBalloonContext _context;

        public InventoryVariantsController(LuxeBalloonContext context)
        {
            _context = context;
        }

        // GET: api/InventoryVariants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InventoryVariant>>> GetInventoryVariant()
        {
            return await _context.InventoryVariant.ToListAsync();
        }

        // GET: api/InventoryVariants/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InventoryVariant>> GetInventoryVariant(int id)
        {
            var inventoryVariant = await _context.InventoryVariant.FindAsync(id);

            if (inventoryVariant == null)
            {
                return NotFound();
            }

            return inventoryVariant;
        }

        // PUT: api/InventoryVariants/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventoryVariant(int id, InventoryVariant inventoryVariant)
        {
            if (id != inventoryVariant.VariantID)
            {
                return BadRequest();
            }

            _context.Entry(inventoryVariant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InventoryVariantExists(id))
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

        // POST: api/InventoryVariants
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<InventoryVariant>> PostInventoryVariant(InventoryVariant inventoryVariant)
        {
            _context.InventoryVariant.Add(inventoryVariant);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInventoryVariant", new { id = inventoryVariant.VariantID }, inventoryVariant);
        }

        // DELETE: api/InventoryVariants/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInventoryVariant(int id)
        {
            var inventoryVariant = await _context.InventoryVariant.FindAsync(id);
            if (inventoryVariant == null)
            {
                return NotFound();
            }

            _context.InventoryVariant.Remove(inventoryVariant);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InventoryVariantExists(int id)
        {
            return _context.InventoryVariant.Any(e => e.VariantID == id);
        }
    }
}
