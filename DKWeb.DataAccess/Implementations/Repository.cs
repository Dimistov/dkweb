using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DKWeb.DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        #region Private variables
        /// <summary>
        /// Getting the default DbContext where all entities are denoted by some DbSet
        /// </summary>
        private readonly ApplicationDbContext mDb;

        /// <summary>
        /// A placeholder for the generic DbSet (manipulation on any set)
        /// </summary>
        internal DbSet<T> Entities { get; set; }
        #endregion


        public Repository(ApplicationDbContext db)
        {
            mDb = db;
            // Sets the placeholder to the set chosen by the generic T
            Entities = mDb.Set<T>();
        }

        public void Add(T entity)
        {
            Entities.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = Entities;
            return query.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            // An implementation of IEnumerable which allows the functionality of a query (where clauses)
            IQueryable<T> query = Entities;
            return query.Where(filter).FirstOrDefault();
        }

        public void Remove(T entity)
        {
            Entities.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            Entities.RemoveRange(entities);
        }
    }
}
