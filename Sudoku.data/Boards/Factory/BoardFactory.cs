using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;

namespace Sudoku.data.Boards.Factory;

public class BoardFactory : CreatorBoard
{
    //wil figire out wich type it is based on the input

    public override Board factorMethod(string cells, SudokuTypes type, SudokuDisplayMode sudokuDisplayMode)
    {
        switch (type)
        {
            case SudokuTypes.Jigsaw:
                return new Jigsaw(cells, sudokuDisplayMode);
            case SudokuTypes.Samurai:
                return new Samurai(cells, sudokuDisplayMode);
            case SudokuTypes.FourByFour:
                return new FourByFour(cells, type, sudokuDisplayMode);
            case SudokuTypes.NineByNine:
                return new NineByNine(cells, sudokuDisplayMode);
            case SudokuTypes.SixBySix:
                return new SixBySix(cells, sudokuDisplayMode);
            default:
                throw new NotImplementedException();
        }
    }
}