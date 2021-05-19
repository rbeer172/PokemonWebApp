using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class tmConfig : IEntityTypeConfiguration<tm>
    {
        public void Configure(EntityTypeBuilder<tm> builder)
        {
            builder.ToTable("tm");
            builder.HasData(
                new tm
                {
                    id = 28,
                    move_name = "Giga Drain"
                }
            );
        }
    }
}
