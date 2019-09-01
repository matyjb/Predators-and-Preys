using SFML.Window;

namespace Cellular_Automaton
{
    public abstract class ToolType
    {
        public virtual void HandleMouseButtonPressed(Form1 form, MouseButtonEventArgs e, ToolOptions options) { }
        public virtual void HandleMouseButtonReleased(Form1 form, MouseButtonEventArgs e, ToolOptions options) { }
        public virtual void HandleMouseButtonMoved(Form1 form, MouseMoveEventArgs e, ToolOptions options) { }
        public virtual void DrawPreview(Form1 form, ToolOptions options) { }
    }
    public enum CreatureType
    {
        None,
        Predator,
        Prey
    }
    public class ToolOptions
    {
        public CreatureType CreatureType { get; set; } = 0;
        public uint BrushThickness { get; set; } = 1;
    }
}
