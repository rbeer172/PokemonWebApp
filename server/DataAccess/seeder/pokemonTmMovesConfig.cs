using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class pokemonTmMovesConfig : IEntityTypeConfiguration<tmLearnedMoves>
    {
        public void Configure(EntityTypeBuilder<tmLearnedMoves> builder)
        {
            builder.ToTable("tm_learned_moves");
            builder.HasData(
                new tmLearnedMoves
                {
                    id = 1,
                    pokemon_id = 1,
                    tm_id = 28
                },
                new tmLearnedMoves
                {
                    id = 2,
                    pokemon_id = 2,
                    tm_id = 28
                },
                new tmLearnedMoves
                {
                    id = 3,
                    pokemon_id = 3,
                    tm_id = 28
                }
            );
        }
    }
}
