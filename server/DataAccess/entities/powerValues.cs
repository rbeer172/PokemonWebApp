using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("power_values")]
    public class powerValues
    {
        [Key]
        public int power { get; set; }
    }
}
