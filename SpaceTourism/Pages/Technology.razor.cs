using Microsoft.AspNetCore.Components.Web;
using SpaceTourism.Models;

namespace SpaceTourism.Pages
{
    public partial class Technology
    {
        public List<Terminology> Terms = new List<Terminology>()
        {new Terminology{Index = 0, Term = "Launch Vehicle", Definition = "A launch vehicle or carrier rocket is a rocket-propelled vehicle used to carry a payload from Earth's surface to space, usually to Earth orbit or beyond. Our WEB-X carrier rocket is the most powerful in operation. Standing 150 metres tall, it's quite an awe-inspiring sight on the launch pad!", ImagePortrait = "/assets/technology/image-launch-vehicle-portrait.jpg", ImageLandscape = "/assets/technology/image-launch-vehicle-landscape.jpg", ImageAlt = "the launch vehicle"}, new Terminology{Index = 1, Term = "Space capsule", Definition = "A space capsule is an often-crewed spacecraft that uses a blunt-body reentry capsule to reenter the Earth's atmosphere without wings. Our capsule is where you'll spend your time during the flight. It includes a space gym, cinema, and plenty of other activities to keep you entertained.", ImagePortrait = "/assets/technology/image-space-capsule-portrait.jpg", ImageLandscape = "/assets/technology/image-space-capsule-landscape.jpg", ImageAlt = "capsule"}, new Terminology{Index = 2, Term = "Spaceport", Definition = "A spaceport or cosmodrome is a site for launching (or receiving) spacecraft, by analogy to the seaport for ships or airport for aircraft. Based in the famous Cape Canaveral, our spaceport is ideally situated to take advantage of the Earth’s rotation for launch.", ImagePortrait = "/assets/technology/image-spaceport-portrait.jpg", ImageLandscape = "/assets/technology/image-spaceport-landscape.jpg", ImageAlt = "spaceport"}, };
        int tabPosition = 0;
        int targetPanel = 0;
        private void ChangeTabFocus(KeyboardEventArgs e)
        {
            if (e.Key == "ArrowRight")
            {
                tabPosition++;
                if (tabPosition >= Terms.Count)
                {
                    tabPosition = 0;
                }
            }
            else if (e.Key == "ArrowLeft")
            {
                tabPosition--;
                if (tabPosition < 0)
                {
                    tabPosition = Terms.Count - 1;
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