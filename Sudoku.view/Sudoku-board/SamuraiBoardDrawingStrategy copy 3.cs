using Sudoku.view.Cell;

namespace Sudoku.view.Sudoku_board
{
    public class SamuraiBoardDrawingStrategy : SudokuBoardView
    {
        public SamuraiBoardDrawingStrategy(string displayoptions, string type, List<List<CellView>> cells) : base(displayoptions, type, cells)
        {
        }

        public override void Draw()
        {
            // Draw the board in the standard way
        }
    }
}