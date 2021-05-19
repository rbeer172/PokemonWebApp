using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class evolutionMovesConfig : IEntityTypeConfiguration<evolutionLearnedMoves>
    {
        public void Configure(EntityTypeBuilder<evolutionLearnedMoves> builder)
        {
            builder.ToTable("evolution_learned_moves");
            builder.HasData(
                new evolutionLearnedMoves
                {
                    id = 1,
                    pokemon_id = 3,
                    move = "Petal Blizzard"
                }
            );
        }
    }
}
