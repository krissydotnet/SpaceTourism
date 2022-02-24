using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Web;
using SpaceTourism.Models;

namespace SpaceTourism.Pages
{
    public partial class Crew
    {
        
        int tabPosition = 0;
        int targetPanel = 0;

        private List<Member>? CrewMembers;
        protected override async Task OnInitializedAsync()
        {
            var randomid = Guid.NewGuid().ToString();
            var url_get = $"data/crew.json?{randomid}";
            CrewMembers = await Http.GetFromJsonAsync<List<Member>>(url_get);
            //CrewMembers = await FetchCrewContentService.GetAll();
        }

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