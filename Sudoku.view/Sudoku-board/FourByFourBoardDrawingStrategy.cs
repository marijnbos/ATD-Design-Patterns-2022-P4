using Sudoku.view.Cell;

namespace Sudoku.view
{
    public class FourByFourBoardDrawingStrategy : SudokuBoardView
    {
        public FourByFourBoardDrawingStrategy(string displayoptions, string type, List<List<CellView>> cells) : base(displayoptions, type, cells)
        {
        }

        public void Draw()
        {
        }
    }
}