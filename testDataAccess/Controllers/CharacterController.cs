using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testDataAccess.Data;
using testDataAccess.Models;

namespace testDataAccess.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CharacterController(AppDbContext context)
        {
            _context = context;
        }

        //GET api/Character
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterTest>>> Characters()
        {
            if (_context.Character == null)
            {
                return NotFound();
            }
            return await _context.Character.ToListAsync();
        }
        
        //GET api/Character/2
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterTest>> Character(int id)
        {
            if (_context.Character == null)
            {
                return NotFound();
            }

            CharacterTest character = await _context.Character.FindAsync(id);

            if (character == null)
            {
                return NotFound();
            }

            return character;
        }


        //POST api/Character
        [HttpPost]
        public async Task<ActionResult<CharacterTest>> PostCharacter(CharacterTest character)
        {
            _context.Character.Add(character);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Character), new { id = character.id }, character);
        }

        //DELETE api/Character/2
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCharacter(int id)
        {
            if (_context == null)
            {
                return NotFound();
            }

            CharacterTest character = await _context.Character.FindAsync(id);

            if (character == null)
            {
                return NotFound();
            }

            _context.Character.Remove(character);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
