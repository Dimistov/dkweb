using DKWeb.DataAccess;

namespace DKWeb.Application.Pages
{
	public class SkillsModel : BasePageModel
    {
		public SkillsModel(IUnitOfWork unit) : base(unit)
		{
			
		}

		public override void OnGet()
        {
			base.OnGet();
        }
    }
}
