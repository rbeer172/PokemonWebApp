using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using server.DataAccess;
using server.DataAccess.entities;
using Microsoft.EntityFrameworkCore;

namespace server.Controllers
{
    [Route("api/TM")]
    public class TmController : ControllerBase
    {
        private readonly pokemonDataContext db;

        public TmController(pokemonDataContext _db)
        {
            db = _db;
        }

        [HttpGet, Route("")]
        public async Task<ActionResult> getTM()
        {
            var result = await db.TMs.FirstOrDefaultAsync();

            return Ok(result);
        }

        [HttpPost, Route("")]
        public async Task<ActionResult> newTM([FromBody] tm newTM)
        {
            db.TMs.Add(newTM);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpPost, Route("update")]
        public async Task<ActionResult> updateTM([FromBody] tm newTM)
        {
            db.TMs.Update(newTM);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete, Route("{id}")]
        public async Task<ActionResult> deleteTM(int id)
        {
            var result = await db.TMs
                .Where(columns => columns.id == id)
                .FirstOrDefaultAsync();

            db.TMs.Remove(result);
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}
