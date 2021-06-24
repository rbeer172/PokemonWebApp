using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class typeEffectivenessConfig : IEntityTypeConfiguration<typeEffectiveness>
    {
        public void Configure(EntityTypeBuilder<typeEffectiveness> builder)
        {
            builder.ToTable("type_effectiveness");
            builder.HasData(
                //defending grass
                new typeEffectiveness { 
                    id = 1,
                    attacking_type = "normal",
                    defending_type = "grass",
                    multiplier = 1
                },
                new typeEffectiveness {
                    id = 2,
                    attacking_type = "fire",
                    defending_type = "grass",
                    multiplier = 2
                },
                new typeEffectiveness {
                    id = 3,
                    attacking_type = "water",
                    defending_type = "grass",
                    multiplier = 0.5f
                },
                new typeEffectiveness {
                    id = 4,
                    attacking_type = "electric",
                    defending_type = "grass",
                    multiplier = 0.5f
                },
                new typeEffectiveness {
                    id = 5,
                    attacking_type = "grass",
                    defending_type = "grass",
                    multiplier = 0.5f
                },
                new typeEffectiveness {
                    id = 7,
                    attacking_type = "ice",
                    defending_type = "grass",
                    multiplier = 2
                },
                new typeEffectiveness {
                    id = 8,
                    attacking_type = "fighting",
                    defending_type = "grass",
                    multiplier = 1
                },
                new typeEffectiveness {
                    id = 9,
                    attacking_type = "poison",
                    defending_type = "grass",
                    multiplier = 2
                },
                new typeEffectiveness {
                    id = 10,
                    attacking_type = "ground",
                    defending_type = "grass",
                    multiplier = 0.5f
                },
                new typeEffectiveness {
                    id = 11,
                    attacking_type = "flying",
                    defending_type = "grass",
                    multiplier = 2
                },
                new typeEffectiveness {
                    id = 12,
                    attacking_type = "psychic",
                    defending_type = "grass",
                    multiplier = 1
                },
                new typeEffectiveness {
                    id = 13,
                    attacking_type = "bug",
                    defending_type = "grass",
                    multiplier = 2
                },
                new typeEffectiveness {
                    id = 14,
                    attacking_type = "rock",
                    defending_type = "grass",
                    multiplier = 1
                },
                new typeEffectiveness {
                    id = 15,
                    attacking_type = "ghost",
                    defending_type = "grass",
                    multiplier = 1
                },
                new typeEffectiveness {
                    id = 16,
                    attacking_type = "dragon",
                    defending_type = "grass",
                    multiplier = 1
                },
                new typeEffectiveness {
                    id = 17,
                    attacking_type = "dark",
                    defending_type = "grass",
                    multiplier = 1
                },
                new typeEffectiveness {
                    id = 18,
                    attacking_type = "steel",
                    defending_type = "grass",
                    multiplier = 1
                },
                new typeEffectiveness {
                    id = 19,
                    attacking_type = "fairy",
                    defending_type = "grass",
                    multiplier = 1
                },
                //defending poison
                new typeEffectiveness
                {
                    id = 20,
                    attacking_type = "normal",
                    defending_type = "poison",
                    multiplier = 1
                },
                new typeEffectiveness
                {
                    id = 21,
                    attacking_type = "fire",
                    defending_type = "poison",
                    multiplier = 1
                },
                new typeEffectiveness
                {
                    id = 22,
                    attacking_type = "water",
                    defending_type = "poison",
                    multiplier = 1
                },
                new typeEffectiveness
                {
                    id = 23,
                    attacking_type = "electric",
                    defending_type = "poison",
                    multiplier = 1
                },
                new typeEffectiveness
                {
                    id = 24,
                    attacking_type = "grass",
                    defending_type = "poison",
                    multiplier = 0.5f
                },
                new typeEffectiveness
                {
                    id = 25,
                    attacking_type = "ice",
                    defending_type = "poison",
                    multiplier = 1
                },
                new typeEffectiveness
                {
                    id = 26,
                    attacking_type = "fighting",
                    defending_type = "poison",
                    multiplier = 0.5f
                },
                new typeEffectiveness
                {
                    id = 27,
                    attacking_type = "poison",
                    defending_type = "poison",
                    multiplier = 0.5f
                },
                new typeEffectiveness
                {
                    id = 28,
                    attacking_type = "ground",
                    defending_type = "poison",
                    multiplier = 2
                },
                new typeEffectiveness
                {
                    id = 29,
                    attacking_type = "flying",
                    defending_type = "poison",
                    multiplier = 1
                },
                new typeEffectiveness
                {
                    id = 30,
                    attacking_type = "psychic",
                    defending_type = "poison",
                    multiplier = 2
                },
                new typeEffectiveness
                {
                    id = 31,
                    attacking_type = "bug",
                    defending_type = "poison",
                    multiplier = 0.5f
                },
                new typeEffectiveness
                {
                    id = 32,
                    attacking_type = "rock",
                    defending_type = "poison",
                    multiplier = 1
                },
                new typeEffectiveness
                {
                    id = 33,
                    attacking_type = "ghost",
                    defending_type = "poison",
                    multiplier = 1
                },
                new typeEffectiveness
                {
                    id = 34,
                    attacking_type = "dragon",
                    defending_type = "poison",
                    multiplier = 1
                },
                new typeEffectiveness
                {
                    id = 35,
                    attacking_type = "dark",
                    defending_type = "poison",
                    multiplier = 1
                },
                new typeEffectiveness
                {
                    id = 36,
                    attacking_type = "steel",
                    defending_type = "poison",
                    multiplier = 1
                },
                new typeEffectiveness
                {
                    id = 37,
                    attacking_type = "fairy",
                    defending_type = "poison",
                    multiplier = 0.5f
                }

            );
        }
    }
}
