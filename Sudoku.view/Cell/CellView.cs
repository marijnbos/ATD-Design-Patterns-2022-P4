using Sudoku.data.Cells.@abstract;
using Sudoku.data.Color;
using Sudoku.view.Cell.Composit;

namespace Sudoku.view.Cell;

public class CellView : IView
{
    public char _cell { get; set; }
    public ColorEnum _colorEnum { get; set; }
    public bool _isHighlighted { get; set; }
    public HelperNumberLeaf _helperNumberLeaf { get; set; }
    public int group { get; set; }


    public CellView(ProductCell cell)
    {
        _cell = cell.Value;
        _colorEnum = cell.getCollor();
        _isHighlighted = cell.Selected;
        _helperNumberLeaf = new HelperNumberLeaf();
        foreach (var helper in cell.HelperNumbers) _helperNumberLeaf.Add(new HelperNumberViewComponent(helper));
        group = cell.Group;
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
        if (_cell == '0' || _cell == ' ')
        {
            Console.Write(" ");
            _helperNumberLeaf.Draw();
        }
        else
        {
            for (var i = 0; i < 9; i++)
            {
                Console.Write(" ");
                if (i == 4)
                    Console.Write(_cell);
            }
        }

        Console.ResetColor();
    }
}