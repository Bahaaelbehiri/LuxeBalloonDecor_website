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
    public class MultimediaContentController : ControllerBase
    {
        private readonly LuxeBalloonContext _context;

        public MultimediaContentController(LuxeBalloonContext context)
        {
            _context = context;
        }

        // GET: api/MultimediaContent
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MultimediaContent>>> GetMultimediaContent()
        {
            return await _context.MultimediaContent.ToListAsync();
        }

        // GET: api/MultimediaContent/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MultimediaContent>> GetMultimediaContent(int id)
        {
            var multimediaContent = await _context.MultimediaContent.FindAsync(id);

            if (multimediaContent == null)
            {
                return NotFound();
            }

            return multimediaContent;
        }

        // PUT: api/MultimediaContent/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMultimediaContent(int id, MultimediaContent multimediaContent)
        {
            if (id != multimediaContent.multimediaContentID)
            {
                return BadRequest();
            }

            _context.Entry(multimediaContent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MultimediaContentExists(id))
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

        // POST: api/MultimediaContent
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MultimediaContent>> PostMultimediaContent(MultimediaContent multimediaContent)
        {
            _context.MultimediaContent.Add(multimediaContent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMultimediaContent", new { id = multimediaContent.multimediaContentID }, multimediaContent);
        }

        // DELETE: api/MultimediaContent/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMultimediaContent(int id)
        {
            var multimediaContent = await _context.MultimediaContent.FindAsync(id);
            if (multimediaContent == null)
            {
                return NotFound();
            }

            _context.MultimediaContent.Remove(multimediaContent);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MultimediaContentExists(int id)
        {
            return _context.MultimediaContent.Any(e => e.multimediaContentID == id);
        }
    }
}
