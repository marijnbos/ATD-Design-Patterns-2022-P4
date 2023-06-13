using Sudoku.view.Cell.Composit;

namespace Sudoku.view.Cell;

public class HelperNumberViewComponent : CellComponent
{
    public override void Draw()
    {
        Console.Write(Value);
    }

    public HelperNumberViewComponent(int value)
    {
        Value = value;
    }
}