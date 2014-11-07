using NumberChoosing.DAL;
using NumberChoosing.Entities;

namespace NumberChoosing.BL
{
    public class GameTableRepository : GenericRepository<GameTable>
    {
        public GameTableRepository()
        {
            
        }

        public GameTableRepository(HoangGameSystemEntities dbContext)
            : base(dbContext)
        {
            
        }
    }
}
