using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using server.DataAccess.entities;

namespace server.DataAccess.seeder
{
    public class moveConfig : IEntityTypeConfiguration<moves>
    {
        public void Configure(EntityTypeBuilder<moves> builder)
        {
            builder.ToTable("moves");
            builder.HasData(
                new moves { 
                    name = "Tackle",
                    typing_name = "normal",
                    category = "physical",
                    power = 40,
                    accuracy = 100,
                    pp = 35,
                    priority = 0,
                    description = "A basic attack that deals damage."
                },
                new moves
                {
                    name = "Poison Powder",
                    typing_name = "poison",
                    category = "status",
                    power = null,
                    accuracy = 75,
                    pp = 35,
                    priority = 0,
                    description = "Target will be poisoned. Poisoned Pokémon lose 1⁄8 of their maximum HP each turn."
                },
                new moves
                {
                    name = "Solar Beam",
                    typing_name = "grass",
                    category = "special",
                    power = 120,
                    accuracy = 100,
                    pp = 10,
                    priority = 0,
                    description = "Charges the first turn then deals damage the second turn. " +
                    "If during sunlight or holding a power herb, deals damage the first turn." +
                    "Rain, hail and sandstorm weather reduces power by 50%"
                },
                new moves
                {
                    name = "Petal Dance",
                    typing_name = "grass",
                    category = "special",
                    power = 120,
                    accuracy = 100,
                    pp = 10,
                    priority = 0,
                    description = "The user of Petal Dance attacks for 2-3 turns, during which it cannot switch out, " +
                    "and then becomes confused," +
                    " for 1-4 attacking turns (50% chance in Generations 1-6)." +
                    " The damage received is as if the Pokémon attacks itself with a typeless 40 base power" +
                    " Physical attack. If Petal Dance is disrupted (e.g. if the move misses or the user cannot " +
                    "attack due to paralysis) then it will stop and not cause confusion."
                },
                new moves
                {
                    name = "Giga Drain",
                    typing_name = "grass",
                    category = "special",
                    power = 75,
                    accuracy = 100,
                    pp = 10,
                    priority = 0,
                    description = "Deals damage and the user will recover 50% of the HP drained."
                },
                new moves
                {
                    name = "Swords Dance",
                    typing_name = "normal",
                    category = "status",
                    power = null,
                    accuracy = null,
                    pp = 20,
                    priority = 0,
                    description = "Raises the user's Attack by two stages up to a max of six."
                },
                new moves
                {
                    name = "Petal Blizzard",
                    typing_name = "grass",
                    category = "physical",
                    power = 90,
                    accuracy = 100,
                    pp = 15,
                    priority = 0,
                    description = "Deals damage."
                }
            );
        }
    }
}
