namespace Sudoku.data.Boards;

public class Samurai : Board
{
    public Samurai(List<List<Cell>> Cells) : base(Cells)
    {
    }

    public override IBoard copy()
    {
        return new Jigsaw(new List<List<Cell>>());
    }
}