using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.@enum;

namespace Sudoku.data.Cells.Factory;

public abstract class CreatorCell
{
    public CreatorCell()
    {

    }

    public abstract ProductCell factorMethod(int group, char cellValue, bool selected, CellState state,
        List<int> helpernumbers);
}