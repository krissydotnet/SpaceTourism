using Microsoft.AspNetCore.Components.Web;
using System.Net.Http.Json;
using SpaceTourism.Models;

namespace SpaceTourism.Pages
{
    public partial class Technology
    {
        int tabPosition = 0;
        int targetPanel = 0;

        private List<Terminology>? Terms;
        protected override async Task OnInitializedAsync()
        {
            var randomid = Guid.NewGuid().ToString();
            var url_get = $"data/tech.json?{randomid}";
            Terms = await Http.GetFromJsonAsync<List<Terminology>>(url_get);
        }

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