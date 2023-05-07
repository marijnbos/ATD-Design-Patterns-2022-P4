using Sudoku.view.Cell;

namespace Sudoku.view
{
    public class SamuraiBoardDrawingStrategy : SudokuBoardView
    {
        public SamuraiBoardDrawingStrategy(string displayoptions, string type, List<List<CellView>> cells) : base(displayoptions, type, cells)
        {
        }

        public void Draw()
        {
            // Draw the board in the standard way
        }
    }
}