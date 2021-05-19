using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class pokemonConfig : IEntityTypeConfiguration<pokemonEntity>
    {
        public void Configure(EntityTypeBuilder<pokemonEntity> builder)
        {
            builder.ToTable("pokemon");
            builder.HasData(
                new pokemonEntity {
                    pokemon_id = 1,
                    pokdex_id = 1,
                    pokemon_name = "Bulbasaur",
                    species = "Seed",
                    height = 0.7f,
                    weight = 6.9f,
                    growth_rate = "medium slow",
                    hp = 45,
                    attack = 49,
                    defense = 49,
                    special_attack = 65,
                    special_defense = 65,
                    speed = 45,
                    total = 318,
                    description = "A Grass/Poison type Pokémon introduced in Generation 1."
                },
                new pokemonEntity
                {
                    pokemon_id = 2,
                    pokdex_id = 2,
                    pokemon_name = "Ivysaur",
                    species = "Seed",
                    height = 1.0f,
                    weight = 13.0f,
                    growth_rate = "medium slow",
                    hp = 60,
                    attack = 62,
                    defense = 63,
                    special_attack = 80,
                    special_defense = 80,
                    speed = 60,
                    total = 405,
                    description = "A Grass/Poison type Pokémon introduced in Generation 1."
                },
                new pokemonEntity
                {
                    pokemon_id = 3,
                    pokdex_id = 3,
                    pokemon_name = "Venusaur",
                    species = "Seed",
                    height = 2.0f,
                    weight = 100.0f,
                    growth_rate = "medium slow",
                    hp = 80,
                    attack = 82,
                    defense = 83,
                    special_attack = 100,
                    special_defense = 100,
                    speed = 80,
                    total = 525,
                    description = "A Grass/Poison type Pokémon introduced in Generation 1."
                }
            );
        }
    }
}
