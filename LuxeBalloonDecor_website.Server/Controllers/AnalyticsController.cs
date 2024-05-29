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
    public class AnalyticsController : ControllerBase
    {
        private readonly LuxeBalloonContext _context;

        public AnalyticsController(LuxeBalloonContext context)
        {
            _context = context;
        }

        // GET: api/Analytics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Analytics>>> GetAnalytics()
        {
            return await _context.Analytics.ToListAsync();
        }

        // GET: api/Analytics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Analytics>> GetAnalytics(int id)
        {
            var analytics = await _context.Analytics.FindAsync(id);

            if (analytics == null)
            {
                return NotFound();
            }

            return analytics;
        }

        // PUT: api/Analytics/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnalytics(int id, Analytics analytics)
        {
            if (id != analytics.analyticsID)
            {
                return BadRequest();
            }

            _context.Entry(analytics).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnalyticsExists(id))
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

        // POST: api/Analytics
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Analytics>> PostAnalytics(Analytics analytics)
        {
            _context.Analytics.Add(analytics);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnalytics", new { id = analytics.analyticsID }, analytics);
        }

        // DELETE: api/Analytics/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnalytics(int id)
        {
            var analytics = await _context.Analytics.FindAsync(id);
            if (analytics == null)
            {
                return NotFound();
            }

            _context.Analytics.Remove(analytics);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnalyticsExists(int id)
        {
            return _context.Analytics.Any(e => e.analyticsID == id);
        }
    }
}
