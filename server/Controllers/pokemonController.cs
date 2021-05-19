using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using AutoMapper;
using server.DataAccess;
using server.Domain;
using Microsoft.EntityFrameworkCore;

namespace server.Controllers
{
    [Route("api/pokemon")]
    public class pokemonController : ControllerBase
    {
        private readonly IMapper map;
        private readonly pokemonDataContext db;

        public pokemonController(pokemonDataContext _db, IMapper _map)
        {
            db = _db;
            map = _map;
        }

        [HttpGet, Route("")]
        public async Task<ActionResult> getAllPokemon()
        {
            var result = await db.pokemon
                .Select(columns => columns.pokemon_name)
                .ToListAsync();
            return Ok(result);
        }

        [HttpGet, Route("{pokedexID}")]
        public async Task<ActionResult> getPokemonData(int pokedexID)
        {
            var result = await map.ProjectTo<pokemon>(db.pokemon)
                .Where(columns => columns.pokdex_id == pokedexID)
                .ToListAsync();

            return Ok(result);
        }

        [HttpGet, Route("evolution/{pokedexID}")]
        public async Task<ActionResult> getPokemonDataWithEvolution(int pokedexID)
        {
            var result = await map.ProjectTo<pokemon>(db.pokemon)
                .Where(columns => columns.pokdex_id == pokedexID)
                .ToListAsync();

            int id = await db.pokemon
                .Where(columns => columns.pokdex_id == pokedexID)
                .Select(row => row.pokemon_id)
                .FirstOrDefaultAsync();

            int evolutionId = await db.evolution
                .Where(columns => columns.pokemon_id == id)
                .Select(row => row.evolution_id)
                .FirstOrDefaultAsync();

            var evolution = await map.ProjectTo<evolutionLine>(db.evolution
                .Where(columns => columns.evolution_id == evolutionId))
                .ToListAsync();

            return Ok(new { pokemon = result, evolutionTree = evolution });
        }
    }
}