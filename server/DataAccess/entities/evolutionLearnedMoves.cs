using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("evolution_learned_moves")]
    public class evolutionLearnedMoves
    {
        public string pokemon_id { get; set; }
        [ForeignKey(nameof(pokemon_id))]
        public pokemonEntity pokemon { get; set; }

        public string move { get; set; }
        [ForeignKey(nameof(move))]
        public moves pokemon_move { get; set; }
    }
}
