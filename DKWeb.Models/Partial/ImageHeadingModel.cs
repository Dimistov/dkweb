namespace DKWeb.Models
{
	public class ImageHeadingModel
    {
		public string HeadingText { get; set; }
		public string ImgURL { get; set; }

		public ImageHeadingModel()
		{

		}
		public ImageHeadingModel(string t, string i)
		{
            HeadingText = t;
            ImgURL = i;
		}

		public ImageHeadingModel NewModel(string t, string i)
		{
			return new ImageHeadingModel(t, i);
		}
	}
}
