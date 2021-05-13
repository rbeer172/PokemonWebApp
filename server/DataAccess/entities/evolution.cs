using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("evolution")]
    public class evolution
    {
        public string pokemon_id { get; set; }
        [ForeignKey(nameof(pokemon_id))]
        public pokemonEntity pokemon { get; set; }

        public string evolution_id { get; set; }
        [ForeignKey(nameof(evolution_id))]
        public evolutionGroup pokemon_evolution { get; set; }

        public string evolved_pokemon { get; set; }
        [ForeignKey(nameof(evolved_pokemon))]
        public pokemonEntity pokemonEvolved { get; set; }

        public int level { get; set; }

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
        public tm pokemon_move { get; set; }

        public bool trade { get; set; }
        public string other { get; set; }
    }
}
