using DKWeb.Models;

namespace DKWeb.DataAccess
{
    /// <summary>
    /// Some sample repository interface
    /// </summary>
    public interface IUserRepository : IRepository<UserDTO>
    {
        public void Update(UserDTO user);
    }
}
