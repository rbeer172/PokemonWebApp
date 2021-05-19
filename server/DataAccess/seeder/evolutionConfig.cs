using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class evolutionConfig : IEntityTypeConfiguration<evolution>
    {
        public void Configure(EntityTypeBuilder<evolution> builder)
        {
            builder.ToTable("evolution");
            builder.HasData(
                new evolution
                {
                    id = 1,
                    pokemon_id = 1,
                    evolution_id = 1,
                    evolved_pokemon = 2,
                    level = 16,
                    heldItem = null,
                    useItem = null,
                    time = null,
                    friendship = false,
                    move = null,
                    trade = false,
                    other = null
                },
                new evolution
                {
                    id = 2,
                    pokemon_id = 2,
                    evolution_id = 1,
                    evolved_pokemon = 3,
                    level = 32,
                    heldItem = null,
                    useItem = null,
                    time = null,
                    friendship = false,
                    move = null,
                    trade = false,
                    other = null
                }
            );
        }
    }
}
