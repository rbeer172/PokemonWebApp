using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("move_categories")]
    public class moveCategories
    {
        [Key]
        public string category { get; set; }
    }
}
