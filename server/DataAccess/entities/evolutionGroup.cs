using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("evolution_group")]
    public class evolutionGroup
    {
        [Key]
        public int id { get; set; }
    }
}
