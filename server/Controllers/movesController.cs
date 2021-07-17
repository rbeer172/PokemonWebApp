using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using AutoMapper;
using server.DataAccess;
using server.DataAccess.entities;
using server.Domain;
using Microsoft.EntityFrameworkCore;

namespace server.Controllers
{
    [Route("api/moves")]
    public class movesController : ControllerBase
    {
        private readonly IMapper map;
        private readonly pokemonDataContext db;

        public movesController(pokemonDataContext _db, IMapper _map)
        {
            db = _db;
            map = _map;
        }

        [HttpGet, Route("")]
        public async Task<ActionResult> getAllMoves()
        {
            var result = await map.ProjectTo<move>(db.pokemon_moves)
                .ToListAsync();
            return Ok(result);
        }

        [HttpGet, Route("{name}")]
        public async Task<ActionResult> getMove(string name)
        {
            var result = await db.pokemon_moves
                .Where(columns => columns.name == name)
                .FirstOrDefaultAsync();
            return Ok(result);
        }

        [HttpPost, Route("")]
        public async Task<ActionResult> addMove([FromBody] moves move)
        {
            db.pokemon_moves.Add(move);
            await db.SaveChangesAsync();

            return Ok();
        }

        [HttpPost, Route("update")]
        public async Task<ActionResult> updateMove([FromBody] moves move)
        {
            db.pokemon_moves.Update(move);
            await db.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete, Route("{name}")]
        public async Task<ActionResult> deleteMove(string name)
        {
            var result = await db.pokemon_moves
                .Where(columns => columns.name == name)
                .FirstOrDefaultAsync();

            db.pokemon_moves.Remove(result);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpGet, Route("properties/category")]
        public async Task<ActionResult> getCategoryProperty()
        {
            var categoryList = await map.ProjectTo<string>(db.move_categories).ToListAsync();
            return Ok(categoryList);
        }

        [HttpGet, Route("properties/power")]
        public async Task<ActionResult> getPowerProperty()
        {
            var power = await map.ProjectTo<int>(db.power_values).ToListAsync();
            return Ok(power);
        }

        [HttpGet, Route("properties/accuracy")]
        public async Task<ActionResult> getAccuracyProperty()
        {
            var list = await map.ProjectTo<int>(db.accuracy).ToListAsync();
            return Ok(list);
        }

        [HttpGet, Route("properties/pp")]
        public async Task<ActionResult> getPPProperty()
        {
            var list = await map.ProjectTo<int>(db.pp_values).ToListAsync();
            return Ok(list);
        }

        [HttpPost, Route("properties/category")]
        public async Task<ActionResult> addCategory([FromBody] moveCategories category)
        {
            db.move_categories.Add(category);
            await db.SaveChangesAsync();

            return Ok();
        }

        [HttpPost, Route("properties/power")]
        public async Task<ActionResult> addPower([FromBody] powerValues power)
        {
            db.power_values.Add(power);
            await db.SaveChangesAsync();

            return Ok();
        }

        [HttpPost, Route("properties/accuracy")]
        public async Task<ActionResult> addAccuracy([FromBody] accuracyValues accuracy)
        {
            db.accuracy.Add(accuracy);
            await db.SaveChangesAsync();

            return Ok();
        }

        [HttpPost, Route("properties/pp")]
        public async Task<ActionResult> addPP([FromBody] ppValues pp)
        {
            db.pp_values.Add(pp);
            await db.SaveChangesAsync();

            return Ok();
        }
    }
}
