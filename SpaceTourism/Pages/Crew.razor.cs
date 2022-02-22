using Microsoft.AspNetCore.Components.Web;
using SpaceTourism.Models;

namespace SpaceTourism.Pages
{
    public partial class Crew
    {
        public List<Member> CrewMembers = new List<Member>()
        {new Member{Index = 0, 
            Name = "Douglas Hurley", 
            Title = "Commander",
            Description = "Douglas Gerald Hurley is an American engineer, former Marine Corps pilot and former NASA astronaut. He launched into space for the third time as commander of Crew Dragon Demo-2.", 
            Image = "/assets/crew/image-douglas-hurley.png", 
            ImageAlt = "the commander"}, 
            new Member{Index = 1, 
                Name = "Mark Shuttleworth", 
                Title = "Mission Specialist", 
                Description = "Mark Richard Shuttleworth is the founder and CEO of Canonical, the company behind the Linux-based Ubuntu operating system. Shuttleworth became the first South African to travel to space as a space tourist.", 
                Image = "/assets/crew/image-mark-shuttleworth.png", 
                ImageAlt = "the mission specialist"}, 
            new Member{Index = 2, 
                Name = "Victor Glover", 
                Title = "Pilot", 
                Description = "Pilot on the first operational flight of the SpaceX Crew Dragon to the International Space Station. Glover is a commander in the U.S. Navy where he pilots an F/A-18.He was a crew member of Expedition 64, and served as a station systems flight engineer. ", 
                Image = "/assets/crew/image-victor-glover.png", 
                ImageAlt = "the pilot"}, 
            new Member{Index = 3, 
                Name = "Anousheh Ansari", 
                Title = "Flight Engineer", 
                Description = "Anousheh Ansari is an Iranian American engineer and co-founder of Prodea Systems. Ansari was the fourth self-funded space tourist, the first self-funded woman to fly to the ISS, and the first Iranian in space. ", 
                Image = "/assets/crew/image-anousheh-ansari.png", 
                ImageAlt = "the engineer"}, };
        int tabPosition = 0;
        int targetPanel = 0;
        private void ChangeTabFocus(KeyboardEventArgs e)
        {
            if (e.Key == "ArrowRight")
            {
                tabPosition++;
                if (tabPosition >= CrewMembers.Count)
                {
                    tabPosition = 0;
                }
            }
            else if (e.Key == "ArrowLeft")
            {
                tabPosition--;
                if (tabPosition < 0)
                {
                    tabPosition = CrewMembers.Count - 1;
                }
            }

            targetPanel = tabPosition;
        }

        private void ChangeTabPanel(int index)
        {
            tabPosition = index;
            targetPanel = tabPosition;
        }
    }
}