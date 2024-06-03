using Newtonsoft.Json;
using HRM.Client.Models;
using Microsoft.AspNetCore.Components;

namespace HRM.Client.Components.Layout
{
    public partial class MainLayout
    {
        [Inject] private HttpClient Http { get; set; } 
        public List<MenuModel> ListMenus { get; set; } = new List<MenuModel>();
        protected override async Task OnInitializedAsync()
        {
            try
            {
                ListMenus = await Http!.GetFromJsonAsync<List<MenuModel>>("https://localhost:7162/data/dataMenu.json") ?? new List<MenuModel>();
            }
            catch (Exception) { }
            base.OnInitialized();
        }
    }
}
