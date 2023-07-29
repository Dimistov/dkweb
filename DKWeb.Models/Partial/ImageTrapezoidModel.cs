namespace DKWeb.Models
{
	public class ImageTrapezoidModel
	{
		public string Heading { get; set; }
		public string Paragraph { get; set; }
		public List<string> FactListing { get; set; }
        public string MainImgURL { get; set; }
        public string SecondaryImgURL { get; set; }

		/// <summary>
		/// On which side to display the image
		/// </summary>
		public Side ImgSide { get; set; }

		public TrapezoidAdaptation Adaptation { get; set; }
		public ImageTrapezoidModel()
		{

		}
		public ImageTrapezoidModel(string heading, string paragraph, Side side, string mainImage, string secondaryImage, List<string> facts, TrapezoidAdaptation adaptation)
		{
			Heading = heading;
			Paragraph = paragraph;
			ImgSide = side;
			MainImgURL = mainImage;
			SecondaryImgURL = secondaryImage;
			FactListing = facts;
			Adaptation = adaptation;
		}

		public ImageTrapezoidModel NewModel(string heading, string paragraph, Side side, string mainImage, string secondaryImage = "", List<string> facts = null, TrapezoidAdaptation adaptation = TrapezoidAdaptation.None)
		{
			return new ImageTrapezoidModel(heading, paragraph, side, mainImage, secondaryImage, facts, adaptation);
		}
	}
}
