namespace Sudoku.data.Cells;

public abstract class CreatorCell
{
    private Dictionary<CellState, Cell> factory { get; set; }
    public abstract Cell factorMethod();
}