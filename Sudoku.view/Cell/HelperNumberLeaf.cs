using Sudoku.view.Cell.Composit;

namespace Sudoku.view.Cell;

public class HelperNumberLeaf : CellComponent
{
    private readonly List<CellComponent> _cells = new();

    public void Add(CellComponent cell)
    {
        if (_cells.Count <= 9)
        {
            var matchCell = _cells.Find(e => e.Value == cell.Value);

            if (matchCell != null)
            {
                _cells.Remove(matchCell);
                return;
            }

            _cells.Add(cell);
        }
    }


    public void Remove(CellComponent cell)
    {
        _cells.Clear();
    }

    public override void Draw()
    {
        var counter = 0;
        foreach (var cellComponent in _cells)
        {
            cellComponent.Draw();
            counter++;
        }

        for (var i = counter; i < 9; i++) Console.Write(" ");
    }
}