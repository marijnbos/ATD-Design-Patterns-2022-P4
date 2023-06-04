using Sudoku.data.Cells.@abstract;
using Sudoku.data.Color;

namespace Sudoku.data.Cells;

public class EmptyCell : ProductCell
{
    private char _value;
    public EmptyCell(int group, char value) : base(group, value)
    {
    }
    public override char Value
    {
        get => _value;
        set => _value = ' ';
    }

    public override ColorEnum getCollor()
    {
        return ColorEnum.White;
    }



}