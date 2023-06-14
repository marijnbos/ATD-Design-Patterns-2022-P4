using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;

namespace Sudoku.data.Boards;

public class SudokuSolverVisitor : ISudokuSolverVisitor
{
    public void Visit(Board board)
    {
        switch (board.ToString())
        {
            // case SudokuTypes.FourByFour:
            //     Visit((FourByFour)board);
            //     break;
            // case SudokuTypes.SixBySix:
            //     Visit((SixBySix)board);
            //     break;
            // case SudokuTypes.NineByNine:
            //     Visit((NineByNine)board);
            //     break;
            // case SudokuTypes.Jigsaw:
            //     Visit((Jigsaw)board);
            //     break;
            // case SudokuTypes.Samurai:
            //     Visit((Samurai)board);
            //     break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public void Visit(FourByFour fourByFour)
    {
        SolveSudoku(fourByFour.Cells);
    }

    private void SolveSudoku(List<List<ProductCell>> cells)
    {
        throw new NotImplementedException();
    }

    public void Visit(NineByNine nineByNine)
    {
        throw new NotImplementedException();
    }

    public void Visit(Jigsaw jigsaw)
    {
        throw new NotImplementedException();
    }

    public void Visit(Samurai samurai)
    {
        throw new NotImplementedException();
    }

    public void Visit(SixBySix sixBySix)
    {
        throw new NotImplementedException();
    }
}