using Sudoku.data.Cells.@abstract;
using Sudoku.data.Color;

namespace Sudoku.data.Cells;

public class NotACell : ProductCell
{
    private char _value;

    public override char Value
    {
        get => _value;
        set => _value = 'x';
    }
    public override ColorEnum getCollor()
    {
        return ColorEnum.Black;
    }

    public NotACell(int group, char value) : base(group, value)
    {
    }
}