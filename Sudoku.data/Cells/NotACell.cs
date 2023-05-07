using Sudoku.data.Color;

namespace Sudoku.data.Cells;

public class NotACell : Cell
{
    private char _value;

    public override char value
    {
        get => _value;
        set => _value = 'x';
    }
    public override ColorEnum getCollor()
    {
        return ColorEnum.Black;
    }

    public NotACell(int group) : base(group)
    {
    }
}