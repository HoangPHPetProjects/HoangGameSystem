namespace NumberChoosing.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            GameTables = new HashSet<GameTable>();
            UserPlays = new HashSet<UserPlay>();
        }
    
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime? LastLogin { get; set; }
    
        public virtual ICollection<GameTable> GameTables { get; set; }
        public virtual ICollection<UserPlay> UserPlays { get; set; }
    }
}
