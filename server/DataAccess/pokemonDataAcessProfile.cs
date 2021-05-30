using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using server.Domain;
using server.DataAccess.entities;

namespace server.DataAccess
{
    public class pokemonDataAcessProfile : Profile
    {
        public pokemonDataAcessProfile()
        {
            CreateMap<pokemonTypes, string>().ConvertUsing(a => a.type);
            CreateMap<pokemonAbilties, string>().ConvertUsing(a => a.ability);
            CreateMap<pokemonEggGroups, string>().ConvertUsing(a => a.eggGroup);

            CreateMap<levelupLearnedMoves, levelupMoves>()
                .ForMember(domain => domain.Level, value => value.MapFrom(db => db.level))
                .ForMember(domain => domain.Move, value => value.MapFrom(db => db.move))
                .ForMember(domain => domain.Accuracy, value => value.MapFrom(db => db.pokemon_move.accuracy))
                .ForMember(domain => domain.Category, value => value.MapFrom(db => db.pokemon_move.category))
                .ForMember(domain => domain.Power, value => value.MapFrom(db => db.pokemon_move.power));
            CreateMap<evolutionLearnedMoves, evolutionMoves>()
                .ForMember(domain => domain.Move, value => value.MapFrom(db => db.move))
                .ForMember(domain => domain.Accuracy, value => value.MapFrom(db => db.pokemon_move.accuracy))
                .ForMember(domain => domain.Category, value => value.MapFrom(db => db.pokemon_move.category))
                .ForMember(domain => domain.Power, value => value.MapFrom(db => db.pokemon_move.power));
            CreateMap<tmLearnedMoves, tmMoves>()
                .ForMember(domain => domain.TM, value => value.MapFrom(db => db.tm_id))
                .ForMember(domain => domain.Move, value => value.MapFrom(db => db.pokemon_move.move.name))
                .ForMember(domain => domain.Accuracy, value => value.MapFrom(db => db.pokemon_move.move.accuracy))
                .ForMember(domain => domain.Category, value => value.MapFrom(db => db.pokemon_move.move.category))
                .ForMember(domain => domain.Power, value => value.MapFrom(db => db.pokemon_move.move.power));
            CreateMap<trLearnedMoves, trMoves>()
                .ForMember(domain => domain.TR, value => value.MapFrom(db => db.tr_id - 1))
                .ForMember(domain => domain.Move, value => value.MapFrom(db => db.pokemon_move.move.name))
                .ForMember(domain => domain.Accuracy, value => value.MapFrom(db => db.pokemon_move.move.accuracy))
                .ForMember(domain => domain.Category, value => value.MapFrom(db => db.pokemon_move.move.category))
                .ForMember(domain => domain.Power, value => value.MapFrom(db => db.pokemon_move.move.power));
            CreateMap<entities.eggMoves, Domain.eggMoves>()
                .ForMember(domain => domain.Move, value => value.MapFrom(db => db.move))
                .ForMember(domain => domain.Accuracy, value => value.MapFrom(db => db.pokemon_move.accuracy))
                .ForMember(domain => domain.Category, value => value.MapFrom(db => db.pokemon_move.category))
                .ForMember(domain => domain.Power, value => value.MapFrom(db => db.pokemon_move.power));
            CreateMap<evolution, evolutionLine>()
                .ForMember(domain => domain.pokemon, value => value.MapFrom(db => db.pokemon.pokemon_name))
                .ForMember(domain => domain.evolved_pokemon, value => value.MapFrom(db => db.pokemonEvolved.pokemon_name));
            CreateMap<moves, move>()
                .ForMember(domain => domain.Name, value => value.MapFrom(db => db.name))
                .ForMember(domain => domain.Type, value => value.MapFrom(db => db.typing_name))
                .ForMember(domain => domain.Accuracy, value => value.MapFrom(db => db.accuracy))
                .ForMember(domain => domain.Category, value => value.MapFrom(db => db.category))
                .ForMember(domain => domain.Power, value => value.MapFrom(db => db.power))
                .ForMember(domain => domain.PP, value => value.MapFrom(db => db.pp))
                .ForMember(domain => domain.Priority, value => value.MapFrom(db => db.priority))
                .ForMember(domain => domain.TM, value => value.MapFrom(db => db.TM.id))
                .ForMember(domain => domain.TR, value => value.MapFrom(db => db.TR.id - 1))
                .ForMember(domain => domain.Description, value => value.MapFrom(db => db.description));

            CreateMap<pokemonEntity, pokemon>();
            CreateMap<entities.typeEffectiveness, Domain.typeEffectiveness>();
            CreateMap<pokemonEvolutionGroup, PokemonEvolutionGroup>();
            CreateMap<evolutionGroup, evolutionTree>();
        }
    }
}
