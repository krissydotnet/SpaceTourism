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

namespace SpaceTourism.Components
{
    public partial class NavBar
    {
        [Inject]
        NavigationManager NavigationManager { get; set; }

        protected override void OnInitialized() => NavigationManager.LocationChanged += (s, e) => StateHasChanged();
        bool IsActive(string href, NavLinkMatch navLinkMatch = NavLinkMatch.Prefix)
        {
            var relativePath = NavigationManager.ToBaseRelativePath(NavigationManager.Uri).ToLower();
            return navLinkMatch == NavLinkMatch.All ? relativePath == href.ToLower() : relativePath.StartsWith(href.ToLower());
        }

        string GetActive(string href, NavLinkMatch navLinkMatch = NavLinkMatch.Prefix) => IsActive(href, navLinkMatch) ? "active" : "";
        private bool IsVisible { get; set; } = false;
        protected void Visible(MouseEventArgs mouseEventArgs)
        {
            IsVisible = !IsVisible;
        }
    }
}