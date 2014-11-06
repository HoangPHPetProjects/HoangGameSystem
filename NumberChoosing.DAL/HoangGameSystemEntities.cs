using NumberChoosing.Entities;

namespace NumberChoosing.DAL
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class HoangGameSystemEntities : DbContext
    {
        public HoangGameSystemEntities()
            : base("name=HoangGameSystemEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<GameTable> GameTables { get; set; }
        public virtual DbSet<UserPlay> UserPlays { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
