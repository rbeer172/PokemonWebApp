using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("pokemon")]
    public class pokemonEntity
    {
        [Key]
        public int pokemon_id { get; set; }
        public int pokdex_id { get; set; }
        public string pokemon_name { get; set; }
        public string species { get; set; }
        public float height { get; set; }
        public float weight { get; set; }
        public string growth_rate { get; set; }
        public int hp { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int special_attack { get; set; }
        public int special_defense { get; set; }
        public int speed { get; set; }
        public int total { get; set; }
        public string description { get; set; }
    }
}
