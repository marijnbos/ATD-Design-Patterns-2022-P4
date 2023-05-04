using Sudoku.data.Position;

namespace Sudoku.data.Boards;

public interface IBoard
{
    uint NumberOfGroups { get; set; }
    List<List<Cell>> Cells { get; set; }
    public IBoard copy();

}