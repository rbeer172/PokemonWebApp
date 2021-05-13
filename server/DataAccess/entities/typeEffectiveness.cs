using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("type_effectiveness")]
    public class typeEffectiveness
    {
        public string attacking_type { get; set; }
        public string defending_type { get; set; }

        [ForeignKey(nameof(attacking_type))]
        public typing attack { get; set; }

        [ForeignKey(nameof(defending_type))]
        public typing defend { get; set; }

        public float multiplier { get; set; }
    }
}
