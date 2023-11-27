using Blazor_M5_L12.Models;
using Microsoft.AspNetCore.Components;
using System.ComponentModel;

namespace Blazor_M5_L12.Components
{
    public partial class Item
    {
        [Parameter]
        public int Id { get; set; }

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public string Note { get; set; }

        [CascadingParameter]
        KanbanBoard Container { get; set; }

        [Parameter]
        public ItemModel ItemModel { get; set; }

        private void HandleDragStart(ItemModel selectedItem)
        {
            Container.Payload = selectedItem;
        }

    }
}
