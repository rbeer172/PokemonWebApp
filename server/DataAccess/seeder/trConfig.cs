using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class trConfig : IEntityTypeConfiguration<tr>
    {
        public void Configure(EntityTypeBuilder<tr> builder)
        {
            builder.ToTable("tr");
            builder.HasData(
                new tr
                {
                    id = 1,
                    move_name = "Swords Dance"
                }
            );
        }
    }
}
