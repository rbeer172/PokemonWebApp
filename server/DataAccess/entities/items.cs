using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("items")]
    public class items
    {
        [Key]
        public string name { get; set; }
        [Required]
        public string description { get; set; }
    }
}
