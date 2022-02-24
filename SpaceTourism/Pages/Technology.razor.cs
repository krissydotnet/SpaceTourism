using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SpaceTourism.Models;

namespace SpaceTourism.Pages
{
    public partial class Technology
    {
        int tabPosition = 0;
        int targetPanel = 0;

        private IEnumerable<Terminology>? Terms;
        private Terminology? TargetTerm;


        protected override async Task OnInitializedAsync()
        {

            Terms = await terminologyDataService.GetAll();
            TargetTerm = Terms.Where(x=> x.Index == targetPanel).FirstOrDefault();
        }
       
        private void ChangeTabFocus(KeyboardEventArgs e)
        {
            if (e.Key == "ArrowRight")
            {
                tabPosition++;
                if (tabPosition >= Terms.Count())
                {
                    tabPosition = 0;
                }
            }
            else if (e.Key == "ArrowLeft")
            {
                tabPosition--;
                if (tabPosition < 0)
                {
                    tabPosition = Terms.Count() - 1;
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
            if (Terms != null)
            {
                TargetTerm = Terms.Where(x => x.Index == targetPanel).FirstOrDefault();
            }
        }
    }
}