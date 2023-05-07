using Sudoku.view.Cell;

namespace Sudoku.view
{
    public class NineByNineBoardDrawingStrategy : SudokuBoardView
    {
        public NineByNineBoardDrawingStrategy(string displayoptions, string type, List<List<CellView>> cells) : base(displayoptions, type, cells)
        {
        }

        public void Draw()
        {
        }
    }
}