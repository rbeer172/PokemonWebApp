using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace server.DataAccess.entities
{
    [Table("pokemon")]
    public class pokemonEntity
    {
        [Key]
        public int pokemon_id { get; set; }
        [Required]
        public int pokdex_id { get; set; }
        [Required]
        public string pokemon_name { get; set; }
        [Required]
        public string species { get; set; }
        [Required]
        public float height { get; set; }
        [Required]
        public float weight { get; set; }
        [Required]
        public int max_exp { get; set; }
        [Required]
        public int hp { get; set; }
        [Required]
        public int attack { get; set; }
        [Required]
        public int defense { get; set; }
        [Required]
        public int special_attack { get; set; }
        [Required]
        public int special_defense { get; set; }
        [Required]
        public int speed { get; set; }
        [Required]
        public int total { get; set; }
        [Required]
        public string description { get; set; }

        public List<pokemonTypes> type { get; set; }
        public List<pokemonAbilties> abilities { get; set; }
        public List<pokemonEggGroups> eggGroups { get; set; }
        public List<levelupLearnedMoves> levelUpMoves { get; set; }
        public List<evolutionLearnedMoves> evolutionMoves { get; set; }
        public List<eggMoves> eggMoves { get; set; }
        public List<tmLearnedMoves> tmMoves { get; set; }
        public List<trLearnedMoves> trMoves { get; set; }
    }
}
