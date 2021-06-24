using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class typingConfig : IEntityTypeConfiguration<typing>
    {
        public void Configure(EntityTypeBuilder<typing> builder)
        {
            builder.ToTable("typing");
            builder.HasData(
                new typing { typing_name = "normal" },
                new typing { typing_name = "fire" },
                new typing { typing_name = "water" },
                new typing { typing_name = "electric" },
                new typing { typing_name = "grass" },
                new typing { typing_name = "ice" },
                new typing { typing_name = "fighting" },
                new typing { typing_name = "poison" },
                new typing { typing_name = "ground" },
                new typing { typing_name = "flying" },
                new typing { typing_name = "psychic" },
                new typing { typing_name = "bug" },
                new typing { typing_name = "rock" },
                new typing { typing_name = "ghost" },
                new typing { typing_name = "dragon" },
                new typing { typing_name = "dark" },
                new typing { typing_name = "steel" },
                new typing { typing_name = "fairy" }
            );
        }
    }
}
