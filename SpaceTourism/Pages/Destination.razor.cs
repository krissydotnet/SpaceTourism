using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Web;
using SpaceTourism.Models;

namespace SpaceTourism.Pages
{
    public partial class Destination
    {
        int tabPosition = 0;
        int targetPanel = 0;
        private List<SpaceDestination>? Destinations;
        protected override async Task OnInitializedAsync()
        {
            var randomid = Guid.NewGuid().ToString();
            var url_get = $"data/destination.json?{randomid}";
            Destinations = await Http.GetFromJsonAsync<List<SpaceDestination>>(url_get);
        }

        private void ChangeTabFocus(KeyboardEventArgs e)
        {
            if (e.Key == "ArrowRight")
            {
                tabPosition++;
                if (tabPosition >= Destinations.Count)
                {
                    tabPosition = 0;
                }
            }
            else if (e.Key == "ArrowLeft")
            {
                tabPosition--;
                if (tabPosition < 0)
                {
                    tabPosition = Destinations.Count - 1;
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