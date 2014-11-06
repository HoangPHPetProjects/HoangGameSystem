namespace NumberChoosing.Entities
{
    using System.Collections.Generic;
    
    public partial class GameTable
    {
        public GameTable()
        {
            UserPlays = new HashSet<UserPlay>();
        }
    
        public int ID { get; set; }
        public int GameID { get; set; }
        public int WinnerID { get; set; }
        public TableState State { get; set; }
    
        public virtual Game Game { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<UserPlay> UserPlays { get; set; }
    }
}
