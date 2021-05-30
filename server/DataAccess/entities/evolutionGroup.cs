using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace server.DataAccess.entities
{
    [Table("evolution_group")]
    public class evolutionGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public List<pokemonEvolutionGroup> pokemon { get; set; }
        public List<evolution> evolutions { get; set; }
    }
}
