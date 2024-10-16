using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parcial20240221100940_DOMAIN.Data;

namespace Parcial20240221100940_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetencyController : ControllerBase
    {
        private readonly Parcial20240221100940Context _context;

        public CompetencyController(Parcial20240221100940Context context)
        {
            _context = context;
        }

        // POST
        [HttpPost]
        public async Task<ActionResult<Competency>> PostCompetency(Competency competency)
        {
            _context.Competency.Add(competency);
            await _context.SaveChangesAsync();
           
           return Ok(competency);
        }

        // PUT:
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompetency(int id, Competency competency)
        {
            if (id != competency.Id2)
            {
                return BadRequest();
            }

            _context.Entry(competency).State = EntityState.Modified;

            await _context.SaveChangesAsync();


            return Ok(competency);
        }

        // DELETE:
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompetency(int id)
        {
            var competency = await _context.Competency.FindAsync(id);
            if (competency == null)
            {
                return NotFound();
            }

            _context.Competency.Remove(competency);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        // GET
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Competency>>> GetCompetency()
        {
            return await _context.Competency.ToListAsync();
        }

    }
}
