using Sudoku.data.Color;

namespace Sudoku.data.Cells;

public class EmptyCell : ProductCell
{
    private char _value;

    public override char value
    {
        get => _value;
        set => _value = ' ';
    }

    public override ColorEnum getCollor()
    {
        return ColorEnum.White;
    }

    public EmptyCell(int group) : base(group)
    {
    }
}