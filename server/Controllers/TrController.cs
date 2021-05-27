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
        public async Task<ActionResult> getTM()
        {
            var result = await db.TRs.FirstOrDefaultAsync();

            return Ok(result);
        }

        [HttpPost, Route("")]
        public async Task<ActionResult> newTM([FromBody] tr newTM)
        {
            db.TRs.Add(newTM);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpPost, Route("update")]
        public async Task<ActionResult> updateTM([FromBody] tr newTR)
        {
            db.TRs.Update(newTR);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete, Route("{id}")]
        public async Task<ActionResult> deleteTM(int id)
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
