using Sudoku.data.Color;

namespace Sudoku.view.Cell;

public class CellView : IView
{
    char _cell;
    ColorEnum _colorEnum;
    bool _isHighlighted;
    public uint cluster;
    
    public CellView (char cell, ColorEnum colorEnum, bool isHighlighted, uint cluster)
    {
        _cell = cell;
        _colorEnum = colorEnum;
        _isHighlighted = isHighlighted;
        this.cluster = cluster;
    }
    public void Draw()
    {
      //  Console.ForegroundColor(_colorEnum.ToString());
        Console.Write(_cell);
    }
}