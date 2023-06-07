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
        int count = 1;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (_cells.Any(c => c.Value == count))
                {
                    // If the helper number exists, draw it.
                    _cells.First(c => c.Value == count).Draw();
                }
                else
                {
                    // If the helper number does not exist, draw a blank space.
                    Console.Write(" ");
                }
            
                if (j < 2) // if it's not the last number in the row, print a space
                {
                    Console.Write(" ");
                }

                count++;
            }
        
            if (i < 2) // if it's not the last row, print a space for separation
            {
                Console.Write("  ");
            }
        }
    }




   
}