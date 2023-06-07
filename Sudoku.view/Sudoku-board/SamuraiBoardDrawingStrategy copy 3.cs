using Sudoku.data.Boards.@abstract;
using Sudoku.view.Sudoku_board.Abstract;

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