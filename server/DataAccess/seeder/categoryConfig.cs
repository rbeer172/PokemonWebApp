using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class categoryConfig : IEntityTypeConfiguration<moveCategories>
    {
        public void Configure(EntityTypeBuilder<moveCategories> builder)
        {
            builder.ToTable("move_categories");
            builder.HasData(
                new moveCategories { category = "physical" },
                new moveCategories { category = "special" },
                new moveCategories { category = "status" }
            );
        }
    }
}
