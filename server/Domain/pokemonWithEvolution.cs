using System.Collections.Generic;

namespace server.Domain
{
    public class pokemonWithEvolution
    {
        public pokemon Pokemon { get; set; }
        public List<evolutionLine> EvolutionTree { get; set; }
    }
}
