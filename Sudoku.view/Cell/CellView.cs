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
            Console.BackgroundColor = (ConsoleColor) _colorEnum;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        else
        {
            Console.ForegroundColor = (ConsoleColor) _colorEnum;
        }

        //only show the helper numbers in the right state
        if (_cell == '0')
        {
            Console.Write(" ");
            _helperNumberLeaf.Draw();
            
        }
        else
        {
            // _helperNumberLeaf.Draw();
            for (int i = 0; i < 9; i++)
            {
                Console.Write(" ");
                if (i == 4)
                    Console.Write(_cell);
            }
        }

        Console.ResetColor();
    }
}