using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("evolution")]
    public class evolution
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int pokemon_id { get; set; }
        public pokemonEntity pokemon { get; set; }

        public int evolution_id { get; set; }
        [ForeignKey(nameof(evolution_id))]
        public evolutionGroup pokemon_evolution { get; set; }

        public int evolved_pokemon { get; set; }
        public pokemonEntity pokemonEvolved { get; set; }

        public int? level { get; set; }

        public string held_item { get; set; }
        [ForeignKey(nameof(held_item))]
        public items heldItem { get; set; }

        public string use_item { get; set; }
        [ForeignKey(nameof(use_item))]
        public items useItem { get; set; }

        public string time { get; set; }
        public bool friendship { get; set; }

        public string move { get; set; }
        [ForeignKey(nameof(move))]
        public moves pokemon_move { get; set; }

        public bool trade { get; set; }
        public string other { get; set; }
    }
}
