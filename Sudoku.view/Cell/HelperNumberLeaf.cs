using Sudoku.data.Cells.@abstract;
using Sudoku.view.Cell.Composit;

namespace Sudoku.view.Cell;

public class HelperNumberLeaf : CellComponent
{
    private readonly List<CellComponent> _cells = new();

    public void Add(CellComponent cell)
    {
        if (_cells.Count < 9)
        {
            _cells.Add(cell);
        }
        else
        {
            throw new InvalidOperationException("Cannot add more than 9 helpnumbers to a HelperNumberLeaf.");
        }
    }

    public void Remove(CellComponent cell)
    {
        _cells.Remove(cell);
    }

    public override void Draw()
    {
        var counter = 0;
        foreach (var cellComponent in _cells)
        {
            cellComponent.Draw();
            counter++;
        }
        for (int i = counter; i < 9; i++)
        {
            Console.Write(" ");
        }
    }
}