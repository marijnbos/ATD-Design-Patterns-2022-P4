using Sudoku.view.Cell;

namespace Sudoku.view.Sudoku_board
{
    public class FourByFourBoardDrawingStrategy : SudokuBoardView
    {
        public FourByFourBoardDrawingStrategy(string displayoptions, string type, List<List<CellView>> cells) : base(displayoptions, type, cells)
        {
        }

        public override void Draw()
        {
        }
    }
}