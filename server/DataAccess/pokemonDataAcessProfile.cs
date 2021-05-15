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
            CreateMap<pokemonEntity, string>().ConvertUsing(a => a.pokemon_name);

            CreateMap<pokemon, typing>()
                .ForMember(
                    dest => dest.typing_name, 
                    opt => opt.MapFrom(src => src.type)
                );
            CreateMap<pokemon, abilities>()
                .ForMember(
                    dest => dest.ability_name,
                    opt => opt.MapFrom(src => src.abilities)
                );
            CreateMap<pokemon, eggGroups>()
                .ForMember(
                    dest => dest.name,
                    opt => opt.MapFrom(src => src.eggGroups)
                );
            CreateMap<pokemon, levelupLearnedMoves>()
                .ForMember(
                    dest => dest.move,
                    opt => opt.MapFrom(src => src.levelUpMoves)
                );
            CreateMap<pokemon, evolutionLearnedMoves>()
                .ForMember(
                    dest => dest.move,
                    opt => opt.MapFrom(src => src.evolutionMoves)
                );
            CreateMap<pokemon, eggMoves>()
                .ForMember(
                    dest => dest.move,
                    opt => opt.MapFrom(src => src.eggMoves)
                );
            CreateMap<pokemon, tmLearnedMoves>()
                .ForMember(
                    dest => dest.tm_id,
                    opt => opt.MapFrom(src => src.tmMoves)
                );
            CreateMap<pokemon, trLearnedMoves>()
                .ForMember(
                    dest => dest.tr_id,
                    opt => opt.MapFrom(src => src.trMoves)
                );
            CreateMap<evolution, evolutionLine>();
            CreateMap<entities.typeEffectiveness, Domain.typeEffectiveness>();
        }
    }
}
