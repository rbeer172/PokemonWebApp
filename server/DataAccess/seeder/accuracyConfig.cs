using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class accuracyConfig : IEntityTypeConfiguration<accuracyValues>
    {
        public void Configure(EntityTypeBuilder<accuracyValues> builder)
        {
            builder.ToTable("accuracy_values");
            builder.HasData(
                new accuracyValues { accuracy = 75 },
                new accuracyValues { accuracy = 100 },
                new accuracyValues { accuracy = 30 },
                new accuracyValues { accuracy = 50 },
                new accuracyValues { accuracy = 55 },
                new accuracyValues { accuracy = 60 },
                new accuracyValues { accuracy = 70 },
                new accuracyValues { accuracy = 80 },
                new accuracyValues { accuracy = 85 },
                new accuracyValues { accuracy = 90 },
                new accuracyValues { accuracy = 95 }
            );
        }
    }
}
