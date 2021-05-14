using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("pokemon_abilities")]
    public class pokemonAbilties
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int pokemon_id { get; set; }
        [ForeignKey(nameof(pokemon_id))]
        public pokemonEntity pokemon { get; set; }

        [Required]
        public string ability { get; set; }
        [ForeignKey(nameof(ability))]
        public abilities pokemon_ability { get; set; }

        [Required]
        public bool hidden { get; set; }
    }
}
