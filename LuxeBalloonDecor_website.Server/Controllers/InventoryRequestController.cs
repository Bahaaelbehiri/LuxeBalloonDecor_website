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
    public class InventoryRequestController : ControllerBase
    {
        private readonly LuxeBalloonContext _context;

        public InventoryRequestController(LuxeBalloonContext context)
        {
            _context = context;
        }

        // GET: api/InventoryRequest
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InventoryRequest>>> GetInventoryRequest()
        {
            return await _context.InventoryRequest.ToListAsync();
        }

        // GET: api/InventoryRequest/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InventoryRequest>> GetInventoryRequest(int id)
        {
            var inventoryRequest = await _context.InventoryRequest.FindAsync(id);

            if (inventoryRequest == null)
            {
                return NotFound();
            }

            return inventoryRequest;
        }

        // PUT: api/InventoryRequest/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventoryRequest(int id, InventoryRequest inventoryRequest)
        {
            if (id != inventoryRequest.requestID)
            {
                return BadRequest();
            }

            _context.Entry(inventoryRequest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InventoryRequestExists(id))
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

        // POST: api/InventoryRequest
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<InventoryRequest>> PostInventoryRequest(InventoryRequest inventoryRequest)
        {
            _context.InventoryRequest.Add(inventoryRequest);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInventoryRequest", new { id = inventoryRequest.requestID }, inventoryRequest);
        }

        // DELETE: api/InventoryRequest/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInventoryRequest(int id)
        {
            var inventoryRequest = await _context.InventoryRequest.FindAsync(id);
            if (inventoryRequest == null)
            {
                return NotFound();
            }

            _context.InventoryRequest.Remove(inventoryRequest);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InventoryRequestExists(int id)
        {
            return _context.InventoryRequest.Any(e => e.requestID == id);
        }
    }
}
