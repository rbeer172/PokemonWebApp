using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("egg_groups")]
    public class eggGroups
    {
        [Key]
        public string name { get; set; }
    }
}