using Sudoku.view.Cell;
using Sudoku.view.Sudoku_board.Abstract;
using Sudoku.data.Boards.@abstract;

namespace Sudoku.view.Sudoku_board
{
    public class SamuraiBoardDrawingStrategy : SudokuBoardView
    {
        public SamuraiBoardDrawingStrategy(Board board) : base(board)
        {
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}