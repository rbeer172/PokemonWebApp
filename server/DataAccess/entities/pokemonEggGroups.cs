using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("pokemon_egg_groups")]
    public class pokemonEggGroups
    {
        public string pokemon_id { get; set; }
        [ForeignKey(nameof(pokemon_id))]
        public pokemonEntity pokemon { get; set; }

        public string eggGroup { get; set; }
        [ForeignKey(nameof(eggGroup))]
        public eggGroups pokemon_egg_group{ get; set; }
    }
}
