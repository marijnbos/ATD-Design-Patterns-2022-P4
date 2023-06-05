using Sudoku.data.Cells.@abstract;
using Sudoku.data.Color;

namespace Sudoku.data.Cells;

public class FilledUserCell : ProductCell
{
    private char _value;

    public override char Value
    {
        get => _value;
        set => _value = value;
    }
    public override ColorEnum getCollor()
    {
        return ColorEnum.White;
    }

    public FilledUserCell(int group, char value, bool selected) : base(group, value, selected)
    {
    }
}