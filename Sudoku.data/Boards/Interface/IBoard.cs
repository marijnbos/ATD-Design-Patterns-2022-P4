namespace Sudoku.data.Boards;

public interface IBoard
{
    List<List<ICell>> Cells { get; set; }
}
