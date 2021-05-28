using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using server.DataAccess;
using server.DataAccess.entities;
using Microsoft.EntityFrameworkCore;

namespace server.Controllers
{
    [Route("api/items")]
    public class itemsController : ControllerBase
    {
        private readonly pokemonDataContext db;

        public itemsController(pokemonDataContext _db)
        {
            db = _db;
        }

        [HttpGet, Route("")]
        public async Task<ActionResult> getAllItems()
        {
            var result = await db.items.ToListAsync();

            return Ok(result);
        }

        [HttpGet, Route("{name}")]
        public async Task<ActionResult> getItem(string name)
        {
            var result = await db.items
                .Where(columns => columns.name == name)
                .FirstOrDefaultAsync();

            return Ok(result);
        }

        [HttpPost, Route("")]
        public async Task<ActionResult> newItem([FromBody] items item)
        {
            db.items.Add(item);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpPost, Route("update")]
        public async Task<ActionResult> updateItem([FromBody] items item)
        {
            db.items.Update(item);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete, Route("{name}")]
        public async Task<ActionResult> deleteItem(string name)
        {
            var result = await db.items
                .Where(columns => columns.name == name)
                .FirstOrDefaultAsync();

            db.items.Remove(result);
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}
