using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.@enum;
using Sudoku.data.Color;

namespace Sudoku.data.Cells;

public class EmptyCell : ProductCell
{
    private char _value;
    public EmptyCell(int group, char value, bool selected, CellState state) : base(group, value, selected, state)
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