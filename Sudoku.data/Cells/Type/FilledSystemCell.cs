using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.@enum;
using Sudoku.data.Color;

namespace Sudoku.data.Cells;

public class FilledSystemCell : ProductCell
{
    private char _value;

    public override char Value
    {
        get => _value;
        set => _value = value;
    }

    public override ColorEnum getColor()
    {
        return ColorEnum.Yellow;
    }

    public FilledSystemCell(int group, char value, bool selected, CellState state, List<int> helperNumbers) : base(
        group, value, selected, state, helperNumbers)
    {
    }
}