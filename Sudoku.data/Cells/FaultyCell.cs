using Sudoku.data.Color;

namespace Sudoku.data.Cells;

public class FaultyCell : Cell
{
    private char _value;

    public override char value
    {
        get => _value;
        set => _value = value;
    }

    public override ColorEnum getCollor()
    {
        return ColorEnum.Red;
    }

    public FaultyCell(int group) : base(group)
    {
    }
}