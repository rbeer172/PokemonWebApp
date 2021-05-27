using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("moves")]
    public class moves
    {
        [Key]
        public string name { get; set; }

        [Required]
        public string typing_name { get; set; }
        [ForeignKey(nameof(typing_name))]
        public typing move_typing { get; set; }

        [Required]
        public string category { get; set; }
        [ForeignKey(nameof(category))]
        public moveCategories move_category { get; set; }

        public int? power { get; set; }
        [ForeignKey(nameof(power))]
        public powerValues move_power { get; set; }

        public int? accuracy { get; set; }
        [ForeignKey(nameof(accuracy))]
        public accuracyValues move_accuracy { get; set; }

        public int pp { get; set; }
        [ForeignKey(nameof(pp))]
        public ppValues move_pp { get; set; }

        [Required]
        public int priority { get; set; }
        [Required]
        public string description { get; set; }

        public tm TM { get; set; }
        public tr TR { get; set; }
    }
}
