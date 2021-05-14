using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("type_effectiveness")]
    public class typeEffectiveness
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public string attacking_type { get; set; }
        [Required]
        public string defending_type { get; set; }

        public typing attack { get; set; }
        public typing defend { get; set; }

        [Required]
        public float multiplier { get; set; }
    }
}
