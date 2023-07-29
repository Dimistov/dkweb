namespace DKWeb.DataAccess
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// Sample property of the unit of work implementation
        /// </summary>
        public IUserRepository User { get; set; }

        // pushing changes to the database is an update to the entire database - that is why it is placed here
        public void Save();
    }
}
