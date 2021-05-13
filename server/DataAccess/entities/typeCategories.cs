using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("type_categories")]
    public class typeCategories
    {
        [Key]
        public string category { get; set; }
    }
}
