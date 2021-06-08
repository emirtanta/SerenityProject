using SerenityProject.DataAccessLayer.Abstract;
using SerenityProject.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SerenityProject.DataAccessLayer.Concrete.EntityFramework
{
    public class EfGenericRepository<T> : IRepository<T> where T : class
    {
        SerenityContext _sc = new SerenityContext();

        DbSet<T> _object;


        public EfGenericRepository()
        {
            _object = _sc.Set<T>();
        }

        public void Delete(T entity)
        {
            var deletedEntity = _sc.Entry(entity);
            deletedEntity.State = EntityState.Deleted;

            _sc.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T entity)
        {
            var addedEntity=_sc.Entry(entity);
            addedEntity.State = EntityState.Added;

            _sc.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T entity)
        {
            var updatedEntity = _sc.Entry(entity);
            updatedEntity.State = EntityState.Modified;

            _sc.SaveChanges();
        }
    }
}
