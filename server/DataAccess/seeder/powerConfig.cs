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
                new powerValues { power = 120 },
                new powerValues { power = 10 },
                new powerValues { power = 15 },
                new powerValues { power = 18 },
                new powerValues { power = 20 },
                new powerValues { power = 30 },
                new powerValues { power = 35 },
                new powerValues { power = 45 },
                new powerValues { power = 50 },
                new powerValues { power = 55 },
                new powerValues { power = 60 },
                new powerValues { power = 65 },
                new powerValues { power = 70 },
                new powerValues { power = 80 },
                new powerValues { power = 95 },
                new powerValues { power = 100 },
                new powerValues { power = 110 },
                new powerValues { power = 125 },
                new powerValues { power = 130 },
                new powerValues { power = 140 },
                new powerValues { power = 150 },
                new powerValues { power = 160 },
                new powerValues { power = 200},
                new powerValues { power = 250 }
            );
        }
    }
}
