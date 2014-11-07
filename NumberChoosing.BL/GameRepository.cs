using NumberChoosing.DAL;
using NumberChoosing.Entities;

namespace NumberChoosing.BL
{
    public class GameRepository : GenericRepository<Game>
    {
        public GameRepository()
        {
            
        }

        public GameRepository(HoangGameSystemEntities dbContext)
            : base(dbContext)
        {
            
        }
    }
}
