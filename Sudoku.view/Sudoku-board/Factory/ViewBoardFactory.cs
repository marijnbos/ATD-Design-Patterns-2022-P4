using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.view.Sudoku_board.Abstract;

namespace Sudoku.view.Sudoku_board.Factory;

public class ViewBoardFactory : CreatorViewBoard
{
    public override SudokuBoardView factorMethod(Board board)
    {
        return board.Type switch
        {
            SudokuTypes.Jigsaw => new JigsawBoardDrawingStrategy(board),
            SudokuTypes.Samurai => new SamuraiBoardDrawingStrategy(board),
            SudokuTypes.FourByFour => new FourByFourBoardDrawingStrategy(board),
            SudokuTypes.SixBySix => new SixBySixDrawingStrategy(board),
            SudokuTypes.NineByNine => new NineByNineBoardDrawingStrategy(board),
            _ => throw new NotImplementedException()
        };
    }

}