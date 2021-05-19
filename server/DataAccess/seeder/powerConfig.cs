using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class powerConfig: IEntityTypeConfiguration<powerValues>
    {
        public void Configure(EntityTypeBuilder<powerValues> builder)
        {
            builder.ToTable("power_values");
            builder.HasData(
                new powerValues { power = 40 },
                new powerValues { power = 75 },
                new powerValues { power = 90 },
                new powerValues { power = 120 }
            );
        }
    }
}
