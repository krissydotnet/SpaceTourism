using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SpaceTourism.Models;

namespace SpaceTourism.Pages
{
    public partial class Crew
    {
        
        int tabPosition = 0;
        int targetPanel = 0;

        private IEnumerable<Member>? CrewMembers;
        private Member? TargetCrew;



        protected override async Task OnInitializedAsync()
        {
            CrewMembers = await crewDataService.GetAll();
            TargetCrew = CrewMembers.Where(x => x.Index == targetPanel).FirstOrDefault();
        }


        private void ChangeTabFocus(KeyboardEventArgs e)
        {
            if (e.Key == "ArrowRight")
            {
                tabPosition++;
                if (tabPosition >= CrewMembers.Count())
                {
                    tabPosition = 0;
                }
            }
            else if (e.Key == "ArrowLeft")
            {
                tabPosition--;
                if (tabPosition < 0)
                {
                    tabPosition = CrewMembers.Count() - 1;
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
            if (CrewMembers != null)
            {
                TargetCrew = CrewMembers.Where(x => x.Index == targetPanel).FirstOrDefault();
            }
        }
    }
}