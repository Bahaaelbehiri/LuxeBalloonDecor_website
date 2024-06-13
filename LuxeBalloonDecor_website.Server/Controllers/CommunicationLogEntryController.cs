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
    public class CommunicationLogEntryController : ControllerBase
    {
        private readonly LuxeBalloonContext _context;

        public CommunicationLogEntryController(LuxeBalloonContext context)
        {
            _context = context;
        }

        // GET: api/CommunicationLogEntry
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommunicationLogEntry>>> GetCommunicationLogEntry()
        {
            return await _context.CommunicationLogEntry.ToListAsync();
        }

        // GET: api/CommunicationLogEntry/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CommunicationLogEntry>> GetCommunicationLogEntry(int id)
        {
            var communicationLogEntry = await _context.CommunicationLogEntry.FindAsync(id);

            if (communicationLogEntry == null)
            {
                return NotFound();
            }

            return communicationLogEntry;
        }

        // PUT: api/CommunicationLogEntry/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommunicationLogEntry(int id, CommunicationLogEntry communicationLogEntry)
        {
            if (id != communicationLogEntry.logID)
            {
                return BadRequest();
            }

            _context.Entry(communicationLogEntry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommunicationLogEntryExists(id))
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

        // POST: api/CommunicationLogEntry
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CommunicationLogEntry>> PostCommunicationLogEntry(CommunicationLogEntry communicationLogEntry)
        {
            _context.CommunicationLogEntry.Add(communicationLogEntry);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCommunicationLogEntry", new { id = communicationLogEntry.logID }, communicationLogEntry);
        }

        // DELETE: api/CommunicationLogEntry/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommunicationLogEntry(int id)
        {
            var communicationLogEntry = await _context.CommunicationLogEntry.FindAsync(id);
            if (communicationLogEntry == null)
            {
                return NotFound();
            }

            _context.CommunicationLogEntry.Remove(communicationLogEntry);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CommunicationLogEntryExists(int id)
        {
            return _context.CommunicationLogEntry.Any(e => e.logID == id);
        }
    }
}
