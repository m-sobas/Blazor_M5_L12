using Blazor_M5_L12.Components;
using Blazor_M5_L12.Models;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace Blazor_M5_L12.Pages
{
    public partial class Kanban
    {
        private ItemModel _itemModel = new ItemModel();

        public List<ItemModel> Items = new List<ItemModel>();

        string lastUpdatedItem = "";

        protected override void OnInitialized()
        {
            Items.Add(new ItemModel
            {
                Id = 1,
                Title = "Zadanie 1",
                Note = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                StateType = StateType.ToDo
            });

            Items.Add(new ItemModel
            {
                Id = 2,
                Title = "Zadanie 2",
                Note = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                StateType = StateType.ToDo
            });

            Items.Add(new ItemModel
            {
                Id = 3,
                Title = "Zadanie 3",
                Note = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                StateType = StateType.ToDo
            });

            Items.Add(new ItemModel
            {
                Id = 4,
                Title = "Zadanie 4",
                Note = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                StateType = StateType.Doing
            });

            Items.Add(new ItemModel
            {
                Id = 5,
                Title = "Zadanie 5",
                Note = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                StateType = StateType.Done
            });

            Items.Add(new ItemModel
            {
                Id = 6,
                Title = "Zadanie 6",
                Note = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                StateType = StateType.Done
            });
        }

        public void HandleStatusUpdated(ItemModel updatedItem)
        {
            lastUpdatedItem = updatedItem.Note;
        }

        public void AddItem()
        {
            var itemCount = Items.Select(x => x.Id).Max();

            Items.Add(new ItemModel
            {
                Id = ++itemCount,
                Title = _itemModel.Title,
                Note = _itemModel.Note,
                StateType = StateType.ToDo
            });
        }
    }
}
