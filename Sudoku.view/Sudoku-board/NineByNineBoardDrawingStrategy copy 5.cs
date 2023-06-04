using Sudoku.data.Boards.Enum;
using Sudoku.view.Cell;
using Sudoku.view.Sudoku_board.Abstract;

namespace Sudoku.view.Sudoku_board
{
    public class NineByNineBoardDrawingStrategy : SudokuBoardView
    {
        public NineByNineBoardDrawingStrategy(SudokuDisplayMode displayoptions, string type, List<List<CellView>> cells) : base(displayoptions, type, cells)
        {
        }

        public override void Draw()
        {
        }
    }
}