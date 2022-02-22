namespace SpaceTourism.Models { 
    public class Member
    {
        public int Index { get; set; }
        public string Name { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }
        public string ImageAlt { get; set; }

        public string ToTag()
        {
            return Title.Replace("", "-");
        }
    }
}
