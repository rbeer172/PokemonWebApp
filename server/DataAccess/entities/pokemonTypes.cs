using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("pokemon_types")]
    public class pokemonTypes
    {
        public string pokemon_id { get; set; }
        [ForeignKey(nameof(pokemon_id))]
        public pokemonEntity pokemon { get; set; }

        public string type { get; set; }
        [ForeignKey(nameof(type))]
        public typing pokemon_type { get; set; }
    }
}
