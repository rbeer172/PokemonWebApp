using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("tm_learned_moves")]
    public class tmLearnedMoves
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int pokemon_id { get; set; }
        [ForeignKey(nameof(pokemon_id))]
        public pokemonEntity pokemon { get; set; }

        public int tm_id { get; set; }
        [ForeignKey(nameof(tm_id))]
        public tm pokemon_move { get; set; }
    }
}
