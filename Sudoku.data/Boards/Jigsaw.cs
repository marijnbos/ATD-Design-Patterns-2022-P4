namespace Sudoku.data.Boards;

public class Jigsaw : Board
{
    public Jigsaw(List<List<Cell>> Cells) : base(Cells)
    {
    }

    public override IBoard copy()
    {
        return new Jigsaw(new List<List<Cell>>());
    }
}