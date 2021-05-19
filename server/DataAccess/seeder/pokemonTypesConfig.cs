using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class pokemonTypesConfig : IEntityTypeConfiguration<pokemonTypes>
    {
        public void Configure(EntityTypeBuilder<pokemonTypes> builder)
        {
            builder.ToTable("pokemon_types");
            builder.HasData(
                new pokemonTypes{ 
                    id = 1,
                    pokemon_id = 1,
                    type = "grass"
                },
                new pokemonTypes
                {
                    id = 2,
                    pokemon_id = 1,
                    type = "poison"
                },
                new pokemonTypes
                {
                    id = 3,
                    pokemon_id = 2,
                    type = "grass"
                },
                new pokemonTypes
                {
                    id = 4,
                    pokemon_id = 2,
                    type = "poison"
                },
                new pokemonTypes
                {
                    id = 5,
                    pokemon_id = 3,
                    type = "grass"
                },
                new pokemonTypes
                {
                    id = 6,
                    pokemon_id = 3,
                    type = "poison"
                }
            );
        }
    }
}
