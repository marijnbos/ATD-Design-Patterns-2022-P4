namespace Sudoku.data.Boards;

public interface IBoard
{
    uint NumberOfgroups { get; set; }
    List<List<Cell>> Cells { get; set; }
    public IBoard copy();
}