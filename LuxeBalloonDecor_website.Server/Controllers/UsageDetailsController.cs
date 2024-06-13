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
    public class UsageDetailsController : ControllerBase
    {
        private readonly LuxeBalloonContext _context;

        public UsageDetailsController(LuxeBalloonContext context)
        {
            _context = context;
        }

        // GET: api/UsageDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsageDetails>>> GetUsageDetails()
        {
            return await _context.UsageDetails.ToListAsync();
        }

        // GET: api/UsageDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UsageDetails>> GetUsageDetails(int id)
        {
            var usageDetails = await _context.UsageDetails.FindAsync(id);

            if (usageDetails == null)
            {
                return NotFound();
            }

            return usageDetails;
        }

        // PUT: api/UsageDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsageDetails(int id, UsageDetails usageDetails)
        {
            if (id != usageDetails.usageID)
            {
                return BadRequest();
            }

            _context.Entry(usageDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsageDetailsExists(id))
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

        // POST: api/UsageDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UsageDetails>> PostUsageDetails(UsageDetails usageDetails)
        {
            _context.UsageDetails.Add(usageDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsageDetails", new { id = usageDetails.usageID }, usageDetails);
        }

        // DELETE: api/UsageDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsageDetails(int id)
        {
            var usageDetails = await _context.UsageDetails.FindAsync(id);
            if (usageDetails == null)
            {
                return NotFound();
            }

            _context.UsageDetails.Remove(usageDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsageDetailsExists(int id)
        {
            return _context.UsageDetails.Any(e => e.usageID == id);
        }
    }
}
