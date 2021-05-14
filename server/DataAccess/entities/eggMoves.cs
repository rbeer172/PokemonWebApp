using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("egg_moves")]
    public class eggMoves
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int pokemon_id { get; set; }
        [ForeignKey(nameof(pokemon_id))]
        public pokemonEntity pokemon { get; set; }

        [Required]
        public string move { get; set; }
        [ForeignKey(nameof(move))]
        public moves pokemon_move { get; set; }
    }
}
