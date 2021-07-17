using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using server.DataAccess;
using server.DataAccess.entities;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace server.Controllers
{
    [Route("api/types")]
    [ApiController]
    public class typesController : ControllerBase
    {
        private readonly IMapper map;
        private readonly pokemonDataContext db;

        public typesController(pokemonDataContext _db, IMapper _map)
        {
            db = _db;
            map = _map;
        }

        [HttpGet, Route("")]
        public async Task<ActionResult> getAllTypes()
        {
            var result = await map.ProjectTo<string>(db.types).ToListAsync();

            return Ok(result);
        }

        [HttpPost, Route("")]
        public async Task<ActionResult> newType([FromBody] typing type)
        {
            db.types.Add(type);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpPost, Route("update")]
        public async Task<ActionResult> updateType([FromBody] typing type)
        {
            db.types.Update(type);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete, Route("{name}")]
        public async Task<ActionResult> deleteType(string name)
        {
            var result = await db.types
                .Where(columns => columns.typing_name == name)
                .FirstOrDefaultAsync();

            db.types.Remove(result);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpGet, Route("effectiveness")]
        public async Task<ActionResult> getAllTypeEffectiveness()
        {
            var result = await db.type_effectiveness.ToListAsync();

            return Ok(result);
        }

        [HttpGet, Route("effectiveness/{name}")]
        public async Task<ActionResult> getEffectivenessByType(string name)
        {
            var result = await db.type_effectiveness
                .Where(columns => columns.defending_type == name || columns.attacking_type == name)
                .ToListAsync();

            return Ok(result);
        }

        [HttpPost, Route("effectiveness")]
        public async Task<ActionResult> newTypeEffectiveness([FromBody] typeEffectiveness type)
        {
            db.type_effectiveness.Add(type);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpPost, Route("effectiveness/update")]
        public async Task<ActionResult> updateTypeEffectiveness([FromBody] typeEffectiveness type)
        {
            db.type_effectiveness.Update(type);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete, Route("effectiveness/{id}")]
        public async Task<ActionResult> deleteTypeEffectiveness(int id)
        {
            var result = await db.type_effectiveness
                .Where(columns => columns.id == id)
                .FirstOrDefaultAsync();

            db.type_effectiveness.Remove(result);
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}
