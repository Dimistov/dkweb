namespace DKWeb.Models
{
	public class ContactNodeModel
	{
		public string NodeName { get; set; }
		public string NodeIMG { get; set; }
		
		public string NodeLink { get; set; }	
		public string NodeLinkText { get; set; }

		public ContactNodeModel()
		{

		}
		public ContactNodeModel(string name, string image, string link, string linkText)
		{
			NodeName = name;
			NodeIMG = image;
			NodeLink = link;
			NodeLinkText = linkText;
		}

		public ContactNodeModel NewModel(string name, string image, string link = "", string linkText = "")
		{
			return new ContactNodeModel(name, image, link, linkText);
		}
	}
}
