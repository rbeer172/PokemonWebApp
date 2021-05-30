using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using server.DataAccess;
using server.DataAccess.entities;
using server.Domain;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace server.Controllers
{
    [Route("api/evolution")]
    public class evolutionController : ControllerBase
    {
        private readonly IMapper map;
        private readonly pokemonDataContext db;

        public evolutionController(pokemonDataContext _db, IMapper _map)
        {
            db = _db;
            map = _map;
        }

        [HttpGet, Route("")]
        public async Task<ActionResult> getAllEvolutions()
        {
            var result = await db.evolution_groups
                //.Select(columns => new { ID = columns.id, Pokemon = columns.pokemon})
                .ToListAsync();

            return Ok(result);
        }

        [HttpGet, Route("{id}")]
        public async Task<ActionResult> getEvolutionByPokemonId(int id)
        {
            var result = await map.ProjectTo<evolutionTree>(db.evolution_groups)
                .Where(columns => columns.pokemon.Any(x => x.pokemon_id == id))
                .FirstOrDefaultAsync();

            return Ok(result);
        }

        [HttpPost, Route("")]
        public async Task<ActionResult> newEvolution([FromBody] evolutionGroup group)
        {
            /*using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    var groupID = new evolutionGroup { };
                    db.evolution_groups.Add(groupID);
                    await db.SaveChangesAsync();

                    foreach (evolution evolution in tree.evolutions)
                    {
                        evolution.evolution_id = groupID.id;
                        db.evolution.Add(evolution);
                    }

                    foreach (int id in tree.pokemonID)
                    {
                        var group = new pokemonEvolutionGroup { 
                            pokemon_id = id,
                            group_id = groupID.id 
                        };
                        db.pokemon_evolution_group.Add(group);
                    }
                    await db.SaveChangesAsync();
                    transaction.Commit();
                }
                catch(Exception)
                {
                    transaction.Rollback();
                }
            }*/
            db.evolution_groups.Add(group);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpPost, Route("update")]
        public async Task<ActionResult> updateEvolution([FromBody] evolutionGroup group)
        {
            db.evolution_groups.Update(group);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete, Route("{id}")]
        public async Task<ActionResult> deleteEvolution(int id)
        {
            var result = await db.evolution_groups
                .Where(columns => columns.pokemon.Any(x => x.pokemon_id == id))
                .FirstOrDefaultAsync();

            db.evolution_groups.Remove(result);
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}
