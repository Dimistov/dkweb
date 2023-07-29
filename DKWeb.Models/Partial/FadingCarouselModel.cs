namespace DKWeb.Models
{
	public class FadingCarouselModel
	{
		public List<string> Images { get; set; }

		public List<string> Descriptions { get; set; }

		public FadingCarouselModel()
		{

		}
		public FadingCarouselModel(List<string> images, List<string> descriptions)
		{
			Images = images;
			Descriptions = descriptions;
		}

		public FadingCarouselModel NewModel(List<string> images, List<string> descriptions)
		{
			return new FadingCarouselModel(images, descriptions);
		}
	}
}
