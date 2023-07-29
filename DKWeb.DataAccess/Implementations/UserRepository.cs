using DKWeb.Models;

namespace DKWeb.DataAccess
{
    /// <summary>
    /// Some sample repository implementation
    /// </summary>
    public class UserRepository : Repository<UserDTO>, IUserRepository
    {
        #region Private variables
        /// <summary>
        /// Getting the default DbContext where all entities are denoted by some DbSet
        /// </summary>
        private readonly ApplicationDbContext mDb;

        #endregion


        public UserRepository(ApplicationDbContext db) : base(db)
        {

        }
        public void Update(UserDTO user)
        {
            mDb.Update(user);
        }
    }
}
