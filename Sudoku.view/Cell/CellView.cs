using Sudoku.data.Cells.@abstract;
using Sudoku.data.Color;
using Sudoku.view.Cell.Composit;

namespace Sudoku.view.Cell;

public class CellView : IView
{
    char _cell;
    ColorEnum _colorEnum;
    bool _isHighlighted;
    HelperNumberLeaf _helperNumberLeaf;
    

    public CellView(ProductCell cell)
    {
        _cell = cell.Value;
        _colorEnum = cell.getCollor();
        _isHighlighted = cell.Selected;
        _helperNumberLeaf = new HelperNumberLeaf();
        foreach (var helper in cell.HelperNumbers)
        {
            _helperNumberLeaf.Add(new HelperNumberViewComponent(helper));
        }
        
       
    }
    public void Draw()
    {
        if (_isHighlighted)
        {
            Console.BackgroundColor = (ConsoleColor)_colorEnum;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        else
        {
            Console.ForegroundColor = (ConsoleColor)_colorEnum;
        }

        if (_cell == ' ')
        {
            _helperNumberLeaf.Draw();
            Console.Write(" "); // print space after helper numbers
        }
        else
        {
            Console.Write(_cell);
        }
        
        Console.ResetColor();
    }
}