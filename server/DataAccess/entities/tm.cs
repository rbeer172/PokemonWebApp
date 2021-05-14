﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.DataAccess.entities
{
    [Table("tm")]
    public class tm
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string move_name { get; set; }
        [ForeignKey(nameof(move_name))]
        public moves move { get; set; }

    }
}
