using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using AutoMapper;
using server.DataAccess;
using server.DataAccess.entities;
using server.Domain;
using server.Mappings;
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
            var result = await map.ProjectTo<pokemon>(db.pokemon)
                .Select(columns => new { 
                    Id = columns.pokemon_id,
                    Name = columns.pokemon_name,
                    Type = columns.type })
                .ToListAsync();
            return Ok(result);
        }

        [HttpGet, Route("{pokedexID}")]
        public async Task<ActionResult> getPokemonData(int pokedexID)
        {
            var result = await map.ProjectTo<pokemon>(db.pokemon)
                .Where(columns => columns.pokdex_id == pokedexID)
                .ToListAsync();

            var pokemonList = new List<Object>();

            for (int i = 0; i < result.Count; i++)
            {
                var typeMultiplier = await map.ProjectTo<PokemonTypeEffectivnees>(db.type_effectiveness
                    .Where(columns => columns.defending_type == result[i].type[0]))
                    .OrderBy(columns => columns.attacking_type)
                    .ToListAsync();

                if(result[i].type.Count > 1)
                {
                    var tempMultiplier = await map.ProjectTo<PokemonTypeEffectivnees>(db.type_effectiveness
                    .Where(columns => columns.defending_type == result[i].type[1]))
                    .OrderBy(columns => columns.attacking_type)
                    .ToListAsync();

                    for (int j = 0; j < typeMultiplier.Count; j++)
                    {
                        typeMultiplier[j].multiplier *= tempMultiplier[j].multiplier;
                    }
                }

                result[i].effectiveness = typeMultiplier;
                var pokemon = new { Pokemon = result[i] };

                pokemonList.Add(pokemon);
            }
                return Ok(pokemonList);
        }

        [HttpGet, Route("evolution/{pokedexID}")]
        public async Task<ActionResult> getPokemonDataWithEvolution(int pokedexID)
        {
            var result = await map.ProjectTo<pokemon>(db.pokemon)
                .Where(columns => columns.pokdex_id == pokedexID)
                .ToListAsync();

            var pokemonList = new List<pokemonWithEvolution>();

            for(int i = 0; i < result.Count; i++)
            {
                var typeMultiplier = await map.ProjectTo<PokemonTypeEffectivnees>(db.type_effectiveness
                    .Where(columns => columns.defending_type == result[i].type[0]))
                    .OrderBy(columns => columns.attacking_type)
                    .ToListAsync();

                if (result[i].type.Count > 1)
                {
                    var tempMultiplier = await map.ProjectTo<PokemonTypeEffectivnees>(db.type_effectiveness
                    .Where(columns => columns.defending_type == result[i].type[1]))
                    .OrderBy(columns => columns.attacking_type)
                    .ToListAsync();

                    for (int j = 0; j < typeMultiplier.Count; j++)
                    {
                        typeMultiplier[j].multiplier *= tempMultiplier[j].multiplier;
                    }
                }

                int evolutionId = await db.pokemon_evolution_group
                    .Where(columns => columns.pokemon_id == result[i].pokemon_id)
                    .Select(row => row.group_id)
                    .FirstOrDefaultAsync();

                var evolution = await map.ProjectTo<evolutionLine>(db.evolution
                    .Where(columns => columns.evolution_id == evolutionId))
                    .ToListAsync();

                result[i].effectiveness = typeMultiplier;
                var pokemon = new pokemonWithEvolution { 
                    Pokemon = result[i],
                    EvolutionTree = evolution
                };

                pokemonList.Add(pokemon);
            }
            return Ok(pokemonList);
        }

        [HttpPost, Route("")]
        public async Task<ActionResult> newPokemon([FromBody]newPokemon pokemon)
        {

            var entitytoPokemon = new pokemonEntitytoPokemon(pokemon);
            var pokemonData = entitytoPokemon.convert();

            db.pokemon.Add(pokemonData);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpPost, Route("update")]
        public async Task<ActionResult> updatePokemon([FromBody] newPokemon pokemon)
        {
            var result = await map.ProjectTo<pokemonEntity>(db.pokemon)
                .Where(columns => columns.pokemon_id == pokemon.pokemon_id)
                .FirstOrDefaultAsync();

            db.pokemon_abilities.RemoveRange(result.abilities);
            db.pokemon_types.RemoveRange(result.type);
            db.pokemon_egg_groups.RemoveRange(result.eggGroups);
            db.levelUpMoves.RemoveRange(result.levelUpMoves);
            db.evolution_moves.RemoveRange(result.evolutionMoves);
            db.tm_learned_moves.RemoveRange(result.tmMoves);
            db.tr_learned_moves.RemoveRange(result.trMoves);

            var entitytoPokemon = new pokemonEntitytoPokemon(pokemon);
            var pokemonData = entitytoPokemon.convert();

            db.pokemon.Update(pokemonData);
            await db.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete, Route("{pokedexID}")]

        public async Task<ActionResult> deletePokemon(int pokedexID)
        {
            var result = await db.pokemon
                .Where(columns => columns.pokdex_id == pokedexID)
                .ToListAsync();

            foreach (pokemonEntity pokemon in result)
                db.pokemon.Remove(pokemon);

            await db.SaveChangesAsync();
            return Ok();
        }
    }
}