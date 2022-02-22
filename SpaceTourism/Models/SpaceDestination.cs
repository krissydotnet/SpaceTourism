namespace SpaceTourism.Models
{
    public class SpaceDestination
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string Image { get; set; }
        public string ImageAlt { get; set; }

        public string Distance { get; set; }

        public string Travel { get; set; }

        public bool Active { get; set; }

        public bool IsHidden { get; set; }
    }
}
