using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Domain
{
    public class evolutionLine
    {
        public int pokemon_id { get; set; }
        public int evolution_id { get; set; }
        public int evolved_pokemon { get; set; }
        public int? level { get; set; }
        public string held_item { get; set; }
        public string use_item { get; set; }
        public string time { get; set; }
        public bool friendship { get; set; }
        public string move { get; set; }
        public bool trade { get; set; }
        public string other { get; set; }
    }
}
