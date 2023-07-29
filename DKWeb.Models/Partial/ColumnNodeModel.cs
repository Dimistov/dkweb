namespace DKWeb.Models
{
	public class ColumnNodeModel
	{
		public string NodeName { get; set; }
		public string NodeIMG { get; set; }
		public string NodeAddon { get; set; }

		public ColumnNodeModel()
		{

		}
		public ColumnNodeModel(string name, string image, string addon)
		{
			NodeName = name;
			NodeIMG = image;
			NodeAddon = addon;
		}

		public ColumnNodeModel NewModel(string name, string image, string addon = "")
		{
			return new ColumnNodeModel(name, image, addon);
		}
	}
}
