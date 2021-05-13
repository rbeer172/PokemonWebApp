using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("pokemon_abilities")]
    public class pokemonAbilties
    {
        public string pokemon_id { get; set; }
        [ForeignKey(nameof(pokemon_id))]
        public pokemonEntity pokemon { get; set; }

        public string ability { get; set; }
        [ForeignKey(nameof(ability))]
        public abilities pokemon_ability { get; set; }

        public bool hidden { get; set; }
    }
}
