using Sudoku.data.Cells.@abstract;

namespace Sudoku.data.Cells.Factory;

public abstract class CreatorCell
{
    public CreatorCell()
    {

    }

    public abstract ProductCell factorMethod(int group, char cellValue, bool selectedj);
}