using Blazor_M5_L12.Models;
using Blazor_M5_L12.Pages;
using Microsoft.AspNetCore.Components;
using System.ComponentModel;
using System.Globalization;

namespace Blazor_M5_L12.Components
{
    public partial class ItemList
    {

        [CascadingParameter]
        KanbanBoard Container { get; set; }

        [Parameter] 
        public StateType State { get; set; }

        [Parameter] 
        public StateType[] AllowedStates { get; set; }

        private List<ItemModel> Items = new List<ItemModel>();

        protected override void OnParametersSet()
        {
            Items.Clear();
            Items.AddRange(Container.Items.Where(x => x.StateType == State));
        }

        private void HandleDragEnter()
        {
        }

        private void HandleDragLeave()
        {
        }

        private async Task HandleDrop()
        {
            await Container.UpdateItemAsync(State);
        }
    }
}
