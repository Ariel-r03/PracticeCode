using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPI.Controllers
{
    [Route("api/superhero")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly DataContext _context;
        public SuperHeroController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            return await _context.SuperHeroes.ToListAsync();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<SuperHero>> GetById(int id)
        {
             var hero=await _context.SuperHeroes.FindAsync(id);
             if(hero == null)
            {
                return NotFound("Superhero wasnt found");
            }

             return Ok(hero);
        }

        [HttpPost]

        public async Task<ActionResult> Insert(SuperHero hero)
        {
            _context.SuperHeroes.Add(hero);
            await _context.SaveChangesAsync();
            return Ok(hero);
        }

        [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> Edit(SuperHero shero)
        {
            var hero = await _context.SuperHeroes.FindAsync(shero.Id);
            if (hero == null)
            {
                return NotFound("Superhero wasnt found");
            }

 
            hero.Name = shero.Name;
            hero.FirstName = shero.FirstName;
            hero.LastName = shero.LastName;
            hero.Place = shero.Place;

            await _context.SaveChangesAsync();
            return Ok(await _context.SuperHeroes.ToListAsync());
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> DeleteHero(int id)
        {
            var hero = await _context.SuperHeroes.FindAsync(id);
            if(hero == null)
            {
                return BadRequest("Hero not found");
            }
            _context.SuperHeroes.Remove(hero);
            await _context.SaveChangesAsync();

            return Ok(await _context.SuperHeroes.ToListAsync());
        }
    }

    

}
