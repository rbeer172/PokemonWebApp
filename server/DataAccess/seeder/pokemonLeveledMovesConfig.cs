using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class pokemonLeveledMovesConfig : IEntityTypeConfiguration<levelupLearnedMoves>
    {
        public void Configure(EntityTypeBuilder<levelupLearnedMoves> builder)
        {
            builder.ToTable("levelup_learned_moves");
            builder.HasData(
                new levelupLearnedMoves
                {
                    id = 1,
                    pokemon_id = 1,
                    move = "Tackle",
                    level = 1
                },
                new levelupLearnedMoves
                {
                    id = 2,
                    pokemon_id = 1,
                    move = "Poison Powder",
                    level = 15
                },
                new levelupLearnedMoves
                {
                    id = 3,
                    pokemon_id = 1,
                    move = "Solar Beam",
                    level = 36
                },
                new levelupLearnedMoves
                {
                    id = 4,
                    pokemon_id = 2,
                    move = "Tackle",
                    level = 1
                },
                new levelupLearnedMoves
                {
                    id = 5,
                    pokemon_id = 2,
                    move = "Poison Powder",
                    level = 15
                },
                new levelupLearnedMoves
                {
                    id = 6,
                    pokemon_id = 2,
                    move = "Solar Beam",
                    level = 50
                },
                new levelupLearnedMoves
                {
                    id = 7,
                    pokemon_id = 3,
                    move = "Tackle",
                    level = 1
                },
                new levelupLearnedMoves
                {
                    id = 8,
                    pokemon_id = 3,
                    move = "Poison Powder",
                    level = 15
                },
                new levelupLearnedMoves
                {
                    id = 9,
                    pokemon_id = 3,
                    move = "Solar Beam",
                    level = 58
                }
                ,
                new levelupLearnedMoves
                {
                    id = 10,
                    pokemon_id = 3,
                    move = "Petal Blizzard",
                    level = 1
                }
                ,
                new levelupLearnedMoves
                {
                    id = 11,
                    pokemon_id = 3,
                    move = "Petal Dance",
                    level = 1
                }
            );
        }
    }
}
