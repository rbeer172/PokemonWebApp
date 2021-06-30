namespace server.Domain
{
    public class levelupMoves
    {
        public int Level { get; set; }
        public string Type { get; set; }
        public string Move { get; set; }
        public string Category { get; set; }
        public int? Power { get; set; }
        public int? Accuracy { get; set; }
        public int PP { get; set; }
        public string Description { get; set; }
    }
}
