using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Cells.@abstract;

namespace Sudoku.data.Boards.Factory;

public abstract class CreatorBoard
{
    public abstract Board factorMethod(List<List<ProductCell>> cells, SudokuTypes type, SudokuDisplayMode sudokuDisplayMode);
}