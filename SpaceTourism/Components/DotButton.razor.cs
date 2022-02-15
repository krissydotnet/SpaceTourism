using Microsoft.AspNetCore.Components;

namespace SpaceTourism.Components
{
    public partial class DotButton
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public bool Active { get; set; }
    }
}