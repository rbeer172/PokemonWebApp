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
                new typing{typing_name = "grass"},
                new typing{typing_name = "poison"}
            );
        }
    }
}
