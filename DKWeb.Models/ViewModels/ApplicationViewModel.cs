namespace DKWeb.Models
{
    /// <summary>
    /// General application properties with a self singleton instance
    /// </summary>
    public class ApplicationViewModel
    {
        // Singleton
        public static ApplicationViewModel Instance = new ApplicationViewModel()
        {
            Username = "",
        };

        #region Properties
        public string Username { get; set; }


        #endregion

    }
}
