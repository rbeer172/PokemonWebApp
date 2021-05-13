using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("accuracy_values")]
    public class accuracyValues
    {
        [Key]
        public int accuracy { get; set; }
    }
}
