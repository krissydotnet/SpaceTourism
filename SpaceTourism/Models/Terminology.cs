namespace SpaceTourism.Models
{
    public class Terminology
    {
        public int Index { get; set; }
        public string Term { get; set; }

        public string Definition { get; set; }

        public string ImagePortrait { get; set; }

        public string ImageLandscape { get; set; }

        public string ImageAlt { get; set; }

        public string ReplaceSpaces(string text)
        {
            return text.Replace(" ", "-").ToLower();
        }
    }
}
