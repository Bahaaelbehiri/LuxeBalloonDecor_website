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
    public class ContactInfoController : ControllerBase
    {
        private readonly LuxeBalloonContext _context;

        public ContactInfoController(LuxeBalloonContext context)
        {
            _context = context;
        }

        // GET: api/ContactInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactInfo>>> GetContactInfo()
        {
            return await _context.ContactInfo.ToListAsync();
        }

        // GET: api/ContactInfo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContactInfo>> GetContactInfo(int id)
        {
            var contactInfo = await _context.ContactInfo.FindAsync(id);

            if (contactInfo == null)
            {
                return NotFound();
            }

            return contactInfo;
        }

        // PUT: api/ContactInfo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContactInfo(int id, ContactInfo contactInfo)
        {
            if (id != contactInfo.contactInfoID)
            {
                return BadRequest();
            }

            _context.Entry(contactInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactInfoExists(id))
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

        // POST: api/ContactInfo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ContactInfo>> PostContactInfo(ContactInfo contactInfo)
        {
            _context.ContactInfo.Add(contactInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContactInfo", new { id = contactInfo.contactInfoID }, contactInfo);
        }

        // DELETE: api/ContactInfo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContactInfo(int id)
        {
            var contactInfo = await _context.ContactInfo.FindAsync(id);
            if (contactInfo == null)
            {
                return NotFound();
            }

            _context.ContactInfo.Remove(contactInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContactInfoExists(int id)
        {
            return _context.ContactInfo.Any(e => e.contactInfoID == id);
        }
    }
}
