namespace DKWeb.Models
{
	public class HoverableDropdownModel
	{
		public List<string> PageNames { get; set; }
		public List<string> PageLinks { get; set; }

		public HoverableDropdownModel()
		{

		}
		public HoverableDropdownModel(List<string> names, List<string> links)
		{
			PageNames = names;
			PageLinks = links;
		}

		public HoverableDropdownModel NewModel(List<string> names, List<string> links)
		{
			return new HoverableDropdownModel(names, links);
		}
	}
}
