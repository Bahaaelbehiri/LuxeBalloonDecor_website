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
    public class StyleSettingsController : ControllerBase
    {
        private readonly LuxeBalloonContext _context;

        public StyleSettingsController(LuxeBalloonContext context)
        {
            _context = context;
        }

        // GET: api/StyleSettings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StyleSettings>>> GetStyleSettings()
        {
            return await _context.StyleSettings.ToListAsync();
        }

        // GET: api/StyleSettings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StyleSettings>> GetStyleSettings(int id)
        {
            var styleSettings = await _context.StyleSettings.FindAsync(id);

            if (styleSettings == null)
            {
                return NotFound();
            }

            return styleSettings;
        }

        // PUT: api/StyleSettings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStyleSettings(int id, StyleSettings styleSettings)
        {
            if (id != styleSettings.settingsID)
            {
                return BadRequest();
            }

            _context.Entry(styleSettings).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StyleSettingsExists(id))
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

        // POST: api/StyleSettings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StyleSettings>> PostStyleSettings(StyleSettings styleSettings)
        {
            _context.StyleSettings.Add(styleSettings);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStyleSettings", new { id = styleSettings.settingsID }, styleSettings);
        }

        // DELETE: api/StyleSettings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStyleSettings(int id)
        {
            var styleSettings = await _context.StyleSettings.FindAsync(id);
            if (styleSettings == null)
            {
                return NotFound();
            }

            _context.StyleSettings.Remove(styleSettings);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StyleSettingsExists(int id)
        {
            return _context.StyleSettings.Any(e => e.settingsID == id);
        }
    }
}
