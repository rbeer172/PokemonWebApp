using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using server.DataAccess.entities;

namespace server.DataAccess
{
    public class pokemonDataContext : DbContext
    {
        public pokemonDataContext(DbContextOptions<pokemonDataContext> opts) : base(opts) { }

        public DbSet<pokemonEntity> pokemon { get; set; }
        public DbSet<abilities> abilities { get; set; }
        public DbSet<accuracyValues> accuracy { get; set; }
        public DbSet<eggGroups> egg_groups { get; set; }
        public DbSet<eggMoves> egg_moves { get; set; }
        public DbSet<evolution> evolution { get; set; }
        public DbSet<evolutionGroup> evolution_groups{ get; set; }
        public DbSet<evolutionLearnedMoves> evolution_moves { get; set; }
        public DbSet<items> items { get; set; }
        public DbSet<levelupLearnedMoves> levelUpMoves { get; set; }
        public DbSet<moves> pokemon_moves { get; set; }
        public DbSet<pokemonAbilties> pokemon_abilities { get; set; }
        public DbSet<pokemonEggGroups> pokemon_egg_groups { get; set; }
        public DbSet<pokemonTypes> pokemon_types { get; set; }
        public DbSet<powerValues> power_values { get; set; }
        public DbSet<ppValues> pp_values{ get; set; }
        public DbSet<tm> TMs{ get; set; }
        public DbSet<tr> TRs{ get; set; }
        public DbSet<tmLearnedMoves> tm_learned_moves { get; set; }
        public DbSet<trLearnedMoves> tr_learned_moves { get; set; }
        public DbSet<moveCategories> move_categories { get; set; }
        public DbSet<typeEffectiveness> type_effectiveness { get; set; }
        public DbSet<typing> types { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            //model.Entity<eggMoves>().HasKey(l => new { l.pokemon_id , l.move });
            model.Entity<evolution>()
                .HasOne(pt => pt.pokemon)
                .WithOne()
                .HasForeignKey<evolution>(pt => pt.pokemon_id)
                .OnDelete(DeleteBehavior.Restrict);
            model.Entity<evolution>()
                .HasOne(pt => pt.pokemonEvolved)
                .WithOne()
                .HasForeignKey<evolution>(pt => pt.evolved_pokemon)
                .OnDelete(DeleteBehavior.Restrict);

            model.Entity<typeEffectiveness>()
                .HasOne(pt => pt.attack)
                .WithOne()
                .HasForeignKey<typeEffectiveness>(pt => pt.attacking_type)
                .OnDelete(DeleteBehavior.Restrict);
            model.Entity<typeEffectiveness>()
                .HasOne(pt => pt.defend)
                .WithOne()
                .HasForeignKey<typeEffectiveness>(pt => pt.defending_type)
                .OnDelete(DeleteBehavior.Restrict);
            //model.Entity<evolutionLearnedMoves>().HasKey(l => new { l.pokemon_id, l.move});
            //model.Entity<levelupLearnedMoves>().HasKey(l => new { l.pokemon_id, l.move });
        }
    }
}
