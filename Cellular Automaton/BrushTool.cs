using SFML.Graphics;
using SFML.Window;

namespace Cellular_Automaton
{
    internal class BrushTool : ToolType
    {
        private bool isButtonPressed = false;
        public override void HandleMouseButtonPressed(Form1 form, MouseButtonEventArgs e, ToolOptions options)
        {
            base.HandleMouseButtonPressed(form, e, options);
            if(e.Button == Mouse.Button.Left)
            {
                isButtonPressed = true;
            }
            PlaceCreaturesOnBoard(form, e.X, e.Y, options);
        }
        public override void HandleMouseButtonReleased(Form1 form, MouseButtonEventArgs e, ToolOptions options)
        {
            base.HandleMouseButtonReleased(form, e, options);
            if (e.Button == Mouse.Button.Left)
            {
                isButtonPressed = false;
            }
        }
        public override void HandleMouseButtonMoved(Form1 form, MouseMoveEventArgs e, ToolOptions options)
        {
            base.HandleMouseButtonMoved(form, e, options);
            PlaceCreaturesOnBoard(form, e.X, e.Y, options);
        }
        public void PlaceCreaturesOnBoard(Form1 form, int mousePosX, int mousePosY, ToolOptions options)
        {
            if (isButtonPressed)
            {
                //TODO: utilize brushthickness
                int boardX = mousePosX / (int)(form.GetCanvas().RendWind.Size.X / form.BoardSize);
                int boardY = mousePosY / (int)(form.GetCanvas().RendWind.Size.Y / form.BoardSize);
                if (boardX < 0 || boardX >= form.board.GetLength(0)) return;
                if (boardY < 0 || boardY >= form.board.GetLength(1)) return;
                switch (options.CreatureType)
                {
                    case CreatureType.Predator:
                        form.board[boardX, boardY] = new Predator();
                        break;
                    case CreatureType.Prey:
                        form.board[boardX, boardY] = new Prey();
                        break;
                }
            }
        }
    }
}