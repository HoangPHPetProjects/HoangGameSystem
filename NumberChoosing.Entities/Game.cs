namespace NumberChoosing.Entities
{
    using System.Collections.Generic;
    
    public partial class Game
    {
        public Game()
        {
            GameTables = new HashSet<GameTable>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    
        public virtual ICollection<GameTable> GameTables { get; set; }
    }
}
