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
    public class PageController : ControllerBase
    {
        private readonly LuxeBalloonContext _context;

        public PageController(LuxeBalloonContext context)
        {
            _context = context;
        }

        // GET: api/Page
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Page>>> GetPage()
        {
            return await _context.Page.ToListAsync();
        }

        // GET: api/Page/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Page>> GetPage(int id)
        {
            var page = await _context.Page.FindAsync(id);

            if (page == null)
            {
                return NotFound();
            }

            return page;
        }

        // PUT: api/Page/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPage(int id, Page page)
        {
            if (id != page.pageID)
            {
                return BadRequest();
            }

            _context.Entry(page).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PageExists(id))
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

        // POST: api/Page
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Page>> PostPage(Page page)
        {
            _context.Page.Add(page);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPage", new { id = page.pageID }, page);
        }

        // DELETE: api/Page/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePage(int id)
        {
            var page = await _context.Page.FindAsync(id);
            if (page == null)
            {
                return NotFound();
            }

            _context.Page.Remove(page);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PageExists(int id)
        {
            return _context.Page.Any(e => e.pageID == id);
        }
    }
}
