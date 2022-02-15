using Microsoft.AspNetCore.Components;

namespace SpaceTourism.Components
{
    public partial class NumberedTitle
    {
        [Parameter]
        public int TitleNumber { get; set; }

        [Parameter]
        public RenderFragment? ChildContent { get; set; }



    }
}