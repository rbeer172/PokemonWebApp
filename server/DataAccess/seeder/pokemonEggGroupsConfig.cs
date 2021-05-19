using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class pokemonEggGroupsConfig : IEntityTypeConfiguration<pokemonEggGroups>
    {
        public void Configure(EntityTypeBuilder<pokemonEggGroups> builder)
        {
            builder.ToTable("pokemon_egg_groups");
            builder.HasData(
                new pokemonEggGroups
                {
                    id = 1,
                    pokemon_id = 1,
                    eggGroup = "Grass"
                },
                new pokemonEggGroups
                {
                    id = 2,
                    pokemon_id = 1,
                    eggGroup = "Monster"
                },
                new pokemonEggGroups
                {
                    id = 3,
                    pokemon_id = 2,
                    eggGroup = "Grass"
                },
                new pokemonEggGroups
                {
                    id = 4,
                    pokemon_id = 2,
                    eggGroup = "Monster"
                },
                new pokemonEggGroups
                {
                    id = 5,
                    pokemon_id = 3,
                    eggGroup = "Grass"
                },
                new pokemonEggGroups
                {
                    id = 6,
                    pokemon_id = 3,
                    eggGroup = "Monster"
                }
            );
        }
    }
}
