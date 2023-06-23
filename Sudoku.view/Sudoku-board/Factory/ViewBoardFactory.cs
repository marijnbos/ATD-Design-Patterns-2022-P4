using Sudoku.data.Boards;
using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.view.Sudoku_board.Abstract;

namespace Sudoku.view.Sudoku_board.Factory;

public class ViewBoardFactory : CreatorViewBoard
{
    public override SudokuBoardView factorMethod(Board board)
    {
        return board switch
        {
            NineByNine => new NineByNineBoardDrawingStrategy(board),
            SixBySix => new SixBySixDrawingStrategy(board),
            FourByFour => new FourByFourBoardDrawingStrategy(board),
            Samurai => new SamuraiBoardDrawingStrategy(board),
            Jigsaw => new JigsawBoardDrawingStrategy(board),
            _ => throw new NotImplementedException()
        };
    }
}