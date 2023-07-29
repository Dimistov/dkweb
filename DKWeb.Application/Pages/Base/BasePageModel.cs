using DKWeb.DataAccess;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DKWeb.Application
{
	public class BasePageModel : PageModel
    {
        #region Variables
        // inherent access to UOW
        protected IUnitOfWork UOW { get; set; }
        #endregion

        #region Properties
        // some default reference classes appearing on every page

        #endregion

        public BasePageModel(IUnitOfWork unit)
        {
            UOW = unit;
        }

        public virtual void OnGet()
        {

        }
    }
}
