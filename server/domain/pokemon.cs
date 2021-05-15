using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Domain
{
    public class pokemon
    {
        public int pokemon_id { get; set; }
        public int pokdex_id { get; set; }
        public string pokemon_name { get; set; }
        public string species { get; set; }
        public float height { get; set; }
        public float weight { get; set; }
        public string growth_rate { get; set; }
        public int hp { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int special_attack { get; set; }
        public int special_defense { get; set; }
        public int speed { get; set; }
        public int total { get; set; }
        public string description { get; set; }
        public List<string> type { get; set; }
        public List<string> abilities { get; set; }
        public List<string> eggGroups { get; set; }
        public List<string> levelUpMoves { get; set; }
        public List<string> evolutionMoves { get; set; }
        public List<string> eggMoves { get; set; }
        public List<int> tmMoves { get; set; }
        public List<int> trMoves { get; set; }
    }
}
