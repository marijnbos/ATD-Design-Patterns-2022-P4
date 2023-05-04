namespace Sudoku.data.Cells;

public abstract class Creator
{
    private Dictionary<CellState, Cell> factory { get; set; }
    public abstract Cell factorMethod();
}