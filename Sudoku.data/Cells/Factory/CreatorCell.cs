namespace Sudoku.data.Cells;

public abstract class CreatorCell
{
    private Dictionary<CellState, ProductCell> factory { get; set; }
    public abstract ProductCell factorMethod();
}