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
                new accuracyValues { accuracy = 100 }
            );
        }
    }
}
