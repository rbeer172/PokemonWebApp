using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class pokemonEvolutionGroupConfig : IEntityTypeConfiguration<pokemonEvolutionGroup>
    {
        public void Configure(EntityTypeBuilder<pokemonEvolutionGroup> builder)
        {
            builder.ToTable("pokemon_evolution_group");
            builder.HasData(
                new pokemonEvolutionGroup
                {
                    id = 1,
                    pokemon_id = 1,
                    group_id = 1
                },
                new pokemonEvolutionGroup
                {
                    id = 2,
                    pokemon_id = 2,
                    group_id = 1
                },
                new pokemonEvolutionGroup
                {
                    id = 3,
                    pokemon_id = 3,
                    group_id = 1
                }
            );
        }
    }
}
