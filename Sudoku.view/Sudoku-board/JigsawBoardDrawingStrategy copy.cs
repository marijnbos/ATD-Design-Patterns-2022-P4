using Sudoku.view.Cell;

namespace Sudoku.view
{
    public class JigsawBoardDrawingStrategy : SudokuBoardView
    {
        public JigsawBoardDrawingStrategy(string displayoptions, string type, List<List<CellView>> cells) : base(displayoptions, type, cells)
        {
        }

        public void Draw()
        {
        }
    }
}