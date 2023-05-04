using Sudoku.data.Color;

namespace Sudoku.data.Cells;

public class FilledSystemCell : Cell
{
    private char _value;

    public override char value
    {
        get => _value;
        set => _value = value;
    }

    public override ColorEnum getCollor()
    {
       return ColorEnum.Yellow;
    }

    public FilledSystemCell(int group) : base(group)
    {
    }
}