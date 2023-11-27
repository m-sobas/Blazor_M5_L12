namespace Blazor_M5_L12.Models
{
    public class ItemModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Note { get; set; }

        public StateType StateType { get; set; }
    }

    public enum StateType
    {
        ToDo,
        Doing,
        Done
    }
}
