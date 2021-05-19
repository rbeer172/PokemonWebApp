using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class abilitiesConfig : IEntityTypeConfiguration<abilities>
    {
        public void Configure(EntityTypeBuilder<abilities> builder)
        {
            builder.ToTable("abilities");
            builder.HasData(
                new abilities {
                    ability_name = "Overgrow",
                    description = "Increases the power of Grass-type moves by 50% when the ability-bearer's " +
                    "HP falls below a third of its maximum HP"
                },
                new abilities
                {
                    ability_name = "Chlorophyll",
                    description = "Doubles the ability-bearer's Speed during bright sunshine."
                }
            );
        }
    }
}
