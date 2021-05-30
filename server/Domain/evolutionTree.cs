using System.Collections.Generic;

namespace server.Domain
{
    public class evolutionTree
    {
        public List<Evolution> evolutions { get; set; }
        public List<PokemonEvolutionGroup> pokemon { get; set; }
    }
}
