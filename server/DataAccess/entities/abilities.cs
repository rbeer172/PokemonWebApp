using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("abilities")]
    public class abilities
    {
        [Key]
        public string ability_name { get; set; }
        [Required]
        public string description { get; set; }
    }
}