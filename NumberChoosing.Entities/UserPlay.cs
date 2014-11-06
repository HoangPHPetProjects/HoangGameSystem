namespace NumberChoosing.Entities
{
    public partial class UserPlay
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int TableID { get; set; }
        public int Point { get; set; }
        public bool IsReady { get; set; }
    
        public virtual GameTable GameTable { get; set; }
        public virtual User User { get; set; }
    }
}
