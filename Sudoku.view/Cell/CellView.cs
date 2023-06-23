using Sudoku.data.Cells.@abstract;
using Sudoku.data.Color;
using Sudoku.view.Cell.Composit;

namespace Sudoku.view.Cell;

public class CellView : IView
{
    public char _cell { get; set; }
    private ColorEnum ColorEnum { get; set; }
    private bool IsHighlighted { get; set; }
    private HelperNumberLeaf HelperNumberLeaf { get; set; }
    public int Group { get; set; }


    public CellView(ProductCell cell)
    {
        _cell = cell.Value;
        ColorEnum = cell.getColor();
        IsHighlighted = cell.Selected;
        HelperNumberLeaf = new HelperNumberLeaf();
        foreach (var helper in cell.HelperNumbers) HelperNumberLeaf.Add(new HelperNumberViewComponent(helper));
        Group = cell.Group;
    }

    public void Draw()
    {
        if (IsHighlighted)
        {
            Console.BackgroundColor = (ConsoleColor) ColorEnum;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        else
        {
            Console.ForegroundColor = (ConsoleColor) ColorEnum;
        }

        //only show the helper numbers in the right state
        if (_cell == '0' || _cell == ' ')
        {
            Console.Write(" ");
            HelperNumberLeaf.Draw();
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