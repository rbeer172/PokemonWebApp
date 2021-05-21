using System.Collections.Generic;
using server.DataAccess.entities;
using server.Domain;


namespace server.Mappings
{
    public class pokemonEntitytoPokemon
    {
        public newPokemon pokemon;

        public pokemonEntitytoPokemon(newPokemon _pokemon)
        {
            pokemon = _pokemon;
        }

        public pokemonEntity convert()
        {
            var pokemonData = new pokemonEntity
            {
                pokemon_id = pokemon.pokemon_id,
                pokdex_id = pokemon.pokdex_id,
                pokemon_name = pokemon.pokemon_name,
                species = pokemon.species,
                height = pokemon.height,
                weight = pokemon.weight,
                growth_rate = pokemon.growth_rate,
                hp = pokemon.hp,
                attack = pokemon.attack,
                defense = pokemon.defense,
                special_attack = pokemon.special_attack,
                special_defense = pokemon.special_defense,
                speed = pokemon.speed,
                total = pokemon.total,
                description = pokemon.description,
                type = new List<pokemonTypes> { },
                abilities = new List<pokemonAbilties> { },
                eggGroups = new List<pokemonEggGroups> { },
                levelUpMoves = new List<levelupLearnedMoves> { },
                evolutionMoves = new List<evolutionLearnedMoves> { },
                eggMoves = new List<DataAccess.entities.eggMoves> { },
                tmMoves = new List<tmLearnedMoves> { },
                trMoves = new List<trLearnedMoves> { }
            };

            foreach (string typing in pokemon.type)
                pokemonData.type.Add(new pokemonTypes { type = typing });

            foreach (string _ability in pokemon.abilities)
                pokemonData.abilities.Add(new pokemonAbilties { ability = _ability });

            foreach (string _eggGroup in pokemon.eggGroups)
                pokemonData.eggGroups.Add(new pokemonEggGroups { eggGroup = _eggGroup });

            foreach (levelupMoves move in pokemon.levelUpMoves)
                pokemonData.levelUpMoves.Add(new levelupLearnedMoves
                {
                    move = move.Move,
                    level = move.Level
                });

            foreach (string move in pokemon.evolutionMoves)
                pokemonData.evolutionMoves.Add(new evolutionLearnedMoves { move = move });

            foreach (string move in pokemon.eggMoves)
                pokemonData.eggMoves.Add(new DataAccess.entities.eggMoves { move = move });

            foreach (int move in pokemon.tmMoves)
                pokemonData.tmMoves.Add(new tmLearnedMoves { tm_id = move });

            foreach (int move in pokemon.trMoves)
                pokemonData.trMoves.Add(new trLearnedMoves { tr_id = move + 1 });

            return pokemonData;
        }       
    }
}
