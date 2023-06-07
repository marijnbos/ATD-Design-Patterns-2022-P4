using Sudoku.data.Cells.@abstract;
using Sudoku.data.Color;

namespace Sudoku.view.Cell;

public class CellView : IView
{
    char _cell;
    ColorEnum _colorEnum;
    bool _isHighlighted;
    public uint cluster;

    public CellView(ProductCell cell)
    {
        _cell = cell.Value;
        _colorEnum = cell.getCollor();
        _isHighlighted = cell.Selected;
    }
    public void Draw()
    {
        if (_isHighlighted)
        {
            Console.BackgroundColor = (ConsoleColor)_colorEnum;
            if(_colorEnum == ColorEnum.Red)
            throw new Exception("asdfasd");
            Console.ForegroundColor = ConsoleColor.Black;
        }
        else
        {
            Console.ForegroundColor = (ConsoleColor)_colorEnum;
        }

        Console.Write(_cell);
        Console.ResetColor();
    }
}