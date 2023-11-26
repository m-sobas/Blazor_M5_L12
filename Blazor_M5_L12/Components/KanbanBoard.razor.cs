using Blazor_M5_L12.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Reflection;
using static Blazor_M5_L12.Models.EnumHelper;

namespace Blazor_M5_L12.Components
{
    public partial class KanbanBoard
    {
        private StateType _state = StateType.Doing;
        private string _test = "";
        private string _style_drag_ToDo = "";
        private string _style_drag_Doing = "";
        private string _style_drag_Done = "";

        private void OnDragOverToDo()
        {
            _test = "DRAG OVER!";
            _style_drag_ToDo = "dragover";
        }

        private void OnDragLeaveToDo(DragEventArgs e)
        {
            _test = "";
            _style_drag_ToDo = "dragleave";
        }

        private void OnDragOverDoing()
        {
            _test = "DRAG OVER!";
            _style_drag_Doing = "dragover";
        }

        private void OnDragLeaveDoing()
        {
            _test = "";
            _style_drag_Doing = "dragleave";
        }

        private void OnDragOverDone()
        {
            _test = "DRAG OVER!";
            _style_drag_Done = "dragover";
        }

        private void OnDragLeaveDone()
        {
            _test = "";
            _style_drag_Done = "dragleave";
        }

        private void OnDragStart(DragEventArgs e) 
        {
            _test = "DRAG START...";
        }

        private void OnDropDoing(DragEventArgs e)
        {            
            _test = "DROP DOWN!";
        }


    }
}
