using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class ppConfig : IEntityTypeConfiguration<ppValues>
    {
        public void Configure(EntityTypeBuilder<ppValues> builder)
        {
            builder.ToTable("pp_values");
            builder.HasData(
                new ppValues { pp = 10 },
                new ppValues { pp = 15 },
                new ppValues { pp = 20 },
                new ppValues { pp = 35 }
            );
        }
    }
}
