using NumberChoosing.DAL;
using NumberChoosing.Entities;

namespace NumberChoosing.BL
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository()
        {
            
        }

        public UserRepository(HoangGameSystemEntities dbContext): base(dbContext)
        {
            
        }
    }
}
