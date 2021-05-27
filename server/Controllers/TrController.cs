using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using server.DataAccess;
using server.DataAccess.entities;
using Microsoft.EntityFrameworkCore;

namespace server.Controllers
{
    [Route("api/TR")]
    public class TrController : ControllerBase
    {
        private readonly pokemonDataContext db;

        public TrController(pokemonDataContext _db)
        {
            db = _db;
        }

        [HttpGet, Route("")]
        public async Task<ActionResult> getTR()
        {
            var result = await db.TRs
                .Select(columns => new { TR = columns.id, Move = columns.move_name })
                .FirstOrDefaultAsync();

            return Ok(result);
        }

        [HttpPost, Route("")]
        public async Task<ActionResult> newTR([FromBody] tr newTR)
        {
            db.TRs.Add(newTR);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpPost, Route("update")]
        public async Task<ActionResult> updateTR([FromBody] tr newTR)
        {
            db.TRs.Update(newTR);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete, Route("{id}")]
        public async Task<ActionResult> deleteTR(int id)
        {
            var result = await db.TRs
                .Where(columns => columns.id == id)
                .FirstOrDefaultAsync();

            db.TRs.Remove(result);
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}
