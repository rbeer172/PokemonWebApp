using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using server.DataAccess;
using server.DataAccess.entities;
using Microsoft.EntityFrameworkCore;

namespace server.Controllers
{
    [Route("api/EggGroup")]
    [ApiController]
    public class eggGroupController : ControllerBase
    {
        private readonly pokemonDataContext db;

        public eggGroupController(pokemonDataContext _db)
        {
            db = _db;
        }

        [HttpGet, Route("")]
        public async Task<ActionResult> getAllGroups()
        {
            var result = await db.egg_groups.ToListAsync();

            return Ok(result);
        }

        [HttpPost, Route("")]
        public async Task<ActionResult> newEggGroup([FromBody] eggGroups eggGroup)
        {
            db.egg_groups.Add(eggGroup);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpPost, Route("update")]
        public async Task<ActionResult> updateEggGroup([FromBody] eggGroups eggGroup)
        {
            db.egg_groups.Update(eggGroup);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete, Route("{name}")]
        public async Task<ActionResult> deleteEggGroup(string name)
        {
            var result = await db.egg_groups
                .Where(columns => columns.name == name)
                .FirstOrDefaultAsync();

            db.egg_groups.Remove(result);
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}
}
