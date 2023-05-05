using Sudoku.data.Color;

namespace Sudoku.view.Cell;

public class CellView : IView
{
    char _cell;
    ColorEnum _colorEnum;
    bool _isHighlighted;
    
    public CellView (char cell, ColorEnum colorEnum, bool isHighlighted)
    {
        _cell = cell;
        _colorEnum = colorEnum;
        _isHighlighted = isHighlighted;
    }
    public void Draw()
    {
      //  Console.ForegroundColor(_colorEnum.ToString());
        Console.Write(_cell);
    }
}