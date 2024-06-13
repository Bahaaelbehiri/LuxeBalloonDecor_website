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
    public class PageElementController : ControllerBase
    {
        private readonly LuxeBalloonContext _context;

        public PageElementController(LuxeBalloonContext context)
        {
            _context = context;
        }

        // GET: api/PageElement
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PageElement>>> GetPageElement()
        {
            return await _context.PageElement.ToListAsync();
        }

        // GET: api/PageElement/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PageElement>> GetPageElement(int id)
        {
            var pageElement = await _context.PageElement.FindAsync(id);

            if (pageElement == null)
            {
                return NotFound();
            }

            return pageElement;
        }

        // PUT: api/PageElement/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPageElement(int id, PageElement pageElement)
        {
            if (id != pageElement.elementID)
            {
                return BadRequest();
            }

            _context.Entry(pageElement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PageElementExists(id))
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

        // POST: api/PageElement
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PageElement>> PostPageElement(PageElement pageElement)
        {
            _context.PageElement.Add(pageElement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPageElement", new { id = pageElement.elementID }, pageElement);
        }

        // DELETE: api/PageElement/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePageElement(int id)
        {
            var pageElement = await _context.PageElement.FindAsync(id);
            if (pageElement == null)
            {
                return NotFound();
            }

            _context.PageElement.Remove(pageElement);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PageElementExists(int id)
        {
            return _context.PageElement.Any(e => e.elementID == id);
        }
    }
}
