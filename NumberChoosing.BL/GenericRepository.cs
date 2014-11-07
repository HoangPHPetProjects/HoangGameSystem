using System.Collections.Generic;
using System.Linq;
using NumberChoosing.DAL;

namespace NumberChoosing.BL
{
   public class GenericRepository<T> where T: class
   {
       protected HoangGameSystemEntities _dbContext;

       public GenericRepository()
       {
           _dbContext = new HoangGameSystemEntities();
       }

       public GenericRepository(HoangGameSystemEntities dbContext)
       {
           _dbContext = dbContext;
       }

       public virtual IList<T> GetList()
       {
           return _dbContext.Set<T>().ToList();
       }

       public virtual T FindById(object id)
       {
           return _dbContext.Set<T>().Find(id);
       }

       public virtual void Insert(T entity)
       {
           _dbContext.Set<T>().Add(entity);
           _dbContext.SaveChanges();
       }

       public virtual void Update(T entity, object key)
       {
           T existing = _dbContext.Set<T>().Find(key);
           if (existing != null)
           {
               _dbContext.Entry(existing).CurrentValues.SetValues(entity);
               _dbContext.SaveChanges();
           }
       }

       public virtual void Delete(T entity)
       {
           _dbContext.Set<T>().Remove(entity);
           _dbContext.SaveChanges();
       }

       public virtual void Delete(object key)
       {
           T existing = _dbContext.Set<T>().Find(key);
           if (existing != null)
           {
               _dbContext.Set<T>().Remove(existing);
               _dbContext.SaveChanges();
           }
       }
   }
}
