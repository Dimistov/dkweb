using DKWeb.DataAccess;

namespace DKWeb.Application.Pages.Projects
{
	public class NetCoreProjectsModel : BasePageModel
    {
		public NetCoreProjectsModel(IUnitOfWork unit) : base(unit)
		{
		}

		public override void OnGet()
        {
			base.OnGet();
        }
    }
}
