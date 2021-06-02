using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class pokemonabilityConfig : IEntityTypeConfiguration<pokemonAbilties>
    {
        public void Configure(EntityTypeBuilder<pokemonAbilties> builder)
        {
            builder.ToTable("pokemon_abilities");
            builder.HasData(
                new pokemonAbilties
                {
                    id = 1,
                    pokemon_id = 1,
                    ability = "Overgrow",
                    hidden = false
                },
                new pokemonAbilties
                {
                    id = 2,
                    pokemon_id = 1,
                    ability = "Chlorophyll",
                    hidden = true
                },
                new pokemonAbilties
                {
                    id = 3,
                    pokemon_id = 2,
                    ability = "Overgrow",
                    hidden = false
                },
                new pokemonAbilties
                {
                    id = 4,
                    pokemon_id = 2,
                    ability = "Chlorophyll",
                    hidden = true
                },
                new pokemonAbilties
                {
                    id = 5,
                    pokemon_id = 3,
                    ability = "Overgrow",
                    hidden = false
                },
                new pokemonAbilties
                {
                    id = 6,
                    pokemon_id = 3,
                    ability = "Chlorophyll",
                    hidden = true
                }
            );
        }
    }
}
