namespace DKWeb.Models
{
	public class PageStatementModel
	{
		public string Question { get; set; }
		public string Prompt { get; set; }

		public PageStatementModel()
		{

		}
		public PageStatementModel(string question, string prompt)
		{
			Question = question;
			Prompt = prompt;
		}

		public PageStatementModel NewModel(string q, string p)
		{
			return new PageStatementModel(q, p);
		}
	}
}
