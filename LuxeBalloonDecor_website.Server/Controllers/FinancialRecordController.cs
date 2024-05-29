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
    public class FinancialRecordController : ControllerBase
    {
        private readonly LuxeBalloonContext _context;

        public FinancialRecordController(LuxeBalloonContext context)
        {
            _context = context;
        }

        // GET: api/FinancialRecord
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FinancialRecord>>> GetFinancialRecord()
        {
            return await _context.FinancialRecord.ToListAsync();
        }

        // GET: api/FinancialRecord/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FinancialRecord>> GetFinancialRecord(int id)
        {
            var financialRecord = await _context.FinancialRecord.FindAsync(id);

            if (financialRecord == null)
            {
                return NotFound();
            }

            return financialRecord;
        }

        // PUT: api/FinancialRecord/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFinancialRecord(int id, FinancialRecord financialRecord)
        {
            if (id != financialRecord.financialRecordID)
            {
                return BadRequest();
            }

            _context.Entry(financialRecord).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FinancialRecordExists(id))
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

        // POST: api/FinancialRecord
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FinancialRecord>> PostFinancialRecord(FinancialRecord financialRecord)
        {
            _context.FinancialRecord.Add(financialRecord);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFinancialRecord", new { id = financialRecord.financialRecordID }, financialRecord);
        }

        // DELETE: api/FinancialRecord/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFinancialRecord(int id)
        {
            var financialRecord = await _context.FinancialRecord.FindAsync(id);
            if (financialRecord == null)
            {
                return NotFound();
            }

            _context.FinancialRecord.Remove(financialRecord);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FinancialRecordExists(int id)
        {
            return _context.FinancialRecord.Any(e => e.financialRecordID == id);
        }
    }
}
