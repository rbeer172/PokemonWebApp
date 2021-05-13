using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("tm_learned_moves")]
    public class tmLearnedMoves
    {
        public string pokemon_id { get; set; }
        [ForeignKey(nameof(pokemon_id))]
        public pokemonEntity pokemon { get; set; }

        public string tm_id { get; set; }
        [ForeignKey(nameof(tm_id))]
        public tm pokemon_move { get; set; }
    }
}
