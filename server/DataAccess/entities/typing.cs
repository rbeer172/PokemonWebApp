using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("typing")]
    public class typing
    {
        [Key]
        public string typing_name { get; set; }
    }
}
