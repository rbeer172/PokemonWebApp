using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("pp_values")]
    public class ppValues
    {
        [Key]
        public int pp { get; set; }
    }
}
