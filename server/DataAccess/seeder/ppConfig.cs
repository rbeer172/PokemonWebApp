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
                new ppValues { pp = 35 },
                new ppValues { pp = 5 },
                new ppValues { pp = 25 },
                new ppValues { pp = 30 },
                new ppValues { pp = 40 }
            );
        }
    }
}
