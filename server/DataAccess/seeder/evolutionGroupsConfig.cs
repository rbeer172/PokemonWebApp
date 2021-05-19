using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class evolutionGroupsConfig : IEntityTypeConfiguration<evolutionGroup>
    {
        public void Configure(EntityTypeBuilder<evolutionGroup> builder)
        {
            builder.ToTable("evolution_group");
            builder.HasData(
                new evolutionGroup {  id = 1 }
            );
        }
    }
}
