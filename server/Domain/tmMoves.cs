using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Domain
{
    public class tmMoves
    {
        public int TM { get; set; }
        public string Move { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public int? Power { get; set; }
        public int? Accuracy { get; set; }
        public int PP { get; set; }
        public string Description { get; set; }
    }
}
