using System.Collections.Generic;
using server.DataAccess.entities;

namespace server.Domain
{
    public class evolutionTree
    {
        public List<evolution> evolutions { get; set; }
        public List<PokemonEvolutionGroup> pokemon { get; set; }
    }
}
