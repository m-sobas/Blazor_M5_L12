using Blazor_M5_L12.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Reflection;

namespace Blazor_M5_L12.Components
{
    public partial class KanbanBoard
    {
        [Parameter]
        public List<ItemModel> Items { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter] 
        public EventCallback<ItemModel> OnStatusUpdated { get; set; }

        public ItemModel Payload { get; set; }

        public async Task UpdateItemAsync(StateType State)
        {
            var task = Items.SingleOrDefault(x => x.Id == Payload.Id);
            
            if (task != null)
            {
                task.StateType = State;
                await OnStatusUpdated.InvokeAsync(Payload);
            }
        }
    }
}
