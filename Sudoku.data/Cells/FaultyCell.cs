using Sudoku.data.Cells.@abstract;
using Sudoku.data.Color;

namespace Sudoku.data.Cells;

public class FaultyCell : ProductCell
{
    private char _value;

    public override char Value
    {
        get => _value;
        set => _value = value;
    }

    public override ColorEnum getCollor()
    {
        return ColorEnum.Red;
    }

    public FaultyCell(int group, char value) : base(group, value)
    {
    }
}