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
    public class TestimonialsController : ControllerBase
    {
        private readonly LuxeBalloonContext _context;

        public TestimonialsController(LuxeBalloonContext context)
        {
            _context = context;
        }

        // GET: api/Testimonials
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Testimonial>>> GetTestimonial()
        {
            return await _context.Testimonial.ToListAsync();
        }

        // GET: api/Testimonials/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Testimonial>> GetTestimonial(int id)
        {
            var testimonial = await _context.Testimonial.FindAsync(id);

            if (testimonial == null)
            {
                return NotFound();
            }

            return testimonial;
        }

        // PUT: api/Testimonials/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTestimonial(int id, Testimonial testimonial)
        {
            if (id != testimonial.TestimonailID)
            {
                return BadRequest();
            }

            _context.Entry(testimonial).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestimonialExists(id))
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

        // POST: api/Testimonials
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Testimonial>> PostTestimonial(Testimonial testimonial)
        {
            _context.Testimonial.Add(testimonial);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTestimonial", new { id = testimonial.TestimonailID }, testimonial);
        }

        // DELETE: api/Testimonials/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            var testimonial = await _context.Testimonial.FindAsync(id);
            if (testimonial == null)
            {
                return NotFound();
            }

            _context.Testimonial.Remove(testimonial);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TestimonialExists(int id)
        {
            return _context.Testimonial.Any(e => e.TestimonailID == id);
        }
    }
}
