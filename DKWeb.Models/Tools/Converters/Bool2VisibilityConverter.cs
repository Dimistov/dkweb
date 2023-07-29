namespace DKWeb.Models
{
    public class Bool2VisibilityConverter
    {
        public static string Convert(bool visibility)
        {
            switch (visibility)
            {
                case true:
                    return "visible";
                case false:
                    return "hidden";
            }
        }
    }
}
