using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using SpaceTourism;
using SpaceTourism.Shared;
using SpaceTourism.Components;
using SpaceTourism.Models;

namespace SpaceTourism.Pages
{
    public partial class Destination
    {
        public List<SpaceDestination> Destinations = new List<SpaceDestination>() {new SpaceDestination{Active=false, Name = "Moon", Description = "See our planet as you’ve never seen it before. A perfect relaxing trip away to help regain perspective and come back refreshed. While you’re there, take in some history by visiting the Luna 2 and Apollo 11 landing sites", Image = "./assets/destination/image-moon.png", ImageAlt="the moon", Distance = "384,400 km", Travel = "3 days"}, 
            new SpaceDestination{Active=true,Name = "Mars", Description = "Don’t forget to pack your hiking boots. You’ll need them to tackle Olympus Mons, the tallest planetary mountain in our solar system. It’s two and a half times the size of Everest!", Image = "./assets/destination/image-mars.png", ImageAlt="Mars", Distance = "225 mil. km", Travel = "9 months"}, 
            new SpaceDestination{Active=false,Name = "Europa", Description = "The smallest of the four Galilean moons orbiting Jupiter, Europa is a winter lover’s dream. With an icy surface, it’s perfect for a bit of ice skating, curling, hockey, or simple relaxation in your snug wintery cabin.", Image = "./assets/destination/image-europa.png", ImageAlt="Europa", Distance = "628 mil. km", Travel = "3 years"}, 
            new SpaceDestination{Active=false,Name = "Titan", Description = "The only moon known to have a dense atmosphere other than Earth, Titan is a home away from home (just a few hundred degrees colder!). As a bonus, you get striking views of the Rings of Saturn.", Image = "./assets/destination/image-titan.png", Distance = "1.6 bil. km",ImageAlt="Titan", Travel = "7 years"}};

        int tabPosition = 0;
        int targetPanel = 0;
        bool IsHidden = false;
        private void ChangeTabFocus(KeyboardEventArgs e)
        {
            if (e.Key == "ArrowRight" || e.Key == "ArrowLeft")
            {
                tabPosition++;
                if(tabPosition >= Destinations.Count)
                {
                    tabPosition = 0;
                }
            }
            Console.WriteLine("Keydown event " + tabPosition);
        }

        private void ChangeTabPanel(MouseEventArgs args)
        {
            targetPanel = tabPosition;
        }

    }
}