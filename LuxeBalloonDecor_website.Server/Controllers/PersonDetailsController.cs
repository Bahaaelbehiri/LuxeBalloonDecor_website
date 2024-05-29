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
    public class PersonDetailsController : ControllerBase
    {
        private readonly LuxeBalloonContext _context;

        public PersonDetailsController(LuxeBalloonContext context)
        {
            _context = context;
        }

        // GET: api/PersonDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonDetails>>> GetPersonDetails()
        {
            return await _context.PersonDetails.ToListAsync();
        }

        // GET: api/PersonDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonDetails>> GetPersonDetails(int id)
        {
            var personDetails = await _context.PersonDetails.FindAsync(id);

            if (personDetails == null)
            {
                return NotFound();
            }

            return personDetails;
        }

        // PUT: api/PersonDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonDetails(int id, PersonDetails personDetails)
        {
            if (id != personDetails.personID)
            {
                return BadRequest();
            }

            _context.Entry(personDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonDetailsExists(id))
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

        // POST: api/PersonDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PersonDetails>> PostPersonDetails(PersonDetails personDetails)
        {
            _context.PersonDetails.Add(personDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersonDetails", new { id = personDetails.personID }, personDetails);
        }

        // DELETE: api/PersonDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonDetails(int id)
        {
            var personDetails = await _context.PersonDetails.FindAsync(id);
            if (personDetails == null)
            {
                return NotFound();
            }

            _context.PersonDetails.Remove(personDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonDetailsExists(int id)
        {
            return _context.PersonDetails.Any(e => e.personID == id);
        }
    }
}
