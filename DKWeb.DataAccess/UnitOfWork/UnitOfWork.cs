namespace DKWeb.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Variables
        private ApplicationDbContext mDb { get; set; }
        #endregion

        #region Properties

        public IUserRepository User { get; set; }

        #endregion


        #region Constructor
        public UnitOfWork(ApplicationDbContext db)
        {
            mDb = db;
            User = new UserRepository(mDb);
        }
        #endregion

        public void Save()
        {
            mDb.SaveChanges();
        }
    }
}
