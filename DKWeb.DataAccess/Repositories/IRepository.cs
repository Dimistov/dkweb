using System.Linq.Expressions;

namespace DKWeb.DataAccess
{
    /// <summary>
    /// Generic interface functioning as data access functionality for different data across the entire web app
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        //T - Category, for CRUD operations

        /// <summary>
        /// Retrieving all entities T from the database
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Filters and retrieves some entity T - it is the result after filtering through Func<>
        /// </summary>
        /// <param name="filter">The filter by which to select some entity (passed as expression type so that the filtering is done here)</param>
        /// <returns></returns>
        T GetFirstOrDefault(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

    }
}
