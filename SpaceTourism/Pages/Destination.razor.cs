using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SpaceTourism.Models;

namespace SpaceTourism.Pages
{
    public partial class Destination
    {
        int tabPosition = 0;
        int targetPanel = 0;
        private IEnumerable<SpaceDestination>? Destinations;
        private SpaceDestination? TargetDestination;


        protected override async Task OnInitializedAsync()
        {

            Destinations = await destinationDataService.GetAll();
            TargetDestination = Destinations.Where(x => x.Index == targetPanel).FirstOrDefault();
        }
        
        private void ChangeTabFocus(KeyboardEventArgs e)
        {
            if (e.Key == "ArrowRight")
            {
                tabPosition++;
                if (tabPosition >= Destinations.Count())
                {
                    tabPosition = 0;
                }
            }
            else if (e.Key == "ArrowLeft")
            {
                tabPosition--;
                if (tabPosition < 0)
                {
                    tabPosition = Destinations.Count() - 1;
                }
            }

            UpdatePanel();
        }

        private void ChangeTabPanel(int index)
        {
            tabPosition = index;
            UpdatePanel();
        }
        private void UpdatePanel()
        {
            targetPanel = tabPosition;
            if (Destinations != null)
            {
                TargetDestination = Destinations.Where(x => x.Index == targetPanel).FirstOrDefault();
            }
        }
    }
}