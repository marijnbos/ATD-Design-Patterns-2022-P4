namespace Sudoku.data.Boards;

public class Board : IBoard
{
    public List<List<ICell>> Cells { get; set; }
}