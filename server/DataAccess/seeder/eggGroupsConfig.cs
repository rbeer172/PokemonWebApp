using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class eggGroupsConfig : IEntityTypeConfiguration<eggGroups>
    {
        public void Configure(EntityTypeBuilder<eggGroups> builder)
        {
            builder.ToTable("egg_groups");
            builder.HasData(
                new eggGroups { name = "Grass" },
                new eggGroups { name = "Monster" }
            );
        }
    }
}
