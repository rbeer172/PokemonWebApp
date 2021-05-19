using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class eggMovesConfig : IEntityTypeConfiguration<eggMoves>
    {
        public void Configure(EntityTypeBuilder<eggMoves> builder)
        {
            builder.ToTable("egg_moves");
            builder.HasData(
                new eggMoves
                {
                    id = 1,
                    pokemon_id = 1,
                    move = "Petal Dance"
                },
                new eggMoves
                {
                    id = 2,
                    pokemon_id = 2,
                    move = "Petal Dance"
                },
                new eggMoves
                {
                    id = 3,
                    pokemon_id = 3,
                    move = "Petal Dance"
                }
            );
        }
    }
}
