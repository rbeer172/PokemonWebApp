using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("tr_learned_moves")]
    public class trLearnedMoves
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int pokemon_id { get; set; }
        [ForeignKey(nameof(pokemon_id))]
        public pokemonEntity pokemon { get; set; }

        public int tr_id { get; set; }
        [ForeignKey(nameof(tr_id))]
        public tr pokemon_move { get; set; }
    }
}
