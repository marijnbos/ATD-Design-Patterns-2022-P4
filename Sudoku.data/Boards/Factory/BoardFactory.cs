using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;

namespace Sudoku.data.Boards.Factory;

public class BoardFactory : CreatorBoard
{
    //wil figire out wich type it is based on the input

    public override Board factorMethod(string cells, string type, SudokuDisplayMode sudokuDisplayMode)
    {
        if (boardTypes.ContainsKey(type))
        {
            var board = (Board) Activator.CreateInstance(boardTypes[type], cells, sudokuDisplayMode);
            return board ?? throw new InvalidOperationException();
        }

        throw new NotImplementedException("unsupported board type");
    }
}