using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class pokemonTrMovesConfig : IEntityTypeConfiguration<trLearnedMoves>
    {
        public void Configure(EntityTypeBuilder<trLearnedMoves> builder)
        {
            builder.ToTable("tr_learned_moves");
            builder.HasData(
                new trLearnedMoves
                {
                    id = 1,
                    pokemon_id = 1,
                    tr_id = 1
                },
                new trLearnedMoves
                {
                    id = 2,
                    pokemon_id = 2,
                    tr_id = 1
                },
                new trLearnedMoves
                {
                    id = 3,
                    pokemon_id = 3,
                    tr_id = 1
                }
            );
        }
    }
}
