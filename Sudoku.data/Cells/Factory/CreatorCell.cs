using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.@enum;

namespace Sudoku.data.Cells.Factory;

public abstract class CreatorCell
{
    private Dictionary<CellState, ProductCell> factory { get; set; }
    public abstract ProductCell factorMethod();
}