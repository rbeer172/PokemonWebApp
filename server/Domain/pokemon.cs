using System.Collections.Generic;

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
        public int max_exp { get; set; }
        public int hp { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int special_attack { get; set; }
        public int special_defense { get; set; }
        public int speed { get; set; }
        public int total { get; set; }
        public string description { get; set; }
        public List<string> type { get; set; }
        public List<PokemonAbilities> abilities { get; set; }
        public List<string> eggGroups { get; set; }
        public List<levelupMoves> levelUpMoves { get; set; }
        public List<evolutionMoves> evolutionMoves { get; set; }
        public List<eggMoves> eggMoves { get; set; }
        public List<tmMoves> tmMoves { get; set; }
        public List<trMoves> trMoves { get; set; }
        public List<PokemonTypeEffectivnees> effectiveness { get; set; }
    }
}
