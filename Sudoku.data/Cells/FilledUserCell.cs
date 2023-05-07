using Sudoku.data.Color;

namespace Sudoku.data.Cells;

public class FilledUserCell : Cell
{
    private char _value;

    public override char value
    {
        get => _value;
        set => _value = value;
    }
    public override ColorEnum getCollor()
    {
        return ColorEnum.White;
    }

    public FilledUserCell(int group) : base(group)
    {
    }
}