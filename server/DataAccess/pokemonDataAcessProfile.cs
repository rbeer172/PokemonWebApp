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
            CreateMap<eggMoves, string>().ConvertUsing(a => a.move);
            CreateMap<evolutionLearnedMoves, string>().ConvertUsing(a => a.move);
            CreateMap<levelupLearnedMoves, string>().ConvertUsing(a => a.move);
            CreateMap<tmLearnedMoves, int>().ConvertUsing(a => a.tm_id);
            CreateMap<trLearnedMoves, int>().ConvertUsing(a => a.tr_id);

            CreateMap<pokemonEntity, pokemon>();
            CreateMap<evolution, evolutionLine>();
            CreateMap<entities.typeEffectiveness, Domain.typeEffectiveness>();
        }
    }
}
