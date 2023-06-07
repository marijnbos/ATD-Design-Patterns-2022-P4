using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;

namespace Sudoku.data.Boards.Factory;

public abstract class CreatorBoard
{
    public abstract Board factorMethod(string cells, SudokuTypes type, SudokuDisplayMode sudokuDisplayMode);
}