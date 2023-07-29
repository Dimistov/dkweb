using DKWeb.DataAccess;

namespace DKWeb.Application.Pages
{
    public class IndexModel : BasePageModel
    {
        #region Properties

        #endregion

        #region Variables
        // just in case
        // private readonly ILogger<IndexModel> _logger;

        #endregion

        #region Constructor

        public IndexModel(IUnitOfWork unit) : base(unit)
        {
            // _logger = logger;
            UOW = unit;
        }
        #endregion

        #region Handlers


        public override void OnGet()
        {
            // completing base functionality
            base.OnGet();
        }

        // CUSTOM FUNCTIONALITY

        #endregion

    }
}