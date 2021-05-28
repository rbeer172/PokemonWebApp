using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using server.DataAccess;
using server.DataAccess.entities;
using Microsoft.EntityFrameworkCore;

namespace server.Controllers
{
    [Route("api/ability")]
    public class abilityController : ControllerBase
    {
        private readonly pokemonDataContext db;

        public abilityController(pokemonDataContext _db)
        {
            db = _db;
        }

        [HttpGet, Route("")]
        public async Task<ActionResult> getAllAbilities()
        {
            var result = await db.abilities.ToListAsync();

            return Ok(result);
        }

        [HttpGet, Route("{name}")]
        public async Task<ActionResult> getAbility(string name)
        {
            var result = await db.abilities
                .Where(columns => columns.ability_name == name)
                .FirstOrDefaultAsync();

            return Ok(result);
        }

        [HttpPost, Route("")]
        public async Task<ActionResult> newAbility([FromBody] abilities ability)
        {
            db.abilities.Add(ability);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpPost, Route("update")]
        public async Task<ActionResult> updateAbility([FromBody] abilities ability)
        {
            db.abilities.Update(ability);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete, Route("{name}")]
        public async Task<ActionResult> deleteAbility(string name)
        {
            var result = await db.abilities
                .Where(columns => columns.ability_name == name)
                .FirstOrDefaultAsync();

            db.abilities.Remove(result);
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}
