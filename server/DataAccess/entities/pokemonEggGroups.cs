using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("pokemon_egg_groups")]
    public class pokemonEggGroups
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int pokemon_id { get; set; }
        [ForeignKey(nameof(pokemon_id))]
        public pokemonEntity pokemon { get; set; }

        [Required]
        public string eggGroup { get; set; }
        [ForeignKey(nameof(eggGroup))]
        public eggGroups pokemon_egg_group{ get; set; }
    }
}
